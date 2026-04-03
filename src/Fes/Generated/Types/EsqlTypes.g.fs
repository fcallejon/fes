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
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Integer option
    }

    type EsqlShardFailure = {
        [<System.Text.Json.Serialization.JsonPropertyName("shard")>]
        Shard: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: Types.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: Types.ErrorCause
    }

    type EsqlClusterDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: EsqlTypes.EsqlClusterStatus
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: string
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: EsqlTypes.EsqlShardInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("failures")>]
        Failures: EsqlTypes.EsqlShardFailure list option
    }

    type EsqlClusterInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("running")>]
        Running: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped")>]
        Skipped: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("partial")>]
        Partial: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed")>]
        Failed: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<string, EsqlTypes.EsqlClusterDetails>
    }

    type EsqlResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("is_partial")>]
        IsPartial: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("all_columns")>]
        AllColumns: EsqlTypes.EsqlColumnInfo list option
        [<System.Text.Json.Serialization.JsonPropertyName("columns")>]
        Columns: EsqlTypes.EsqlColumnInfo list
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Types.FieldValue list list
        [<System.Text.Json.Serialization.JsonPropertyName("_clusters")>]
        Clusters: EsqlTypes.EsqlClusterInfo option
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
        | FieldValue of Types.FieldValue
        | Array of Types.FieldValue list

    type NamedValue = Map<string, EsqlTypes.SingleOrMultiValue>

    [<RequireQualifiedAccess>]
    type ESQLParams =
        | Array of EsqlTypes.SingleOrMultiValue list
        | Array of EsqlTypes.NamedValue list

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
        | Integer of Types.Integer
        | Array of Types.Integer list

    [<RequireQualifiedAccess>]
    type TableValuesKeywordValue =
        | String of string
        | Array of string list

    [<RequireQualifiedAccess>]
    type TableValuesLongValue =
        | Long of Types.Long
        | Array of Types.Long list

    [<RequireQualifiedAccess>]
    type TableValuesLongDouble =
        | Double of Types.Double
        | Array of Types.Double list

    [<RequireQualifiedAccess>]
    type TableValuesContainer =
        | Integer of EsqlTypes.TableValuesIntegerValue list
        | Keyword of EsqlTypes.TableValuesKeywordValue list
        | Long of EsqlTypes.TableValuesLongValue list
        | Double of EsqlTypes.TableValuesLongDouble list

