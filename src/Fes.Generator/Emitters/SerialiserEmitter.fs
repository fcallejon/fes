module Fes.Generator.Emitters.SerialiserEmitter

open Fes.Generator.Schema
open Fes.Generator.Analysis
open Fes.Generator.Emitters.FSharpWriter

// ============================================================================
// Emit JsonConverter for container variant DUs
// ============================================================================

let private emitContainerVariantConverter (w: Writer) (ctx: TypeResolver.ResolveContext) (def: InterfaceDefinition) (nonExhaustive: bool) (resolvedName: string) =
    let variantProps = def.Properties |> List.filter (fun p -> not p.ContainerProperty)
    let duName = resolvedName
    let fullDuName = duName
    let converterName = $"{duName}Converter"

    w.Line $"type {converterName}() ="
    w.Line $"    inherit System.Text.Json.Serialization.JsonConverter<{fullDuName}>()"
    w.BlankLine()

    // Write
    w.Indent()
    w.Line $"override _.Write(writer, value, options) ="
    w.Indent()
    w.Line "writer.WriteStartObject()"
    w.Line $"match value with"
    for p in variantProps do
        let caseName = Namespacing.toPascalCase p.Name
        match p.Type with
        | ValueOf.DictionaryOf (_, _, true) ->
            w.Line $"| {fullDuName}.{caseName} (field, v) ->"
            w.Indent()
            w.Line $"writer.WritePropertyName(\"{p.Name}\")"
            w.Line "writer.WriteStartObject()"
            w.Line "writer.WritePropertyName(field)"
            w.Line "System.Text.Json.JsonSerializer.Serialize(writer, v, options)"
            w.Line "writer.WriteEndObject()"
            w.Dedent()
        | _ ->
            w.Line $"| {fullDuName}.{caseName} v ->"
            w.Indent()
            w.Line $"writer.WritePropertyName(\"{p.Name}\")"
            w.Line "System.Text.Json.JsonSerializer.Serialize(writer, v, options)"
            w.Dedent()
    if nonExhaustive then
        w.Line $"| {fullDuName}.Unknown (name, el) ->"
        w.Indent()
        w.Line "writer.WritePropertyName(name)"
        w.Line "el.WriteTo(writer)"
        w.Dedent()
    w.Line "writer.WriteEndObject()"
    w.Dedent()
    w.BlankLine()

    // Read
    w.Line $"override _.Read(reader, _typeToConvert, options) ="
    w.Indent()
    w.Line "if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then"
    w.Line $"    raise (System.Text.Json.JsonException(\"Expected StartObject for {duName}\"))"
    w.Line "reader.Read() |> ignore"
    w.Line "if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then"
    w.Line $"    raise (System.Text.Json.JsonException(\"Expected PropertyName for {duName}\"))"
    w.Line "let propName = reader.GetString()"
    w.Line "reader.Read() |> ignore"
    w.Line "let result ="
    w.Indent()
    w.Line "match propName with"
    for p in variantProps do
        let caseName = Namespacing.toPascalCase p.Name
        match p.Type with
        | ValueOf.DictionaryOf (_, value, true) ->
            let valueType = TypeResolver.resolveValueOf ctx value
            w.Line $"| \"{p.Name}\" ->"
            w.Indent()
            w.Line "reader.Read() |> ignore // StartObject"
            w.Line "let field = reader.GetString()"
            w.Line "reader.Read() |> ignore"
            w.Line $"let v = System.Text.Json.JsonSerializer.Deserialize<{valueType}>(&reader, options)"
            w.Line "reader.Read() |> ignore // EndObject"
            w.Line $"{fullDuName}.{caseName} (field, v)"
            w.Dedent()
        | _ ->
            let caseType = TypeResolver.resolveValueOf ctx p.Type
            w.Line $"| \"{p.Name}\" ->"
            w.Indent()
            w.Line $"let v = System.Text.Json.JsonSerializer.Deserialize<{caseType}>(&reader, options)"
            w.Line $"{fullDuName}.{caseName} v"
            w.Dedent()
    if nonExhaustive then
        w.Line "| other ->"
        w.Indent()
        w.Line "let el = System.Text.Json.JsonElement.ParseValue(&reader)"
        w.Line $"{fullDuName}.Unknown (other, el)"
        w.Dedent()
    else
        w.Line $"| other -> raise (System.Text.Json.JsonException($\"Unknown property '{{other}}' for {duName}\"))"
    w.Dedent()
    w.Line "reader.Read() |> ignore // EndObject"
    w.Line "result"
    w.Dedent()
    w.Dedent()
    w.BlankLine()

// ============================================================================
// Emit JsonConverter for enums
// ============================================================================

let private emitEnumConverter (w: Writer) (def: EnumDefinition) (resolvedName: string) =
    let enumName = resolvedName
    let fullName = enumName
    let converterName = $"{enumName}Converter"

    w.Line $"type {converterName}() ="
    w.Line $"    inherit System.Text.Json.Serialization.JsonConverter<{fullName}>()"
    w.BlankLine()

    w.Indent()
    w.Line $"override _.Write(writer, value, _options) ="
    w.Indent()
    w.Line "let s ="
    w.Indent()
    w.Line "match value with"
    for m in def.Members do
        let caseName = Namespacing.toPascalCase m.Name
        let caseName = if caseName = "" then "Empty" elif System.Char.IsDigit caseName[0] then $"N{caseName}" else caseName
        w.Line $"| {fullName}.{caseName} -> \"{m.Name}\""
    if def.IsOpen then
        w.Line $"| {fullName}.Custom v -> v"
    w.Dedent()
    w.Line "writer.WriteStringValue(s)"
    w.Dedent()
    w.BlankLine()

    w.Line $"override _.Read(reader, _typeToConvert, _options) ="
    w.Indent()
    w.Line "let s = reader.GetString()"
    w.Line "match s with"
    for m in def.Members do
        let caseName = Namespacing.toPascalCase m.Name
        let caseName = if caseName = "" then "Empty" elif System.Char.IsDigit caseName[0] then $"N{caseName}" else caseName
        w.Line $"| \"{m.Name}\" -> {fullName}.{caseName}"
    if def.IsOpen then
        w.Line $"| other -> {fullName}.Custom other"
    else
        w.Line $"| other -> raise (System.Text.Json.JsonException($\"Unknown enum value '{{other}}' for {enumName}\"))"
    w.Dedent()
    w.Dedent()
    w.BlankLine()

