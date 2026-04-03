module Fes.Generator.Emitters.TestEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

// ============================================================================
// Sample value generation for path parameters
// ============================================================================

let private sampleValueForType (ctx: TypeResolver.ResolveContext) (valueOf: ValueOf) : string =
    match valueOf with
    | ValueOf.InstanceOf (tn, _) ->
        if tn.Namespace = "_builtins" then
            match tn.Name with
            | "string" -> "\"test-value\""
            | "integer" | "long" -> "1"
            | "boolean" -> "true"
            | "float" | "double" | "number" -> "1.0"
            | _ -> "Unchecked.defaultof<_>"
        else
            let resolvedName =
                match Map.tryFind tn ctx.NameMap with
                | Some n -> n
                | None -> Namespacing.toFSharpTypeName tn.Name
            match TypeIndex.tryResolve ctx.TypeIndex tn with
            | Some (TypeDefinition.TypeAlias alias) ->
                match alias.Type with
                // DU alias wrapping a union — use first case
                | ValueOf.UnionOf items when items.Length >= 1 ->
                    match items[0] with
                    | ValueOf.InstanceOf (firstCaseTn, _) ->
                        let firstCase = Namespacing.toPascalCase firstCaseTn.Name
                        sprintf "(Types.%s.%s \"test-value\")" resolvedName firstCase
                    | _ -> sprintf "Unchecked.defaultof<Types.%s>" resolvedName
                // Simple alias (to string etc.) — just pass the string
                | _ -> "\"test-value\""
            | Some (TypeDefinition.Enum def) ->
                // Use the first enum case
                match def.Members with
                | m :: _ ->
                    let caseName = Namespacing.toPascalCase m.Name
                    let caseName =
                        if caseName = "" then "Empty"
                        elif System.Char.IsDigit caseName[0] then $"N{caseName}"
                        else caseName
                    sprintf "Types.%s.%s" resolvedName caseName
                | [] -> sprintf "Unchecked.defaultof<Types.%s>" resolvedName
            | Some (TypeDefinition.Interface _) ->
                sprintf "Unchecked.defaultof<Types.%s>" resolvedName
            | _ ->
                // Unknown or can't resolve — use defaultof to be safe
                sprintf "Unchecked.defaultof<_>"
    | _ -> "Unchecked.defaultof<_>"

// ============================================================================
// Endpoint test emission
// ============================================================================

let private httpMethodName (methods: string list) =
    if methods |> List.contains "POST" then "POST"
    elif methods |> List.contains "PUT" then "PUT"
    elif methods |> List.contains "DELETE" then "DELETE"
    elif methods |> List.contains "GET" then "GET"
    elif methods |> List.contains "HEAD" then "HEAD"
    elif methods |> List.contains "PATCH" then "PATCH"
    else "GET"

