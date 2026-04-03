// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module XpackInfoBuilders =

    type FeatureBuilder() =
        member _.Yield(_: unit) : Feature =
            {
                Available = Unchecked.defaultof<_>
                Description = None
                Enabled = Unchecked.defaultof<_>
                NativeCodeInfo = None
            }

        [<CustomOperation("available")>]
        member _.Available(state: Feature, value: bool) =
            { state with Available = value }

        [<CustomOperation("description")>]
        member _.Description(state: Feature, value: string) =
            { state with Description = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Feature, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("nativeCodeInfo")>]
        member _.NativeCodeInfo(state: Feature, value: XpackInfo.NativeCodeInformation) =
            { state with NativeCodeInfo = Some value }

    let feature = FeatureBuilder()

