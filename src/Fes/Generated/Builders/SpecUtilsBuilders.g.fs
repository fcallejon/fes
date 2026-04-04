// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SpecUtilsBuilders =

    type CommonQueryParametersBuilder() =
        member _.Yield(_: unit) : Types.CommonQueryParameters =
            {
                ErrorTrace = None
                FilterPath = None
                Human = None
                Pretty = None
            }

        [<CustomOperation("errorTrace")>]
        member _.ErrorTrace(state: Types.CommonQueryParameters, value: bool) =
            { state with ErrorTrace = Some value }

        [<CustomOperation("filterPath")>]
        member _.FilterPath(state: Types.CommonQueryParameters, value: string list) =
            { state with FilterPath = Some value }

        [<CustomOperation("human")>]
        member _.Human(state: Types.CommonQueryParameters, value: bool) =
            { state with Human = Some value }

        [<CustomOperation("pretty")>]
        member _.Pretty(state: Types.CommonQueryParameters, value: bool) =
            { state with Pretty = Some value }

    let commonQueryParameters = CommonQueryParametersBuilder()

    type CommonCatQueryParametersBuilder() =
        member _.Yield(_: unit) : Types.CommonCatQueryParameters =
            {
                Format = None
                Help = None
                V = None
                Bytes = None
                Time = None
            }

        [<CustomOperation("format")>]
        member _.Format(state: Types.CommonCatQueryParameters, value: string) =
            { state with Format = Some value }

        [<CustomOperation("help")>]
        member _.Help(state: Types.CommonCatQueryParameters, value: bool) =
            { state with Help = Some value }

        [<CustomOperation("v")>]
        member _.V(state: Types.CommonCatQueryParameters, value: bool) =
            { state with V = Some value }

        [<CustomOperation("bytes")>]
        member _.Bytes(state: Types.CommonCatQueryParameters, value: Types.Bytes) =
            { state with Bytes = Some value }

        [<CustomOperation("time")>]
        member _.Time(state: Types.CommonCatQueryParameters, value: Types.TimeUnit) =
            { state with Time = Some value }

    let commonCatQueryParameters = CommonCatQueryParametersBuilder()

