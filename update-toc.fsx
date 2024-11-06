#r "nuget: Markdig, 0.38.0"

open System
open Markdig
open System.IO
open Markdig.Renderers.Roundtrip
open Markdig.Syntax

let readmeFilePath = Path.Combine(__SOURCE_DIRECTORY__, "README.md")

let markdown = File.ReadAllText(readmeFilePath)
let document = Markdown.Parse(markdown, trackTrivia = true)

let headers =
    document.Descendants<HeadingBlock>()
    |> Seq.skip 2 // The document header and the Table of Contents

let getLink(header: string) =
    let characters =
        header
        |> Seq.choose(function 
            | c when Char.IsLetterOrDigit c -> Some(Char.ToLowerInvariant c)
            | ' ' -> Some '-'
            | _ -> None 
        )
        |> Seq.toArray
    
    "#" + String characters 

let tocText =
    (
        headers
        |> Seq.map(fun h ->
            let text = h.Inline.FirstChild.ToString()
            let indent = String(' ', (h.Level - 2) * 2)
            $"{indent}- [{text}]({getLink text})"
        )
        |> String.concat "\n"
    ) + "\n\n"

let updateHeader (header: HeadingBlock) (newContent: string) =
    let parent = header.Parent
    let index = parent.IndexOf header
    while not (parent[index + 1] :? HeadingBlock) do
        parent.RemoveAt(index + 1)
        
    let newMd = Markdown.Parse(newContent, trackTrivia = true)
    for block in newMd do
        block.Parent.Remove block |> ignore
        parent.Insert(index + 1, block)

let firstHeader =
    document.Descendants<HeadingBlock>()
    |> Seq.find (fun h -> h.Level = 2)

updateHeader firstHeader tocText

File.WriteAllText(readmeFilePath, 
    use sw = new StringWriter()
    let renderer = RoundtripRenderer sw
    renderer.Write document
    sw.ToString()
)
