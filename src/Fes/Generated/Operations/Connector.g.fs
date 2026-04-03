// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module ConnectorOperations =

    type ConnectorCheckInRequest = {
        ConnectorId: CoreTypes.Id
    }

        with
        static member ToRequest(req: ConnectorCheckInRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_check_in"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorCheckInResponse = System.Text.Json.JsonElement

    type ConnectorCheckInRequestBuilder() =
        member _.Yield(_: unit) : ConnectorCheckInRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorCheckInRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

    let connectorCheckInRequest = ConnectorCheckInRequestBuilder()

    type ConnectorDeleteRequest = {
        ConnectorId: CoreTypes.Id
        DeleteSyncJobs: bool option
        Hard: bool option
    }

        with
        static member ToRequest(req: ConnectorDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}"
                let queryParams =
                    [
                        req.DeleteSyncJobs |> Option.map (fun v -> "delete_sync_jobs", Fes.Http.toQueryValue v)
                        req.Hard |> Option.map (fun v -> "hard", Fes.Http.toQueryValue v)
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

    type ConnectorDeleteResponse = CoreTypes.AcknowledgedResponseBase

    type ConnectorDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorDeleteRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                DeleteSyncJobs = None
                Hard = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorDeleteRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("deleteSyncJobs")>]
        member _.DeleteSyncJobs(state: ConnectorDeleteRequest, value: bool) =
            { state with DeleteSyncJobs = Some value }

        [<CustomOperation("hard")>]
        member _.Hard(state: ConnectorDeleteRequest, value: bool) =
            { state with Hard = Some value }

    let connectorDeleteRequest = ConnectorDeleteRequestBuilder()

    module Delete =
        let withDeleteSyncJobs (value: bool) (req: ConnectorDeleteRequest) =
            { req with DeleteSyncJobs = Some value }
        let withHard (value: bool) (req: ConnectorDeleteRequest) =
            { req with Hard = Some value }

    type ConnectorGetRequest = {
        ConnectorId: CoreTypes.Id
        IncludeDeleted: bool option
    }

        with
        static member ToRequest(req: ConnectorGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}"
                let queryParams =
                    [
                        req.IncludeDeleted |> Option.map (fun v -> "include_deleted", Fes.Http.toQueryValue v)
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

    type ConnectorGetResponse = ConnectorTypes.Connector

    type ConnectorGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorGetRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                IncludeDeleted = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorGetRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("includeDeleted")>]
        member _.IncludeDeleted(state: ConnectorGetRequest, value: bool) =
            { state with IncludeDeleted = Some value }

    let connectorGetRequest = ConnectorGetRequestBuilder()

    module Get =
        let withIncludeDeleted (value: bool) (req: ConnectorGetRequest) =
            { req with IncludeDeleted = Some value }

    type ConnectorLastSyncRequest = {
        ConnectorId: CoreTypes.Id
        LastAccessControlSyncError: string option
        LastAccessControlSyncScheduledAt: CoreTypes.DateTime option
        LastAccessControlSyncStatus: ConnectorTypes.SyncStatus option
        LastDeletedDocumentCount: CoreTypes.Long option
        LastIncrementalSyncScheduledAt: CoreTypes.DateTime option
        LastIndexedDocumentCount: CoreTypes.Long option
        LastSeen: CoreTypes.DateTime option
        LastSyncError: string option
        LastSyncScheduledAt: CoreTypes.DateTime option
        LastSyncStatus: ConnectorTypes.SyncStatus option
        LastSynced: CoreTypes.DateTime option
        SyncCursor: System.Text.Json.JsonElement option
    }

        with
        static member ToRequest(req: ConnectorLastSyncRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_last_sync"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorLastSyncResponse = System.Text.Json.JsonElement

    type ConnectorLastSyncRequestBuilder() =
        member _.Yield(_: unit) : ConnectorLastSyncRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                LastAccessControlSyncError = None
                LastAccessControlSyncScheduledAt = None
                LastAccessControlSyncStatus = None
                LastDeletedDocumentCount = None
                LastIncrementalSyncScheduledAt = None
                LastIndexedDocumentCount = None
                LastSeen = None
                LastSyncError = None
                LastSyncScheduledAt = None
                LastSyncStatus = None
                LastSynced = None
                SyncCursor = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorLastSyncRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("lastAccessControlSyncError")>]
        member _.LastAccessControlSyncError(state: ConnectorLastSyncRequest, value: string) =
            { state with LastAccessControlSyncError = Some value }

        [<CustomOperation("lastAccessControlSyncScheduledAt")>]
        member _.LastAccessControlSyncScheduledAt(state: ConnectorLastSyncRequest, value: CoreTypes.DateTime) =
            { state with LastAccessControlSyncScheduledAt = Some value }

        [<CustomOperation("lastAccessControlSyncStatus")>]
        member _.LastAccessControlSyncStatus(state: ConnectorLastSyncRequest, value: ConnectorTypes.SyncStatus) =
            { state with LastAccessControlSyncStatus = Some value }

        [<CustomOperation("lastDeletedDocumentCount")>]
        member _.LastDeletedDocumentCount(state: ConnectorLastSyncRequest, value: CoreTypes.Long) =
            { state with LastDeletedDocumentCount = Some value }

        [<CustomOperation("lastIncrementalSyncScheduledAt")>]
        member _.LastIncrementalSyncScheduledAt(state: ConnectorLastSyncRequest, value: CoreTypes.DateTime) =
            { state with LastIncrementalSyncScheduledAt = Some value }

        [<CustomOperation("lastIndexedDocumentCount")>]
        member _.LastIndexedDocumentCount(state: ConnectorLastSyncRequest, value: CoreTypes.Long) =
            { state with LastIndexedDocumentCount = Some value }

        [<CustomOperation("lastSeen")>]
        member _.LastSeen(state: ConnectorLastSyncRequest, value: CoreTypes.DateTime) =
            { state with LastSeen = Some value }

        [<CustomOperation("lastSyncError")>]
        member _.LastSyncError(state: ConnectorLastSyncRequest, value: string) =
            { state with LastSyncError = Some value }

        [<CustomOperation("lastSyncScheduledAt")>]
        member _.LastSyncScheduledAt(state: ConnectorLastSyncRequest, value: CoreTypes.DateTime) =
            { state with LastSyncScheduledAt = Some value }

        [<CustomOperation("lastSyncStatus")>]
        member _.LastSyncStatus(state: ConnectorLastSyncRequest, value: ConnectorTypes.SyncStatus) =
            { state with LastSyncStatus = Some value }

        [<CustomOperation("lastSynced")>]
        member _.LastSynced(state: ConnectorLastSyncRequest, value: CoreTypes.DateTime) =
            { state with LastSynced = Some value }

        [<CustomOperation("syncCursor")>]
        member _.SyncCursor(state: ConnectorLastSyncRequest, value: System.Text.Json.JsonElement) =
            { state with SyncCursor = Some value }

    let connectorLastSyncRequest = ConnectorLastSyncRequestBuilder()

    module LastSync =
        let withLastAccessControlSyncError (value: string) (req: ConnectorLastSyncRequest) =
            { req with LastAccessControlSyncError = Some value }
        let withLastAccessControlSyncScheduledAt (value: CoreTypes.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastAccessControlSyncScheduledAt = Some value }
        let withLastAccessControlSyncStatus (value: ConnectorTypes.SyncStatus) (req: ConnectorLastSyncRequest) =
            { req with LastAccessControlSyncStatus = Some value }
        let withLastDeletedDocumentCount (value: CoreTypes.Long) (req: ConnectorLastSyncRequest) =
            { req with LastDeletedDocumentCount = Some value }
        let withLastIncrementalSyncScheduledAt (value: CoreTypes.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastIncrementalSyncScheduledAt = Some value }
        let withLastIndexedDocumentCount (value: CoreTypes.Long) (req: ConnectorLastSyncRequest) =
            { req with LastIndexedDocumentCount = Some value }
        let withLastSeen (value: CoreTypes.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastSeen = Some value }
        let withLastSyncError (value: string) (req: ConnectorLastSyncRequest) =
            { req with LastSyncError = Some value }
        let withLastSyncScheduledAt (value: CoreTypes.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastSyncScheduledAt = Some value }
        let withLastSyncStatus (value: ConnectorTypes.SyncStatus) (req: ConnectorLastSyncRequest) =
            { req with LastSyncStatus = Some value }
        let withLastSynced (value: CoreTypes.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastSynced = Some value }
        let withSyncCursor (value: System.Text.Json.JsonElement) (req: ConnectorLastSyncRequest) =
            { req with SyncCursor = Some value }

    type ConnectorListRequest = {
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        IndexName: CoreTypes.Indices option
        ConnectorName: CoreTypes.Names option
        ServiceType: CoreTypes.Names option
        IncludeDeleted: bool option
        Query: string option
    }

        with
        static member ToRequest(req: ConnectorListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.IndexName |> Option.map (fun v -> "index_name", Fes.Http.toQueryValue v)
                        req.ConnectorName |> Option.map (fun v -> "connector_name", Fes.Http.toQueryValue v)
                        req.ServiceType |> Option.map (fun v -> "service_type", Fes.Http.toQueryValue v)
                        req.IncludeDeleted |> Option.map (fun v -> "include_deleted", Fes.Http.toQueryValue v)
                        req.Query |> Option.map (fun v -> "query", Fes.Http.toQueryValue v)
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

    type ConnectorListResponse = System.Text.Json.JsonElement

    type ConnectorListRequestBuilder() =
        member _.Yield(_: unit) : ConnectorListRequest =
            {
                From = None
                Size = None
                IndexName = None
                ConnectorName = None
                ServiceType = None
                IncludeDeleted = None
                Query = None
            }

        [<CustomOperation("from")>]
        member _.From(state: ConnectorListRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: ConnectorListRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorListRequest, value: CoreTypes.Indices) =
            { state with IndexName = Some value }

        [<CustomOperation("connectorName")>]
        member _.ConnectorName(state: ConnectorListRequest, value: CoreTypes.Names) =
            { state with ConnectorName = Some value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: ConnectorListRequest, value: CoreTypes.Names) =
            { state with ServiceType = Some value }

        [<CustomOperation("includeDeleted")>]
        member _.IncludeDeleted(state: ConnectorListRequest, value: bool) =
            { state with IncludeDeleted = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: ConnectorListRequest, value: string) =
            { state with Query = Some value }

    let connectorListRequest = ConnectorListRequestBuilder()

    module List =
        let withFrom (value: CoreTypes.Integer) (req: ConnectorListRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: ConnectorListRequest) =
            { req with Size = Some value }
        let withIndexName (value: CoreTypes.Indices) (req: ConnectorListRequest) =
            { req with IndexName = Some value }
        let withConnectorName (value: CoreTypes.Names) (req: ConnectorListRequest) =
            { req with ConnectorName = Some value }
        let withServiceType (value: CoreTypes.Names) (req: ConnectorListRequest) =
            { req with ServiceType = Some value }
        let withIncludeDeleted (value: bool) (req: ConnectorListRequest) =
            { req with IncludeDeleted = Some value }
        let withQuery (value: string) (req: ConnectorListRequest) =
            { req with Query = Some value }

    type ConnectorPostRequest = {
        Description: string option
        IndexName: CoreTypes.IndexName option
        IsNative: bool option
        Language: string option
        Name: string option
        ServiceType: string option
    }

        with
        static member ToRequest(req: ConnectorPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorPostResponse = System.Text.Json.JsonElement

    type ConnectorPostRequestBuilder() =
        member _.Yield(_: unit) : ConnectorPostRequest =
            {
                Description = None
                IndexName = None
                IsNative = None
                Language = None
                Name = None
                ServiceType = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorPostRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorPostRequest, value: CoreTypes.IndexName) =
            { state with IndexName = Some value }

        [<CustomOperation("isNative")>]
        member _.IsNative(state: ConnectorPostRequest, value: bool) =
            { state with IsNative = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: ConnectorPostRequest, value: string) =
            { state with Language = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: ConnectorPostRequest, value: string) =
            { state with Name = Some value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: ConnectorPostRequest, value: string) =
            { state with ServiceType = Some value }

    let connectorPostRequest = ConnectorPostRequestBuilder()

    module Post =
        let withDescription (value: string) (req: ConnectorPostRequest) =
            { req with Description = Some value }
        let withIndexName (value: CoreTypes.IndexName) (req: ConnectorPostRequest) =
            { req with IndexName = Some value }
        let withIsNative (value: bool) (req: ConnectorPostRequest) =
            { req with IsNative = Some value }
        let withLanguage (value: string) (req: ConnectorPostRequest) =
            { req with Language = Some value }
        let withName (value: string) (req: ConnectorPostRequest) =
            { req with Name = Some value }
        let withServiceType (value: string) (req: ConnectorPostRequest) =
            { req with ServiceType = Some value }

    type ConnectorPutRequest = {
        ConnectorId: CoreTypes.Id
        Description: string option
        IndexName: CoreTypes.IndexName option
        IsNative: bool option
        Language: string option
        Name: string option
        ServiceType: string option
    }

        with
        static member ToRequest(req: ConnectorPutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorPutResponse = System.Text.Json.JsonElement

    type ConnectorPutRequestBuilder() =
        member _.Yield(_: unit) : ConnectorPutRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Description = None
                IndexName = None
                IsNative = None
                Language = None
                Name = None
                ServiceType = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorPutRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorPutRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorPutRequest, value: CoreTypes.IndexName) =
            { state with IndexName = Some value }

        [<CustomOperation("isNative")>]
        member _.IsNative(state: ConnectorPutRequest, value: bool) =
            { state with IsNative = Some value }

        [<CustomOperation("language")>]
        member _.Language(state: ConnectorPutRequest, value: string) =
            { state with Language = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: ConnectorPutRequest, value: string) =
            { state with Name = Some value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: ConnectorPutRequest, value: string) =
            { state with ServiceType = Some value }

    let connectorPutRequest = ConnectorPutRequestBuilder()

    module Put =
        let withDescription (value: string) (req: ConnectorPutRequest) =
            { req with Description = Some value }
        let withIndexName (value: CoreTypes.IndexName) (req: ConnectorPutRequest) =
            { req with IndexName = Some value }
        let withIsNative (value: bool) (req: ConnectorPutRequest) =
            { req with IsNative = Some value }
        let withLanguage (value: string) (req: ConnectorPutRequest) =
            { req with Language = Some value }
        let withName (value: string) (req: ConnectorPutRequest) =
            { req with Name = Some value }
        let withServiceType (value: string) (req: ConnectorPutRequest) =
            { req with ServiceType = Some value }

    type ConnectorSecretDeleteRequest = {
        Id: string
    }

        with
        static member ToRequest(req: ConnectorSecretDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_secret/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSecretDeleteResponse = System.Text.Json.JsonElement

    type ConnectorSecretDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSecretDeleteRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSecretDeleteRequest, value: string) =
            { state with Id = value }

    let connectorSecretDeleteRequest = ConnectorSecretDeleteRequestBuilder()

    type ConnectorSecretGetRequest = {
        Id: string
    }

        with
        static member ToRequest(req: ConnectorSecretGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_secret/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSecretGetResponse = System.Text.Json.JsonElement

    type ConnectorSecretGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSecretGetRequest =
            {
                Id = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSecretGetRequest, value: string) =
            { state with Id = value }

    let connectorSecretGetRequest = ConnectorSecretGetRequestBuilder()

    type ConnectorSecretPostRequest = {
        Value: string option
    }

        with
        static member ToRequest(req: ConnectorSecretPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_secret"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSecretPostResponse = System.Text.Json.JsonElement

    type ConnectorSecretPostRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSecretPostRequest =
            {
                Value = None
            }

        [<CustomOperation("value")>]
        member _.Value(state: ConnectorSecretPostRequest, value: string) =
            { state with Value = Some value }

    let connectorSecretPostRequest = ConnectorSecretPostRequestBuilder()

    module SecretPost =
        let withValue (value: string) (req: ConnectorSecretPostRequest) =
            { req with Value = Some value }

    type ConnectorSecretPutRequest = {
        Id: string
        Value: string
    }

        with
        static member ToRequest(req: ConnectorSecretPutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_secret/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSecretPutResponse = System.Text.Json.JsonElement

    type ConnectorSecretPutRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSecretPutRequest =
            {
                Id = Unchecked.defaultof<_>
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSecretPutRequest, value: string) =
            { state with Id = value }

        [<CustomOperation("value")>]
        member _.Value(state: ConnectorSecretPutRequest, value: string) =
            { state with Value = value }

    let connectorSecretPutRequest = ConnectorSecretPutRequestBuilder()

    module SecretPut =
        let withValue (value: string) (req: ConnectorSecretPutRequest) =
            { req with Value = value }

    type ConnectorSyncJobCancelRequest = {
        ConnectorSyncJobId: CoreTypes.Id
    }

        with
        static member ToRequest(req: ConnectorSyncJobCancelRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_cancel"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobCancelResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobCancelRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobCancelRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobCancelRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobCancelRequest = ConnectorSyncJobCancelRequestBuilder()

    type ConnectorSyncJobCheckInRequest = {
        ConnectorSyncJobId: CoreTypes.Id
    }

        with
        static member ToRequest(req: ConnectorSyncJobCheckInRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_check_in"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobCheckInResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobCheckInRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobCheckInRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobCheckInRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobCheckInRequest = ConnectorSyncJobCheckInRequestBuilder()

    type ConnectorSyncJobClaimRequest = {
        ConnectorSyncJobId: CoreTypes.Id
        SyncCursor: System.Text.Json.JsonElement option
        WorkerHostname: string
    }

        with
        static member ToRequest(req: ConnectorSyncJobClaimRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_claim"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobClaimResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobClaimRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobClaimRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
                SyncCursor = None
                WorkerHostname = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobClaimRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

        [<CustomOperation("syncCursor")>]
        member _.SyncCursor(state: ConnectorSyncJobClaimRequest, value: System.Text.Json.JsonElement) =
            { state with SyncCursor = Some value }

        [<CustomOperation("workerHostname")>]
        member _.WorkerHostname(state: ConnectorSyncJobClaimRequest, value: string) =
            { state with WorkerHostname = value }

    let connectorSyncJobClaimRequest = ConnectorSyncJobClaimRequestBuilder()

    module SyncJobClaim =
        let withSyncCursor (value: System.Text.Json.JsonElement) (req: ConnectorSyncJobClaimRequest) =
            { req with SyncCursor = Some value }
        let withWorkerHostname (value: string) (req: ConnectorSyncJobClaimRequest) =
            { req with WorkerHostname = value }

    type ConnectorSyncJobDeleteRequest = {
        ConnectorSyncJobId: CoreTypes.Id
    }

        with
        static member ToRequest(req: ConnectorSyncJobDeleteRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobDeleteResponse = CoreTypes.AcknowledgedResponseBase

    type ConnectorSyncJobDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobDeleteRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobDeleteRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobDeleteRequest = ConnectorSyncJobDeleteRequestBuilder()

    type ConnectorSyncJobErrorRequest = {
        ConnectorSyncJobId: CoreTypes.Id
        Error: string
    }

        with
        static member ToRequest(req: ConnectorSyncJobErrorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_error"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobErrorResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobErrorRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobErrorRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
                Error = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobErrorRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorSyncJobErrorRequest, value: string) =
            { state with Error = value }

    let connectorSyncJobErrorRequest = ConnectorSyncJobErrorRequestBuilder()

    module SyncJobError =
        let withError (value: string) (req: ConnectorSyncJobErrorRequest) =
            { req with Error = value }

    type ConnectorSyncJobGetRequest = {
        ConnectorSyncJobId: CoreTypes.Id
    }

        with
        static member ToRequest(req: ConnectorSyncJobGetRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobGetResponse = ConnectorTypes.ConnectorSyncJob

    type ConnectorSyncJobGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobGetRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobGetRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobGetRequest = ConnectorSyncJobGetRequestBuilder()

    type ConnectorSyncJobListRequest = {
        From: CoreTypes.Integer option
        Size: CoreTypes.Integer option
        Status: ConnectorTypes.SyncStatus option
        ConnectorId: CoreTypes.Id option
        JobType: System.Text.Json.JsonElement option
    }

        with
        static member ToRequest(req: ConnectorSyncJobListRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job"
                let queryParams =
                    [
                        req.From |> Option.map (fun v -> "from", Fes.Http.toQueryValue v)
                        req.Size |> Option.map (fun v -> "size", Fes.Http.toQueryValue v)
                        req.Status |> Option.map (fun v -> "status", Fes.Http.toQueryValue v)
                        req.ConnectorId |> Option.map (fun v -> "connector_id", Fes.Http.toQueryValue v)
                        req.JobType |> Option.map (fun v -> "job_type", Fes.Http.toQueryValue v)
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

    type ConnectorSyncJobListResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobListRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobListRequest =
            {
                From = None
                Size = None
                Status = None
                ConnectorId = None
                JobType = None
            }

        [<CustomOperation("from")>]
        member _.From(state: ConnectorSyncJobListRequest, value: CoreTypes.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: ConnectorSyncJobListRequest, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorSyncJobListRequest, value: ConnectorTypes.SyncStatus) =
            { state with Status = Some value }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorSyncJobListRequest, value: CoreTypes.Id) =
            { state with ConnectorId = Some value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: ConnectorSyncJobListRequest, value: System.Text.Json.JsonElement) =
            { state with JobType = Some value }

    let connectorSyncJobListRequest = ConnectorSyncJobListRequestBuilder()

    module SyncJobList =
        let withFrom (value: CoreTypes.Integer) (req: ConnectorSyncJobListRequest) =
            { req with From = Some value }
        let withSize (value: CoreTypes.Integer) (req: ConnectorSyncJobListRequest) =
            { req with Size = Some value }
        let withStatus (value: ConnectorTypes.SyncStatus) (req: ConnectorSyncJobListRequest) =
            { req with Status = Some value }
        let withConnectorId (value: CoreTypes.Id) (req: ConnectorSyncJobListRequest) =
            { req with ConnectorId = Some value }
        let withJobType (value: System.Text.Json.JsonElement) (req: ConnectorSyncJobListRequest) =
            { req with JobType = Some value }

    type ConnectorSyncJobPostRequest = {
        Id: CoreTypes.Id
        JobType: ConnectorTypes.SyncJobType option
        TriggerMethod: ConnectorTypes.SyncJobTriggerMethod option
    }

        with
        static member ToRequest(req: ConnectorSyncJobPostRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobPostResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobPostRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobPostRequest =
            {
                Id = Unchecked.defaultof<_>
                JobType = None
                TriggerMethod = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSyncJobPostRequest, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: ConnectorSyncJobPostRequest, value: ConnectorTypes.SyncJobType) =
            { state with JobType = Some value }

        [<CustomOperation("triggerMethod")>]
        member _.TriggerMethod(state: ConnectorSyncJobPostRequest, value: ConnectorTypes.SyncJobTriggerMethod) =
            { state with TriggerMethod = Some value }

    let connectorSyncJobPostRequest = ConnectorSyncJobPostRequestBuilder()

    module SyncJobPost =
        let withId (value: CoreTypes.Id) (req: ConnectorSyncJobPostRequest) =
            { req with Id = value }
        let withJobType (value: ConnectorTypes.SyncJobType) (req: ConnectorSyncJobPostRequest) =
            { req with JobType = Some value }
        let withTriggerMethod (value: ConnectorTypes.SyncJobTriggerMethod) (req: ConnectorSyncJobPostRequest) =
            { req with TriggerMethod = Some value }

    type ConnectorSyncJobUpdateStatsRequest = {
        ConnectorSyncJobId: CoreTypes.Id
        DeletedDocumentCount: CoreTypes.Long
        IndexedDocumentCount: CoreTypes.Long
        IndexedDocumentVolume: CoreTypes.Long
        LastSeen: CoreTypes.Duration option
        Metadata: CoreTypes.Metadata option
        TotalDocumentCount: CoreTypes.Integer option
    }

        with
        static member ToRequest(req: ConnectorSyncJobUpdateStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_stats"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorSyncJobUpdateStatsResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobUpdateStatsRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobUpdateStatsRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
                DeletedDocumentCount = Unchecked.defaultof<_>
                IndexedDocumentCount = Unchecked.defaultof<_>
                IndexedDocumentVolume = Unchecked.defaultof<_>
                LastSeen = None
                Metadata = None
                TotalDocumentCount = None
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Id) =
            { state with ConnectorSyncJobId = value }

        [<CustomOperation("deletedDocumentCount")>]
        member _.DeletedDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Long) =
            { state with DeletedDocumentCount = value }

        [<CustomOperation("indexedDocumentCount")>]
        member _.IndexedDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Long) =
            { state with IndexedDocumentCount = value }

        [<CustomOperation("indexedDocumentVolume")>]
        member _.IndexedDocumentVolume(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Long) =
            { state with IndexedDocumentVolume = value }

        [<CustomOperation("lastSeen")>]
        member _.LastSeen(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Duration) =
            { state with LastSeen = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("totalDocumentCount")>]
        member _.TotalDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: CoreTypes.Integer) =
            { state with TotalDocumentCount = Some value }

    let connectorSyncJobUpdateStatsRequest = ConnectorSyncJobUpdateStatsRequestBuilder()

    module SyncJobUpdateStats =
        let withDeletedDocumentCount (value: CoreTypes.Long) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with DeletedDocumentCount = value }
        let withIndexedDocumentCount (value: CoreTypes.Long) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with IndexedDocumentCount = value }
        let withIndexedDocumentVolume (value: CoreTypes.Long) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with IndexedDocumentVolume = value }
        let withLastSeen (value: CoreTypes.Duration) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with LastSeen = Some value }
        let withMetadata (value: CoreTypes.Metadata) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with Metadata = Some value }
        let withTotalDocumentCount (value: CoreTypes.Integer) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with TotalDocumentCount = Some value }

    type ConnectorUpdateActiveFilteringRequest = {
        ConnectorId: CoreTypes.Id
    }

        with
        static member ToRequest(req: ConnectorUpdateActiveFilteringRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_filtering/_activate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateActiveFilteringResponse = System.Text.Json.JsonElement

    type ConnectorUpdateActiveFilteringRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateActiveFilteringRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateActiveFilteringRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

    let connectorUpdateActiveFilteringRequest = ConnectorUpdateActiveFilteringRequestBuilder()

    type ConnectorUpdateApiKeyIdRequest = {
        ConnectorId: CoreTypes.Id
        ApiKeyId: string option
        ApiKeySecretId: string option
    }

        with
        static member ToRequest(req: ConnectorUpdateApiKeyIdRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_api_key_id"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateApiKeyIdResponse = System.Text.Json.JsonElement

    type ConnectorUpdateApiKeyIdRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateApiKeyIdRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                ApiKeyId = None
                ApiKeySecretId = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateApiKeyIdRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("apiKeyId")>]
        member _.ApiKeyId(state: ConnectorUpdateApiKeyIdRequest, value: string) =
            { state with ApiKeyId = Some value }

        [<CustomOperation("apiKeySecretId")>]
        member _.ApiKeySecretId(state: ConnectorUpdateApiKeyIdRequest, value: string) =
            { state with ApiKeySecretId = Some value }

    let connectorUpdateApiKeyIdRequest = ConnectorUpdateApiKeyIdRequestBuilder()

    module UpdateApiKeyId =
        let withApiKeyId (value: string) (req: ConnectorUpdateApiKeyIdRequest) =
            { req with ApiKeyId = Some value }
        let withApiKeySecretId (value: string) (req: ConnectorUpdateApiKeyIdRequest) =
            { req with ApiKeySecretId = Some value }

    type ConnectorUpdateConfigurationRequest = {
        ConnectorId: CoreTypes.Id
        Configuration: ConnectorTypes.ConnectorConfiguration option
        Values: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: ConnectorUpdateConfigurationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_configuration"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateConfigurationResponse = System.Text.Json.JsonElement

    type ConnectorUpdateConfigurationRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateConfigurationRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Configuration = None
                Values = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateConfigurationRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("configuration")>]
        member _.Configuration(state: ConnectorUpdateConfigurationRequest, value: ConnectorTypes.ConnectorConfiguration) =
            { state with Configuration = Some value }

        [<CustomOperation("values")>]
        member _.Values(state: ConnectorUpdateConfigurationRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Values = Some value }

    let connectorUpdateConfigurationRequest = ConnectorUpdateConfigurationRequestBuilder()

    module UpdateConfiguration =
        let withConfiguration (value: ConnectorTypes.ConnectorConfiguration) (req: ConnectorUpdateConfigurationRequest) =
            { req with Configuration = Some value }
        let withValues (value: Map<string, System.Text.Json.JsonElement>) (req: ConnectorUpdateConfigurationRequest) =
            { req with Values = Some value }

    type ConnectorUpdateErrorRequest = {
        ConnectorId: CoreTypes.Id
        Error: CoreTypes.WithNullValue<string>
    }

        with
        static member ToRequest(req: ConnectorUpdateErrorRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_error"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateErrorResponse = System.Text.Json.JsonElement

    type ConnectorUpdateErrorRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateErrorRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Error = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateErrorRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorUpdateErrorRequest, value: CoreTypes.WithNullValue<string>) =
            { state with Error = value }

    let connectorUpdateErrorRequest = ConnectorUpdateErrorRequestBuilder()

    module UpdateError =
        let withError (value: CoreTypes.WithNullValue<string>) (req: ConnectorUpdateErrorRequest) =
            { req with Error = value }

    type ConnectorUpdateFeaturesRequest = {
        ConnectorId: CoreTypes.Id
        Features: ConnectorTypes.ConnectorFeatures
    }

        with
        static member ToRequest(req: ConnectorUpdateFeaturesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_features"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateFeaturesResponse = System.Text.Json.JsonElement

    type ConnectorUpdateFeaturesRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFeaturesRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Features = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateFeaturesRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("features")>]
        member _.Features(state: ConnectorUpdateFeaturesRequest, value: ConnectorTypes.ConnectorFeatures) =
            { state with Features = value }

    let connectorUpdateFeaturesRequest = ConnectorUpdateFeaturesRequestBuilder()

    module UpdateFeatures =
        let withFeatures (value: ConnectorTypes.ConnectorFeatures) (req: ConnectorUpdateFeaturesRequest) =
            { req with Features = value }

    type ConnectorUpdateFilteringRequest = {
        ConnectorId: CoreTypes.Id
        Filtering: ConnectorTypes.FilteringConfig list option
        Rules: ConnectorTypes.FilteringRule list option
        AdvancedSnippet: ConnectorTypes.FilteringAdvancedSnippet option
    }

        with
        static member ToRequest(req: ConnectorUpdateFilteringRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_filtering"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateFilteringResponse = System.Text.Json.JsonElement

    type ConnectorUpdateFilteringRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFilteringRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Filtering = None
                Rules = None
                AdvancedSnippet = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateFilteringRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("filtering")>]
        member _.Filtering(state: ConnectorUpdateFilteringRequest, value: ConnectorTypes.FilteringConfig list) =
            { state with Filtering = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: ConnectorUpdateFilteringRequest, value: ConnectorTypes.FilteringRule list) =
            { state with Rules = Some value }

        [<CustomOperation("advancedSnippet")>]
        member _.AdvancedSnippet(state: ConnectorUpdateFilteringRequest, value: ConnectorTypes.FilteringAdvancedSnippet) =
            { state with AdvancedSnippet = Some value }

    let connectorUpdateFilteringRequest = ConnectorUpdateFilteringRequestBuilder()

    module UpdateFiltering =
        let withFiltering (value: ConnectorTypes.FilteringConfig list) (req: ConnectorUpdateFilteringRequest) =
            { req with Filtering = Some value }
        let withRules (value: ConnectorTypes.FilteringRule list) (req: ConnectorUpdateFilteringRequest) =
            { req with Rules = Some value }
        let withAdvancedSnippet (value: ConnectorTypes.FilteringAdvancedSnippet) (req: ConnectorUpdateFilteringRequest) =
            { req with AdvancedSnippet = Some value }

    type ConnectorUpdateFilteringValidationRequest = {
        ConnectorId: CoreTypes.Id
        Validation: ConnectorTypes.FilteringRulesValidation
    }

        with
        static member ToRequest(req: ConnectorUpdateFilteringValidationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_filtering/_validation"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateFilteringValidationResponse = System.Text.Json.JsonElement

    type ConnectorUpdateFilteringValidationRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFilteringValidationRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Validation = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateFilteringValidationRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("validation")>]
        member _.Validation(state: ConnectorUpdateFilteringValidationRequest, value: ConnectorTypes.FilteringRulesValidation) =
            { state with Validation = value }

    let connectorUpdateFilteringValidationRequest = ConnectorUpdateFilteringValidationRequestBuilder()

    module UpdateFilteringValidation =
        let withValidation (value: ConnectorTypes.FilteringRulesValidation) (req: ConnectorUpdateFilteringValidationRequest) =
            { req with Validation = value }

    type ConnectorUpdateIndexNameRequest = {
        ConnectorId: CoreTypes.Id
        IndexName: CoreTypes.WithNullValue<CoreTypes.IndexName>
    }

        with
        static member ToRequest(req: ConnectorUpdateIndexNameRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_index_name"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateIndexNameResponse = System.Text.Json.JsonElement

    type ConnectorUpdateIndexNameRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateIndexNameRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                IndexName = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateIndexNameRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorUpdateIndexNameRequest, value: CoreTypes.WithNullValue<CoreTypes.IndexName>) =
            { state with IndexName = value }

    let connectorUpdateIndexNameRequest = ConnectorUpdateIndexNameRequestBuilder()

    module UpdateIndexName =
        let withIndexName (value: CoreTypes.WithNullValue<CoreTypes.IndexName>) (req: ConnectorUpdateIndexNameRequest) =
            { req with IndexName = value }

    type ConnectorUpdateNameRequest = {
        ConnectorId: CoreTypes.Id
        Name: string option
        Description: string option
    }

        with
        static member ToRequest(req: ConnectorUpdateNameRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_name"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateNameResponse = System.Text.Json.JsonElement

    type ConnectorUpdateNameRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateNameRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Name = None
                Description = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateNameRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("name")>]
        member _.Name(state: ConnectorUpdateNameRequest, value: string) =
            { state with Name = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorUpdateNameRequest, value: string) =
            { state with Description = Some value }

    let connectorUpdateNameRequest = ConnectorUpdateNameRequestBuilder()

    module UpdateName =
        let withName (value: string) (req: ConnectorUpdateNameRequest) =
            { req with Name = Some value }
        let withDescription (value: string) (req: ConnectorUpdateNameRequest) =
            { req with Description = Some value }

    type ConnectorUpdateNativeRequest = {
        ConnectorId: CoreTypes.Id
        IsNative: bool
    }

        with
        static member ToRequest(req: ConnectorUpdateNativeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_native"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateNativeResponse = System.Text.Json.JsonElement

    type ConnectorUpdateNativeRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateNativeRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                IsNative = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateNativeRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("isNative")>]
        member _.IsNative(state: ConnectorUpdateNativeRequest, value: bool) =
            { state with IsNative = value }

    let connectorUpdateNativeRequest = ConnectorUpdateNativeRequestBuilder()

    module UpdateNative =
        let withIsNative (value: bool) (req: ConnectorUpdateNativeRequest) =
            { req with IsNative = value }

    type ConnectorUpdatePipelineRequest = {
        ConnectorId: CoreTypes.Id
        Pipeline: ConnectorTypes.IngestPipelineParams
    }

        with
        static member ToRequest(req: ConnectorUpdatePipelineRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_pipeline"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdatePipelineResponse = System.Text.Json.JsonElement

    type ConnectorUpdatePipelineRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdatePipelineRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Pipeline = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdatePipelineRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: ConnectorUpdatePipelineRequest, value: ConnectorTypes.IngestPipelineParams) =
            { state with Pipeline = value }

    let connectorUpdatePipelineRequest = ConnectorUpdatePipelineRequestBuilder()

    module UpdatePipeline =
        let withPipeline (value: ConnectorTypes.IngestPipelineParams) (req: ConnectorUpdatePipelineRequest) =
            { req with Pipeline = value }

    type ConnectorUpdateSchedulingRequest = {
        ConnectorId: CoreTypes.Id
        Scheduling: ConnectorTypes.SchedulingConfiguration
    }

        with
        static member ToRequest(req: ConnectorUpdateSchedulingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_scheduling"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateSchedulingResponse = System.Text.Json.JsonElement

    type ConnectorUpdateSchedulingRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateSchedulingRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Scheduling = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateSchedulingRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("scheduling")>]
        member _.Scheduling(state: ConnectorUpdateSchedulingRequest, value: ConnectorTypes.SchedulingConfiguration) =
            { state with Scheduling = value }

    let connectorUpdateSchedulingRequest = ConnectorUpdateSchedulingRequestBuilder()

    module UpdateScheduling =
        let withScheduling (value: ConnectorTypes.SchedulingConfiguration) (req: ConnectorUpdateSchedulingRequest) =
            { req with Scheduling = value }

    type ConnectorUpdateServiceTypeRequest = {
        ConnectorId: CoreTypes.Id
        ServiceType: string
    }

        with
        static member ToRequest(req: ConnectorUpdateServiceTypeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_service_type"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateServiceTypeResponse = System.Text.Json.JsonElement

    type ConnectorUpdateServiceTypeRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateServiceTypeRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                ServiceType = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateServiceTypeRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: ConnectorUpdateServiceTypeRequest, value: string) =
            { state with ServiceType = value }

    let connectorUpdateServiceTypeRequest = ConnectorUpdateServiceTypeRequestBuilder()

    module UpdateServiceType =
        let withServiceType (value: string) (req: ConnectorUpdateServiceTypeRequest) =
            { req with ServiceType = value }

    type ConnectorUpdateStatusRequest = {
        ConnectorId: CoreTypes.Id
        Status: ConnectorTypes.ConnectorStatus
    }

        with
        static member ToRequest(req: ConnectorUpdateStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_connector/{req.ConnectorId}/_status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type ConnectorUpdateStatusResponse = System.Text.Json.JsonElement

    type ConnectorUpdateStatusRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateStatusRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateStatusRequest, value: CoreTypes.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorUpdateStatusRequest, value: ConnectorTypes.ConnectorStatus) =
            { state with Status = value }

    let connectorUpdateStatusRequest = ConnectorUpdateStatusRequestBuilder()

    module UpdateStatus =
        let withStatus (value: ConnectorTypes.ConnectorStatus) (req: ConnectorUpdateStatusRequest) =
            { req with Status = value }

