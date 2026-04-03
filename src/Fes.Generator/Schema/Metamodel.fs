namespace Fes.Generator.Schema

open System.Text.Json

/// A reference to a named type in the specification (namespace + name)
[<Struct>]
type TypeName = {
    Name: string
    Namespace: string
}

/// Variant strategy descriptors
[<RequireQualifiedAccess>]
type VariantKind =
    | Container of nonExhaustive: bool
    | InternalTag of tag: string * defaultTag: string option * nonExhaustive: bool
    | ExternalTag
    | Untagged of untypedVariant: TypeName option

/// A type reference in the schema — the "value" side of any property or parameter type
[<RequireQualifiedAccess>]
type ValueOf =
    | InstanceOf of typeName: TypeName * generics: ValueOf list
    | ArrayOf of value: ValueOf
    | UnionOf of items: ValueOf list
    | DictionaryOf of key: ValueOf * value: ValueOf * singleKey: bool
    | UserDefinedValue
    | LiteralValue of value: LiteralValue

and [<RequireQualifiedAccess>] LiteralValue =
    | String of string
    | Bool of bool
    | Number of float

/// A property on a type or request
type Property = {
    Name: string
    Type: ValueOf
    Required: bool
    Description: string option
    ServerDefault: JsonElement option
    Aliases: string list
    CodegenName: string option
    ContainerProperty: bool
    Deprecation: Deprecation option
}

and Deprecation = {
    Version: string
    Description: string
}

/// The body of a request or response
[<RequireQualifiedAccess>]
type Body =
    | Properties of properties: Property list
    | Value of value: ValueOf * codegenName: string option
    | NoBody

/// Inherits clause
type Inherits = {
    Type: TypeName
    Generics: ValueOf list
}

/// A type definition in the schema
[<RequireQualifiedAccess>]
type TypeDefinition =
    | Interface of InterfaceDefinition
    | Request of RequestDefinition
    | Response of ResponseDefinition
    | Enum of EnumDefinition
    | TypeAlias of TypeAliasDefinition

and InterfaceDefinition = {
    Name: TypeName
    Properties: Property list
    Inherits: Inherits option
    Generics: TypeName list
    Variants: VariantKind option
    ShortcutProperty: string option
    Behaviours: string list
    Description: string option
}

and RequestDefinition = {
    Name: TypeName
    Path: Property list
    Query: Property list
    Body: Body
    Inherits: Inherits option
    Generics: TypeName list
    AttachedBehaviours: string list
    Description: string option
}

and ResponseDefinition = {
    Name: TypeName
    Body: Body
    Generics: TypeName list
    Description: string option
}

and EnumMember = {
    Name: string
    Description: string option
    Aliases: string list
    Deprecation: Deprecation option
}

and EnumDefinition = {
    Name: TypeName
    Members: EnumMember list
    IsOpen: bool
    Description: string option
}

and TypeAliasDefinition = {
    Name: TypeName
    Type: ValueOf
    Generics: TypeName list
    Variants: VariantKind option
    Description: string option
}

/// URL template for an endpoint
type UrlTemplate = {
    Path: string
    Methods: string list
}

/// An API endpoint
type Endpoint = {
    Name: string
    Description: string option
    Urls: UrlTemplate list
    Request: TypeName
    Response: TypeName
    RequestBodyRequired: bool
    Availability: JsonElement option
    CodegenExclude: bool
}

/// The top-level model (root of schema.json)
type Model = {
    Endpoints: Endpoint list
    Types: TypeDefinition list
}

/// Helper to extract the TypeName from any TypeDefinition
module TypeDefinition =

    let name = function
        | TypeDefinition.Interface d -> d.Name
        | TypeDefinition.Request d -> d.Name
        | TypeDefinition.Response d -> d.Name
        | TypeDefinition.Enum d -> d.Name
        | TypeDefinition.TypeAlias d -> d.Name

    let description = function
        | TypeDefinition.Interface d -> d.Description
        | TypeDefinition.Request d -> d.Description
        | TypeDefinition.Response d -> d.Description
        | TypeDefinition.Enum d -> d.Description
        | TypeDefinition.TypeAlias d -> d.Description
