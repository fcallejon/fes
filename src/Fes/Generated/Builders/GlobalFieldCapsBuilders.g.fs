// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalFieldCapsBuilders =

    type FieldCapabilityBuilder() =
        member _.Yield(_: unit) : Types.FieldCapability =
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
        member _.Aggregatable(state: Types.FieldCapability, value: bool) =
            { state with Aggregatable = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.FieldCapability, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.FieldCapability, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("nonAggregatableIndices")>]
        member _.NonAggregatableIndices(state: Types.FieldCapability, value: Types.Indices) =
            { state with NonAggregatableIndices = Some value }

        [<CustomOperation("nonSearchableIndices")>]
        member _.NonSearchableIndices(state: Types.FieldCapability, value: Types.Indices) =
            { state with NonSearchableIndices = Some value }

        [<CustomOperation("searchable")>]
        member _.Searchable(state: Types.FieldCapability, value: bool) =
            { state with Searchable = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.FieldCapability, value: string) =
            { state with Type = value }

        [<CustomOperation("metadataField")>]
        member _.MetadataField(state: Types.FieldCapability, value: bool) =
            { state with MetadataField = Some value }

        [<CustomOperation("timeSeriesDimension")>]
        member _.TimeSeriesDimension(state: Types.FieldCapability, value: bool) =
            { state with TimeSeriesDimension = Some value }

        [<CustomOperation("timeSeriesMetric")>]
        member _.TimeSeriesMetric(state: Types.FieldCapability, value: Types.TimeSeriesMetricType) =
            { state with TimeSeriesMetric = Some value }

        [<CustomOperation("nonDimensionIndices")>]
        member _.NonDimensionIndices(state: Types.FieldCapability, value: Types.IndexName list) =
            { state with NonDimensionIndices = Some value }

        [<CustomOperation("metricConflictsIndices")>]
        member _.MetricConflictsIndices(state: Types.FieldCapability, value: Types.IndexName list) =
            { state with MetricConflictsIndices = Some value }

    let fieldCapability = FieldCapabilityBuilder()

