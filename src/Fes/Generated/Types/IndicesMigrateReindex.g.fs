// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesMigrateReindex =

    [<RequireQualifiedAccess>]
    type ModeEnum =
        | Upgrade

    type SourceIndex = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
    }

    type MigrateReindex = {
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: IndicesMigrateReindex.ModeEnum
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: IndicesMigrateReindex.SourceIndex
    }

