// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module ConnectorOperations =

    type ConnectorCheckInRequest = {
        ConnectorId: Types.Id
    }

        with
        static member ToEndpoint(req: ConnectorCheckInRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_check_in"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type ConnectorCheckInResponse = System.Text.Json.JsonElement

    type ConnectorCheckInRequestBuilder() =
        member _.Yield(_: unit) : ConnectorCheckInRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorCheckInRequest, value: Types.Id) =
            { state with ConnectorId = value }

    let connectorCheckInRequest = ConnectorCheckInRequestBuilder()

    type ConnectorDeleteRequest = {
        ConnectorId: Types.Id
        DeleteSyncJobs: bool option
        Hard: bool option
    }

        with
        static member ToEndpoint(req: ConnectorDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type ConnectorDeleteResponse = Types.AcknowledgedResponseBase

    type ConnectorDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorDeleteRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                DeleteSyncJobs = None
                Hard = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorDeleteRequest, value: Types.Id) =
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
        ConnectorId: Types.Id
        IncludeDeleted: bool option
    }

        with
        static member ToEndpoint(req: ConnectorGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}"
            let queryParams =
                [
                    req.IncludeDeleted |> Option.map (fun v -> "include_deleted", Fes.Http.toQueryValue v)
                ] |> List.choose id
            let queryString =
                if List.isEmpty queryParams then ""
                else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
            let fullPath = path + queryString
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type ConnectorGetResponse = Types.Connector

    type ConnectorGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorGetRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                IncludeDeleted = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorGetRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("includeDeleted")>]
        member _.IncludeDeleted(state: ConnectorGetRequest, value: bool) =
            { state with IncludeDeleted = Some value }

    let connectorGetRequest = ConnectorGetRequestBuilder()

    module Get =
        let withIncludeDeleted (value: bool) (req: ConnectorGetRequest) =
            { req with IncludeDeleted = Some value }

    type ConnectorLastSyncRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_error")>]
        LastAccessControlSyncError: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_scheduled_at")>]
        LastAccessControlSyncScheduledAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_status")>]
        LastAccessControlSyncStatus: Types.SyncStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("last_deleted_document_count")>]
        LastDeletedDocumentCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_incremental_sync_scheduled_at")>]
        LastIncrementalSyncScheduledAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_indexed_document_count")>]
        LastIndexedDocumentCount: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_seen")>]
        LastSeen: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_sync_error")>]
        LastSyncError: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_sync_scheduled_at")>]
        LastSyncScheduledAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_sync_status")>]
        LastSyncStatus: Types.SyncStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("last_synced")>]
        LastSynced: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("sync_cursor")>]
        SyncCursor: System.Text.Json.JsonElement option
    }

        with
        static member ToEndpoint(req: ConnectorLastSyncRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_last_sync"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.ConnectorId(state: ConnectorLastSyncRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("lastAccessControlSyncError")>]
        member _.LastAccessControlSyncError(state: ConnectorLastSyncRequest, value: string) =
            { state with LastAccessControlSyncError = Some value }

        [<CustomOperation("lastAccessControlSyncScheduledAt")>]
        member _.LastAccessControlSyncScheduledAt(state: ConnectorLastSyncRequest, value: Types.DateTime) =
            { state with LastAccessControlSyncScheduledAt = Some value }

        [<CustomOperation("lastAccessControlSyncStatus")>]
        member _.LastAccessControlSyncStatus(state: ConnectorLastSyncRequest, value: Types.SyncStatus) =
            { state with LastAccessControlSyncStatus = Some value }

        [<CustomOperation("lastDeletedDocumentCount")>]
        member _.LastDeletedDocumentCount(state: ConnectorLastSyncRequest, value: Types.Long) =
            { state with LastDeletedDocumentCount = Some value }

        [<CustomOperation("lastIncrementalSyncScheduledAt")>]
        member _.LastIncrementalSyncScheduledAt(state: ConnectorLastSyncRequest, value: Types.DateTime) =
            { state with LastIncrementalSyncScheduledAt = Some value }

        [<CustomOperation("lastIndexedDocumentCount")>]
        member _.LastIndexedDocumentCount(state: ConnectorLastSyncRequest, value: Types.Long) =
            { state with LastIndexedDocumentCount = Some value }

        [<CustomOperation("lastSeen")>]
        member _.LastSeen(state: ConnectorLastSyncRequest, value: Types.DateTime) =
            { state with LastSeen = Some value }

        [<CustomOperation("lastSyncError")>]
        member _.LastSyncError(state: ConnectorLastSyncRequest, value: string) =
            { state with LastSyncError = Some value }

        [<CustomOperation("lastSyncScheduledAt")>]
        member _.LastSyncScheduledAt(state: ConnectorLastSyncRequest, value: Types.DateTime) =
            { state with LastSyncScheduledAt = Some value }

        [<CustomOperation("lastSyncStatus")>]
        member _.LastSyncStatus(state: ConnectorLastSyncRequest, value: Types.SyncStatus) =
            { state with LastSyncStatus = Some value }

        [<CustomOperation("lastSynced")>]
        member _.LastSynced(state: ConnectorLastSyncRequest, value: Types.DateTime) =
            { state with LastSynced = Some value }

        [<CustomOperation("syncCursor")>]
        member _.SyncCursor(state: ConnectorLastSyncRequest, value: System.Text.Json.JsonElement) =
            { state with SyncCursor = Some value }

    let connectorLastSyncRequest = ConnectorLastSyncRequestBuilder()

    module LastSync =
        let withLastAccessControlSyncError (value: string) (req: ConnectorLastSyncRequest) =
            { req with LastAccessControlSyncError = Some value }
        let withLastAccessControlSyncScheduledAt (value: Types.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastAccessControlSyncScheduledAt = Some value }
        let withLastAccessControlSyncStatus (value: Types.SyncStatus) (req: ConnectorLastSyncRequest) =
            { req with LastAccessControlSyncStatus = Some value }
        let withLastDeletedDocumentCount (value: Types.Long) (req: ConnectorLastSyncRequest) =
            { req with LastDeletedDocumentCount = Some value }
        let withLastIncrementalSyncScheduledAt (value: Types.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastIncrementalSyncScheduledAt = Some value }
        let withLastIndexedDocumentCount (value: Types.Long) (req: ConnectorLastSyncRequest) =
            { req with LastIndexedDocumentCount = Some value }
        let withLastSeen (value: Types.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastSeen = Some value }
        let withLastSyncError (value: string) (req: ConnectorLastSyncRequest) =
            { req with LastSyncError = Some value }
        let withLastSyncScheduledAt (value: Types.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastSyncScheduledAt = Some value }
        let withLastSyncStatus (value: Types.SyncStatus) (req: ConnectorLastSyncRequest) =
            { req with LastSyncStatus = Some value }
        let withLastSynced (value: Types.DateTime) (req: ConnectorLastSyncRequest) =
            { req with LastSynced = Some value }
        let withSyncCursor (value: System.Text.Json.JsonElement) (req: ConnectorLastSyncRequest) =
            { req with SyncCursor = Some value }

    type ConnectorListRequest = {
        From: Types.Integer option
        Size: Types.Integer option
        IndexName: Types.Indices option
        ConnectorName: Types.Names option
        ServiceType: Types.Names option
        IncludeDeleted: bool option
        Query: string option
    }

        with
        static member ToEndpoint(req: ConnectorListRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.From(state: ConnectorListRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: ConnectorListRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorListRequest, value: Types.Indices) =
            { state with IndexName = Some value }

        [<CustomOperation("connectorName")>]
        member _.ConnectorName(state: ConnectorListRequest, value: Types.Names) =
            { state with ConnectorName = Some value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: ConnectorListRequest, value: Types.Names) =
            { state with ServiceType = Some value }

        [<CustomOperation("includeDeleted")>]
        member _.IncludeDeleted(state: ConnectorListRequest, value: bool) =
            { state with IncludeDeleted = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: ConnectorListRequest, value: string) =
            { state with Query = Some value }

    let connectorListRequest = ConnectorListRequestBuilder()

    module List =
        let withFrom (value: Types.Integer) (req: ConnectorListRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: ConnectorListRequest) =
            { req with Size = Some value }
        let withIndexName (value: Types.Indices) (req: ConnectorListRequest) =
            { req with IndexName = Some value }
        let withConnectorName (value: Types.Names) (req: ConnectorListRequest) =
            { req with ConnectorName = Some value }
        let withServiceType (value: Types.Names) (req: ConnectorListRequest) =
            { req with ServiceType = Some value }
        let withIncludeDeleted (value: bool) (req: ConnectorListRequest) =
            { req with IncludeDeleted = Some value }
        let withQuery (value: string) (req: ConnectorListRequest) =
            { req with Query = Some value }

    type ConnectorPostRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("is_native")>]
        IsNative: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("service_type")>]
        ServiceType: string option
    }

        with
        static member ToEndpoint(req: ConnectorPostRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.IndexName(state: ConnectorPostRequest, value: Types.IndexName) =
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
        let withIndexName (value: Types.IndexName) (req: ConnectorPostRequest) =
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
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("is_native")>]
        IsNative: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("service_type")>]
        ServiceType: string option
    }

        with
        static member ToEndpoint(req: ConnectorPutRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.ConnectorId(state: ConnectorPutRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("description")>]
        member _.Description(state: ConnectorPutRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorPutRequest, value: Types.IndexName) =
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
        let withIndexName (value: Types.IndexName) (req: ConnectorPutRequest) =
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
        static member ToEndpoint(req: ConnectorSecretDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_secret/{req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

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
        static member ToEndpoint(req: ConnectorSecretGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_secret/{req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string option
    }

        with
        static member ToEndpoint(req: ConnectorSecretPostRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_secret"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

        with
        static member ToEndpoint(req: ConnectorSecretPutRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_secret/{req.Id}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        ConnectorSyncJobId: Types.Id
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobCancelRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_cancel"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type ConnectorSyncJobCancelResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobCancelRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobCancelRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobCancelRequest, value: Types.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobCancelRequest = ConnectorSyncJobCancelRequestBuilder()

    type ConnectorSyncJobCheckInRequest = {
        ConnectorSyncJobId: Types.Id
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobCheckInRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_check_in"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type ConnectorSyncJobCheckInResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobCheckInRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobCheckInRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobCheckInRequest, value: Types.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobCheckInRequest = ConnectorSyncJobCheckInRequestBuilder()

    type ConnectorSyncJobClaimRequest = {
        ConnectorSyncJobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("sync_cursor")>]
        SyncCursor: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("worker_hostname")>]
        WorkerHostname: string
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobClaimRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_claim"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorSyncJobClaimResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobClaimRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobClaimRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
                SyncCursor = None
                WorkerHostname = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobClaimRequest, value: Types.Id) =
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
        ConnectorSyncJobId: Types.Id
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobDeleteRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.DELETE, fullPath)
            endpoint, ValueNone

    type ConnectorSyncJobDeleteResponse = Types.AcknowledgedResponseBase

    type ConnectorSyncJobDeleteRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobDeleteRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobDeleteRequest, value: Types.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobDeleteRequest = ConnectorSyncJobDeleteRequestBuilder()

    type ConnectorSyncJobErrorRequest = {
        ConnectorSyncJobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobErrorRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_error"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorSyncJobErrorResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobErrorRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobErrorRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
                Error = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobErrorRequest, value: Types.Id) =
            { state with ConnectorSyncJobId = value }

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorSyncJobErrorRequest, value: string) =
            { state with Error = value }

    let connectorSyncJobErrorRequest = ConnectorSyncJobErrorRequestBuilder()

    module SyncJobError =
        let withError (value: string) (req: ConnectorSyncJobErrorRequest) =
            { req with Error = value }

    type ConnectorSyncJobGetRequest = {
        ConnectorSyncJobId: Types.Id
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobGetRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type ConnectorSyncJobGetResponse = Types.ConnectorSyncJob

    type ConnectorSyncJobGetRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobGetRequest =
            {
                ConnectorSyncJobId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorSyncJobId")>]
        member _.ConnectorSyncJobId(state: ConnectorSyncJobGetRequest, value: Types.Id) =
            { state with ConnectorSyncJobId = value }

    let connectorSyncJobGetRequest = ConnectorSyncJobGetRequestBuilder()

    type ConnectorSyncJobListRequest = {
        From: Types.Integer option
        Size: Types.Integer option
        Status: Types.SyncStatus option
        ConnectorId: Types.Id option
        JobType: System.Text.Json.JsonElement option
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobListRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
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
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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
        member _.From(state: ConnectorSyncJobListRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: ConnectorSyncJobListRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorSyncJobListRequest, value: Types.SyncStatus) =
            { state with Status = Some value }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorSyncJobListRequest, value: Types.Id) =
            { state with ConnectorId = Some value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: ConnectorSyncJobListRequest, value: System.Text.Json.JsonElement) =
            { state with JobType = Some value }

    let connectorSyncJobListRequest = ConnectorSyncJobListRequestBuilder()

    module SyncJobList =
        let withFrom (value: Types.Integer) (req: ConnectorSyncJobListRequest) =
            { req with From = Some value }
        let withSize (value: Types.Integer) (req: ConnectorSyncJobListRequest) =
            { req with Size = Some value }
        let withStatus (value: Types.SyncStatus) (req: ConnectorSyncJobListRequest) =
            { req with Status = Some value }
        let withConnectorId (value: Types.Id) (req: ConnectorSyncJobListRequest) =
            { req with ConnectorId = Some value }
        let withJobType (value: System.Text.Json.JsonElement) (req: ConnectorSyncJobListRequest) =
            { req with JobType = Some value }

    type ConnectorSyncJobPostRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: Types.SyncJobType option
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_method")>]
        TriggerMethod: Types.SyncJobTriggerMethod option
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobPostRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorSyncJobPostResponse = System.Text.Json.JsonElement

    type ConnectorSyncJobPostRequestBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJobPostRequest =
            {
                Id = Unchecked.defaultof<_>
                JobType = None
                TriggerMethod = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSyncJobPostRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: ConnectorSyncJobPostRequest, value: Types.SyncJobType) =
            { state with JobType = Some value }

        [<CustomOperation("triggerMethod")>]
        member _.TriggerMethod(state: ConnectorSyncJobPostRequest, value: Types.SyncJobTriggerMethod) =
            { state with TriggerMethod = Some value }

    let connectorSyncJobPostRequest = ConnectorSyncJobPostRequestBuilder()

    module SyncJobPost =
        let withId (value: Types.Id) (req: ConnectorSyncJobPostRequest) =
            { req with Id = value }
        let withJobType (value: Types.SyncJobType) (req: ConnectorSyncJobPostRequest) =
            { req with JobType = Some value }
        let withTriggerMethod (value: Types.SyncJobTriggerMethod) (req: ConnectorSyncJobPostRequest) =
            { req with TriggerMethod = Some value }

    type ConnectorSyncJobUpdateStatsRequest = {
        ConnectorSyncJobId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("deleted_document_count")>]
        DeletedDocumentCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_document_count")>]
        IndexedDocumentCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_document_volume")>]
        IndexedDocumentVolume: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("last_seen")>]
        LastSeen: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("total_document_count")>]
        TotalDocumentCount: Types.Integer option
    }

        with
        static member ToEndpoint(req: ConnectorSyncJobUpdateStatsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/_sync_job/{req.ConnectorSyncJobId}/_stats"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.ConnectorSyncJobId(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Id) =
            { state with ConnectorSyncJobId = value }

        [<CustomOperation("deletedDocumentCount")>]
        member _.DeletedDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Long) =
            { state with DeletedDocumentCount = value }

        [<CustomOperation("indexedDocumentCount")>]
        member _.IndexedDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Long) =
            { state with IndexedDocumentCount = value }

        [<CustomOperation("indexedDocumentVolume")>]
        member _.IndexedDocumentVolume(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Long) =
            { state with IndexedDocumentVolume = value }

        [<CustomOperation("lastSeen")>]
        member _.LastSeen(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Duration) =
            { state with LastSeen = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("totalDocumentCount")>]
        member _.TotalDocumentCount(state: ConnectorSyncJobUpdateStatsRequest, value: Types.Integer) =
            { state with TotalDocumentCount = Some value }

    let connectorSyncJobUpdateStatsRequest = ConnectorSyncJobUpdateStatsRequestBuilder()

    module SyncJobUpdateStats =
        let withDeletedDocumentCount (value: Types.Long) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with DeletedDocumentCount = value }
        let withIndexedDocumentCount (value: Types.Long) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with IndexedDocumentCount = value }
        let withIndexedDocumentVolume (value: Types.Long) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with IndexedDocumentVolume = value }
        let withLastSeen (value: Types.Duration) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with LastSeen = Some value }
        let withMetadata (value: Types.Metadata) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with Metadata = Some value }
        let withTotalDocumentCount (value: Types.Integer) (req: ConnectorSyncJobUpdateStatsRequest) =
            { req with TotalDocumentCount = Some value }

    type ConnectorUpdateActiveFilteringRequest = {
        ConnectorId: Types.Id
    }

        with
        static member ToEndpoint(req: ConnectorUpdateActiveFilteringRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_filtering/_activate"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            endpoint, ValueNone

    type ConnectorUpdateActiveFilteringResponse = System.Text.Json.JsonElement

    type ConnectorUpdateActiveFilteringRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateActiveFilteringRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateActiveFilteringRequest, value: Types.Id) =
            { state with ConnectorId = value }

    let connectorUpdateActiveFilteringRequest = ConnectorUpdateActiveFilteringRequestBuilder()

    type ConnectorUpdateApiKeyIdRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("api_key_id")>]
        ApiKeyId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("api_key_secret_id")>]
        ApiKeySecretId: string option
    }

        with
        static member ToEndpoint(req: ConnectorUpdateApiKeyIdRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_api_key_id"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateApiKeyIdResponse = System.Text.Json.JsonElement

    type ConnectorUpdateApiKeyIdRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateApiKeyIdRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                ApiKeyId = None
                ApiKeySecretId = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateApiKeyIdRequest, value: Types.Id) =
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
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("configuration")>]
        Configuration: Types.ConnectorConfiguration option
        [<System.Text.Json.Serialization.JsonPropertyName("values")>]
        Values: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToEndpoint(req: ConnectorUpdateConfigurationRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_configuration"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateConfigurationResponse = System.Text.Json.JsonElement

    type ConnectorUpdateConfigurationRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateConfigurationRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Configuration = None
                Values = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateConfigurationRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("configuration")>]
        member _.Configuration(state: ConnectorUpdateConfigurationRequest, value: Types.ConnectorConfiguration) =
            { state with Configuration = Some value }

        [<CustomOperation("values")>]
        member _.Values(state: ConnectorUpdateConfigurationRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Values = Some value }

    let connectorUpdateConfigurationRequest = ConnectorUpdateConfigurationRequestBuilder()

    module UpdateConfiguration =
        let withConfiguration (value: Types.ConnectorConfiguration) (req: ConnectorUpdateConfigurationRequest) =
            { req with Configuration = Some value }
        let withValues (value: Map<string, System.Text.Json.JsonElement>) (req: ConnectorUpdateConfigurationRequest) =
            { req with Values = Some value }

    type ConnectorUpdateErrorRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.WithNullValue<string>
    }

        with
        static member ToEndpoint(req: ConnectorUpdateErrorRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_error"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateErrorResponse = System.Text.Json.JsonElement

    type ConnectorUpdateErrorRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateErrorRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Error = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateErrorRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorUpdateErrorRequest, value: Types.WithNullValue<string>) =
            { state with Error = value }

    let connectorUpdateErrorRequest = ConnectorUpdateErrorRequestBuilder()

    module UpdateError =
        let withError (value: Types.WithNullValue<string>) (req: ConnectorUpdateErrorRequest) =
            { req with Error = value }

    type ConnectorUpdateFeaturesRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: Types.ConnectorFeatures
    }

        with
        static member ToEndpoint(req: ConnectorUpdateFeaturesRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_features"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateFeaturesResponse = System.Text.Json.JsonElement

    type ConnectorUpdateFeaturesRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFeaturesRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Features = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateFeaturesRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("features")>]
        member _.Features(state: ConnectorUpdateFeaturesRequest, value: Types.ConnectorFeatures) =
            { state with Features = value }

    let connectorUpdateFeaturesRequest = ConnectorUpdateFeaturesRequestBuilder()

    module UpdateFeatures =
        let withFeatures (value: Types.ConnectorFeatures) (req: ConnectorUpdateFeaturesRequest) =
            { req with Features = value }

    type ConnectorUpdateFilteringRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("filtering")>]
        Filtering: Types.FilteringConfig list option
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: Types.FilteringRule list option
        [<System.Text.Json.Serialization.JsonPropertyName("advanced_snippet")>]
        AdvancedSnippet: Types.FilteringAdvancedSnippet option
    }

        with
        static member ToEndpoint(req: ConnectorUpdateFilteringRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_filtering"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

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
        member _.ConnectorId(state: ConnectorUpdateFilteringRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("filtering")>]
        member _.Filtering(state: ConnectorUpdateFilteringRequest, value: Types.FilteringConfig list) =
            { state with Filtering = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: ConnectorUpdateFilteringRequest, value: Types.FilteringRule list) =
            { state with Rules = Some value }

        [<CustomOperation("advancedSnippet")>]
        member _.AdvancedSnippet(state: ConnectorUpdateFilteringRequest, value: Types.FilteringAdvancedSnippet) =
            { state with AdvancedSnippet = Some value }

    let connectorUpdateFilteringRequest = ConnectorUpdateFilteringRequestBuilder()

    module UpdateFiltering =
        let withFiltering (value: Types.FilteringConfig list) (req: ConnectorUpdateFilteringRequest) =
            { req with Filtering = Some value }
        let withRules (value: Types.FilteringRule list) (req: ConnectorUpdateFilteringRequest) =
            { req with Rules = Some value }
        let withAdvancedSnippet (value: Types.FilteringAdvancedSnippet) (req: ConnectorUpdateFilteringRequest) =
            { req with AdvancedSnippet = Some value }

    type ConnectorUpdateFilteringValidationRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("validation")>]
        Validation: Types.FilteringRulesValidation
    }

        with
        static member ToEndpoint(req: ConnectorUpdateFilteringValidationRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_filtering/_validation"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateFilteringValidationResponse = System.Text.Json.JsonElement

    type ConnectorUpdateFilteringValidationRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateFilteringValidationRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Validation = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateFilteringValidationRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("validation")>]
        member _.Validation(state: ConnectorUpdateFilteringValidationRequest, value: Types.FilteringRulesValidation) =
            { state with Validation = value }

    let connectorUpdateFilteringValidationRequest = ConnectorUpdateFilteringValidationRequestBuilder()

    module UpdateFilteringValidation =
        let withValidation (value: Types.FilteringRulesValidation) (req: ConnectorUpdateFilteringValidationRequest) =
            { req with Validation = value }

    type ConnectorUpdateIndexNameRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: Types.WithNullValue<Types.IndexName>
    }

        with
        static member ToEndpoint(req: ConnectorUpdateIndexNameRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_index_name"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateIndexNameResponse = System.Text.Json.JsonElement

    type ConnectorUpdateIndexNameRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateIndexNameRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                IndexName = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateIndexNameRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: ConnectorUpdateIndexNameRequest, value: Types.WithNullValue<Types.IndexName>) =
            { state with IndexName = value }

    let connectorUpdateIndexNameRequest = ConnectorUpdateIndexNameRequestBuilder()

    module UpdateIndexName =
        let withIndexName (value: Types.WithNullValue<Types.IndexName>) (req: ConnectorUpdateIndexNameRequest) =
            { req with IndexName = value }

    type ConnectorUpdateNameRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
    }

        with
        static member ToEndpoint(req: ConnectorUpdateNameRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_name"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateNameResponse = System.Text.Json.JsonElement

    type ConnectorUpdateNameRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateNameRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Name = None
                Description = None
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateNameRequest, value: Types.Id) =
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
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("is_native")>]
        IsNative: bool
    }

        with
        static member ToEndpoint(req: ConnectorUpdateNativeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_native"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateNativeResponse = System.Text.Json.JsonElement

    type ConnectorUpdateNativeRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateNativeRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                IsNative = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateNativeRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("isNative")>]
        member _.IsNative(state: ConnectorUpdateNativeRequest, value: bool) =
            { state with IsNative = value }

    let connectorUpdateNativeRequest = ConnectorUpdateNativeRequestBuilder()

    module UpdateNative =
        let withIsNative (value: bool) (req: ConnectorUpdateNativeRequest) =
            { req with IsNative = value }

    type ConnectorUpdatePipelineRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: Types.IngestPipelineParams
    }

        with
        static member ToEndpoint(req: ConnectorUpdatePipelineRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_pipeline"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdatePipelineResponse = System.Text.Json.JsonElement

    type ConnectorUpdatePipelineRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdatePipelineRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Pipeline = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdatePipelineRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: ConnectorUpdatePipelineRequest, value: Types.IngestPipelineParams) =
            { state with Pipeline = value }

    let connectorUpdatePipelineRequest = ConnectorUpdatePipelineRequestBuilder()

    module UpdatePipeline =
        let withPipeline (value: Types.IngestPipelineParams) (req: ConnectorUpdatePipelineRequest) =
            { req with Pipeline = value }

    type ConnectorUpdateSchedulingRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("scheduling")>]
        Scheduling: Types.SchedulingConfiguration
    }

        with
        static member ToEndpoint(req: ConnectorUpdateSchedulingRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_scheduling"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateSchedulingResponse = System.Text.Json.JsonElement

    type ConnectorUpdateSchedulingRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateSchedulingRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Scheduling = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateSchedulingRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("scheduling")>]
        member _.Scheduling(state: ConnectorUpdateSchedulingRequest, value: Types.SchedulingConfiguration) =
            { state with Scheduling = value }

    let connectorUpdateSchedulingRequest = ConnectorUpdateSchedulingRequestBuilder()

    module UpdateScheduling =
        let withScheduling (value: Types.SchedulingConfiguration) (req: ConnectorUpdateSchedulingRequest) =
            { req with Scheduling = value }

    type ConnectorUpdateServiceTypeRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("service_type")>]
        ServiceType: string
    }

        with
        static member ToEndpoint(req: ConnectorUpdateServiceTypeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_service_type"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateServiceTypeResponse = System.Text.Json.JsonElement

    type ConnectorUpdateServiceTypeRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateServiceTypeRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                ServiceType = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateServiceTypeRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: ConnectorUpdateServiceTypeRequest, value: string) =
            { state with ServiceType = value }

    let connectorUpdateServiceTypeRequest = ConnectorUpdateServiceTypeRequestBuilder()

    module UpdateServiceType =
        let withServiceType (value: string) (req: ConnectorUpdateServiceTypeRequest) =
            { req with ServiceType = value }

    type ConnectorUpdateStatusRequest = {
        ConnectorId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.ConnectorStatus
    }

        with
        static member ToEndpoint(req: ConnectorUpdateStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_connector/{req.ConnectorId}/_status"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.PUT, fullPath)
            let postData = Elastic.Transport.PostData.String(Fes.Json.serialize req)
            endpoint, ValueSome postData

    type ConnectorUpdateStatusResponse = System.Text.Json.JsonElement

    type ConnectorUpdateStatusRequestBuilder() =
        member _.Yield(_: unit) : ConnectorUpdateStatusRequest =
            {
                ConnectorId = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
            }

        [<CustomOperation("connectorId")>]
        member _.ConnectorId(state: ConnectorUpdateStatusRequest, value: Types.Id) =
            { state with ConnectorId = value }

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorUpdateStatusRequest, value: Types.ConnectorStatus) =
            { state with Status = value }

    let connectorUpdateStatusRequest = ConnectorUpdateStatusRequestBuilder()

    module UpdateStatus =
        let withStatus (value: Types.ConnectorStatus) (req: ConnectorUpdateStatusRequest) =
            { req with Status = value }

