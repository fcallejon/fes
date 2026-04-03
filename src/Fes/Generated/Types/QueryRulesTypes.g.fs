// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module QueryRulesTypes =

    [<RequireQualifiedAccess>]
    type QueryRuleType =
        | Pinned
        | Exclude

    [<RequireQualifiedAccess>]
    type QueryRuleCriteriaType =
        | Global
        | Exact
        | Fuzzy
        | Prefix
        | Suffix
        | Contains
        | Lt
        | Lte
        | Gt
        | Gte
        | Always

    type QueryRuleCriteria = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: QueryRulesTypes.QueryRuleCriteriaType
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: string option
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: System.Text.Json.JsonElement list option
    }

    type QueryRuleActions = {
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: Types.Id list option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: TypesQueryDsl.PinnedDoc list option
    }

    type QueryRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("rule_id")>]
        RuleId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: QueryRulesTypes.QueryRuleType
        [<System.Text.Json.Serialization.JsonPropertyName("criteria")>]
        Criteria: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: QueryRulesTypes.QueryRuleActions
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Types.Integer option
    }

    type QueryRuleset = {
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_id")>]
        RulesetId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: QueryRulesTypes.QueryRule list
    }

