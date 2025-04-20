#r "nuget: Markdig, 0.41.0"
#r "nuget: Polly.Core, 8.5.2"

open System
open System.Net
open System.Net.Http
open System.Net.Http.Headers
open System.Threading.Tasks
open Markdig
open System.IO
open Markdig.Syntax
open Markdig.Syntax.Inlines
open Polly
open Polly.Retry

let rec visitRecursively (action: MarkdownObject -> unit) (node: MarkdownObject) =
    match node with
    | :? ContainerBlock as c ->
        action c
        c |> Seq.iter(visitRecursively action)
    | :? ContainerInline as i ->
        action i
        i |> Seq.iter(visitRecursively action)
    | :? LeafBlock as lb ->
        action lb
        visitRecursively action lb.Inline
    | other -> action other

let collectLinks node =
    let urls = ResizeArray()
    visitRecursively
        (function
            | :? LinkInline as link ->
                urls.Add link.Url
            | _ -> ()
        )
        node
    urls

let exclusionCodes = Map.ofArray [|
    "https://www.lkokemohr.de/fsharp_godot.html", HttpStatusCode.TooManyRequests // GitHub runner receives this often
|]
let userAgents = Map.ofArray [|
    // Reddit doesn't like when we access it without any user-agent header.
    // Note that this won't work for every other resource; e.g., X doesn't like whe we *pass* the user-agent.
    "https://www.reddit.com/r/fsharp/", "Mozilla/5.0 (compatible; +https://github.com/fsprojects/awesome-fsharp)"
|]

let printLock = Object()
let retryPipeline =
    ResiliencePipelineBuilder()
        .AddRetry(RetryStrategyOptions())
        .Build()
let checkLinkStatus (client: HttpClient) (url: string) = task {
    try
        lock printLock (fun () -> printfn $"Verifying link {url}…")
        let! response = retryPipeline.ExecuteAsync(
            fun _ -> ValueTask<HttpResponseMessage>(task {
                use request = new HttpRequestMessage(HttpMethod.Get, url)
                Map.tryFind url userAgents |> Option.iter(
                    fun ua -> request.Headers.TryAddWithoutValidation("User-Agent", ua) |> ignore
                )
                return! client.SendAsync request
            })
        )
        if response.StatusCode <> HttpStatusCode.OK then
            return
                match Map.tryFind url exclusionCodes with
                | Some code when code = response.StatusCode -> Result.Ok()
                | _ -> Result.Error $"Status code {int response.StatusCode}."
        else
            return Result.Ok()
    with
    | error -> return Result.Error $"Exception {error.Message}"
}

let isNonLocalLink(link: string) =
    if link.StartsWith '#' then false else
    try
        let uri = Uri link
        uri.IsAbsoluteUri
    with
    | error ->
        eprintfn $"Error during parsing link {link}: {error.Message}"
        reraise()

let readmeFilePath = Path.Combine(__SOURCE_DIRECTORY__, "../README.md")

let markdown = File.ReadAllText(readmeFilePath)
let document = Markdown.Parse(markdown, trackTrivia = true)
let links = collectLinks document |> Seq.filter isNonLocalLink

let results = Async.RunSynchronously(async {
    use client = new HttpClient()
    return! links |> Seq.map(fun url -> async {
        let! status = Async.AwaitTask <| checkLinkStatus client url
        return url, status
    }) |> Async.Parallel
})

printfn $"Checked {results.Length} links."

let mutable errorCount = 0
for url, status in results do
    match status with
    | Result.Ok() -> ()
    | Result.Error e ->
        eprintfn $"%s{url}: %s{e}"
        errorCount <- 1

if errorCount <> 0 then
    printfn $"There are {errorCount} errors found."
else
    printfn "Link validation succeeded."

Environment.Exit errorCount
