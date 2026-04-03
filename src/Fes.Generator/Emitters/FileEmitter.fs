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
        TypeEmitter.emitTypeGroup w index group

    w.Dedent()
    filePath, w.ToString()

/// Emit all type files
let emitAllTypeFiles (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : (string * string) list =
    let grouped = groupTypesByNamespace types
    grouped
    |> Map.toList
    |> List.map (fun (ns, nsTypes) -> emitTypeFile index ns nsTypes)

/// Write files to disk
let writeFiles (outputDir: string) (files: (string * string) list) =
    for path, content in files do
        let fullPath = Path.Combine(outputDir, path)
        let dir = Path.GetDirectoryName(fullPath)
        if not (Directory.Exists dir) then
            Directory.CreateDirectory(dir) |> ignore
        File.WriteAllText(fullPath, content)
        printfn $"  Wrote {path}"
