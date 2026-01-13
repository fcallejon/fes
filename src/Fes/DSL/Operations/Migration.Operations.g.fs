// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module MigrationOperations =

    type IndicesCancelMigrateReindexRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
    } with
        static member ToRequest(request: IndicesCancelMigrateReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/reindex/{request.Index}/_cancel"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesCancelMigrateReindexRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesCancelMigrateReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesCancelMigrateReindexRequest.ToRequest request

    type IndicesCancelMigrateReindexRequestBuilder() =
        member _.Yield(_: unit) : IndicesCancelMigrateReindexRequest =
            {
                IndicesCancelMigrateReindexRequest.Index = Unchecked.defaultof<Indices>
            } : IndicesCancelMigrateReindexRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesCancelMigrateReindexRequest, value: Indices) =
            { state with IndicesCancelMigrateReindexRequest.Index = value } : IndicesCancelMigrateReindexRequest

    let indicesCancelMigrateReindexRequest = IndicesCancelMigrateReindexRequestBuilder()

    type IndicesCancelMigrateReindexResponse = AcknowledgedResponseBase

    type IndicesCreateFromRequest = {
        [<JsonPropertyName("source")>]
        Source: IndexName
        [<JsonPropertyName("dest")>]
        Dest: IndexName
        [<JsonPropertyName("body")>]
        Body: CreateFromCreateFrom
    } with
        static member ToRequest(request: IndicesCreateFromRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_create_from/{request.Source}/{request.Dest}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesCreateFromRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesCreateFromRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesCreateFromRequest.ToRequest request

    type IndicesCreateFromRequestBuilder() =
        member _.Yield(_: unit) : IndicesCreateFromRequest =
            {
                IndicesCreateFromRequest.Source = Unchecked.defaultof<IndexName>
                IndicesCreateFromRequest.Dest = Unchecked.defaultof<IndexName>
                IndicesCreateFromRequest.Body = Unchecked.defaultof<CreateFromCreateFrom>
            } : IndicesCreateFromRequest

        [<CustomOperation("source")>]
        member _.Source(state: IndicesCreateFromRequest, value: IndexName) =
            { state with IndicesCreateFromRequest.Source = value } : IndicesCreateFromRequest

        [<CustomOperation("dest")>]
        member _.Dest(state: IndicesCreateFromRequest, value: IndexName) =
            { state with IndicesCreateFromRequest.Dest = value } : IndicesCreateFromRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesCreateFromRequest, value: CreateFromCreateFrom) =
            { state with IndicesCreateFromRequest.Body = value } : IndicesCreateFromRequest

    let indicesCreateFromRequest = IndicesCreateFromRequestBuilder()

    type IndicesGetMigrateReindexStatusRequest = {
        [<JsonPropertyName("index")>]
        Index: Indices
    } with
        static member ToRequest(request: IndicesGetMigrateReindexStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/reindex/{request.Index}/_status"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module IndicesGetMigrateReindexStatusRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: IndicesGetMigrateReindexStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            IndicesGetMigrateReindexStatusRequest.ToRequest request

    type IndicesGetMigrateReindexStatusRequestBuilder() =
        member _.Yield(_: unit) : IndicesGetMigrateReindexStatusRequest =
            {
                IndicesGetMigrateReindexStatusRequest.Index = Unchecked.defaultof<Indices>
            } : IndicesGetMigrateReindexStatusRequest

        [<CustomOperation("index")>]
        member _.Index(state: IndicesGetMigrateReindexStatusRequest, value: Indices) =
            { state with IndicesGetMigrateReindexStatusRequest.Index = value } : IndicesGetMigrateReindexStatusRequest

    let indicesGetMigrateReindexStatusRequest = IndicesGetMigrateReindexStatusRequestBuilder()

    type IndicesGetMigrateReindexStatusResponse = {
        [<JsonPropertyName("start_time")>]
        StartTime: DateTime option
        [<JsonPropertyName("start_time_millis")>]
        StartTimeMillis: EpochTimeUnitMillis
        [<JsonPropertyName("complete")>]
        Complete: bool
        [<JsonPropertyName("total_indices_in_data_stream")>]
        TotalIndicesInDataStream: float
        [<JsonPropertyName("total_indices_requiring_upgrade")>]
        TotalIndicesRequiringUpgrade: float
        [<JsonPropertyName("successes")>]
        Successes: float
        [<JsonPropertyName("in_progress")>]
        InProgress: GetMigrateReindexStatusStatusInProgress array
        [<JsonPropertyName("pending")>]
        Pending: float
        [<JsonPropertyName("errors")>]
        Errors: GetMigrateReindexStatusStatusError array
        [<JsonPropertyName("exception")>]
        Exception: string option
    }

    type IndicesMigrateReindexRequest = {
        [<JsonPropertyName("body")>]
        Body: MigrateReindexMigrateReindex
    } with
        static member ToRequest(request: IndicesMigrateReindexRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_migration/reindex"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody request.Body
                |> Result.Ok
            with ex -> Result.Error ex

    type IndicesMigrateReindexRequestBuilder() =
        member _.Yield(_: unit) : IndicesMigrateReindexRequest =
            {
                IndicesMigrateReindexRequest.Body = Unchecked.defaultof<MigrateReindexMigrateReindex>
            } : IndicesMigrateReindexRequest

        [<CustomOperation("body")>]
        member _.Body(state: IndicesMigrateReindexRequest, value: MigrateReindexMigrateReindex) =
            { state with IndicesMigrateReindexRequest.Body = value } : IndicesMigrateReindexRequest

    let indicesMigrateReindexRequest = IndicesMigrateReindexRequestBuilder()

    type IndicesMigrateReindexResponse = AcknowledgedResponseBase

    type MigrationDeprecationsRequest = {
        [<JsonPropertyName("index")>]
        Index: IndexName
    } with
        static member ToRequest(request: MigrationDeprecationsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{request.Index}/_migration/deprecations"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module MigrationDeprecationsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: MigrationDeprecationsRequest) : Result<Fes.Http.RequestMsg, exn> =
            MigrationDeprecationsRequest.ToRequest request

    type MigrationDeprecationsRequestBuilder() =
        member _.Yield(_: unit) : MigrationDeprecationsRequest =
            {
                MigrationDeprecationsRequest.Index = Unchecked.defaultof<IndexName>
            } : MigrationDeprecationsRequest

        [<CustomOperation("index")>]
        member _.Index(state: MigrationDeprecationsRequest, value: IndexName) =
            { state with MigrationDeprecationsRequest.Index = value } : MigrationDeprecationsRequest

    let migrationDeprecationsRequest = MigrationDeprecationsRequestBuilder()

    type MigrationGetFeatureUpgradeStatusRequest = unit

    let migrationGetFeatureUpgradeStatusRequest = ()

    type MigrationGetFeatureUpgradeStatusResponse = {
        [<JsonPropertyName("features")>]
        Features: GetFeatureUpgradeStatusMigrationFeature array
        [<JsonPropertyName("migration_status")>]
        MigrationStatus: GetFeatureUpgradeStatusMigrationStatus
    }

    type MigrationPostFeatureUpgradeRequest = unit

    let migrationPostFeatureUpgradeRequest = ()

    type MigrationPostFeatureUpgradeResponse = {
        [<JsonPropertyName("accepted")>]
        Accepted: bool
        [<JsonPropertyName("features")>]
        Features: PostFeatureUpgradeMigrationFeature array option
        [<JsonPropertyName("reason")>]
        Reason: string option
    }

