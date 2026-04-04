module Fes.Generator.Emitters.TypeEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

// ============================================================================
// Helpers
// ============================================================================

/// Filter generic params to only those that actually appear in generated output
let filterUsedGenerics (generics: TypeName list) (bodyText: string) =
    match generics with
    | [] -> ""
    | gs ->
        let used =
            gs |> List.filter (fun g ->
                let paramStr = $"'{g.Name}"
                bodyText.Contains(paramStr))
        match used with
        | [] -> ""
        | us -> "<" + (us |> List.map (fun g -> $"'{g.Name}") |> String.concat ", ") + ">"

/// Deduplicate record field names — returns properties with CodegenName set for collisions
let dedupRecordFields (properties: Property list) : Property list =
    let mutable seenFields = Set.empty
    properties |> List.map (fun p ->
        let fieldName = Namespacing.toFieldName p.Name
        if Set.contains fieldName seenFields then
            let altName = Namespacing.toPascalCase ($"{p.Name}_field")
            seenFields <- Set.add altName seenFields
            { p with CodegenName = Some altName }
        else
            seenFields <- Set.add fieldName seenFields
            p)

/// Get the actual F# field name for a property (respecting dedup)
let getRecordFieldName (p: Property) =
    match p.CodegenName with
    | Some alt -> alt
    | None -> Namespacing.toFieldName p.Name

// ============================================================================
// Emit Enums
// ============================================================================

let emitEnumWithName (w: Writer) (isFirst: bool) (def: EnumDefinition) (typeName: string) =
    w.DocComment def.Description
    if isFirst then
        w.Attribute "RequireQualifiedAccess"
        w.Line $"type {typeName} ="
    else
        w.Line $"and [<RequireQualifiedAccess>] {typeName} ="

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

/// Generate the default value expression for a required field.
/// LiteralValue fields produce their fixed value; others fall back to Unchecked.defaultof.
let defaultValueExpr (p: Property) : string =
    match p.Type with
    | ValueOf.LiteralValue (LiteralValue.String s) -> $"\"{s}\""
    | ValueOf.LiteralValue (LiteralValue.Bool b) -> if b then "true" else "false"
    | ValueOf.LiteralValue (LiteralValue.Number n) ->
        let s = n.ToString(System.Globalization.CultureInfo.InvariantCulture)
        if s.Contains('.') then s else $"{s}.0"
    | _ -> "Unchecked.defaultof<_>"

