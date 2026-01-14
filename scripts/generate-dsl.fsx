#!/usr/bin/env dotnet fsi

#r "nuget: YamlDotNet, 16.3.0"

open System
open System.IO
open System.Collections.Generic
open System.Text
open YamlDotNet.RepresentationModel

// ============================================================================
// Configuration
// ============================================================================

let specPath = Path.Combine(__SOURCE_DIRECTORY__, "esapi.2025-01.yaml")
let modelsOutputDir = Path.Combine(__SOURCE_DIRECTORY__, "..", "src", "Fes", "DSL", "Models")
let buildersOutputDir = Path.Combine(__SOURCE_DIRECTORY__, "..", "src", "Fes", "DSL")
let fsprojPath = Path.Combine(__SOURCE_DIRECTORY__, "..", "src", "Fes", "Fes.fsproj")

// ============================================================================
// YAML Helpers
// ============================================================================

let getScalar (node: YamlMappingNode) (key: string) =
    let keyNode = YamlScalarNode(key)
    if node.Children.ContainsKey(keyNode) then
        match node.Children[keyNode] with
        | :? YamlScalarNode as scalar -> Some scalar.Value
        | _ -> None
    else None

let getMapping (node: YamlMappingNode) (key: string) =
    let keyNode = YamlScalarNode(key)
    if node.Children.ContainsKey(keyNode) then
        match node.Children[keyNode] with
        | :? YamlMappingNode as mapping -> Some mapping
        | _ -> None
    else None

let getSequence (node: YamlMappingNode) (key: string) =
    let keyNode = YamlScalarNode(key)
    if node.Children.ContainsKey(keyNode) then
        match node.Children[keyNode] with
        | :? YamlSequenceNode as seq -> Some seq
        | _ -> None
    else None

let tryGetMapping (node: YamlNode) =
    match node with
    | :? YamlMappingNode as m -> Some m
    | _ -> None

// ============================================================================
// Type Model
// ============================================================================

type PropertyInfo = {
    Name: string
    Type: TypeRef
    Required: bool
    Description: string option
}

and TypeRef =
    | Primitive of string
    | Array of TypeRef
    | Dictionary of TypeRef
    | Reference of string
    | Enum of string list
    | Object of PropertyInfo list
    | OneOf of TypeRef list
    | AllOf of TypeRef list
    | Unknown

type SchemaDefinition = {
    FullName: string        // e.g., "_global.bulk.FailureStoreStatus"
    ModuleName: string      // e.g., "Global" or "Types"
    TypeName: string        // e.g., "FailureStoreStatus"
    Type: TypeRef
    Description: string option
    Discriminator: (string * Map<string, string>) option
    Dependencies: Set<string>  // Full names of referenced schemas
}

// ============================================================================
// Schema Parsing
// ============================================================================

let resolveRefName (ref: string) =
    if ref.StartsWith("#/components/schemas/") then
        Some (ref.Substring("#/components/schemas/".Length))
    else None

let rec parseTypeRef (node: YamlMappingNode) : TypeRef =
    match getScalar node "$ref" with
    | Some ref ->
        match resolveRefName ref with
        | Some name -> Reference name
        | None -> Unknown
    | None ->
        match getSequence node "oneOf" with
        | Some seq ->
            let types = seq.Children |> Seq.choose tryGetMapping |> Seq.map parseTypeRef |> Seq.toList
            OneOf types
        | None ->
            match getSequence node "allOf" with
            | Some seq ->
                let types = seq.Children |> Seq.choose tryGetMapping |> Seq.map parseTypeRef |> Seq.toList
                AllOf types
            | None ->
                match getScalar node "type" with
                | Some "string" ->
                    match getSequence node "enum" with
                    | Some enumSeq ->
                        let values = enumSeq.Children
                                     |> Seq.choose (function :? YamlScalarNode as s -> Some s.Value | _ -> None)
                                     |> Seq.toList
                        Enum values
                    | None -> Primitive "string"
                | Some "number" -> Primitive "number"
                | Some "integer" -> Primitive "integer"
                | Some "boolean" -> Primitive "boolean"
                | Some "array" ->
                    match getMapping node "items" with
                    | Some items -> Array (parseTypeRef items)
                    | None -> Array (Primitive "object")
                | Some "object" ->
                    match getMapping node "additionalProperties" with
                    | Some addProps -> Dictionary (parseTypeRef addProps)
                    | None ->
                        match getMapping node "properties" with
                        | Some props ->
                            let required =
                                match getSequence node "required" with
                                | Some reqSeq ->
                                    reqSeq.Children
                                    |> Seq.choose (function :? YamlScalarNode as s -> Some s.Value | _ -> None)
                                    |> Set.ofSeq
                                | None -> Set.empty
                            let properties =
                                props.Children
                                |> Seq.choose (fun kvp ->
                                    match kvp.Key, kvp.Value with
                                    | (:? YamlScalarNode as key), (:? YamlMappingNode as value) ->
                                        Some {
                                            Name = key.Value
                                            Type = parseTypeRef value
                                            Required = Set.contains key.Value required
                                            Description = getScalar value "description"
                                        }
                                    | _ -> None)
                                |> Seq.toList
                            Object properties
                        | None -> Object []
                | _ -> Unknown

// ============================================================================
// Name Utilities
// ============================================================================

let toPascalCase (s: string) =
    let sanitized =
        s.Replace(".", "_")
         .Replace(">", "Gt").Replace("<", "Lt").Replace("@", "At")
         .Replace("#", "Hash").Replace("$", "Dollar").Replace("%", "Percent")
         .Replace("&", "And").Replace("*", "Star").Replace("+", "Plus")
         .Replace("=", "Eq").Replace("!", "Bang").Replace("?", "Question")
         .Replace("/", "_").Replace("\\", "_").Replace(":", "_")
         .Replace(";", "_").Replace(",", "_").Replace("'", "")
         .Replace("\"", "").Replace("(", "").Replace(")", "")
         .Replace("[", "").Replace("]", "").Replace("{", "").Replace("}", "")
    let result =
        sanitized.Split([|'_'; '-'; ' '|], StringSplitOptions.RemoveEmptyEntries)
        |> Array.map (fun part ->
            if part.Length > 0 then Char.ToUpper(part[0]).ToString() + part.Substring(1)
            else "")
        |> String.concat ""
    if String.IsNullOrWhiteSpace(result) then "Value"
    elif Char.IsDigit(result[0]) then "N" + result
    else result

/// Get the module name from a schema full name
/// "_global.bulk.X" -> "Global"
/// "_types.query_dsl.X" -> "Types"
/// "some_other.X" -> "Other"
let getModuleName (fullName: string) =
    let parts = fullName.Split('.')
    if parts.Length > 0 then
        let firstPart = parts[0].TrimStart('_')
        toPascalCase firstPart
    else
        "Types"

/// Get the type name from a schema full name (fully qualified within module)
/// "_types.query_dsl.QueryContainer" -> "QueryDslQueryContainer"
let getTypeName (fullName: string) =
    let parts = fullName.Split('.')
    // Combine all parts except the first (module) into the type name
    if parts.Length > 1 then
        parts[1..]
        |> Array.map (fun p -> toPascalCase (p.TrimStart('_')))
        |> String.concat ""
    else
        toPascalCase parts[0]

/// Collect all schema references from a TypeRef
let rec collectReferences (typeRef: TypeRef) : Set<string> =
    match typeRef with
    | Reference name -> Set.singleton name
    | Array inner -> collectReferences inner
    | Dictionary inner -> collectReferences inner
    | Object props -> props |> List.collect (fun p -> collectReferences p.Type |> Set.toList) |> Set.ofList
    | OneOf refs -> refs |> List.collect (collectReferences >> Set.toList) |> Set.ofList
    | AllOf refs -> refs |> List.collect (collectReferences >> Set.toList) |> Set.ofList
    | _ -> Set.empty

