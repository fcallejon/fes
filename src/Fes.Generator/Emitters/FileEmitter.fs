module Fes.Generator.Emitters.FileEmitter

open System.IO
open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

/// Group types by their namespace (for file emission)
let groupTypesByNamespace (types: TypeDefinition list) : Map<string, TypeDefinition list> =
    types
    |> List.choose (fun td ->
        match td with
        | TypeDefinition.Request _ | TypeDefinition.Response _ -> None
        | _ -> Some (TypeDefinition.name td, td))
    |> List.groupBy (fun (tn, _) -> tn.Namespace)
    |> List.map (fun (ns, items) -> ns, items |> List.map snd)
    |> Map.ofList

/// Emit a single namespace's types into a .g.fs file
let emitTypeFile (index: TypeIndex.TypeIndex) (ns: string) (types: TypeDefinition list) : string * string =
    let filePath = Namespacing.toTypeFilePath ns
    let moduleName = Namespacing.toModuleName ns

    // Sort types within this namespace
    let sorted = DependencyGraph.topologicalSort types

    let w = Writer()
    w.Header()
    w.Namespace "Fes.Generated.Types"
    w.BlankLine()
    w.Open "System.Text.Json.Serialization"
    w.BlankLine()
    w.Line $"module {moduleName} ="
    w.BlankLine()
    w.Indent()

    for group in sorted do
        TypeEmitter.emitTypeGroup w index ns group

    w.Dedent()
    filePath, w.ToString()

/// Build a name map: TypeName → unique F# name.
/// Types in _types namespace keep short names, others get namespace-prefixed names.
/// Duplicates always get prefixed.
let buildNameMap (types: TypeDefinition list) : Map<TypeName, string> =
    let emittable =
        types |> List.filter (fun td ->
            match td with
            | TypeDefinition.Request _ | TypeDefinition.Response _ -> false
            | _ -> true)

    // Collect all names and find duplicates
    let allNames =
        emittable
        |> List.map (fun td -> TypeDefinition.name td)

    let shortNameCounts =
        allNames
        |> List.countBy (fun tn -> Namespacing.toFSharpTypeName tn.Name)
        |> Map.ofList

    let mutable nameMap = Map.empty
    for tn in allNames do
        let shortName = Namespacing.toFSharpTypeName tn.Name
        let isDuplicate = Map.tryFind shortName shortNameCounts |> Option.defaultValue 0 > 1
        let fsharpName =
            if isDuplicate then
                // Always prefix duplicates
                let prefix = Namespacing.toModuleName tn.Namespace
                $"{prefix}{shortName}"
            else
                shortName
        nameMap <- Map.add tn fsharpName nameMap
    nameMap

/// Emit all types into a single file to avoid cross-namespace circular dependencies.
let emitAllTypeFiles (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : (string * string) list =
    let allEmittableTypes =
        types
        |> List.filter (fun td ->
            match td with
            | TypeDefinition.Request _ | TypeDefinition.Response _ -> false
            | _ -> true)

    let nameMap = buildNameMap types
    let index = TypeIndex.withNameMap nameMap index
    let sorted = DependencyGraph.topologicalSort allEmittableTypes

    let w = FSharpWriter.Writer()
    w.Header()
    w.Namespace "Fes.Generated"
    w.BlankLine()
    w.Open "System.Text.Json.Serialization"
    w.BlankLine()
    w.Line "module Types ="
    w.BlankLine()
    w.Indent()

    let mergedNs = "__all__"
    for group in sorted do
        TypeEmitter.emitTypeGroup w index mergedNs group

    w.Dedent()

    [ "Types/AllTypes.g.fs", w.ToString() ]

/// Write files to disk
let writeFiles (outputDir: string) (files: (string * string) list) =
    for path, content in files do
        let fullPath = Path.Combine(outputDir, path)
        let dir = Path.GetDirectoryName(fullPath)
        if not (Directory.Exists dir) then
            Directory.CreateDirectory(dir) |> ignore
        File.WriteAllText(fullPath, content)
        printfn $"  Wrote {path}"
