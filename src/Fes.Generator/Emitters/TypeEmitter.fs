module Fes.Generator.Emitters.TypeEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

// ============================================================================
// Emit Enums
// ============================================================================

let emitEnum (w: Writer) (isFirst: bool) (def: EnumDefinition) =
    w.DocComment def.Description
    if isFirst then
        w.Attribute "RequireQualifiedAccess"
        w.Line $"type {Namespacing.toFSharpTypeName def.Name.Name} ="
    else
        w.Line $"and [<RequireQualifiedAccess>] {Namespacing.toFSharpTypeName def.Name.Name} ="

    w.Indent()
    for m in def.Members do
        let caseName = Namespacing.toPascalCase m.Name
        let caseName = if caseName = "" then "Empty" else caseName
        // Ensure case doesn't start with digit
        let caseName =
            if caseName.Length > 0 && System.Char.IsDigit caseName[0] then $"N{caseName}"
            else caseName
        w.Line $"| {caseName}"

    if def.IsOpen then
        w.Line "| Custom of string"

    w.Dedent()
    w.BlankLine()

// ============================================================================
// Emit Records (from Interface definitions)
// ============================================================================

let emitRecordField (w: Writer) (ctx: TypeResolver.ResolveContext) (p: Property) =
    let fieldName = Namespacing.toFieldName p.Name
    let fieldType = TypeResolver.resolveValueOf ctx p.Type

    let finalType =
        if p.Required then fieldType
        else $"{fieldType} option"

    // Add JsonPropertyName if the field name differs from the JSON name
    let pascalName = Namespacing.toPascalCase p.Name
    if pascalName <> p.Name then
        w.Line $"[<System.Text.Json.Serialization.JsonPropertyName(\"{p.Name}\")>]"

    w.Line $"{fieldName}: {finalType}"