// ============================================================================
// Schema Definition Parsing
// ============================================================================

let parseSchema (fullName: string) (node: YamlMappingNode) : SchemaDefinition =
    let moduleName = getModuleName fullName
    let typeName = getTypeName fullName
    let typeRef = parseTypeRef node
    let deps = collectReferences typeRef

    let discriminator =
        match getMapping node "discriminator" with
        | Some disc ->
            let propName = getScalar disc "propertyName"
            let mapping =
                match getMapping disc "mapping" with
                | Some m ->
                    m.Children
                    |> Seq.choose (fun kvp ->
                        match kvp.Key, kvp.Value with
                        | (:? YamlScalarNode as k), (:? YamlScalarNode as v) -> Some (k.Value, v.Value)
                        | _ -> None)
                    |> Map.ofSeq
                | None -> Map.empty
            match propName with
            | Some pn -> Some (pn, mapping)
            | None -> None
        | None -> None

    {
        FullName = fullName
        ModuleName = moduleName
        TypeName = typeName
        Type = typeRef
        Description = getScalar node "description"
        Discriminator = discriminator
        Dependencies = deps
    }

let extractAllSchemas (root: YamlMappingNode) : SchemaDefinition list =
    match getMapping root "components" with
    | Some components ->
        match getMapping components "schemas" with
        | Some schemas ->
            schemas.Children
            |> Seq.choose (fun kvp ->
                match kvp.Key, kvp.Value with
                | (:? YamlScalarNode as key), (:? YamlMappingNode as value) ->
                    Some (parseSchema key.Value value)
                | _ -> None)
            |> Seq.toList
        | None -> []
    | None -> []

// ============================================================================
// Request Type Detection
// ============================================================================

let rec collectRefsFromNode (node: YamlNode) : Set<string> =
    match node with
    | :? YamlMappingNode as mapping ->
        let refs = ResizeArray<string>()
        for kvp in mapping.Children do
            match kvp.Key with
            | :? YamlScalarNode as keyNode when keyNode.Value = "$ref" ->
                match kvp.Value with
                | :? YamlScalarNode as refNode ->
                    match resolveRefName refNode.Value with
                    | Some name -> refs.Add(name)
                    | None -> ()
                | _ -> ()
            | _ -> ()
            refs.AddRange(collectRefsFromNode kvp.Value)
        Set.ofSeq refs
    | :? YamlSequenceNode as seq ->
        seq.Children |> Seq.collect collectRefsFromNode |> Set.ofSeq
    | _ -> Set.empty

let extractRequestBodySchemas (root: YamlMappingNode) : Set<string> =
    match getMapping root "components" with
    | Some components ->
        match getMapping components "requestBodies" with
        | Some requestBodies ->
            requestBodies.Children
            |> Seq.collect (fun kvp -> collectRefsFromNode kvp.Value)
            |> Set.ofSeq
        | None -> Set.empty
    | None -> Set.empty

let expandReferencedSchemas (schemaMap: Map<string, SchemaDefinition>) (initialRefs: Set<string>) : Set<string> =
    let mutable allRefs = initialRefs
    let mutable toProcess = initialRefs
    while not (Set.isEmpty toProcess) do
        let newRefs =
            toProcess
            |> Seq.collect (fun name ->
                match schemaMap.TryFind name with
                | Some schema -> schema.Dependencies
                | None -> Set.empty)
            |> Set.ofSeq
            |> fun s -> Set.difference s allRefs
        allRefs <- Set.union allRefs newRefs
        toProcess <- newRefs
    allRefs

// ============================================================================
// Topological Sort Within Module
// ============================================================================

let topologicalSortWithinModule (schemas: SchemaDefinition list) : SchemaDefinition list =
    let schemaSet = schemas |> List.map (fun s -> s.FullName) |> Set.ofList
    let schemaMap = schemas |> List.map (fun s -> s.FullName, s) |> Map.ofList
    let visited = HashSet<string>()
    let result = ResizeArray<SchemaDefinition>()

    let rec visit (name: string) =
        if visited.Contains(name) then ()
        else
            visited.Add(name) |> ignore
            match schemaMap.TryFind name with
            | Some schema ->
                // Only visit dependencies that are within this module
                for dep in schema.Dependencies do
                    if Set.contains dep schemaSet then
                        visit dep
                result.Add(schema)
            | None -> ()

    for schema in schemas do
        visit schema.FullName

    result |> Seq.toList

// ============================================================================
// Code Generation
// ============================================================================

/// Set of all schema names in the current module
let mutable currentModuleSchemas = Set.empty<string>
/// Map from full name to type name within module
let mutable schemaTypeNames = Map.empty<string, string>
/// Current module name being generated
let mutable currentModuleName = ""
/// Set of modules that come before the current module in compilation order
let mutable availableModules = Set.empty<string>

let rec typeRefToFSharp (typeRef: TypeRef) : string =
    match typeRef with
    | Primitive "string" -> "string"
    | Primitive "number" -> "float"
    | Primitive "integer" -> "int"
    | Primitive "boolean" -> "bool"
    | Primitive _ -> "obj"
    | Array inner -> $"{typeRefToFSharp inner} array"
    | Dictionary inner -> $"Map<string, {typeRefToFSharp inner}>"
    | Reference name ->
        // Check if this reference is within the current module
        match schemaTypeNames.TryFind name with
        | Some typeName -> typeName  // Use simple type name within module
        | None ->
            // External reference - check if the target module is available
            // (has been compiled before the current module)
            let extModule = getModuleName name
            if Set.contains extModule availableModules then
                let extType = getTypeName name
                $"{extModule}.{extType}"
            else
                // Module not available yet (circular dependency) - use JsonElement for flexibility
                "System.Text.Json.JsonElement"
    | Enum _ -> "string"
    | Object props when props.Length > 0 ->
        // For inline objects with properties, use JsonElement for flexibility
        "System.Text.Json.JsonElement"
    | Object _ -> "obj"
    | OneOf types ->
        // If OneOf contains a single reference, use that type
        // Otherwise, for multiple types, use JsonElement for flexibility
        match types with
        | [single] -> typeRefToFSharp single
        | _ -> "System.Text.Json.JsonElement"
    | AllOf types ->
        // If AllOf contains a single reference, use that type directly
        // Otherwise, try to use JsonElement
        match types with
        | [single] -> typeRefToFSharp single
        | _ -> "System.Text.Json.JsonElement"
    | Unknown -> "obj"

let toJsonValue (s: string) = s.Replace("-", "_")

