// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TransformTypesBuilders =

    type TransformTypesDestinationBuilder() =
        member _.Yield(_: unit) : Types.TransformTypesDestination =
            {
                Index = None
                Pipeline = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.TransformTypesDestination, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Types.TransformTypesDestination, value: string) =
            { state with Pipeline = Some value }

    let transformTypesDestination = TransformTypesDestinationBuilder()

    type PivotBuilder() =
        member _.Yield(_: unit) : Types.Pivot =
            {
                Aggregations = None
                GroupBy = None
            }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: Types.Pivot, value: Map<string, Types.AggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("groupBy")>]
        member _.GroupBy(state: Types.Pivot, value: Map<string, Types.PivotGroupByContainer>) =
            { state with GroupBy = Some value }

    let pivot = PivotBuilder()

    module PivotGroupBy =

        let dateHistogram (value: Types.DateHistogramAggregation) =
            Types.PivotGroupByContainer.DateHistogram value

        let geotileGrid (value: Types.GeoTileGridAggregation) =
            Types.PivotGroupByContainer.GeotileGrid value

        let histogram (value: Types.HistogramAggregation) =
            Types.PivotGroupByContainer.Histogram value

        let terms (value: Types.TermsAggregation) =
            Types.PivotGroupByContainer.Terms value

    module RetentionPolicy =

        let time (value: Types.RetentionPolicy) =
            Types.RetentionPolicyContainer.Time value

    type SettingsBuilder() =
        member _.Yield(_: unit) : Types.Settings =
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
        member _.AlignCheckpoints(state: Types.Settings, value: bool) =
            { state with AlignCheckpoints = Some value }

        [<CustomOperation("datesAsEpochMillis")>]
        member _.DatesAsEpochMillis(state: Types.Settings, value: bool) =
            { state with DatesAsEpochMillis = Some value }

        [<CustomOperation("deduceMappings")>]
        member _.DeduceMappings(state: Types.Settings, value: bool) =
            { state with DeduceMappings = Some value }

        [<CustomOperation("docsPerSecond")>]
        member _.DocsPerSecond(state: Types.Settings, value: Types.Float) =
            { state with DocsPerSecond = Some value }

        [<CustomOperation("maxPageSearchSize")>]
        member _.MaxPageSearchSize(state: Types.Settings, value: Types.Integer) =
            { state with MaxPageSearchSize = Some value }

        [<CustomOperation("usePointInTime")>]
        member _.UsePointInTime(state: Types.Settings, value: bool) =
            { state with UsePointInTime = Some value }

        [<CustomOperation("numFailureRetries")>]
        member _.NumFailureRetries(state: Types.Settings, value: Types.Integer) =
            { state with NumFailureRetries = Some value }

        [<CustomOperation("unattended")>]
        member _.Unattended(state: Types.Settings, value: bool) =
            { state with Unattended = Some value }

    let settings = SettingsBuilder()

    type TransformTypesSourceBuilder() =
        member _.Yield(_: unit) : Types.TransformTypesSource =
            {
                Index = Unchecked.defaultof<_>
                Query = None
                RuntimeMappings = None
                ProjectRouting = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.TransformTypesSource, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.TransformTypesSource, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Types.TransformTypesSource, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: Types.TransformTypesSource, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

    let transformTypesSource = TransformTypesSourceBuilder()

    module Sync =

        let time (value: Types.TimeSync) =
            Types.SyncContainer.Time value