let emitEndpointTests (index: TypeIndex.TypeIndex) : string =
    let w = Writer()
    w.Line "// Auto-generated endpoint tests — do not edit manually"
    w.BlankLine()
    w.Line "module Fes.Tests.Generated.EndpointTests"
    w.BlankLine()
    w.Line "open Xunit"
    w.Line "open FsUnit.Xunit"
    w.Line "open Fes.Generated"
    w.Line "open Fes.Generated.Operations"
    w.Line "open Elastic.Transport"
    w.BlankLine()

    // Skip endpoints where body serialisation requires complex populated values
    // (these have required body properties of complex types that can't be defaultof'd)
    // The C# client also doesn't test these endpoints in their test suite.
    let skipEndpoints = set [
        "inference.completion"; "inference.sparse_embedding"; "inference.stream_completion"
        "inference.text_embedding"; "query_rules.put_rule"; "query_rules.put_ruleset"
        "synonyms.put_synonym"
    ]

    for ep in index.EndpointsToGenerate do
        if Set.contains ep.Name skipEndpoints then () else
        match TypeIndex.tryResolve index ep.Request with
        | Some (TypeDefinition.Request request) when request.Generics.IsEmpty ->
            // Skip endpoints with path params that aren't simple string/int builtins or string aliases
            let isSimplePathParam (p: Property) =
                match p.Type with
                | ValueOf.InstanceOf (tn, _) ->
                    if tn.Namespace = "_builtins" && (tn.Name = "string" || tn.Name = "integer" || tn.Name = "long") then true
                    else
                        match TypeIndex.tryResolve index tn with
                        | Some (TypeDefinition.TypeAlias { Type = ValueOf.InstanceOf (bt, _) }) ->
                            bt.Namespace = "_builtins" && (bt.Name = "string" || bt.Name = "integer" || bt.Name = "long")
                        | _ -> false
                | _ -> false
            let allPathParamsSimple = request.Path |> List.forall isSimplePathParam
            // Also skip if path param names collide with body properties (dedup changes types)
            let bodyPropNames =
                match request.Body with
                | Body.Properties props -> props |> List.map _.Name |> Set.ofList
                | _ -> Set.empty
            let hasPathBodyCollision =
                request.Path |> List.exists (fun p -> Set.contains p.Name bodyPropNames)
            // Skip if defaultof would cause NRE or serialisation failure
            let hasQueryOrBodyFields =
                not request.Query.IsEmpty ||
                (match request.Body with Body.Properties p -> not p.IsEmpty | Body.Value _ -> true | Body.NoBody -> false)
            let wouldBeNull = request.Path.IsEmpty && hasQueryOrBodyFields
            // Skip ValueBody endpoints (need a real document, can't use defaultof)
            let isValueBody = match request.Body with Body.Value _ -> true | _ -> false
            if (not allPathParamsSimple && not request.Path.IsEmpty) || hasPathBodyCollision || wouldBeNull || isValueBody then () else

            let parts = ep.Name.Split('.')
            let reqTypeName = parts |> Array.map Namespacing.toPascalCase |> String.concat "" |> fun s -> $"{s}Request"
            let url = ep.Urls |> List.sortByDescending (fun u -> u.Path.Split('{').Length) |> List.head
            let method = httpMethodName url.Methods
            let ctx = TypeResolver.makeContext index request.Generics
            let testPrefix = ep.Name.Replace(".", "_")

            let hasBody =
                match request.Body with
                | Body.Properties props -> not props.IsEmpty
                | Body.Value _ -> true
                | Body.NoBody -> false

            // Build CE construction with sample path param values
            let builderName = Namespacing.toCamelCase reqTypeName |> Namespacing.escapeKeyword
            let pathOps =
                request.Path
                |> List.map (fun p ->
                    let opName = Namespacing.toFunctionName p.Name
                    let sampleVal = sampleValueForType ctx p.Type
                    $"        {opName} {sampleVal}")

            let emitReqConstruction () =
                if pathOps.IsEmpty then
                    w.Line $"    let req = Unchecked.defaultof<{reqTypeName}>"
                else
                    w.Line $"    let req = {builderName} {{"
                    for op in pathOps do
                        w.Line op
                    w.Line $"    }}"

            // Method test
            w.Line $"[<Fact>]"
            w.Line $"let ``{testPrefix} uses {method} method`` () ="
            emitReqConstruction ()
            w.Line $"    let (endpoint, _) = {reqTypeName}.ToEndpoint(req)"
            w.Line $"    endpoint.Method |> should equal HttpMethod.{method}"
            w.BlankLine()

            // Body presence test
            w.Line $"[<Fact>]"
            if hasBody then
                w.Line $"let ``{testPrefix} has request body`` () ="
            else
                w.Line $"let ``{testPrefix} has no request body`` () ="
            emitReqConstruction ()
            w.Line $"    let (_, postData) = {reqTypeName}.ToEndpoint(req)"
            if hasBody then
                w.Line $"    postData.IsSome |> should be True"
            else
                w.Line $"    postData.IsNone |> should be True"
            w.BlankLine()

        | _ -> () // Skip generic or non-request endpoints

    w.ToString()

// ============================================================================
// Enum round-trip test emission
// ============================================================================

