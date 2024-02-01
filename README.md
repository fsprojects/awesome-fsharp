# <img src="http://fsprojects.github.io/assets/logo.png" width="26"> Awesome F# #

[![Awesome](https://cdn.rawgit.com/sindresorhus/awesome/d7305f38d29fed78fa85652e3a63e154dd8e8829/media/badge.svg)](https://github.com/sindresorhus/awesome)
[![Join the chat at https://gitter.im/VPashkov/awesome-fsharp](https://badges.gitter.im/VPashkov/awesome-fsharp.svg)](https://gitter.im/VPashkov/awesome-fsharp?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

A curated list of awesome F# frameworks, libraries, software and resources.

## Table of Contents
- [Awesome F#](#)
  - [F# wrappers for popular .NET libraries](#f-wrappers-for-popular-net-libraries)
  - [Actor frameworks](#actor-frameworks)
  - [Build tools](#build-tools)
  - [Cloud](#cloud)
  - [Compilers](#compilers)
  - [Concurrent, asynchronous and parallel programming](#concurrent-asynchronous-and-parallel-programming)
  - [Configuration](#configuration)
  - [Data Science](#data-science)
  - [Development Tools](#development-tools)
    - [IDE](#ide)
    - [Editor plugins](#editor-plugins)
    - [Performance analysis](#performance-analysis)
  - [Game development](#game-development)
  - [General purpose libraries](#general-purpose-libraries)
  - [GUI](#gui)
  - [HTTP Clients](#http-clients)
  - [Logging](#logging)
  - [Package Management](#package-management)
  - [Parsing](#parsing)
  - [PreCompilation](#precompilation)
  - [Search](#search)
  - [Serialization](#serialization)
  - [Simulation](#simulation)
  - [Testing](#testing)
  - [Type providers](#type-providers)
    - [Creating type providers](#creating-type-providers)
  - [Visualization](#visualization)
  - [Web frameworks](#web-frameworks)
  - [.Net Core Templates](#net-core-templates)
  - [Resources](#resources)
    - [Blogs](#blogs)
    - [Cheatsheets](#cheatsheets)
    - [Community](#community)
    - [Other Lists](#other-lists)
    - [Websites](#websites)
    - [Videos](#videos)
    - [Courses](#courses)

## F# wrappers for popular .NET libraries
Looking to have a more enjoyable experience when consuming a popular .NET library? Here is a quick table.

.NET Library | F# Wrapper
-|-
[Avalonia](https://github.com/AvaloniaUI/Avalonia) | [Avalonia.FuncUI](https://github.com/fsprojects/Avalonia.FuncUI)
[ASP.NET Core](https://github.com/dotnet/aspnetcore) | [Giraffe](https://github.com/giraffe-fsharp/Giraffe) (+ optionally [Saturn](https://github.com/SaturnFramework/Saturn))
[ASP.NET Core Blazor](https://github.com/dotnet/aspnetcore/tree/main/src/Components) | [Bolero](https://github.com/fsbolero/Bolero)
[MSTest](https://github.com/microsoft/testfx)/[NUnit](https://github.com/nunit/nunit)/[xUnit.net](https://github.com/xunit/xunit) | [FsUnit](https://github.com/fsprojects/FsUnit)
[System.Text.Json](https://github.com/dotnet/runtime/tree/main/src/libraries/System.Text.Json) | [FSharp.SystemTextJson](https://github.com/Tarmil/FSharp.SystemTextJson)
[WPF](https://github.com/dotnet/wpf) | [Elmish.WPF](https://github.com/elmish/Elmish.WPF)
[Xamarin.Forms](https://github.com/xamarin/Xamarin.Forms) | [Fabulous](https://github.com/fabulous-dev/Fabulous)

## Actor frameworks

* **[Akka.NET ★ 2239 ⧗ 0](https://github.com/akkadotnet/akka.net)** - Community-driven port of the popular Java/Scala framework Akka to .NET. [Apache 2.0]
* [Akkling ★ 45 ⧗ 1](https://github.com/Horusiath/Akkling) - F# typed API for Akka.NET. [Apache 2.0]
* [Cricket ★ 141 ⧗ 380](https://github.com/fsprojects/Cricket) - Actor framework for F#. [Unlicense]
* [Orleankka ★ 175 ⧗ 5](https://github.com/OrleansContrib/Orleankka) - Functional API for Orleans Framework. [Apache 2.0]
* **[Orleans ★ 2754 ⧗ 0](https://github.com/dotnet/orleans)** - Distributed Virtual Actor Model. [MIT]
* **[Proto.actor ★ 692 ⧗ 0](https://github.com/AsynkronIT/protoactor-dotnet)** - Cross-platform actor framework for .NET, GO, JAVA and KOTLIN. [Apache 2.0]


## Build tools

* **[FAKE ★ 733 ⧗ 0](https://github.com/fsharp/FAKE)** - "F# Make" is a cross platform build automation system. [Apache 2.0]
* **[Xake ★ 8 ⧗ 0](https://github.com/OlegZee/Xake)** - Another MAKE utility implementation on F#, fully declarative with no-brain parallelism, inspired by Shake. [MIT]

## Cloud

* [FsFirestore](https://github.com/mrbandler/FsFirestore) - Functional F# library to access Firestore database hosted on Google Cloud Platform (GCP) or Firebase. [MIT]
* [Chia ★ 3 ⧗ 0](https://github.com/DanpowerGruppe/Chia) - Chia is a F# library which contains HelperFunctions for reporting, logging and Azure cloud operations. [Apache-2.0]

## Code Generation

* [Hawaii](https://github.com/Zaid-Ajaj/Hawaii) - A dotnet CLI tool to generate type-safe F# clients from OpenAPI/Swagger services.

## Compilers

* [F# Compiler Services ★ 159 ⧗ 0](https://github.com/fsharp/FSharp.Compiler.Service) - The F# Compiler, F# Interactive scripting engine and F# editing services as a component library. [Apache 2.0]
* **[Fable ★ 808 ⧗ 0](https://github.com/fable-compiler/Fable)** - F# to JavaScript Compiler. [Apache 2.0]
* [Fez ★ 49 ⧗ 0](https://github.com/kjnilsson/fez) - F# to Erlang compiler. [MIT]
* **[FSharp ★ 1549 ⧗ 0](https://github.com/fsharp/fsharp)** - The Open Edition of the F# compiler, core library and tools. [Apache 2.0]
* [FunScript ★ 446 ⧗ 64](https://github.com/ZachBray/FunScript) - F# to JavaScript compiler with JQuery etc. mappings through a TypeScript type provider. [Apache-2.0]
* [Juniper ★ 73 ⧗ 0](https://github.com/calebh/Juniper) - Functional Reactive Programming for the Arduino and other microcontrollers. [MIT]
* [Pengines.Client ★ 3 ⧗ 0](https://github.com/ninjarobot/Pengines.Client) - sandboxed Prolog environment. [BSD-2-Clause]
* **[Visual F# ★ 988 ⧗ 0](https://github.com/Microsoft/visualfsharp)** - The Visual F# compiler and tools. [Apache 2.0]

## Concurrent, asynchronous and parallel programming

* [FIO](https://github.com/iyyel/fio) - A type-safe, highly concurrent and asynchronous library for F# based on pure functional programming [GNU v3]
* [FSharp.Control.AsyncSeq ★ 28 ⧗ 12](https://github.com/fsprojects/FSharp.Control.AsyncSeq) - Collection of asynchronous programming utilities for F#. [Apache 2.0]
* [FSharp.Control.FusionTasks](https://github.com/kekyo/FSharp.Control.FusionTasks) - F# Async workflow <--> .NET Task/ValueTask easy seamless interoperability library.
* [FSharpx.Async ★ 37 ⧗ 56](https://github.com/fsprojects/FSharpx.Async) - Collection of asynchronous programming utilities for F#. [Apache 2.0]
* [Giraffe.Tasks ★ 13 ⧗ 0](https://github.com/giraffe-fsharp/giraffe.tasks) - task computation expression to work natively with .NET's Tasks from an F# application. [Apache 2.0]
* [Hopac ★ 268 ⧗ 7](https://github.com/Hopac/Hopac) - Concurrent ML style concurrent programming library for F#. [MIT]
* [Ply](https://github.com/crowded/ply) - High performance System.Threading.(Value)Task computation expressions for F#. [MIT]
* [Reaction.AsyncRx](https://github.com/dbrattli/Reaction) - An implementation of Async Observables in F# for .NET and Fable. [MIT]
* [TaskBuilder.fs](https://github.com/rspeele/TaskBuilder.fs) - F# computation expression builder for System.Threading.Tasks. [CC0]

## Configuration

* [Argu ★ 145 ⧗ 0](https://github.com/fsprojects/Argu) - Declarative CLI argument/XML configuration parser for F# applications. [MIT]
* [docopt.fs ★ 18 ⧗ 0](https://github.com/docopt/docopt.fs/) - command line arguments parser, F# port of [docopt](https://github.com/docopt/docopt). [MIT]
* [FsConfig ★ 14 ⧗ 1](https://github.com/demystifyfp/FsConfig) - F# library for reading configuration data from environment variables and AppSettings with type safety. [Unlicense]
* [Skid ★ 3 ⧗ 0](https://github.com/Meyhem/Skid) - Simple, single-file portable CLI utility for configuration templating. [MIT]
## Data Science

* [Deedle ★ 347 ⧗ 21](https://github.com/BlueMountainCapital/Deedle) - Deedle: Exploratory data library for .NET. [BSD-2-Clause]
* [Deep.Net](http://www.deepml.net) - Deep learning library for F#. Provides symbolic model differentiation, automatic differentiation and compilation to CUDA GPUs. [Apache 2.0]
* [DiffSharp ★ 106 ⧗ 70](https://github.com/DiffSharp/DiffSharp) - DiffSharp is a functional automatic differentiation (AD) library. [BSD-2-Clause]
* [FsLab ★ 97 ⧗ 171](https://github.com/fslaborg/FsLab) - FsLab is a collection of libraries for data-science. It provides a rapid development environment that lets you write advanced analysis with few lines of production-quality code. [Apache 2.0]
* [IfSharp * 272 ⧗ 1](https://github.com/fsprojects/IfSharp) - F# for Jupyter Notebooks. [BSD-3-Clause]
* [m2cgen](https://github.com/BayesWitnesses/m2cgen) - A CLI tool to transpile trained classic ML models into a native F# code with zero dependencies. [MIT]
* **[Math.NET Numerics ★ 1,923 ⧗ 0](https://github.com/mathnet/mathnet-numerics)** - Math.NET Numerics aims to provide methods and algorithms for numerical computations in science, engineering and every day use. F# specific bindings available. [MIT]
* [Math.NET Symbolics ★ 203 ⧗ 5](https://github.com/mathnet/mathnet-symbolics/) - Math.NET Symbolics is a basic open source computer algebra library for .NET, Silverlight and Mono written entirely in F#. [MIT]
* [SIMDArray ★ 42 ⧗ 11](https://github.com/jackmott/SIMDArray) - SIMD enhanced Array extensions for faster computation. [MIT]
* [Synapses](https://github.com/mrdimosthenis/Synapses) - Neural network library in F#. [MIT]

## Development Tools

### IDE

* [F# Playground](https://github.com/Seng-Jik/FSharpPlayground) - Minimal playground for F#. [GPL 3.0]
* [Jetbrains Rider](https://www.jetbrains.com/rider) - Cross-Platform .Net IDE with F# support. [Proprietary, free for open source projects] 
* [MonoDevelop](http://www.monodevelop.com/) - Cross-platform IDE mostly aimed at Mono/.NET developers. [LGPLv2 and X11/MIT]
* [Visual Studio](https://www.visualstudio.com/) - IDE from Microsoft with first class F# support(Windows only). [Proprietary]

### Editor plugins

* [Emacs F# mode ★ 80 ⧗ 27](https://github.com/fsharp/emacs-fsharp-mode) - F# support in Emacs (including Intellisense and Interactive mode) [Apache 2.0]
* [F# Bindings ★ 321 ⧗ 261](https://github.com/fsharp/fsharpbinding) - Archive of F# Language Bindings for Open Editors. [Apache 2.0]
* [Fantomas ★ 472 ⧗ 115](https://github.com/fsprojects/fantomas) - F# code formatter. [Apache 2.0]
* [FSharpLint ★ 223 ⧗ 55](https://github.com/fsprojects/FSharpLint) - F# code linter. [MIT]
* [FSharpFar ★ 33 ⧗ 54](https://github.com/nightroman/FarNet) - F# support for Far Manager. [BSD-3-Clause]
* [Ionide](http://ionide.io/) - Atom Editor and Visual Studio Code package suite for cross platform F# development. [MIT]
* [Vim F# ★ 66 ⧗ 3](https://github.com/fsharp/vim-fsharp) - F# support for Vim. [MIT]
* [neofsharp.vim](https://github.com/adelarsq/neofsharp.vim) - Basic F# support for (Neo)Vim [MIT]
* [VimSpeak ★ 305 ⧗ 910](https://github.com/AshleyF/VimSpeak) - VimSpeak lets you control Vim with your voice using speech recognition. [MIT]
* [Visual F# Power Tools ★ 310 ⧗ 53](https://github.com/fsprojects/VisualFSharpPowerTools) - Power commands for F# in Visual Studio. [Apache 2.0]
* [fsharp-notebook](https://github.com/pablofrommars/fsharp-notebook) - Data Science Notebook for F# interactive. [MIT]

### Performance analysis

* [fasm](https://github.com/d-edge/fasm) - F# jit disassembler, as a dotnet tool [MIT]

## General purpose libraries

* [Aether ★ 71 ⧗ 0](https://github.com/xyncro/aether) - Optics library for F#, similar to the Haskell Data.Lens package. [MIT]
* [Chessie ★ 96 ⧗ 272](https://github.com/fsprojects/Chessie) - Railway-oriented programming. [Unlicense]
* [Donald](https://github.com/pimbrouwers/Donald) - A simple F# interface for ADO.NET. [Apache-2.0]
* [DustyTables ★ 39 ⧗ 6](https://github.com/Zaid-Ajaj/DustyTables) - Thin F# API for SqlClient for easy data access to ms sql server with functional seasoning on top [MIT]
* [ExtCore ★ 96 ⧗ 0](https://github.com/jack-pappas/ExtCore) - Extended core library for F#. [Apache 2.0]
* [Fling](https://github.com/cmeeren/Fling) - Fling significantly reduces boilerplate needed to efficiently save/load complex domain entities to/from multiple tables. [MIT]
* [FSharp.CosmosDb](https://github.com/aaronpowell/fsharp.cosmosdb) - An F# wrapper around the CosmosDB SDK, making it more functional-friendly [MIT]
* [FSharp.HashCollections ★ 4 ⧗ 0](https://github.com/mvkara/fsharp-hashcollections) - Library providing fast hash based immutable map and set. [MIT]
* [FSharpLu ★ 133 ⧗ 20](https://github.com/Microsoft/fsharplu) - Lightweight utilities for string manipulations, logging, collection data structures, file operations, text processing, security, async, parsing, diagnostics, configuration files and Json serialization. [MIT]
* [FsToolkit.ErrorHandling](https://github.com/demystifyfp/FsToolkit.ErrorHandling) - Clear, simple and powerful error handling with railway-oriented programming. Inspired by Chessie. [MIT]
* [Fumble ★ 30 ⧗ 0](https://github.com/tforkmann/Fumble) - Thin F# API for Sqlite for easy data access to sqlite database with functional seasoning on top [MIT]
* [FSharpPlus ★ 142 ⧗ 34](https://github.com/gmpl/FSharpPlus) - Extensions for F#. [Apache 2.0]
* [FSharpx.Extras ★ 589 ⧗ 28](https://github.com/fsprojects/FSharpx.Extras) - FSharpx.Extras is a collection of libraries and tools for use with F#. [Unlicense]
* [LiteDB.FSharp](https://github.com/Zaid-Ajaj/LiteDB.FSharp) - F# Support for [LiteDB](https://github.com/mbdavid/LiteDB), an embedded single file database for .NET [MIT]
* [Npgsql.FSharp](https://github.com/Zaid-Ajaj/Npgsql.FSharp) - Thin F# wrapper around [Npgsql](https://github.com/npgsql/npgsql), the PostgreSQL database driver [MIT]
* [TypeShape ★ 64 ⧗ 0](https://github.com/eiriktsarpalis/TypeShape) - Small, extensible F# library for practical generic programming. [MIT]
* [Validus](https://github.com/pimbrouwers/Validus) - A composable validation library for F#, with built-in validators for most primitive types and easily extended through custom validators.
* [Vp.FSharp.Sql](https://github.com/veepee-oss/Vp.FSharp.Sql) - Generic F# ADO Provider Wrapper (SqlServer, PostgreSql, Sqlite). [MIT]

## Game development

* [FsUnity](https://github.com/FsUnity) - F# Libraries, Tools, and Plugins for the Unity3d Game Engine. [Unilicense]
* [Garnet ★ 15 ⧗ 6](https://github.com/bcarruthers/garnet) - Garnet is a lightweight game composition library for F# with entity-component-system (ECS) and actor-like messaging features. [MIT]
* [Godot](http://www.lkokemohr.de/fsharp_godot.html) - Tutorial how to use F# with Godot. 
* **[Nu Game Engine ★ 502 ⧗ 9](https://github.com/bryanedds/Nu)** - Cross-platform F# 2D game engine built in the functional style. Uses SDL2 and Farseer Physics. [MIT]

## GUI

* [Avalonia.FuncUI](https://github.com/fsprojects/Avalonia.FuncUI) - Develop cross-platform MVU GUI Applications using F# and Avalonia
* [Epoxy](https://github.com/kekyo/epoxy) - An independent flexible XAML MVVM library for .NET
* [Fabulous](https://github.com/fabulous-dev/Fabulous) - F# Functional App Development, using declarative dynamic UI

## HTTP Clients
* [Http.fs](https://github.com/haf/Http.fs) - A simple, functional HTTP client library for F#
* [FsHttp](https://github.com/ronaldschlenker/FsHttp) - A convenient library for consuming HTTP/REST endpoints via F#. [Apache 2.0]
* [Oryx](https://github.com/cognitedata/oryx) - A high performance .NET cross platform functional HTTP request handler library for writing HTTP clients and orchestrating web requests. [Apache 2.0]

## Logging

* [FsLibLog ★ 26 ⧗ 0](https://github.com/TheAngryByrd/FsLibLog) - FsLibLog is a single file you can copy paste or add through Paket Github dependencies to provide your F# library with a logging abstraction. [MIT]
* [Logary ★ 259 ⧗ 0](https://github.com/logary/logary/) - Logary is a high performance, multi-target logging, metric, tracing and health-check library for mono and .Net. [Apache 2.0]

## Package Management

* [NuGet](https://www.nuget.org/) - NuGet is the package manager for the Microsoft development platform including .NET. [Apache 2.0]
* **[Paket ★ 903 ⧗ 0](https://github.com/fsprojects/Paket)** - Dependency manager for .NET with support for NuGet packages and Git repositories. [MIT]

## Parsing

* [FParsec ★ 50 ⧗ 0](https://github.com/stephan-tolksdorf/fparsec) - FParsec is a parser combinator library for F#. [[BSD-2-Clause](http://www.quanttec.com/fparsec/license.html)]
* [FsAttoparsec ★ 1 ⧗ 0](https://github.com/haf/FsAttoparsec) - Port of Bryan O'Sullivan's attoparsec from Haskell to F#. [BSD-3-Clause]
* [XParsec ★ 29 ⧗ 2](https://github.com/corsis/XParsec) - Extensible, type-and-source-polymorphic, non-linear applicative parser combinator library for F# 3.0 and 4.0. [BSD-3-Clause]

## PreCompilation
* [Myriad ★ 38 ⧗ 4](https://github.com/MoiraeSoftware/myriad) - Myriad is a pre-compilation code generator


## Serialization

* [FsCodec ★ 21 ⧗ 7](https://github.com/jet/FsCodec) - F# Event-Union Contract Encoding with versioning tolerant converters. [Apache 2.0]
* [FSharp.Json ★ 72 ⧗ 15](https://github.com/vsapronov/FSharp.Json) - F# JSON Reflection based serialization library. [Apache-2.0]
* [FSharp.SystemTextJson ★ 36 ⧗ 0](https://github.com/Tarmil/FSharp.SystemTextJson) - System.Text.Json extensions for F# types. [MIT]
* [Fleece ★ 94 ⧗ 76](https://github.com/mausch/Fleece) - Fleece is a JSON mapper for F#. It simplifies mapping from a Json library's JsonValue onto your types, and mapping from your types onto JsonValue. [Apache-2.0]
* [FsPickler ★ 195 ⧗ 13](https://github.com/mbraceproject/FsPickler) - Fast, multi-format messaging serializer for .NET. [MIT]
* [Legivel ★ 19 ⧗ 4](https://github.com/fjoppe/Legivel) - F# Yaml 1.2 parser. [Unlicense]
* [Thoth.Json ★ 40 ⧗ 11](https://thoth-org.github.io/Thoth.Json/) - Json encoder/decoder library inspire by Elm. [MIT]

## Search
* [FlexSearch ★ 133 ⧗ 14](https://github.com/flexsearch/flexsearch) - high performance REST/SOAP services based full-text searching platform built on top of the popular Lucene search library. [Apache 2.0]

## Simulation
* [F# RISC-V Instruction Set formal specification](https://github.com/mrLSD/riscv-fs) - RISC-V CPU formal ISA Specification. RISC-V CPU simulator with ELF files execution. [MIT]

## Testing
* [altcover ★ 139 ⧗ 0](https://github.com/SteveGilham/altcover) - Cross-platform coverage gathering and processing tool set for .net/.net core and Mono. [MIT]
* [canopy ★ 304 ⧗ 2](https://github.com/lefthandedgoat/canopy) - F# web automation and testing framework. [MIT]
* [Expecto ★ 124 ⧗ 2](https://github.com/haf/expecto) - Smooth testing framework for F# with tests-as-values and parallelism by default. [Apache 2.0]
* [FsCheck ★ 415 ⧗ 34](https://github.com/fscheck/FsCheck) - Random Testing for .NET. [BSD-3-Clause]
* [fsharp-hedgehog ★ 42 ⧗ 4](https://github.com/hedgehogqa/fsharp-hedgehog) - Property-based testing system for F#. [Apache 2.0]
* [FsUnit ★ 340 ⧗ 86](https://github.com/fsprojects/FsUnit) - FsUnit makes unit-testing with F# more enjoyable. It adds a special syntax to your favorite .NET testing framework. [MIT]
* [NBomber ★ 14 ⧗ 23](https://github.com/PragmaticFlow/NBomber) - simple load testing framework for Pull and Push scenarios. [Apache 2.0]
* [Persimmon ★ 29 ⧗ 9](https://github.com/persimmon-projects/Persimmon) - Unit test framework for F# using computation expressions. [MIT]
* [unquote ★ 88 ⧗ 17](https://github.com/swensensoftware/unquote) - Write F# unit test assertions as quoted expressions. [Apache 2.0]
* [xUnit.net](https://xunit.github.io/) - Free, open source, community-focused unit testing tool for the .NET Framework. [Apache 2.0]

## Type providers

* [ApiaryProvider ★ 9 ⧗ 380](https://github.com/fsprojects/ApiaryProvider) - Type provider for Apiary.io. [Apache 2.0]
* [AzureStorageTypeProvider ★ 45 ⧗ 20](https://github.com/fsprojects/AzureStorageTypeProvider) - F# Azure Type Provider which can be used to explore Blob, Table and Queue Azure Storage assets and easily apply CRUD operations on them. [Unilicense]
* [COM Type Provider ★ 36 ⧗ 330](https://github.com/fsprojects/FSharp.Interop.ComProvider) - Type provider for COM interop. [Unilicense]
* [DynamicsCRMProvider ★ 8 ⧗ 380](https://github.com/fsprojects/DynamicsCRMProvider) - Type provider for Microsoft Dynamics CRM 2011. [Apache 2.0]
* [ExcelProvider ★ 45 ⧗ 75](https://github.com/fsprojects/ExcelProvider) - Excel type provider. [Unilicense]
* [Facil](https://github.com/cmeeren/Facil) - Facil generates F# data access source code from SQL queries and stored procedures. Optimized for developer happiness. [MIT]
* [FSharp.Configuration ★ 60 ⧗ 6](https://github.com/fsprojects/FSharp.Configuration) - The project contains type providers for the configuration of .NET projects. Handles AppSettings, ResX, Yaml and Ini files. [Apache 2.0]
* [FSharp.Data ★ 375 ⧗ 8](https://github.com/fsharp/FSharp.Data) - Data science library that contains type providers for CSV, HTML, JSON, XML, and WorldBank data. [Apache 2.0]
* [FSharp.Data.DbPedia ★ 9 ⧗ 379](https://github.com/fsprojects/FSharp.Data.DbPedia) - F# type provider for DBpedia. [Unilicense]
* [FSharp.Data.HiveProvider ★ 8 ⧗ 379](https://github.com/fsprojects/FSharp.Data.HiveProvider) - Demonstrator F# type provider for Apache Hive. [Apache 2.0]
* [FSharp.Data.Npgsql ★ 6 ⧗ 1](https://github.com/demetrixbio/FSharp.Data.Npgsql) - F# type providers library on a top of well-known Npgsql ADO.NET client library. [Apache 2.0]
* [FSharp.Data.SqlClient ★ 121 ⧗ 16](https://github.com/fsprojects/FSharp.Data.SqlClient) - F# Type Provider for statically typed access to T-SQL command parameters and result set. [Apache 2.0]
* [FSharp.Data.Tdms ★ 0 ⧗ 1](https://github.com/mettekou/FSharp.Data.Tdms) - TDMS support for F# [MIT]
* [FSharp.Data.Toolbox ★ 38 ⧗ 7](https://github.com/fsprojects/FSharp.Data.Toolbox) - Library for various data access APIs based on FSharp.Data. The library currently includes the Twitter type provider for access to Twitter users and feeds, and SAS type provider to read SAS dataset files. [Apache 2.0]
* [FSharp.Data.TypeProviders ★ 9 ⧗ 379](https://github.com/fsprojects/FSharp.Data.TypeProviders) - Library that contains type providers for `.edmx` files, `.dbml` files, WSDL services, OData services, and SQL databases. [Unilicense]
* [FSharp.Management ★ 59 ⧗ 1](https://github.com/fsprojects/FSharp.Management) - The project contains various type providers for the management of the machine. Handles file system, registry,  Windows Management Instrumentation, PowerShell and SystemTimeZones. [Apache 2.0]
* [FSharp.Text.RegexProvider ★ 29 ⧗ 285](https://github.com/fsprojects/FSharp.Text.RegexProvider) - Type provider for regular expressions. [Apache 2.0]
* [FsXaml ★ 158 ⧗ 453](https://github.com/fsprojects/FsXaml) - F# Tools for working with XAML Projects. [MIT]
* [FsYaml ★ 33 ⧗ 41](https://github.com/bleis-tift/FsYaml) - Typed Yaml library for F#. [NYSL Version 0.9982]
* [GraphProvider ★ 21 ⧗ 379](https://github.com/fsprojects/GraphProvider) - `.dgml` state machine type provider. [Apache 2.0]
* [MatDataProvider ★ 6 ⧗ 378](https://github.com/fsprojects/matprovider) - Erased type provider for `.mat` files (binary MATLAB format files). [Apache 2.0]
* [R Type Provider ★ 159 ⧗ 365](https://github.com/BlueMountainCapital/FSharpRProvider) - Type provider to interop with R. [BSD-2-Clause]
* [Rezoom.SQL ★ 7 ⧗ 0](https://github.com/rspeele/Rezoom.SQL) - Statically typed SQL for F#. [MIT]
* [S3Provider ★ 16 ⧗ 379](https://github.com/fsprojects/S3Provider) - Experimental type provider for Amazon S3. [MIT]
* [SQLProvider ★ 192 ⧗ 7](https://github.com/fsprojects/SQLProvider) - General F# SQL database erasing type provider, supporting LINQ queries, schema exploration, individuals, CRUD operations and much more besides. [Apache 2.0]
* [SwaggerProvider ★ 81 ⧗ 3](https://github.com/fsprojects/SwaggerProvider) - F# generative Type Provider for Swagger. [Unilicense]


### Creating type providers

* [FSharp.TypeProviders.StarterPack ★ 104 ⧗ 42](https://github.com/fsprojects/FSharp.TypeProviders.StarterPack) - The ProvidedTypes SDK for creating F# type providers. [Apache 2.0]
* [RestProvider ★ 14 ⧗ 258](https://github.com/fsprojects/RestProvider) - Create type providers just by implementing a simple REST service. [Apache 2.0]

## Visualization

* [FSharp.Charting ★ 186 ⧗ 0](https://github.com/fslaborg/FSharp.Charting) - Charting library suitable for interactive F# scripting. [MIT]
* [SharpVG ★ 32 ⧗ 0](https://github.com/ChrisNikkel/SharpVG) - Create SVG vector graphics in F#. [MIT]
* [XPlot ★ 173 ⧗ 0](https://github.com/fslaborg/XPlot) - A plotting library for the F# programming language. [Apache 2.0]
* [GG.Net](https://github.com/pablofrommars/GGNet) - Visualization library for data scientists. [MIT]
* [Plotly.NET](https://github.com/plotly/Plotly.NET) - A Plotly-based general purpose plotting library for F#. [MIT]

## Web frameworks

* [Bolero ★ 629](https://github.com/fsbolero/Bolero/) - F# in WebAssembly, develop SPAs with the full power of F# and .NET Blazor. [Apache 2.0]
* [Falco](https://github.com/pimbrouwers/Falco/) - A functional-first toolkit for building brilliant ASP.NET Core applications using F#.
* [Felicity](https://github.com/cmeeren/Felicity) - Boilerplate-free, idiomatic JSON:API for your beautiful, idiomatic F# domain model. Optimized for developer happiness. [MIT]
* [Freya ★ 241 ⧗ 7](https://github.com/xyncro/freya) - Modern, purely functional stack for web programming in F#. [Apache 2.0]
* [Genit ★ 62 ⧗ 1](https://github.com/lefthandedgoat/genit) - Cross-platform website generator and server using F#, Suave and PostgreSQL or MS SQL Server.
* [Giraffe ★ 526 ⧗ 49](https://github.com/giraffe-fsharp/Giraffe) - Native functional ASP.NET Core web framework for F# developers. [Apache 2.0]
* [Saturn ★ 62 ⧗ 2](https://github.com/SaturnFramework/Saturn) - Opinionated, web development framework for F# which implements the server-side, functional MVC pattern. [MIT]
* **[Suave ★ 756 ⧗ 2](https://github.com/SuaveIO/suave)** - Suave is a simple web development F# library providing a lightweight web server and a set of combinators to manipulate route flow and task composition. [Apache 2.0]
* [WebSharper ★ 270 ⧗ 7](https://github.com/intellifactory/websharper) - F#-based web programming platform including a compiler from F# code to JavaScript. [Apache 2.0]

## .Net Core Templates
 * [ASP.NET Core WebAPI F# Template](https://github.com/MNie/FSharpNetCoreWebApiTemplate) `dotnet new -i WebAPI.FSharp.Template::*`
 * [Expecto Template](https://github.com/MNie/Expecto.Template) `dotnet new -i Expecto.Template::*`
 * [Fable, F# |> Babel](http://fable.io) `dotnet new -i Fable.Template::*`
 * [Fable-elmish](https://github.com/fable-compiler/fable-elmish) `dotnet new -i Fable.Template.Elmish.React::*`
 * [Freya](https://freya.io) `dotnet new --install Freya.Template::*`
 * [Giraffe Template](https://github.com/giraffe-fsharp/giraffe-template) (Quick install: `dotnet new -i "giraffe-template::*"`)
 * [MiniScaffold](https://github.com/TheAngryByrd/MiniScaffold) 
    - F# Template for creating and publishing libraries targeting .NET Full (net45) and Core (netstandard1.6)
    - `dotnet new -i MiniScaffold::*`
 * [NancyFx Template](https://github.com/MNie/NancyFxCore) `dotnet new -i NancyFx.Core.Template::*`
 * [SAFE Stack Template](https://github.com/SAFE-Stack/SAFE-template) `dotnet new -i SAFE.Template::*`
 * [vbfox's F# Templates](https://github.com/vbfox/FSharpTemplates)
    - F# Template for creating github project with appveyor and travis support

## Resources

### Blogs

* [.NET Blog (F# tag)](https://devblogs.microsoft.com/dotnet/tag/f/)
* [Codesuji](http://codesuji.com)
* [Krzysztof Cieslak](http://kcieslak.io/)
* [Mark Seemann](http://blog.ploeh.dk/)
* [Sergey Tihon (F# Weekly)](https://sergeytihon.wordpress.com/)
* [Tomas Petricek](http://tomasp.net/blog/)

### Books

* [F# in Action](https://www.manning.com/books/f-sharp-in-action)

### Cheatsheets

* [F# cheatsheet](http://fsprojects.github.io/fsharp-cheatsheet/)
* [F# Snips](http://fssnip.net/)
* [F# tour](https://docs.microsoft.com/en-us/dotnet/articles/fsharp/tour)
* [Learn F# in Y minutes](https://learnxinyminutes.com/docs/fsharp)

### Community

* [F# on Discourse](https://forums.fsharp.org/)
* [F# on Github](https://github.com/fsharp/)
* [F# on IRC](http://webchat.freenode.net/?channels=%23%23fsharp)
* [F# on Slack](http://fsharp.org/guides/slack/)
* [F# news on Telegram](https://t.me/fsharp_news)

### Other Lists

* **[Awesome .NET! ★ 4458 ⧗ 2](https://github.com/quozd/awesome-dotnet)** - Collection of awesome .NET libraries, tools, frameworks and software. [CC0 1.0]
* [Awesome Fable](https://github.com/kunjee17/awesome-fable) - Curated list of useful Fable tutorials, libraries and software. [CC0 1.0]
* [F# Community Projects](http://fsharp.org/community/projects/) - FSharp community projects
* [F# for fun and profit](https://fsharpforfunandprofit.com/)
* [WTF#](https://wtfsharp.net) - podcast focused on F# and its ecosystem

### Websites

* [Community for F#](http://c4fsharp.net/) - Links to dojos and recordings of community presentations.
* [cs2fs](https://jindraivanek.gitlab.io/cs2fs-online) - Transform C# code to F# code
* [Decompiler.com](https://www.decompiler.com/) - Online C#/VB/F# decompiler
* [DotNetFiddle](https://dotnetfiddle.net/) - Online REPL
* [F# Core Engineering](http://fsharp.github.io/)
* [F# for Fun and Profit](https://fsharpforfunandprofit.com/) - Reference tutorials
* [F# Software Foundation](http://fsharp.org/) - Main website
* [fantomas-tools](https://fsprojects.github.io/fantomas-tools) - A set of Fantomas related tools like AST viewer and online bug reporter.
* [SharpLab](https://sharplab.io/) - C#/VB/F# compiler playground.
* [Try F#](http://www.tryfsharp.org) - Online tutorials, currently without execution of code due to Silverlight dependency

### Videos

* [Austin F# Meetup Group Recorded Presentations](http://usergroup.tv/videos/category/group/austin-f-meetup)
* [Intro to F#](https://www.youtube.com/watch?v=1ioGr701c5Q&list=PLqWncHdBPoD4YEWoXQlRj1tiTc96HZxH8)
* [Fast Dictionary in F#](https://www.youtube.com/watch?v=KMR2y1vcO-s&list=PLqWncHdBPoD4-d_VSZ0MB0IBKQY0rwYLd)
* [F# Chats on performance](https://www.youtube.com/watch?v=EIBRoNEpg6c&list=PLqWncHdBPoD4O1sr2Q3W9gAuJ30s09U2r)
* [Topological Sort](https://www.youtube.com/playlist?list=PLqWncHdBPoD5hEK31CcfmTHP-7icw2Xd0)

### Courses

* [Data programming with F#](https://www.udemy.com/course/data-programming-with-f/)
* [F# workshop](http://www.fsharpworkshop.com/)
* [Introduction to F#](https://fsharp.tv/courses/fsharp-programming-intro/)
* [Write yourself a scheme in 48 hours using F#](https://write-yourself-a-scheme.pangwa.com/)
