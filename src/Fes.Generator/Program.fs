open System
open System.IO
open Fes.Generator.Schema
open Fes.Generator.Emitters

[<EntryPoint>]
let main args =
    let schemaPath =
        args
        |> Array.tryFindIndex (fun a -> a = "--schema")
        |> Option.bind (fun i ->
            if i + 1 < args.Length then Some args[i + 1] else None)
        |> Option.defaultValue "schema/elasticsearch-schema.json"

    let outputDir =
        args
        |> Array.tryFindIndex (fun a -> a = "--output")
        |> Option.bind (fun i ->
            if i + 1 < args.Length then Some args[i + 1] else None)
        |> Option.defaultValue "src/Fes/Generated"

    let clean = args |> Array.contains "--clean"

    printfn $"Reading schema from: {schemaPath}"
    printfn $"Output directory: {outputDir}"

    if not (File.Exists schemaPath) then
        eprintfn $"Error: schema file not found at {schemaPath}"
        1
    else

    let model = SchemaReader.readSchemaFile schemaPath
    let index = TypeIndex.build model

    let endpointsToGenerate = index.EndpointsToGenerate.Length

    // Report stats
    let mutable interfaceCount = 0
    let mutable requestCount = 0
    let mutable responseCount = 0
    let mutable enumCount = 0
    let mutable typeAliasCount = 0
    let mutable containerVariantCount = 0
    let mutable internalTagCount = 0

    for t in model.Types do
        match t with
        | TypeDefinition.Interface d ->
            interfaceCount <- interfaceCount + 1
            match d.Variants with
            | Some (VariantKind.Container _) -> containerVariantCount <- containerVariantCount + 1
            | _ -> ()
        | TypeDefinition.Request _ -> requestCount <- requestCount + 1
        | TypeDefinition.Response _ -> responseCount <- responseCount + 1
        | TypeDefinition.Enum _ -> enumCount <- enumCount + 1
        | TypeDefinition.TypeAlias d ->
            typeAliasCount <- typeAliasCount + 1
            match d.Variants with
            | Some (VariantKind.InternalTag _) -> internalTagCount <- internalTagCount + 1
            | _ -> ()

    printfn ""
    printfn $"Schema: {model.Endpoints.Length} endpoints ({endpointsToGenerate} to generate), {model.Types.Length} types"
    printfn $"  Interfaces: {interfaceCount} (container DUs: {containerVariantCount})"
    printfn $"  Internal tag DUs: {internalTagCount}"
    printfn $"  Requests: {requestCount}, Responses: {responseCount}"
    printfn $"  Enums: {enumCount}, Type aliases: {typeAliasCount}"
    printfn ""

    // Clean output if requested
    if clean && Directory.Exists outputDir then
        printfn "Cleaning output directory..."
        for f in Directory.GetFiles(outputDir, "*.g.fs", SearchOption.AllDirectories) do
            File.Delete f

    // Generate type files
    printfn "Generating type files..."
    let typeFiles = FileEmitter.emitAllTypeFiles index model.Types
    FileEmitter.writeFiles outputDir typeFiles
    printfn $"  {typeFiles.Length} type files"

    // Generate operation files
    printfn "Generating operation files..."
    let operationFiles = OperationEmitter.emitAllOperationFiles index
    FileEmitter.writeFiles outputDir operationFiles
    printfn $"  {operationFiles.Length} operation files"

    // Generate builder files
    printfn "Generating builder files..."
    let builderFiles = BuilderEmitter.emitAllBuilderFiles index model.Types
    FileEmitter.writeFiles outputDir builderFiles
    printfn $"  {builderFiles.Length} builder files"

    // Generate ES module
    printfn "Generating ES module..."
    let esModule = ESModuleEmitter.emitESModule index
    FileEmitter.writeFiles outputDir [ esModule ]
    printfn "  1 ES module file"

    printfn ""
    printfn $"Generation complete: {typeFiles.Length + operationFiles.Length} files total"

    0
