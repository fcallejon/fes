// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module QueryRulesTest =

    type QueryRulesetMatchedRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("ruleset_id")>]
        RulesetId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("rule_id")>]
        RuleId: Types.Id
    }

