// Auto-generated from Elasticsearch OpenAPI spec
// Do not edit manually - regenerate using generate-dsl.fsx

namespace Fes.DSL.Operations

open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types

[<AutoOpen>]
module SecurityOperations =

    type SecurityActivateUserProfileRequest = {
        [<JsonPropertyName("access_token")>]
        AccessToken: string option
        [<JsonPropertyName("grant_type")>]
        GrantType: TypesGrantType
        [<JsonPropertyName("password")>]
        Password: string option
        [<JsonPropertyName("username")>]
        Username: string option
    } with
        static member ToRequest(request: SecurityActivateUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/profile/_activate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``access_token`` = request.AccessToken; ``grant_type`` = request.GrantType; ``password`` = request.Password; ``username`` = request.Username |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityActivateUserProfileRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityActivateUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityActivateUserProfileRequest.ToRequest request

    type SecurityActivateUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityActivateUserProfileRequest =
            {
                SecurityActivateUserProfileRequest.AccessToken = Option.None
                SecurityActivateUserProfileRequest.GrantType = Unchecked.defaultof<TypesGrantType>
                SecurityActivateUserProfileRequest.Password = Option.None
                SecurityActivateUserProfileRequest.Username = Option.None
            } : SecurityActivateUserProfileRequest

        [<CustomOperation("access_token")>]
        member _.AccessToken(state: SecurityActivateUserProfileRequest, value: string) =
            { state with SecurityActivateUserProfileRequest.AccessToken = Option.Some value } : SecurityActivateUserProfileRequest

        [<CustomOperation("grant_type")>]
        member _.GrantType(state: SecurityActivateUserProfileRequest, value: TypesGrantType) =
            { state with SecurityActivateUserProfileRequest.GrantType = value } : SecurityActivateUserProfileRequest

        [<CustomOperation("password")>]
        member _.Password(state: SecurityActivateUserProfileRequest, value: string) =
            { state with SecurityActivateUserProfileRequest.Password = Option.Some value } : SecurityActivateUserProfileRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityActivateUserProfileRequest, value: string) =
            { state with SecurityActivateUserProfileRequest.Username = Option.Some value } : SecurityActivateUserProfileRequest

    let securityActivateUserProfileRequest = SecurityActivateUserProfileRequestBuilder()

    type SecurityActivateUserProfileResponse = TypesUserProfileWithMetadata

    type SecurityAuthenticateRequest = unit

    let securityAuthenticateRequest = ()

    type SecurityAuthenticateResponse = {
        [<JsonPropertyName("api_key")>]
        ApiKey: AuthenticateAuthenticateApiKey option
        [<JsonPropertyName("authentication_realm")>]
        AuthenticationRealm: TypesRealmInfo
        [<JsonPropertyName("email")>]
        Email: System.Text.Json.JsonElement option
        [<JsonPropertyName("full_name")>]
        FullName: System.Text.Json.JsonElement option
        [<JsonPropertyName("lookup_realm")>]
        LookupRealm: TypesRealmInfo
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata
        [<JsonPropertyName("roles")>]
        Roles: string array
        [<JsonPropertyName("username")>]
        Username: Username
        [<JsonPropertyName("enabled")>]
        Enabled: bool
        [<JsonPropertyName("authentication_type")>]
        AuthenticationType: string
        [<JsonPropertyName("token")>]
        Token: AuthenticateToken option
    }

    type SecurityBulkPutRoleRequest = {
        Refresh: Refresh option
        [<JsonPropertyName("roles")>]
        Roles: Map<string, TypesRoleDescriptor>
    } with
        static member ToRequest(request: SecurityBulkPutRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/role"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``roles`` = request.Roles |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityBulkPutRoleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityBulkPutRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityBulkPutRoleRequest.ToRequest request

    type SecurityBulkPutRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityBulkPutRoleRequest =
            {
                SecurityBulkPutRoleRequest.Refresh = Option.None
                SecurityBulkPutRoleRequest.Roles = Unchecked.defaultof<Map<string, TypesRoleDescriptor>>
            } : SecurityBulkPutRoleRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityBulkPutRoleRequest, value: Refresh) =
            { state with SecurityBulkPutRoleRequest.Refresh = Option.Some value } : SecurityBulkPutRoleRequest

        [<CustomOperation("roles")>]
        member _.Roles(state: SecurityBulkPutRoleRequest, value: Map<string, TypesRoleDescriptor>) =
            { state with SecurityBulkPutRoleRequest.Roles = value } : SecurityBulkPutRoleRequest

    let securityBulkPutRoleRequest = SecurityBulkPutRoleRequestBuilder()

    type SecurityBulkPutRoleResponse = {
        [<JsonPropertyName("created")>]
        Created: string array option
        [<JsonPropertyName("updated")>]
        Updated: string array option
        [<JsonPropertyName("noop")>]
        Noop: string array option
        [<JsonPropertyName("errors")>]
        Errors: TypesBulkError option
    }

    type SecurityBulkDeleteRoleRequest = {
        Refresh: Refresh option
        [<JsonPropertyName("names")>]
        Names: string array
    } with
        static member ToRequest(request: SecurityBulkDeleteRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/role"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody {| ``names`` = request.Names |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityBulkDeleteRoleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityBulkDeleteRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityBulkDeleteRoleRequest.ToRequest request

    type SecurityBulkDeleteRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityBulkDeleteRoleRequest =
            {
                SecurityBulkDeleteRoleRequest.Refresh = Option.None
                SecurityBulkDeleteRoleRequest.Names = [||]
            } : SecurityBulkDeleteRoleRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityBulkDeleteRoleRequest, value: Refresh) =
            { state with SecurityBulkDeleteRoleRequest.Refresh = Option.Some value } : SecurityBulkDeleteRoleRequest

        [<CustomOperation("names")>]
        member _.Names(state: SecurityBulkDeleteRoleRequest, value: string array) =
            { state with SecurityBulkDeleteRoleRequest.Names = value } : SecurityBulkDeleteRoleRequest

    let securityBulkDeleteRoleRequest = SecurityBulkDeleteRoleRequestBuilder()

    type SecurityBulkDeleteRoleResponse = {
        [<JsonPropertyName("deleted")>]
        Deleted: string array option
        [<JsonPropertyName("not_found")>]
        NotFound: string array option
        [<JsonPropertyName("errors")>]
        Errors: TypesBulkError option
    }

    type SecurityBulkUpdateApiKeysRequest = {
        [<JsonPropertyName("expiration")>]
        Expiration: Duration option
        [<JsonPropertyName("ids")>]
        Ids: System.Text.Json.JsonElement
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, TypesRoleDescriptor> option
    } with
        static member ToRequest(request: SecurityBulkUpdateApiKeysRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/api_key/_bulk_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``expiration`` = request.Expiration; ``ids`` = request.Ids; ``metadata`` = request.Metadata; ``role_descriptors`` = request.RoleDescriptors |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityBulkUpdateApiKeysRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityBulkUpdateApiKeysRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityBulkUpdateApiKeysRequest.ToRequest request

    type SecurityBulkUpdateApiKeysRequestBuilder() =
        member _.Yield(_: unit) : SecurityBulkUpdateApiKeysRequest =
            {
                SecurityBulkUpdateApiKeysRequest.Expiration = Option.None
                SecurityBulkUpdateApiKeysRequest.Ids = Unchecked.defaultof<System.Text.Json.JsonElement>
                SecurityBulkUpdateApiKeysRequest.Metadata = Option.None
                SecurityBulkUpdateApiKeysRequest.RoleDescriptors = Option.None
            } : SecurityBulkUpdateApiKeysRequest

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityBulkUpdateApiKeysRequest, value: Duration) =
            { state with SecurityBulkUpdateApiKeysRequest.Expiration = Option.Some value } : SecurityBulkUpdateApiKeysRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: SecurityBulkUpdateApiKeysRequest, value: System.Text.Json.JsonElement) =
            { state with SecurityBulkUpdateApiKeysRequest.Ids = value } : SecurityBulkUpdateApiKeysRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityBulkUpdateApiKeysRequest, value: Metadata) =
            { state with SecurityBulkUpdateApiKeysRequest.Metadata = Option.Some value } : SecurityBulkUpdateApiKeysRequest

        [<CustomOperation("role_descriptors")>]
        member _.RoleDescriptors(state: SecurityBulkUpdateApiKeysRequest, value: Map<string, TypesRoleDescriptor>) =
            { state with SecurityBulkUpdateApiKeysRequest.RoleDescriptors = Option.Some value } : SecurityBulkUpdateApiKeysRequest

    let securityBulkUpdateApiKeysRequest = SecurityBulkUpdateApiKeysRequestBuilder()

    type SecurityBulkUpdateApiKeysResponse = {
        [<JsonPropertyName("errors")>]
        Errors: TypesBulkError option
        [<JsonPropertyName("noops")>]
        Noops: string array
        [<JsonPropertyName("updated")>]
        Updated: string array
    }

    type SecurityChangePasswordRequest = {
        Username: Username
        Refresh: Refresh option
        [<JsonPropertyName("password")>]
        Password: Password option
        [<JsonPropertyName("password_hash")>]
        PasswordHash: string option
    } with
        static member ToRequest(request: SecurityChangePasswordRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.Username}/_password"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``password`` = request.Password; ``password_hash`` = request.PasswordHash |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityChangePasswordRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityChangePasswordRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityChangePasswordRequest.ToRequest request

    type SecurityChangePasswordRequestBuilder() =
        member _.Yield(_: unit) : SecurityChangePasswordRequest =
            {
                SecurityChangePasswordRequest.Username = Unchecked.defaultof<Username>
                SecurityChangePasswordRequest.Refresh = Option.None
                SecurityChangePasswordRequest.Password = Option.None
                SecurityChangePasswordRequest.PasswordHash = Option.None
            } : SecurityChangePasswordRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityChangePasswordRequest, value: Username) =
            { state with SecurityChangePasswordRequest.Username = value } : SecurityChangePasswordRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityChangePasswordRequest, value: Refresh) =
            { state with SecurityChangePasswordRequest.Refresh = Option.Some value } : SecurityChangePasswordRequest

        [<CustomOperation("password")>]
        member _.Password(state: SecurityChangePasswordRequest, value: Password) =
            { state with SecurityChangePasswordRequest.Password = Option.Some value } : SecurityChangePasswordRequest

        [<CustomOperation("password_hash")>]
        member _.PasswordHash(state: SecurityChangePasswordRequest, value: string) =
            { state with SecurityChangePasswordRequest.PasswordHash = Option.Some value } : SecurityChangePasswordRequest

    let securityChangePasswordRequest = SecurityChangePasswordRequestBuilder()

    type SecurityClearApiKeyCacheRequest = {
        Ids: Ids
    } with
        static member ToRequest(request: SecurityClearApiKeyCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key/{request.Ids}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityClearApiKeyCacheRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityClearApiKeyCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityClearApiKeyCacheRequest.ToRequest request

    type SecurityClearApiKeyCacheRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearApiKeyCacheRequest =
            {
                SecurityClearApiKeyCacheRequest.Ids = Unchecked.defaultof<Ids>
            } : SecurityClearApiKeyCacheRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: SecurityClearApiKeyCacheRequest, value: Ids) =
            { state with SecurityClearApiKeyCacheRequest.Ids = value } : SecurityClearApiKeyCacheRequest

    let securityClearApiKeyCacheRequest = SecurityClearApiKeyCacheRequestBuilder()

    type SecurityClearApiKeyCacheResponse = {
        [<JsonPropertyName("_nodes")>]
        Nodes: NodeStatistics
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("nodes")>]
        Nodes2: Map<string, TypesClusterNode>
    }

    type SecurityClearCachedPrivilegesRequest = {
        Application: Names
    } with
        static member ToRequest(request: SecurityClearCachedPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/{request.Application}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityClearCachedPrivilegesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityClearCachedPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityClearCachedPrivilegesRequest.ToRequest request

    type SecurityClearCachedPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedPrivilegesRequest =
            {
                SecurityClearCachedPrivilegesRequest.Application = Unchecked.defaultof<Names>
            } : SecurityClearCachedPrivilegesRequest

        [<CustomOperation("application")>]
        member _.Application(state: SecurityClearCachedPrivilegesRequest, value: Names) =
            { state with SecurityClearCachedPrivilegesRequest.Application = value } : SecurityClearCachedPrivilegesRequest

    let securityClearCachedPrivilegesRequest = SecurityClearCachedPrivilegesRequestBuilder()

    type SecurityClearCachedPrivilegesResponse = {
        [<JsonPropertyName("_nodes")>]
        Nodes: NodeStatistics
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("nodes")>]
        Nodes2: Map<string, TypesClusterNode>
    }

    type SecurityClearCachedRealmsRequest = {
        Realms: Names
        Usernames: string array option
    } with
        static member ToRequest(request: SecurityClearCachedRealmsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/realm/{request.Realms}/_clear_cache"
                let queryParams =
                    [
                        request.Usernames |> Option.map (fun v -> "usernames", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityClearCachedRealmsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityClearCachedRealmsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityClearCachedRealmsRequest.ToRequest request

    type SecurityClearCachedRealmsRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedRealmsRequest =
            {
                SecurityClearCachedRealmsRequest.Realms = Unchecked.defaultof<Names>
                SecurityClearCachedRealmsRequest.Usernames = Option.None
            } : SecurityClearCachedRealmsRequest

        [<CustomOperation("realms")>]
        member _.Realms(state: SecurityClearCachedRealmsRequest, value: Names) =
            { state with SecurityClearCachedRealmsRequest.Realms = value } : SecurityClearCachedRealmsRequest

        [<CustomOperation("usernames")>]
        member _.Usernames(state: SecurityClearCachedRealmsRequest, value: string array) =
            { state with SecurityClearCachedRealmsRequest.Usernames = Option.Some value } : SecurityClearCachedRealmsRequest

    let securityClearCachedRealmsRequest = SecurityClearCachedRealmsRequestBuilder()

    type SecurityClearCachedRealmsResponse = {
        [<JsonPropertyName("_nodes")>]
        Nodes: NodeStatistics
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("nodes")>]
        Nodes2: Map<string, TypesClusterNode>
    }

    type SecurityClearCachedRolesRequest = {
        Name: Names
    } with
        static member ToRequest(request: SecurityClearCachedRolesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{request.Name}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityClearCachedRolesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityClearCachedRolesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityClearCachedRolesRequest.ToRequest request

    type SecurityClearCachedRolesRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedRolesRequest =
            {
                SecurityClearCachedRolesRequest.Name = Unchecked.defaultof<Names>
            } : SecurityClearCachedRolesRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityClearCachedRolesRequest, value: Names) =
            { state with SecurityClearCachedRolesRequest.Name = value } : SecurityClearCachedRolesRequest

    let securityClearCachedRolesRequest = SecurityClearCachedRolesRequestBuilder()

    type SecurityClearCachedRolesResponse = {
        [<JsonPropertyName("_nodes")>]
        Nodes: NodeStatistics
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("nodes")>]
        Nodes2: Map<string, TypesClusterNode>
    }

    type SecurityClearCachedServiceTokensRequest = {
        Namespace: Namespace
        Service: Service
        Name: Names
    } with
        static member ToRequest(request: SecurityClearCachedServiceTokensRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{request.Namespace}/{request.Service}/credential/token/{request.Name}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityClearCachedServiceTokensRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityClearCachedServiceTokensRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityClearCachedServiceTokensRequest.ToRequest request

    type SecurityClearCachedServiceTokensRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedServiceTokensRequest =
            {
                SecurityClearCachedServiceTokensRequest.Namespace = Unchecked.defaultof<Namespace>
                SecurityClearCachedServiceTokensRequest.Service = Unchecked.defaultof<Service>
                SecurityClearCachedServiceTokensRequest.Name = Unchecked.defaultof<Names>
            } : SecurityClearCachedServiceTokensRequest

        [<CustomOperation("namespace")>]
        member _.Namespace(state: SecurityClearCachedServiceTokensRequest, value: Namespace) =
            { state with SecurityClearCachedServiceTokensRequest.Namespace = value } : SecurityClearCachedServiceTokensRequest

        [<CustomOperation("service")>]
        member _.Service(state: SecurityClearCachedServiceTokensRequest, value: Service) =
            { state with SecurityClearCachedServiceTokensRequest.Service = value } : SecurityClearCachedServiceTokensRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityClearCachedServiceTokensRequest, value: Names) =
            { state with SecurityClearCachedServiceTokensRequest.Name = value } : SecurityClearCachedServiceTokensRequest

    let securityClearCachedServiceTokensRequest = SecurityClearCachedServiceTokensRequestBuilder()

    type SecurityClearCachedServiceTokensResponse = {
        [<JsonPropertyName("_nodes")>]
        Nodes: NodeStatistics
        [<JsonPropertyName("cluster_name")>]
        ClusterName: Name
        [<JsonPropertyName("nodes")>]
        Nodes2: Map<string, TypesClusterNode>
    }

    type SecurityGetApiKeyRequest = {
        Id: Id option
        Name: Name option
        Owner: bool option
        RealmName: Name option
        Username: Username option
        WithLimitedBy: bool option
        ActiveOnly: bool option
        WithProfileUid: bool option
    } with
        static member ToRequest(request: SecurityGetApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/api_key"
                let queryParams =
                    [
                        request.Id |> Option.map (fun v -> "id", Fes.Http.toQueryValue v)
                        request.Name |> Option.map (fun v -> "name", Fes.Http.toQueryValue v)
                        request.Owner |> Option.map (fun v -> "owner", Fes.Http.toQueryValue v)
                        request.RealmName |> Option.map (fun v -> "realm_name", Fes.Http.toQueryValue v)
                        request.Username |> Option.map (fun v -> "username", Fes.Http.toQueryValue v)
                        request.WithLimitedBy |> Option.map (fun v -> "with_limited_by", Fes.Http.toQueryValue v)
                        request.ActiveOnly |> Option.map (fun v -> "active_only", Fes.Http.toQueryValue v)
                        request.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
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

    module SecurityGetApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetApiKeyRequest.ToRequest request

    type SecurityGetApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetApiKeyRequest =
            {
                SecurityGetApiKeyRequest.Id = Option.None
                SecurityGetApiKeyRequest.Name = Option.None
                SecurityGetApiKeyRequest.Owner = Option.None
                SecurityGetApiKeyRequest.RealmName = Option.None
                SecurityGetApiKeyRequest.Username = Option.None
                SecurityGetApiKeyRequest.WithLimitedBy = Option.None
                SecurityGetApiKeyRequest.ActiveOnly = Option.None
                SecurityGetApiKeyRequest.WithProfileUid = Option.None
            } : SecurityGetApiKeyRequest

        [<CustomOperation("id")>]
        member _.Id(state: SecurityGetApiKeyRequest, value: Id) =
            { state with SecurityGetApiKeyRequest.Id = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetApiKeyRequest, value: Name) =
            { state with SecurityGetApiKeyRequest.Name = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("owner")>]
        member _.Owner(state: SecurityGetApiKeyRequest, value: bool) =
            { state with SecurityGetApiKeyRequest.Owner = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("realm_name")>]
        member _.RealmName(state: SecurityGetApiKeyRequest, value: Name) =
            { state with SecurityGetApiKeyRequest.RealmName = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGetApiKeyRequest, value: Username) =
            { state with SecurityGetApiKeyRequest.Username = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("with_limited_by")>]
        member _.WithLimitedBy(state: SecurityGetApiKeyRequest, value: bool) =
            { state with SecurityGetApiKeyRequest.WithLimitedBy = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("active_only")>]
        member _.ActiveOnly(state: SecurityGetApiKeyRequest, value: bool) =
            { state with SecurityGetApiKeyRequest.ActiveOnly = Option.Some value } : SecurityGetApiKeyRequest

        [<CustomOperation("with_profile_uid")>]
        member _.WithProfileUid(state: SecurityGetApiKeyRequest, value: bool) =
            { state with SecurityGetApiKeyRequest.WithProfileUid = Option.Some value } : SecurityGetApiKeyRequest

    let securityGetApiKeyRequest = SecurityGetApiKeyRequestBuilder()

    type SecurityGetApiKeyResponse = {
        [<JsonPropertyName("api_keys")>]
        ApiKeys: TypesApiKey array
    }

    type SecurityCreateApiKeyRequest = {
        Refresh: Refresh option
        [<JsonPropertyName("expiration")>]
        Expiration: Duration option
        [<JsonPropertyName("name")>]
        Name: Name option
        [<JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, TypesRoleDescriptor> option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
    } with
        static member ToRequest(request: SecurityCreateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/api_key"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``expiration`` = request.Expiration; ``name`` = request.Name; ``role_descriptors`` = request.RoleDescriptors; ``metadata`` = request.Metadata |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityCreateApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityCreateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityCreateApiKeyRequest.ToRequest request

    type SecurityCreateApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityCreateApiKeyRequest =
            {
                SecurityCreateApiKeyRequest.Refresh = Option.None
                SecurityCreateApiKeyRequest.Expiration = Option.None
                SecurityCreateApiKeyRequest.Name = Option.None
                SecurityCreateApiKeyRequest.RoleDescriptors = Option.None
                SecurityCreateApiKeyRequest.Metadata = Option.None
            } : SecurityCreateApiKeyRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityCreateApiKeyRequest, value: Refresh) =
            { state with SecurityCreateApiKeyRequest.Refresh = Option.Some value } : SecurityCreateApiKeyRequest

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityCreateApiKeyRequest, value: Duration) =
            { state with SecurityCreateApiKeyRequest.Expiration = Option.Some value } : SecurityCreateApiKeyRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityCreateApiKeyRequest, value: Name) =
            { state with SecurityCreateApiKeyRequest.Name = Option.Some value } : SecurityCreateApiKeyRequest

        [<CustomOperation("role_descriptors")>]
        member _.RoleDescriptors(state: SecurityCreateApiKeyRequest, value: Map<string, TypesRoleDescriptor>) =
            { state with SecurityCreateApiKeyRequest.RoleDescriptors = Option.Some value } : SecurityCreateApiKeyRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityCreateApiKeyRequest, value: Metadata) =
            { state with SecurityCreateApiKeyRequest.Metadata = Option.Some value } : SecurityCreateApiKeyRequest

    let securityCreateApiKeyRequest = SecurityCreateApiKeyRequestBuilder()

    type SecurityInvalidateApiKeyRequest = {
        [<JsonPropertyName("id")>]
        Id: Id option
        [<JsonPropertyName("ids")>]
        Ids: Id array option
        [<JsonPropertyName("name")>]
        Name: Name option
        [<JsonPropertyName("owner")>]
        Owner: bool option
        [<JsonPropertyName("realm_name")>]
        RealmName: string option
        [<JsonPropertyName("username")>]
        Username: Username option
    } with
        static member ToRequest(request: SecurityInvalidateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/api_key"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody {| ``id`` = request.Id; ``ids`` = request.Ids; ``name`` = request.Name; ``owner`` = request.Owner; ``realm_name`` = request.RealmName; ``username`` = request.Username |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityInvalidateApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityInvalidateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityInvalidateApiKeyRequest.ToRequest request

    type SecurityInvalidateApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityInvalidateApiKeyRequest =
            {
                SecurityInvalidateApiKeyRequest.Id = Option.None
                SecurityInvalidateApiKeyRequest.Ids = Option.None
                SecurityInvalidateApiKeyRequest.Name = Option.None
                SecurityInvalidateApiKeyRequest.Owner = Option.None
                SecurityInvalidateApiKeyRequest.RealmName = Option.None
                SecurityInvalidateApiKeyRequest.Username = Option.None
            } : SecurityInvalidateApiKeyRequest

        [<CustomOperation("id")>]
        member _.Id(state: SecurityInvalidateApiKeyRequest, value: Id) =
            { state with SecurityInvalidateApiKeyRequest.Id = Option.Some value } : SecurityInvalidateApiKeyRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: SecurityInvalidateApiKeyRequest, value: Id array) =
            { state with SecurityInvalidateApiKeyRequest.Ids = Option.Some value } : SecurityInvalidateApiKeyRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityInvalidateApiKeyRequest, value: Name) =
            { state with SecurityInvalidateApiKeyRequest.Name = Option.Some value } : SecurityInvalidateApiKeyRequest

        [<CustomOperation("owner")>]
        member _.Owner(state: SecurityInvalidateApiKeyRequest, value: bool) =
            { state with SecurityInvalidateApiKeyRequest.Owner = Option.Some value } : SecurityInvalidateApiKeyRequest

        [<CustomOperation("realm_name")>]
        member _.RealmName(state: SecurityInvalidateApiKeyRequest, value: string) =
            { state with SecurityInvalidateApiKeyRequest.RealmName = Option.Some value } : SecurityInvalidateApiKeyRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityInvalidateApiKeyRequest, value: Username) =
            { state with SecurityInvalidateApiKeyRequest.Username = Option.Some value } : SecurityInvalidateApiKeyRequest

    let securityInvalidateApiKeyRequest = SecurityInvalidateApiKeyRequestBuilder()

    type SecurityInvalidateApiKeyResponse = {
        [<JsonPropertyName("error_count")>]
        ErrorCount: float
        [<JsonPropertyName("error_details")>]
        ErrorDetails: ErrorCause array option
        [<JsonPropertyName("invalidated_api_keys")>]
        InvalidatedApiKeys: string array
        [<JsonPropertyName("previously_invalidated_api_keys")>]
        PreviouslyInvalidatedApiKeys: string array
    }

    type SecurityCreateCrossClusterApiKeyRequest = {
        [<JsonPropertyName("access")>]
        Access: TypesAccess
        [<JsonPropertyName("expiration")>]
        Expiration: Duration option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("certificate_identity")>]
        CertificateIdentity: string option
    } with
        static member ToRequest(request: SecurityCreateCrossClusterApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/cross_cluster/api_key"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``access`` = request.Access; ``expiration`` = request.Expiration; ``metadata`` = request.Metadata; ``name`` = request.Name; ``certificate_identity`` = request.CertificateIdentity |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityCreateCrossClusterApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityCreateCrossClusterApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityCreateCrossClusterApiKeyRequest.ToRequest request

    type SecurityCreateCrossClusterApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityCreateCrossClusterApiKeyRequest =
            {
                SecurityCreateCrossClusterApiKeyRequest.Access = Unchecked.defaultof<TypesAccess>
                SecurityCreateCrossClusterApiKeyRequest.Expiration = Option.None
                SecurityCreateCrossClusterApiKeyRequest.Metadata = Option.None
                SecurityCreateCrossClusterApiKeyRequest.Name = Unchecked.defaultof<Name>
                SecurityCreateCrossClusterApiKeyRequest.CertificateIdentity = Option.None
            } : SecurityCreateCrossClusterApiKeyRequest

        [<CustomOperation("access")>]
        member _.Access(state: SecurityCreateCrossClusterApiKeyRequest, value: TypesAccess) =
            { state with SecurityCreateCrossClusterApiKeyRequest.Access = value } : SecurityCreateCrossClusterApiKeyRequest

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityCreateCrossClusterApiKeyRequest, value: Duration) =
            { state with SecurityCreateCrossClusterApiKeyRequest.Expiration = Option.Some value } : SecurityCreateCrossClusterApiKeyRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityCreateCrossClusterApiKeyRequest, value: Metadata) =
            { state with SecurityCreateCrossClusterApiKeyRequest.Metadata = Option.Some value } : SecurityCreateCrossClusterApiKeyRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityCreateCrossClusterApiKeyRequest, value: Name) =
            { state with SecurityCreateCrossClusterApiKeyRequest.Name = value } : SecurityCreateCrossClusterApiKeyRequest

        [<CustomOperation("certificate_identity")>]
        member _.CertificateIdentity(state: SecurityCreateCrossClusterApiKeyRequest, value: string) =
            { state with SecurityCreateCrossClusterApiKeyRequest.CertificateIdentity = Option.Some value } : SecurityCreateCrossClusterApiKeyRequest

    let securityCreateCrossClusterApiKeyRequest = SecurityCreateCrossClusterApiKeyRequestBuilder()

    type SecurityCreateCrossClusterApiKeyResponse = {
        [<JsonPropertyName("api_key")>]
        ApiKey: string
        [<JsonPropertyName("expiration")>]
        Expiration: DurationValueUnitMillis option
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("encoded")>]
        Encoded: string
    }

    type SecurityCreateServiceTokenRequest = {
        Namespace: Namespace
        Service: Service
        Name: Name
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityCreateServiceTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{request.Namespace}/{request.Service}/credential/token/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityCreateServiceTokenRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityCreateServiceTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityCreateServiceTokenRequest.ToRequest request

    type SecurityCreateServiceTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityCreateServiceTokenRequest =
            {
                SecurityCreateServiceTokenRequest.Namespace = Unchecked.defaultof<Namespace>
                SecurityCreateServiceTokenRequest.Service = Unchecked.defaultof<Service>
                SecurityCreateServiceTokenRequest.Name = Unchecked.defaultof<Name>
                SecurityCreateServiceTokenRequest.Refresh = Option.None
            } : SecurityCreateServiceTokenRequest

        [<CustomOperation("namespace")>]
        member _.Namespace(state: SecurityCreateServiceTokenRequest, value: Namespace) =
            { state with SecurityCreateServiceTokenRequest.Namespace = value } : SecurityCreateServiceTokenRequest

        [<CustomOperation("service")>]
        member _.Service(state: SecurityCreateServiceTokenRequest, value: Service) =
            { state with SecurityCreateServiceTokenRequest.Service = value } : SecurityCreateServiceTokenRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityCreateServiceTokenRequest, value: Name) =
            { state with SecurityCreateServiceTokenRequest.Name = value } : SecurityCreateServiceTokenRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityCreateServiceTokenRequest, value: Refresh) =
            { state with SecurityCreateServiceTokenRequest.Refresh = Option.Some value } : SecurityCreateServiceTokenRequest

    let securityCreateServiceTokenRequest = SecurityCreateServiceTokenRequestBuilder()

    type SecurityDeleteServiceTokenRequest = {
        Namespace: Namespace
        Service: Service
        Name: Name
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDeleteServiceTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{request.Namespace}/{request.Service}/credential/token/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
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

    module SecurityDeleteServiceTokenRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDeleteServiceTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDeleteServiceTokenRequest.ToRequest request

    type SecurityDeleteServiceTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteServiceTokenRequest =
            {
                SecurityDeleteServiceTokenRequest.Namespace = Unchecked.defaultof<Namespace>
                SecurityDeleteServiceTokenRequest.Service = Unchecked.defaultof<Service>
                SecurityDeleteServiceTokenRequest.Name = Unchecked.defaultof<Name>
                SecurityDeleteServiceTokenRequest.Refresh = Option.None
            } : SecurityDeleteServiceTokenRequest

        [<CustomOperation("namespace")>]
        member _.Namespace(state: SecurityDeleteServiceTokenRequest, value: Namespace) =
            { state with SecurityDeleteServiceTokenRequest.Namespace = value } : SecurityDeleteServiceTokenRequest

        [<CustomOperation("service")>]
        member _.Service(state: SecurityDeleteServiceTokenRequest, value: Service) =
            { state with SecurityDeleteServiceTokenRequest.Service = value } : SecurityDeleteServiceTokenRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeleteServiceTokenRequest, value: Name) =
            { state with SecurityDeleteServiceTokenRequest.Name = value } : SecurityDeleteServiceTokenRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteServiceTokenRequest, value: Refresh) =
            { state with SecurityDeleteServiceTokenRequest.Refresh = Option.Some value } : SecurityDeleteServiceTokenRequest

    let securityDeleteServiceTokenRequest = SecurityDeleteServiceTokenRequestBuilder()

    type SecurityDeleteServiceTokenResponse = {
        [<JsonPropertyName("found")>]
        Found: bool
    }

    type SecurityDelegatePkiRequest = {
        [<JsonPropertyName("x509_certificate_chain")>]
        X509CertificateChain: string array
    } with
        static member ToRequest(request: SecurityDelegatePkiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/delegate_pki"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``x509_certificate_chain`` = request.X509CertificateChain |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityDelegatePkiRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDelegatePkiRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDelegatePkiRequest.ToRequest request

    type SecurityDelegatePkiRequestBuilder() =
        member _.Yield(_: unit) : SecurityDelegatePkiRequest =
            {
                SecurityDelegatePkiRequest.X509CertificateChain = [||]
            } : SecurityDelegatePkiRequest

        [<CustomOperation("x509_certificate_chain")>]
        member _.X509CertificateChain(state: SecurityDelegatePkiRequest, value: string array) =
            { state with SecurityDelegatePkiRequest.X509CertificateChain = value } : SecurityDelegatePkiRequest

    let securityDelegatePkiRequest = SecurityDelegatePkiRequestBuilder()

    type SecurityDelegatePkiResponse = {
        [<JsonPropertyName("access_token")>]
        AccessToken: string
        [<JsonPropertyName("expires_in")>]
        ExpiresIn: float
        [<JsonPropertyName("type")>]
        Type: string
        [<JsonPropertyName("authentication")>]
        Authentication: DelegatePkiAuthentication option
    }

    type SecurityGetPrivilegesRequest = {
        Application: Name
        Name: Names
    } with
        static member ToRequest(request: SecurityGetPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/{request.Application}/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGetPrivilegesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetPrivilegesRequest.ToRequest request

    type SecurityGetPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetPrivilegesRequest =
            {
                SecurityGetPrivilegesRequest.Application = Unchecked.defaultof<Name>
                SecurityGetPrivilegesRequest.Name = Unchecked.defaultof<Names>
            } : SecurityGetPrivilegesRequest

        [<CustomOperation("application")>]
        member _.Application(state: SecurityGetPrivilegesRequest, value: Name) =
            { state with SecurityGetPrivilegesRequest.Application = value } : SecurityGetPrivilegesRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetPrivilegesRequest, value: Names) =
            { state with SecurityGetPrivilegesRequest.Name = value } : SecurityGetPrivilegesRequest

    let securityGetPrivilegesRequest = SecurityGetPrivilegesRequestBuilder()

    type SecurityDeletePrivilegesRequest = {
        Application: Name
        Name: Names
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDeletePrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/{request.Application}/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
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

    module SecurityDeletePrivilegesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDeletePrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDeletePrivilegesRequest.ToRequest request

    type SecurityDeletePrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeletePrivilegesRequest =
            {
                SecurityDeletePrivilegesRequest.Application = Unchecked.defaultof<Name>
                SecurityDeletePrivilegesRequest.Name = Unchecked.defaultof<Names>
                SecurityDeletePrivilegesRequest.Refresh = Option.None
            } : SecurityDeletePrivilegesRequest

        [<CustomOperation("application")>]
        member _.Application(state: SecurityDeletePrivilegesRequest, value: Name) =
            { state with SecurityDeletePrivilegesRequest.Application = value } : SecurityDeletePrivilegesRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeletePrivilegesRequest, value: Names) =
            { state with SecurityDeletePrivilegesRequest.Name = value } : SecurityDeletePrivilegesRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeletePrivilegesRequest, value: Refresh) =
            { state with SecurityDeletePrivilegesRequest.Refresh = Option.Some value } : SecurityDeletePrivilegesRequest

    let securityDeletePrivilegesRequest = SecurityDeletePrivilegesRequestBuilder()

    type SecurityGetRoleRequest = {
        Name: Names
    } with
        static member ToRequest(request: SecurityGetRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGetRoleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetRoleRequest.ToRequest request

    type SecurityGetRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetRoleRequest =
            {
                SecurityGetRoleRequest.Name = Unchecked.defaultof<Names>
            } : SecurityGetRoleRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetRoleRequest, value: Names) =
            { state with SecurityGetRoleRequest.Name = value } : SecurityGetRoleRequest

    let securityGetRoleRequest = SecurityGetRoleRequestBuilder()

    type SecurityPutRoleRequest = {
        Name: Name
        Refresh: Refresh option
        [<JsonPropertyName("applications")>]
        Applications: TypesApplicationPrivileges array option
        [<JsonPropertyName("cluster")>]
        Cluster: TypesClusterPrivilege array option
        [<JsonPropertyName("global")>]
        Global: Map<string, obj> option
        [<JsonPropertyName("indices")>]
        Indices: TypesIndicesPrivileges array option
        [<JsonPropertyName("remote_indices")>]
        RemoteIndices: TypesRemoteIndicesPrivileges array option
        [<JsonPropertyName("remote_cluster")>]
        RemoteCluster: TypesRemoteClusterPrivileges array option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("run_as")>]
        RunAs: string array option
        [<JsonPropertyName("description")>]
        Description: string option
        [<JsonPropertyName("transient_metadata")>]
        TransientMetadata: Map<string, obj> option
    } with
        static member ToRequest(request: SecurityPutRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``applications`` = request.Applications; ``cluster`` = request.Cluster; ``global`` = request.Global; ``indices`` = request.Indices; ``remote_indices`` = request.RemoteIndices; ``remote_cluster`` = request.RemoteCluster; ``metadata`` = request.Metadata; ``run_as`` = request.RunAs; ``description`` = request.Description; ``transient_metadata`` = request.TransientMetadata |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityPutRoleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityPutRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityPutRoleRequest.ToRequest request

    type SecurityPutRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutRoleRequest =
            {
                SecurityPutRoleRequest.Name = Unchecked.defaultof<Name>
                SecurityPutRoleRequest.Refresh = Option.None
                SecurityPutRoleRequest.Applications = Option.None
                SecurityPutRoleRequest.Cluster = Option.None
                SecurityPutRoleRequest.Global = Option.None
                SecurityPutRoleRequest.Indices = Option.None
                SecurityPutRoleRequest.RemoteIndices = Option.None
                SecurityPutRoleRequest.RemoteCluster = Option.None
                SecurityPutRoleRequest.Metadata = Option.None
                SecurityPutRoleRequest.RunAs = Option.None
                SecurityPutRoleRequest.Description = Option.None
                SecurityPutRoleRequest.TransientMetadata = Option.None
            } : SecurityPutRoleRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityPutRoleRequest, value: Name) =
            { state with SecurityPutRoleRequest.Name = value } : SecurityPutRoleRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutRoleRequest, value: Refresh) =
            { state with SecurityPutRoleRequest.Refresh = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("applications")>]
        member _.Applications(state: SecurityPutRoleRequest, value: TypesApplicationPrivileges array) =
            { state with SecurityPutRoleRequest.Applications = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("cluster")>]
        member _.Cluster(state: SecurityPutRoleRequest, value: TypesClusterPrivilege array) =
            { state with SecurityPutRoleRequest.Cluster = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("global")>]
        member _.Global(state: SecurityPutRoleRequest, value: Map<string, obj>) =
            { state with SecurityPutRoleRequest.Global = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("indices")>]
        member _.Indices(state: SecurityPutRoleRequest, value: TypesIndicesPrivileges array) =
            { state with SecurityPutRoleRequest.Indices = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("remote_indices")>]
        member _.RemoteIndices(state: SecurityPutRoleRequest, value: TypesRemoteIndicesPrivileges array) =
            { state with SecurityPutRoleRequest.RemoteIndices = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("remote_cluster")>]
        member _.RemoteCluster(state: SecurityPutRoleRequest, value: TypesRemoteClusterPrivileges array) =
            { state with SecurityPutRoleRequest.RemoteCluster = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityPutRoleRequest, value: Metadata) =
            { state with SecurityPutRoleRequest.Metadata = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("run_as")>]
        member _.RunAs(state: SecurityPutRoleRequest, value: string array) =
            { state with SecurityPutRoleRequest.RunAs = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("description")>]
        member _.Description(state: SecurityPutRoleRequest, value: string) =
            { state with SecurityPutRoleRequest.Description = Option.Some value } : SecurityPutRoleRequest

        [<CustomOperation("transient_metadata")>]
        member _.TransientMetadata(state: SecurityPutRoleRequest, value: Map<string, obj>) =
            { state with SecurityPutRoleRequest.TransientMetadata = Option.Some value } : SecurityPutRoleRequest

    let securityPutRoleRequest = SecurityPutRoleRequestBuilder()

    type SecurityDeleteRoleRequest = {
        Name: Name
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDeleteRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
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

    module SecurityDeleteRoleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDeleteRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDeleteRoleRequest.ToRequest request

    type SecurityDeleteRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteRoleRequest =
            {
                SecurityDeleteRoleRequest.Name = Unchecked.defaultof<Name>
                SecurityDeleteRoleRequest.Refresh = Option.None
            } : SecurityDeleteRoleRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeleteRoleRequest, value: Name) =
            { state with SecurityDeleteRoleRequest.Name = value } : SecurityDeleteRoleRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteRoleRequest, value: Refresh) =
            { state with SecurityDeleteRoleRequest.Refresh = Option.Some value } : SecurityDeleteRoleRequest

    let securityDeleteRoleRequest = SecurityDeleteRoleRequestBuilder()

    type SecurityDeleteRoleResponse = {
        [<JsonPropertyName("found")>]
        Found: bool
    }

    type SecurityGetRoleMappingRequest = {
        Name: Names
    } with
        static member ToRequest(request: SecurityGetRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role_mapping/{request.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGetRoleMappingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetRoleMappingRequest.ToRequest request

    type SecurityGetRoleMappingRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetRoleMappingRequest =
            {
                SecurityGetRoleMappingRequest.Name = Unchecked.defaultof<Names>
            } : SecurityGetRoleMappingRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetRoleMappingRequest, value: Names) =
            { state with SecurityGetRoleMappingRequest.Name = value } : SecurityGetRoleMappingRequest

    let securityGetRoleMappingRequest = SecurityGetRoleMappingRequestBuilder()

    type SecurityPutRoleMappingRequest = {
        Name: Name
        Refresh: Refresh option
        [<JsonPropertyName("enabled")>]
        Enabled: bool option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("roles")>]
        Roles: string array option
        [<JsonPropertyName("role_templates")>]
        RoleTemplates: TypesRoleTemplate array option
        [<JsonPropertyName("rules")>]
        Rules: TypesRoleMappingRule option
        [<JsonPropertyName("run_as")>]
        RunAs: string array option
    } with
        static member ToRequest(request: SecurityPutRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role_mapping/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``enabled`` = request.Enabled; ``metadata`` = request.Metadata; ``roles`` = request.Roles; ``role_templates`` = request.RoleTemplates; ``rules`` = request.Rules; ``run_as`` = request.RunAs |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityPutRoleMappingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityPutRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityPutRoleMappingRequest.ToRequest request

    type SecurityPutRoleMappingRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutRoleMappingRequest =
            {
                SecurityPutRoleMappingRequest.Name = Unchecked.defaultof<Name>
                SecurityPutRoleMappingRequest.Refresh = Option.None
                SecurityPutRoleMappingRequest.Enabled = Option.None
                SecurityPutRoleMappingRequest.Metadata = Option.None
                SecurityPutRoleMappingRequest.Roles = Option.None
                SecurityPutRoleMappingRequest.RoleTemplates = Option.None
                SecurityPutRoleMappingRequest.Rules = Option.None
                SecurityPutRoleMappingRequest.RunAs = Option.None
            } : SecurityPutRoleMappingRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityPutRoleMappingRequest, value: Name) =
            { state with SecurityPutRoleMappingRequest.Name = value } : SecurityPutRoleMappingRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutRoleMappingRequest, value: Refresh) =
            { state with SecurityPutRoleMappingRequest.Refresh = Option.Some value } : SecurityPutRoleMappingRequest

        [<CustomOperation("enabled")>]
        member _.Enabled(state: SecurityPutRoleMappingRequest, value: bool) =
            { state with SecurityPutRoleMappingRequest.Enabled = Option.Some value } : SecurityPutRoleMappingRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityPutRoleMappingRequest, value: Metadata) =
            { state with SecurityPutRoleMappingRequest.Metadata = Option.Some value } : SecurityPutRoleMappingRequest

        [<CustomOperation("roles")>]
        member _.Roles(state: SecurityPutRoleMappingRequest, value: string array) =
            { state with SecurityPutRoleMappingRequest.Roles = Option.Some value } : SecurityPutRoleMappingRequest

        [<CustomOperation("role_templates")>]
        member _.RoleTemplates(state: SecurityPutRoleMappingRequest, value: TypesRoleTemplate array) =
            { state with SecurityPutRoleMappingRequest.RoleTemplates = Option.Some value } : SecurityPutRoleMappingRequest

        [<CustomOperation("rules")>]
        member _.Rules(state: SecurityPutRoleMappingRequest, value: TypesRoleMappingRule) =
            { state with SecurityPutRoleMappingRequest.Rules = Option.Some value } : SecurityPutRoleMappingRequest

        [<CustomOperation("run_as")>]
        member _.RunAs(state: SecurityPutRoleMappingRequest, value: string array) =
            { state with SecurityPutRoleMappingRequest.RunAs = Option.Some value } : SecurityPutRoleMappingRequest

    let securityPutRoleMappingRequest = SecurityPutRoleMappingRequestBuilder()

    type SecurityDeleteRoleMappingRequest = {
        Name: Name
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDeleteRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role_mapping/{request.Name}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
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

    module SecurityDeleteRoleMappingRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDeleteRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDeleteRoleMappingRequest.ToRequest request

    type SecurityDeleteRoleMappingRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteRoleMappingRequest =
            {
                SecurityDeleteRoleMappingRequest.Name = Unchecked.defaultof<Name>
                SecurityDeleteRoleMappingRequest.Refresh = Option.None
            } : SecurityDeleteRoleMappingRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeleteRoleMappingRequest, value: Name) =
            { state with SecurityDeleteRoleMappingRequest.Name = value } : SecurityDeleteRoleMappingRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteRoleMappingRequest, value: Refresh) =
            { state with SecurityDeleteRoleMappingRequest.Refresh = Option.Some value } : SecurityDeleteRoleMappingRequest

    let securityDeleteRoleMappingRequest = SecurityDeleteRoleMappingRequestBuilder()

    type SecurityDeleteRoleMappingResponse = {
        [<JsonPropertyName("found")>]
        Found: bool
    }

    type SecurityGetUserRequest = {
        Username: System.Text.Json.JsonElement
        WithProfileUid: bool option
    } with
        static member ToRequest(request: SecurityGetUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.Username}"
                let queryParams =
                    [
                        request.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
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

    module SecurityGetUserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetUserRequest.ToRequest request

    type SecurityGetUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetUserRequest =
            {
                SecurityGetUserRequest.Username = Unchecked.defaultof<System.Text.Json.JsonElement>
                SecurityGetUserRequest.WithProfileUid = Option.None
            } : SecurityGetUserRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGetUserRequest, value: System.Text.Json.JsonElement) =
            { state with SecurityGetUserRequest.Username = value } : SecurityGetUserRequest

        [<CustomOperation("with_profile_uid")>]
        member _.WithProfileUid(state: SecurityGetUserRequest, value: bool) =
            { state with SecurityGetUserRequest.WithProfileUid = Option.Some value } : SecurityGetUserRequest

    let securityGetUserRequest = SecurityGetUserRequestBuilder()

    type SecurityPutUserRequest = {
        Username: Username
        Refresh: Refresh option
        [<JsonPropertyName("username")>]
        Username2: Username option
        [<JsonPropertyName("email")>]
        Email: System.Text.Json.JsonElement option
        [<JsonPropertyName("full_name")>]
        FullName: System.Text.Json.JsonElement option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("password")>]
        Password: Password option
        [<JsonPropertyName("password_hash")>]
        PasswordHash: string option
        [<JsonPropertyName("roles")>]
        Roles: string array option
        [<JsonPropertyName("enabled")>]
        Enabled: bool option
    } with
        static member ToRequest(request: SecurityPutUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.Username}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``username`` = request.Username2; ``email`` = request.Email; ``full_name`` = request.FullName; ``metadata`` = request.Metadata; ``password`` = request.Password; ``password_hash`` = request.PasswordHash; ``roles`` = request.Roles; ``enabled`` = request.Enabled |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityPutUserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityPutUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityPutUserRequest.ToRequest request

    type SecurityPutUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutUserRequest =
            {
                SecurityPutUserRequest.Username = Unchecked.defaultof<Username>
                SecurityPutUserRequest.Refresh = Option.None
                SecurityPutUserRequest.Username2 = Option.None
                SecurityPutUserRequest.Email = Option.None
                SecurityPutUserRequest.FullName = Option.None
                SecurityPutUserRequest.Metadata = Option.None
                SecurityPutUserRequest.Password = Option.None
                SecurityPutUserRequest.PasswordHash = Option.None
                SecurityPutUserRequest.Roles = Option.None
                SecurityPutUserRequest.Enabled = Option.None
            } : SecurityPutUserRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityPutUserRequest, value: Username) =
            { state with SecurityPutUserRequest.Username = value } : SecurityPutUserRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutUserRequest, value: Refresh) =
            { state with SecurityPutUserRequest.Refresh = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("username2")>]
        member _.Username2(state: SecurityPutUserRequest, value: Username) =
            { state with SecurityPutUserRequest.Username2 = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("email")>]
        member _.Email(state: SecurityPutUserRequest, value: System.Text.Json.JsonElement) =
            { state with SecurityPutUserRequest.Email = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("full_name")>]
        member _.FullName(state: SecurityPutUserRequest, value: System.Text.Json.JsonElement) =
            { state with SecurityPutUserRequest.FullName = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityPutUserRequest, value: Metadata) =
            { state with SecurityPutUserRequest.Metadata = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("password")>]
        member _.Password(state: SecurityPutUserRequest, value: Password) =
            { state with SecurityPutUserRequest.Password = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("password_hash")>]
        member _.PasswordHash(state: SecurityPutUserRequest, value: string) =
            { state with SecurityPutUserRequest.PasswordHash = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("roles")>]
        member _.Roles(state: SecurityPutUserRequest, value: string array) =
            { state with SecurityPutUserRequest.Roles = Option.Some value } : SecurityPutUserRequest

        [<CustomOperation("enabled")>]
        member _.Enabled(state: SecurityPutUserRequest, value: bool) =
            { state with SecurityPutUserRequest.Enabled = Option.Some value } : SecurityPutUserRequest

    let securityPutUserRequest = SecurityPutUserRequestBuilder()

    type SecurityDeleteUserRequest = {
        Username: Username
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDeleteUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.Username}"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
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

    module SecurityDeleteUserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDeleteUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDeleteUserRequest.ToRequest request

    type SecurityDeleteUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteUserRequest =
            {
                SecurityDeleteUserRequest.Username = Unchecked.defaultof<Username>
                SecurityDeleteUserRequest.Refresh = Option.None
            } : SecurityDeleteUserRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityDeleteUserRequest, value: Username) =
            { state with SecurityDeleteUserRequest.Username = value } : SecurityDeleteUserRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteUserRequest, value: Refresh) =
            { state with SecurityDeleteUserRequest.Refresh = Option.Some value } : SecurityDeleteUserRequest

    let securityDeleteUserRequest = SecurityDeleteUserRequestBuilder()

    type SecurityDeleteUserResponse = {
        [<JsonPropertyName("found")>]
        Found: bool
    }

    type SecurityDisableUserRequest = {
        Username: Username
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDisableUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.Username}/_disable"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityDisableUserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDisableUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDisableUserRequest.ToRequest request

    type SecurityDisableUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityDisableUserRequest =
            {
                SecurityDisableUserRequest.Username = Unchecked.defaultof<Username>
                SecurityDisableUserRequest.Refresh = Option.None
            } : SecurityDisableUserRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityDisableUserRequest, value: Username) =
            { state with SecurityDisableUserRequest.Username = value } : SecurityDisableUserRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDisableUserRequest, value: Refresh) =
            { state with SecurityDisableUserRequest.Refresh = Option.Some value } : SecurityDisableUserRequest

    let securityDisableUserRequest = SecurityDisableUserRequestBuilder()

    type SecurityDisableUserProfileRequest = {
        Uid: TypesUserProfileId
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityDisableUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{request.Uid}/_disable"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityDisableUserProfileRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityDisableUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityDisableUserProfileRequest.ToRequest request

    type SecurityDisableUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityDisableUserProfileRequest =
            {
                SecurityDisableUserProfileRequest.Uid = Unchecked.defaultof<TypesUserProfileId>
                SecurityDisableUserProfileRequest.Refresh = Option.None
            } : SecurityDisableUserProfileRequest

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityDisableUserProfileRequest, value: TypesUserProfileId) =
            { state with SecurityDisableUserProfileRequest.Uid = value } : SecurityDisableUserProfileRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDisableUserProfileRequest, value: Refresh) =
            { state with SecurityDisableUserProfileRequest.Refresh = Option.Some value } : SecurityDisableUserProfileRequest

    let securityDisableUserProfileRequest = SecurityDisableUserProfileRequestBuilder()

    type SecurityEnableUserRequest = {
        Username: Username
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityEnableUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.Username}/_enable"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityEnableUserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityEnableUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityEnableUserRequest.ToRequest request

    type SecurityEnableUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityEnableUserRequest =
            {
                SecurityEnableUserRequest.Username = Unchecked.defaultof<Username>
                SecurityEnableUserRequest.Refresh = Option.None
            } : SecurityEnableUserRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityEnableUserRequest, value: Username) =
            { state with SecurityEnableUserRequest.Username = value } : SecurityEnableUserRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityEnableUserRequest, value: Refresh) =
            { state with SecurityEnableUserRequest.Refresh = Option.Some value } : SecurityEnableUserRequest

    let securityEnableUserRequest = SecurityEnableUserRequestBuilder()

    type SecurityEnableUserProfileRequest = {
        Uid: TypesUserProfileId
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityEnableUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{request.Uid}/_enable"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityEnableUserProfileRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityEnableUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityEnableUserProfileRequest.ToRequest request

    type SecurityEnableUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityEnableUserProfileRequest =
            {
                SecurityEnableUserProfileRequest.Uid = Unchecked.defaultof<TypesUserProfileId>
                SecurityEnableUserProfileRequest.Refresh = Option.None
            } : SecurityEnableUserProfileRequest

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityEnableUserProfileRequest, value: TypesUserProfileId) =
            { state with SecurityEnableUserProfileRequest.Uid = value } : SecurityEnableUserProfileRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityEnableUserProfileRequest, value: Refresh) =
            { state with SecurityEnableUserProfileRequest.Refresh = Option.Some value } : SecurityEnableUserProfileRequest

    let securityEnableUserProfileRequest = SecurityEnableUserProfileRequestBuilder()

    type SecurityEnrollKibanaRequest = unit

    let securityEnrollKibanaRequest = ()

    type SecurityEnrollKibanaResponse = {
        [<JsonPropertyName("token")>]
        Token: EnrollKibanaToken
        [<JsonPropertyName("http_ca")>]
        HttpCa: string
    }

    type SecurityEnrollNodeRequest = unit

    let securityEnrollNodeRequest = ()

    type SecurityEnrollNodeResponse = {
        [<JsonPropertyName("http_ca_key")>]
        HttpCaKey: string
        [<JsonPropertyName("http_ca_cert")>]
        HttpCaCert: string
        [<JsonPropertyName("transport_ca_cert")>]
        TransportCaCert: string
        [<JsonPropertyName("transport_key")>]
        TransportKey: string
        [<JsonPropertyName("transport_cert")>]
        TransportCert: string
        [<JsonPropertyName("nodes_addresses")>]
        NodesAddresses: string array
    }

    type SecurityGetBuiltinPrivilegesRequest = unit

    let securityGetBuiltinPrivilegesRequest = ()

    type SecurityGetBuiltinPrivilegesResponse = {
        [<JsonPropertyName("cluster")>]
        Cluster: TypesClusterPrivilege array
        [<JsonPropertyName("index")>]
        Index: IndexName array
        [<JsonPropertyName("remote_cluster")>]
        RemoteCluster: TypesRemoteClusterPrivilege array
    }

    type SecurityGetServiceAccountsRequest = {
        Namespace: Namespace
        Service: Service
    } with
        static member ToRequest(request: SecurityGetServiceAccountsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{request.Namespace}/{request.Service}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGetServiceAccountsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetServiceAccountsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetServiceAccountsRequest.ToRequest request

    type SecurityGetServiceAccountsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetServiceAccountsRequest =
            {
                SecurityGetServiceAccountsRequest.Namespace = Unchecked.defaultof<Namespace>
                SecurityGetServiceAccountsRequest.Service = Unchecked.defaultof<Service>
            } : SecurityGetServiceAccountsRequest

        [<CustomOperation("namespace")>]
        member _.Namespace(state: SecurityGetServiceAccountsRequest, value: Namespace) =
            { state with SecurityGetServiceAccountsRequest.Namespace = value } : SecurityGetServiceAccountsRequest

        [<CustomOperation("service")>]
        member _.Service(state: SecurityGetServiceAccountsRequest, value: Service) =
            { state with SecurityGetServiceAccountsRequest.Service = value } : SecurityGetServiceAccountsRequest

    let securityGetServiceAccountsRequest = SecurityGetServiceAccountsRequestBuilder()

    type SecurityGetServiceCredentialsRequest = {
        Namespace: Namespace
        Service: Name
    } with
        static member ToRequest(request: SecurityGetServiceCredentialsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{request.Namespace}/{request.Service}/credential"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGetServiceCredentialsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetServiceCredentialsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetServiceCredentialsRequest.ToRequest request

    type SecurityGetServiceCredentialsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetServiceCredentialsRequest =
            {
                SecurityGetServiceCredentialsRequest.Namespace = Unchecked.defaultof<Namespace>
                SecurityGetServiceCredentialsRequest.Service = Unchecked.defaultof<Name>
            } : SecurityGetServiceCredentialsRequest

        [<CustomOperation("namespace")>]
        member _.Namespace(state: SecurityGetServiceCredentialsRequest, value: Namespace) =
            { state with SecurityGetServiceCredentialsRequest.Namespace = value } : SecurityGetServiceCredentialsRequest

        [<CustomOperation("service")>]
        member _.Service(state: SecurityGetServiceCredentialsRequest, value: Name) =
            { state with SecurityGetServiceCredentialsRequest.Service = value } : SecurityGetServiceCredentialsRequest

    let securityGetServiceCredentialsRequest = SecurityGetServiceCredentialsRequestBuilder()

    type SecurityGetServiceCredentialsResponse = {
        [<JsonPropertyName("service_account")>]
        ServiceAccount: string
        [<JsonPropertyName("count")>]
        Count: float
        [<JsonPropertyName("tokens")>]
        Tokens: Map<string, Metadata>
        [<JsonPropertyName("nodes_credentials")>]
        NodesCredentials: GetServiceCredentialsNodesCredentials
    }

    type SecurityGetSettingsRequest = {
        MasterTimeout: Duration option
    } with
        static member ToRequest(request: SecurityGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/settings"
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

    module SecurityGetSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetSettingsRequest.ToRequest request

    type SecurityGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetSettingsRequest =
            {
                SecurityGetSettingsRequest.MasterTimeout = Option.None
            } : SecurityGetSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SecurityGetSettingsRequest, value: Duration) =
            { state with SecurityGetSettingsRequest.MasterTimeout = Option.Some value } : SecurityGetSettingsRequest

    let securityGetSettingsRequest = SecurityGetSettingsRequestBuilder()

    type SecurityGetSettingsResponse = {
        [<JsonPropertyName("security")>]
        Security: TypesSecuritySettings
        [<JsonPropertyName("security-profile")>]
        SecurityProfile: TypesSecuritySettings
        [<JsonPropertyName("security-tokens")>]
        SecurityTokens: TypesSecuritySettings
    }

    type SecurityUpdateSettingsRequest = {
        MasterTimeout: Duration option
        Timeout: Duration option
        [<JsonPropertyName("security")>]
        Security: TypesSecuritySettings option
        [<JsonPropertyName("security-profile")>]
        SecurityProfile: TypesSecuritySettings option
        [<JsonPropertyName("security-tokens")>]
        SecurityTokens: TypesSecuritySettings option
    } with
        static member ToRequest(request: SecurityUpdateSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/settings"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``security`` = request.Security; ``security-profile`` = request.SecurityProfile; ``security-tokens`` = request.SecurityTokens |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityUpdateSettingsRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityUpdateSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityUpdateSettingsRequest.ToRequest request

    type SecurityUpdateSettingsRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateSettingsRequest =
            {
                SecurityUpdateSettingsRequest.MasterTimeout = Option.None
                SecurityUpdateSettingsRequest.Timeout = Option.None
                SecurityUpdateSettingsRequest.Security = Option.None
                SecurityUpdateSettingsRequest.SecurityProfile = Option.None
                SecurityUpdateSettingsRequest.SecurityTokens = Option.None
            } : SecurityUpdateSettingsRequest

        [<CustomOperation("master_timeout")>]
        member _.MasterTimeout(state: SecurityUpdateSettingsRequest, value: Duration) =
            { state with SecurityUpdateSettingsRequest.MasterTimeout = Option.Some value } : SecurityUpdateSettingsRequest

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SecurityUpdateSettingsRequest, value: Duration) =
            { state with SecurityUpdateSettingsRequest.Timeout = Option.Some value } : SecurityUpdateSettingsRequest

        [<CustomOperation("security")>]
        member _.Security(state: SecurityUpdateSettingsRequest, value: TypesSecuritySettings) =
            { state with SecurityUpdateSettingsRequest.Security = Option.Some value } : SecurityUpdateSettingsRequest

        [<CustomOperation("security_profile")>]
        member _.SecurityProfile(state: SecurityUpdateSettingsRequest, value: TypesSecuritySettings) =
            { state with SecurityUpdateSettingsRequest.SecurityProfile = Option.Some value } : SecurityUpdateSettingsRequest

        [<CustomOperation("security_tokens")>]
        member _.SecurityTokens(state: SecurityUpdateSettingsRequest, value: TypesSecuritySettings) =
            { state with SecurityUpdateSettingsRequest.SecurityTokens = Option.Some value } : SecurityUpdateSettingsRequest

    let securityUpdateSettingsRequest = SecurityUpdateSettingsRequestBuilder()

    type SecurityUpdateSettingsResponse = {
        [<JsonPropertyName("acknowledged")>]
        Acknowledged: bool
    }

    type SecurityGetStatsRequest = unit

    let securityGetStatsRequest = ()

    type SecurityGetStatsResponse = {
        [<JsonPropertyName("nodes")>]
        Nodes: Map<string, TypesNodeSecurityStats>
    }

    type SecurityGetTokenRequest = {
        [<JsonPropertyName("grant_type")>]
        GrantType: GetTokenAccessTokenGrantType option
        [<JsonPropertyName("scope")>]
        Scope: string option
        [<JsonPropertyName("password")>]
        Password: Password option
        [<JsonPropertyName("kerberos_ticket")>]
        KerberosTicket: string option
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string option
        [<JsonPropertyName("username")>]
        Username: Username option
    } with
        static member ToRequest(request: SecurityGetTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/oauth2/token"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``grant_type`` = request.GrantType; ``scope`` = request.Scope; ``password`` = request.Password; ``kerberos_ticket`` = request.KerberosTicket; ``refresh_token`` = request.RefreshToken; ``username`` = request.Username |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGetTokenRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetTokenRequest.ToRequest request

    type SecurityGetTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetTokenRequest =
            {
                SecurityGetTokenRequest.GrantType = Option.None
                SecurityGetTokenRequest.Scope = Option.None
                SecurityGetTokenRequest.Password = Option.None
                SecurityGetTokenRequest.KerberosTicket = Option.None
                SecurityGetTokenRequest.RefreshToken = Option.None
                SecurityGetTokenRequest.Username = Option.None
            } : SecurityGetTokenRequest

        [<CustomOperation("grant_type")>]
        member _.GrantType(state: SecurityGetTokenRequest, value: GetTokenAccessTokenGrantType) =
            { state with SecurityGetTokenRequest.GrantType = Option.Some value } : SecurityGetTokenRequest

        [<CustomOperation("scope")>]
        member _.Scope(state: SecurityGetTokenRequest, value: string) =
            { state with SecurityGetTokenRequest.Scope = Option.Some value } : SecurityGetTokenRequest

        [<CustomOperation("password")>]
        member _.Password(state: SecurityGetTokenRequest, value: Password) =
            { state with SecurityGetTokenRequest.Password = Option.Some value } : SecurityGetTokenRequest

        [<CustomOperation("kerberos_ticket")>]
        member _.KerberosTicket(state: SecurityGetTokenRequest, value: string) =
            { state with SecurityGetTokenRequest.KerberosTicket = Option.Some value } : SecurityGetTokenRequest

        [<CustomOperation("refresh_token")>]
        member _.RefreshToken(state: SecurityGetTokenRequest, value: string) =
            { state with SecurityGetTokenRequest.RefreshToken = Option.Some value } : SecurityGetTokenRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGetTokenRequest, value: Username) =
            { state with SecurityGetTokenRequest.Username = Option.Some value } : SecurityGetTokenRequest

    let securityGetTokenRequest = SecurityGetTokenRequestBuilder()

    type SecurityGetTokenResponse = {
        [<JsonPropertyName("access_token")>]
        AccessToken: string
        [<JsonPropertyName("expires_in")>]
        ExpiresIn: float
        [<JsonPropertyName("scope")>]
        Scope: string option
        [<JsonPropertyName("type")>]
        Type: string
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string option
        [<JsonPropertyName("kerberos_authentication_response_token")>]
        KerberosAuthenticationResponseToken: string option
        [<JsonPropertyName("authentication")>]
        Authentication: GetTokenAuthenticatedUser
    }

    type SecurityInvalidateTokenRequest = {
        [<JsonPropertyName("token")>]
        Token: string option
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string option
        [<JsonPropertyName("realm_name")>]
        RealmName: Name option
        [<JsonPropertyName("username")>]
        Username: Username option
    } with
        static member ToRequest(request: SecurityInvalidateTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/oauth2/token"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody {| ``token`` = request.Token; ``refresh_token`` = request.RefreshToken; ``realm_name`` = request.RealmName; ``username`` = request.Username |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityInvalidateTokenRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityInvalidateTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityInvalidateTokenRequest.ToRequest request

    type SecurityInvalidateTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityInvalidateTokenRequest =
            {
                SecurityInvalidateTokenRequest.Token = Option.None
                SecurityInvalidateTokenRequest.RefreshToken = Option.None
                SecurityInvalidateTokenRequest.RealmName = Option.None
                SecurityInvalidateTokenRequest.Username = Option.None
            } : SecurityInvalidateTokenRequest

        [<CustomOperation("token")>]
        member _.Token(state: SecurityInvalidateTokenRequest, value: string) =
            { state with SecurityInvalidateTokenRequest.Token = Option.Some value } : SecurityInvalidateTokenRequest

        [<CustomOperation("refresh_token")>]
        member _.RefreshToken(state: SecurityInvalidateTokenRequest, value: string) =
            { state with SecurityInvalidateTokenRequest.RefreshToken = Option.Some value } : SecurityInvalidateTokenRequest

        [<CustomOperation("realm_name")>]
        member _.RealmName(state: SecurityInvalidateTokenRequest, value: Name) =
            { state with SecurityInvalidateTokenRequest.RealmName = Option.Some value } : SecurityInvalidateTokenRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityInvalidateTokenRequest, value: Username) =
            { state with SecurityInvalidateTokenRequest.Username = Option.Some value } : SecurityInvalidateTokenRequest

    let securityInvalidateTokenRequest = SecurityInvalidateTokenRequestBuilder()

    type SecurityInvalidateTokenResponse = {
        [<JsonPropertyName("error_count")>]
        ErrorCount: float
        [<JsonPropertyName("error_details")>]
        ErrorDetails: ErrorCause array option
        [<JsonPropertyName("invalidated_tokens")>]
        InvalidatedTokens: float
        [<JsonPropertyName("previously_invalidated_tokens")>]
        PreviouslyInvalidatedTokens: float
    }

    type SecurityGetUserPrivilegesRequest = unit

    let securityGetUserPrivilegesRequest = ()

    type SecurityGetUserPrivilegesResponse = {
        [<JsonPropertyName("applications")>]
        Applications: TypesApplicationPrivileges array
        [<JsonPropertyName("cluster")>]
        Cluster: string array
        [<JsonPropertyName("remote_cluster")>]
        RemoteCluster: TypesRemoteClusterPrivileges array option
        [<JsonPropertyName("global")>]
        Global: TypesGlobalPrivilege array
        [<JsonPropertyName("indices")>]
        Indices: TypesUserIndicesPrivileges array
        [<JsonPropertyName("remote_indices")>]
        RemoteIndices: TypesRemoteUserIndicesPrivileges array option
        [<JsonPropertyName("run_as")>]
        RunAs: string array
    }

    type SecurityGetUserProfileRequest = {
        Uid: System.Text.Json.JsonElement
        Data: System.Text.Json.JsonElement option
    } with
        static member ToRequest(request: SecurityGetUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{request.Uid}"
                let queryParams =
                    [
                        request.Data |> Option.map (fun v -> "data", Fes.Http.toQueryValue v)
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

    module SecurityGetUserProfileRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGetUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGetUserProfileRequest.ToRequest request

    type SecurityGetUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetUserProfileRequest =
            {
                SecurityGetUserProfileRequest.Uid = Unchecked.defaultof<System.Text.Json.JsonElement>
                SecurityGetUserProfileRequest.Data = Option.None
            } : SecurityGetUserProfileRequest

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityGetUserProfileRequest, value: System.Text.Json.JsonElement) =
            { state with SecurityGetUserProfileRequest.Uid = value } : SecurityGetUserProfileRequest

        [<CustomOperation("data")>]
        member _.Data(state: SecurityGetUserProfileRequest, value: System.Text.Json.JsonElement) =
            { state with SecurityGetUserProfileRequest.Data = Option.Some value } : SecurityGetUserProfileRequest

    let securityGetUserProfileRequest = SecurityGetUserProfileRequestBuilder()

    type SecurityGetUserProfileResponse = {
        [<JsonPropertyName("profiles")>]
        Profiles: TypesUserProfileWithMetadata array
        [<JsonPropertyName("errors")>]
        Errors: GetUserProfileGetUserProfileErrors option
    }

    type SecurityGrantApiKeyRequest = {
        Refresh: Refresh option
        [<JsonPropertyName("api_key")>]
        ApiKey: GrantApiKeyGrantApiKey
        [<JsonPropertyName("grant_type")>]
        GrantType: GrantApiKeyApiKeyGrantType
        [<JsonPropertyName("access_token")>]
        AccessToken: string option
        [<JsonPropertyName("username")>]
        Username: Username option
        [<JsonPropertyName("password")>]
        Password: Password option
        [<JsonPropertyName("run_as")>]
        RunAs: Username option
    } with
        static member ToRequest(request: SecurityGrantApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/api_key/grant"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``api_key`` = request.ApiKey; ``grant_type`` = request.GrantType; ``access_token`` = request.AccessToken; ``username`` = request.Username; ``password`` = request.Password; ``run_as`` = request.RunAs |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityGrantApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityGrantApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityGrantApiKeyRequest.ToRequest request

    type SecurityGrantApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityGrantApiKeyRequest =
            {
                SecurityGrantApiKeyRequest.Refresh = Option.None
                SecurityGrantApiKeyRequest.ApiKey = Unchecked.defaultof<GrantApiKeyGrantApiKey>
                SecurityGrantApiKeyRequest.GrantType = Unchecked.defaultof<GrantApiKeyApiKeyGrantType>
                SecurityGrantApiKeyRequest.AccessToken = Option.None
                SecurityGrantApiKeyRequest.Username = Option.None
                SecurityGrantApiKeyRequest.Password = Option.None
                SecurityGrantApiKeyRequest.RunAs = Option.None
            } : SecurityGrantApiKeyRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityGrantApiKeyRequest, value: Refresh) =
            { state with SecurityGrantApiKeyRequest.Refresh = Option.Some value } : SecurityGrantApiKeyRequest

        [<CustomOperation("api_key")>]
        member _.ApiKey(state: SecurityGrantApiKeyRequest, value: GrantApiKeyGrantApiKey) =
            { state with SecurityGrantApiKeyRequest.ApiKey = value } : SecurityGrantApiKeyRequest

        [<CustomOperation("grant_type")>]
        member _.GrantType(state: SecurityGrantApiKeyRequest, value: GrantApiKeyApiKeyGrantType) =
            { state with SecurityGrantApiKeyRequest.GrantType = value } : SecurityGrantApiKeyRequest

        [<CustomOperation("access_token")>]
        member _.AccessToken(state: SecurityGrantApiKeyRequest, value: string) =
            { state with SecurityGrantApiKeyRequest.AccessToken = Option.Some value } : SecurityGrantApiKeyRequest

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGrantApiKeyRequest, value: Username) =
            { state with SecurityGrantApiKeyRequest.Username = Option.Some value } : SecurityGrantApiKeyRequest

        [<CustomOperation("password")>]
        member _.Password(state: SecurityGrantApiKeyRequest, value: Password) =
            { state with SecurityGrantApiKeyRequest.Password = Option.Some value } : SecurityGrantApiKeyRequest

        [<CustomOperation("run_as")>]
        member _.RunAs(state: SecurityGrantApiKeyRequest, value: Username) =
            { state with SecurityGrantApiKeyRequest.RunAs = Option.Some value } : SecurityGrantApiKeyRequest

    let securityGrantApiKeyRequest = SecurityGrantApiKeyRequestBuilder()

    type SecurityGrantApiKeyResponse = {
        [<JsonPropertyName("api_key")>]
        ApiKey: string
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("name")>]
        Name: Name
        [<JsonPropertyName("expiration")>]
        Expiration: EpochTimeUnitMillis option
        [<JsonPropertyName("encoded")>]
        Encoded: string
    }

    type SecurityHasPrivilegesRequest = {
        User: Name
        [<JsonPropertyName("application")>]
        Application: HasPrivilegesApplicationPrivilegesCheck array option
        [<JsonPropertyName("cluster")>]
        Cluster: TypesClusterPrivilege array option
        [<JsonPropertyName("index")>]
        Index: HasPrivilegesIndexPrivilegesCheck array option
    } with
        static member ToRequest(request: SecurityHasPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{request.User}/_has_privileges"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``application`` = request.Application; ``cluster`` = request.Cluster; ``index`` = request.Index |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityHasPrivilegesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityHasPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityHasPrivilegesRequest.ToRequest request

    type SecurityHasPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityHasPrivilegesRequest =
            {
                SecurityHasPrivilegesRequest.User = Unchecked.defaultof<Name>
                SecurityHasPrivilegesRequest.Application = Option.None
                SecurityHasPrivilegesRequest.Cluster = Option.None
                SecurityHasPrivilegesRequest.Index = Option.None
            } : SecurityHasPrivilegesRequest

        [<CustomOperation("user")>]
        member _.User(state: SecurityHasPrivilegesRequest, value: Name) =
            { state with SecurityHasPrivilegesRequest.User = value } : SecurityHasPrivilegesRequest

        [<CustomOperation("application")>]
        member _.Application(state: SecurityHasPrivilegesRequest, value: HasPrivilegesApplicationPrivilegesCheck array) =
            { state with SecurityHasPrivilegesRequest.Application = Option.Some value } : SecurityHasPrivilegesRequest

        [<CustomOperation("cluster")>]
        member _.Cluster(state: SecurityHasPrivilegesRequest, value: TypesClusterPrivilege array) =
            { state with SecurityHasPrivilegesRequest.Cluster = Option.Some value } : SecurityHasPrivilegesRequest

        [<CustomOperation("index")>]
        member _.Index(state: SecurityHasPrivilegesRequest, value: HasPrivilegesIndexPrivilegesCheck array) =
            { state with SecurityHasPrivilegesRequest.Index = Option.Some value } : SecurityHasPrivilegesRequest

    let securityHasPrivilegesRequest = SecurityHasPrivilegesRequestBuilder()

    type SecurityHasPrivilegesUserProfileRequest = {
        [<JsonPropertyName("uids")>]
        Uids: TypesUserProfileId array
        [<JsonPropertyName("privileges")>]
        Privileges: HasPrivilegesUserProfilePrivilegesCheck
    } with
        static member ToRequest(request: SecurityHasPrivilegesUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/profile/_has_privileges"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``uids`` = request.Uids; ``privileges`` = request.Privileges |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityHasPrivilegesUserProfileRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityHasPrivilegesUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityHasPrivilegesUserProfileRequest.ToRequest request

    type SecurityHasPrivilegesUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityHasPrivilegesUserProfileRequest =
            {
                SecurityHasPrivilegesUserProfileRequest.Uids = [||]
                SecurityHasPrivilegesUserProfileRequest.Privileges = Unchecked.defaultof<HasPrivilegesUserProfilePrivilegesCheck>
            } : SecurityHasPrivilegesUserProfileRequest

        [<CustomOperation("uids")>]
        member _.Uids(state: SecurityHasPrivilegesUserProfileRequest, value: TypesUserProfileId array) =
            { state with SecurityHasPrivilegesUserProfileRequest.Uids = value } : SecurityHasPrivilegesUserProfileRequest

        [<CustomOperation("privileges")>]
        member _.Privileges(state: SecurityHasPrivilegesUserProfileRequest, value: HasPrivilegesUserProfilePrivilegesCheck) =
            { state with SecurityHasPrivilegesUserProfileRequest.Privileges = value } : SecurityHasPrivilegesUserProfileRequest

    let securityHasPrivilegesUserProfileRequest = SecurityHasPrivilegesUserProfileRequestBuilder()

    type SecurityOidcAuthenticateRequest = {
        [<JsonPropertyName("nonce")>]
        Nonce: string
        [<JsonPropertyName("realm")>]
        Realm: string option
        [<JsonPropertyName("redirect_uri")>]
        RedirectUri: string
        [<JsonPropertyName("state")>]
        State: string
    } with
        static member ToRequest(request: SecurityOidcAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/oidc/authenticate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``nonce`` = request.Nonce; ``realm`` = request.Realm; ``redirect_uri`` = request.RedirectUri; ``state`` = request.State |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityOidcAuthenticateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityOidcAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityOidcAuthenticateRequest.ToRequest request

    type SecurityOidcAuthenticateRequestBuilder() =
        member _.Yield(_: unit) : SecurityOidcAuthenticateRequest =
            {
                SecurityOidcAuthenticateRequest.Nonce = String.Empty
                SecurityOidcAuthenticateRequest.Realm = Option.None
                SecurityOidcAuthenticateRequest.RedirectUri = String.Empty
                SecurityOidcAuthenticateRequest.State = String.Empty
            } : SecurityOidcAuthenticateRequest

        [<CustomOperation("nonce")>]
        member _.Nonce(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with SecurityOidcAuthenticateRequest.Nonce = value } : SecurityOidcAuthenticateRequest

        [<CustomOperation("realm")>]
        member _.Realm(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with SecurityOidcAuthenticateRequest.Realm = Option.Some value } : SecurityOidcAuthenticateRequest

        [<CustomOperation("redirect_uri")>]
        member _.RedirectUri(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with SecurityOidcAuthenticateRequest.RedirectUri = value } : SecurityOidcAuthenticateRequest

        [<CustomOperation("state")>]
        member _.State(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with SecurityOidcAuthenticateRequest.State = value } : SecurityOidcAuthenticateRequest

    let securityOidcAuthenticateRequest = SecurityOidcAuthenticateRequestBuilder()

    type SecurityOidcAuthenticateResponse = {
        [<JsonPropertyName("access_token")>]
        AccessToken: string
        [<JsonPropertyName("expires_in")>]
        ExpiresIn: float
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string
        [<JsonPropertyName("type")>]
        Type: string
    }

    type SecurityOidcLogoutRequest = {
        [<JsonPropertyName("token")>]
        Token: string
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string option
    } with
        static member ToRequest(request: SecurityOidcLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/oidc/logout"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``token`` = request.Token; ``refresh_token`` = request.RefreshToken |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityOidcLogoutRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityOidcLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityOidcLogoutRequest.ToRequest request

    type SecurityOidcLogoutRequestBuilder() =
        member _.Yield(_: unit) : SecurityOidcLogoutRequest =
            {
                SecurityOidcLogoutRequest.Token = String.Empty
                SecurityOidcLogoutRequest.RefreshToken = Option.None
            } : SecurityOidcLogoutRequest

        [<CustomOperation("token")>]
        member _.Token(state: SecurityOidcLogoutRequest, value: string) =
            { state with SecurityOidcLogoutRequest.Token = value } : SecurityOidcLogoutRequest

        [<CustomOperation("refresh_token")>]
        member _.RefreshToken(state: SecurityOidcLogoutRequest, value: string) =
            { state with SecurityOidcLogoutRequest.RefreshToken = Option.Some value } : SecurityOidcLogoutRequest

    let securityOidcLogoutRequest = SecurityOidcLogoutRequestBuilder()

    type SecurityOidcLogoutResponse = {
        [<JsonPropertyName("redirect")>]
        Redirect: string
    }

    type SecurityOidcPrepareAuthenticationRequest = {
        [<JsonPropertyName("iss")>]
        Iss: string option
        [<JsonPropertyName("login_hint")>]
        LoginHint: string option
        [<JsonPropertyName("nonce")>]
        Nonce: string option
        [<JsonPropertyName("realm")>]
        Realm: string option
        [<JsonPropertyName("state")>]
        State: string option
    } with
        static member ToRequest(request: SecurityOidcPrepareAuthenticationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/oidc/prepare"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``iss`` = request.Iss; ``login_hint`` = request.LoginHint; ``nonce`` = request.Nonce; ``realm`` = request.Realm; ``state`` = request.State |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityOidcPrepareAuthenticationRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityOidcPrepareAuthenticationRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityOidcPrepareAuthenticationRequest.ToRequest request

    type SecurityOidcPrepareAuthenticationRequestBuilder() =
        member _.Yield(_: unit) : SecurityOidcPrepareAuthenticationRequest =
            {
                SecurityOidcPrepareAuthenticationRequest.Iss = Option.None
                SecurityOidcPrepareAuthenticationRequest.LoginHint = Option.None
                SecurityOidcPrepareAuthenticationRequest.Nonce = Option.None
                SecurityOidcPrepareAuthenticationRequest.Realm = Option.None
                SecurityOidcPrepareAuthenticationRequest.State = Option.None
            } : SecurityOidcPrepareAuthenticationRequest

        [<CustomOperation("iss")>]
        member _.Iss(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with SecurityOidcPrepareAuthenticationRequest.Iss = Option.Some value } : SecurityOidcPrepareAuthenticationRequest

        [<CustomOperation("login_hint")>]
        member _.LoginHint(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with SecurityOidcPrepareAuthenticationRequest.LoginHint = Option.Some value } : SecurityOidcPrepareAuthenticationRequest

        [<CustomOperation("nonce")>]
        member _.Nonce(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with SecurityOidcPrepareAuthenticationRequest.Nonce = Option.Some value } : SecurityOidcPrepareAuthenticationRequest

        [<CustomOperation("realm")>]
        member _.Realm(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with SecurityOidcPrepareAuthenticationRequest.Realm = Option.Some value } : SecurityOidcPrepareAuthenticationRequest

        [<CustomOperation("state")>]
        member _.State(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with SecurityOidcPrepareAuthenticationRequest.State = Option.Some value } : SecurityOidcPrepareAuthenticationRequest

    let securityOidcPrepareAuthenticationRequest = SecurityOidcPrepareAuthenticationRequestBuilder()

    type SecurityOidcPrepareAuthenticationResponse = {
        [<JsonPropertyName("nonce")>]
        Nonce: string
        [<JsonPropertyName("realm")>]
        Realm: string
        [<JsonPropertyName("redirect")>]
        Redirect: string
        [<JsonPropertyName("state")>]
        State: string
    }

    type SecurityPutPrivilegesRequest = {
        Refresh: Refresh option
    } with
        static member ToRequest(request: SecurityPutPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/privilege"
                let queryParams =
                    [
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityPutPrivilegesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityPutPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityPutPrivilegesRequest.ToRequest request

    type SecurityPutPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutPrivilegesRequest =
            {
                SecurityPutPrivilegesRequest.Refresh = Option.None
            } : SecurityPutPrivilegesRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutPrivilegesRequest, value: Refresh) =
            { state with SecurityPutPrivilegesRequest.Refresh = Option.Some value } : SecurityPutPrivilegesRequest

    let securityPutPrivilegesRequest = SecurityPutPrivilegesRequestBuilder()

    type SecurityQueryApiKeysRequest = {
        WithLimitedBy: bool option
        WithProfileUid: bool option
        TypedKeys: bool option
        [<JsonPropertyName("aggregations")>]
        Aggregations: Map<string, QueryApiKeysApiKeyAggregationContainer> option
        [<JsonPropertyName("query")>]
        Query: QueryApiKeysApiKeyQueryContainer option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("sort")>]
        Sort: Sort option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
    } with
        static member ToRequest(request: SecurityQueryApiKeysRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/_query/api_key"
                let queryParams =
                    [
                        request.WithLimitedBy |> Option.map (fun v -> "with_limited_by", Fes.Http.toQueryValue v)
                        request.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
                        request.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``aggregations`` = request.Aggregations; ``query`` = request.Query; ``from`` = request.From; ``sort`` = request.Sort; ``size`` = request.Size; ``search_after`` = request.SearchAfter |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityQueryApiKeysRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityQueryApiKeysRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityQueryApiKeysRequest.ToRequest request

    type SecurityQueryApiKeysRequestBuilder() =
        member _.Yield(_: unit) : SecurityQueryApiKeysRequest =
            {
                SecurityQueryApiKeysRequest.WithLimitedBy = Option.None
                SecurityQueryApiKeysRequest.WithProfileUid = Option.None
                SecurityQueryApiKeysRequest.TypedKeys = Option.None
                SecurityQueryApiKeysRequest.Aggregations = Option.None
                SecurityQueryApiKeysRequest.Query = Option.None
                SecurityQueryApiKeysRequest.From = Option.None
                SecurityQueryApiKeysRequest.Sort = Option.None
                SecurityQueryApiKeysRequest.Size = Option.None
                SecurityQueryApiKeysRequest.SearchAfter = Option.None
            } : SecurityQueryApiKeysRequest

        [<CustomOperation("with_limited_by")>]
        member _.WithLimitedBy(state: SecurityQueryApiKeysRequest, value: bool) =
            { state with SecurityQueryApiKeysRequest.WithLimitedBy = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("with_profile_uid")>]
        member _.WithProfileUid(state: SecurityQueryApiKeysRequest, value: bool) =
            { state with SecurityQueryApiKeysRequest.WithProfileUid = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("typed_keys")>]
        member _.TypedKeys(state: SecurityQueryApiKeysRequest, value: bool) =
            { state with SecurityQueryApiKeysRequest.TypedKeys = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: SecurityQueryApiKeysRequest, value: Map<string, QueryApiKeysApiKeyAggregationContainer>) =
            { state with SecurityQueryApiKeysRequest.Aggregations = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("query")>]
        member _.Query(state: SecurityQueryApiKeysRequest, value: QueryApiKeysApiKeyQueryContainer) =
            { state with SecurityQueryApiKeysRequest.Query = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("from")>]
        member _.From(state: SecurityQueryApiKeysRequest, value: float) =
            { state with SecurityQueryApiKeysRequest.From = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: SecurityQueryApiKeysRequest, value: Sort) =
            { state with SecurityQueryApiKeysRequest.Sort = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("size")>]
        member _.Size(state: SecurityQueryApiKeysRequest, value: float) =
            { state with SecurityQueryApiKeysRequest.Size = Option.Some value } : SecurityQueryApiKeysRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: SecurityQueryApiKeysRequest, value: SortResults) =
            { state with SecurityQueryApiKeysRequest.SearchAfter = Option.Some value } : SecurityQueryApiKeysRequest

    let securityQueryApiKeysRequest = SecurityQueryApiKeysRequestBuilder()

    type SecurityQueryRoleRequest = {
        [<JsonPropertyName("query")>]
        Query: QueryRoleRoleQueryContainer option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("sort")>]
        Sort: Sort option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
    } with
        static member ToRequest(request: SecurityQueryRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/_query/role"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``query`` = request.Query; ``from`` = request.From; ``sort`` = request.Sort; ``size`` = request.Size; ``search_after`` = request.SearchAfter |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityQueryRoleRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityQueryRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityQueryRoleRequest.ToRequest request

    type SecurityQueryRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityQueryRoleRequest =
            {
                SecurityQueryRoleRequest.Query = Option.None
                SecurityQueryRoleRequest.From = Option.None
                SecurityQueryRoleRequest.Sort = Option.None
                SecurityQueryRoleRequest.Size = Option.None
                SecurityQueryRoleRequest.SearchAfter = Option.None
            } : SecurityQueryRoleRequest

        [<CustomOperation("query")>]
        member _.Query(state: SecurityQueryRoleRequest, value: QueryRoleRoleQueryContainer) =
            { state with SecurityQueryRoleRequest.Query = Option.Some value } : SecurityQueryRoleRequest

        [<CustomOperation("from")>]
        member _.From(state: SecurityQueryRoleRequest, value: float) =
            { state with SecurityQueryRoleRequest.From = Option.Some value } : SecurityQueryRoleRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: SecurityQueryRoleRequest, value: Sort) =
            { state with SecurityQueryRoleRequest.Sort = Option.Some value } : SecurityQueryRoleRequest

        [<CustomOperation("size")>]
        member _.Size(state: SecurityQueryRoleRequest, value: float) =
            { state with SecurityQueryRoleRequest.Size = Option.Some value } : SecurityQueryRoleRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: SecurityQueryRoleRequest, value: SortResults) =
            { state with SecurityQueryRoleRequest.SearchAfter = Option.Some value } : SecurityQueryRoleRequest

    let securityQueryRoleRequest = SecurityQueryRoleRequestBuilder()

    type SecurityQueryUserRequest = {
        WithProfileUid: bool option
        [<JsonPropertyName("query")>]
        Query: QueryUserUserQueryContainer option
        [<JsonPropertyName("from")>]
        From: float option
        [<JsonPropertyName("sort")>]
        Sort: Sort option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("search_after")>]
        SearchAfter: SortResults option
    } with
        static member ToRequest(request: SecurityQueryUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/_query/user"
                let queryParams =
                    [
                        request.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``query`` = request.Query; ``from`` = request.From; ``sort`` = request.Sort; ``size`` = request.Size; ``search_after`` = request.SearchAfter |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityQueryUserRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityQueryUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityQueryUserRequest.ToRequest request

    type SecurityQueryUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityQueryUserRequest =
            {
                SecurityQueryUserRequest.WithProfileUid = Option.None
                SecurityQueryUserRequest.Query = Option.None
                SecurityQueryUserRequest.From = Option.None
                SecurityQueryUserRequest.Sort = Option.None
                SecurityQueryUserRequest.Size = Option.None
                SecurityQueryUserRequest.SearchAfter = Option.None
            } : SecurityQueryUserRequest

        [<CustomOperation("with_profile_uid")>]
        member _.WithProfileUid(state: SecurityQueryUserRequest, value: bool) =
            { state with SecurityQueryUserRequest.WithProfileUid = Option.Some value } : SecurityQueryUserRequest

        [<CustomOperation("query")>]
        member _.Query(state: SecurityQueryUserRequest, value: QueryUserUserQueryContainer) =
            { state with SecurityQueryUserRequest.Query = Option.Some value } : SecurityQueryUserRequest

        [<CustomOperation("from")>]
        member _.From(state: SecurityQueryUserRequest, value: float) =
            { state with SecurityQueryUserRequest.From = Option.Some value } : SecurityQueryUserRequest

        [<CustomOperation("sort")>]
        member _.Sort(state: SecurityQueryUserRequest, value: Sort) =
            { state with SecurityQueryUserRequest.Sort = Option.Some value } : SecurityQueryUserRequest

        [<CustomOperation("size")>]
        member _.Size(state: SecurityQueryUserRequest, value: float) =
            { state with SecurityQueryUserRequest.Size = Option.Some value } : SecurityQueryUserRequest

        [<CustomOperation("search_after")>]
        member _.SearchAfter(state: SecurityQueryUserRequest, value: SortResults) =
            { state with SecurityQueryUserRequest.SearchAfter = Option.Some value } : SecurityQueryUserRequest

    let securityQueryUserRequest = SecurityQueryUserRequestBuilder()

    type SecuritySamlAuthenticateRequest = {
        [<JsonPropertyName("content")>]
        Content: string
        [<JsonPropertyName("ids")>]
        Ids: Ids
        [<JsonPropertyName("realm")>]
        Realm: string option
    } with
        static member ToRequest(request: SecuritySamlAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/saml/authenticate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``content`` = request.Content; ``ids`` = request.Ids; ``realm`` = request.Realm |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySamlAuthenticateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySamlAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySamlAuthenticateRequest.ToRequest request

    type SecuritySamlAuthenticateRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlAuthenticateRequest =
            {
                SecuritySamlAuthenticateRequest.Content = String.Empty
                SecuritySamlAuthenticateRequest.Ids = Unchecked.defaultof<Ids>
                SecuritySamlAuthenticateRequest.Realm = Option.None
            } : SecuritySamlAuthenticateRequest

        [<CustomOperation("content")>]
        member _.Content(state: SecuritySamlAuthenticateRequest, value: string) =
            { state with SecuritySamlAuthenticateRequest.Content = value } : SecuritySamlAuthenticateRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: SecuritySamlAuthenticateRequest, value: Ids) =
            { state with SecuritySamlAuthenticateRequest.Ids = value } : SecuritySamlAuthenticateRequest

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlAuthenticateRequest, value: string) =
            { state with SecuritySamlAuthenticateRequest.Realm = Option.Some value } : SecuritySamlAuthenticateRequest

    let securitySamlAuthenticateRequest = SecuritySamlAuthenticateRequestBuilder()

    type SecuritySamlAuthenticateResponse = {
        [<JsonPropertyName("access_token")>]
        AccessToken: string
        [<JsonPropertyName("username")>]
        Username: string
        [<JsonPropertyName("expires_in")>]
        ExpiresIn: float
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string
        [<JsonPropertyName("realm")>]
        Realm: string
        [<JsonPropertyName("in_response_to")>]
        InResponseTo: string option
    }

    type SecuritySamlCompleteLogoutRequest = {
        [<JsonPropertyName("realm")>]
        Realm: string
        [<JsonPropertyName("ids")>]
        Ids: Ids
        [<JsonPropertyName("query_string")>]
        QueryString: string option
        [<JsonPropertyName("content")>]
        Content: string option
    } with
        static member ToRequest(request: SecuritySamlCompleteLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/saml/complete_logout"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``realm`` = request.Realm; ``ids`` = request.Ids; ``query_string`` = request.QueryString; ``content`` = request.Content |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySamlCompleteLogoutRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySamlCompleteLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySamlCompleteLogoutRequest.ToRequest request

    type SecuritySamlCompleteLogoutRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlCompleteLogoutRequest =
            {
                SecuritySamlCompleteLogoutRequest.Realm = String.Empty
                SecuritySamlCompleteLogoutRequest.Ids = Unchecked.defaultof<Ids>
                SecuritySamlCompleteLogoutRequest.QueryString = Option.None
                SecuritySamlCompleteLogoutRequest.Content = Option.None
            } : SecuritySamlCompleteLogoutRequest

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlCompleteLogoutRequest, value: string) =
            { state with SecuritySamlCompleteLogoutRequest.Realm = value } : SecuritySamlCompleteLogoutRequest

        [<CustomOperation("ids")>]
        member _.Ids(state: SecuritySamlCompleteLogoutRequest, value: Ids) =
            { state with SecuritySamlCompleteLogoutRequest.Ids = value } : SecuritySamlCompleteLogoutRequest

        [<CustomOperation("query_string")>]
        member _.QueryString(state: SecuritySamlCompleteLogoutRequest, value: string) =
            { state with SecuritySamlCompleteLogoutRequest.QueryString = Option.Some value } : SecuritySamlCompleteLogoutRequest

        [<CustomOperation("content")>]
        member _.Content(state: SecuritySamlCompleteLogoutRequest, value: string) =
            { state with SecuritySamlCompleteLogoutRequest.Content = Option.Some value } : SecuritySamlCompleteLogoutRequest

    let securitySamlCompleteLogoutRequest = SecuritySamlCompleteLogoutRequestBuilder()

    type SecuritySamlInvalidateRequest = {
        [<JsonPropertyName("acs")>]
        Acs: string option
        [<JsonPropertyName("query_string")>]
        QueryString: string
        [<JsonPropertyName("realm")>]
        Realm: string option
    } with
        static member ToRequest(request: SecuritySamlInvalidateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/saml/invalidate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``acs`` = request.Acs; ``query_string`` = request.QueryString; ``realm`` = request.Realm |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySamlInvalidateRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySamlInvalidateRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySamlInvalidateRequest.ToRequest request

    type SecuritySamlInvalidateRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlInvalidateRequest =
            {
                SecuritySamlInvalidateRequest.Acs = Option.None
                SecuritySamlInvalidateRequest.QueryString = String.Empty
                SecuritySamlInvalidateRequest.Realm = Option.None
            } : SecuritySamlInvalidateRequest

        [<CustomOperation("acs")>]
        member _.Acs(state: SecuritySamlInvalidateRequest, value: string) =
            { state with SecuritySamlInvalidateRequest.Acs = Option.Some value } : SecuritySamlInvalidateRequest

        [<CustomOperation("query_string")>]
        member _.QueryString(state: SecuritySamlInvalidateRequest, value: string) =
            { state with SecuritySamlInvalidateRequest.QueryString = value } : SecuritySamlInvalidateRequest

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlInvalidateRequest, value: string) =
            { state with SecuritySamlInvalidateRequest.Realm = Option.Some value } : SecuritySamlInvalidateRequest

    let securitySamlInvalidateRequest = SecuritySamlInvalidateRequestBuilder()

    type SecuritySamlInvalidateResponse = {
        [<JsonPropertyName("invalidated")>]
        Invalidated: float
        [<JsonPropertyName("realm")>]
        Realm: string
        [<JsonPropertyName("redirect")>]
        Redirect: string
    }

    type SecuritySamlLogoutRequest = {
        [<JsonPropertyName("token")>]
        Token: string
        [<JsonPropertyName("refresh_token")>]
        RefreshToken: string option
    } with
        static member ToRequest(request: SecuritySamlLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/saml/logout"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``token`` = request.Token; ``refresh_token`` = request.RefreshToken |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySamlLogoutRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySamlLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySamlLogoutRequest.ToRequest request

    type SecuritySamlLogoutRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlLogoutRequest =
            {
                SecuritySamlLogoutRequest.Token = String.Empty
                SecuritySamlLogoutRequest.RefreshToken = Option.None
            } : SecuritySamlLogoutRequest

        [<CustomOperation("token")>]
        member _.Token(state: SecuritySamlLogoutRequest, value: string) =
            { state with SecuritySamlLogoutRequest.Token = value } : SecuritySamlLogoutRequest

        [<CustomOperation("refresh_token")>]
        member _.RefreshToken(state: SecuritySamlLogoutRequest, value: string) =
            { state with SecuritySamlLogoutRequest.RefreshToken = Option.Some value } : SecuritySamlLogoutRequest

    let securitySamlLogoutRequest = SecuritySamlLogoutRequestBuilder()

    type SecuritySamlLogoutResponse = {
        [<JsonPropertyName("redirect")>]
        Redirect: string
    }

    type SecuritySamlPrepareAuthenticationRequest = {
        [<JsonPropertyName("acs")>]
        Acs: string option
        [<JsonPropertyName("realm")>]
        Realm: string option
        [<JsonPropertyName("relay_state")>]
        RelayState: string option
    } with
        static member ToRequest(request: SecuritySamlPrepareAuthenticationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/saml/prepare"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``acs`` = request.Acs; ``realm`` = request.Realm; ``relay_state`` = request.RelayState |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySamlPrepareAuthenticationRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySamlPrepareAuthenticationRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySamlPrepareAuthenticationRequest.ToRequest request

    type SecuritySamlPrepareAuthenticationRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlPrepareAuthenticationRequest =
            {
                SecuritySamlPrepareAuthenticationRequest.Acs = Option.None
                SecuritySamlPrepareAuthenticationRequest.Realm = Option.None
                SecuritySamlPrepareAuthenticationRequest.RelayState = Option.None
            } : SecuritySamlPrepareAuthenticationRequest

        [<CustomOperation("acs")>]
        member _.Acs(state: SecuritySamlPrepareAuthenticationRequest, value: string) =
            { state with SecuritySamlPrepareAuthenticationRequest.Acs = Option.Some value } : SecuritySamlPrepareAuthenticationRequest

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlPrepareAuthenticationRequest, value: string) =
            { state with SecuritySamlPrepareAuthenticationRequest.Realm = Option.Some value } : SecuritySamlPrepareAuthenticationRequest

        [<CustomOperation("relay_state")>]
        member _.RelayState(state: SecuritySamlPrepareAuthenticationRequest, value: string) =
            { state with SecuritySamlPrepareAuthenticationRequest.RelayState = Option.Some value } : SecuritySamlPrepareAuthenticationRequest

    let securitySamlPrepareAuthenticationRequest = SecuritySamlPrepareAuthenticationRequestBuilder()

    type SecuritySamlPrepareAuthenticationResponse = {
        [<JsonPropertyName("id")>]
        Id: Id
        [<JsonPropertyName("realm")>]
        Realm: string
        [<JsonPropertyName("redirect")>]
        Redirect: string
    }

    type SecuritySamlServiceProviderMetadataRequest = {
        RealmName: Name
    } with
        static member ToRequest(request: SecuritySamlServiceProviderMetadataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/metadata/{request.RealmName}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySamlServiceProviderMetadataRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySamlServiceProviderMetadataRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySamlServiceProviderMetadataRequest.ToRequest request

    type SecuritySamlServiceProviderMetadataRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlServiceProviderMetadataRequest =
            {
                SecuritySamlServiceProviderMetadataRequest.RealmName = Unchecked.defaultof<Name>
            } : SecuritySamlServiceProviderMetadataRequest

        [<CustomOperation("realm_name")>]
        member _.RealmName(state: SecuritySamlServiceProviderMetadataRequest, value: Name) =
            { state with SecuritySamlServiceProviderMetadataRequest.RealmName = value } : SecuritySamlServiceProviderMetadataRequest

    let securitySamlServiceProviderMetadataRequest = SecuritySamlServiceProviderMetadataRequestBuilder()

    type SecuritySamlServiceProviderMetadataResponse = {
        [<JsonPropertyName("metadata")>]
        Metadata: string
    }

    type SecuritySuggestUserProfilesRequest = {
        Data: System.Text.Json.JsonElement option
        [<JsonPropertyName("name")>]
        Name: string option
        [<JsonPropertyName("size")>]
        Size: float option
        [<JsonPropertyName("data")>]
        Data2: System.Text.Json.JsonElement option
        [<JsonPropertyName("hint")>]
        Hint: SuggestUserProfilesHint option
    } with
        static member ToRequest(request: SecuritySuggestUserProfilesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = "/_security/profile/_suggest"
                let queryParams =
                    [
                        request.Data |> Option.map (fun v -> "data", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``name`` = request.Name; ``size`` = request.Size; ``data`` = request.Data2; ``hint`` = request.Hint |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecuritySuggestUserProfilesRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecuritySuggestUserProfilesRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecuritySuggestUserProfilesRequest.ToRequest request

    type SecuritySuggestUserProfilesRequestBuilder() =
        member _.Yield(_: unit) : SecuritySuggestUserProfilesRequest =
            {
                SecuritySuggestUserProfilesRequest.Data = Option.None
                SecuritySuggestUserProfilesRequest.Name = Option.None
                SecuritySuggestUserProfilesRequest.Size = Option.None
                SecuritySuggestUserProfilesRequest.Data2 = Option.None
                SecuritySuggestUserProfilesRequest.Hint = Option.None
            } : SecuritySuggestUserProfilesRequest

        [<CustomOperation("data")>]
        member _.Data(state: SecuritySuggestUserProfilesRequest, value: System.Text.Json.JsonElement) =
            { state with SecuritySuggestUserProfilesRequest.Data = Option.Some value } : SecuritySuggestUserProfilesRequest

        [<CustomOperation("name")>]
        member _.Name(state: SecuritySuggestUserProfilesRequest, value: string) =
            { state with SecuritySuggestUserProfilesRequest.Name = Option.Some value } : SecuritySuggestUserProfilesRequest

        [<CustomOperation("size")>]
        member _.Size(state: SecuritySuggestUserProfilesRequest, value: float) =
            { state with SecuritySuggestUserProfilesRequest.Size = Option.Some value } : SecuritySuggestUserProfilesRequest

        [<CustomOperation("data2")>]
        member _.Data2(state: SecuritySuggestUserProfilesRequest, value: System.Text.Json.JsonElement) =
            { state with SecuritySuggestUserProfilesRequest.Data2 = Option.Some value } : SecuritySuggestUserProfilesRequest

        [<CustomOperation("hint")>]
        member _.Hint(state: SecuritySuggestUserProfilesRequest, value: SuggestUserProfilesHint) =
            { state with SecuritySuggestUserProfilesRequest.Hint = Option.Some value } : SecuritySuggestUserProfilesRequest

    let securitySuggestUserProfilesRequest = SecuritySuggestUserProfilesRequestBuilder()

    type SecurityUpdateApiKeyRequest = {
        Id: Id
        [<JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, TypesRoleDescriptor> option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("expiration")>]
        Expiration: Duration option
    } with
        static member ToRequest(request: SecurityUpdateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``role_descriptors`` = request.RoleDescriptors; ``metadata`` = request.Metadata; ``expiration`` = request.Expiration |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityUpdateApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityUpdateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityUpdateApiKeyRequest.ToRequest request

    type SecurityUpdateApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateApiKeyRequest =
            {
                SecurityUpdateApiKeyRequest.Id = Unchecked.defaultof<Id>
                SecurityUpdateApiKeyRequest.RoleDescriptors = Option.None
                SecurityUpdateApiKeyRequest.Metadata = Option.None
                SecurityUpdateApiKeyRequest.Expiration = Option.None
            } : SecurityUpdateApiKeyRequest

        [<CustomOperation("id")>]
        member _.Id(state: SecurityUpdateApiKeyRequest, value: Id) =
            { state with SecurityUpdateApiKeyRequest.Id = value } : SecurityUpdateApiKeyRequest

        [<CustomOperation("role_descriptors")>]
        member _.RoleDescriptors(state: SecurityUpdateApiKeyRequest, value: Map<string, TypesRoleDescriptor>) =
            { state with SecurityUpdateApiKeyRequest.RoleDescriptors = Option.Some value } : SecurityUpdateApiKeyRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityUpdateApiKeyRequest, value: Metadata) =
            { state with SecurityUpdateApiKeyRequest.Metadata = Option.Some value } : SecurityUpdateApiKeyRequest

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityUpdateApiKeyRequest, value: Duration) =
            { state with SecurityUpdateApiKeyRequest.Expiration = Option.Some value } : SecurityUpdateApiKeyRequest

    let securityUpdateApiKeyRequest = SecurityUpdateApiKeyRequestBuilder()

    type SecurityUpdateApiKeyResponse = {
        [<JsonPropertyName("updated")>]
        Updated: bool
    }

    type SecurityUpdateCrossClusterApiKeyRequest = {
        Id: Id
        [<JsonPropertyName("access")>]
        Access: TypesAccess
        [<JsonPropertyName("expiration")>]
        Expiration: Duration option
        [<JsonPropertyName("metadata")>]
        Metadata: Metadata option
        [<JsonPropertyName("certificate_identity")>]
        CertificateIdentity: string option
    } with
        static member ToRequest(request: SecurityUpdateCrossClusterApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/cross_cluster/api_key/{request.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody {| ``access`` = request.Access; ``expiration`` = request.Expiration; ``metadata`` = request.Metadata; ``certificate_identity`` = request.CertificateIdentity |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityUpdateCrossClusterApiKeyRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityUpdateCrossClusterApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityUpdateCrossClusterApiKeyRequest.ToRequest request

    type SecurityUpdateCrossClusterApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateCrossClusterApiKeyRequest =
            {
                SecurityUpdateCrossClusterApiKeyRequest.Id = Unchecked.defaultof<Id>
                SecurityUpdateCrossClusterApiKeyRequest.Access = Unchecked.defaultof<TypesAccess>
                SecurityUpdateCrossClusterApiKeyRequest.Expiration = Option.None
                SecurityUpdateCrossClusterApiKeyRequest.Metadata = Option.None
                SecurityUpdateCrossClusterApiKeyRequest.CertificateIdentity = Option.None
            } : SecurityUpdateCrossClusterApiKeyRequest

        [<CustomOperation("id")>]
        member _.Id(state: SecurityUpdateCrossClusterApiKeyRequest, value: Id) =
            { state with SecurityUpdateCrossClusterApiKeyRequest.Id = value } : SecurityUpdateCrossClusterApiKeyRequest

        [<CustomOperation("access")>]
        member _.Access(state: SecurityUpdateCrossClusterApiKeyRequest, value: TypesAccess) =
            { state with SecurityUpdateCrossClusterApiKeyRequest.Access = value } : SecurityUpdateCrossClusterApiKeyRequest

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityUpdateCrossClusterApiKeyRequest, value: Duration) =
            { state with SecurityUpdateCrossClusterApiKeyRequest.Expiration = Option.Some value } : SecurityUpdateCrossClusterApiKeyRequest

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityUpdateCrossClusterApiKeyRequest, value: Metadata) =
            { state with SecurityUpdateCrossClusterApiKeyRequest.Metadata = Option.Some value } : SecurityUpdateCrossClusterApiKeyRequest

        [<CustomOperation("certificate_identity")>]
        member _.CertificateIdentity(state: SecurityUpdateCrossClusterApiKeyRequest, value: string) =
            { state with SecurityUpdateCrossClusterApiKeyRequest.CertificateIdentity = Option.Some value } : SecurityUpdateCrossClusterApiKeyRequest

    let securityUpdateCrossClusterApiKeyRequest = SecurityUpdateCrossClusterApiKeyRequestBuilder()

    type SecurityUpdateCrossClusterApiKeyResponse = {
        [<JsonPropertyName("updated")>]
        Updated: bool
    }

    type SecurityUpdateUserProfileDataRequest = {
        Uid: TypesUserProfileId
        IfSeqNo: SequenceNumber option
        IfPrimaryTerm: float option
        Refresh: Refresh option
        [<JsonPropertyName("labels")>]
        Labels: Map<string, obj> option
        [<JsonPropertyName("data")>]
        Data: Map<string, obj> option
    } with
        static member ToRequest(request: SecurityUpdateUserProfileDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{request.Uid}/_data"
                let queryParams =
                    [
                        request.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        request.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        request.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k,v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody {| ``labels`` = request.Labels; ``data`` = request.Data |}
                |> Result.Ok
            with ex -> Result.Error ex

    module SecurityUpdateUserProfileDataRequestHelpers =
        /// Convert request to HTTP request message
        let toRequest (request: SecurityUpdateUserProfileDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            SecurityUpdateUserProfileDataRequest.ToRequest request

    type SecurityUpdateUserProfileDataRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateUserProfileDataRequest =
            {
                SecurityUpdateUserProfileDataRequest.Uid = Unchecked.defaultof<TypesUserProfileId>
                SecurityUpdateUserProfileDataRequest.IfSeqNo = Option.None
                SecurityUpdateUserProfileDataRequest.IfPrimaryTerm = Option.None
                SecurityUpdateUserProfileDataRequest.Refresh = Option.None
                SecurityUpdateUserProfileDataRequest.Labels = Option.None
                SecurityUpdateUserProfileDataRequest.Data = Option.None
            } : SecurityUpdateUserProfileDataRequest

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityUpdateUserProfileDataRequest, value: TypesUserProfileId) =
            { state with SecurityUpdateUserProfileDataRequest.Uid = value } : SecurityUpdateUserProfileDataRequest

        [<CustomOperation("if_seq_no")>]
        member _.IfSeqNo(state: SecurityUpdateUserProfileDataRequest, value: SequenceNumber) =
            { state with SecurityUpdateUserProfileDataRequest.IfSeqNo = Option.Some value } : SecurityUpdateUserProfileDataRequest

        [<CustomOperation("if_primary_term")>]
        member _.IfPrimaryTerm(state: SecurityUpdateUserProfileDataRequest, value: float) =
            { state with SecurityUpdateUserProfileDataRequest.IfPrimaryTerm = Option.Some value } : SecurityUpdateUserProfileDataRequest

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityUpdateUserProfileDataRequest, value: Refresh) =
            { state with SecurityUpdateUserProfileDataRequest.Refresh = Option.Some value } : SecurityUpdateUserProfileDataRequest

        [<CustomOperation("labels")>]
        member _.Labels(state: SecurityUpdateUserProfileDataRequest, value: Map<string, obj>) =
            { state with SecurityUpdateUserProfileDataRequest.Labels = Option.Some value } : SecurityUpdateUserProfileDataRequest

        [<CustomOperation("data")>]
        member _.Data(state: SecurityUpdateUserProfileDataRequest, value: Map<string, obj>) =
            { state with SecurityUpdateUserProfileDataRequest.Data = Option.Some value } : SecurityUpdateUserProfileDataRequest

    let securityUpdateUserProfileDataRequest = SecurityUpdateUserProfileDataRequestBuilder()

    type SslCertificatesRequest = unit

    let sslCertificatesRequest = ()

