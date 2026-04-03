// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module MigrationOperations =

    type MigrationDeprecationsRequest = {
        Index: Types.IndexName
    }

        with
        static member ToEndpoint(req: MigrationDeprecationsRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/{Fes.Http.toPathSegment req.Index}/_migration/deprecations"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

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

    type MigrationGetFeatureUpgradeStatusRequest = | MigrationGetFeatureUpgradeStatusRequest

        with
        static member ToEndpoint(req: MigrationGetFeatureUpgradeStatusRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_migration/system_features"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.GET, fullPath)
            endpoint, ValueNone

    type MigrationGetFeatureUpgradeStatusResponse = System.Text.Json.JsonElement

    type MigrationPostFeatureUpgradeRequest = | MigrationPostFeatureUpgradeRequest

        with
        static member ToEndpoint(req: MigrationPostFeatureUpgradeRequest) : Elastic.Transport.EndpointPath * Elastic.Transport.PostData voption =
            let path = $"/_migration/system_features"
            let fullPath = path
            let endpoint = Elastic.Transport.EndpointPath(Elastic.Transport.HttpMethod.POST, fullPath)
            endpoint, ValueNone

    type MigrationPostFeatureUpgradeResponse = System.Text.Json.JsonElement

