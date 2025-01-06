# Awesome F# [![Awesome](https://awesome.re/badge.svg)](https://awesome.re) [![Join the chat at https://gitter.im/VPashkov/awesome-fsharp](https://badges.gitter.im/VPashkov/awesome-fsharp.svg)](https://gitter.im/VPashkov/awesome-fsharp?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) <img src="https://fsharp.org/img/logo/fsharp.svg" width="48" height="48" align="right"/>

A curated list of awesome F# frameworks, libraries, software and resources.

## Contents
- [F# wrappers for popular .NET libraries](#f-wrappers-for-popular-net-libraries)
- [Actor frameworks](#actor-frameworks)
- [Build tools](#build-tools)
- [Cloud](#cloud)
- [Code Generation](#code-generation)
- [Compilers](#compilers)
- [Concurrent, asynchronous and parallel programming](#concurrent-asynchronous-and-parallel-programming)
- [Configuration](#configuration)
- [Data Science](#data-science)
- [Development Tools](#development-tools)
  - [IDE](#ide)
  - [Editor plugins](#editor-plugins)
  - [Performance analysis](#performance-analysis)
- [General purpose libraries](#general-purpose-libraries)
- [Game development](#game-development)
- [GUI](#gui)
- [HTTP Clients](#http-clients)
- [Logging](#logging)
- [Package Management](#package-management)
- [Parsing](#parsing)
- [PreCompilation](#precompilation)
- [Serialization](#serialization)
- [Search](#search)
- [Simulation](#simulation)
- [Static site generators](#static-site-generators)
- [Testing](#testing)
- [Type providers](#type-providers)
  - [Creating type providers](#creating-type-providers)
- [Visualization](#visualization)
- [Web frameworks](#web-frameworks)
- [.NET Core Templates](#net-core-templates)
- [Resources](#resources)
  - [Blogs](#blogs)
  - [Books](#books)
  - [Cheatsheets](#cheatsheets)
  - [Community](#community)
  - [Other Lists](#other-lists)
  - [Websites](#websites)
  - [Videos](#videos)
  - [Courses](#courses)

## F# wrappers for popular .NET libraries
Looking to have a more enjoyable experience when consuming a popular .NET library? Here is a quick table.

<!-- The following table includes some entries that are duplicated in the list below. This is by design. -->  
<!--lint disable double-link -->
.NET Library | F# Wrapper
-|-
[Avalonia](https://github.com/AvaloniaUI/Avalonia) | [Avalonia.FuncUI](https://github.com/fsprojects/Avalonia.FuncUI)
[ASP.NET Core](https://github.com/dotnet/aspnetcore) | [Giraffe](https://github.com/giraffe-fsharp/Giraffe) (+ optionally [Saturn](https://github.com/SaturnFramework/Saturn))<br/>[Oxpecker](https://github.com/Lanayx/Oxpecker)
[ASP.NET Core Blazor](https://github.com/dotnet/aspnetcore/tree/main/src/Components) | [Bolero](https://github.com/fsbolero/Bolero)
[MSTest](https://github.com/microsoft/testfx)/[NUnit](https://github.com/nunit/nunit)/[xUnit.net](https://github.com/xunit/xunit) | [FsUnit](https://github.com/fsprojects/FsUnit)
[System.Text.Json](https://github.com/dotnet/runtime/tree/main/src/libraries/System.Text.Json) | [FSharp.SystemTextJson](https://github.com/Tarmil/FSharp.SystemTextJson)
[WPF](https://github.com/dotnet/wpf) | [Elmish.WPF](https://github.com/elmish/Elmish.WPF)
[MAUI](https://github.com/dotnet/maui)/[Xamarin.Forms](https://github.com/xamarin/Xamarin.Forms) | [Fabulous](https://github.com/fabulous-dev/Fabulous)
<!--lint enable double-link -->

## Actor frameworks

- [Akka.NET](https://github.com/akkadotnet/akka.net) - Community-driven port of the popular Java/Scala framework Akka to .NET.
- [Akkling](https://github.com/Horusiath/Akkling) - F# typed API for Akka.NET.
- [Cricket](https://github.com/fsprojects/Cricket) - Actor framework for F#.
- [Orleankka](https://github.com/OrleansContrib/Orleankka) - Functional API for Orleans Framework.
- [Orleans](https://github.com/dotnet/orleans) - Distributed Virtual Actor Model.
- [Proto.actor](https://github.com/AsynkronIT/protoactor-dotnet) - Cross-platform actor framework for .NET, GO, JAVA and KOTLIN.


## Build tools

- [FAKE](https://github.com/fsharp/FAKE) - "F# Make" is a cross platform build automation system.
- [Xake](https://github.com/OlegZee/Xake) - Another MAKE utility implementation on F#, fully declarative with no-brain parallelism, inspired by Shake.

## Cloud

- [FsFirestore](https://github.com/mrbandler/FsFirestore) - Functional F# library to access Firestore database hosted on Google Cloud Platform (GCP) or Firebase.
- [Chia](https://github.com/DanpowerGruppe/Chia) - Chia is a F# library which contains HelperFunctions for reporting, logging and Azure cloud operations.

## Code Generation

- [Hawaii](https://github.com/Zaid-Ajaj/Hawaii) - A dotnet CLI tool to generate type-safe F# clients from OpenAPI/Swagger services.

## Compilers

- [F# Compiler Services](https://github.com/fsharp/FSharp.Compiler.Service) - The F# Compiler, F# Interactive scripting engine and F# editing services as a component library.
- [Fable](https://github.com/fable-compiler/Fable) - F# to JavaScript Compiler.
- [Fez](https://github.com/kjnilsson/fez) - F# to Erlang compiler.
- [FSharp](https://github.com/fsharp/fsharp) - The Open Edition of the F# compiler, core library and tools.
- [FunScript](https://github.com/ZachBray/FunScript) - F# to JavaScript compiler with JQuery etc. mappings through a TypeScript type provider.
- [Juniper](https://github.com/calebh/Juniper) - Functional Reactive Programming for the Arduino and other microcontrollers.
- [Pengines.Client](https://github.com/ninjarobot/Pengines.Client) - Sandboxed Prolog environment.
- [Visual F#](https://github.com/Microsoft/visualfsharp) - The Visual F# compiler and tools.

## Concurrent, asynchronous and parallel programming

- [FIO](https://github.com/iyyel/fio) - A type-safe, highly concurrent and asynchronous library for F# based on pure functional programming.
- [FSharp.Control.AsyncSeq](https://github.com/fsprojects/FSharp.Control.AsyncSeq) - Collection of asynchronous programming utilities for F#.
- [FSharp.Control.FusionTasks](https://github.com/kekyo/FSharp.Control.FusionTasks) - F# Async workflow <--> .NET Task/ValueTask easy seamless interoperability library.
- [FSharpx.Async](https://github.com/fsprojects/FSharpx.Async) - Collection of asynchronous programming utilities for F#.
- [Giraffe.Tasks](https://github.com/giraffe-fsharp/giraffe.tasks) - Task computation expression to work natively with .NET's Tasks from an F# application.
- [Hopac](https://github.com/Hopac/Hopac) - Concurrent ML style concurrent programming library for F#.
- [Ply](https://github.com/crowded/ply) - High performance System.Threading.(Value)Task computation expressions for F#.
- [Reaction.AsyncRx](https://github.com/dbrattli/Reaction) - An implementation of Async Observables in F# for .NET and Fable.
- [TaskBuilder.fs](https://github.com/rspeele/TaskBuilder.fs) - F# computation expression builder for System.Threading.Tasks.

## Configuration

- [Argu](https://github.com/fsprojects/Argu) - Declarative CLI argument/XML configuration parser for F# applications.
- [docopt.fs](https://github.com/docopt/docopt.fs/) - command line arguments parser, F# port of [docopt](https://github.com/docopt/docopt).
- [FsConfig](https://github.com/demystifyfp/FsConfig) - F# library for reading configuration data from environment variables and AppSettings with type safety.
- [Skid](https://github.com/Meyhem/Skid) - Simple, single-file portable CLI utility for configuration templating.
## Data Science

- [Deedle](https://github.com/BlueMountainCapital/Deedle) - Deedle: Exploratory data library for .NET.
- [Deep.Net](http://www.deepml.net) - Deep learning library for F#. Provides symbolic model differentiation, automatic differentiation and compilation to CUDA GPUs.
- [DiffSharp](https://github.com/DiffSharp/DiffSharp) - DiffSharp is a functional automatic differentiation (AD) library.
- [FsLab](https://github.com/fslaborg/FsLab) - FsLab is a collection of libraries for data-science. It provides a rapid development environment that lets you write advanced analysis with few lines of production-quality code.
- [IfSharp](https://github.com/fsprojects/IfSharp) - F# for Jupyter Notebooks.
- [m2cgen](https://github.com/BayesWitnesses/m2cgen) - A CLI tool to transpile trained classic ML models into a native F# code with zero dependencies.
- [Math.NET Numerics](https://github.com/mathnet/mathnet-numerics) - Math.NET Numerics aims to provide methods and algorithms for numerical computations in science, engineering and every day use. F# specific bindings available.
- [Math.NET Symbolics](https://github.com/mathnet/mathnet-symbolics/) - Math.NET Symbolics is a basic open source computer algebra library for .NET, Silverlight and Mono written entirely in F#.
- [SIMDArray](https://github.com/jackmott/SIMDArray) - SIMD enhanced Array extensions for faster computation.
- [Synapses](https://github.com/mrdimosthenis/Synapses) - Neural network library in F#.

## Development Tools

### IDE

- [F# Playground](https://github.com/Seng-Jik/FSharpPlayground) - Minimal playground for F#.
- [JetBrains Rider](https://www.jetbrains.com/rider) - Cross-platform .NET IDE with F# support (Proprietary, free for non-commercial use).
- [MonoDevelop](http://www.monodevelop.com/) - Cross-platform IDE mostly aimed at Mono/.NET developers.
- [Visual Studio](https://www.visualstudio.com/) - IDE from Microsoft with first class F# support (Windows only, Proprietary).

### Editor plugins

- [Emacs F# mode](https://github.com/fsharp/emacs-fsharp-mode) - F# support in Emacs (including Intellisense and Interactive mode).
- [F# Bindings](https://github.com/fsharp/fsharpbinding) - Archive of F# Language Bindings for Open Editors.
- [Fantomas](https://github.com/fsprojects/fantomas) - F# code formatter.
- [FSharpLint](https://github.com/fsprojects/FSharpLint) - F# code linter.
- [FSharpFar](https://github.com/nightroman/FarNet) - F# support for Far Manager.
- [Ionide](http://ionide.io/) - Atom Editor and Visual Studio Code package suite for cross platform F# development.
- [Vim F#](https://github.com/fsharp/vim-fsharp) - F# support for Vim.
- [neofsharp.vim](https://github.com/adelarsq/neofsharp.vim) - Basic F# support for (Neo)Vim.
- [VimSpeak](https://github.com/AshleyF/VimSpeak) - VimSpeak lets you control Vim with your voice using speech recognition.
- [Visual F# Power Tools](https://github.com/fsprojects/VisualFSharpPowerTools) - Power commands for F# in Visual Studio.
- [fsharp-notebook](https://github.com/pablofrommars/fsharp-notebook) - Data Science Notebook for F# interactive.

### Performance analysis

- [fasm](https://github.com/d-edge/fasm) - F# jit disassembler, as a dotnet tool.

## General purpose libraries

- [Aether](https://github.com/xyncro/aether) - Optics library for F#, similar to the Haskell Data.Lens package.
- [Chessie](https://github.com/fsprojects/Chessie) - Railway-oriented programming.
- [Donald](https://github.com/pimbrouwers/Donald) - A simple F# interface for ADO.NET.
- [DustyTables](https://github.com/Zaid-Ajaj/DustyTables) - Thin F# API for SqlClient for easy data access to ms sql server with functional seasoning on top.
- [ExtCore](https://github.com/jack-pappas/ExtCore) - Extended core library for F#.
- [Fling](https://github.com/cmeeren/Fling) - Fling significantly reduces boilerplate needed to efficiently save/load complex domain entities to/from multiple tables.
- [FSharp.CosmosDb](https://github.com/aaronpowell/fsharp.cosmosdb) - An F# wrapper around the CosmosDB SDK, making it more functional-friendly.
- [FSharp.HashCollections](https://github.com/mvkara/fsharp-hashcollections) - Library providing fast hash based immutable map and set.
- [FSharpLu](https://github.com/Microsoft/fsharplu) - Lightweight utilities for string manipulations, logging, collection data structures, file operations, text processing, security, async, parsing, diagnostics, configuration files and Json serialization.
- [FsToolkit.ErrorHandling](https://github.com/demystifyfp/FsToolkit.ErrorHandling) - Clear, simple and powerful error handling with railway-oriented programming. Inspired by Chessie.
- [Fumble](https://github.com/tforkmann/Fumble) - Thin F# API for Sqlite for easy data access to sqlite database with functional seasoning on top.
- [FSharpPlus](https://github.com/gmpl/FSharpPlus) - Extensions for F#.
- [FSharpx.Extras](https://github.com/fsprojects/FSharpx.Extras) - FSharpx.Extras is a collection of libraries and tools for use with F#.
- [LiteDB.FSharp](https://github.com/Zaid-Ajaj/LiteDB.FSharp) - F# Support for [LiteDB](https://github.com/mbdavid/LiteDB), an embedded single file database for .NET.
- [Npgsql.FSharp](https://github.com/Zaid-Ajaj/Npgsql.FSharp) - Thin F# wrapper around [Npgsql](https://github.com/npgsql/npgsql), the PostgreSQL database driver.
- [TypeShape](https://github.com/eiriktsarpalis/TypeShape) - Small, extensible F# library for practical generic programming.
- [Validus](https://github.com/pimbrouwers/Validus) - A composable validation library for F#, with built-in validators for most primitive types and easily extended through custom validators.
- [Vp.FSharp.Sql](https://github.com/veepee-oss/Vp.FSharp.Sql) - Generic F# ADO Provider Wrapper (SqlServer, PostgreSql, Sqlite).

## Game development

- [FsUnity](https://github.com/FsUnity) - F# Libraries, Tools, and Plugins for the Unity3d Game Engine.
- [Garnet](https://github.com/bcarruthers/garnet) - Garnet is a lightweight game composition library for F# with entity-component-system (ECS) and actor-like messaging features.
- [Godot](http://www.lkokemohr.de/fsharp_godot.html) - Tutorial how to use F# with Godot. 
- [Nu Game Engine](https://github.com/bryanedds/Nu) - Cross-platform F# 2D game engine built in the functional style. Uses SDL2 and Farseer Physics.

## GUI
<!--lint disable double-link -->
- [Avalonia.FuncUI](https://github.com/fsprojects/Avalonia.FuncUI) - Develop cross-platform MVU GUI Applications using F# and Avalonia.
- [Elmish.WPF](https://github.com/elmish/Elmish.WPF) - Elmish (or MVU) approach to WPF programming.
- [Epoxy](https://github.com/kekyo/epoxy) - An independent flexible XAML MVVM library for .NET.
- [Fabulous](https://github.com/fabulous-dev/Fabulous) - F# Functional App Development, using declarative dynamic UI.
<!--lint enable double-link -->

## HTTP Clients
- [Http.fs](https://github.com/haf/Http.fs) - A simple, functional HTTP client library for F#.
- [FsHttp](https://github.com/ronaldschlenker/FsHttp) - A convenient library for consuming HTTP/REST endpoints via F#.
- [Oryx](https://github.com/cognitedata/oryx) - A high performance .NET cross platform functional HTTP request handler library for writing HTTP clients and orchestrating web requests.

## Logging

- [FsLibLog](https://github.com/TheAngryByrd/FsLibLog) - FsLibLog is a single file you can copy paste or add through Paket GitHub dependencies to provide your F# library with a logging abstraction.
- [Logary](https://github.com/logary/logary/) - Logary is a high performance, multi-target logging, metric, tracing and health-check library for mono and .NET.

## Package Management

- [NuGet](https://www.nuget.org/) - NuGet is the package manager for the Microsoft development platform including .NET.
- [Paket](https://github.com/fsprojects/Paket) - Dependency manager for .NET with support for NuGet packages and Git repositories.

## Parsing

- [FParsec](https://github.com/stephan-tolksdorf/fparsec) - FParsec is a parser combinator library for F#.
- [FsAttoparsec](https://github.com/haf/FsAttoparsec) - Port of Bryan O'Sullivan's attoparsec from Haskell to F#.
- [XParsec](https://github.com/corsis/XParsec) - Extensible, type-and-source-polymorphic, non-linear applicative parser combinator library for F# 3.0 and 4.0.

## PreCompilation
- [Myriad](https://github.com/MoiraeSoftware/myriad) - Myriad is a pre-compilation code generator.

## Serialization
<!--lint disable double-link -->
- [FsCodec](https://github.com/jet/FsCodec) - F# Event-Union Contract Encoding with versioning tolerant converters.
- [FSharp.Json](https://github.com/vsapronov/FSharp.Json) - F# JSON Reflection based serialization library.
- [FSharp.SystemTextJson](https://github.com/Tarmil/FSharp.SystemTextJson) - System.Text.Json extensions for F# types.
- [Fleece](https://github.com/mausch/Fleece) - Fleece is a JSON mapper for F#. It simplifies mapping from a Json library's JsonValue onto your types, and mapping from your types onto JsonValue.
- [FsPickler](https://github.com/mbraceproject/FsPickler) - Fast, multi-format messaging serializer for .NET.
- [Legivel](https://github.com/fjoppe/Legivel) - F# Yaml 1.2 parser.
- [Thoth.Json](https://thoth-org.github.io/Thoth.Json/) - Json encoder/decoder library inspire by Elm.
<!--lint enable double-link -->

## Search
- [FlexSearch](https://github.com/flexsearch/flexsearch) - High performance REST/SOAP services based full-text searching platform built on top of the popular Lucene search library.

## Simulation
- [F# RISC-V Instruction Set formal specification](https://github.com/mrLSD/riscv-fs) - RISC-V CPU formal ISA Specification. RISC-V CPU simulator with ELF files execution.

## Static site generators
- [SkunkHTML](https://github.com/MaxGripe/skunk-html) - Markdown Blog with GitHub Pages.

## Testing
<!--lint disable double-link -->
- [altcover](https://github.com/SteveGilham/altcover) - Cross-platform coverage gathering and processing tool set for .NET/.NET core and Mono.
- [canopy](https://github.com/lefthandedgoat/canopy) - F# web automation and testing framework.
- [Expecto](https://github.com/haf/expecto) - Smooth testing framework for F# with tests-as-values and parallelism by default.
- [Faqt](https://github.com/cmeeren/Faqt) - Fantastic fluent assertions for your F# tests and domain code.
- [FsCheck](https://github.com/fscheck/FsCheck) - Random Testing for .NET.
- [fsharp-hedgehog](https://github.com/hedgehogqa/fsharp-hedgehog) - Property-based testing system for F#.
- [FsUnit](https://github.com/fsprojects/FsUnit) - FsUnit makes unit-testing with F# more enjoyable. It adds a special syntax to your favorite .NET testing framework.
- [NBomber](https://github.com/PragmaticFlow/NBomber) - Simple load testing framework for Pull and Push scenarios.
- [Persimmon](https://github.com/persimmon-projects/Persimmon) - Unit test framework for F# using computation expressions.
- [unquote](https://github.com/swensensoftware/unquote) - Write F# unit test assertions as quoted expressions.
- [xUnit.net](https://xunit.github.io/) - Free, open source, community-focused unit testing tool for the .NET Framework.
<!--lint enable double-link -->

## Type providers

- [ApiaryProvider](https://github.com/fsprojects/ApiaryProvider) - Type provider for Apiary.io.
- [AzureStorageTypeProvider](https://github.com/fsprojects/AzureStorageTypeProvider) - F# Azure Type Provider which can be used to explore Blob, Table and Queue Azure Storage assets and easily apply CRUD operations on them.
- [COM Type Provider](https://github.com/fsprojects/FSharp.Interop.ComProvider) - Type provider for COM interop.
- [DynamicsCRMProvider](https://github.com/fsprojects/DynamicsCRMProvider) - Type provider for Microsoft Dynamics CRM 2011.
- [EasyBuild.FileSystemProvider](https://github.com/easybuild-org/EasyBuild.FileSystemProvider) - Type provider to provide a typed representation of files and directories based on your project structure or a virtual file system.
- [ExcelProvider](https://github.com/fsprojects/ExcelProvider) - Excel type provider.
- [Facil](https://github.com/cmeeren/Facil) - Facil generates F# data access source code from SQL queries and stored procedures. Optimized for developer happiness.
- [FSharp.Configuration](https://github.com/fsprojects/FSharp.Configuration) - The project contains type providers for the configuration of .NET projects. Handles AppSettings, ResX, Yaml and Ini files.
- [FSharp.Data](https://github.com/fsharp/FSharp.Data) - Data science library that contains type providers for CSV, HTML, JSON, XML, and WorldBank data.
- [FSharp.Data.DbPedia](https://github.com/fsprojects/FSharp.Data.DbPedia) - F# type provider for DBpedia.
- [FSharp.Data.HiveProvider](https://github.com/fsprojects/FSharp.Data.HiveProvider) - Demonstrator F# type provider for Apache Hive.
- [FSharp.Data.Npgsql](https://github.com/demetrixbio/FSharp.Data.Npgsql) - F# type providers library on a top of well-known Npgsql ADO.NET client library.
- [FSharp.Data.SqlClient](https://github.com/fsprojects/FSharp.Data.SqlClient) - F# Type Provider for statically typed access to T-SQL command parameters and result set.
- [FSharp.Data.Tdms](https://github.com/mettekou/FSharp.Data.Tdms) - TDMS support for F#.
- [FSharp.Data.Toolbox](https://github.com/fsprojects/FSharp.Data.Toolbox) - Library for various data access APIs based on FSharp.Data. The library currently includes the Twitter type provider for access to Twitter users and feeds, and SAS type provider to read SAS dataset files.
- [FSharp.Data.TypeProviders](https://github.com/fsprojects/FSharp.Data.TypeProviders) - Library that contains type providers for `.edmx` files, `.dbml` files, WSDL services, OData services, and SQL databases.
- [FSharp.Management](https://github.com/fsprojects/FSharp.Management) - The project contains various type providers for the management of the machine. Handles file system, registry,  Windows Management Instrumentation, PowerShell and SystemTimeZones.
- [FSharp.Text.RegexProvider](https://github.com/fsprojects/FSharp.Text.RegexProvider) - Type provider for regular expressions.
- [FsXaml](https://github.com/fsprojects/FsXaml) - F# Tools for working with XAML Projects.
- [FsYaml](https://github.com/bleis-tift/FsYaml) - Typed Yaml library for F#.
- [GraphProvider](https://github.com/fsprojects/GraphProvider) - `.dgml` state machine type provider.
- [MatDataProvider](https://github.com/fsprojects/matprovider) - Erased type provider for `.mat` files (binary MATLAB format files).
- [R Type Provider](https://github.com/BlueMountainCapital/FSharpRProvider) - Type provider to interop with R.
- [Rezoom.SQL](https://github.com/rspeele/Rezoom.SQL) - Statically typed SQL for F#.
- [S3Provider](https://github.com/fsprojects/S3Provider) - Experimental type provider for Amazon S3.
- [SQLProvider](https://github.com/fsprojects/SQLProvider) - General F# SQL database erasing type provider, supporting LINQ queries, schema exploration, individuals, CRUD operations and much more besides.
- [SwaggerProvider](https://github.com/fsprojects/SwaggerProvider) - F# generative Type Provider for Swagger.


### Creating type providers

- [FSharp.TypeProviders.StarterPack](https://github.com/fsprojects/FSharp.TypeProviders.StarterPack) - The ProvidedTypes SDK for creating F# type providers.
- [RestProvider](https://github.com/fsprojects/RestProvider) - Create type providers just by implementing a simple REST service.

## Visualization

- [FSharp.Charting](https://github.com/fslaborg/FSharp.Charting) - Charting library suitable for interactive F# scripting.
- [SharpVG](https://github.com/ChrisNikkel/SharpVG) - Create SVG vector graphics in F#.
- [XPlot](https://github.com/fslaborg/XPlot) - A plotting library for the F# programming language.
- [GG.Net](https://github.com/pablofrommars/GGNet) - Visualization library for data scientists.
- [Plotly.NET](https://github.com/plotly/Plotly.NET) - A Plotly-based general purpose plotting library for F#.

## Web frameworks
<!--lint disable double-link -->
- [Bolero](https://github.com/fsbolero/Bolero/) - F# in WebAssembly, develop SPAs with the full power of F# and .NET Blazor.
- [Falco](https://github.com/pimbrouwers/Falco/) - A functional-first toolkit for building brilliant ASP.NET Core applications using F#.
- [Felicity](https://github.com/cmeeren/Felicity) - Boilerplate-free, idiomatic JSON:API for your beautiful, idiomatic F# domain model. Optimized for developer happiness.
- [Feliz](https://github.com/Zaid-Ajaj/Feliz) - A fresh retake of the React API in Fable and a collection of high-quality components to build React applications in F#.
- [Freya](https://github.com/xyncro/freya) - Modern, purely functional stack for web programming in F#.
- [Genit](https://github.com/lefthandedgoat/genit) - Cross-platform website generator and server using F#, Suave and PostgreSQL or MS SQL Server.
- [Giraffe](https://github.com/giraffe-fsharp/Giraffe) - Native functional ASP.NET Core web framework for F# developers.
- [Oxpecker](https://github.com/Lanayx/Oxpecker) - ASP.NET Core based F# framework + supporting tools (ViewEngine, Htmx, OpenApi)
- [Saturn](https://github.com/SaturnFramework/Saturn) - Opinionated, web development framework for F# which implements the server-side, functional MVC pattern.
- [Suave](https://github.com/SuaveIO/suave) - Suave is a simple web development F# library providing a lightweight web server and a set of combinators to manipulate route flow and task composition.
- [WebSharper](https://github.com/intellifactory/websharper) - F#-based web programming platform including a compiler from F# code to JavaScript.
<!--lint enable double-link -->

## .NET Core Templates
<!--lint disable awesome-list-item-->
- [ASP.NET Core WebAPI F# Template](https://github.com/MNie/FSharpNetCoreWebApiTemplate) - `dotnet new -i WebAPI.FSharp.Template::*`
- [Expecto Template](https://github.com/MNie/Expecto.Template) - `dotnet new -i Expecto.Template::*`
- [Fable, F# |> Babel](http://fable.io) - `dotnet new -i Fable.Template::*`
- [Fable-elmish](https://github.com/fable-compiler/fable-elmish) - `dotnet new -i Fable.Template.Elmish.React::*`
- [Freya](https://freya.io) - `dotnet new --install Freya.Template::*`
- [Giraffe Template](https://github.com/giraffe-fsharp/giraffe-template) - `dotnet new -i "giraffe-template::*"`
- [MiniScaffold](https://github.com/TheAngryByrd/MiniScaffold) - F# Template for creating and publishing libraries targeting .NET Full (net45) and Core (netstandard1.6), `dotnet new -i MiniScaffold::*`
- [NancyFx Template](https://github.com/MNie/NancyFxCore) - `dotnet new -i NancyFx.Core.Template::*`
- [SAFE Stack Template](https://github.com/SAFE-Stack/SAFE-template) - `dotnet new -i SAFE.Template::*`
- [vbfox's F# Templates](https://github.com/vbfox/FSharpTemplates) - F# Template for creating GitHub project with appveyor and travis support.
<!--lint enable awesome-list-item-->

## Resources

### Blogs

- [.NET Blog (F# tag)](https://devblogs.microsoft.com/dotnet/tag/f/)
- [Codesuji](http://codesuji.com)
- [Krzysztof Cieslak](http://kcieslak.io/)
- [Mark Seemann](http://blog.ploeh.dk/)
- [Sergey Tihon (F# Weekly)](https://sergeytihon.wordpress.com/)
- [Tomas Petricek](http://tomasp.net/blog/)

### Books

- [F# in Action](https://www.manning.com/books/f-sharp-in-action)
- [Domain Modeling Made Functional](https://pragprog.com/titles/swdddf/domain-modeling-made-functional/)

### Cheatsheets

- [F# cheatsheet](http://fsprojects.github.io/fsharp-cheatsheet/)
- [F# Snips](http://fssnip.net/)
- [F# tour](https://docs.microsoft.com/en-us/dotnet/articles/fsharp/tour)
- [Learn F# in Y minutes](https://learnxinyminutes.com/docs/fsharp)
- [30min F# tutorial for C# programmers, with back to back code snippets](https://github.com/knocte/2fsharp/blob/master/csharp2fsharp.md)
- [30min F# tutorial for Python programmers, with back to back code snippets](https://github.com/knocte/2fsharp/blob/master/python2fsharp.md)

### Community

- [F# on Discourse](https://forums.fsharp.org/)
- [F# on GitHub](https://github.com/fsharp/)
- [F# on IRC](http://webchat.freenode.net/?channels=%23%23fsharp)
- [F# on Slack](http://fsharp.org/guides/slack/)
- [F# news on Telegram](https://t.me/fsharp_news)

### Other Lists

- [Awesome .NET!](https://github.com/quozd/awesome-dotnet) - Collection of awesome .NET libraries, tools, frameworks and software.
- [Awesome Fable](https://github.com/kunjee17/awesome-fable) - Curated list of useful Fable tutorials, libraries and software.
- [F# Community Projects](http://fsharp.org/community/projects/) - FSharp community projects.
- [WTF#](https://wtfsharp.net) - Podcast focused on F# and its ecosystem.

### Websites

- [Community for F#](http://c4fsharp.net/) - Links to dojos and recordings of community presentations.
- [cs2fs](https://jindraivanek.gitlab.io/cs2fs-online) - Transform C# code to F# code.
- [Decompiler.com](https://www.decompiler.com/) - Online C#/VB/F# decompiler.
- [DotNetFiddle](https://dotnetfiddle.net/) - Online REPL.
- [F# Core Engineering](http://fsharp.github.io/)
- [F# for Fun and Profit](https://fsharpforfunandprofit.com/) - Reference tutorials.
- [F# Software Foundation](http://fsharp.org/) - Main website.
- [fantomas-tools](https://fsprojects.github.io/fantomas-tools) - A set of Fantomas related tools like AST viewer and online bug reporter.
- [SharpLab](https://sharplab.io/) - C#/VB/F# compiler playground.
- [Try F#](http://www.tryfsharp.org) - Online tutorials, currently without execution of code due to Silverlight dependency.

### Videos

- [Austin F# Meetup Group Recorded Presentations](http://usergroup.tv/videos/category/group/austin-f-meetup)
- [Intro to F#](https://www.youtube.com/watch?v=1ioGr701c5Q&list=PLqWncHdBPoD4YEWoXQlRj1tiTc96HZxH8)
- [Fast Dictionary in F#](https://www.youtube.com/watch?v=KMR2y1vcO-s&list=PLqWncHdBPoD4-d_VSZ0MB0IBKQY0rwYLd)
- [F# Chats on performance](https://www.youtube.com/watch?v=EIBRoNEpg6c&list=PLqWncHdBPoD4O1sr2Q3W9gAuJ30s09U2r)
- [Topological Sort](https://www.youtube.com/playlist?list=PLqWncHdBPoD5hEK31CcfmTHP-7icw2Xd0)

### Courses

- [Data programming with F#](https://www.udemy.com/course/data-programming-with-f/)
- [F# workshop](http://www.fsharpworkshop.com/)
- [Introduction to F#](https://fsharp.tv/courses/fsharp-programming-intro/)
- [Write yourself a scheme in 48 hours using F#](https://write-yourself-a-scheme.pangwa.com/)
