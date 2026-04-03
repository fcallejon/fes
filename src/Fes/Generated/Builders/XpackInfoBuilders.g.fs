// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module XpackInfoBuilders =

    type XpackInfoFeatureBuilder() =
        member _.Yield(_: unit) : Types.XpackInfoFeature =
            {
                Available = Unchecked.defaultof<_>
                Description = None
                Enabled = Unchecked.defaultof<_>
                NativeCodeInfo = None
            }

        [<CustomOperation("available")>]
        member _.Available(state: Types.XpackInfoFeature, value: bool) =
            { state with Available = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.XpackInfoFeature, value: string) =
            { state with Description = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.XpackInfoFeature, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("nativeCodeInfo")>]
        member _.NativeCodeInfo(state: Types.XpackInfoFeature, value: Types.NativeCodeInformation) =
            { state with NativeCodeInfo = Some value }

    let xpackInfoFeature = XpackInfoFeatureBuilder()

