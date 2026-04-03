// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module EnrichTypesBuilders =

    type EnrichTypesPolicyBuilder() =
        member _.Yield(_: unit) : Types.EnrichTypesPolicy =
            {
                EnrichFields = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                MatchField = Unchecked.defaultof<_>
                Query = None
                Name = None
                ElasticsearchVersion = None
            }

        [<CustomOperation("enrichFields")>]
        member _.EnrichFields(state: Types.EnrichTypesPolicy, value: Types.Fields) =
            { state with EnrichFields = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.EnrichTypesPolicy, value: Types.Indices) =
            { state with Indices = value }

        [<CustomOperation("matchField")>]
        member _.MatchField(state: Types.EnrichTypesPolicy, value: Types.Field) =
            { state with MatchField = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.EnrichTypesPolicy, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.EnrichTypesPolicy, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("elasticsearchVersion")>]
        member _.ElasticsearchVersion(state: Types.EnrichTypesPolicy, value: string) =
            { state with ElasticsearchVersion = Some value }

    let enrichTypesPolicy = EnrichTypesPolicyBuilder()

