// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlInfo =

    type AnomalyDetectors = {
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: MlTypes.CategorizationAnalyzer
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_examples_limit")>]
        CategorizationExamplesLimit: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: Types.Integer
    }

    type Datafeeds = {
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: Types.Integer
    }

    type Defaults = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_detectors")>]
        AnomalyDetectors: MlInfo.AnomalyDetectors
        [<System.Text.Json.Serialization.JsonPropertyName("datafeeds")>]
        Datafeeds: MlInfo.Datafeeds
    }

    type Limits = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_single_ml_node_processors")>]
        MaxSingleMlNodeProcessors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_ml_processors")>]
        TotalMlProcessors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_model_memory_limit")>]
        MaxModelMemoryLimit: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("effective_max_model_memory_limit")>]
        EffectiveMaxModelMemoryLimit: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_ml_memory")>]
        TotalMlMemory: Types.ByteSize
    }

    type NativeCode = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
    }

