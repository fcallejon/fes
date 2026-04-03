module Fes.Generator.Emitters.OperationEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

// ============================================================================
// Helpers
// ============================================================================

let private httpMethodString (methods: string list) =
    // Prefer POST if available (for body), otherwise first method
    if methods |> List.contains "POST" then "POST"
    elif methods |> List.contains "PUT" then "PUT"
    elif methods |> List.contains "DELETE" then "DELETE"
    elif methods |> List.contains "GET" then "GET"
    elif methods |> List.contains "HEAD" then "HEAD"
    elif methods |> List.contains "PATCH" then "PATCH"
    else "GET"

/// Pick the best URL template (prefer the one with most path params for the function signature)
let private bestUrl (urls: UrlTemplate list) =
    urls
    |> List.sortByDescending (fun u -> u.Path.Split('{').Length)
    |> List.head

/// Extract path parameter names from a URL template like "/{index}/_search"
let private extractPathParams (path: string) =
    let mutable result = []
    let mutable i = 0
    while i < path.Length do
        if path[i] = '{' then
            let endIdx = path.IndexOf('}', i)
            if endIdx > i then
                result <- path.Substring(i + 1, endIdx - i - 1) :: result
                i <- endIdx + 1
            else
                i <- i + 1
        else
            i <- i + 1
    result |> List.rev

/// Derive the F# request type name from an endpoint name
/// search → SearchRequest
/// indices.create → IndicesCreateRequest
let private requestTypeName (endpointName: string) =
    let parts = endpointName.Split('.')
    let pascal = parts |> Array.map Namespacing.toPascalCase |> String.concat ""
    $"{pascal}Request"

/// Derive the F# response type name
let private responseTypeName (endpointName: string) =
    let parts = endpointName.Split('.')
    let pascal = parts |> Array.map Namespacing.toPascalCase |> String.concat ""
    $"{pascal}Response"

/// Derive the function name from endpoint name
/// search → search
/// indices.create → create
let private functionName (endpointName: string) =
    let parts = endpointName.Split('.')
    let name = parts |> Array.last
    Namespacing.toFunctionName name

/// Derive the module name for grouping
/// search → Global (or Search for the operations file)
/// indices.create → Indices
let private operationGroupName (endpointName: string) =
    let parts = endpointName.Split('.')
    if parts.Length > 1 then Namespacing.toPascalCase parts[0]
    else "Global"

// ============================================================================
// Field Name Deduplication
// ============================================================================

type FieldNameMap = Map<string, string>

let private buildFieldNameMap (pathProps: Property list) (queryProps: Property list) (bodyProps: Property list) : FieldNameMap =
    let mutable seen = Set.empty<string>
    let mutable result = Map.empty
    let addProp (prefix: string) (p: Property) =
        let key = $"{prefix}:{p.Name}"
        let baseName = Namespacing.toFieldName p.Name
        if Set.contains baseName seen then
            let alt = $"{prefix}{baseName}"
            seen <- Set.add alt seen
            result <- Map.add key alt result
        else
            seen <- Set.add baseName seen
            result <- Map.add key baseName result
    for p in pathProps do addProp "path" p
    for p in queryProps do addProp "query" p
    for p in bodyProps do addProp "body" p
    result

let private getFieldName (fnm: FieldNameMap) (prefix: string) (p: Property) =
    Map.tryFind $"{prefix}:{p.Name}" fnm |> Option.defaultValue (Namespacing.toFieldName p.Name)

// ============================================================================
// Emit Request Type
// ============================================================================

let private emitRequestRecord (w: Writer) (ctx: TypeResolver.ResolveContext) (reqTypeName: string) (fnm: FieldNameMap) (generics: TypeName list) (pathProps: Property list) (queryProps: Property list) (bodyProps: Property list) =
    let allProps = pathProps @ queryProps @ bodyProps
    let genericParams =
        match generics with
        | [] -> ""
        | gs -> "<" + (gs |> List.map (fun g -> $"'{Namespacing.toCamelCase g.Name}") |> String.concat ", ") + ">"
    if allProps.IsEmpty then
        w.Line $"type {reqTypeName} = | {reqTypeName}"
        w.BlankLine()
    else

    w.Line $"type {reqTypeName}{genericParams} = {{"
    w.Indent()

    for p in pathProps do
        let fieldName = getFieldName fnm "path" p
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        w.Line $"{fieldName}: {fieldType}"

    for p in queryProps do
        let fieldName = getFieldName fnm "query" p
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        if p.Required then w.Line $"{fieldName}: {fieldType}"
        else w.Line $"{fieldName}: {fieldType} option"

    for p in bodyProps do
        let fieldName = getFieldName fnm "body" p
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        w.Line $"[<System.Text.Json.Serialization.JsonPropertyName(\"{p.Name}\")>]"
        if p.Required then w.Line $"{fieldName}: {fieldType}"
        else w.Line $"{fieldName}: {fieldType} option"

    w.Dedent()
    w.Line "}"
    w.BlankLine()

