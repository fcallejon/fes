module Fes.Generator.Emitters.BuilderEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

// ============================================================================
// Emit smart constructors for container variant types
// ============================================================================

/// Emit a module with convenience functions for each DU case
let emitContainerBuilders (w: Writer) (ctx: TypeResolver.ResolveContext) (def: InterfaceDefinition) =
    let variantProps = def.Properties |> List.filter (fun p -> not p.ContainerProperty)
    let resolvedName =
        match Map.tryFind def.Name ctx.TypeIndex.NameMap with
        | Some n -> n
        | None -> Namespacing.toFSharpTypeName def.Name.Name
    let duName = $"Types.{resolvedName}"
    let moduleName = Namespacing.toPascalCase def.Name.Name |> Namespacing.escapeKeyword

    // Remove "Container" suffix for the module name if present
    let shortModuleName =
        if moduleName.EndsWith("Container") then
            moduleName.Substring(0, moduleName.Length - "Container".Length)
        else moduleName

    w.Line $"module {shortModuleName} ="
    w.BlankLine()
    w.Indent()

    for p in variantProps do
        let caseName = Namespacing.toPascalCase p.Name
        let funcName = Namespacing.toFunctionName p.Name |> Namespacing.escapeKeyword

        match p.Type with
        | ValueOf.DictionaryOf (key, value, true) ->
            // SingleKeyDictionary: function takes field (key type) + value
            let keyType = TypeResolver.resolveValueOf ctx key
            let valueType = TypeResolver.resolveValueOf ctx value
            w.Line $"let {funcName} (field: {keyType}) (value: {valueType}) ="
            w.Line $"    {duName}.{caseName} (field, value)"
        | ValueOf.InstanceOf (tn, _) ->
            let caseType = TypeResolver.resolveValueOf ctx p.Type
            w.Line $"let {funcName} (value: {caseType}) ="
            w.Line $"    {duName}.{caseName} value"
        | _ ->
            let caseType = TypeResolver.resolveValueOf ctx p.Type
            w.Line $"let {funcName} (value: {caseType}) ="
            w.Line $"    {duName}.{caseName} value"
        w.BlankLine()

    w.Dedent()

// ============================================================================
// Emit CE builders for record types (used for query types, agg types, etc.)
// ============================================================================

let emitRecordCeBuilder (w: Writer) (ctx: TypeResolver.ResolveContext) (typeName: string) (properties: Property list) =
    let shortName = typeName.Split('.') |> Array.last
    let builderTypeName = $"{shortName}Builder"
    let builderInstanceName = Namespacing.toCamelCase shortName |> Namespacing.escapeKeyword

    // Use same field dedup as the type emitter
    let dedupedProps = TypeEmitter.dedupRecordFields properties

    w.Line $"type {builderTypeName}() ="
    w.Indent()

    // Yield
    w.Line $"member _.Yield(_: unit) : {typeName} ="
    w.Indent()
    w.Line "{"
    w.Indent()
    for p in dedupedProps do
        let fieldName = TypeEmitter.getRecordFieldName p
        if p.Required then
            w.Line $"{fieldName} = Unchecked.defaultof<_>"
        else
            w.Line $"{fieldName} = None"
    w.Dedent()
    w.Line "}"
    w.Dedent()
    w.BlankLine()

    // Custom operations
    for p in dedupedProps do
        let fieldName = TypeEmitter.getRecordFieldName p
        let opName = Namespacing.toFunctionName fieldName
        let fieldType = TypeResolver.resolveValueOf ctx p.Type
        w.Line $"[<CustomOperation(\"{opName}\")>]"
        if p.Required then
            w.Line $"member _.{Namespacing.toPascalCase fieldName}(state: {typeName}, value: {fieldType}) ="
            w.Line $"    {{ state with {fieldName} = value }}"
        else
            w.Line $"member _.{Namespacing.toPascalCase fieldName}(state: {typeName}, value: {fieldType}) ="
            w.Line $"    {{ state with {fieldName} = Some value }}"
        w.BlankLine()

    w.Dedent()

    // Builder instance
    w.Line $"let {builderInstanceName} = {builderTypeName}()"
    w.BlankLine()

// ============================================================================
// Emit shortcut constructors
// ============================================================================