let emitRecord (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (name: string) (properties: Property list) (generics: TypeName list) (description: string option) =
    w.DocComment description
    let keyword = w.TypeKeyword isFirst

    if properties.IsEmpty then
        // F# records cannot be empty — use a type alias to JsonElement (no generics needed)
        w.Line $"{keyword} {name} = System.Text.Json.JsonElement"
    else
        // For records, keep all declared generic params (they may be used indirectly
        // via fields that resolve to JsonElement for complex unions)
        let genericParams =
            match generics with
            | [] -> ""
            | gs -> "<" + (gs |> List.map (fun g -> $"'{g.Name}") |> String.concat ", ") + ">"

        let dedupedProperties = dedupRecordFields properties

        w.Line $"{keyword} {name}{genericParams} = {{"
        w.Indent()
        for p in dedupedProperties do
            match p.CodegenName with
            | Some altName ->
                if p.Name <> altName then
                    w.Line $"[<System.Text.Json.Serialization.JsonPropertyName(\"{p.Name}\")>]"
                let fieldType = TypeResolver.resolveValueOf ctx p.Type
                let finalType = if p.Required then fieldType else $"{fieldType} option"
                w.Line $"{altName}: {finalType}"
            | None ->
                emitRecordField w ctx p
        w.Dedent()
        w.Line "}"

        // Generate static member empty for non-generic records
        if generics.IsEmpty then
            w.BlankLine()
            w.Indent()
            w.Line "with"
            w.Line $"static member empty : {name} ="
            w.Indent()
            w.Line "{"
            w.Indent()
            for p in dedupedProperties do
                let fieldName = getRecordFieldName p
                if p.Required then
                    w.Line $"{fieldName} = {defaultValueExpr p}"
                else
                    w.Line $"{fieldName} = None"
            w.Dedent()
            w.Line "}"
            w.Dedent()
            w.Dedent()

    w.BlankLine()

// ============================================================================
// Emit Container Variants (DUs)
// ============================================================================

let emitContainerVariantWithName (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (def: InterfaceDefinition) (nonExhaustive: bool) (duName: string) =
    let containerProps = def.Properties |> List.filter _.ContainerProperty
    let variantProps = def.Properties |> List.filter (fun p -> not p.ContainerProperty)

    // Emit the DU
    w.DocComment def.Description
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

let emitInternalTagVariantWithName (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (def: TypeAliasDefinition) (_tag: string) (_defaultTag: string option) (nonExhaustive: bool) (duName: string) =
    w.DocComment def.Description
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

let emitTypeAliasWithName (w: Writer) (isFirst: bool) (ctx: TypeResolver.ResolveContext) (def: TypeAliasDefinition) (name: string) =
    w.DocComment def.Description

    match def.Type with
    | ValueOf.UnionOf items when items.Length >= 2 ->
        // Emit as DU for unions — collect all case types to check generic usage
        let cases =
            items |> List.mapi (fun i item ->
                let caseType = TypeResolver.resolveValueOf ctx item
                let caseName =
                    match item with
                    | ValueOf.InstanceOf (tn, _) -> Namespacing.toPascalCase tn.Name
                    | ValueOf.ArrayOf _ -> "Array"
                    | ValueOf.DictionaryOf _ -> "Dictionary"
                    | _ -> $"Case{i}"
                caseName, caseType)
        // Dedup case names
        let mutable seenCases = Map.empty<string, int>
        let dedupedCases =
            cases |> List.map (fun (caseName, caseType) ->
                let count = Map.tryFind caseName seenCases |> Option.defaultValue 0
                seenCases <- Map.add caseName (count + 1) seenCases
                let finalName = if count > 0 then $"{caseName}{count + 1}" else caseName
                finalName, caseType)
        let allCaseTypes = dedupedCases |> List.map snd |> String.concat " "
        let genericParams = filterUsedGenerics def.Generics allCaseTypes
        if isFirst then
            w.Attribute "RequireQualifiedAccess"
            w.Line $"type {name}{genericParams} ="
        else
            w.Line $"and [<RequireQualifiedAccess>] {name}{genericParams} ="
        w.Indent()
        for caseName, caseType in dedupedCases do
            w.Line $"| {caseName} of {caseType}"
        w.Dedent()
    | _ ->
        let keyword = w.TypeKeyword isFirst
        let resolved = TypeResolver.resolveValueOf ctx def.Type
        let genericParams = filterUsedGenerics def.Generics resolved
        w.Line $"{keyword} {name}{genericParams} = {resolved}"

    w.BlankLine()

// ============================================================================
// Emit a single TypeDefinition
// ============================================================================

let private lookupName (nameMap: Map<TypeName, string>) (tn: TypeName) =
    match Map.tryFind tn nameMap with
    | Some n -> n
    | None -> Namespacing.toFSharpTypeName tn.Name

let emitTypeDefinition (w: Writer) (index: TypeIndex.TypeIndex) (isFirst: bool) (currentNamespace: string) (td: TypeDefinition) =
    let mkCtx generics = TypeResolver.makeContextInNamespace index generics currentNamespace
    let getName (tn: TypeName) = lookupName index.NameMap tn
    match td with
    | TypeDefinition.Enum def ->
        emitEnumWithName w isFirst def (getName def.Name)

    | TypeDefinition.Interface def ->
        let name = getName def.Name
        match def.Variants with
        | Some (VariantKind.Container nonExhaustive) ->
            emitContainerVariantWithName w isFirst (mkCtx def.Generics) def nonExhaustive name
        | Some (VariantKind.InternalTag _) ->
            emitRecord w isFirst (mkCtx def.Generics) name def.Properties def.Generics def.Description
        | _ ->
            emitRecord w isFirst (mkCtx def.Generics) name def.Properties def.Generics def.Description

    | TypeDefinition.TypeAlias def ->
        let name = getName def.Name
        match def.Variants with
        | Some (VariantKind.InternalTag (tag, defaultTag, nonExhaustive)) ->
            emitInternalTagVariantWithName w isFirst (mkCtx def.Generics) def tag defaultTag nonExhaustive name
        | _ ->
            emitTypeAliasWithName w isFirst (mkCtx def.Generics) def name

    | TypeDefinition.Request _ -> ()
    | TypeDefinition.Response _ -> ()

// ============================================================================
// Emit a TypeGroup (potentially mutually recursive)
// ============================================================================

let emitTypeGroup (w: Writer) (index: TypeIndex.TypeIndex) (currentNamespace: string) (group: DependencyGraph.TypeGroup) =
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
            emitTypeDefinition w index (i = 0) currentNamespace td
