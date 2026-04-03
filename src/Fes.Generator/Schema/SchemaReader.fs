module Fes.Generator.Schema.SchemaReader

open System
open System.Text.Json
open Fes.Generator.Schema

// ============================================================================
// JSON Helpers
// ============================================================================

let private getStringProp (el: JsonElement) (name: string) =
    match el.TryGetProperty(name) with
    | true, v when v.ValueKind = JsonValueKind.String -> Some (v.GetString())
    | _ -> None

let private getStringPropOr (el: JsonElement) (name: string) (defaultValue: string) =
    getStringProp el name |> Option.defaultValue defaultValue

let private getBoolProp (el: JsonElement) (name: string) =
    match el.TryGetProperty(name) with
    | true, v when v.ValueKind = JsonValueKind.True -> true
    | true, v when v.ValueKind = JsonValueKind.False -> false
    | _ -> false

let private getArrayProp (el: JsonElement) (name: string) =
    match el.TryGetProperty(name) with
    | true, v when v.ValueKind = JsonValueKind.Array ->
        v.EnumerateArray() |> Seq.toList
    | _ -> []

let private getObjectProp (el: JsonElement) (name: string) =
    match el.TryGetProperty(name) with
    | true, v when v.ValueKind = JsonValueKind.Object -> Some v
    | _ -> None

let private getElementProp (el: JsonElement) (name: string) =
    match el.TryGetProperty(name) with
    | true, v when v.ValueKind <> JsonValueKind.Null && v.ValueKind <> JsonValueKind.Undefined -> Some v
    | _ -> None

// ============================================================================
// Parse TypeName
// ============================================================================

let private parseTypeName (el: JsonElement) : TypeName =
    { Name = el.GetProperty("name").GetString()
      Namespace = el.GetProperty("namespace").GetString() }

// ============================================================================
// Parse ValueOf (recursive)
// ============================================================================

let rec private parseValueOf (el: JsonElement) : ValueOf =
    let kind = el.GetProperty("kind").GetString()
    match kind with
    | "instance_of" ->
        let typeName = parseTypeName (el.GetProperty("type"))
        let generics =
            getArrayProp el "generics"
            |> List.map parseValueOf
        ValueOf.InstanceOf (typeName, generics)
    | "array_of" ->
        ValueOf.ArrayOf (parseValueOf (el.GetProperty("value")))
    | "union_of" ->
        let items =
            getArrayProp el "items"
            |> List.map parseValueOf
        ValueOf.UnionOf items
    | "dictionary_of" ->
        let key = parseValueOf (el.GetProperty("key"))
        let value = parseValueOf (el.GetProperty("value"))
        let singleKey = getBoolProp el "singleKey"
        ValueOf.DictionaryOf (key, value, singleKey)
    | "user_defined_value" ->
        ValueOf.UserDefinedValue
    | "literal_value" ->
        let v = el.GetProperty("value")
        let lit =
            match v.ValueKind with
            | JsonValueKind.String -> LiteralValue.String (v.GetString())
            | JsonValueKind.True -> LiteralValue.Bool true
            | JsonValueKind.False -> LiteralValue.Bool false
            | JsonValueKind.Number -> LiteralValue.Number (v.GetDouble())
            | _ -> LiteralValue.String (v.GetRawText())
        ValueOf.LiteralValue lit
    | other ->
        eprintfn $"Warning: unknown ValueOf kind '{other}', treating as UserDefinedValue"
        ValueOf.UserDefinedValue

// ============================================================================
// Parse Deprecation
// ============================================================================

let private parseDeprecation (el: JsonElement) : Deprecation =
    { Version = getStringPropOr el "version" ""
      Description = getStringPropOr el "description" "" }

// ============================================================================
// Parse Property
// ============================================================================

let private parseProperty (el: JsonElement) : Property =
    { Name = el.GetProperty("name").GetString()
      Type = parseValueOf (el.GetProperty("type"))
      Required = getBoolProp el "required"
      Description = getStringProp el "description"
      ServerDefault = getElementProp el "serverDefault"
      Aliases =
          getArrayProp el "aliases"
          |> List.choose (fun a ->
              if a.ValueKind = JsonValueKind.String then Some (a.GetString())
              else None)
      CodegenName = getStringProp el "codegenName"
      ContainerProperty = getBoolProp el "containerProperty"
      Deprecation =
          getObjectProp el "deprecation"
          |> Option.map parseDeprecation }

// ============================================================================
// Parse Body
// ============================================================================

let private parseBody (el: JsonElement) : Body =
    let kind = el.GetProperty("kind").GetString()
    match kind with
    | "properties" ->
        let props =
            getArrayProp el "properties"
            |> List.map parseProperty
        Body.Properties props
    | "value" ->
        let value = parseValueOf (el.GetProperty("value"))
        let codegenName = getStringProp el "codegenName"
        Body.Value (value, codegenName)
    | "no_body" ->
        Body.NoBody
    | other ->
        eprintfn $"Warning: unknown body kind '{other}', treating as NoBody"
        Body.NoBody

// ============================================================================
// Parse Inherits
// ============================================================================

let private parseInherits (el: JsonElement) : Inherits =
    { Type = parseTypeName (el.GetProperty("type"))
      Generics =
          getArrayProp el "generics"
          |> List.map parseValueOf }

// ============================================================================
// Parse Variant
// ============================================================================

