// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlGetMemoryStats =

    type JvmStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference")>]
        JavaInference: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference_in_bytes")>]
        JavaInferenceInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference_max")>]
        JavaInferenceMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference_max_in_bytes")>]
        JavaInferenceMaxInBytes: Types.Integer
    }

    type MemMlStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_detectors")>]
        AnomalyDetectors: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_detectors_in_bytes")>]
        AnomalyDetectorsInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame_analytics")>]
        DataFrameAnalytics: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame_analytics_in_bytes")>]
        DataFrameAnalyticsInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_in_bytes")>]
        MaxInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("native_code_overhead")>]
        NativeCodeOverhead: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("native_code_overhead_in_bytes")>]
        NativeCodeOverheadInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("native_inference")>]
        NativeInference: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("native_inference_in_bytes")>]
        NativeInferenceInBytes: Types.Integer
    }

    type MemStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total")>]
        AdjustedTotal: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total_in_bytes")>]
        AdjustedTotalInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: MlGetMemoryStats.MemMlStats
    }

    type Memory = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: MlGetMemoryStats.JvmStats
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: MlGetMemoryStats.MemStats
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: Types.Id
    }

