// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module EnrichExecutePolicy =

    [<RequireQualifiedAccess>]
    type EnrichPolicyPhase =
        | SCHEDULED
        | RUNNING
        | COMPLETE
        | FAILED
        | CANCELLED

    type ExecuteEnrichPolicyStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("phase")>]
        Phase: EnrichExecutePolicy.EnrichPolicyPhase
        [<System.Text.Json.Serialization.JsonPropertyName("step")>]
        Step: string option
    }

