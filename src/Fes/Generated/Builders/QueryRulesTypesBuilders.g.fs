// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module QueryRulesTypesBuilders =

    type QueryRuleActionsBuilder() =
        member _.Yield(_: unit) : Types.QueryRuleActions =
            {
                Ids = None
                Docs = None
            }

        [<CustomOperation("ids")>]
        member _.Ids(state: Types.QueryRuleActions, value: Types.Id list) =
            { state with Ids = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: Types.QueryRuleActions, value: Types.PinnedDoc list) =
            { state with Docs = Some value }

    let queryRuleActions = QueryRuleActionsBuilder()

    type QueryRuleCriteriaBuilder() =
        member _.Yield(_: unit) : Types.QueryRuleCriteria =
            {
                Type = Unchecked.defaultof<_>
                Metadata = None
                Values = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.QueryRuleCriteria, value: Types.QueryRuleCriteriaType) =
            { state with Type = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.QueryRuleCriteria, value: string) =
            { state with Metadata = Some value }

        [<CustomOperation("values")>]
        member _.Values(state: Types.QueryRuleCriteria, value: System.Text.Json.JsonElement list) =
            { state with Values = Some value }

    let queryRuleCriteria = QueryRuleCriteriaBuilder()

