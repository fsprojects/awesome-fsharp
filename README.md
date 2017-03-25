# Awesome F# #

[![Join the chat at https://gitter.im/VPashkov/awesome-fsharp](https://badges.gitter.im/VPashkov/awesome-fsharp.svg)](https://gitter.im/VPashkov/awesome-fsharp?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

A curated list of awesome F# frameworks, libraries, software and resources.

## Contents
 * [Actor frameworks](#actor-frameworks)
 * [Concurrent, asynchronous and parallel programming](#concurrent-asynchronous-and-parallel-programming)
 * [General purpose libraries](#general-purpose-libraries)
 * [Build tools](#build-tools)
 * [Compilers](#compilers)
 * [Data Science](#data-science)
 * [Type providers](#type-providers)
  * [Creating type providers](#creating-type-providers)
 * [Development Tools](#development-tools)
  * [Editor plugins](#editor-plugins)
  * [IDE](#ide)
 * [Game development](#game-development)
 * [Logging](#logging)
 * [Package Management](#package-management)
 * [Serialization](#serialization)
 * [Testing](#testing)
 * [Web frameworks](#web-frameworks)
 * [Resources](#resources)
  * [Blogs](#blogs)
  * [Cheatsheets](#cheatsheets)
  * [Community](#community)
  * [Other Lists](#other-lists)
  * [Websites](#websites)

## Actor frameworks
 * [Akka.NET](http://getakka.net/) - Community-driven port of the popular Java/Scala framework Akka to .NET. [Apache 2.0]
 * [Akkling](https://github.com/Horusiath/Akkling) - F# typed API for Akka.NET. [Apache 2.0]
 * [Cricket](http://fsprojects.github.io/Cricket/) - An actor framework for F#. [Unlicense]
 * [Orleans](http://dotnet.github.io/orleans/) - Distributed Virtual Actor Model. [MIT]
 * [Orleankka](https://github.com/OrleansContrib/Orleankka) - Functional API for Orleans Framework. [Apache 2.0]

## Concurrent, asynchronous and parallel programming
 * [Hopac](http://hopac.github.io/Hopac/Hopac.html) - concurrent ML style concurrent programming library for F#. [MIT]
 * [FSharpx.Async](https://github.com/fsprojects/FSharpx.Async) - collection of asynchronous programming utilities for F# [Apache 2.0]
 * [FSharp.Control.AsyncSeq](https://github.com/fsprojects/FSharp.Control.AsyncSeq) - collection of asynchronous programming utilities for F# [Apache 2.0]
 
## General purpose libraries
 * [Chessie](https://github.com/fsprojects/Chessie) - railway-oriented programming. [Unlicense]
 * [FSharpLu](https://github.com/Microsoft/fsharplu) - lightweight utilities for string manipulations, logging, collection data structures, file operations, text processing, security, async, parsing, diagnostics, configuration files and Json serialization. [MIT]
 * [FSharpPlus](https://github.com/gmpl/FSharpPlus) - extensions for F#. [Apache 2.0]

## Build tools
 * [FAKE](http://fsharp.github.io/FAKE/) - "F# Make" is a cross platform build automation system. [Apache 2.0]

## Compilers
 * [Fable](http://fable.io/) - F# to JavaScript Compiler. [Apache 2.0]
 * [FSharp](https://github.com/fsharp/fsharp) - The Open Edition of the F# compiler, core library and tools. [Apache 2.0]
 * [F# Compiler Services](http://fsharp.github.io/FSharp.Compiler.Service/) - The F# Compiler, F# Interactive scripting engine and F# editing services as a component library. [Apache 2.0]
 * [FunScript](http://funscript.info) - F# to JavaScript compiler with JQuery etc. mappings through a TypeScript type provider. [Apache-2.0]
 * [Visual F#](https://github.com/Microsoft/visualfsharp) - The Visual F# compiler and tools. [Apache 2.0]

## Configuration
 * [Argu](http://fsprojects.github.io/Argu) - declarative CLI argument/XML configuration parser for F# applications. [MIT]

## Data Science
 * [FsLab](https://fslab.org/) - FsLab is a collection of libraries for data-science. It provides a rapid development envi­ronment that lets you write advanced analysis with few lines of production-quality code. [Apache 2.0]
 * [Math.NET](http://numerics.mathdotnet.com/) - Math.NET Numerics aims to provide methods and algorithms for numerical computations in science, engineering and every day use. F# specific bindings available. [MIT]
 * [SIMDArray](https://github.com/jackmott/SIMDArray) - SIMD enhanced Array extensions for faster computation. [MIT]
 * [Deep.Net](http://www.deepml.net) - Deep learning library for F#. Provides symbolic model differentiation, automatic differentiation and compilation to CUDA GPUs. [Apache 2.0]
 
## Type providers
 * [ApiaryProvider](https://github.com/fsprojects/ApiaryProvider) - Type provider for Apiary.io. [Apache 2.0]
 * [AzureStorageTypeProvider](https://github.com/fsprojects/AzureStorageTypeProvider) - An F# Azure Type Provider which can be used to explore Blob, Table and Queue Azure Storage assets and easily apply CRUD operations on them. [Unilicense]
 * [COM Type Provider](https://github.com/fsprojects/FSharp.Interop.ComProvider) - A type provider for COM interop. [Unilicense]
 * [DynamicsCRMProvider](https://github.com/fsprojects/DynamicsCRMProvider) - A type provider for Microsoft Dynamics CRM 2011. [Apache 2.0]
 * [ExcelProvider](https://github.com/fsprojects/ExcelProvider) - Excel type provider. [Unilicense]
 * [FSharp.Configuration](https://github.com/fsprojects/FSharp.Configuration) - The project contains type providers for the configuration of .NET projects. Handles AppSettings, ResX, Yaml and Ini files. [Apache 2.0]
 * [FSharp.Data.DbPedia](http://fsprojects.github.io/FSharp.Data.DbPedia/) - An F# type provider for DBpedia. [Unilicense]
 * [FSharp.Data.HiveProvider](https://github.com/fsprojects/FSharp.Data.HiveProvider) - A demonstrator F# type provider for Apache Hive. [Apache 2.0]
 * [FSharp.Data.SqlClient](https://github.com/fsprojects/FSharp.Data.SqlClient) - An F# Type Provider for statically typed access to T-SQL command parameters and result set. [Apache 2.0]
 * [FSharp.Data.Toolbox](https://github.com/fsprojects/FSharp.Data.Toolbox) - A library for various data access APIs based on FSharp.Data. The library currently includes the Twitter type provider for access to Twitter users and feeds, and SAS type provider to read SAS dataset files. [Apache 2.0]
 * [FSharp.Data.TypeProviders](https://github.com/fsprojects/FSharp.Data.TypeProviders) - A library that contains type providers for `.edmx` files, `.dbml` files, WSLD services, OData services, and SQL databases. [Unilicense]
 * [FSharp.Data](https://github.com/fsharp/FSharp.Data) - Data science library that contains type providers for CSV, HTML, JSON, XML, and WorldBank data. [Apache 2.0]
 * [FSharp.Management](https://github.com/fsprojects/FSharp.Management) - The project contains various type providers for the management of the machine. Handles file system, registry,  Windows Management Instrumentation, PowerShell and SystemTimeZones. [Apache 2.0]
 * [FSharp.Text.RegexProvider](https://github.com/fsprojects/FSharp.Text.RegexProvider) - A type provider for regular expressions. [Apache 2.0]
 * [FsYaml](https://github.com/bleis-tift/FsYaml) - A typed Yaml library for F#. [NYSL Version 0.9982]
 * [GraphProvider](https://github.com/fsprojects/GraphProvider) - A `.dgml` state machine type provider. [Apache 2.0]
 * [MatDataProvider](https://github.com/fsprojects/matprovider) - An erased type provider for `.mat` files (binary MATLAB format files). [Apache 2.0]
 * [R Type Provider](https://github.com/BlueMountainCapital/FSharpRProvider) - Type provider to interop with R. [BSD-2-Clause]
 * [S3Provider](https://github.com/fsprojects/S3Provider) - Experimental type provider for Amazon S3 [MIT]
 * [SQLProvider](https://github.com/fsprojects/SQLProvider) - A general F# SQL database erasing type provider, supporting LINQ queries, schema exploration, individuals, CRUD operations and much more besides. [Apache 2.0]
 * [SwaggerProvider](https://github.com/fsprojects/SwaggerProvider) - F# generative Type Provider for Swagger. [Unilicense]

### Creating type providers
 * [FSharp.TypeProviders.StarterPack](https://github.com/fsprojects/FSharp.TypeProviders.StarterPack) - The ProvidedTypes SDK for creating F# type providers. [Apache 2.0]
 * [RestProvider](https://github.com/fsprojects/RestProvider) - Create type providers just by implementing a simple REST service [Apache 2.0]
 
## Development Tools

### IDE
 * [MonoDevelop](http://www.monodevelop.com/) - Cross-platform IDE mostly aimed at Mono/.NET developers. [LGPLv2 and X11/MIT]
 * [Visual Studio](https://www.visualstudio.com/) - IDE from Microsoft with first class F# support(Windows only). [Proprietary]
 * [Xamarin Studio](https://www.xamarin.com/studio) - Advanced IDE for iOS & Android. [Proprietary]

### Editor plugins
 * [F# Bindings](https://github.com/fsharp/fsharpbinding) - Archive of F# Language Bindings for Open Editors. [Apache 2.0]
 * [FSharpFar](https://github.com/nightroman/FarNet/tree/master/FSharpFar) - F# support for Far Manager. [BSD-3-Clause]
 * [Fantomas](https://github.com/dungpa/fantomas) - F# code formatter [Apache 2.0]
 * [Ionide](http://ionide.io/) - An Atom Editor and Visual Studio Code package suite for cross platform F# development. [MIT]
 * [Vim F#](https://github.com/fsharp/vim-fsharp) - F# support for Vim. [MIT]
 * [VimSpeak](https://github.com/AshleyF/VimSpeak) - VimSpeak lets you control Vim with your voice using speech recognition. [MIT]
 * [Visual F# Power Tools](http://fsprojects.github.io/VisualFSharpPowerTools/) - Power commands for F# in Visual Studio [Apache 2.0]

## Game development
 * [FsUnity](https://github.com/FsUnity) - F# Libraries, Tools, and Plugins for the Unity3d Game Engine. [Unilicense]
 * [Nu Game Engine](https://github.com/bryanedds/Nu) - Cross-platform F# 2D game engine built in the functional style. Uses SDL2 and Farseer Physics. [MIT]

## Logging
 * [Logary](https://logary.github.io/) - Logary is a high performance, multi-target logging, metric, tracing and health-check library for mono and .Net. [Apache 2.0]

## Package Management
 * [NuGet](https://www.nuget.org/) - NuGet is the package manager for the Microsoft development platform including .NET. [Apache 2.0]
 * [Paket](https://fsprojects.github.io/Paket/) - A dependency manager for .NET with support for NuGet packages and Git repositories. [MIT]

## Serialization
 * [FsPickler](http://mbraceproject.github.io/FsPickler/) - A fast, multi-format messaging serializer for .NET [MIT]

## Testing
 * [canopy](http://lefthandedgoat.github.io/canopy/) - F# web automation and testing framework. [MIT]
 * [Expecto](https://github.com/haf/expecto) – a smooth testing framework for F# with tests-as-values and parallelism by default. [Apache 2.0]
 * [FsCheck](https://fscheck.github.io/FsCheck/) - Random Testing for .NET. [BSD-3-Clause]
 * [FsUnit](http://fsprojects.github.io/FsUnit/) - FsUnit makes unit-testing with F# more enjoyable. It adds a special syntax to your favorite .NET testing framework. [???]
 * [Persimmon](https://github.com/persimmon-projects/Persimmon) - A unit test framework for F# using computation expressions. [MIT]
 * [xUnit.net](https://xunit.github.io/) - Free, open source, community-focused unit testing tool for the .NET Framework. [Apache 2.0]
 * [unquote](https://github.com/swensensoftware/unquote) - Write F# unit test assertions as quoted expressions. [Apache 2.0]

## Web frameworks
 * [ASP.NET Core MVC](https://github.com/aspnet/Mvc) - ASP.NET Core MVC is a model view controller framework for building dynamic web sites with clean separation of concerns, including the merged MVC, Web API, and Web Pages w/ Razor. [Apache 2.0]
 * [Freya](https://freya.io/) - Modern, purely functional stack for web programming in F#. [Apache 2.0]
 * [Giraffe](https://github.com/dustinmoris/Giraffe) - A native functional ASP.NET Core web framework for F# developers. [Apache 2.0]
 * [Nancy](http://nancyfx.org/) - Lightweight, low-ceremony, framework for building HTTP based services on .Net and Mono. [MIT]
 * [Suave](https://suave.io/) - Suave is a simple web development F# library providing a lightweight web server and a set of combinators to manipulate route flow and task composition. [Apache 2.0]
 * [WebSharper](http://websharper.com/) - F#-based web programming platform including a compiler from F# code to JavaScript. [Apache 2.0]

## Resources

### Blogs
 * [Don Syme's WebLog on F# and Related Topics](https://blogs.msdn.microsoft.com/dsyme/)
 * [Tomas Petricek's Blog](http://tomasp.net/blog/)
 * [Sergey Tihon's Blog](https://sergeytihon.wordpress.com/)
 * [Dave Thomas Blog](http://7sharpnine.com/)
 
### Cheatsheets
 * [F# cheatsheet](http://dungpa.github.io/fsharp-cheatsheet)
 * [F# tour](https://docs.microsoft.com/en-us/dotnet/articles/fsharp/tour)
 * [Learn F# in Y minutes](https://learnxinyminutes.com/docs/fsharp)

### Community
 * [F# on Github](https://github.com/fsharp/)
 * [F# on IRC](http://webchat.freenode.net/?channels=%23%23fsharp)
 * [F# on Slack](http://fsharp.org/guides/slack/)

### Other Lists
 * [Awesome .NET!](https://github.com/quozd/awesome-dotnet) - A collection of awesome .NET libraries, tools, frameworks and software. [CC0 1.0]
 * [F# Community Projects](http://fsharp.org/community/projects/)

### Websites
 * [F# Software Foundation](http://fsharp.org/)
 * [F# for Fun and Profit](https://fsharpforfunandprofit.com/)
 * [Try F#](http://www.tryfsharp.org)
 * [Community for F#](http://c4fsharp.net/) - links to dojos and recordings of community presentations.