let private parseVariant (el: JsonElement) : VariantKind =
    let kind = el.GetProperty("kind").GetString()
    match kind with
    | "container" ->
        VariantKind.Container (getBoolProp el "nonExhaustive")
    | "internal_tag" ->
        let tag = el.GetProperty("tag").GetString()
        let defaultTag = getStringProp el "defaultTag"
        let nonExhaustive = getBoolProp el "nonExhaustive"
        VariantKind.InternalTag (tag, defaultTag, nonExhaustive)
    | "external_tag" ->
        VariantKind.ExternalTag
    | "untagged" ->
        let untypedVariant =
            getObjectProp el "untypedVariant"
            |> Option.map parseTypeName
        VariantKind.Untagged untypedVariant
    | other ->
        eprintfn $"Warning: unknown variant kind '{other}', treating as container"
        VariantKind.Container false

// ============================================================================
// Parse Enum Member
// ============================================================================

let private parseEnumMember (el: JsonElement) : EnumMember =
    { Name = el.GetProperty("name").GetString()
      Description = getStringProp el "description"
      Aliases =
          getArrayProp el "aliases"
          |> List.choose (fun a ->
              if a.ValueKind = JsonValueKind.String then Some (a.GetString())
              else None)
      Deprecation =
          getObjectProp el "deprecation"
          |> Option.map parseDeprecation }

// ============================================================================
// Parse TypeDefinition
// ============================================================================

let private parseGenericParams (el: JsonElement) =
    getArrayProp el "generics"
    |> List.map parseTypeName

let private parseTypeDefinition (el: JsonElement) : TypeDefinition =
    let kind = el.GetProperty("kind").GetString()
    let name = parseTypeName (el.GetProperty("name"))

    match kind with
    | "interface" ->
        TypeDefinition.Interface {
            Name = name
            Properties =
                getArrayProp el "properties"
                |> List.map parseProperty
            Inherits =
                getObjectProp el "inherits"
                |> Option.map parseInherits
            Generics = parseGenericParams el
            Variants =
                getObjectProp el "variants"
                |> Option.map parseVariant
            ShortcutProperty = getStringProp el "shortcutProperty"
            Behaviours =
                getArrayProp el "behaviors"
                |> List.choose (fun b ->
                    getStringProp b "type"
                    |> Option.orElseWith (fun () ->
                        getObjectProp b "type"
                        |> Option.map (fun t -> t.GetProperty("name").GetString())))
            Description = getStringProp el "description"
        }
    | "request" ->
        TypeDefinition.Request {
            Name = name
            Path =
                getArrayProp el "path"
                |> List.map parseProperty
            Query =
                getArrayProp el "query"
                |> List.map parseProperty
            Body =
                match getObjectProp el "body" with
                | Some body -> parseBody body
                | None -> Body.NoBody
            Inherits =
                getObjectProp el "inherits"
                |> Option.map parseInherits
            Generics = parseGenericParams el
            AttachedBehaviours =
                getArrayProp el "attachedBehaviors"
                |> List.choose (fun a ->
                    if a.ValueKind = JsonValueKind.String then Some (a.GetString())
                    else None)
            Description = getStringProp el "description"
        }
    | "response" ->
        TypeDefinition.Response {
            Name = name
            Body =
                match getObjectProp el "body" with
                | Some body -> parseBody body
                | None -> Body.NoBody
            Generics = parseGenericParams el
            Description = getStringProp el "description"
        }
    | "enum" ->
        TypeDefinition.Enum {
            Name = name
            Members =
                getArrayProp el "members"
                |> List.map parseEnumMember
            IsOpen = getBoolProp el "isOpen"
            Description = getStringProp el "description"
        }
    | "type_alias" ->
        TypeDefinition.TypeAlias {
            Name = name
            Type = parseValueOf (el.GetProperty("type"))
            Generics = parseGenericParams el
            Variants =
                getObjectProp el "variants"
                |> Option.map parseVariant
            Description = getStringProp el "description"
        }
    | other ->
        failwith $"Unknown type definition kind: '{other}'"

// ============================================================================
// Parse Endpoint
// ============================================================================

let private parseUrlTemplate (el: JsonElement) : UrlTemplate =
    { Path = el.GetProperty("path").GetString()
      Methods =
          getArrayProp el "methods"
          |> List.choose (fun m ->
              if m.ValueKind = JsonValueKind.String then Some (m.GetString())
              else None) }

let private parseEndpoint (el: JsonElement) : Endpoint =
    { Name = el.GetProperty("name").GetString()
      Description = getStringProp el "description"
      Urls =
          getArrayProp el "urls"
          |> List.map parseUrlTemplate
      Request = parseTypeName (el.GetProperty("request"))
      Response = parseTypeName (el.GetProperty("response"))
      RequestBodyRequired = getBoolProp el "requestBodyRequired"
      Availability = getElementProp el "availability"
      CodegenExclude = getBoolProp el "codegenExclude" }

// ============================================================================
// Parse Model (top-level)
// ============================================================================

let parseModel (el: JsonElement) : Model =
    { Endpoints =
          getArrayProp el "endpoints"
          |> List.map parseEndpoint
      Types =
          getArrayProp el "types"
          |> List.map parseTypeDefinition }

/// Read and parse a schema.json file
let readSchemaFile (path: string) : Model =
    let json = System.IO.File.ReadAllText(path)
    let doc = JsonDocument.Parse(json)
    parseModel doc.RootElement
