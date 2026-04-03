// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module SynonymsOperations =

    type SynonymsDeleteSynonymRequest = {
        Id: Types.Id
    }

        with
        static member ToRequest(req: SynonymsDeleteSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsDeleteSynonymResponse = Types.AcknowledgedResponseBase

    type SynonymsDeleteSynonymRequestBuilder() =
        member _.Yield(_: unit) : SynonymsDeleteSynonymRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: SynonymsDeleteSynonymRequest, value: Types.Id) =
            { state with Id = value }

    let synonymsDeleteSynonymRequest = SynonymsDeleteSynonymRequestBuilder()

    type SynonymsDeleteSynonymRuleRequest = {
        SetId: Types.Id
        RuleId: Types.Id
        Refresh: bool option
    }

        with
        static member ToRequest(req: SynonymsDeleteSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{req.SetId}/{req.RuleId}"
                let queryParams =
                    [
                        req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsDeleteSynonymRuleResponse = SynonymsTypes.SynonymsUpdateResult

    type SynonymsDeleteSynonymRuleRequestBuilder() =
        member _.Yield(_: unit) : SynonymsDeleteSynonymRuleRequest =
            {
                SetId = Unchecked.defaultof<_>
                RuleId = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("setId")>]
        member _.SetId(state: SynonymsDeleteSynonymRuleRequest, value: Types.Id) =
            { state with SetId = value }

        [<CustomOperation("ruleId")>]
        member _.RuleId(state: SynonymsDeleteSynonymRuleRequest, value: Types.Id) =
            { state with RuleId = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SynonymsDeleteSynonymRuleRequest, value: bool) =
            { state with Refresh = Some value }

    let synonymsDeleteSynonymRuleRequest = SynonymsDeleteSynonymRuleRequestBuilder()

    module DeleteSynonymRule =
        let withRefresh (value: bool) (req: SynonymsDeleteSynonymRuleRequest) =
            { req with Refresh = Some value }

    type SynonymsGetSynonymRequest = {
        Id: Types.Id
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToRequest(req: SynonymsGetSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{req.Id}"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsGetSynonymResponse = System.Text.Json.JsonElement

    type SynonymsGetSynonymRequestBuilder() =
        member _.Yield(_: unit) : SynonymsGetSynonymRequest =
            {
                Id = Unchecked.defaultof<_>
                From = None
                Size = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SynonymsGetSynonymRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("from")>]
        member _.From(state: SynonymsGetSynonymRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SynonymsGetSynonymRequest, value: Types.Integer) =
            { state with Size = Some value }

    let synonymsGetSynonymRequest = SynonymsGetSynonymRequestBuilder()

    module GetSynonym =
        let withFrom (value: Types.Integer) (req: SynonymsGetSynonymRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: SynonymsGetSynonymRequest) =
            { req with Size = Some value }

    type SynonymsGetSynonymRuleRequest = {
        SetId: Types.Id
        RuleId: Types.Id
    }

        with
        static member ToRequest(req: SynonymsGetSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{req.SetId}/{req.RuleId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsGetSynonymRuleResponse = SynonymsTypes.SynonymRuleRead

    type SynonymsGetSynonymRuleRequestBuilder() =
        member _.Yield(_: unit) : SynonymsGetSynonymRuleRequest =
            {
                SetId = Unchecked.defaultof<_>
                RuleId = Unchecked.defaultof<_>
            }

        [<CustomOperation("setId")>]
        member _.SetId(state: SynonymsGetSynonymRuleRequest, value: Types.Id) =
            { state with SetId = value }

        [<CustomOperation("ruleId")>]
        member _.RuleId(state: SynonymsGetSynonymRuleRequest, value: Types.Id) =
            { state with RuleId = value }

    let synonymsGetSynonymRuleRequest = SynonymsGetSynonymRuleRequestBuilder()

    type SynonymsGetSynonymsSetsRequest = {
        From: Types.Integer option
        Size: Types.Integer option
    }

        with
        static member ToRequest(req: SynonymsGetSynonymsSetsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsGetSynonymsSetsResponse = System.Text.Json.JsonElement

    type SynonymsGetSynonymsSetsRequestBuilder() =
        member _.Yield(_: unit) : SynonymsGetSynonymsSetsRequest =
            {
                From = None
                Size = None
            }

        [<CustomOperation("from")>]
        member _.From(state: SynonymsGetSynonymsSetsRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SynonymsGetSynonymsSetsRequest, value: Types.Integer) =
            { state with Size = Some value }

    let synonymsGetSynonymsSetsRequest = SynonymsGetSynonymsSetsRequestBuilder()

    module GetSynonymsSets =
        let withFrom (value: Types.Integer) (req: SynonymsGetSynonymsSetsRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: SynonymsGetSynonymsSetsRequest) =
            { req with Size = Some value }

    type SynonymsPutSynonymRequest = {
        Id: Types.Id
        Refresh: bool option
        SynonymsSet: System.Text.Json.JsonElement
    }

        with
        static member ToRequest(req: SynonymsPutSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{req.Id}"
                let queryParams =
                    [
                        req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsPutSynonymResponse = System.Text.Json.JsonElement

    type SynonymsPutSynonymRequestBuilder() =
        member _.Yield(_: unit) : SynonymsPutSynonymRequest =
            {
                Id = Unchecked.defaultof<_>
                Refresh = None
                SynonymsSet = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: SynonymsPutSynonymRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SynonymsPutSynonymRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("synonymsSet")>]
        member _.SynonymsSet(state: SynonymsPutSynonymRequest, value: System.Text.Json.JsonElement) =
            { state with SynonymsSet = value }

    let synonymsPutSynonymRequest = SynonymsPutSynonymRequestBuilder()

    module PutSynonym =
        let withRefresh (value: bool) (req: SynonymsPutSynonymRequest) =
            { req with Refresh = Some value }
        let withSynonymsSet (value: System.Text.Json.JsonElement) (req: SynonymsPutSynonymRequest) =
            { req with SynonymsSet = value }

    type SynonymsPutSynonymRuleRequest = {
        SetId: Types.Id
        RuleId: Types.Id
        Refresh: bool option
        Synonyms: SynonymsTypes.SynonymString
    }

        with
        static member ToRequest(req: SynonymsPutSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{req.SetId}/{req.RuleId}"
                let queryParams =
                    [
                        req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SynonymsPutSynonymRuleResponse = SynonymsTypes.SynonymsUpdateResult

    type SynonymsPutSynonymRuleRequestBuilder() =
        member _.Yield(_: unit) : SynonymsPutSynonymRuleRequest =
            {
                SetId = Unchecked.defaultof<_>
                RuleId = Unchecked.defaultof<_>
                Refresh = None
                Synonyms = Unchecked.defaultof<_>
            }

        [<CustomOperation("setId")>]
        member _.SetId(state: SynonymsPutSynonymRuleRequest, value: Types.Id) =
            { state with SetId = value }

        [<CustomOperation("ruleId")>]
        member _.RuleId(state: SynonymsPutSynonymRuleRequest, value: Types.Id) =
            { state with RuleId = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SynonymsPutSynonymRuleRequest, value: bool) =
            { state with Refresh = Some value }

        [<CustomOperation("synonyms")>]
        member _.Synonyms(state: SynonymsPutSynonymRuleRequest, value: SynonymsTypes.SynonymString) =
            { state with Synonyms = value }

    let synonymsPutSynonymRuleRequest = SynonymsPutSynonymRuleRequestBuilder()

    module PutSynonymRule =
        let withRefresh (value: bool) (req: SynonymsPutSynonymRuleRequest) =
            { req with Refresh = Some value }
        let withSynonyms (value: SynonymsTypes.SynonymString) (req: SynonymsPutSynonymRuleRequest) =
            { req with Synonyms = value }

