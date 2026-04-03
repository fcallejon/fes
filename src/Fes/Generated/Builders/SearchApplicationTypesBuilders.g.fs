// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SearchApplicationTypesBuilders =

    type SearchApplicationParametersBuilder() =
        member _.Yield(_: unit) : SearchApplicationParameters =
            {
                Indices = Unchecked.defaultof<_>
                AnalyticsCollectionName = None
                Template = None
            }

        [<CustomOperation("indices")>]
        member _.Indices(state: SearchApplicationParameters, value: Types.IndexName list) =
            { state with Indices = value }

        [<CustomOperation("analyticsCollectionName")>]
        member _.AnalyticsCollectionName(state: SearchApplicationParameters, value: Types.Name) =
            { state with AnalyticsCollectionName = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: SearchApplicationParameters, value: SearchApplicationTypes.SearchApplicationTemplate) =
            { state with Template = Some value }

    let searchApplicationParameters = SearchApplicationParametersBuilder()