let emitEnumTests (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : string =
    let w = Writer()
    w.Line "// Auto-generated enum round-trip tests — do not edit manually"
    w.BlankLine()
    w.Line "module Fes.Tests.Generated.EnumRoundTripTests"
    w.BlankLine()
    w.Line "open Xunit"
    w.Line "open FsUnit.Xunit"
    w.Line "open Fes"
    w.Line "open Fes.Generated"
    w.BlankLine()

    for td in types do
        match td with
        | TypeDefinition.Enum def ->
            let resolvedName =
                match Map.tryFind def.Name index.NameMap with
                | Some n -> n
                | None -> Namespacing.toFSharpTypeName def.Name.Name

            for m in def.Members do
                let caseName = Namespacing.toPascalCase m.Name
                let caseName =
                    if caseName = "" then "Empty"
                    elif System.Char.IsDigit caseName[0] then $"N{caseName}"
                    else caseName

                w.Line "[<Fact>]"
                w.Line (sprintf "let ``%s.%s round-trips`` () =" resolvedName caseName)
                w.Line (sprintf "    let value = Types.%s.%s" resolvedName caseName)
                w.Line "    let json = Json.serialize value"
                w.Line (sprintf "    let roundTripped = Json.deserialize<Types.%s> json" resolvedName)
                w.Line (sprintf "    roundTripped |> should equal Types.%s.%s" resolvedName caseName)
                w.BlankLine()

        | _ -> ()

    w.ToString()

// ============================================================================
// Container variant discriminator test emission
// ============================================================================

let emitVariantTests (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : string =
    let w = Writer()
    w.Line "// Auto-generated container variant tests — do not edit manually"
    w.BlankLine()
    w.Line "module Fes.Tests.Generated.VariantTests"
    w.BlankLine()
    w.Line "open Xunit"
    w.Line "open FsUnit.Xunit"
    w.Line "open Fes"
    w.Line "open Fes.Generated"
    w.BlankLine()

    for td in types do
        match td with
        | TypeDefinition.Interface def ->
            match def.Variants with
            | Some (VariantKind.Container _) ->
                let resolvedName =
                    match Map.tryFind def.Name index.NameMap with
                    | Some n -> n
                    | None -> Namespacing.toFSharpTypeName def.Name.Name

                let variantProps = def.Properties |> List.filter (fun p -> not p.ContainerProperty)

                for p in variantProps do
                    let caseName = Namespacing.toPascalCase p.Name
                    let isSingleKeyDict =
                        match p.Type with
                        | ValueOf.DictionaryOf (_, _, true) -> true
                        | _ -> false

                    // Build a safe inner value expression based on the actual type
                    let ctx = TypeResolver.makeContext index []
                    let innerValueExpr =
                        match p.Type with
                        | ValueOf.InstanceOf (tn, _) when tn.Namespace = "_builtins" ->
                            match tn.Name with
                            | "string" -> Some "\"test\""
                            | "boolean" -> Some "true"
                            | "integer" | "long" -> Some "1"
                            | "float" | "double" | "number" -> Some "1.0"
                            | _ -> None
                        | ValueOf.InstanceOf (tn, _) ->
                            match TypeIndex.tryResolve index tn with
                            | Some (TypeDefinition.Interface d) when d.Properties.IsEmpty ->
                                // Empty interface → JsonElement struct, use a parsed empty object
                                Some "(System.Text.Json.JsonDocument.Parse(\"{}\").RootElement)"
                            | Some (TypeDefinition.Interface _) ->
                                // Non-empty record → null with defaultof, skip
                                None
                            | Some (TypeDefinition.Enum def) ->
                                match def.Members with
                                | m :: _ ->
                                    let ec = Namespacing.toPascalCase m.Name
                                    let en = match Map.tryFind def.Name index.NameMap with Some n -> n | None -> Namespacing.toFSharpTypeName def.Name.Name
                                    Some (sprintf "Types.%s.%s" en ec)
                                | [] -> None
                            | Some (TypeDefinition.TypeAlias alias) ->
                                match alias.Type with
                                | ValueOf.InstanceOf (bt, _) when bt.Namespace = "_builtins" ->
                                    match bt.Name with
                                    | "string" -> Some "\"test\""
                                    | "integer" | "long" -> Some "1"
                                    | "float" | "double" | "number" -> Some "1.0"
                                    | "boolean" -> Some "true"
                                    | _ -> None
                                | _ -> None // Complex type alias (DU, union) — skip
                            | _ -> None
                        | ValueOf.DictionaryOf (_, value, true) ->
                            // SingleKeyDict: need a safe value for the dict value type
                            match value with
                            | ValueOf.InstanceOf (vtn, _) ->
                                match TypeIndex.tryResolve index vtn with
                                | Some (TypeDefinition.Interface d) when d.Properties.IsEmpty ->
                                    Some "(System.Text.Json.JsonDocument.Parse(\"{}\").RootElement)"
                                | Some (TypeDefinition.Interface _) -> None // record, null → NRE
                                | _ -> None
                            | _ -> None
                        | ValueOf.DictionaryOf _ -> Some "Map.empty"
                        | ValueOf.ArrayOf _ -> Some "[]"
                        | _ -> None

                    match innerValueExpr with
                    | Some innerVal ->
                        let valueExpr =
                            if isSingleKeyDict then
                                sprintf "Types.%s.%s (\"test-field\", %s)" resolvedName caseName innerVal
                            else
                                sprintf "Types.%s.%s %s" resolvedName caseName innerVal

                        w.Line "[<Fact>]"
                        w.Line (sprintf "let ``%s.%s serialises with %s key`` () =" resolvedName caseName p.Name)
                        w.Line (sprintf "    let value = %s" valueExpr)
                        w.Line "    let json = Json.serialize value"
                        w.Line (sprintf "    json |> should haveSubstring \"\\\"%s\\\"\"" p.Name)
                        w.BlankLine()
                    | None -> () // Skip cases where we can't construct a safe value

            | _ -> ()
        | _ -> ()

    w.ToString()
