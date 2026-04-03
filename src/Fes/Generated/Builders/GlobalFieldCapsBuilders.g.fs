// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalFieldCapsBuilders =

    type FieldCapabilityBuilder() =
        member _.Yield(_: unit) : FieldCapability =
            {
                Aggregatable = Unchecked.defaultof<_>
                Indices = None
                Meta = None
                NonAggregatableIndices = None
                NonSearchableIndices = None
                Searchable = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                MetadataField = None
                TimeSeriesDimension = None
                TimeSeriesMetric = None
                NonDimensionIndices = None
                MetricConflictsIndices = None
            }

        [<CustomOperation("aggregatable")>]
        member _.Aggregatable(state: FieldCapability, value: bool) =
            { state with Aggregatable = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: FieldCapability, value: CoreTypes.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: FieldCapability, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("nonAggregatableIndices")>]
        member _.NonAggregatableIndices(state: FieldCapability, value: CoreTypes.Indices) =
            { state with NonAggregatableIndices = Some value }

        [<CustomOperation("nonSearchableIndices")>]
        member _.NonSearchableIndices(state: FieldCapability, value: CoreTypes.Indices) =
            { state with NonSearchableIndices = Some value }

        [<CustomOperation("searchable")>]
        member _.Searchable(state: FieldCapability, value: bool) =
            { state with Searchable = value }

        [<CustomOperation("type'")>]
        member _.Type(state: FieldCapability, value: string) =
            { state with Type = value }

        [<CustomOperation("metadataField")>]
        member _.MetadataField(state: FieldCapability, value: bool) =
            { state with MetadataField = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: FieldCapability, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: FieldCapability, value: CoreTypes.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("nonDimensionIndices")>]
        member _.NonDimensionIndices(state: FieldCapability, value: CoreTypes.IndexName list) =
            { state with NonDimensionIndices = Some value }

        [<CustomOperation("metricConflictsIndices")>]
        member _.MetricConflictsIndices(state: FieldCapability, value: CoreTypes.IndexName list) =
            { state with MetricConflictsIndices = Some value }

    let fieldCapability = FieldCapabilityBuilder()

