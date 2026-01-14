// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module ConnectorOperations =

    type ConnectorCheckInRequest = {
        ConnectorId: Id
    } with
        static member ToRequest(request: ConnectorCheckInRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_check_in"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorCheckInRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorCheckInRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorCheckInRequest.ToRequest request

    type ConnectorCheckInRequestBuilder() =
        member _.Yield(_: unit) : ConnectorCheckInRequest =
            {
                ConnectorCheckInRequest.ConnectorId = Unchecked.defaultof<Id>
            } : ConnectorCheckInRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorCheckInRequest, value: Id) =
            { state with ConnectorCheckInRequest.ConnectorId = value } : ConnectorCheckInRequest

    let connectorCheckInRequest = ConnectorCheckInRequestBuilder()

    type ConnectorCheckInResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorGetRequest = {
        ConnectorId: Id
        IncludeDeleted: bool option
    } with
        static member ToRequest(request: ConnectorGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}"
                let queryParams =
                    [
                        request.IncludeDeleted |> Option.map (fun v -> "include_deleted", Fes.Http.toQueryValue v)
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

    module ConnectorGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorGetRequest.ToRequest request

    type ConnectorGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorGetRequest =
            {
                ConnectorGetRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorGetRequest.IncludeDeleted = Option.None
            } : ConnectorGetRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorGetRequest, value: Id) =
            { state with ConnectorGetRequest.ConnectorId = value } : ConnectorGetRequest

        [<CustomOperation("include_deleted")>]
        member _.IncludeDeleted(state: ConnectorGetRequest, value: bool) =
            { state with ConnectorGetRequest.IncludeDeleted = Option.Some value } : ConnectorGetRequest

    let connectorGetRequest = ConnectorGetRequestBuilder()

    type ConnectorGetResponse = TypesConnector

    type ConnectorPutRequest = {
        ConnectorId: Id
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("index_name")>]
        IndexName: IndexName option
        [<JsonPropertyName("is_native")>]
        IsNative: bool option
        [<JsonPropertyName("language")>]
        Language: string option
        [<JsonPropertyName("name")>]
        Name: string option
        [<JsonPropertyName("service_type")>]
        ServiceType: string option
    } with
        static member ToRequest(request: ConnectorPutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``description`` = request.Description; ``index_name`` = request.IndexName; ``is_native`` = request.IsNative; ``language`` = request.Language; ``name`` = request.Name; ``service_type`` = request.ServiceType |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorPutRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorPutRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorPutRequest.ToRequest request

    type ConnectorPutRequestBuilder() =
        member _.Yield(_: unit) : ConnectorPutRequest =
            {
                ConnectorPutRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorPutRequest.Description = Option.None
                ConnectorPutRequest.IndexName = Option.None
                ConnectorPutRequest.IsNative = Option.None
                ConnectorPutRequest.Language = Option.None
                ConnectorPutRequest.Name = Option.None
                ConnectorPutRequest.ServiceType = Option.None
            } : ConnectorPutRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorPutRequest, value: Id) =
            { state with ConnectorPutRequest.ConnectorId = value } : ConnectorPutRequest

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorPutRequest, value: string) =
            { state with ConnectorPutRequest.Description = Option.Some value } : ConnectorPutRequest

        [<CustomOperation("index_name")>]
        member _.IndexName(state: ConnectorPutRequest, value: IndexName) =
            { state with ConnectorPutRequest.IndexName = Option.Some value } : ConnectorPutRequest

        [<CustomOperation("is_native")>]
        member _.IsNative(state: ConnectorPutRequest, value: bool) =
            { state with ConnectorPutRequest.IsNative = Option.Some value } : ConnectorPutRequest

        [<CustomOperation("language")>]
        member _.Language(state: ConnectorPutRequest, value: string) =
            { state with ConnectorPutRequest.Language = Option.Some value } : ConnectorPutRequest

        [<CustomOperation("name")>]
        member _.Name(state: ConnectorPutRequest, value: string) =
            { state with ConnectorPutRequest.Name = Option.Some value } : ConnectorPutRequest

        [<CustomOperation("service_type")>]
        member _.ServiceType(state: ConnectorPutRequest, value: string) =
            { state with ConnectorPutRequest.ServiceType = Option.Some value } : ConnectorPutRequest

    let connectorPutRequest = ConnectorPutRequestBuilder()

    type ConnectorDeleteRequest = {
        ConnectorId: Id
        DeleteSyncJobs: bool option
        Hard: bool option
    } with
        static member ToRequest(request: ConnectorDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}"
                let queryParams =
                    [
                        request.DeleteSyncJobs |> Option.map (fun v -> "delete_sync_jobs", Fes.Http.toQueryValue v)
                        request.Hard |> Option.map (fun v -> "hard", Fes.Http.toQueryValue v)
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

    module ConnectorDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorDeleteRequest.ToRequest request

    type ConnectorDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorDeleteRequest =
            {
                ConnectorDeleteRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorDeleteRequest.DeleteSyncJobs = Option.None
                ConnectorDeleteRequest.Hard = Option.None
            } : ConnectorDeleteRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorDeleteRequest, value: Id) =
            { state with ConnectorDeleteRequest.ConnectorId = value } : ConnectorDeleteRequest

        [<CustomOperation("delete_sync_jobs")>]
        member _.DeleteSyncJobs(state: ConnectorDeleteRequest, value: bool) =
            { state with ConnectorDeleteRequest.DeleteSyncJobs = Option.Some value } : ConnectorDeleteRequest

        [<CustomOperation("hard")>]
        member _.Hard(state: ConnectorDeleteRequest, value: bool) =
            { state with ConnectorDeleteRequest.Hard = Option.Some value } : ConnectorDeleteRequest

    let connectorDeleteRequest = ConnectorDeleteRequestBuilder()

    type ConnectorDeleteResponse = AcknowledgedResponseBase

    type ConnectorListRequest = {
        From: float option
        Size: float option
        IndexName: Indices option
        ConnectorName: Names option
        ServiceType: Names option
        IncludeDeleted: bool option
        Query: string option
    } with
        static member ToRequest(request: ConnectorListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_connector"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.IndexName |> Option.map (fun v -> "index_name", Fes.Http.toQueryValue v)
                        request.ConnectorName |> Option.map (fun v -> "connector_name", Fes.Http.toQueryValue v)
                        request.ServiceType |> Option.map (fun v -> "service_type", Fes.Http.toQueryValue v)
                        request.IncludeDeleted |> Option.map (fun v -> "include_deleted", Fes.Http.toQueryValue v)
                        request.Query |> Option.map (fun v -> "query", Fes.Http.toQueryValue v)
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

    module ConnectorListRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorListRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorListRequest.ToRequest request

    type ConnectorListRequestBuilder() =
        member _.Yield(_: unit) : ConnectorListRequest =
            {
                ConnectorListRequest.From = Option.None
                ConnectorListRequest.Size = Option.None
                ConnectorListRequest.IndexName = Option.None
                ConnectorListRequest.ConnectorName = Option.None
                ConnectorListRequest.ServiceType = Option.None
                ConnectorListRequest.IncludeDeleted = Option.None
                ConnectorListRequest.Query = Option.None
            } : ConnectorListRequest

        [<CustomOperation("from")>]
        member _.From(state: ConnectorListRequest, value: float) =
            { state with ConnectorListRequest.From = Option.Some value } : ConnectorListRequest

        [<CustomOperation("size")>]
        member _.Size(state: ConnectorListRequest, value: float) =
            { state with ConnectorListRequest.Size = Option.Some value } : ConnectorListRequest

        [<CustomOperation("index_name")>]
        member _.IndexName(state: ConnectorListRequest, value: Indices) =
            { state with ConnectorListRequest.IndexName = Option.Some value } : ConnectorListRequest

        [<CustomOperation("connector_name")>]
        member _.ConnectorName(state: ConnectorListRequest, value: Names) =
            { state with ConnectorListRequest.ConnectorName = Option.Some value } : ConnectorListRequest

        [<CustomOperation("service_type")>]
        member _.ServiceType(state: ConnectorListRequest, value: Names) =
            { state with ConnectorListRequest.ServiceType = Option.Some value } : ConnectorListRequest

        [<CustomOperation("include_deleted")>]
        member _.IncludeDeleted(state: ConnectorListRequest, value: bool) =
            { state with ConnectorListRequest.IncludeDeleted = Option.Some value } : ConnectorListRequest

        [<CustomOperation("query")>]
        member _.Query(state: ConnectorListRequest, value: string) =
            { state with ConnectorListRequest.Query = Option.Some value } : ConnectorListRequest

    let connectorListRequest = ConnectorListRequestBuilder()

    type ConnectorListResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("results")>]
        Results: TypesConnector array
    }

    type ConnectorPostRequest = {
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("index_name")>]
        IndexName: IndexName option
        [<JsonPropertyName("is_native")>]
        IsNative: bool option
        [<JsonPropertyName("language")>]
        Language: string option
        [<JsonPropertyName("name")>]
        Name: string option
        [<JsonPropertyName("service_type")>]
        ServiceType: string option
    } with
        static member ToRequest(request: ConnectorPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_connector"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``description`` = request.Description; ``index_name`` = request.IndexName; ``is_native`` = request.IsNative; ``language`` = request.Language; ``name`` = request.Name; ``service_type`` = request.ServiceType |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorPostRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorPostRequest.ToRequest request

    type ConnectorPostRequestBuilder() =
        member _.Yield(_: unit) : ConnectorPostRequest =
            {
                ConnectorPostRequest.Description = Option.None
                ConnectorPostRequest.IndexName = Option.None
                ConnectorPostRequest.IsNative = Option.None
                ConnectorPostRequest.Language = Option.None
                ConnectorPostRequest.Name = Option.None
                ConnectorPostRequest.ServiceType = Option.None
            } : ConnectorPostRequest

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorPostRequest, value: string) =
            { state with ConnectorPostRequest.Description = Option.Some value } : ConnectorPostRequest

        [<CustomOperation("index_name")>]
        member _.IndexName(state: ConnectorPostRequest, value: IndexName) =
            { state with ConnectorPostRequest.IndexName = Option.Some value } : ConnectorPostRequest

        [<CustomOperation("is_native")>]
        member _.IsNative(state: ConnectorPostRequest, value: bool) =
            { state with ConnectorPostRequest.IsNative = Option.Some value } : ConnectorPostRequest

        [<CustomOperation("language")>]
        member _.Language(state: ConnectorPostRequest, value: string) =
            { state with ConnectorPostRequest.Language = Option.Some value } : ConnectorPostRequest

        [<CustomOperation("name")>]
        member _.Name(state: ConnectorPostRequest, value: string) =
            { state with ConnectorPostRequest.Name = Option.Some value } : ConnectorPostRequest

        [<CustomOperation("service_type")>]
        member _.ServiceType(state: ConnectorPostRequest, value: string) =
            { state with ConnectorPostRequest.ServiceType = Option.Some value } : ConnectorPostRequest

    let connectorPostRequest = ConnectorPostRequestBuilder()

    type ConnectorPostResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
        [<JsonPropertyName("id")>]
        Id: Id
    }

    type ConnectorSyncJobCancelRequest = {
        ConnectorSyncJobId: Id
    } with
        static member ToRequest(request: ConnectorSyncJobCancelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}/_cancel"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobCancelRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobCancelRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobCancelRequest.ToRequest request

    type ConnectorSyncJobCancelRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobCancelRequest =
            {
                ConnectorSyncJobCancelRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
            } : ConnectorSyncJobCancelRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobCancelRequest, value: Id) =
            { state with ConnectorSyncJobCancelRequest.ConnectorSyncJobId = value } : ConnectorSyncJobCancelRequest

    let connectorSyncJobCancelRequest = ConnectorSyncJobCancelRequestBuilder()

    type ConnectorSyncJobCancelResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorSyncJobCheckInRequest = {
        ConnectorSyncJobId: Id
    } with
        static member ToRequest(request: ConnectorSyncJobCheckInRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}/_check_in"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobCheckInRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobCheckInRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobCheckInRequest.ToRequest request

    type ConnectorSyncJobCheckInRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobCheckInRequest =
            {
                ConnectorSyncJobCheckInRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
            } : ConnectorSyncJobCheckInRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobCheckInRequest, value: Id) =
            { state with ConnectorSyncJobCheckInRequest.ConnectorSyncJobId = value } : ConnectorSyncJobCheckInRequest

    let connectorSyncJobCheckInRequest = ConnectorSyncJobCheckInRequestBuilder()

    type ConnectorSyncJobClaimRequest = {
        ConnectorSyncJobId: Id
        [<JsonPropertyName("sync_cursor")>]
        SyncCursor: obj option
        [<JsonPropertyName("worker_hostname")>]
        WorkerHostname: string
    } with
        static member ToRequest(request: ConnectorSyncJobClaimRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}/_claim"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``sync_cursor`` = request.SyncCursor; ``worker_hostname`` = request.WorkerHostname |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobClaimRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobClaimRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobClaimRequest.ToRequest request

    type ConnectorSyncJobClaimRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobClaimRequest =
            {
                ConnectorSyncJobClaimRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
                ConnectorSyncJobClaimRequest.SyncCursor = Option.None
                ConnectorSyncJobClaimRequest.WorkerHostname = String.Empty
            } : ConnectorSyncJobClaimRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobClaimRequest, value: Id) =
            { state with ConnectorSyncJobClaimRequest.ConnectorSyncJobId = value } : ConnectorSyncJobClaimRequest

        [<CustomOperation("sync_cursor")>]
        member _.SyncCursor(state: ConnectorSyncJobClaimRequest, value: obj) =
            { state with ConnectorSyncJobClaimRequest.SyncCursor = Option.Some value } : ConnectorSyncJobClaimRequest

        [<CustomOperation("worker_hostname")>]
        member _.WorkerHostname(state: ConnectorSyncJobClaimRequest, value: string) =
            { state with ConnectorSyncJobClaimRequest.WorkerHostname = value } : ConnectorSyncJobClaimRequest

    let connectorSyncJobClaimRequest = ConnectorSyncJobClaimRequestBuilder()

    type ConnectorSyncJobGetRequest = {
        ConnectorSyncJobId: Id
    } with
        static member ToRequest(request: ConnectorSyncJobGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobGetRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobGetRequest.ToRequest request

    type ConnectorSyncJobGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobGetRequest =
            {
                ConnectorSyncJobGetRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
            } : ConnectorSyncJobGetRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobGetRequest, value: Id) =
            { state with ConnectorSyncJobGetRequest.ConnectorSyncJobId = value } : ConnectorSyncJobGetRequest

    let connectorSyncJobGetRequest = ConnectorSyncJobGetRequestBuilder()

    type ConnectorSyncJobGetResponse = TypesConnectorSyncJob

    type ConnectorSyncJobDeleteRequest = {
        ConnectorSyncJobId: Id
    } with
        static member ToRequest(request: ConnectorSyncJobDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobDeleteRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobDeleteRequest.ToRequest request

    type ConnectorSyncJobDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobDeleteRequest =
            {
                ConnectorSyncJobDeleteRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
            } : ConnectorSyncJobDeleteRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobDeleteRequest, value: Id) =
            { state with ConnectorSyncJobDeleteRequest.ConnectorSyncJobId = value } : ConnectorSyncJobDeleteRequest

    let connectorSyncJobDeleteRequest = ConnectorSyncJobDeleteRequestBuilder()

    type ConnectorSyncJobDeleteResponse = AcknowledgedResponseBase

    type ConnectorSyncJobErrorRequest = {
        ConnectorSyncJobId: Id
        [<JsonPropertyName("error")>]
        Error: string
    } with
        static member ToRequest(request: ConnectorSyncJobErrorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}/_error"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``error`` = request.Error |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobErrorRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobErrorRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobErrorRequest.ToRequest request

    type ConnectorSyncJobErrorRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobErrorRequest =
            {
                ConnectorSyncJobErrorRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
                ConnectorSyncJobErrorRequest.Error = String.Empty
            } : ConnectorSyncJobErrorRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobErrorRequest, value: Id) =
            { state with ConnectorSyncJobErrorRequest.ConnectorSyncJobId = value } : ConnectorSyncJobErrorRequest

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorSyncJobErrorRequest, value: string) =
            { state with ConnectorSyncJobErrorRequest.Error = value } : ConnectorSyncJobErrorRequest

    let connectorSyncJobErrorRequest = ConnectorSyncJobErrorRequestBuilder()

    type ConnectorSyncJobListRequest = {
        From: float option
        Size: float option
        Status: TypesSyncStatus option
        ConnectorId: Id option
        JobType: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: ConnectorSyncJobListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_connector/_sync_job"
                let queryParams =
                    [
                        request.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        request.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        request.Status |> Option.map (fun v -> "status", Fes.Http.toQueryValue v)
                        request.ConnectorId |> Option.map (fun v -> "connector_id", Fes.Http.toQueryValue v)
                        request.JobType |> Option.map (fun v -> "job_type", Fes.Http.toQueryValue v)
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

    module ConnectorSyncJobListRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobListRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobListRequest.ToRequest request

    type ConnectorSyncJobListRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobListRequest =
            {
                ConnectorSyncJobListRequest.From = Option.None
                ConnectorSyncJobListRequest.Size = Option.None
                ConnectorSyncJobListRequest.Status = Option.None
                ConnectorSyncJobListRequest.ConnectorId = Option.None
                ConnectorSyncJobListRequest.JobType = Option.None
            } : ConnectorSyncJobListRequest

        [<CustomOperation("from")>]
        member _.From(state: ConnectorSyncJobListRequest, value: float) =
            { state with ConnectorSyncJobListRequest.From = Option.Some value } : ConnectorSyncJobListRequest

        [<CustomOperation("size")>]
        member _.Size(state: ConnectorSyncJobListRequest, value: float) =
            { state with ConnectorSyncJobListRequest.Size = Option.Some value } : ConnectorSyncJobListRequest

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorSyncJobListRequest, value: TypesSyncStatus) =
            { state with ConnectorSyncJobListRequest.Status = Option.Some value } : ConnectorSyncJobListRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorSyncJobListRequest, value: Id) =
            { state with ConnectorSyncJobListRequest.ConnectorId = Option.Some value } : ConnectorSyncJobListRequest

        [<CustomOperation("job_type")>]
        member _.JobType(state: ConnectorSyncJobListRequest, value: System.Text.Json.JsonElement) =
            { state with ConnectorSyncJobListRequest.JobType = Option.Some value } : ConnectorSyncJobListRequest

    let connectorSyncJobListRequest = ConnectorSyncJobListRequestBuilder()

    type ConnectorSyncJobListResponse = {
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("results")>]
        Results: TypesConnectorSyncJob array
    }

    type ConnectorSyncJobPostRequest = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("job_type")>]
        JobType: TypesSyncJobType option
        [<JsonPropertyName("trigger_method")>]
        TriggerMethod: TypesSyncJobTriggerMethod option
    } with
        static member ToRequest(request: ConnectorSyncJobPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_connector/_sync_job"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``id`` = request.Id; ``job_type`` = request.JobType; ``trigger_method`` = request.TriggerMethod |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobPostRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobPostRequest.ToRequest request

    type ConnectorSyncJobPostRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobPostRequest =
            {
                ConnectorSyncJobPostRequest.Id = Unchecked.defaultof<Id>
                ConnectorSyncJobPostRequest.JobType = Option.None
                ConnectorSyncJobPostRequest.TriggerMethod = Option.None
            } : ConnectorSyncJobPostRequest

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSyncJobPostRequest, value: Id) =
            { state with ConnectorSyncJobPostRequest.Id = value } : ConnectorSyncJobPostRequest

        [<CustomOperation("job_type")>]
        member _.JobType(state: ConnectorSyncJobPostRequest, value: TypesSyncJobType) =
            { state with ConnectorSyncJobPostRequest.JobType = Option.Some value } : ConnectorSyncJobPostRequest

        [<CustomOperation("trigger_method")>]
        member _.TriggerMethod(state: ConnectorSyncJobPostRequest, value: TypesSyncJobTriggerMethod) =
            { state with ConnectorSyncJobPostRequest.TriggerMethod = Option.Some value } : ConnectorSyncJobPostRequest

    let connectorSyncJobPostRequest = ConnectorSyncJobPostRequestBuilder()

    type ConnectorSyncJobPostResponse = {
        [<JsonPropertyName("id")>]
        Id: Id
    }

    type ConnectorSyncJobUpdateStatsRequest = {
        ConnectorSyncJobId: Id
        [<JsonPropertyName("deleted_document_count")>]
        DeletedDocumentCount: float
        [<JsonPropertyName("indexed_document_count")>]
        IndexedDocumentCount: float
        [<JsonPropertyName("indexed_document_volume")>]
        IndexedDocumentVolume: float
        [<JsonPropertyName("last_seen")>]
        LastSeen: Duration option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("total_document_count")>]
        TotalDocumentCount: float option
    } with
        static member ToRequest(request: ConnectorSyncJobUpdateStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{request.ConnectorSyncJobId}/_stats"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``deleted_document_count`` = request.DeletedDocumentCount; ``indexed_document_count`` = request.IndexedDocumentCount; ``indexed_document_volume`` = request.IndexedDocumentVolume; ``last_seen`` = request.LastSeen; ``metadata`` = request.Metadata; ``total_document_count`` = request.TotalDocumentCount |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorSyncJobUpdateStatsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorSyncJobUpdateStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorSyncJobUpdateStatsRequest.ToRequest request

    type ConnectorSyncJobUpdateStatsRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobUpdateStatsRequest =
            {
                ConnectorSyncJobUpdateStatsRequest.ConnectorSyncJobId = Unchecked.defaultof<Id>
                ConnectorSyncJobUpdateStatsRequest.DeletedDocumentCount = 0.0
                ConnectorSyncJobUpdateStatsRequest.IndexedDocumentCount = 0.0
                ConnectorSyncJobUpdateStatsRequest.IndexedDocumentVolume = 0.0
                ConnectorSyncJobUpdateStatsRequest.LastSeen = Option.None
                ConnectorSyncJobUpdateStatsRequest.Metadata = Option.None
                ConnectorSyncJobUpdateStatsRequest.TotalDocumentCount = Option.None
            } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("connector_sync_job_id")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobUpdateStatsRequest, value: Id) =
            { state with ConnectorSyncJobUpdateStatsRequest.ConnectorSyncJobId = value } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("deleted_document_count")>]
        member _.DeletedDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: float) =
            { state with ConnectorSyncJobUpdateStatsRequest.DeletedDocumentCount = value } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("indexed_document_count")>]
        member _.IndexedDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: float) =
            { state with ConnectorSyncJobUpdateStatsRequest.IndexedDocumentCount = value } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("indexed_document_volume")>]
        member _.IndexedDocumentVolume(state: ConnectorSyncJobUpdateStatsRequest, value: float) =
            { state with ConnectorSyncJobUpdateStatsRequest.IndexedDocumentVolume = value } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("last_seen")>]
        member _.LastSeen(state: ConnectorSyncJobUpdateStatsRequest, value: Duration) =
            { state with ConnectorSyncJobUpdateStatsRequest.LastSeen = Option.Some value } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: ConnectorSyncJobUpdateStatsRequest, value: Metadata) =
            { state with ConnectorSyncJobUpdateStatsRequest.Metadata = Option.Some value } : ConnectorSyncJobUpdateStatsRequest

        [<CustomOperation("total_document_count")>]
        member _.TotalDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: float) =
            { state with ConnectorSyncJobUpdateStatsRequest.TotalDocumentCount = Option.Some value } : ConnectorSyncJobUpdateStatsRequest

    let connectorSyncJobUpdateStatsRequest = ConnectorSyncJobUpdateStatsRequestBuilder()

    type ConnectorUpdateActiveFilteringRequest = {
        ConnectorId: Id
    } with
        static member ToRequest(request: ConnectorUpdateActiveFilteringRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_filtering/_activate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateActiveFilteringRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateActiveFilteringRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateActiveFilteringRequest.ToRequest request

    type ConnectorUpdateActiveFilteringRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateActiveFilteringRequest =
            {
                ConnectorUpdateActiveFilteringRequest.ConnectorId = Unchecked.defaultof<Id>
            } : ConnectorUpdateActiveFilteringRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateActiveFilteringRequest, value: Id) =
            { state with ConnectorUpdateActiveFilteringRequest.ConnectorId = value } : ConnectorUpdateActiveFilteringRequest

    let connectorUpdateActiveFilteringRequest = ConnectorUpdateActiveFilteringRequestBuilder()

    type ConnectorUpdateActiveFilteringResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateApiKeyIdRequest = {
        ConnectorId: Id
        [<JsonPropertyName("api_key_id")>]
        ApiKeyId: string option
        [<JsonPropertyName("api_key_secret_id")>]
        ApiKeySecretId: string option
    } with
        static member ToRequest(request: ConnectorUpdateApiKeyIdRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_api_key_id"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``api_key_id`` = request.ApiKeyId; ``api_key_secret_id`` = request.ApiKeySecretId |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateApiKeyIdRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateApiKeyIdRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateApiKeyIdRequest.ToRequest request

    type ConnectorUpdateApiKeyIdRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateApiKeyIdRequest =
            {
                ConnectorUpdateApiKeyIdRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateApiKeyIdRequest.ApiKeyId = Option.None
                ConnectorUpdateApiKeyIdRequest.ApiKeySecretId = Option.None
            } : ConnectorUpdateApiKeyIdRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateApiKeyIdRequest, value: Id) =
            { state with ConnectorUpdateApiKeyIdRequest.ConnectorId = value } : ConnectorUpdateApiKeyIdRequest

        [<CustomOperation("api_key_id")>]
        member _.ApiKeyId(state: ConnectorUpdateApiKeyIdRequest, value: string) =
            { state with ConnectorUpdateApiKeyIdRequest.ApiKeyId = Option.Some value } : ConnectorUpdateApiKeyIdRequest

        [<CustomOperation("api_key_secret_id")>]
        member _.ApiKeySecretId(state: ConnectorUpdateApiKeyIdRequest, value: string) =
            { state with ConnectorUpdateApiKeyIdRequest.ApiKeySecretId = Option.Some value } : ConnectorUpdateApiKeyIdRequest

    let connectorUpdateApiKeyIdRequest = ConnectorUpdateApiKeyIdRequestBuilder()

    type ConnectorUpdateApiKeyIdResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateConfigurationRequest = {
        ConnectorId: Id
        [<JsonPropertyName("configuration")>]
        Configuration: TypesConnectorConfiguration option
        [<JsonPropertyName("values")>]
        Values: Map<string, obj> option
    } with
        static member ToRequest(request: ConnectorUpdateConfigurationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_configuration"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``configuration`` = request.Configuration; ``values`` = request.Values |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateConfigurationRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateConfigurationRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateConfigurationRequest.ToRequest request

    type ConnectorUpdateConfigurationRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateConfigurationRequest =
            {
                ConnectorUpdateConfigurationRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateConfigurationRequest.Configuration = Option.None
                ConnectorUpdateConfigurationRequest.Values = Option.None
            } : ConnectorUpdateConfigurationRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateConfigurationRequest, value: Id) =
            { state with ConnectorUpdateConfigurationRequest.ConnectorId = value } : ConnectorUpdateConfigurationRequest

        [<CustomOperation("configuration")>]
        member _.Configuration(state: ConnectorUpdateConfigurationRequest, value: TypesConnectorConfiguration) =
            { state with ConnectorUpdateConfigurationRequest.Configuration = Option.Some value } : ConnectorUpdateConfigurationRequest

        [<CustomOperation("values")>]
        member _.Values(state: ConnectorUpdateConfigurationRequest, value: Map<string, obj>) =
            { state with ConnectorUpdateConfigurationRequest.Values = Option.Some value } : ConnectorUpdateConfigurationRequest

    let connectorUpdateConfigurationRequest = ConnectorUpdateConfigurationRequestBuilder()

    type ConnectorUpdateConfigurationResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateErrorRequest = {
        ConnectorId: Id
        [<JsonPropertyName("error")>]
        Error: System.Text.Json.JsonElement
    } with
        static member ToRequest(request: ConnectorUpdateErrorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_error"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``error`` = request.Error |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateErrorRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateErrorRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateErrorRequest.ToRequest request

    type ConnectorUpdateErrorRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateErrorRequest =
            {
                ConnectorUpdateErrorRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateErrorRequest.Error = Unchecked.defaultof<System.Text.Json.JsonElement>
            } : ConnectorUpdateErrorRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateErrorRequest, value: Id) =
            { state with ConnectorUpdateErrorRequest.ConnectorId = value } : ConnectorUpdateErrorRequest

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorUpdateErrorRequest, value: System.Text.Json.JsonElement) =
            { state with ConnectorUpdateErrorRequest.Error = value } : ConnectorUpdateErrorRequest

    let connectorUpdateErrorRequest = ConnectorUpdateErrorRequestBuilder()

    type ConnectorUpdateErrorResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateFeaturesRequest = {
        ConnectorId: Id
        [<JsonPropertyName("features")>]
        Features: TypesConnectorFeatures
    } with
        static member ToRequest(request: ConnectorUpdateFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_features"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``features`` = request.Features |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateFeaturesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateFeaturesRequest.ToRequest request

    type ConnectorUpdateFeaturesRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFeaturesRequest =
            {
                ConnectorUpdateFeaturesRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateFeaturesRequest.Features = Unchecked.defaultof<TypesConnectorFeatures>
            } : ConnectorUpdateFeaturesRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateFeaturesRequest, value: Id) =
            { state with ConnectorUpdateFeaturesRequest.ConnectorId = value } : ConnectorUpdateFeaturesRequest

        [<CustomOperation("features")>]
        member _.Features(state: ConnectorUpdateFeaturesRequest, value: TypesConnectorFeatures) =
            { state with ConnectorUpdateFeaturesRequest.Features = value } : ConnectorUpdateFeaturesRequest

    let connectorUpdateFeaturesRequest = ConnectorUpdateFeaturesRequestBuilder()

    type ConnectorUpdateFeaturesResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateFilteringRequest = {
        ConnectorId: Id
        [<JsonPropertyName("filtering")>]
        Filtering: TypesFilteringConfig array option
        [<JsonPropertyName("rules")>]
        Rules: TypesFilteringRule array option
        [<JsonPropertyName("advanced_snippet")>]
        AdvancedSnippet: TypesFilteringAdvancedSnippet option
    } with
        static member ToRequest(request: ConnectorUpdateFilteringRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_filtering"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``filtering`` = request.Filtering; ``rules`` = request.Rules; ``advanced_snippet`` = request.AdvancedSnippet |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateFilteringRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateFilteringRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateFilteringRequest.ToRequest request

    type ConnectorUpdateFilteringRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFilteringRequest =
            {
                ConnectorUpdateFilteringRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateFilteringRequest.Filtering = Option.None
                ConnectorUpdateFilteringRequest.Rules = Option.None
                ConnectorUpdateFilteringRequest.AdvancedSnippet = Option.None
            } : ConnectorUpdateFilteringRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateFilteringRequest, value: Id) =
            { state with ConnectorUpdateFilteringRequest.ConnectorId = value } : ConnectorUpdateFilteringRequest

        [<CustomOperation("filtering")>]
        member _.Filtering(state: ConnectorUpdateFilteringRequest, value: TypesFilteringConfig array) =
            { state with ConnectorUpdateFilteringRequest.Filtering = Option.Some value } : ConnectorUpdateFilteringRequest

        [<CustomOperation("rules")>]
        member _.Rules(state: ConnectorUpdateFilteringRequest, value: TypesFilteringRule array) =
            { state with ConnectorUpdateFilteringRequest.Rules = Option.Some value } : ConnectorUpdateFilteringRequest

        [<CustomOperation("advanced_snippet")>]
        member _.AdvancedSnippet(state: ConnectorUpdateFilteringRequest, value: TypesFilteringAdvancedSnippet) =
            { state with ConnectorUpdateFilteringRequest.AdvancedSnippet = Option.Some value } : ConnectorUpdateFilteringRequest

    let connectorUpdateFilteringRequest = ConnectorUpdateFilteringRequestBuilder()

    type ConnectorUpdateFilteringResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateFilteringValidationRequest = {
        ConnectorId: Id
        [<JsonPropertyName("validation")>]
        Validation: TypesFilteringRulesValidation
    } with
        static member ToRequest(request: ConnectorUpdateFilteringValidationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_filtering/_validation"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``validation`` = request.Validation |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateFilteringValidationRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateFilteringValidationRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateFilteringValidationRequest.ToRequest request

    type ConnectorUpdateFilteringValidationRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFilteringValidationRequest =
            {
                ConnectorUpdateFilteringValidationRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateFilteringValidationRequest.Validation = Unchecked.defaultof<TypesFilteringRulesValidation>
            } : ConnectorUpdateFilteringValidationRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateFilteringValidationRequest, value: Id) =
            { state with ConnectorUpdateFilteringValidationRequest.ConnectorId = value } : ConnectorUpdateFilteringValidationRequest

        [<CustomOperation("validation")>]
        member _.Validation(state: ConnectorUpdateFilteringValidationRequest, value: TypesFilteringRulesValidation) =
            { state with ConnectorUpdateFilteringValidationRequest.Validation = value } : ConnectorUpdateFilteringValidationRequest

    let connectorUpdateFilteringValidationRequest = ConnectorUpdateFilteringValidationRequestBuilder()

    type ConnectorUpdateFilteringValidationResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateIndexNameRequest = {
        ConnectorId: Id
        [<JsonPropertyName("index_name")>]
        IndexName: System.Text.Json.JsonElement
    } with
        static member ToRequest(request: ConnectorUpdateIndexNameRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_index_name"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``index_name`` = request.IndexName |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateIndexNameRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateIndexNameRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateIndexNameRequest.ToRequest request

    type ConnectorUpdateIndexNameRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateIndexNameRequest =
            {
                ConnectorUpdateIndexNameRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateIndexNameRequest.IndexName = Unchecked.defaultof<System.Text.Json.JsonElement>
            } : ConnectorUpdateIndexNameRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateIndexNameRequest, value: Id) =
            { state with ConnectorUpdateIndexNameRequest.ConnectorId = value } : ConnectorUpdateIndexNameRequest

        [<CustomOperation("index_name")>]
        member _.IndexName(state: ConnectorUpdateIndexNameRequest, value: System.Text.Json.JsonElement) =
            { state with ConnectorUpdateIndexNameRequest.IndexName = value } : ConnectorUpdateIndexNameRequest

    let connectorUpdateIndexNameRequest = ConnectorUpdateIndexNameRequestBuilder()

    type ConnectorUpdateIndexNameResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateNameRequest = {
        ConnectorId: Id
        [<JsonPropertyName("name")>]
        Name: string option
        [<JsonPropertyName("description")>]
        Description: string option
    } with
        static member ToRequest(request: ConnectorUpdateNameRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_name"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``name`` = request.Name; ``description`` = request.Description |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateNameRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateNameRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateNameRequest.ToRequest request

    type ConnectorUpdateNameRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateNameRequest =
            {
                ConnectorUpdateNameRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateNameRequest.Name = Option.None
                ConnectorUpdateNameRequest.Description = Option.None
            } : ConnectorUpdateNameRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateNameRequest, value: Id) =
            { state with ConnectorUpdateNameRequest.ConnectorId = value } : ConnectorUpdateNameRequest

        [<CustomOperation("name")>]
        member _.Name(state: ConnectorUpdateNameRequest, value: string) =
            { state with ConnectorUpdateNameRequest.Name = Option.Some value } : ConnectorUpdateNameRequest

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorUpdateNameRequest, value: string) =
            { state with ConnectorUpdateNameRequest.Description = Option.Some value } : ConnectorUpdateNameRequest

    let connectorUpdateNameRequest = ConnectorUpdateNameRequestBuilder()

    type ConnectorUpdateNameResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateNativeRequest = {
        ConnectorId: Id
        [<JsonPropertyName("is_native")>]
        IsNative: bool
    } with
        static member ToRequest(request: ConnectorUpdateNativeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_native"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``is_native`` = request.IsNative |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateNativeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateNativeRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateNativeRequest.ToRequest request

    type ConnectorUpdateNativeRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateNativeRequest =
            {
                ConnectorUpdateNativeRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateNativeRequest.IsNative = false
            } : ConnectorUpdateNativeRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateNativeRequest, value: Id) =
            { state with ConnectorUpdateNativeRequest.ConnectorId = value } : ConnectorUpdateNativeRequest

        [<CustomOperation("is_native")>]
        member _.IsNative(state: ConnectorUpdateNativeRequest, value: bool) =
            { state with ConnectorUpdateNativeRequest.IsNative = value } : ConnectorUpdateNativeRequest

    let connectorUpdateNativeRequest = ConnectorUpdateNativeRequestBuilder()

    type ConnectorUpdateNativeResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdatePipelineRequest = {
        ConnectorId: Id
        [<JsonPropertyName("pipeline")>]
        Pipeline: TypesIngestPipelineParams
    } with
        static member ToRequest(request: ConnectorUpdatePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_pipeline"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``pipeline`` = request.Pipeline |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdatePipelineRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdatePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdatePipelineRequest.ToRequest request

    type ConnectorUpdatePipelineRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdatePipelineRequest =
            {
                ConnectorUpdatePipelineRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdatePipelineRequest.Pipeline = Unchecked.defaultof<TypesIngestPipelineParams>
            } : ConnectorUpdatePipelineRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdatePipelineRequest, value: Id) =
            { state with ConnectorUpdatePipelineRequest.ConnectorId = value } : ConnectorUpdatePipelineRequest

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: ConnectorUpdatePipelineRequest, value: TypesIngestPipelineParams) =
            { state with ConnectorUpdatePipelineRequest.Pipeline = value } : ConnectorUpdatePipelineRequest

    let connectorUpdatePipelineRequest = ConnectorUpdatePipelineRequestBuilder()

    type ConnectorUpdatePipelineResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateSchedulingRequest = {
        ConnectorId: Id
        [<JsonPropertyName("scheduling")>]
        Scheduling: TypesSchedulingConfiguration
    } with
        static member ToRequest(request: ConnectorUpdateSchedulingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_scheduling"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``scheduling`` = request.Scheduling |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateSchedulingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateSchedulingRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateSchedulingRequest.ToRequest request

    type ConnectorUpdateSchedulingRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateSchedulingRequest =
            {
                ConnectorUpdateSchedulingRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateSchedulingRequest.Scheduling = Unchecked.defaultof<TypesSchedulingConfiguration>
            } : ConnectorUpdateSchedulingRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateSchedulingRequest, value: Id) =
            { state with ConnectorUpdateSchedulingRequest.ConnectorId = value } : ConnectorUpdateSchedulingRequest

        [<CustomOperation("scheduling")>]
        member _.Scheduling(state: ConnectorUpdateSchedulingRequest, value: TypesSchedulingConfiguration) =
            { state with ConnectorUpdateSchedulingRequest.Scheduling = value } : ConnectorUpdateSchedulingRequest

    let connectorUpdateSchedulingRequest = ConnectorUpdateSchedulingRequestBuilder()

    type ConnectorUpdateSchedulingResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateServiceTypeRequest = {
        ConnectorId: Id
        [<JsonPropertyName("service_type")>]
        ServiceType: string
    } with
        static member ToRequest(request: ConnectorUpdateServiceTypeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_service_type"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``service_type`` = request.ServiceType |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateServiceTypeRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateServiceTypeRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateServiceTypeRequest.ToRequest request

    type ConnectorUpdateServiceTypeRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateServiceTypeRequest =
            {
                ConnectorUpdateServiceTypeRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateServiceTypeRequest.ServiceType = String.Empty
            } : ConnectorUpdateServiceTypeRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateServiceTypeRequest, value: Id) =
            { state with ConnectorUpdateServiceTypeRequest.ConnectorId = value } : ConnectorUpdateServiceTypeRequest

        [<CustomOperation("service_type")>]
        member _.ServiceType(state: ConnectorUpdateServiceTypeRequest, value: string) =
            { state with ConnectorUpdateServiceTypeRequest.ServiceType = value } : ConnectorUpdateServiceTypeRequest

    let connectorUpdateServiceTypeRequest = ConnectorUpdateServiceTypeRequestBuilder()

    type ConnectorUpdateServiceTypeResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

    type ConnectorUpdateStatusRequest = {
        ConnectorId: Id
        [<JsonPropertyName("status")>]
        Status: TypesConnectorStatus
    } with
        static member ToRequest(request: ConnectorUpdateStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{request.ConnectorId}/_status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``status`` = request.Status |}
                |> Result.Ok
            with ex -> Result.Error ex

    module ConnectorUpdateStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: ConnectorUpdateStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            ConnectorUpdateStatusRequest.ToRequest request

    type ConnectorUpdateStatusRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateStatusRequest =
            {
                ConnectorUpdateStatusRequest.ConnectorId = Unchecked.defaultof<Id>
                ConnectorUpdateStatusRequest.Status = Unchecked.defaultof<TypesConnectorStatus>
            } : ConnectorUpdateStatusRequest

        [<CustomOperation("connector_id")>]
        member _.ConnectorId(state: ConnectorUpdateStatusRequest, value: Id) =
            { state with ConnectorUpdateStatusRequest.ConnectorId = value } : ConnectorUpdateStatusRequest

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorUpdateStatusRequest, value: TypesConnectorStatus) =
            { state with ConnectorUpdateStatusRequest.Status = value } : ConnectorUpdateStatusRequest

    let connectorUpdateStatusRequest = ConnectorUpdateStatusRequestBuilder()

    type ConnectorUpdateStatusResponse = {
        [<JsonPropertyName("result")>]
        Result: Result
    }