// ============================================================================
// Emit ToEndpoint static method
// ============================================================================

let private emitToEndpoint (w: Writer) (reqTypeName: string) (endpoint: Endpoint) (request: RequestDefinition) (fnm: FieldNameMap) =
    let url = bestUrl endpoint.Urls
    let httpMethod = httpMethodString url.Methods

    w.Indent()
    w.Line $"static member ToEndpoint(req: {reqTypeName}) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption ="
    w.Indent()

    // Build path with interpolation
    let pathParams = extractPathParams url.Path
    let pathExpr =
        let mutable p = url.Path
        for param in pathParams do
            let pathProp = request.Path |> List.tryFind (fun pp -> pp.Name = param)
            let fieldName =
                match pathProp with
                | Some pp -> getFieldName fnm "path" pp
                | None -> Namespacing.toFieldName param
            p <- p.Replace($"{{{param}}}", $"{{Fes.Http.toPathSegment req.{fieldName}}}")
        $"$\"{p}\""
    w.Line $"let path = {pathExpr}"

    // Build query string from optional query params
    let queryProps = request.Query |> List.filter (fun p -> not p.Required)
    if not queryProps.IsEmpty then
        w.Line "let queryParams ="
        w.Indent()
        w.Line "["
        w.Indent()
        for p in queryProps do
            let fieldName = getFieldName fnm "query" p
            w.Line $"req.{fieldName} |> Option.map (fun v -> \"{p.Name}\", Fes.Http.toQueryValue v)"
        w.Dedent()
        w.Line "] |> List.choose id"
        w.Dedent()
        w.Line "let queryString ="
        w.Indent()
        w.Line "if List.isEmpty queryParams then \"\""
        w.Line "else \"?\" + (queryParams |> List.map (fun (k, v) -> k + \"=\" + v) |> String.concat \"&\")"
        w.Dedent()
        w.Line "let fullPath = path + queryString"
    else
        w.Line "let fullPath = path"

    // Build endpoint + post data
    w.Line $"let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.{httpMethod}, fullPath)"

    match request.Body with
    | Body.Properties props when not props.IsEmpty ->
        w.Line "let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)"
        w.Line "endpoint, ValueSome postData"
    | Body.Value _ ->
        w.Line "let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req.Document)"
        w.Line "endpoint, ValueSome postData"
    | _ ->
        w.Line "endpoint, ValueNone"

    w.Dedent()
    w.Dedent()
    w.BlankLine()

// ============================================================================
// Emit CE Builder
// ============================================================================

