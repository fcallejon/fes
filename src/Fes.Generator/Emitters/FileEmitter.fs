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

/// Check if a namespace should be merged into the core types file
let private isCoreTypeNamespace (ns: string) =
    ns.StartsWith("_types") || ns = "_spec_utils"

/// Emit all type files.
/// Core type namespaces (_types, _types.query_dsl, _types.mapping, etc.) are merged
/// into a single file to handle circular cross-namespace dependencies.
let emitAllTypeFiles (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : (string * string) list =
    let grouped = groupTypesByNamespace types

    // Separate core types from the rest
    let coreNamespaces, otherNamespaces =
        grouped
        |> Map.toList
        |> List.partition (fun (ns, _) -> isCoreTypeNamespace ns)

    // Merge all core namespaces into one file with all types together
    let coreFile =
        if coreNamespaces.IsEmpty then []
        else
            let allCoreTypes = coreNamespaces |> List.collect snd
            let sorted = DependencyGraph.topologicalSort allCoreTypes

            let w = FSharpWriter.Writer()
            w.Header()
            w.Namespace "Fes.Generated.Types"
            w.BlankLine()
            w.Open "System.Text.Json.Serialization"
            w.BlankLine()
            // Emit each core namespace as a nested module within CoreTypes
            // But to avoid self-reference issues, emit ALL types in one flat module
            w.Line "module CoreTypes ="
            w.BlankLine()
            w.Indent()

            // We need a merged namespace for resolution
            let mergedNs = "_types"
            for group in sorted do
                TypeEmitter.emitTypeGroup w index mergedNs group

            w.Dedent()
            [ "Types/CoreTypes.g.fs", w.ToString() ]

    let otherFiles =
        otherNamespaces
        |> List.map (fun (ns, nsTypes) -> emitTypeFile index ns nsTypes)

    coreFile @ otherFiles

/// Write files to disk
let writeFiles (outputDir: string) (files: (string * string) list) =
    for path, content in files do
        let fullPath = Path.Combine(outputDir, path)
        let dir = Path.GetDirectoryName(fullPath)
        if not (Directory.Exists dir) then
            Directory.CreateDirectory(dir) |> ignore
        File.WriteAllText(fullPath, content)
        printfn $"  Wrote {path}"
