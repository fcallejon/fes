// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlInfo =

    type AnomalyDetectors = {
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_analyzer")>]
        CategorizationAnalyzer: MlTypes.CategorizationAnalyzer
        [<System.Text.Json.Serialization.JsonPropertyName("categorization_examples_limit")>]
        CategorizationExamplesLimit: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string
        [<System.Text.Json.Serialization.JsonPropertyName("model_snapshot_retention_days")>]
        ModelSnapshotRetentionDays: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("daily_model_snapshot_retention_after_days")>]
        DailyModelSnapshotRetentionAfterDays: CoreTypes.Integer
    }

    type Datafeeds = {
        [<System.Text.Json.Serialization.JsonPropertyName("scroll_size")>]
        ScrollSize: CoreTypes.Integer
    }

    type Defaults = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_detectors")>]
        AnomalyDetectors: AnomalyDetectors
        [<System.Text.Json.Serialization.JsonPropertyName("datafeeds")>]
        Datafeeds: Datafeeds
    }

    type Limits = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_single_ml_node_processors")>]
        MaxSingleMlNodeProcessors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_ml_processors")>]
        TotalMlProcessors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_model_memory_limit")>]
        MaxModelMemoryLimit: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("effective_max_model_memory_limit")>]
        EffectiveMaxModelMemoryLimit: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_ml_memory")>]
        TotalMlMemory: CoreTypes.ByteSize
    }

    type NativeCode = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
    }

