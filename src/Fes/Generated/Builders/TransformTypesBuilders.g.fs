// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TransformTypesBuilders =

    type DestinationBuilder() =
        member _.Yield(_: unit) : Destination =
            {
                Index = None
                Pipeline = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Destination, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Destination, value: string) =
            { state with Pipeline = Some value }

    let destination = DestinationBuilder()

    type PivotBuilder() =
        member _.Yield(_: unit) : Pivot =
            {
                Aggregations = None
                GroupBy = None
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: Pivot, value: Map<string, TypesAggregations.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("groupBy")>]
        member _.GroupBy(state: Pivot, value: Map<string, TransformTypes.PivotGroupByContainer>) =
            { state with GroupBy = Some value }

    let pivot = PivotBuilder()

    module PivotGroupBy =

        let dateHistogram (value: TypesAggregations.DateHistogramAggregation) =
            PivotGroupByContainer.DateHistogram value

        let geotileGrid (value: TypesAggregations.GeoTileGridAggregation) =
            PivotGroupByContainer.GeotileGrid value

        let histogram (value: TypesAggregations.HistogramAggregation) =
            PivotGroupByContainer.Histogram value

        let terms (value: TypesAggregations.TermsAggregation) =
            PivotGroupByContainer.Terms value

    module RetentionPolicy =

        let time (value: TransformTypes.RetentionPolicy) =
            RetentionPolicyContainer.Time value

    type SettingsBuilder() =
        member _.Yield(_: unit) : Settings =
            {
                AlignCheckpoints = None
                DatesAsEpochMillis = None
                DeduceMappings = None
                DocsPerSecond = None
                MaxPageSearchSize = None
                UsePointInTime = None
                NumFailureRetries = None
                Unattended = None
            }

        [<CustomOperation("alignCheckpoints")>]
        member _.AlignCheckpoints(state: Settings, value: bool) =
            { state with AlignCheckpoints = Some value }

        [<CustomOperation("datesAsEpochMillis")>]
        member _.DatesAsEpochMillis(state: Settings, value: bool) =
            { state with DatesAsEpochMillis = Some value }

        [<CustomOperation("deduceMappings")>]
        member _.DeduceMappings(state: Settings, value: bool) =
            { state with DeduceMappings = Some value }

        [<CustomOperation("docsPerSecond")>]
        member _.DocsPerSecond(state: Settings, value: Types.Float) =
            { state with DocsPerSecond = Some value }

        [<CustomOperation("maxPageSearchSize")>]
        member _.MaxPageSearchSize(state: Settings, value: Types.Integer) =
            { state with MaxPageSearchSize = Some value }

        [<CustomOperation("usePointInTime")>]
        member _.UsePointInTime(state: Settings, value: bool) =
            { state with UsePointInTime = Some value }

        [<CustomOperation("numFailureRetries")>]
        member _.NumFailureRetries(state: Settings, value: Types.Integer) =
            { state with NumFailureRetries = Some value }

        [<CustomOperation("unattended")>]
        member _.Unattended(state: Settings, value: bool) =
            { state with Unattended = Some value }

    let settings = SettingsBuilder()

    type SourceBuilder() =
        member _.Yield(_: unit) : Source =
            {
                Index = Unchecked.defaultof<_>
                Query = None
                RuntimeMappings = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Source, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: Source, value: TypesQueryDsl.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Source, value: TypesMapping.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: Source, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let source = SourceBuilder()

    module Sync =

        let time (value: TransformTypes.TimeSync) =
            SyncContainer.Time value