/// Generate an enum type with a custom JsonConverter (using and for mutual recursion)
let generateEnumWithConverter (typeName: string) (values: string list) (isFirst: bool) =
    let sb = StringBuilder()
    let validValues =
        values
        |> List.choose (fun v ->
            let caseName = toPascalCase v
            if String.IsNullOrWhiteSpace(caseName) || caseName.StartsWith("{") then None
            else Some (caseName, toJsonValue v))
        |> List.distinctBy fst

    if validValues.IsEmpty then None
    else
        let typeKeyword = if isFirst then "type" else "and"

        sb.AppendLine($"    {typeKeyword} {typeName}Converter() =") |> ignore
        sb.AppendLine($"        inherit JsonConverter<{typeName}>()") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"        override _.Write(writer: Utf8JsonWriter, value: {typeName}, _options: JsonSerializerOptions) =") |> ignore
        sb.AppendLine($"            let str =") |> ignore
        sb.AppendLine($"                match value with") |> ignore
        for (caseName, snakeCase) in validValues do
            sb.AppendLine($"                | {typeName}.{caseName} -> \"{snakeCase}\"") |> ignore
        sb.AppendLine($"            writer.WriteStringValue(str)") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"        override _.Read(reader: byref<Utf8JsonReader>, _typeToConvert: Type, _options: JsonSerializerOptions) =") |> ignore
        sb.AppendLine($"            match reader.GetString() with") |> ignore
        for (caseName, snakeCase) in validValues do
            sb.AppendLine($"            | \"{snakeCase}\" -> {typeName}.{caseName}") |> ignore
        sb.AppendLine($"            | s -> failwith $\"Unknown {typeName}: {{s}}\"") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine($"    and [<JsonConverter(typeof<{typeName}Converter>)>]") |> ignore
        sb.AppendLine($"        {typeName} =") |> ignore
        for (caseName, _) in validValues do
            sb.AppendLine($"        | {caseName}") |> ignore
        // Add ToString() override so that `string enumValue` returns the correct lowercase/snake_case value
        sb.AppendLine($"        with") |> ignore
        sb.AppendLine($"        override this.ToString() =") |> ignore
        sb.AppendLine($"            match this with") |> ignore
        for (caseName, snakeCase) in validValues do
            sb.AppendLine($"            | {caseName} -> \"{snakeCase}\"") |> ignore
        sb.AppendLine() |> ignore
        Some (sb.ToString())

let generateRecord (typeName: string) (props: PropertyInfo list) (description: string option) (isFirst: bool) =
    let sb = StringBuilder()
    let typeKeyword = if isFirst then "type" else "and"

    match description with
    | Some desc ->
        sb.AppendLine($"    /// <summary>") |> ignore
        for line in desc.Split('\n') |> Array.truncate 3 do
            let escaped = line.Trim().Replace("<", "&lt;").Replace(">", "&gt;")
            if not (String.IsNullOrWhiteSpace(escaped)) then
                sb.AppendLine($"    /// {escaped}") |> ignore
        sb.AppendLine($"    /// </summary>") |> ignore
    | None -> ()

    if props.Length = 0 then
        sb.AppendLine($"    {typeKeyword} {typeName} = obj") |> ignore
    else
        sb.AppendLine($"    {typeKeyword} {typeName} = {{") |> ignore
        let usedNames = HashSet<string>()
        for prop in props do
            let baseName = toPascalCase prop.Name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore
            let fsharpType = typeRefToFSharp prop.Type
            let finalType = if prop.Required then fsharpType else $"{fsharpType} option"
            sb.AppendLine($"        [<JsonPropertyName(\"{prop.Name}\")>]") |> ignore
            sb.AppendLine($"        {fsharpName}: {finalType}") |> ignore
        sb.AppendLine($"    }}") |> ignore
    sb.AppendLine() |> ignore
    sb.ToString()

let generateTypeAlias (typeName: string) (targetType: string) (description: string option) (isFirst: bool) =
    let sb = StringBuilder()
    let typeKeyword = if isFirst then "type" else "and"

    match description with
    | Some desc ->
        sb.AppendLine($"    /// <summary>") |> ignore
        for line in desc.Split('\n') |> Array.truncate 3 do
            let escaped = line.Trim().Replace("<", "&lt;").Replace(">", "&gt;")
            if not (String.IsNullOrWhiteSpace(escaped)) then
                sb.AppendLine($"    /// {escaped}") |> ignore
        sb.AppendLine($"    /// </summary>") |> ignore
    | None -> ()
    sb.AppendLine($"    {typeKeyword} {typeName} = {targetType}") |> ignore
    sb.AppendLine() |> ignore
    sb.ToString()

let generateDiscriminatorEnum (typeName: string) (discriminator: string * Map<string, string>) (isFirst: bool) =
    let (_, mapping) = discriminator
    let values =
        mapping |> Map.toList |> List.map fst
        |> List.filter (fun v -> not (v.StartsWith("{")) && not (String.IsNullOrWhiteSpace(v)))
    if values.IsEmpty then None
    else
        // Generate both the enum type AND the main type as obj alias
        let enumCode = generateEnumWithConverter (typeName + "Type") values isFirst
        match enumCode with
        | Some code ->
            let sb = StringBuilder()
            sb.Append(code) |> ignore
            // Also generate the main type as obj (since oneOf types can't be fully represented)
            sb.AppendLine($"    and {typeName} = obj") |> ignore
            sb.AppendLine() |> ignore
            Some (sb.ToString())
        | None -> None

let resolveAllOfProperties (schemaMap: Map<string, SchemaDefinition>) (typeRef: TypeRef) : PropertyInfo list =
    let rec resolve (tr: TypeRef) =
        match tr with
        | AllOf refs -> refs |> List.collect resolve
        | Reference name ->
            match schemaMap.TryFind name with
            | Some schema -> resolve schema.Type
            | None -> []
        | Object props -> props
        | _ -> []
    resolve typeRef

/// Generate a single type code (without file header)
let generateTypeCode (schema: SchemaDefinition) (allSchemas: Map<string, SchemaDefinition>) (isFirst: bool) : string option =
    let typeName = schema.TypeName
    if typeName.StartsWith("{") || String.IsNullOrWhiteSpace(typeName) then None
    else
        let typeCode =
            match schema.Discriminator with
            | Some disc -> generateDiscriminatorEnum typeName disc isFirst
            | None ->
                match schema.Type with
                | Enum values when values.Length > 0 ->
                    generateEnumWithConverter typeName values isFirst
                | Object props when props.Length > 0 ->
                    Some (generateRecord typeName props schema.Description isFirst)
                | AllOf _ ->
                    let resolvedProps = resolveAllOfProperties allSchemas schema.Type
                    if resolvedProps.Length > 0 then
                        Some (generateRecord typeName resolvedProps schema.Description isFirst)
                    else
                        Some (generateTypeAlias typeName "obj" schema.Description isFirst)
                | Reference refName ->
                    let targetType = typeRefToFSharp (Reference refName)
                    Some (generateTypeAlias typeName targetType schema.Description isFirst)
                | Primitive p ->
                    let fsharpType = match p with "string" -> "string" | "number" -> "float" | "integer" -> "int" | "boolean" -> "bool" | _ -> "obj"
                    Some (generateTypeAlias typeName fsharpType schema.Description isFirst)
                | Array inner ->
                    Some (generateTypeAlias typeName $"{typeRefToFSharp inner} array" schema.Description isFirst)
                | Dictionary inner ->
                    Some (generateTypeAlias typeName $"Map<string, {typeRefToFSharp inner}>" schema.Description isFirst)
                | OneOf _ ->
                    Some (generateTypeAlias typeName "obj" schema.Description isFirst)
                | _ ->
                    Some (generateTypeAlias typeName "obj" schema.Description isFirst)
        typeCode

/// Generate a module file containing all types for a module (legacy - separate files)
let generateModuleFile (moduleName: string) (schemas: SchemaDefinition list) (allSchemas: Map<string, SchemaDefinition>) (priorModules: Set<string>) : string =
    // Set up module context for type resolution
    currentModuleName <- moduleName
    currentModuleSchemas <- schemas |> List.map (fun s -> s.FullName) |> Set.ofList
    schemaTypeNames <- schemas |> List.map (fun s -> s.FullName, s.TypeName) |> Map.ofList
    availableModules <- priorModules

    // Sort types within module by dependencies
    let sortedSchemas = topologicalSortWithinModule schemas

    let sb = StringBuilder()
    sb.AppendLine("// Auto-generated from Elasticsearch OpenAPI spec") |> ignore
    sb.AppendLine("// Do not edit manually - regenerate using generate-dsl.fsx") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine($"namespace Fes.DSL.Models") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("open System") |> ignore
    sb.AppendLine("open System.Text.Json") |> ignore
    sb.AppendLine("open System.Text.Json.Serialization") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine($"module {moduleName} =") |> ignore
    sb.AppendLine() |> ignore

    let mutable isFirst = true
    for schema in sortedSchemas do
        match generateTypeCode schema allSchemas isFirst with
        | Some code ->
            sb.Append(code) |> ignore
            isFirst <- false
        | None -> ()

    sb.ToString()

