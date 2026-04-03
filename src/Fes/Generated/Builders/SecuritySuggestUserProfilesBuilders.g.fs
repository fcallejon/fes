// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecuritySuggestUserProfilesBuilders =

    type HintBuilder() =
        member _.Yield(_: unit) : Types.Hint =
            {
                Uids = None
                Labels = None
            }

        [<CustomOperation("uids")>]
        member _.Uids(state: Types.Hint, value: Types.UserProfileId list) =
            { state with Uids = Some value }

        [<CustomOperation("labels")>]
        member _.Labels(state: Types.Hint, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Labels = Some value }

    let hint = HintBuilder()

