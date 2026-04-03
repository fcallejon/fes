// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MlGetMemoryStatsBuilders =

    type JvmStatsBuilder() =
        member _.Yield(_: unit) : JvmStats =
            {
                HeapMax = None
                HeapMaxInBytes = Unchecked.defaultof<_>
                JavaInference = None
                JavaInferenceInBytes = Unchecked.defaultof<_>
                JavaInferenceMax = None
                JavaInferenceMaxInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: JvmStats, value: CoreTypes.ByteSize) =
            { state with HeapMax = Some value }

        [<CustomOperation("heapMaxInBytes")>]
        member _.HeapMaxInBytes(state: JvmStats, value: CoreTypes.Integer) =
            { state with HeapMaxInBytes = value }

        [<CustomOperation("javaInference")>]
        member _.JavaInference(state: JvmStats, value: CoreTypes.ByteSize) =
            { state with JavaInference = Some value }

        [<CustomOperation("javaInferenceInBytes")>]
        member _.JavaInferenceInBytes(state: JvmStats, value: CoreTypes.Integer) =
            { state with JavaInferenceInBytes = value }

        [<CustomOperation("javaInferenceMax")>]
        member _.JavaInferenceMax(state: JvmStats, value: CoreTypes.ByteSize) =
            { state with JavaInferenceMax = Some value }

        [<CustomOperation("javaInferenceMaxInBytes")>]
        member _.JavaInferenceMaxInBytes(state: JvmStats, value: CoreTypes.Integer) =
            { state with JavaInferenceMaxInBytes = value }

    let jvmStats = JvmStatsBuilder()

    type MemMlStatsBuilder() =
        member _.Yield(_: unit) : MemMlStats =
            {
                AnomalyDetectors = None
                AnomalyDetectorsInBytes = Unchecked.defaultof<_>
                DataFrameAnalytics = None
                DataFrameAnalyticsInBytes = Unchecked.defaultof<_>
                Max = None
                MaxInBytes = Unchecked.defaultof<_>
                NativeCodeOverhead = None
                NativeCodeOverheadInBytes = Unchecked.defaultof<_>
                NativeInference = None
                NativeInferenceInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("anomalyDetectors")>]
        member _.AnomalyDetectors(state: MemMlStats, value: CoreTypes.ByteSize) =
            { state with AnomalyDetectors = Some value }

        [<CustomOperation("anomalyDetectorsInBytes")>]
        member _.AnomalyDetectorsInBytes(state: MemMlStats, value: CoreTypes.Integer) =
            { state with AnomalyDetectorsInBytes = value }

        [<CustomOperation("dataFrameAnalytics")>]
        member _.DataFrameAnalytics(state: MemMlStats, value: CoreTypes.ByteSize) =
            { state with DataFrameAnalytics = Some value }

        [<CustomOperation("dataFrameAnalyticsInBytes")>]
        member _.DataFrameAnalyticsInBytes(state: MemMlStats, value: CoreTypes.Integer) =
            { state with DataFrameAnalyticsInBytes = value }

        [<CustomOperation("max")>]
        member _.Max(state: MemMlStats, value: CoreTypes.ByteSize) =
            { state with Max = Some value }

        [<CustomOperation("maxInBytes")>]
        member _.MaxInBytes(state: MemMlStats, value: CoreTypes.Integer) =
            { state with MaxInBytes = value }

        [<CustomOperation("nativeCodeOverhead")>]
        member _.NativeCodeOverhead(state: MemMlStats, value: CoreTypes.ByteSize) =
            { state with NativeCodeOverhead = Some value }

        [<CustomOperation("nativeCodeOverheadInBytes")>]
        member _.NativeCodeOverheadInBytes(state: MemMlStats, value: CoreTypes.Integer) =
            { state with NativeCodeOverheadInBytes = value }

        [<CustomOperation("nativeInference")>]
        member _.NativeInference(state: MemMlStats, value: CoreTypes.ByteSize) =
            { state with NativeInference = Some value }

        [<CustomOperation("nativeInferenceInBytes")>]
        member _.NativeInferenceInBytes(state: MemMlStats, value: CoreTypes.Integer) =
            { state with NativeInferenceInBytes = value }

    let memMlStats = MemMlStatsBuilder()

    type MemStatsBuilder() =
        member _.Yield(_: unit) : MemStats =
            {
                AdjustedTotal = None
                AdjustedTotalInBytes = Unchecked.defaultof<_>
                Total = None
                TotalInBytes = Unchecked.defaultof<_>
                Ml = Unchecked.defaultof<_>
            }

        [<CustomOperation("adjustedTotal")>]
        member _.AdjustedTotal(state: MemStats, value: CoreTypes.ByteSize) =
            { state with AdjustedTotal = Some value }

        [<CustomOperation("adjustedTotalInBytes")>]
        member _.AdjustedTotalInBytes(state: MemStats, value: CoreTypes.Integer) =
            { state with AdjustedTotalInBytes = value }

        [<CustomOperation("total")>]
        member _.Total(state: MemStats, value: CoreTypes.ByteSize) =
            { state with Total = Some value }

        [<CustomOperation("totalInBytes")>]
        member _.TotalInBytes(state: MemStats, value: CoreTypes.Integer) =
            { state with TotalInBytes = value }

        [<CustomOperation("ml")>]
        member _.Ml(state: MemStats, value: MlGetMemoryStats.MemMlStats) =
            { state with Ml = value }

    let memStats = MemStatsBuilder()