/// Generate a single consolidated file with all types using mutual recursion (and keyword)
let generateConsolidatedTypesFile (allSchemas: SchemaDefinition list) (schemaMap: Map<string, SchemaDefinition>) : string =
    // Deduplicate schemas by TypeName (some OpenAPI namespaces have same type names)
    let deduplicatedSchemas =
        allSchemas
        |> List.distinctBy (fun s -> s.TypeName)

    printfn "Deduplicated from %d to %d schemas" (List.length allSchemas) (List.length deduplicatedSchemas)

    // Set up context - all schemas available, no module prefixes needed
    currentModuleName <- ""
    currentModuleSchemas <- deduplicatedSchemas |> List.map (fun s -> s.FullName) |> Set.ofList
    // Map full names to just type names (no module prefix since all in one file)
    schemaTypeNames <- deduplicatedSchemas |> List.map (fun s -> s.FullName, s.TypeName) |> Map.ofList
    availableModules <- Set.empty  // Not used in consolidated mode

    // Sort all schemas topologically
    let sortedSchemas = topologicalSortWithinModule deduplicatedSchemas

    let sb = StringBuilder()
    sb.AppendLine("// Auto-generated from Elasticsearch OpenAPI spec") |> ignore
    sb.AppendLine("// Do not edit manually - regenerate using generate-dsl.fsx") |> ignore
    sb.AppendLine("// This file contains all Elasticsearch types with mutual recursion support") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("namespace Fes.DSL.Models") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("open System") |> ignore
    sb.AppendLine("open System.Text.Json") |> ignore
    sb.AppendLine("open System.Text.Json.Serialization") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("[<AutoOpen>]") |> ignore
    sb.AppendLine("module Types =") |> ignore
    sb.AppendLine() |> ignore

    let mutable isFirst = true
    for schema in sortedSchemas do
        match generateTypeCode schema schemaMap isFirst with
        | Some code ->
            sb.Append(code) |> ignore
            isFirst <- false
        | None -> ()

    sb.ToString()

/// Generate a builder file for a type
let generateBuilderFile (schema: SchemaDefinition) (allSchemas: Map<string, SchemaDefinition>) : string option =
    let typeName = schema.TypeName
    let props =
        match schema.Discriminator with
        | None ->
            match schema.Type with
            | Object props when props.Length > 0 -> Some props
            | AllOf _ ->
                let resolvedProps = resolveAllOfProperties allSchemas schema.Type
                if resolvedProps.Length > 0 then Some resolvedProps else None
            | _ -> None
        | _ -> None

    match props with
    | None -> None
    | Some props ->
        // All types are in consolidated Types module
        let sb = StringBuilder()
        sb.AppendLine("// Auto-generated builder from Elasticsearch OpenAPI spec") |> ignore
        sb.AppendLine("// Do not edit manually - regenerate using generate-dsl.fsx") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("namespace Fes.DSL.Builders") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("open System") |> ignore
        sb.AppendLine("open Fes.DSL.Models.Types") |> ignore
        sb.AppendLine() |> ignore
        sb.AppendLine("[<AutoOpen>]") |> ignore
        sb.AppendLine($"module {typeName}Builder =") |> ignore

        let builderName = $"{typeName}Builder"
        sb.AppendLine($"    type {builderName}() =") |> ignore
        sb.AppendLine($"        member _.Yield(_: unit) : {typeName} =") |> ignore
        sb.AppendLine($"            {{") |> ignore

        let usedNames = HashSet<string>()
        for prop in props do
            let baseName = toPascalCase prop.Name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore
            let fsharpType = typeRefToFSharp prop.Type
            let defaultValue =
                if prop.Required then
                    match prop.Type with
                    | Primitive "string" -> "String.Empty"
                    | Primitive "number" -> "0.0"
                    | Primitive "integer" -> "0"
                    | Primitive "boolean" -> "false"
                    | Array _ -> "[||]"
                    | _ -> $"Unchecked.defaultof<{fsharpType}>"
                else "Option.None"
            sb.AppendLine($"                {typeName}.{fsharpName} = {defaultValue}") |> ignore

        sb.AppendLine($"            }} : {typeName}") |> ignore
        sb.AppendLine() |> ignore

        usedNames.Clear()
        let operationNames = HashSet<string>()
        for prop in props do
            let baseName = toPascalCase prop.Name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore

            let baseOpName = prop.Name.Replace(".", "_").Replace("-", "_")
            let mutable opName = baseOpName
            let mutable opSuffix = 2
            while operationNames.Contains(opName) do
                opName <- $"{baseOpName}{opSuffix}"
                opSuffix <- opSuffix + 1
            operationNames.Add(opName) |> ignore

            let fsharpType = typeRefToFSharp prop.Type
            sb.AppendLine($"        [<CustomOperation(\"{opName}\")>]") |> ignore
            if prop.Required then
                sb.AppendLine($"        member _.{fsharpName}(state: {typeName}, value: {fsharpType}) =") |> ignore
                sb.AppendLine($"            {{ state with {typeName}.{fsharpName} = value }} : {typeName}") |> ignore
            else
                sb.AppendLine($"        member _.{fsharpName}(state: {typeName}, value: {fsharpType}) =") |> ignore
                sb.AppendLine($"            {{ state with {typeName}.{fsharpName} = Option.Some value }} : {typeName}") |> ignore
            sb.AppendLine() |> ignore

        let instanceName = Char.ToLower(typeName[0]).ToString() + typeName.Substring(1)
        sb.AppendLine($"    let {instanceName} = {builderName}()") |> ignore

        Some (sb.ToString())

// ============================================================================
// Main Execution
// ============================================================================

// Mutable references for resolving $ref references (must be declared before YAML loading)
let mutable requestBodiesNode : YamlMappingNode option = None
let mutable parametersNode : YamlMappingNode option = None

printfn "=== Elasticsearch DSL Code Generator ==="
printfn ""

if not (File.Exists(specPath)) then
    printfn "ERROR: Spec file not found at %s" specPath
    exit 1

printfn "Loading spec from %s..." specPath
let yamlContent = File.ReadAllText(specPath)

printfn "Parsing YAML..."
let reader = new StringReader(yamlContent)
let yaml = YamlStream()
yaml.Load(reader)
let root = yaml.Documents[0].RootNode :?> YamlMappingNode

// Initialize requestBodiesNode for resolving requestBody references
requestBodiesNode <-
    match getMapping root "components" with
    | Some components ->
        match getMapping components "requestBodies" with
        | Some rb -> Some rb
        | None -> None
    | None -> None
printfn "RequestBodies node initialized: %b" requestBodiesNode.IsSome

parametersNode <-
    match getMapping root "components" with
    | Some components ->
        match getMapping components "parameters" with
        | Some p -> Some p
        | None -> None
    | None -> None
printfn "Parameters node initialized: %b" parametersNode.IsSome

printfn "Extracting schemas..."
let allSchemas = extractAllSchemas root
printfn "Found %d schemas" (List.length allSchemas)

let schemaMap = allSchemas |> List.map (fun s -> s.FullName, s) |> Map.ofList

// Identify request types
printfn "Identifying request types..."
let requestBodyRefs = extractRequestBodySchemas root
let requestTypes = expandReferencedSchemas schemaMap requestBodyRefs
printfn "Found %d request types" (Set.count requestTypes)

let isRequestType (fullName: string) = Set.contains fullName requestTypes

