// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SpecUtils =

    /// In some places in the specification an object consists of the union of a set of known properties
    type AdditionalProperties<'tKey, 'tValue> = {
    }

    /// In some places in the specification an object consists of a static set of properties and a single additional property
    type AdditionalProperty<'tKey, 'tValue> = {
    }

    type BaseNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: Types.Ip
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Types.NodeRoles option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
    }

    /// Implements a set of common query parameters all Cat API's support.
    type CommonCatQueryParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: string option
        [<System.Text.Json.Serialization.JsonPropertyName("help")>]
        Help: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("v")>]
        V: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: Types.Bytes option
        [<System.Text.Json.Serialization.JsonPropertyName("time")>]
        Time: Types.TimeUnit option
    }

    /// Implements a set of common query parameters all API's support.
    type CommonQueryParameters = {
        [<System.Text.Json.Serialization.JsonPropertyName("error_trace")>]
        ErrorTrace: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter_path")>]
        FilterPath: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("human")>]
        Human: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pretty")>]
        Pretty: bool option
    }

    /// A `null` value that is to be interpreted as an actual value, unless other uses of `null` that are equivalent
    type NullValue = unit

    /// A class that implements `OverloadOf` only needs to declare properties that differ from the parent.
    type OverloadOf<'tDefinition> = {
    }

    /// A set of flags that can be represented as a single enum value or a set of values that are encoded
    [<RequireQualifiedAccess>]
    type PipeSeparatedFlags<'t> =
        | T of 't
        | String of string

    /// Some APIs will return values such as numbers also as a string (notably epoch timestamps). This behavior
    [<RequireQualifiedAccess>]
    type Stringified<'t> =
        | T of 't
        | String of string

    /// The absence of any type. This is commonly used in APIs that don't return a body.
    type Void = unit

    /// `WithNullValue&lt;T&gt;` allows for explicit null assignments in contexts where `null` should be interpreted as an
    [<RequireQualifiedAccess>]
    type WithNullValue<'t> =
        | T of 't
        | NullValue of SpecUtils.NullValue