let emitRecord (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (name: string) (properties: Property list) (generics: TypeName list) (description: string option) =
    w.DocComment description
    let keyword = w.TypeKeyword isFirst
    let genericParams =
        match generics with
        | [] -> ""
        | gs -> "<" + (gs |> List.map (fun g -> $"'{Namespacing.toCamelCase g.Name}") |> String.concat ", ") + ">"

    if properties.IsEmpty then
        // F# records cannot be empty — use a type alias to JsonElement
        w.Line $"{keyword} {Namespacing.toFSharpTypeName name}{genericParams} = System.Text.Json.JsonElement"
    else
        w.Line $"{keyword} {Namespacing.toFSharpTypeName name}{genericParams} = {{"
        w.Indent()
        for p in properties do
            emitRecordField w ctx p
        w.Dedent()
        w.Line "}"

    w.BlankLine()

// ============================================================================
// Emit Container Variants (DUs)
// ============================================================================

let emitContainerVariant (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (def: InterfaceDefinition) (nonExhaustive: bool) =
    let containerProps = def.Properties |> List.filter _.ContainerProperty
    let variantProps = def.Properties |> List.filter (fun p -> not p.ContainerProperty)

    // Emit the DU
    w.DocComment def.Description
    let duName = Namespacing.toFSharpTypeName def.Name.Name
    if isFirst then
        w.Attribute "RequireQualifiedAccess"
        w.Line $"type {duName} ="
    else
        w.Line $"and [<RequireQualifiedAccess>] {duName} ="

    w.Indent()
    for p in variantProps do
        let caseName = Namespacing.toPascalCase p.Name
        match p.Type with
        | ValueOf.DictionaryOf (_, value, true) ->
            // SingleKeyDictionary → field-keyed case
            let valueType = TypeResolver.resolveValueOf ctx value
            w.Line $"| {caseName} of field: string * {valueType}"
        | _ ->
            let caseType = TypeResolver.resolveValueOf ctx p.Type
            w.Line $"| {caseName} of {caseType}"

    if nonExhaustive then
        w.Line "| Unknown of name: string * System.Text.Json.JsonElement"

    w.Dedent()
    w.BlankLine()

    // Emit container properties as a separate record if any
    if not containerProps.IsEmpty then
        let metaName = $"{duName}Meta"
        w.Line $"and {metaName} = {{"
        w.Indent()
        for p in containerProps do
            emitRecordField w ctx p
        w.Dedent()
        w.Line "}"
        w.BlankLine()

// ============================================================================
// Emit Internal Tag Variants (DUs via type_alias)
// ============================================================================

let emitInternalTagVariant (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (def: TypeAliasDefinition) (_tag: string) (_defaultTag: string option) (nonExhaustive: bool) =
    // The type_alias wraps a union_of where each item is a concrete type
    // whose tag field value determines the case name
    w.DocComment def.Description
    let duName = Namespacing.toFSharpTypeName def.Name.Name
    if isFirst then
        w.Attribute "RequireQualifiedAccess"
        w.Line $"type {duName} ="
    else
        w.Line $"and [<RequireQualifiedAccess>] {duName} ="

    w.Indent()
    match def.Type with
    | ValueOf.UnionOf items ->
        for item in items do
            match item with
            | ValueOf.InstanceOf (tn, _generics) ->
                let caseName = Namespacing.toPascalCase tn.Name
                let caseType = TypeResolver.resolveValueOf ctx item
                w.Line $"| {caseName} of {caseType}"
            | _ ->
                let caseType = TypeResolver.resolveValueOf ctx item
                w.Line $"| UnknownVariant of {caseType}"
    | _ ->
        // Fallback: just alias
        w.Line $"| Value of {TypeResolver.resolveValueOf ctx def.Type}"

    if nonExhaustive then
        w.Line "| Unknown of name: string * System.Text.Json.JsonElement"

    w.Dedent()
    w.BlankLine()

// ============================================================================
// Emit Type Aliases
// ============================================================================

let emitTypeAlias (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (def: TypeAliasDefinition) =
    w.DocComment def.Description
    let keyword = w.TypeKeyword isFirst
    let name = Namespacing.toFSharpTypeName def.Name.Name
    let genericParams =
        match def.Generics with
        | [] -> ""
        | gs -> "<" + (gs |> List.map (fun g -> $"'{Namespacing.toCamelCase g.Name}") |> String.concat ", ") + ">"

    match def.Type with
    | ValueOf.UnionOf items when items.Length >= 2 ->
        // Emit as DU for unions
        if isFirst then
            w.Attribute "RequireQualifiedAccess"
            w.Line $"type {name}{genericParams} ="
        else
            w.Line $"and [<RequireQualifiedAccess>] {name}{genericParams} ="
        w.Indent()
        for i, item in items |> List.indexed do
            let caseType = TypeResolver.resolveValueOf ctx item
            let caseName =
                match item with
                | ValueOf.InstanceOf (tn, _) ->
                    if tn.Namespace = "_builtins" then Namespacing.toPascalCase tn.Name
                    else Namespacing.toPascalCase tn.Name
                | ValueOf.ArrayOf _ -> $"Array"
                | ValueOf.DictionaryOf _ -> $"Dictionary"
                | _ -> $"Case{i}"
            w.Line $"| {caseName} of {caseType}"
        w.Dedent()
    | _ ->
        let keyword = w.TypeKeyword isFirst
        let resolved = TypeResolver.resolveValueOf ctx def.Type
        // Only include generic params that appear in the resolved type
        let usedGenericParams =
            match def.Generics with
            | [] -> ""
            | gs ->
                let used =
                    gs
                    |> List.filter (fun g ->
                        let paramStr = $"'{Namespacing.toCamelCase g.Name}"
                        resolved.Contains(paramStr))
                match used with
                | [] -> ""
                | us -> "<" + (us |> List.map (fun g -> $"'{Namespacing.toCamelCase g.Name}") |> String.concat ", ") + ">"
        w.Line $"{keyword} {name}{usedGenericParams} = {resolved}"

    w.BlankLine()

// ============================================================================
// Emit a single TypeDefinition
// ============================================================================

let emitTypeDefinition (w: Writer) (index: TypeIndex.TypeIndex) (isFirst: bool) (td: TypeDefinition) =
    match td with
    | TypeDefinition.Enum def ->
        emitEnum w isFirst def

    | TypeDefinition.Interface def ->
        match def.Variants with
        | Some (VariantKind.Container nonExhaustive) ->
            let ctx = TypeResolver.makeContext index def.Generics
            emitContainerVariant w isFirst ctx def nonExhaustive
        | Some (VariantKind.InternalTag (tag, defaultTag, nonExhaustive)) ->
            // Unusual: interface with internal tag. Emit as record for now.
            let ctx = TypeResolver.makeContext index def.Generics
            emitRecord w isFirst ctx def.Name.Name def.Properties def.Generics def.Description
        | _ ->
            let ctx = TypeResolver.makeContext index def.Generics
            emitRecord w isFirst ctx def.Name.Name def.Properties def.Generics def.Description

    | TypeDefinition.TypeAlias def ->
        match def.Variants with
        | Some (VariantKind.InternalTag (tag, defaultTag, nonExhaustive)) ->
            let ctx = TypeResolver.makeContext index def.Generics
            emitInternalTagVariant w isFirst ctx def tag defaultTag nonExhaustive
        | _ ->
            let ctx = TypeResolver.makeContext index def.Generics
            emitTypeAlias w isFirst ctx def

    | TypeDefinition.Request _ -> ()  // Handled by OperationEmitter
    | TypeDefinition.Response _ -> () // Handled by OperationEmitter

// ============================================================================
// Emit a TypeGroup (potentially mutually recursive)
// ============================================================================

let emitTypeGroup (w: Writer) (index: TypeIndex.TypeIndex) (group: DependencyGraph.TypeGroup) =
    let emittable =
        group.Types
        |> List.filter (fun td ->
            match td with
            | TypeDefinition.Request _ | TypeDefinition.Response _ -> false
            | _ -> true)

    match emittable with
    | [] -> ()
    | _ ->
        for i, td in emittable |> List.indexed do
            emitTypeDefinition w index (i = 0) td
