// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module QueryRulesListRulesets =

    type QueryRulesetListItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_id")>]
        RulesetId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("rule_total_count")>]
        RuleTotalCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("rule_criteria_types_counts")>]
        RuleCriteriaTypesCounts: Map<string, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("rule_type_counts")>]
        RuleTypeCounts: Map<string, Types.Integer>
    }