let private emitCeBuilder (w: Writer) (ctx: TypeResolver.ResolveContext) (reqTypeName: string) (builderName: string) (fnm: FieldNameMap) (pathProps: Property list) (queryProps: Property list) (bodyProps: Property list) (hasValueBody: bool) =
    w.Line $"type {reqTypeName}Builder() ="

    w.Indent()

    // Yield
    w.Line $"member _.Yield(_: unit) : {reqTypeName} ="
    w.Indent()
    w.Line "{"
    w.Indent()
    for p in pathProps do
        let fieldName = getFieldName fnm "path" p
        w.Line $"{fieldName} = Unchecked.defaultof<_>"
    for p in queryProps do
        let fieldName = getFieldName fnm "query" p
        if p.Required then w.Line $"{fieldName} = Unchecked.defaultof<_>"
        else w.Line $"{fieldName} = None"
    for p in bodyProps do
        let fieldName = getFieldName fnm "body" p
        if p.Required then w.Line $"{fieldName} = Unchecked.defaultof<_>"
        else w.Line $"{fieldName} = None"
    if hasValueBody then
        w.Line "Document = Unchecked.defaultof<_>"
    w.Dedent()
    w.Line "}"
    w.Dedent()
    w.BlankLine()

    // Custom operations for path params
    for p in pathProps do
        let fieldName = getFieldName fnm "path" p
        let opName = Namespacing.toFunctionName fieldName
        let memberName = Namespacing.toPascalCase fieldName
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        w.Line $"[<CustomOperation(\"{opName}\")>]"
        w.Line $"member _.{memberName}(state: {reqTypeName}, value: {fieldType}) ="
        w.Line $"    {{ state with {fieldName} = value }}"
        w.BlankLine()

    // Custom operations for query params
    for p in queryProps do
        let fieldName = getFieldName fnm "query" p
        let opName = Namespacing.toFunctionName fieldName
        let memberName = Namespacing.toPascalCase fieldName
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        w.Line $"[<CustomOperation(\"{opName}\")>]"
        if p.Required then
            w.Line $"member _.{memberName}(state: {reqTypeName}, value: {fieldType}) ="
            w.Line $"    {{ state with {fieldName} = value }}"
        else
            w.Line $"member _.{memberName}(state: {reqTypeName}, value: {fieldType}) ="
            w.Line $"    {{ state with {fieldName} = Some value }}"
        w.BlankLine()

    // Custom operations for body props — use deduped names when they collide with query ops
    let queryOpNames = queryProps |> List.map (fun p -> Namespacing.toFunctionName p.Name) |> Set.ofList
    for p in bodyProps do
        let fieldName = getFieldName fnm "body" p
        let baseOpName = Namespacing.toFunctionName p.Name
        let opName = if Set.contains baseOpName queryOpNames then Namespacing.toFunctionName fieldName else baseOpName
        let memberName = Namespacing.toPascalCase fieldName
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        w.Line $"[<CustomOperation(\"{opName}\")>]"
        if p.Required then
            w.Line $"member _.{memberName}(state: {reqTypeName}, value: {fieldType}) ="
            w.Line $"    {{ state with {fieldName} = value }}"
        else
            w.Line $"member _.{memberName}(state: {reqTypeName}, value: {fieldType}) ="
            w.Line $"    {{ state with {fieldName} = Some value }}"
        w.BlankLine()

    // Document custom operation for ValueBody
    if hasValueBody then
        w.Line "[<CustomOperation(\"document\")>]"
        w.Line $"member _.Document(state: {reqTypeName}, value) ="
        w.Line $"    {{ state with Document = value }}"
        w.BlankLine()

    w.Dedent()

    // Builder instance
    w.Line $"let {builderName} = {reqTypeName}Builder()"
    w.BlankLine()

// ============================================================================
// Emit pipe-friendly module functions
// ============================================================================

let private emitPipeFunctions (w: Writer) (ctx: TypeResolver.ResolveContext) (reqTypeName: string) (moduleName: string) (fnm: FieldNameMap) (queryProps: Property list) (bodyProps: Property list) =
    w.Line $"module {moduleName} ="
    w.Indent()

    for p in queryProps do
        let funcName = $"with{Namespacing.toPascalCase p.Name}"
        let fieldName = getFieldName fnm "query" p
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        if p.Required then
            w.Line $"let {funcName} (value: {fieldType}) (req: {reqTypeName}) ="
            w.Line $"    {{ req with {fieldName} = value }}"
        else
            w.Line $"let {funcName} (value: {fieldType}) (req: {reqTypeName}) ="
            w.Line $"    {{ req with {fieldName} = Some value }}"

    for p in bodyProps do
        let fieldName = getFieldName fnm "body" p
        let funcName = $"with{Namespacing.toPascalCase fieldName}"
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        if p.Required then
            w.Line $"let {funcName} (value: {fieldType}) (req: {reqTypeName}) ="
            w.Line $"    {{ req with {fieldName} = value }}"
        else
            w.Line $"let {funcName} (value: {fieldType}) (req: {reqTypeName}) ="
            w.Line $"    {{ req with {fieldName} = Some value }}"

    w.Dedent()
    w.BlankLine()

// ============================================================================
// Emit a single endpoint
// ============================================================================

