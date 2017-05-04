# Awesome F# #

[![Join the chat at https://gitter.im/VPashkov/awesome-fsharp](https://badges.gitter.im/VPashkov/awesome-fsharp.svg)](https://gitter.im/VPashkov/awesome-fsharp?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

A curated list of awesome F# frameworks, libraries, software and resources.

- [Contents](#awesome-fsharp)
  - [Actor frameworks](#actor-frameworks)
  - [Concurrent, asynchronous and parallel programming](#concurrent-asynchronous-and-parallel-programming)
  - [General purpose libraries](#general-purpose-libraries)
  - [Build tools](#build-tools)
  - [Compilers](#compilers)
  - [Data Science](#data-science)
  - [Type providers](#type-providers)
  - [Creating type providers](#creating-type-providers)
  - [Development Tools](#development-tools)
  - [Editor plugins](#editor-plugins)
  - [IDE](#ide)
  - [Game development](#game-development)
  - [Logging](#logging)
  - [Package Management](#package-management)
  - [Serialization](#serialization)
  - [Testing](#testing)
  - [Web frameworks](#web-frameworks)
  - [.Net Core Templates](#net-core-templates)
  - [Resources](#resources)
  - [Blogs](#blogs)
  - [Cheatsheets](#cheatsheets)
  - [Community](#community)
  - [Other Lists](#other-lists)
  - [Websites](#websites)

## Actor frameworks

* **[Akka.NET ★ 2239 ⧗ 0](https://github.com/akkadotnet/akka.net)** - Community-driven port of the popular Java/Scala framework Akka to .NET. [Apache 2.0]
* [Akkling ★ 45 ⧗ 1](https://github.com/Horusiath/Akkling) - F# typed API for Akka.NET. [Apache 2.0]
* [Cricket ★ 141 ⧗ 380](https://github.com/fsprojects/Cricket) - An actor framework for F#. [Unlicense]
* [Orleankka ★ 175 ⧗ 5](https://github.com/OrleansContrib/Orleankka) - Functional API for Orleans Framework. [Apache 2.0]
* **[Orleans ★ 2754 ⧗ 0](https://github.com/dotnet/orleans)** - Distributed Virtual Actor Model. [MIT]

## Concurrent, asynchronous and parallel programming

* [FSharp.Control.AsyncSeq ★ 28 ⧗ 12](https://github.com/fsprojects/FSharp.Control.AsyncSeq) - collection of asynchronous programming utilities for F# [Apache 2.0]
* [FSharpx.Async ★ 37 ⧗ 56](https://github.com/fsprojects/FSharpx.Async) - collection of asynchronous programming utilities for F# [Apache 2.0]
* [Hopac ★ 268 ⧗ 7](https://github.com/Hopac/Hopac) - concurrent ML style concurrent programming library for F#. [MIT]

## General purpose libraries

* [Aether ★ 71 ⧗ 0](https://github.com/xyncro/aether) - Optics library for F#, similar to the Haskell Data.Lens package. [MIT]
* [Chessie ★ 96 ⧗ 272](https://github.com/fsprojects/Chessie) - railway-oriented programming. [Unlicense]
* [ExtCore ★ 96 ⧗ 0](https://github.com/jack-pappas/ExtCore) - extended core library for F#. [Apache 2.0]
* [FSharpLu ★ 133 ⧗ 20](https://github.com/Microsoft/fsharplu) - lightweight utilities for string manipulations, logging, collection data structures, file operations, text processing, security, async, parsing, diagnostics, configuration files and Json serialization. [MIT]
* [FSharpPlus ★ 142 ⧗ 34](https://github.com/gmpl/FSharpPlus) - extensions for F#. [Apache 2.0]

## Build tools

* **[FAKE ★ 733 ⧗ 0](https://github.com/fsharp/FAKE)** - "F# Make" is a cross platform build automation system. [Apache 2.0]

## Compilers

* [F# Compiler Services ★ 159 ⧗ 0](https://github.com/fsharp/FSharp.Compiler.Service) - The F# Compiler, F# Interactive scripting engine and F# editing services as a component library. [Apache 2.0]
* **[Fable ★ 808 ⧗ 0](https://github.com/fable-compiler/Fable)** - F# to JavaScript Compiler. [Apache 2.0]
* **[FSharp ★ 1549 ⧗ 0](https://github.com/fsharp/fsharp)** - The Open Edition of the F# compiler, core library and tools. [Apache 2.0]
* [FunScript ★ 446 ⧗ 64](https://github.com/ZachBray/FunScript) - F# to JavaScript compiler with JQuery etc. mappings through a TypeScript type provider. [Apache-2.0]
* **[Visual F# ★ 988 ⧗ 0](https://github.com/Microsoft/visualfsharp)** - The Visual F# compiler and tools. [Apache 2.0]

## Configuration

* [Argu ★ 145 ⧗ 0](https://github.com/fsprojects/Argu) - declarative CLI argument/XML configuration parser for F# applications. [MIT]

## Data Science

* [Deedle ★ 347 ⧗ 21](https://github.com/BlueMountainCapital/Deedle) - Deedle: Exploratory data library for .NET [BSD-2-Clause]
* [Deep.Net](http://www.deepml.net) - Deep learning library for F#. Provides symbolic model differentiation, automatic differentiation and compilation to CUDA GPUs. [Apache 2.0]
* [DiffSharp ★ 106 ⧗ 70](https://github.com/DiffSharp/DiffSharp) - DiffSharp is a functional automatic differentiation (AD) library [GPL-3.0]
* [FsLab ★ 97 ⧗ 171](https://github.com/fslaborg/FsLab) - FsLab is a collection of libraries for data-science. It provides a rapid development envi­ronment that lets you write advanced analysis with few lines of production-quality code. [Apache 2.0]
* **[Math.NET ★ 1081 ⧗ 3](https://github.com/mathnet/mathnet-numerics)** - Math.NET Numerics aims to provide methods and algorithms for numerical computations in science, engineering and every day use. F# specific bindings available. [MIT]
* [SIMDArray ★ 42 ⧗ 11](https://github.com/jackmott/SIMDArray) - SIMD enhanced Array extensions for faster computation. [MIT]

## Type providers

* [ApiaryProvider ★ 9 ⧗ 380](https://github.com/fsprojects/ApiaryProvider) - Type provider for Apiary.io. [Apache 2.0]
* [AzureStorageTypeProvider ★ 45 ⧗ 20](https://github.com/fsprojects/AzureStorageTypeProvider) - An F# Azure Type Provider which can be used to explore Blob, Table and Queue Azure Storage assets and easily apply CRUD operations on them. [Unilicense]
* [COM Type Provider ★ 36 ⧗ 330](https://github.com/fsprojects/FSharp.Interop.ComProvider) - A type provider for COM interop. [Unilicense]
* [DynamicsCRMProvider ★ 8 ⧗ 380](https://github.com/fsprojects/DynamicsCRMProvider) - A type provider for Microsoft Dynamics CRM 2011. [Apache 2.0]
* [ExcelProvider ★ 45 ⧗ 75](https://github.com/fsprojects/ExcelProvider) - Excel type provider. [Unilicense]
* [FSharp.Configuration ★ 60 ⧗ 6](https://github.com/fsprojects/FSharp.Configuration) - The project contains type providers for the configuration of .NET projects. Handles AppSettings, ResX, Yaml and Ini files. [Apache 2.0]
* [FSharp.Data ★ 375 ⧗ 8](https://github.com/fsharp/FSharp.Data) - Data science library that contains type providers for CSV, HTML, JSON, XML, and WorldBank data. [Apache 2.0]
* [FSharp.Data.DbPedia ★ 9 ⧗ 379](https://github.com/fsprojects/FSharp.Data.DbPedia) - An F# type provider for DBpedia. [Unilicense]
* [FSharp.Data.HiveProvider ★ 8 ⧗ 379](https://github.com/fsprojects/FSharp.Data.HiveProvider) - A demonstrator F# type provider for Apache Hive. [Apache 2.0]
* [FSharp.Data.SqlClient ★ 121 ⧗ 16](https://github.com/fsprojects/FSharp.Data.SqlClient) - An F# Type Provider for statically typed access to T-SQL command parameters and result set. [Apache 2.0]
* [FSharp.Data.Toolbox ★ 38 ⧗ 7](https://github.com/fsprojects/FSharp.Data.Toolbox) - A library for various data access APIs based on FSharp.Data. The library currently includes the Twitter type provider for access to Twitter users and feeds, and SAS type provider to read SAS dataset files. [Apache 2.0]
* [FSharp.Data.TypeProviders ★ 9 ⧗ 379](https://github.com/fsprojects/FSharp.Data.TypeProviders) - A library that contains type providers for `.edmx` files, `.dbml` files, WSLD services, OData services, and SQL databases. [Unilicense]
* [FSharp.Management ★ 59 ⧗ 1](https://github.com/fsprojects/FSharp.Management) - The project contains various type providers for the management of the machine. Handles file system, registry,  Windows Management Instrumentation, PowerShell and SystemTimeZones. [Apache 2.0]
* [FSharp.Text.RegexProvider ★ 29 ⧗ 285](https://github.com/fsprojects/FSharp.Text.RegexProvider) - A type provider for regular expressions. [Apache 2.0]
* [FsYaml ★ 33 ⧗ 41](https://github.com/bleis-tift/FsYaml) - A typed Yaml library for F#. [NYSL Version 0.9982]
* [GraphProvider ★ 21 ⧗ 379](https://github.com/fsprojects/GraphProvider) - A `.dgml` state machine type provider. [Apache 2.0]
* [MatDataProvider ★ 6 ⧗ 378](https://github.com/fsprojects/matprovider) - An erased type provider for `.mat` files (binary MATLAB format files). [Apache 2.0]
* [R Type Provider ★ 159 ⧗ 365](https://github.com/BlueMountainCapital/FSharpRProvider) - Type provider to interop with R. [BSD-2-Clause]
* [S3Provider ★ 16 ⧗ 379](https://github.com/fsprojects/S3Provider) - Experimental type provider for Amazon S3 [MIT]
* [SQLProvider ★ 192 ⧗ 7](https://github.com/fsprojects/SQLProvider) - A general F# SQL database erasing type provider, supporting LINQ queries, schema exploration, individuals, CRUD operations and much more besides. [Apache 2.0]
* [SwaggerProvider ★ 81 ⧗ 3](https://github.com/fsprojects/SwaggerProvider) - F# generative Type Provider for Swagger. [Unilicense]

### Creating type providers

* [FSharp.TypeProviders.StarterPack ★ 104 ⧗ 42](https://github.com/fsprojects/FSharp.TypeProviders.StarterPack) - The ProvidedTypes SDK for creating F# type providers. [Apache 2.0]
* [RestProvider ★ 14 ⧗ 258](https://github.com/fsprojects/RestProvider) - Create type providers just by implementing a simple REST service [Apache 2.0]

## Development Tools


### IDE

* [MonoDevelop](http://www.monodevelop.com/) - Cross-platform IDE mostly aimed at Mono/.NET developers. [LGPLv2 and X11/MIT]
* [Visual Studio](https://www.visualstudio.com/) - IDE from Microsoft with first class F# support(Windows only). [Proprietary]
* [Xamarin Studio](https://www.xamarin.com/studio) - Advanced IDE for iOS & Android. [Proprietary]

### Editor plugins

* [F# Bindings ★ 321 ⧗ 261](https://github.com/fsharp/fsharpbinding) - Archive of F# Language Bindings for Open Editors. [Apache 2.0]
* [Fantomas ★ 119 ⧗ 5](https://github.com/dungpa/fantomas) - F# code formatter [Apache 2.0]
* [FSharpFar ★ 33 ⧗ 54](https://github.com/nightroman/FarNet) - F# support for Far Manager. [BSD-3-Clause]
* [Ionide](http://ionide.io/) - An Atom Editor and Visual Studio Code package suite for cross platform F# development. [MIT]
* [Vim F# ★ 66 ⧗ 3](https://github.com/fsharp/vim-fsharp) - F# support for Vim. [MIT]
* [VimSpeak ★ 305 ⧗ 910](https://github.com/AshleyF/VimSpeak) - VimSpeak lets you control Vim with your voice using speech recognition. [MIT]
* [Visual F# Power Tools ★ 310 ⧗ 53](https://github.com/fsprojects/VisualFSharpPowerTools) - Power commands for F# in Visual Studio [Apache 2.0]

## Game development

* [FsUnity](https://github.com/FsUnity) - F# Libraries, Tools, and Plugins for the Unity3d Game Engine. [Unilicense]
* **[Nu Game Engine ★ 502 ⧗ 9](https://github.com/bryanedds/Nu)** - Cross-platform F# 2D game engine built in the functional style. Uses SDL2 and Farseer Physics. [MIT]

## Logging

* [Logary ★ 259 ⧗ 0](https://github.com/logary/logary/) - Logary is a high performance, multi-target logging, metric, tracing and health-check library for mono and .Net. [Apache 2.0]

## Package Management

* [NuGet](https://www.nuget.org/) - NuGet is the package manager for the Microsoft development platform including .NET. [Apache 2.0]
* **[Paket ★ 903 ⧗ 0](https://github.com/fsprojects/Paket)** - A dependency manager for .NET with support for NuGet packages and Git repositories. [MIT]

## Serialization

* [FsPickler ★ 195 ⧗ 13](https://github.com/mbraceproject/FsPickler) - A fast, multi-format messaging serializer for .NET [MIT]

## Testing

* [canopy ★ 304 ⧗ 2](https://github.com/lefthandedgoat/canopy) - F# web automation and testing framework. [MIT]
* [Expecto ★ 124 ⧗ 2](https://github.com/haf/expecto) - a smooth testing framework for F# with tests-as-values and parallelism by default. [Apache 2.0]
* [FsCheck ★ 415 ⧗ 34](https://github.com/fscheck/FsCheck) - Random Testing for .NET. [BSD-3-Clause]
* [fsharp-hedgehog ★ 42 ⧗ 4](https://github.com/hedgehogqa/fsharp-hedgehog) - Property-based testing system for F# [Apache 2.0]
* [FsUnit ★ 193 ⧗ 15](https://github.com/fsprojects/FsUnit) - FsUnit makes unit-testing with F# more enjoyable. It adds a special syntax to your favorite .NET testing framework. [???]
* [Persimmon ★ 29 ⧗ 9](https://github.com/persimmon-projects/Persimmon) - A unit test framework for F# using computation expressions. [MIT]
* [unquote ★ 88 ⧗ 17](https://github.com/swensensoftware/unquote) - Write F# unit test assertions as quoted expressions. [Apache 2.0]
* [xUnit.net](https://xunit.github.io/) - Free, open source, community-focused unit testing tool for the .NET Framework. [Apache 2.0]

## Web frameworks

* **[ASP.NET Core MVC ★ 4189 ⧗ 0](https://github.com/aspnet/Mvc)** - ASP.NET Core MVC is a model view controller framework for building dynamic web sites with clean separation of concerns, including the merged MVC, Web API, and Web Pages w/ Razor. [Apache 2.0]
* [Freya ★ 241 ⧗ 7](https://github.com/xyncro/freya) - Modern, purely functional stack for web programming in F#. [Apache 2.0]
* [Giraffe ★ 162 ⧗ 1](https://github.com/dustinmoris/Giraffe) - A native functional ASP.NET Core web framework for F# developers. [Apache 2.0]
* **[Nancy ★ 5133 ⧗ 16](https://github.com/NancyFx/Nancy)** - Lightweight, low-ceremony, framework for building HTTP based services on .Net and Mono. [MIT]
* **[Suave ★ 756 ⧗ 2](https://github.com/SuaveIO/suave)** - Suave is a simple web development F# library providing a lightweight web server and a set of combinators to manipulate route flow and task composition. [Apache 2.0]
* [WebSharper ★ 270 ⧗ 7](https://github.com/intellifactory/websharper) - F#-based web programming platform including a compiler from F# code to JavaScript. [Apache 2.0]

 ## .Net Core Templates
 * [MiniScaffold](https://github.com/TheAngryByrd/MiniScaffold) 
    - F# Template for creating and publishing libraries targeting .NET Full (net45) and Core (netstandard1.6)
    - `dotnet new -i MiniScaffold::*`
 * [Giraffe Template](https://github.com/dustinmoris/Giraffe/tree/master/template) (Quick install: `dotnet new -i "giraffe-template::*"`)
 * [vbfox's F# Templates](https://github.com/vbfox/FSharpTemplates)
    - F# Template for creating github project with appveyor and travis support
 * [Fable, F# |> Bable](http://fable.io) `dotnet new -i Fable.Template::*`
 * [Fable-elmish](https://github.com/fable-compiler/fable-elmish) `dotnet new -i Fable.Template.Elmish.React::*`
 * [Freya](https://freya.io) `dotnet new --install Freya.Template::*`
 * [ASP.NET Core WebAPI F# Template](https://github.com/MNie/FSharpNetCoreWebApiTemplate) `dotnet new -i WebAPI.FSharp.Template::*`
 * [Expecto Template](https://github.com/MNie/Expecto.Template) `dotnet new -i Expecto.Template::1.0.0-beta1`

## Resources


### Blogs

* [Dave Thomas Blog](http://7sharpnine.com/)
* [Don Syme's WebLog on F# and Related Topics](https://blogs.msdn.microsoft.com/dsyme/)
* [Sergey Tihon's Blog](https://sergeytihon.wordpress.com/)
* [Tomas Petricek's Blog](http://tomasp.net/blog/)

### Cheatsheets

* [F# cheatsheet](http://dungpa.github.io/fsharp-cheatsheet)
* [F# tour](https://docs.microsoft.com/en-us/dotnet/articles/fsharp/tour)
* [Learn F# in Y minutes](https://learnxinyminutes.com/docs/fsharp)

### Community

* [F# on Github](https://github.com/fsharp/)
* [F# on IRC](http://webchat.freenode.net/?channels=%23%23fsharp)
* [F# on Slack](http://fsharp.org/guides/slack/)

### Other Lists

* **[Awesome .NET! ★ 4458 ⧗ 2](https://github.com/quozd/awesome-dotnet)** - A collection of awesome .NET libraries, tools, frameworks and software. [CC0 1.0]
* [Awesome Fable](https://github.com/kunjee17/awesome-fable) - curated list of useful Fable tutorials, libraries and software. [CC0 1.0]
* [F# Community Projects](http://fsharp.org/community/projects/)

### Websites

* [Community for F#](http://c4fsharp.net/) - links to dojos and recordings of community presentations.
* [F# for Fun and Profit](https://fsharpforfunandprofit.com/)
* [F# Software Foundation](http://fsharp.org/)
* [Try F#](http://www.tryfsharp.org)

