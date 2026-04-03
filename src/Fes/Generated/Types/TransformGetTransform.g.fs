// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TransformGetTransform =

    type TransformSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("authorization")>]
        Authorization: MlTypes.TransformAuthorization option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time_string")>]
        CreateTimeString: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dest")>]
        Dest: GlobalReindex.Destination
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("latest")>]
        Latest: TransformTypes.Latest option
        [<System.Text.Json.Serialization.JsonPropertyName("pivot")>]
        Pivot: TransformTypes.Pivot option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_policy")>]
        RetentionPolicy: TransformTypes.RetentionPolicyContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: TransformTypes.Settings option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: TransformTypes.Source
        [<System.Text.Json.Serialization.JsonPropertyName("sync")>]
        Sync: TransformTypes.SyncContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
    }