// Group schemas by module
printfn "Grouping schemas by module..."
let schemasByModule =
    allSchemas
    |> List.groupBy (fun s -> s.ModuleName)
    |> Map.ofList

printfn "Found %d modules:" (Map.count schemasByModule)
for kvp in schemasByModule do
    printfn "  - %s: %d types" kvp.Key (List.length kvp.Value)

// Ensure output directories exist
if not (Directory.Exists(modelsOutputDir)) then
    Directory.CreateDirectory(modelsOutputDir) |> ignore
if not (Directory.Exists(buildersOutputDir)) then
    Directory.CreateDirectory(buildersOutputDir) |> ignore

// Delete old generated files
printfn ""
printfn "Cleaning old generated files..."
for file in Directory.GetFiles(modelsOutputDir, "*.g.fs") do
    File.Delete(file)
for file in Directory.GetFiles(buildersOutputDir, "*.Builder.g.fs") do
    File.Delete(file)

printfn ""
printfn "Generating consolidated types file..."

let generatedModelFiles = ResizeArray<string>()

// Generate a single consolidated file with all types
let consolidatedContent = generateConsolidatedTypesFile allSchemas schemaMap
let consolidatedFileName = "Types.g.fs"
let consolidatedFilePath = Path.Combine(modelsOutputDir, consolidatedFileName)
File.WriteAllText(consolidatedFilePath, consolidatedContent)
generatedModelFiles.Add(consolidatedFileName)
printfn "Generated %s with %d types" consolidatedFileName (List.length allSchemas)

// Skip type builders - only generate operation builders
// Type builders were causing issues and aren't needed
printfn ""
printfn "Skipping type builders (not needed - operations have built-in builders)"

// ============================================================================
// Operation Parsing and Generation
// ============================================================================

type HttpMethod = Get | Post | Put | Delete | Head | Patch

type OperationParameter = {
    Name: string
    In: string  // "path" | "query"
    Required: bool
    Type: TypeRef
    Description: string option
}

type OperationDefinition = {
    OperationId: string
    Path: string
    Method: HttpMethod
    Tags: string list
    Summary: string option
    PathParameters: OperationParameter list
    QueryParameters: OperationParameter list
    RequestBodyRef: string option  // Reference to requestBody schema
    RequestBodyInline: PropertyInfo list option  // Inline properties
    ResponseRef: string option  // Reference to response schema
    ResponseInline: PropertyInfo list option  // Inline response properties
}

let parseHttpMethod (method: string) =
    match method.ToLower() with
    | "get" -> Some Get
    | "post" -> Some Post
    | "put" -> Some Put
    | "delete" -> Some Delete
    | "head" -> Some Head
    | "patch" -> Some Patch
    | _ -> None

let httpMethodToString (method: HttpMethod) =
    match method with
    | Get -> "Get"
    | Post -> "Post"
    | Put -> "Put"
    | Delete -> "Delete"
    | Head -> "Head"
    | Patch -> "Patch"

let httpMethodToFes (method: HttpMethod) =
    match method with
    | Get -> "Fes.Http.Method.Get"
    | Post -> "Fes.Http.Method.Post"
    | Put -> "Fes.Http.Method.Put"
    | Delete -> "Fes.Http.Method.Delete"
    | Head -> "Fes.Http.Method.Head"
    | Patch -> "Fes.Http.Method.Patch"

let parseInlineParameter (node: YamlMappingNode) : OperationParameter option =
    match getScalar node "name", getScalar node "in" with
    | Some name, Some location ->
        let required = getScalar node "required" |> Option.map (fun s -> s = "true") |> Option.defaultValue false
        let typeRef =
            match getMapping node "schema" with
            | Some schema -> parseTypeRef schema
            | None -> Primitive "string"
        Some {
            Name = name
            In = location
            Required = required
            Type = typeRef
            Description = getScalar node "description"
        }
    | _ -> None

let parseOperationParameter (node: YamlMappingNode) : OperationParameter option =
    // First check if this is a reference to a parameter
    match getScalar node "$ref" with
    | Some ref ->
        // Extract name from reference like "#/components/parameters/indices.put_settings-index"
        let refParts = ref.Split('/')
        if refParts.Length >= 4 && refParts.[2] = "parameters" then
            let paramName = refParts.[refParts.Length - 1]
            // Look up the referenced parameter
            match parametersNode with
            | Some pNode ->
                match getMapping pNode paramName with
                | Some referencedParam -> parseInlineParameter referencedParam
                | None -> None
            | None -> None
        else
            None
    | None ->
        // Not a reference, parse inline
        parseInlineParameter node

let rec parseRequestBodyContent (node: YamlMappingNode) : (string option * PropertyInfo list option) =
    match getMapping node "content" with
    | Some content ->
        match getMapping content "application/json" with
        | Some json ->
            match getMapping json "schema" with
            | Some schema ->
                // Check for $ref first
                match getScalar schema "$ref" with
                | Some ref ->
                    match resolveRefName ref with
                    | Some name -> (Some name, None)
                    | None -> (None, None)
                | None ->
                    // Inline schema - parse properties
                    match getMapping schema "properties" with
                    | Some props ->
                        let requiredFields =
                            match getSequence schema "required" with
                            | Some seq ->
                                seq.Children
                                |> Seq.choose (function :? YamlScalarNode as s -> Some s.Value | _ -> None)
                                |> Set.ofSeq
                            | None -> Set.empty
                        let properties =
                            props.Children
                            |> Seq.choose (fun kvp ->
                                match kvp.Key, kvp.Value with
                                | (:? YamlScalarNode as key), (:? YamlMappingNode as value) ->
                                    Some {
                                        Name = key.Value
                                        Type = parseTypeRef value
                                        Required = Set.contains key.Value requiredFields
                                        Description = getScalar value "description"
                                    }
                                | _ -> None)
                            |> Seq.toList
                        (None, Some properties)
                    | None -> (None, None)
            | None -> (None, None)
        | None -> (None, None)
    | None -> (None, None)

let parseRequestBody (node: YamlMappingNode) : (string option * PropertyInfo list option) =
    // First check if this is a reference to a requestBody
    match getScalar node "$ref" with
    | Some ref ->
        // Extract name from reference like "#/components/requestBodies/search"
        let refParts = ref.Split('/')
        if refParts.Length >= 4 && refParts.[2] = "requestBodies" then
            let bodyName = refParts.[refParts.Length - 1]
            // Look up the referenced requestBody
            match requestBodiesNode with
            | Some rbNode ->
                match getMapping rbNode bodyName with
                | Some referencedBody -> parseRequestBodyContent referencedBody
                | None -> (None, None)
            | None -> (None, None)
        else
            (None, None)
    | None ->
        // Not a reference, parse directly
        parseRequestBodyContent node

/// Parse response schema from responses section
let parseResponse (node: YamlMappingNode) : (string option * PropertyInfo list option) =
    // Look for '200' response first
    match getMapping node "200" with
    | Some response200 ->
        match getMapping response200 "content" with
        | Some content ->
            match getMapping content "application/json" with
            | Some json ->
                match getMapping json "schema" with
                | Some schema ->
                    // Check for $ref first
                    match getScalar schema "$ref" with
                    | Some ref ->
                        match resolveRefName ref with
                        | Some name -> (Some name, None)
                        | None -> (None, None)
                    | None ->
                        // Inline schema - parse properties
                        match getMapping schema "properties" with
                        | Some props ->
                            let requiredFields =
                                match getSequence schema "required" with
                                | Some seq ->
                                    seq.Children
                                    |> Seq.choose (function :? YamlScalarNode as s -> Some s.Value | _ -> None)
                                    |> Set.ofSeq
                                | None -> Set.empty
                            let properties =
                                props.Children
                                |> Seq.choose (fun kvp ->
                                    match kvp.Key, kvp.Value with
                                    | (:? YamlScalarNode as key), (:? YamlMappingNode as value) ->
                                        Some {
                                            Name = key.Value
                                            Type = parseTypeRef value
                                            Required = Set.contains key.Value requiredFields
                                            Description = getScalar value "description"
                                        }
                                    | _ -> None)
                                |> Seq.toList
                            (None, Some properties)
                        | None -> (None, None)
                | None -> (None, None)
            | None -> (None, None)
        | None -> (None, None)
    | None -> (None, None)

