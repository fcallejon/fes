// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module EnrichTypesBuilders =

    type PolicyBuilder() =
        member _.Yield(_: unit) : Policy =
            {
                EnrichFields = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                MatchField = Unchecked.defaultof<_>
                Query = None
                Name = None
                ElasticsearchVersion = None
            }

        [<CustomOperation("enrichFields")>]
        member _.EnrichFields(state: Policy, value: Types.Fields) =
            { state with EnrichFields = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Policy, value: Types.Indices) =
            { state with Indices = value }

        [<CustomOperation("matchField")>]
        member _.MatchField(state: Policy, value: Types.Field) =
            { state with MatchField = value }

        [<CustomOperation("query")>]
        member _.Query(state: Policy, value: TypesQueryDsl.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Policy, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("elasticsearchVersion")>]
        member _.ElasticsearchVersion(state: Policy, value: string) =
            { state with ElasticsearchVersion = Some value }

    let policy = PolicyBuilder()

