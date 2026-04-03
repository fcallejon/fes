// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EsqlTypes =

    type EsqlColumnInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type EsqlClusterStatus =
        | Running
        | Successful
        | Partial
        | Skipped
        | Failed

    type EsqlShardInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Integer option
    }

    type EsqlShardFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: CoreTypes.ErrorCause
    }

    type EsqlClusterDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: EsqlClusterStatus
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: EsqlShardInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: EsqlShardFailure list option
    }

    type EsqlClusterInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("running")>]
        Running: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<string, EsqlClusterDetails>
    }

    type EsqlResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("all_columns")>]
        AllColumns: EsqlColumnInfo list option
        [<System.Text.Json.Serialization.JsonPropertyName("columns")>]
        Columns: EsqlColumnInfo list
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: CoreTypes.FieldValue list list
        [<System.Text.Json.Serialization.JsonPropertyName("_clusters")>]
        Clusters: EsqlClusterInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: System.Text.Json.JsonElement option
    }

    type AsyncEsqlResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("is_running")>]
        IsRunning: bool
    }

    [<RequireQualifiedAccess>]
    type SingleOrMultiValue =
        | FieldValue of CoreTypes.FieldValue
        | Array of CoreTypes.FieldValue list

    type NamedValue = Map<string, SingleOrMultiValue>

    [<RequireQualifiedAccess>]
    type ESQLParams =
        | Array of SingleOrMultiValue list
        | Array of NamedValue list

    /// A non-materialized ES|QL view.
    type ESQLView = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: string
    }

    [<RequireQualifiedAccess>]
    type EsqlFormat =
        | Csv
        | Json
        | Tsv
        | Txt
        | Yaml
        | Cbor
        | Smile
        | Arrow

    [<RequireQualifiedAccess>]
    type TableValuesIntegerValue =
        | Integer of CoreTypes.Integer
        | Array of CoreTypes.Integer list

    [<RequireQualifiedAccess>]
    type TableValuesKeywordValue =
        | String of string
        | Array of string list

    [<RequireQualifiedAccess>]
    type TableValuesLongValue =
        | Long of CoreTypes.Long
        | Array of CoreTypes.Long list

    [<RequireQualifiedAccess>]
    type TableValuesLongDouble =
        | Double of CoreTypes.Double
        | Array of CoreTypes.Double list

    [<RequireQualifiedAccess>]
    type TableValuesContainer =
        | Integer of TableValuesIntegerValue list
        | Keyword of TableValuesKeywordValue list
        | Long of TableValuesLongValue list
        | Double of TableValuesLongDouble list

