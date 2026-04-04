// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SearchApplicationTypesBuilders =

    type SearchApplicationBuilder() =
        member _.Yield(_: unit) : Types.SearchApplication =
            {
                Name = Unchecked.defaultof<_>
                UpdatedAtMillis = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                AnalyticsCollectionName = None
                Template = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.SearchApplication, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("updatedAtMillis")>]
        member _.UpdatedAtMillis(state: Types.SearchApplication, value: Types.EpochTime<Types.UnitMillis>) =
            { state with UpdatedAtMillis = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.SearchApplication, value: Types.IndexName list) =
            { state with Indices = value }

        [<CustomOperation("analyticsCollectionName")>]
        member _.AnalyticsCollectionName(state: Types.SearchApplication, value: Types.Name) =
            { state with AnalyticsCollectionName = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: Types.SearchApplication, value: Types.SearchApplicationTemplate) =
            { state with Template = Some value }

    let searchApplication = SearchApplicationBuilder()

    type SearchApplicationParametersBuilder() =
        member _.Yield(_: unit) : Types.SearchApplicationParameters =
            {
                Indices = Unchecked.defaultof<_>
                AnalyticsCollectionName = None
                Template = None
            }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.SearchApplicationParameters, value: Types.IndexName list) =
            { state with Indices = value }

        [<CustomOperation("analyticsCollectionName")>]
        member _.AnalyticsCollectionName(state: Types.SearchApplicationParameters, value: Types.Name) =
            { state with AnalyticsCollectionName = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: Types.SearchApplicationParameters, value: Types.SearchApplicationTemplate) =
            { state with Template = Some value }

    let searchApplicationParameters = SearchApplicationParametersBuilder()

