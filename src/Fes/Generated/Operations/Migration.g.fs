// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes

[<AutoOpen>]
module MigrationOperations =

    type MigrationDeprecationsRequest = {
        Index: Types.IndexName
    }

        with
        static member ToRequest(req: MigrationDeprecationsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/{req.Index}/_migration/deprecations"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type MigrationDeprecationsResponse = System.Text.Json.JsonElement

    type MigrationDeprecationsRequestBuilder() =
        member _.Yield(_: unit) : MigrationDeprecationsRequest =
            {
                Index = Unchecked.defaultof<_>
            }

        [<CustomOperation("index")>]
        member _.Index(state: MigrationDeprecationsRequest, value: Types.IndexName) =
            { state with Index = value }

    let migrationDeprecationsRequest = MigrationDeprecationsRequestBuilder()

    type MigrationGetFeatureUpgradeStatusRequest = {
    }

        with
        static member ToRequest(req: MigrationGetFeatureUpgradeStatusRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/system_features"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type MigrationGetFeatureUpgradeStatusResponse = System.Text.Json.JsonElement

    type MigrationGetFeatureUpgradeStatusRequestBuilder() =
        member _.Yield(_: unit) : MigrationGetFeatureUpgradeStatusRequest =
            {
            }

    let migrationGetFeatureUpgradeStatusRequest = MigrationGetFeatureUpgradeStatusRequestBuilder()

    type MigrationPostFeatureUpgradeRequest = {
    }

        with
        static member ToRequest(req: MigrationPostFeatureUpgradeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_migration/system_features"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type MigrationPostFeatureUpgradeResponse = System.Text.Json.JsonElement

    type MigrationPostFeatureUpgradeRequestBuilder() =
        member _.Yield(_: unit) : MigrationPostFeatureUpgradeRequest =
            {
            }

    let migrationPostFeatureUpgradeRequest = MigrationPostFeatureUpgradeRequestBuilder()