let parseOperation (path: string) (method: string) (node: YamlMappingNode) : OperationDefinition option =
    match getScalar node "operationId", parseHttpMethod method with
    | Some opId, Some httpMethod ->
        let tags =
            match getSequence node "tags" with
            | Some seq ->
                seq.Children
                |> Seq.choose (function :? YamlScalarNode as s -> Some s.Value | _ -> None)
                |> Seq.toList
            | None -> []

        let parameters =
            match getSequence node "parameters" with
            | Some seq ->
                seq.Children
                |> Seq.choose (fun n ->
                    match n with
                    | :? YamlMappingNode as m -> parseOperationParameter m
                    | _ -> None)
                |> Seq.toList
            | None -> []

        let pathParams = parameters |> List.filter (fun p -> p.In = "path")
        let queryParams = parameters |> List.filter (fun p -> p.In = "query")

        let (bodyRef, bodyInline) =
            match getMapping node "requestBody" with
            | Some rb -> parseRequestBody rb
            | None -> (None, None)

        let (responseRef, responseInline) =
            match getMapping node "responses" with
            | Some responses -> parseResponse responses
            | None -> (None, None)

        Some {
            OperationId = opId
            Path = path
            Method = httpMethod
            Tags = tags
            Summary = getScalar node "summary"
            PathParameters = pathParams
            QueryParameters = queryParams
            RequestBodyRef = bodyRef
            RequestBodyInline = bodyInline
            ResponseRef = responseRef
            ResponseInline = responseInline
        }
    | _ -> None

let extractAllOperations (root: YamlMappingNode) : OperationDefinition list =
    match getMapping root "paths" with
    | Some paths ->
        paths.Children
        |> Seq.collect (fun pathKvp ->
            match pathKvp.Key, pathKvp.Value with
            | (:? YamlScalarNode as pathNode), (:? YamlMappingNode as pathValue) ->
                let path = pathNode.Value
                pathValue.Children
                |> Seq.choose (fun methodKvp ->
                    match methodKvp.Key, methodKvp.Value with
                    | (:? YamlScalarNode as methodNode), (:? YamlMappingNode as opNode) ->
                        parseOperation path methodNode.Value opNode
                    | _ -> None)
            | _ -> Seq.empty)
        |> Seq.toList
    | None -> []

