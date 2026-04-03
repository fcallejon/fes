// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module QueryRulesTypesBuilders =

    type QueryRuleActionsBuilder() =
        member _.Yield(_: unit) : QueryRuleActions =
            {
                Ids = None
                Docs = None
            }

        [<CustomOperation("ids")>]
        member _.Ids(state: QueryRuleActions, value: CoreTypes.Id list) =
            { state with Ids = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: QueryRuleActions, value: CoreTypes.PinnedDoc list) =
            { state with Docs = Some value }

    let queryRuleActions = QueryRuleActionsBuilder()

    type QueryRuleCriteriaBuilder() =
        member _.Yield(_: unit) : QueryRuleCriteria =
            {
                Type = Unchecked.defaultof<_>
                Metadata = None
                Values = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: QueryRuleCriteria, value: QueryRulesTypes.QueryRuleCriteriaType) =
            { state with Type = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: QueryRuleCriteria, value: string) =
            { state with Metadata = Some value }

        [<CustomOperation("values")>]
        member _.Values(state: QueryRuleCriteria, value: System.Text.Json.JsonElement list) =
            { state with Values = Some value }

    let queryRuleCriteria = QueryRuleCriteriaBuilder()

