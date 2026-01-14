// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SynonymsOperations =

    type SynonymsGetSynonymRequest = {
        Id: Id
        From: float option
        Size: float option
    } with
        static member ToRequest(request: SynonymsGetSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{request.Id}"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsGetSynonymRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsGetSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsGetSynonymRequest.ToRequest request

    type SynonymsGetSynonymRequestBuilder() =
        member _.Yield(_: unit) : SynonymsGetSynonymRequest =
            {
                SynonymsGetSynonymRequest.Id = Unchecked.defaultof<Id>
                SynonymsGetSynonymRequest.From = Option.None
                SynonymsGetSynonymRequest.Size = Option.None
            } : SynonymsGetSynonymRequest

        [<CustomOperation("id")>]
        member _.Id(state: SynonymsGetSynonymRequest, value: Id) =
            { state with SynonymsGetSynonymRequest.Id = value } : SynonymsGetSynonymRequest

        [<CustomOperation("from")>]
        member _.From(state: SynonymsGetSynonymRequest, value: float) =
            { state with SynonymsGetSynonymRequest.From = Option.Some value } : SynonymsGetSynonymRequest

        [<CustomOperation("size")>]
        member _.Size(state: SynonymsGetSynonymRequest, value: float) =
            { state with SynonymsGetSynonymRequest.Size = Option.Some value } : SynonymsGetSynonymRequest

    let synonymsGetSynonymRequest = SynonymsGetSynonymRequestBuilder()

    type SynonymsGetSynonymResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("synonyms_set")>]
        SynonymsSet: TypesSynonymRuleRead array
    }

    type SynonymsPutSynonymRequest = {
        Id: Id
        Refresh: bool option
        [<JsonPropertyName("synonyms_set")>]
        SynonymsSet: System.Text.Json.JsonElement
    } with
        static member ToRequest(request: SynonymsPutSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{request.Id}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsPutSynonymRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsPutSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsPutSynonymRequest.ToRequest request

    type SynonymsPutSynonymRequestBuilder() =
        member _.Yield(_: unit) : SynonymsPutSynonymRequest =
            {
                SynonymsPutSynonymRequest.Id = Unchecked.defaultof<Id>
                SynonymsPutSynonymRequest.Refresh = Option.None
                SynonymsPutSynonymRequest.SynonymsSet = Unchecked.defaultof<System.Text.Json.JsonElement>
            } : SynonymsPutSynonymRequest

        [<CustomOperation("id")>]
        member _.Id(state: SynonymsPutSynonymRequest, value: Id) =
            { state with SynonymsPutSynonymRequest.Id = value } : SynonymsPutSynonymRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SynonymsPutSynonymRequest, value: bool) =
            { state with SynonymsPutSynonymRequest.Refresh = Option.Some value } : SynonymsPutSynonymRequest

        [<CustomOperation("synonyms_set")>]
        member _.SynonymsSet(state: SynonymsPutSynonymRequest, value: System.Text.Json.JsonElement) =
            { state with SynonymsPutSynonymRequest.SynonymsSet = value } : SynonymsPutSynonymRequest

    let synonymsPutSynonymRequest = SynonymsPutSynonymRequestBuilder()

    type SynonymsPutSynonymResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
        [<JsonPropertyName("reload_analyzers_details")>]
        ReloadAnalyzersDetails: ReloadSearchAnalyzersReloadResult option
    }

    type SynonymsDeleteSynonymRequest = {
        Id: Id
    } with
        static member ToRequest(request: SynonymsDeleteSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsDeleteSynonymRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsDeleteSynonymRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsDeleteSynonymRequest.ToRequest request

    type SynonymsDeleteSynonymRequestBuilder() =
        member _.Yield(_: unit) : SynonymsDeleteSynonymRequest =
            {
                SynonymsDeleteSynonymRequest.Id = Unchecked.defaultof<Id>
            } : SynonymsDeleteSynonymRequest

        [<CustomOperation("id")>]
        member _.Id(state: SynonymsDeleteSynonymRequest, value: Id) =
            { state with SynonymsDeleteSynonymRequest.Id = value } : SynonymsDeleteSynonymRequest

    let synonymsDeleteSynonymRequest = SynonymsDeleteSynonymRequestBuilder()

    type SynonymsDeleteSynonymResponse = AcknowledgedResponseBase

    type SynonymsGetSynonymRuleRequest = {
        SetId: Id
        RuleId: Id
    } with
        static member ToRequest(request: SynonymsGetSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{request.SetId}/{request.RuleId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsGetSynonymRuleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsGetSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsGetSynonymRuleRequest.ToRequest request

    type SynonymsGetSynonymRuleRequestBuilder() =
        member _.Yield(_: unit) : SynonymsGetSynonymRuleRequest =
            {
                SynonymsGetSynonymRuleRequest.SetId = Unchecked.defaultof<Id>
                SynonymsGetSynonymRuleRequest.RuleId = Unchecked.defaultof<Id>
            } : SynonymsGetSynonymRuleRequest

        [<CustomOperation("set_id")>]
        member _.SetId(state: SynonymsGetSynonymRuleRequest, value: Id) =
            { state with SynonymsGetSynonymRuleRequest.SetId = value } : SynonymsGetSynonymRuleRequest

        [<CustomOperation("rule_id")>]
        member _.RuleId(state: SynonymsGetSynonymRuleRequest, value: Id) =
            { state with SynonymsGetSynonymRuleRequest.RuleId = value } : SynonymsGetSynonymRuleRequest

    let synonymsGetSynonymRuleRequest = SynonymsGetSynonymRuleRequestBuilder()

    type SynonymsGetSynonymRuleResponse = TypesSynonymRuleRead

    type SynonymsPutSynonymRuleRequest = {
        SetId: Id
        RuleId: Id
        Refresh: bool option
        [<JsonPropertyName("synonyms")>]
        Synonyms: TypesSynonymString
    } with
        static member ToRequest(request: SynonymsPutSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{request.SetId}/{request.RuleId}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody request
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsPutSynonymRuleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsPutSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsPutSynonymRuleRequest.ToRequest request

    type SynonymsPutSynonymRuleRequestBuilder() =
        member _.Yield(_: unit) : SynonymsPutSynonymRuleRequest =
            {
                SynonymsPutSynonymRuleRequest.SetId = Unchecked.defaultof<Id>
                SynonymsPutSynonymRuleRequest.RuleId = Unchecked.defaultof<Id>
                SynonymsPutSynonymRuleRequest.Refresh = Option.None
                SynonymsPutSynonymRuleRequest.Synonyms = Unchecked.defaultof<TypesSynonymString>
            } : SynonymsPutSynonymRuleRequest

        [<CustomOperation("set_id")>]
        member _.SetId(state: SynonymsPutSynonymRuleRequest, value: Id) =
            { state with SynonymsPutSynonymRuleRequest.SetId = value } : SynonymsPutSynonymRuleRequest

        [<CustomOperation("rule_id")>]
        member _.RuleId(state: SynonymsPutSynonymRuleRequest, value: Id) =
            { state with SynonymsPutSynonymRuleRequest.RuleId = value } : SynonymsPutSynonymRuleRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SynonymsPutSynonymRuleRequest, value: bool) =
            { state with SynonymsPutSynonymRuleRequest.Refresh = Option.Some value } : SynonymsPutSynonymRuleRequest

        [<CustomOperation("synonyms")>]
        member _.Synonyms(state: SynonymsPutSynonymRuleRequest, value: TypesSynonymString) =
            { state with SynonymsPutSynonymRuleRequest.Synonyms = value } : SynonymsPutSynonymRuleRequest

    let synonymsPutSynonymRuleRequest = SynonymsPutSynonymRuleRequestBuilder()

    type SynonymsPutSynonymRuleResponse = TypesSynonymsUpdateResult

    type SynonymsDeleteSynonymRuleRequest = {
        SetId: Id
        RuleId: Id
        Refresh: bool option
    } with
        static member ToRequest(request: SynonymsDeleteSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_synonyms/{request.SetId}/{request.RuleId}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsDeleteSynonymRuleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsDeleteSynonymRuleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsDeleteSynonymRuleRequest.ToRequest request

    type SynonymsDeleteSynonymRuleRequestBuilder() =
        member _.Yield(_: unit) : SynonymsDeleteSynonymRuleRequest =
            {
                SynonymsDeleteSynonymRuleRequest.SetId = Unchecked.defaultof<Id>
                SynonymsDeleteSynonymRuleRequest.RuleId = Unchecked.defaultof<Id>
                SynonymsDeleteSynonymRuleRequest.Refresh = Option.None
            } : SynonymsDeleteSynonymRuleRequest

        [<CustomOperation("set_id")>]
        member _.SetId(state: SynonymsDeleteSynonymRuleRequest, value: Id) =
            { state with SynonymsDeleteSynonymRuleRequest.SetId = value } : SynonymsDeleteSynonymRuleRequest

        [<CustomOperation("rule_id")>]
        member _.RuleId(state: SynonymsDeleteSynonymRuleRequest, value: Id) =
            { state with SynonymsDeleteSynonymRuleRequest.RuleId = value } : SynonymsDeleteSynonymRuleRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SynonymsDeleteSynonymRuleRequest, value: bool) =
            { state with SynonymsDeleteSynonymRuleRequest.Refresh = Option.Some value } : SynonymsDeleteSynonymRuleRequest

    let synonymsDeleteSynonymRuleRequest = SynonymsDeleteSynonymRuleRequestBuilder()

    type SynonymsDeleteSynonymRuleResponse = TypesSynonymsUpdateResult

    type SynonymsGetSynonymsSetsRequest = {
        From: float option
        Size: float option
    } with
        static member ToRequest(request: SynonymsGetSynonymsSetsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_synonyms"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", string v)
                        request.Size |> Option.map (fun v -> "size", string v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SynonymsGetSynonymsSetsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SynonymsGetSynonymsSetsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SynonymsGetSynonymsSetsRequest.ToRequest request

    type SynonymsGetSynonymsSetsRequestBuilder() =
        member _.Yield(_: unit) : SynonymsGetSynonymsSetsRequest =
            {
                SynonymsGetSynonymsSetsRequest.From = Option.None
                SynonymsGetSynonymsSetsRequest.Size = Option.None
            } : SynonymsGetSynonymsSetsRequest

        [<CustomOperation("from")>]
        member _.From(state: SynonymsGetSynonymsSetsRequest, value: float) =
            { state with SynonymsGetSynonymsSetsRequest.From = Option.Some value } : SynonymsGetSynonymsSetsRequest

        [<CustomOperation("size")>]
        member _.Size(state: SynonymsGetSynonymsSetsRequest, value: float) =
            { state with SynonymsGetSynonymsSetsRequest.Size = Option.Some value } : SynonymsGetSynonymsSetsRequest

    let synonymsGetSynonymsSetsRequest = SynonymsGetSynonymsSetsRequestBuilder()

    type SynonymsGetSynonymsSetsResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("results")>]
        Results: GetSynonymsSetsSynonymsSetItem array
    }