// ============================================================================
// Emit JsonConverter for internal-tag variant DUs (type_alias)
// ============================================================================

let private emitInternalTagConverter (w: Writer) (ctx: TypeResolver.ResolveContext) (def: TypeAliasDefinition) (tag: string) (_defaultTag: string option) (nonExhaustive: bool) (resolvedName: string) =
    let duName = resolvedName
    let fullDuName = duName
    let converterName = $"{duName}Converter"

    w.Line $"type {converterName}() ="
    w.Line $"    inherit System.Text.Json.Serialization.JsonConverter<{fullDuName}>()"
    w.BlankLine()

    w.Indent()
    w.Line $"override _.Write(writer, value, options) ="
    w.Indent()
    w.Line $"match value with"
    match def.Type with
    | ValueOf.UnionOf items ->
        for item in items do
            match item with
            | ValueOf.InstanceOf (tn, _) ->
                let caseName = Namespacing.toPascalCase tn.Name
                w.Line $"| {fullDuName}.{caseName} v ->"
                w.Line $"    System.Text.Json.JsonSerializer.Serialize(writer, v, options)"
            | _ -> ()
    | _ -> ()
    if nonExhaustive then
        w.Line $"| {fullDuName}.Unknown (_, el) -> el.WriteTo(writer)"
    w.Dedent()
    w.BlankLine()

    w.Line $"override _.Read(reader, _typeToConvert, options) ="
    w.Indent()
    w.Line "let doc = System.Text.Json.JsonDocument.ParseValue(&reader)"
    w.Line $"let tagValue ="
    w.Line $"    match doc.RootElement.TryGetProperty(\"{tag}\") with"
    w.Line "    | true, v -> v.GetString()"
    w.Line $"    | _ -> \"\""
    w.Line "match tagValue with"
    match def.Type with
    | ValueOf.UnionOf items ->
        for item in items do
            match item with
            | ValueOf.InstanceOf (tn, _) ->
                let caseName = Namespacing.toPascalCase tn.Name
                let caseType = TypeResolver.resolveValueOf ctx item
                // The tag value is typically the snake_case type name
                let tagVal = tn.Name.Replace("Property", "") |> fun s -> s.ToLowerInvariant()
                w.Line $"| \"{tagVal}\" ->"
                w.Line $"    let v = System.Text.Json.JsonSerializer.Deserialize<{caseType}>(doc.RootElement.GetRawText(), options)"
                w.Line $"    {fullDuName}.{caseName} v"
            | _ -> ()
    | _ -> ()
    if nonExhaustive then
        w.Line $"| _ -> {fullDuName}.Unknown (tagValue, doc.RootElement.Clone())"
    else
        w.Line $"| other -> raise (System.Text.Json.JsonException($\"Unknown tag value '{{other}}' for {duName}\"))"
    w.Dedent()
    w.Dedent()
    w.BlankLine()

// ============================================================================
// Collect all types needing converters and emit registration
// ============================================================================

type ConverterInfo = {
    ConverterName: string
    FullTypeName: string
}

let emitAllConverters (index: TypeIndex.TypeIndex) (types: TypeDefinition list) : (string * string) list =
    let w = Writer()
    w.Header()
    w.Namespace "Fes.Generated"
    w.BlankLine()
    w.Open "Fes.Generated"
    w.Open "Fes.Generated.Types"
    w.BlankLine()
    w.Line "module Converters ="
    w.BlankLine()
    w.Indent()

    let mutable converterNames = []

    let lookupName (tn: TypeName) =
        match Map.tryFind tn index.NameMap with
        | Some n -> n
        | None -> Namespacing.toFSharpTypeName tn.Name

    for td in types do
        match td with
        | TypeDefinition.Interface def ->
            match def.Variants with
            | Some (VariantKind.Container nonExhaustive) ->
                let ctx = TypeResolver.makeContext index def.Generics
                let duName = lookupName def.Name
                emitContainerVariantConverter w ctx def nonExhaustive duName
                converterNames <- $"{duName}Converter" :: converterNames
            | _ -> ()

        | TypeDefinition.Enum def ->
            let enumName = lookupName def.Name
            emitEnumConverter w def enumName
            converterNames <- $"{enumName}Converter" :: converterNames

        | TypeDefinition.TypeAlias def ->
            match def.Variants with
            | Some (VariantKind.InternalTag (tag, defaultTag, nonExhaustive)) ->
                let ctx = TypeResolver.makeContext index def.Generics
                let duName = lookupName def.Name
                emitInternalTagConverter w ctx def tag defaultTag nonExhaustive duName
                converterNames <- $"{duName}Converter" :: converterNames
            | _ -> ()

        | _ -> ()

    // Registration function
    w.BlankLine()
    w.Line "let registerAll (options: System.Text.Json.JsonSerializerOptions) ="
    w.Indent()
    for name in converterNames |> List.rev do
        w.Line $"options.Converters.Add({name}())"
    w.Dedent()

    w.Dedent()

    [ "Converters.g.fs", w.ToString() ]
