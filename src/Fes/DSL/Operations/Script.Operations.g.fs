// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module ScriptOperations =

    type GetScriptRequest = {
        Id: Id
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: GetScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/{request.Id}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    module GetScriptRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: GetScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            GetScriptRequest.ToRequest request

    type GetScriptRequestBuilder() =
        member _.Yield(_: unit) : GetScriptRequest =
            {
                GetScriptRequest.Id = Unchecked.defaultof<Id>
                GetScriptRequest.MasterTimeout = Option.None
            } : GetScriptRequest

        [<CustomOperation("id")>]
        member _.Id(state: GetScriptRequest, value: Id) =
            { state with GetScriptRequest.Id = value } : GetScriptRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: GetScriptRequest, value: Duration) =
            { state with GetScriptRequest.MasterTimeout = Option.Some value } : GetScriptRequest

    let getScriptRequest = GetScriptRequestBuilder()

    type GetScriptResponse = {
        [<JsonPropertyName("_id")>]
        Id: Id
        [<JsonPropertyName("found")>]
        Found: bool
        [<JsonPropertyName("script")>]
        Script: StoredScript option
    }

    type DeleteScriptRequest = {
        Id: Id
        MasterTimeout: Duration option
        Timeout: Duration option
    } with
        static member ToRequest(request: DeleteScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/{request.Id}"
                let queryParams =
                    [
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    module DeleteScriptRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: DeleteScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            DeleteScriptRequest.ToRequest request

    type DeleteScriptRequestBuilder() =
        member _.Yield(_: unit) : DeleteScriptRequest =
            {
                DeleteScriptRequest.Id = Unchecked.defaultof<Id>
                DeleteScriptRequest.MasterTimeout = Option.None
                DeleteScriptRequest.Timeout = Option.None
            } : DeleteScriptRequest

        [<CustomOperation("id")>]
        member _.Id(state: DeleteScriptRequest, value: Id) =
            { state with DeleteScriptRequest.Id = value } : DeleteScriptRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: DeleteScriptRequest, value: Duration) =
            { state with DeleteScriptRequest.MasterTimeout = Option.Some value } : DeleteScriptRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: DeleteScriptRequest, value: Duration) =
            { state with DeleteScriptRequest.Timeout = Option.Some value } : DeleteScriptRequest

    let deleteScriptRequest = DeleteScriptRequestBuilder()

    type DeleteScriptResponse = AcknowledgedResponseBase

    type GetScriptContextRequest = unit

    let getScriptContextRequest = ()

    type GetScriptContextResponse = {
        [<JsonPropertyName("contexts")>]
        Contexts: GetScriptContextContext array
    }

    type GetScriptLanguagesRequest = unit

    let getScriptLanguagesRequest = ()

    type GetScriptLanguagesResponse = {
        [<JsonPropertyName("language_contexts")>]
        LanguageContexts: GetScriptLanguagesLanguageContext array
        [<JsonPropertyName("types_allowed")>]
        TypesAllowed: string array
    }

    type PutScriptRequest = {
        Id: Id
        Context: Name
        Context2: Name option
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("script")>]
        Script: StoredScript
    } with
        static member ToRequest(request: PutScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_scripts/{request.Id}/{request.Context}"
                let queryParams =
                    [
                        request.Context2 |> Option.map (fun v -> "context", Fes.Http.toQueryValue v)
                        request.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        request.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``script`` = request.Script |}
                |> Result.Ok
            with ex -> Result.Error ex

    module PutScriptRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: PutScriptRequest) : Result<Fes.Http.RequestMsg, exn> =
            PutScriptRequest.ToRequest request

    type PutScriptRequestBuilder() =
        member _.Yield(_: unit) : PutScriptRequest =
            {
                PutScriptRequest.Id = Unchecked.defaultof<Id>
                PutScriptRequest.Context = Unchecked.defaultof<Name>
                PutScriptRequest.Context2 = Option.None
                PutScriptRequest.MasterTimeout = Option.None
                PutScriptRequest.Timeout = Option.None
                PutScriptRequest.Script = Unchecked.defaultof<StoredScript>
            } : PutScriptRequest

        [<CustomOperation("id")>]
        member _.Id(state: PutScriptRequest, value: Id) =
            { state with PutScriptRequest.Id = value } : PutScriptRequest

        [<CustomOperation("context")>]
        member _.Context(state: PutScriptRequest, value: Name) =
            { state with PutScriptRequest.Context = value } : PutScriptRequest

        [<CustomOperation("context2")>]
        member _.Context2(state: PutScriptRequest, value: Name) =
            { state with PutScriptRequest.Context2 = Option.Some value } : PutScriptRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: PutScriptRequest, value: Duration) =
            { state with PutScriptRequest.MasterTimeout = Option.Some value } : PutScriptRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: PutScriptRequest, value: Duration) =
            { state with PutScriptRequest.Timeout = Option.Some value } : PutScriptRequest

        [<CustomOperation("script")>]
        member _.Script(state: PutScriptRequest, value: StoredScript) =
            { state with PutScriptRequest.Script = value } : PutScriptRequest

    let putScriptRequest = PutScriptRequestBuilder()

    type ScriptsPainlessExecuteRequest = {
        [<JsonPropertyName("context")>]
        Context: ScriptsPainlessExecutePainlessContext option
        [<JsonPropertyName("context_setup")>]
        ContextSetup: ScriptsPainlessExecutePainlessContextSetup option
        [<JsonPropertyName("script")>]
        Script: Script option
    } with
        static member ToRequest(request: ScriptsPainlessExecuteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_scripts/painless/_execute"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``context`` = request.Context; ``context_setup`` = request.ContextSetup; ``script`` = request.Script |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ScriptsPainlessExecuteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ScriptsPainlessExecuteRequest) : Result<Fes.Http.RequestMsg, exn> =
            ScriptsPainlessExecuteRequest.ToRequest request

    type ScriptsPainlessExecuteRequestBuilder() =
        member _.Yield(_: unit) : ScriptsPainlessExecuteRequest =
            {
                ScriptsPainlessExecuteRequest.Context = Option.None
                ScriptsPainlessExecuteRequest.ContextSetup = Option.None
                ScriptsPainlessExecuteRequest.Script = Option.None
            } : ScriptsPainlessExecuteRequest

        [<CustomOperation("context")>]
        member _.Context(state: ScriptsPainlessExecuteRequest, value: ScriptsPainlessExecutePainlessContext) =
            { state with ScriptsPainlessExecuteRequest.Context = Option.Some value } : ScriptsPainlessExecuteRequest

        [<CustomOperation("context_setup")>]
        member _.ContextSetup(state: ScriptsPainlessExecuteRequest, value: ScriptsPainlessExecutePainlessContextSetup) =
            { state with ScriptsPainlessExecuteRequest.ContextSetup = Option.Some value } : ScriptsPainlessExecuteRequest

        [<CustomOperation("script")>]
        member _.Script(state: ScriptsPainlessExecuteRequest, value: Script) =
            { state with ScriptsPainlessExecuteRequest.Script = Option.Some value } : ScriptsPainlessExecuteRequest

    let scriptsPainlessExecuteRequest = ScriptsPainlessExecuteRequestBuilder()

