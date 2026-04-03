// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesValidateQueryBuilders =

    type IndicesValidationExplanationBuilder() =
        member _.Yield(_: unit) : IndicesValidationExplanation =
            {
                Error = None
                Explanation = None
                Index = None
                Shard = None
                Valid = Unchecked.defaultof<_>
            }

        [<CustomOperation("error")>]
        member _.Error(state: IndicesValidationExplanation, value: string) =
            { state with Error = Some value }

        [<CustomOperation("explanation")>]
        member _.Explanation(state: IndicesValidationExplanation, value: string) =
            { state with Explanation = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: IndicesValidationExplanation, value: CoreTypes.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: IndicesValidationExplanation, value: CoreTypes.Integer) =
            { state with Shard = Some value }

        [<CustomOperation("valid")>]
        member _.Valid(state: IndicesValidationExplanation, value: bool) =
            { state with Valid = value }

    let indicesValidationExplanation = IndicesValidationExplanationBuilder()

