// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MigrationDeprecations =

    [<RequireQualifiedAccess>]
    type DeprecationLevel =
        | None
        | Info
        | Warning
        | Critical

    type Deprecation = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: string option
        [<System.Text.Json.Serialization.JsonPropertyName("level")>]
        Level: DeprecationLevel
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: string
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("resolve_during_rolling_upgrade")>]
        ResolveDuringRollingUpgrade: bool
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Map<string, System.Text.Json.JsonElement> option
    }

