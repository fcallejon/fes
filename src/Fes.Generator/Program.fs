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

    let testOutputDir =
        args
        |> Array.tryFindIndex (fun a -> a = "--test-output")
        |> Option.bind (fun i ->
            if i + 1 < args.Length then Some args[i + 1] else None)

    let clean = args |> Array.contains "--clean"

    printfn $"Reading schema from: {schemaPath}"
    printfn $"Output directory: {outputDir}"

    if not (File.Exists schemaPath) then
        eprintfn $"Error: schema file not found at {schemaPath}"
        1
    else

    let model, nameMap, index =
        try
            let model = SchemaReader.readSchemaFile schemaPath
            let nameMap = FileEmitter.buildNameMap model.Types
            let index = TypeIndex.build model |> TypeIndex.withNameMap nameMap
            model, nameMap, index
        with ex ->
            eprintfn $"Error: failed to read schema '{schemaPath}': {ex.Message}"
            exit 1

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

    // Generate converter files
    printfn "Generating serialisation converters..."
    let converterFiles = SerialiserEmitter.emitAllConverters index model.Types
    FileEmitter.writeFiles outputDir converterFiles
    printfn $"  {converterFiles.Length} converter files"

    // Generate builder files (Query.bool, Agg.terms, boolQuery { } etc.)
    printfn "Generating builder files..."
    let builderFiles = BuilderEmitter.emitAllBuilderFiles index model.Types
    FileEmitter.writeFiles outputDir builderFiles
    printfn $"  {builderFiles.Length} builder files"

    // Generate ES module
    printfn "Generating ES module..."
    let esModule = ESModuleEmitter.emitESModule index
    FileEmitter.writeFiles outputDir [ esModule ]
    printfn "  1 ES module file"

    let totalFiles = typeFiles.Length + operationFiles.Length + converterFiles.Length + builderFiles.Length + 1
    printfn ""
    printfn $"Generation complete: {totalFiles} files total"

    // Update fsproj
    let fsprojPath =
        args
        |> Array.tryFindIndex (fun a -> a = "--fsproj")
        |> Option.bind (fun i ->
            if i + 1 < args.Length then Some args[i + 1] else None)
        |> Option.defaultValue "src/Fes/Fes.fsproj"

    if File.Exists fsprojPath then
        printfn "Updating fsproj..."
        FsprojUpdater.updateFsproj fsprojPath outputDir
    else
        printfn $"Skipping fsproj update (not found: {fsprojPath})"

    // Generate test files if --test-output specified
    match testOutputDir with
    | Some testDir ->
        printfn ""
        printfn $"Generating test files to: {testDir}"

        let genDir = System.IO.Path.Combine(testDir, "Generated")
        if not (System.IO.Directory.Exists genDir) then
            System.IO.Directory.CreateDirectory(genDir) |> ignore

        let endpointTests = TestEmitter.emitEndpointTests index
        System.IO.File.WriteAllText(System.IO.Path.Combine(genDir, "EndpointTests.g.fs"), endpointTests)
        printfn "  Wrote EndpointTests.g.fs"

        let enumTests = TestEmitter.emitEnumTests index model.Types
        System.IO.File.WriteAllText(System.IO.Path.Combine(genDir, "EnumRoundTripTests.g.fs"), enumTests)
        printfn "  Wrote EnumRoundTripTests.g.fs"

        let variantTests = TestEmitter.emitVariantTests index model.Types
        System.IO.File.WriteAllText(System.IO.Path.Combine(genDir, "VariantTests.g.fs"), variantTests)
        printfn "  Wrote VariantTests.g.fs"
    | None -> ()

    0