let emitShortcutConstructor (w: Writer) (ctx: TypeResolver.ResolveContext) (def: InterfaceDefinition) =
    match def.ShortcutProperty with
    | Some shortcutPropName ->
        let shortcutProp =
            def.Properties |> List.tryFind (fun p -> p.Name = shortcutPropName)
        match shortcutProp with
        | Some prop ->
            let resolvedName =
                match Map.tryFind def.Name ctx.TypeIndex.NameMap with
                | Some n -> n
                | None -> Namespacing.toFSharpTypeName def.Name.Name
            let typeName = $"Types.{resolvedName}"
            let funcName = $"create{resolvedName}"
            let paramType = TypeResolver.resolveValueOf ctx prop.Type
            w.Line $"let {funcName} (value: {paramType}) : {typeName} ="
            w.Indent()
            w.Line "{"
            w.Indent()
            let dedupedProps = TypeEmitter.dedupRecordFields def.Properties
            for p in dedupedProps do
                let fieldName = TypeEmitter.getRecordFieldName p
                if p.Name = shortcutPropName then
                    if p.Required then w.Line $"{fieldName} = value"
                    else w.Line $"{fieldName} = Some value"
                elif p.Required then
                    w.Line $"{fieldName} = Unchecked.defaultof<_>"
                else
                    w.Line $"{fieldName} = None"
            w.Dedent()
            w.Line "}"
            w.Dedent()
            w.BlankLine()
        | None -> ()
    | None -> ()

// ============================================================================
// Emit all builders for a namespace's types
// ============================================================================

let emitBuildersForNamespace (w: Writer) (index: TypeIndex.TypeIndex) (types: TypeDefinition list) =
    for td in types do
        match td with
        | TypeDefinition.Interface def ->
            match def.Variants with
            | Some (VariantKind.Container _) ->
                // Container variant: emit module with convenience constructors
                let ctx = TypeResolver.makeContext index def.Generics
                emitContainerBuilders w ctx def
            | None ->
                // Regular interface: emit CE builder if it has properties and enough optionals
                let optionalCount = def.Properties |> List.filter (fun p -> not p.Required) |> List.length
                if not def.Properties.IsEmpty && optionalCount >= 2 && def.Generics.IsEmpty then
                    let ctx = TypeResolver.makeContext index def.Generics
                    let resolvedName =
                        match Map.tryFind def.Name index.NameMap with
                        | Some n -> n
                        | None -> Namespacing.toFSharpTypeName def.Name.Name
                    let typeName = $"Types.{resolvedName}"
                    emitRecordCeBuilder w ctx typeName def.Properties
                    emitShortcutConstructor w ctx def
            | _ -> ()
        | _ -> ()

// ============================================================================
// Group and emit builder files
// ============================================================================

let emitBuilderFile (index: TypeIndex.TypeIndex) (ns: string) (types: TypeDefinition list) : string * string =
    let moduleName = Namespacing.toModuleName ns
    let filePath = $"Builders/{moduleName}Builders.g.fs"

    let w = Writer()
    w.Header()
    w.Namespace "Fes.Generated.Builders"
    w.BlankLine()
    w.Open "System.Text.Json.Serialization"
    w.Open "Fes.Generated"
    w.BlankLine()

    w.AutoOpenModule $"{moduleName}Builders"

    emitBuildersForNamespace w index types

    filePath, w.ToString()

let emitAllBuilderFiles (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : (string * string) list =
    // Only emit builders for namespaces that have container variants or complex types
    let grouped =
        types
        |> List.choose (fun td ->
            match td with
            | TypeDefinition.Interface def ->
                match def.Variants with
                | Some (VariantKind.Container _) -> Some (def.Name.Namespace, td)
                | None when not def.Properties.IsEmpty && def.Generics.IsEmpty && (def.Properties |> List.filter (fun p -> not p.Required) |> List.length >= 2) ->
                    Some (def.Name.Namespace, td)
                | _ -> None
            | _ -> None)
        |> List.groupBy fst
        |> List.map (fun (ns, items) -> ns, items |> List.map snd)

    grouped
    |> List.map (fun (ns, nsTypes) -> emitBuilderFile index ns nsTypes)
    |> List.filter (fun (_, content) ->
        // Skip empty builder modules (module declaration + nothing else)
        content.Split('\n').Length > 12)