/// Generate operation type name from operationId
/// "indices-create" -> "IndicesCreateRequest"
let operationToTypeName (opId: string) =
    opId.Split([|'-'; '_'; '.'|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map toPascalCase
    |> String.concat ""
    |> fun s -> s + "Request"

/// Generate module name for operation grouping
let operationToModuleName (op: OperationDefinition) =
    match op.Tags with
    | tag :: _ -> toPascalCase tag
    | [] ->
        // Fallback to first part of operationId
        op.OperationId.Split('-').[0] |> toPascalCase

/// Generate an operation request type with ToRequest static member
let generateOperationRequestType (op: OperationDefinition) : string =
    let typeName = operationToTypeName op.OperationId
    let sb = StringBuilder()

    // Collect all fields
    let pathFields =
        op.PathParameters
        |> List.map (fun p ->
            let fsharpType = typeRefToFSharp p.Type
            { Name = p.Name; Type = p.Type; Required = p.Required; Description = p.Description })

    let queryFields =
        op.QueryParameters
        |> List.map (fun p ->
            { Name = p.Name; Type = p.Type; Required = p.Required; Description = p.Description })

    let bodyFields =
        match op.RequestBodyInline with
        | Some props -> props
        | None ->
            // If there's a body reference, create a single "body" field
            match op.RequestBodyRef with
            | Some bodyTypeName ->
                [{ Name = "body"; Type = TypeRef.Reference bodyTypeName; Required = true; Description = None }]
            | None -> []

    let allFields = pathFields @ queryFields @ bodyFields

    let hasQueryParams = not op.QueryParameters.IsEmpty
    let hasBody = op.RequestBodyInline.IsSome || op.RequestBodyRef.IsSome
    let hasBodyRef = op.RequestBodyRef.IsSome && op.RequestBodyInline.IsNone
    let httpMethod = httpMethodToFes op.Method

    if allFields.IsEmpty then
        sb.AppendLine($"    type {typeName} = unit") |> ignore
    else
        // First pass: compute renamed field names to handle collisions
        let usedNames = HashSet<string>()
        let fieldNameMap = System.Collections.Generic.Dictionary<string, string>() // "location:originalName" -> fsharpName

        // Path parameters first
        for pathParam in op.PathParameters do
            let baseName = toPascalCase pathParam.Name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore
            fieldNameMap.[$"path:{pathParam.Name}"] <- fsharpName

        // Query parameters
        for queryParam in op.QueryParameters do
            let baseName = toPascalCase queryParam.Name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore
            fieldNameMap.[$"query:{queryParam.Name}"] <- fsharpName

        // Body fields
        for bodyField in bodyFields do
            let baseName = toPascalCase bodyField.Name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore
            fieldNameMap.[$"body:{bodyField.Name}"] <- fsharpName

        // Generate the record type
        sb.AppendLine($"    type {typeName} = {{") |> ignore

        // Path parameters - no JsonPropertyName since they go in URL path, not JSON body
        for pathParam in op.PathParameters do
            let fsharpName = fieldNameMap.[$"path:{pathParam.Name}"]
            let fsharpType = typeRefToFSharp pathParam.Type
            let finalType = if pathParam.Required then fsharpType else $"{fsharpType} option"
            sb.AppendLine($"        {fsharpName}: {finalType}") |> ignore

        // Query parameters - no JsonPropertyName since they go in URL query string, not JSON body
        for queryParam in op.QueryParameters do
            let fsharpName = fieldNameMap.[$"query:{queryParam.Name}"]
            let fsharpType = typeRefToFSharp queryParam.Type
            let finalType = if queryParam.Required then fsharpType else $"{fsharpType} option"
            sb.AppendLine($"        {fsharpName}: {finalType}") |> ignore

        // Body fields - these DO need JsonPropertyName for JSON serialization
        for bodyField in bodyFields do
            let fsharpName = fieldNameMap.[$"body:{bodyField.Name}"]
            let fsharpType = typeRefToFSharp bodyField.Type
            let finalType = if bodyField.Required then fsharpType else $"{fsharpType} option"
            sb.AppendLine($"        [<JsonPropertyName(\"{bodyField.Name}\")>]") |> ignore
            sb.AppendLine($"        {fsharpName}: {finalType}") |> ignore

        sb.AppendLine($"    }} with") |> ignore

        // Add static member ToRequest for SRTP compatibility with Http.toRequest
        sb.AppendLine($"        static member ToRequest(request: {typeName}) : Result<Fes.Http.RequestMsg, exn> =") |> ignore
        sb.AppendLine($"            try") |> ignore

        // Build path with substitutions using correctly renamed field names
        let pathTemplate = op.Path
        if op.PathParameters.IsEmpty then
            sb.AppendLine($"                let path = \"{pathTemplate}\"") |> ignore
        else
            let mutable pathStr = pathTemplate
            for pathParam in op.PathParameters do
                let fsharpName = fieldNameMap.[$"path:{pathParam.Name}"]
                pathStr <- pathStr.Replace($"{{{pathParam.Name}}}", $"{{request.{fsharpName}}}")
            sb.AppendLine($"                let path = $\"{pathStr}\"") |> ignore

        // Build query string using correctly renamed field names
        if hasQueryParams then
            sb.AppendLine($"                let queryParams =") |> ignore
            sb.AppendLine($"                    [") |> ignore
            for qp in op.QueryParameters do
                let fsharpName = fieldNameMap.[$"query:{qp.Name}"]
                if qp.Required then
                    sb.AppendLine($"                        Some (\"{qp.Name}\", Fes.Http.toQueryValue request.{fsharpName})") |> ignore
                else
                    sb.AppendLine($"                        request.{fsharpName} |> Option.map (fun v -> \"{qp.Name}\", Fes.Http.toQueryValue v)") |> ignore
            sb.AppendLine($"                    ] |> List.choose id") |> ignore
            sb.AppendLine($"                let queryString =") |> ignore
            sb.AppendLine($"                    if List.isEmpty queryParams then \"\"") |> ignore
            sb.AppendLine($"                    else \"?\" + (queryParams |> List.map (fun (k,v) -> k + \"=\" + v) |> String.concat \"&\")") |> ignore
            sb.AppendLine($"                let fullPath = path + queryString") |> ignore
        else
            sb.AppendLine($"                let fullPath = path") |> ignore

        // Build the request
        sb.AppendLine($"                fullPath") |> ignore
        sb.AppendLine($"                |> Fes.Http.Request.fromPath") |> ignore
        sb.AppendLine($"                |> Fes.Http.Request.withMethod {httpMethod}") |> ignore

        if hasBody then
            // If body is a reference type, serialize the Body field
            // Otherwise, create an anonymous record with just the body fields (excluding path/query params)
            if hasBodyRef then
                sb.AppendLine($"                |> Fes.Http.Request.withJsonBody request.Body") |> ignore
            else
                // Build anonymous record with only body fields
                match op.RequestBodyInline with
                | Some inlineProps when not inlineProps.IsEmpty ->
                    let bodyFieldAssignments =
                        inlineProps
                        |> List.map (fun prop ->
                            let fsharpName = fieldNameMap.[$"body:{prop.Name}"]
                            // Use backticks for field names that contain hyphens or are reserved words
                            $"``{prop.Name}`` = request.{fsharpName}")
                        |> String.concat "; "
                    sb.AppendLine($"                |> Fes.Http.Request.withJsonBody {{| {bodyFieldAssignments} |}}") |> ignore
                | _ -> ()

        sb.AppendLine($"                |> Result.Ok") |> ignore
        sb.AppendLine($"            with ex -> Result.Error ex") |> ignore

    sb.ToString()

/// Generate operation builder
let generateOperationBuilder (op: OperationDefinition) : string =
    let typeName = operationToTypeName op.OperationId
    let builderName = $"{typeName}Builder"
    let sb = StringBuilder()

    // Collect all fields
    let pathFields =
        op.PathParameters
        |> List.map (fun p ->
            (p.Name, typeRefToFSharp p.Type, p.Required))

    let queryFields =
        op.QueryParameters
        |> List.map (fun p ->
            (p.Name, typeRefToFSharp p.Type, p.Required))

    let bodyFields =
        match op.RequestBodyInline with
        | Some props -> props |> List.map (fun p -> (p.Name, typeRefToFSharp p.Type, p.Required))
        | None ->
            // If there's a body reference, create a single "body" field
            match op.RequestBodyRef with
            | Some bodyTypeName ->
                let fsharpTypeName = typeRefToFSharp (TypeRef.Reference bodyTypeName)
                [("body", fsharpTypeName, true)]
            | None -> []

    let allFields = pathFields @ queryFields @ bodyFields

    if allFields.IsEmpty then
        sb.AppendLine($"    let {Char.ToLower(typeName[0])}{typeName.Substring(1)} = ()") |> ignore
    else
        sb.AppendLine($"    type {builderName}() =") |> ignore
        sb.AppendLine($"        member _.Yield(_: unit) : {typeName} =") |> ignore
        sb.AppendLine($"            {{") |> ignore

        let usedNames = HashSet<string>()
        for (name, fsharpType, required) in allFields do
            let baseName = toPascalCase name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore
            let defaultValue =
                if required then
                    match fsharpType with
                    | "string" -> "String.Empty"
                    | "float" -> "0.0"
                    | "int" -> "0"
                    | "bool" -> "false"
                    | t when t.EndsWith(" array") -> "[||]"
                    | _ -> $"Unchecked.defaultof<{fsharpType}>"
                else "Option.None"
            sb.AppendLine($"                {typeName}.{fsharpName} = {defaultValue}") |> ignore

        sb.AppendLine($"            }} : {typeName}") |> ignore
        sb.AppendLine() |> ignore

        usedNames.Clear()
        let operationNames = HashSet<string>()
        for (name, fsharpType, required) in allFields do
            let baseName = toPascalCase name
            let mutable fsharpName = baseName
            let mutable suffix = 2
            while usedNames.Contains(fsharpName) do
                fsharpName <- $"{baseName}{suffix}"
                suffix <- suffix + 1
            usedNames.Add(fsharpName) |> ignore

            let baseOpName = name.Replace(".", "_").Replace("-", "_")
            let mutable opName = baseOpName
            let mutable opSuffix = 2
            while operationNames.Contains(opName) do
                opName <- $"{baseOpName}{opSuffix}"
                opSuffix <- opSuffix + 1
            operationNames.Add(opName) |> ignore

            sb.AppendLine($"        [<CustomOperation(\"{opName}\")>]") |> ignore
            if required then
                sb.AppendLine($"        member _.{fsharpName}(state: {typeName}, value: {fsharpType}) =") |> ignore
                sb.AppendLine($"            {{ state with {typeName}.{fsharpName} = value }} : {typeName}") |> ignore
            else
                sb.AppendLine($"        member _.{fsharpName}(state: {typeName}, value: {fsharpType}) =") |> ignore
                sb.AppendLine($"            {{ state with {typeName}.{fsharpName} = Option.Some value }} : {typeName}") |> ignore
            sb.AppendLine() |> ignore

        let instanceName = Char.ToLower(typeName[0]).ToString() + typeName.Substring(1)
        sb.AppendLine($"    let {instanceName} = {builderName}()") |> ignore

    sb.ToString()

/// Generate helper module for an operation (delegates to static member)
let generateToRequestMethod (op: OperationDefinition) : string =
    let typeName = operationToTypeName op.OperationId
    let sb = StringBuilder()

    // Skip if no fields at all
    let allFields = op.PathParameters @ op.QueryParameters @ (op.RequestBodyInline |> Option.defaultValue [] |> List.map (fun p -> { Name = p.Name; In = "body"; Required = p.Required; Type = p.Type; Description = p.Description }))
    if allFields.IsEmpty then
        "" // No helpers for unit types
    else
        sb.AppendLine($"    module {typeName}Helpers =") |> ignore
        sb.AppendLine($"        /// Convert request to HTTP request message") |> ignore
        sb.AppendLine($"        let toRequest (request: {typeName}) : Result<Fes.Http.RequestMsg, exn> =") |> ignore
        sb.AppendLine($"            {typeName}.ToRequest request") |> ignore
        sb.AppendLine() |> ignore

        sb.ToString()

/// Generate response type name from operationId
/// "indices-create" -> "IndicesCreateResponse"
let operationToResponseTypeName (opId: string) =
    opId.Split([|'-'; '_'; '.'|], StringSplitOptions.RemoveEmptyEntries)
    |> Array.map toPascalCase
    |> String.concat ""
    |> fun s -> s + "Response"

/// Generate an operation response type
let generateOperationResponseType (op: OperationDefinition) : string =
    let typeName = operationToResponseTypeName op.OperationId
    let sb = StringBuilder()

    // Check for response ref first
    match op.ResponseRef with
    | Some refName ->
        // Generate type alias to the referenced type
        let targetType = typeRefToFSharp (Reference refName)
        sb.AppendLine($"    type {typeName} = {targetType}") |> ignore
        sb.AppendLine() |> ignore
        sb.ToString()
    | None ->
        // Check for inline response
        match op.ResponseInline with
        | Some props when props.Length > 0 ->
            sb.AppendLine($"    type {typeName} = {{") |> ignore
            let usedNames = HashSet<string>()
            for field in props do
                let baseName = toPascalCase field.Name
                let mutable fsharpName = baseName
                let mutable suffix = 2
                while usedNames.Contains(fsharpName) do
                    fsharpName <- $"{baseName}{suffix}"
                    suffix <- suffix + 1
                usedNames.Add(fsharpName) |> ignore
                let fsharpType = typeRefToFSharp field.Type
                let finalType = if field.Required then fsharpType else $"{fsharpType} option"
                sb.AppendLine($"        [<JsonPropertyName(\"{field.Name}\")>]") |> ignore
                sb.AppendLine($"        {fsharpName}: {finalType}") |> ignore
            sb.AppendLine($"    }}") |> ignore
            sb.AppendLine() |> ignore
            sb.ToString()
        | _ ->
            // No response schema - skip
            ""

/// Generate a complete operations module file
let generateOperationsModuleFile (moduleName: string) (operations: OperationDefinition list) : string =
    // All types are in consolidated Types module which is AutoOpen
    // So map all full names to just the type names (no module prefix needed)
    schemaTypeNames <- allSchemas |> List.map (fun s -> s.FullName, s.TypeName) |> Map.ofList
    availableModules <- Set.empty
    currentModuleName <- ""

    let sb = StringBuilder()
    sb.AppendLine("// Auto-generated from Elasticsearch OpenAPI spec") |> ignore
    sb.AppendLine("// Do not edit manually - regenerate using generate-dsl.fsx") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine($"namespace Fes.DSL.Operations") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine("open System") |> ignore
    sb.AppendLine("open System.Text.Json") |> ignore
    sb.AppendLine("open System.Text.Json.Serialization") |> ignore
    sb.AppendLine("open Fes") |> ignore
    sb.AppendLine("open Fes.DSL.Models.Types") |> ignore
    sb.AppendLine() |> ignore
    sb.AppendLine($"[<AutoOpen>]") |> ignore
    sb.AppendLine($"module {moduleName}Operations =") |> ignore
    sb.AppendLine() |> ignore

    for op in operations do
        sb.Append(generateOperationRequestType op) |> ignore
        sb.AppendLine() |> ignore
        sb.Append(generateToRequestMethod op) |> ignore
        sb.Append(generateOperationBuilder op) |> ignore
        sb.AppendLine() |> ignore
        // Generate response type for this operation
        let responseTypeCode = generateOperationResponseType op
        if not (String.IsNullOrWhiteSpace(responseTypeCode)) then
            sb.Append(responseTypeCode) |> ignore

    sb.ToString()

// ============================================================================
// Generate Operations
// ============================================================================

printfn ""
printfn "=== Generating Operations ==="

let operations = extractAllOperations root
printfn "Found %d operations" (List.length operations)

// Group operations by their first tag
let operationsByModule =
    operations
    |> List.groupBy operationToModuleName
    |> Map.ofList

printfn "Found %d operation modules:" (Map.count operationsByModule)
for kvp in operationsByModule do
    printfn "  - %s: %d operations" kvp.Key (List.length kvp.Value)

// Generate operation module files
let operationsOutputDir = Path.Combine(__SOURCE_DIRECTORY__, "..", "src", "Fes", "DSL", "Operations")
if not (Directory.Exists(operationsOutputDir)) then
    Directory.CreateDirectory(operationsOutputDir) |> ignore

// Delete old generated files
for file in Directory.GetFiles(operationsOutputDir, "*.g.fs") do
    File.Delete(file)

let mutable generatedOpModules = 0
let generatedOpFiles = ResizeArray<string>()

for (moduleName, ops) in operationsByModule |> Map.toList do
    let content = generateOperationsModuleFile moduleName ops
    let fileName = $"{moduleName}.Operations.g.fs"
    let filePath = Path.Combine(operationsOutputDir, fileName)
    File.WriteAllText(filePath, content)
    generatedOpFiles.Add(fileName)
    generatedOpModules <- generatedOpModules + 1
    printfn "Generated %s with %d operations" fileName (List.length ops)

printfn "Generated %d operation module files" generatedOpModules

// Update fsproj with ordered model files
printfn ""
printfn "Updating fsproj with ordered model files..."

let fsprojContent = File.ReadAllText(fsprojPath)

// Model files section (goes before builders)
let modelFilesXml = StringBuilder()
modelFilesXml.AppendLine("        <!-- Auto-generated model files (ordered by dependencies) -->") |> ignore
for fileName in generatedModelFiles do
    modelFilesXml.AppendLine($"        <Compile Include=\"DSL\\Models\\{fileName}\"/>") |> ignore

// Operation files section (goes after Http.fs)
let operationFilesXml = StringBuilder()
operationFilesXml.AppendLine("        <!-- Auto-generated operation files (must be after Http.fs) -->") |> ignore
for fileName in generatedOpFiles do
    operationFilesXml.AppendLine($"        <Compile Include=\"DSL\\Operations\\{fileName}\"/>") |> ignore

// Build pattern to match either glob or explicit includes
let lines = fsprojContent.Split('\n') |> Array.toList
let updatedLines = ResizeArray<string>()
let mutable inModelSection = false
let mutable modelSectionDone = false
let mutable inOperationSection = false
let mutable operationSectionInserted = false

for line in lines do
    // Handle model files section
    if line.Contains("<!-- Auto-generated model files") then
        inModelSection <- true
        modelSectionDone <- false
    elif line.Contains("<Compile Include=\"DSL\\Models\\") && not modelSectionDone then
        if not inModelSection then
            inModelSection <- true
        // Skip this line - we'll add our new content
    elif inModelSection && not (line.Contains("<Compile Include=\"DSL\\Models\\")) then
        // End of model section, add our content
        updatedLines.Add(modelFilesXml.ToString().TrimEnd())
        updatedLines.Add(line)
        inModelSection <- false
        modelSectionDone <- true
    // Skip any existing operation files section (we'll add after Http.fs)
    elif line.Contains("<!-- Auto-generated operation files") then
        inOperationSection <- true
        // Skip this comment line
    elif line.Contains("<Compile Include=\"DSL\\Operations\\") then
        if not inOperationSection then
            inOperationSection <- true
        // Skip this line - we'll add operations after Http.fs
    elif inOperationSection && not (line.Contains("<Compile Include=\"DSL\\Operations\\")) then
        // End of old operation section, don't add anything here, just add the next line
        inOperationSection <- false
        updatedLines.Add(line)
    // Insert operations after Http.fs
    elif line.Contains("<Compile Include=\"Http.fs\"") && not operationSectionInserted then
        updatedLines.Add(line)
        updatedLines.Add(operationFilesXml.ToString().TrimEnd())
        operationSectionInserted <- true
    else
        if not inOperationSection then
            updatedLines.Add(line)

let updatedFsproj = String.concat "\n" updatedLines

File.WriteAllText(fsprojPath, updatedFsproj)
printfn "Updated fsproj with %d module files" generatedModelFiles.Count

printfn ""
printfn "=== Generation Complete ==="
printfn "Generated consolidated types file with %d types" (List.length allSchemas)
printfn "Generated %d operation module files" generatedOpModules
