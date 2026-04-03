// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SpecUtils =

    /// In some places in the specification an object consists of the union of a set of known properties
and a set of runtime injected properties. Meaning that object should theoretically extend Dictionary bu...
    type AdditionalProperties<'tKey, 'tValue> = {
    }

    /// In some places in the specification an object consists of a static set of properties and a single additional property
with an arbitrary name but a statically defined type. This is typically used for c...
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
Since these can break the request structure these are listed explicitly as a behavior.
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
Since these can break the request structure these are listed explicitly as a behavior.
Its up to individual clients to define support alt...
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
to a missing value. It is used for exemple in settings, where using the `NullValue` for a s...
    type NullValue = unit

    /// A class that implements `OverloadOf` only needs to declare properties that differ from the parent.
Unchanged properties are inherited automatically. For declared properties, you can change
whether a p...
    type OverloadOf<'tDefinition> = {
    }

    /// A set of flags that can be represented as a single enum value or a set of values that are encoded
as a pipe-separated string

Depending on the target language, code generators can use this hint to gen...
    [<RequireQualifiedAccess>]
    type PipeSeparatedFlags<'t> =
        | T of 't
        | String of string

    /// Some APIs will return values such as numbers also as a string (notably epoch timestamps). This behavior
is used to capture this behavior while keeping the semantics of the field type.

Depending on th...
    [<RequireQualifiedAccess>]
    type Stringified<'t> =
        | T of 't
        | String of string

    /// The absence of any type. This is commonly used in APIs that don't return a body.

Although "void" is generally used for the unit type that has only one value, this is to be interpreted as
the bottom t...
    type Void = unit

    /// `WithNullValue&lt;T&gt;` allows for explicit null assignments in contexts where `null` should be interpreted as an
actual value.
    [<RequireQualifiedAccess>]
    type WithNullValue<'t> =
        | T of 't
        | NullValue of SpecUtils.NullValue