let emitEndpoint (w: Writer) (index: TypeIndex.TypeIndex) (endpoint: Endpoint) =
    let reqTd = TypeIndex.resolve index endpoint.Request
    match reqTd with
    | TypeDefinition.Request request ->
        let reqTN = requestTypeName endpoint.Name
        let respTN = responseTypeName endpoint.Name
        let builderName = Namespacing.toCamelCase reqTN |> Namespacing.escapeKeyword
        let ctx = TypeResolver.makeContext index request.Generics

        let pathProps = request.Path
        let queryProps = request.Query
        let bodyProps, hasValueBody =
            match request.Body with
            | Body.Properties props -> props, false
            | Body.Value _ -> [], true
            | Body.NoBody -> [], false

        let fnm = buildFieldNameMap pathProps queryProps bodyProps

        // Request record
        if hasValueBody then
            // For ValueBody, add a Document field to the request
            let genericParams =
                match request.Generics with
                | [] -> ""
                | gs -> "<" + (gs |> List.map (fun g -> $"'{Namespacing.toCamelCase g.Name}") |> String.concat ", ") + ">"
            w.Line $"type {reqTN}{genericParams} = {{"
            w.Indent()
            for p in pathProps do
                let fieldName = getFieldName fnm "path" p
                let fieldType = TypeResolver.resolveValueOf ctx p.Type
                w.Line $"{fieldName}: {fieldType}"
            for p in queryProps do
                let fieldName = getFieldName fnm "query" p
                let fieldType = TypeResolver.resolveValueOf ctx p.Type
                if p.Required then w.Line $"{fieldName}: {fieldType}"
                else w.Line $"{fieldName}: {fieldType} option"
            w.Line "Document: obj"
            w.Dedent()
            w.Line "}"
            w.BlankLine()
        else
            emitRequestRecord w ctx reqTN fnm request.Generics pathProps queryProps bodyProps

        // ToEndpoint method — skip for generic requests (needs generic threading)
        if request.Generics.IsEmpty then
            w.Line $"    with"
            emitToEndpoint w reqTN endpoint request fnm

        // Response type alias
        let respTd = TypeIndex.resolve index endpoint.Response
        match respTd with
        | TypeDefinition.Response resp ->
            let respCtx = TypeResolver.makeContext index resp.Generics
            let genericParams =
                match resp.Generics with
                | [] -> ""
                | gs -> "<" + (gs |> List.map (fun g -> $"'{Namespacing.toCamelCase g.Name}") |> String.concat ", ") + ">"
            match resp.Body with
            | Body.Value (v, _) ->
                let respType = TypeResolver.resolveValueOf respCtx v
                w.Line $"type {respTN}{genericParams} = {respType}"
            | Body.Properties _ ->
                w.Line $"type {respTN} = System.Text.Json.JsonElement"
            | Body.NoBody ->
                w.Line $"type {respTN} = unit"
            w.BlankLine()
        | _ -> ()

        // CE builder — skip for empty request types (marker DUs) and generic requests
        let hasAnyProps = not pathProps.IsEmpty || not queryProps.IsEmpty || not bodyProps.IsEmpty || hasValueBody
        if hasAnyProps && request.Generics.IsEmpty then
            emitCeBuilder w ctx reqTN builderName fnm pathProps queryProps bodyProps hasValueBody

        // Pipe-friendly module — also skip for generic requests
        if request.Generics.IsEmpty then
            let pipeModuleName = Namespacing.toPascalCase (endpoint.Name.Split('.') |> Array.last)
            if not queryProps.IsEmpty || not bodyProps.IsEmpty then
                emitPipeFunctions w ctx reqTN pipeModuleName fnm queryProps bodyProps

    | _ ->
        w.Line $"// Skipping endpoint {endpoint.Name}: request type is not a Request definition"
        w.BlankLine()

// ============================================================================
// Group endpoints by operation file
// ============================================================================

let groupEndpoints (endpoints: Endpoint list) : Map<string, Endpoint list> =
    endpoints
    |> List.groupBy (fun e -> operationGroupName e.Name)
    |> Map.ofList

/// Emit a single operations file for a group of endpoints
let emitOperationsFile (index: TypeIndex.TypeIndex) (groupName: string) (endpoints: Endpoint list) : string * string =
    let filePath = $"Operations/{groupName}.g.fs"
    let w = Writer()
    w.Header()
    w.Namespace "Fes.Generated.Operations"
    w.BlankLine()
    w.Open "System"
    w.Open "System.Text.Json"
    w.Open "System.Text.Json.Serialization"
    w.Open "Fes"
    w.Open "Fes.Generated"
    w.BlankLine()

    w.AutoOpenModule $"{groupName}Operations"

    for endpoint in endpoints do
        emitEndpoint w index endpoint

    filePath, w.ToString()

/// Emit all operation files
let emitAllOperationFiles (index: TypeIndex.TypeIndex) : (string * string) list =
    let grouped = groupEndpoints index.EndpointsToGenerate
    grouped
    |> Map.toList
    |> List.map (fun (groupName, endpoints) -> emitOperationsFile index groupName endpoints)
