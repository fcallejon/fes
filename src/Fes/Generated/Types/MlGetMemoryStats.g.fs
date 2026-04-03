// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlGetMemoryStats =

    type JvmStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference")>]
        JavaInference: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference_in_bytes")>]
        JavaInferenceInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference_max")>]
        JavaInferenceMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("java_inference_max_in_bytes")>]
        JavaInferenceMaxInBytes: CoreTypes.Integer
    }

    type MemMlStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_detectors")>]
        AnomalyDetectors: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("anomaly_detectors_in_bytes")>]
        AnomalyDetectorsInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame_analytics")>]
        DataFrameAnalytics: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame_analytics_in_bytes")>]
        DataFrameAnalyticsInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_in_bytes")>]
        MaxInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("native_code_overhead")>]
        NativeCodeOverhead: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("native_code_overhead_in_bytes")>]
        NativeCodeOverheadInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("native_inference")>]
        NativeInference: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("native_inference_in_bytes")>]
        NativeInferenceInBytes: CoreTypes.Integer
    }

    type MemStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total")>]
        AdjustedTotal: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("adjusted_total_in_bytes")>]
        AdjustedTotalInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: MemMlStats
    }

    type Memory = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: JvmStats
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: MemStats
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("ephemeral_id")>]
        EphemeralId: CoreTypes.Id
    }

