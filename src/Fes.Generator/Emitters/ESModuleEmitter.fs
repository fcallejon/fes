module Fes.Generator.Emitters.ESModuleEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

/// Generate the ES module with verb-first functions and sub-modules
let emitESModule (index: TypeIndex.TypeIndex) : string * string =
    let filePath = "Operations/ES.g.fs"
    let w = Writer()
    w.Header()
    w.Namespace "Fes.Generated.Operations"
    w.BlankLine()
    w.Open "Fes"
    w.Open "Fes.Generated"
    w.Open "Fes.Generated.Operations"
    w.BlankLine()

    // Group endpoints by namespace
    let grouped =
        index.EndpointsToGenerate
        |> List.groupBy (fun e ->
            let parts = e.Name.Split('.')
            if parts.Length > 1 then Some (Namespacing.toPascalCase parts[0])
            else None)

    w.Line "module Endpoints ="
    w.BlankLine()
    w.Indent()

    // Note: ES.connect, ES.sendAsync etc. are defined in Transport.fs
    // This generated module only contains verb-first endpoint functions
    w.BlankLine()

    // Global endpoints (no namespace prefix)
    for group in grouped do
        match group with
        | None, endpoints ->
            for ep in endpoints do
                let parts = ep.Name.Split('.')
                let funcName = Namespacing.toFunctionName (parts |> Array.last)
                let reqTypeName =
                    parts |> Array.map Namespacing.toPascalCase |> String.concat ""
                    |> fun s -> $"{s}Request"

                let reqTd = TypeIndex.resolve index ep.Request
                match reqTd with
                | TypeDefinition.Request request when request.Generics.IsEmpty ->
                    let pathParams = request.Path
                    let ctx = TypeResolver.makeContext index request.Generics

                    // Build function signature
                    let paramList =
                        pathParams
                        |> List.map (fun p ->
                            let pName = Namespacing.toFunctionName p.Name
                            let pType = TypeResolver.resolveValueOf ctx p.Type
                            $"({pName}: {pType})")
                        |> String.concat " "

                    let hasBody =
                        match request.Body with
                        | Body.Properties props -> not props.IsEmpty
                        | Body.Value _ -> true
                        | Body.NoBody -> false

                    let hasQueryParams = not request.Query.IsEmpty

                    w.DocComment ep.Description
                    if hasBody || hasQueryParams then
                        // Returns a default request — intended for use with the CE builder
                        // Note: Unchecked.defaultof gives null for records; callers should use
                        // the CE builder (e.g. searchRequest { ... }) rather than this directly
                        if pathParams.IsEmpty then
                            w.Line $"let {funcName} () ="
                        else
                            w.Line $"let {funcName} {paramList} ="
                        w.Indent()
                        if pathParams.IsEmpty then
                            w.Line $"Unchecked.defaultof<{reqTypeName}>"
                        else
                            w.Line $"let mutable req = Unchecked.defaultof<{reqTypeName}>"
                            for p in pathParams do
                                let fieldName = Namespacing.toFieldName p.Name
                                let argName = Namespacing.toFunctionName p.Name
                                w.Line $"req <- {{ req with {fieldName} = {argName} }}"
                            w.Line "req"
                        w.Dedent()
                    else
                        if pathParams.IsEmpty then
                            w.Line $"let {funcName} () : {reqTypeName} ="
                            w.Indent()
                            w.Line $"Unchecked.defaultof<{reqTypeName}>"
                            w.Dedent()
                        else
                            w.Line $"let {funcName} {paramList} : {reqTypeName} ="
                            w.Indent()
                            w.Line "{"
                            w.Indent()
                            for p in pathParams do
                                let fieldName = Namespacing.toFieldName p.Name
                                let argName = Namespacing.toFunctionName p.Name
                                w.Line $"{fieldName} = {argName}"
                            w.Dedent()
                            w.Line "}"
                            w.Dedent()
                    w.BlankLine()
                | _ -> ()

        | Some nsName, endpoints ->
            // Filter to non-generic endpoints only
            let nonGenericEndpoints =
                endpoints |> List.filter (fun ep ->
                    match TypeIndex.tryResolve index ep.Request with
                    | Some (TypeDefinition.Request r) -> r.Generics.IsEmpty
                    | _ -> false)
            if nonGenericEndpoints.IsEmpty then () else

            // Sub-module for namespaced endpoints
            w.Line $"module {nsName} ="
            w.BlankLine()
            w.Indent()

            for ep in nonGenericEndpoints do
                let parts = ep.Name.Split('.')
                let funcName = Namespacing.toFunctionName (parts |> Array.last)
                let reqTypeName =
                    parts |> Array.map Namespacing.toPascalCase |> String.concat ""
                    |> fun s -> $"{s}Request"

                let reqTd = TypeIndex.resolve index ep.Request
                match reqTd with
                | TypeDefinition.Request request when request.Generics.IsEmpty ->
                    let pathParams = request.Path
                    let ctx = TypeResolver.makeContext index request.Generics

                    let paramList =
                        pathParams
                        |> List.map (fun p ->
                            let pName = Namespacing.toFunctionName p.Name
                            let pType = TypeResolver.resolveValueOf ctx p.Type
                            $"({pName}: {pType})")
                        |> String.concat " "

                    let hasBody =
                        match request.Body with
                        | Body.Properties props -> not props.IsEmpty
                        | Body.Value _ -> true
                        | Body.NoBody -> false

                    let hasQueryParams = not request.Query.IsEmpty

                    w.DocComment ep.Description
                    if paramList = "" then
                        if hasBody || hasQueryParams then
                            w.Line $"let {funcName} () ="
                            w.Indent()
                            w.Line $"Unchecked.defaultof<{reqTypeName}>"
                            w.Dedent()
                        else
                            w.Line $"let {funcName} () : {reqTypeName} ="
                            w.Indent()
                            w.Line $"Unchecked.defaultof<{reqTypeName}>"
                            w.Dedent()
                    else
                        w.Line $"let {funcName} {paramList} ="
                        w.Indent()
                        if List.isEmpty pathParams then
                            w.Line $"Unchecked.defaultof<{reqTypeName}>"
                        else
                            w.Line $"let mutable req = Unchecked.defaultof<{reqTypeName}>"
                            for p in pathParams do
                                let fieldName = Namespacing.toFieldName p.Name
                                let argName = Namespacing.toFunctionName p.Name
                                w.Line $"req <- {{ req with {fieldName} = {argName} }}"
                            w.Line "req"
                        w.Dedent()
                    w.BlankLine()
                | _ -> ()

            w.Dedent()

    w.Dedent()

    filePath, w.ToString()
