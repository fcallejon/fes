// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ProjectTypes =

    type RoutingExpression = string

    type ProjectRoutingExpression = {
        [<System.Text.Json.Serialization.JsonPropertyName("expression")>]
        Expression: ProjectTypes.RoutingExpression
    }

    type NamedProjectRoutingExpressions = Map<string, ProjectTypes.ProjectRoutingExpression>

