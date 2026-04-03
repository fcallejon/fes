// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Operations


open System
open System.Text.Json
open System.Text.Json.Serialization
open Fes
open Fes.Generated

[<AutoOpen>]
module SecurityOperations =

    type SecurityActivateUserProfileRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("access_token")>]
        AccessToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("grant_type")>]
        GrantType: Types.GrantType
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: string option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: string option
    }

        with
        static member ToRequest(req: SecurityActivateUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/_activate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityActivateUserProfileResponse = Types.UserProfileWithMetadata

    type SecurityActivateUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityActivateUserProfileRequest =
            {
                AccessToken = None
                GrantType = Unchecked.defaultof<_>
                Password = None
                Username = None
            }

        [<CustomOperation("accessToken")>]
        member _.AccessToken(state: SecurityActivateUserProfileRequest, value: string) =
            { state with AccessToken = Some value }

        [<CustomOperation("grantType")>]
        member _.GrantType(state: SecurityActivateUserProfileRequest, value: Types.GrantType) =
            { state with GrantType = value }

        [<CustomOperation("password")>]
        member _.Password(state: SecurityActivateUserProfileRequest, value: string) =
            { state with Password = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityActivateUserProfileRequest, value: string) =
            { state with Username = Some value }

    let securityActivateUserProfileRequest = SecurityActivateUserProfileRequestBuilder()

    module ActivateUserProfile =
        let withAccessToken (value: string) (req: SecurityActivateUserProfileRequest) =
            { req with AccessToken = Some value }
        let withGrantType (value: Types.GrantType) (req: SecurityActivateUserProfileRequest) =
            { req with GrantType = value }
        let withPassword (value: string) (req: SecurityActivateUserProfileRequest) =
            { req with Password = Some value }
        let withUsername (value: string) (req: SecurityActivateUserProfileRequest) =
            { req with Username = Some value }

    type SecurityAuthenticateRequest = | SecurityAuthenticateRequest

        with
        static member ToRequest(req: SecurityAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/_authenticate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityAuthenticateResponse = System.Text.Json.JsonElement

    type SecurityAuthenticateRequestBuilder() =
        member _.Yield(_: unit) : SecurityAuthenticateRequest =
            {
            }

    let securityAuthenticateRequest = SecurityAuthenticateRequestBuilder()

    type SecurityBulkDeleteRoleRequest = {
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: string list
    }

        with
        static member ToRequest(req: SecurityBulkDeleteRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role"
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
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityBulkDeleteRoleResponse = System.Text.Json.JsonElement

    type SecurityBulkDeleteRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityBulkDeleteRoleRequest =
            {
                Refresh = None
                Names = Unchecked.defaultof<_>
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityBulkDeleteRoleRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: SecurityBulkDeleteRoleRequest, value: string list) =
            { state with Names = value }

    let securityBulkDeleteRoleRequest = SecurityBulkDeleteRoleRequestBuilder()

    module BulkDeleteRole =
        let withRefresh (value: Types.Refresh) (req: SecurityBulkDeleteRoleRequest) =
            { req with Refresh = Some value }
        let withNames (value: string list) (req: SecurityBulkDeleteRoleRequest) =
            { req with Names = value }

    type SecurityBulkPutRoleRequest = {
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Map<string, Types.RoleDescriptor>
    }

        with
        static member ToRequest(req: SecurityBulkPutRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityBulkPutRoleResponse = System.Text.Json.JsonElement

    type SecurityBulkPutRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityBulkPutRoleRequest =
            {
                Refresh = None
                Roles = Unchecked.defaultof<_>
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityBulkPutRoleRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: SecurityBulkPutRoleRequest, value: Map<string, Types.RoleDescriptor>) =
            { state with Roles = value }

    let securityBulkPutRoleRequest = SecurityBulkPutRoleRequestBuilder()

    module BulkPutRole =
        let withRefresh (value: Types.Refresh) (req: SecurityBulkPutRoleRequest) =
            { req with Refresh = Some value }
        let withRoles (value: Map<string, Types.RoleDescriptor>) (req: SecurityBulkPutRoleRequest) =
            { req with Roles = value }

    type SecurityBulkUpdateApiKeysRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, Types.RoleDescriptor> option
    }

        with
        static member ToRequest(req: SecurityBulkUpdateApiKeysRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key/_bulk_update"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityBulkUpdateApiKeysResponse = System.Text.Json.JsonElement

    type SecurityBulkUpdateApiKeysRequestBuilder() =
        member _.Yield(_: unit) : SecurityBulkUpdateApiKeysRequest =
            {
                Expiration = None
                Ids = Unchecked.defaultof<_>
                Metadata = None
                RoleDescriptors = None
            }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityBulkUpdateApiKeysRequest, value: Types.Duration) =
            { state with Expiration = Some value }

        [<CustomOperation("ids")>]
        member _.Ids(state: SecurityBulkUpdateApiKeysRequest, value: System.Text.Json.JsonElement) =
            { state with Ids = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityBulkUpdateApiKeysRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("roleDescriptors")>]
        member _.RoleDescriptors(state: SecurityBulkUpdateApiKeysRequest, value: Map<string, Types.RoleDescriptor>) =
            { state with RoleDescriptors = Some value }

    let securityBulkUpdateApiKeysRequest = SecurityBulkUpdateApiKeysRequestBuilder()

    module BulkUpdateApiKeys =
        let withExpiration (value: Types.Duration) (req: SecurityBulkUpdateApiKeysRequest) =
            { req with Expiration = Some value }
        let withIds (value: System.Text.Json.JsonElement) (req: SecurityBulkUpdateApiKeysRequest) =
            { req with Ids = value }
        let withMetadata (value: Types.Metadata) (req: SecurityBulkUpdateApiKeysRequest) =
            { req with Metadata = Some value }
        let withRoleDescriptors (value: Map<string, Types.RoleDescriptor>) (req: SecurityBulkUpdateApiKeysRequest) =
            { req with RoleDescriptors = Some value }

    type SecurityChangePasswordRequest = {
        Username: Types.Username
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: Types.Password option
        [<System.Text.Json.Serialization.JsonPropertyName("password_hash")>]
        PasswordHash: string option
    }

        with
        static member ToRequest(req: SecurityChangePasswordRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.Username}/_password"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityChangePasswordResponse = System.Text.Json.JsonElement

    type SecurityChangePasswordRequestBuilder() =
        member _.Yield(_: unit) : SecurityChangePasswordRequest =
            {
                Username = Unchecked.defaultof<_>
                Refresh = None
                Password = None
                PasswordHash = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityChangePasswordRequest, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityChangePasswordRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("password")>]
        member _.Password(state: SecurityChangePasswordRequest, value: Types.Password) =
            { state with Password = Some value }

        [<CustomOperation("passwordHash")>]
        member _.PasswordHash(state: SecurityChangePasswordRequest, value: string) =
            { state with PasswordHash = Some value }

    let securityChangePasswordRequest = SecurityChangePasswordRequestBuilder()

    module ChangePassword =
        let withRefresh (value: Types.Refresh) (req: SecurityChangePasswordRequest) =
            { req with Refresh = Some value }
        let withPassword (value: Types.Password) (req: SecurityChangePasswordRequest) =
            { req with Password = Some value }
        let withPasswordHash (value: string) (req: SecurityChangePasswordRequest) =
            { req with PasswordHash = Some value }

    type SecurityClearApiKeyCacheRequest = {
        Ids: Types.Ids
    }

        with
        static member ToRequest(req: SecurityClearApiKeyCacheRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key/{req.Ids}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityClearApiKeyCacheResponse = System.Text.Json.JsonElement

    type SecurityClearApiKeyCacheRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearApiKeyCacheRequest =
            {
                Ids = Unchecked.defaultof<_>
            }

        [<CustomOperation("ids")>]
        member _.Ids(state: SecurityClearApiKeyCacheRequest, value: Types.Ids) =
            { state with Ids = value }

    let securityClearApiKeyCacheRequest = SecurityClearApiKeyCacheRequestBuilder()

    type SecurityClearCachedPrivilegesRequest = {
        Application: Types.Names
    }

        with
        static member ToRequest(req: SecurityClearCachedPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/{req.Application}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityClearCachedPrivilegesResponse = System.Text.Json.JsonElement

    type SecurityClearCachedPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedPrivilegesRequest =
            {
                Application = Unchecked.defaultof<_>
            }

        [<CustomOperation("application")>]
        member _.Application(state: SecurityClearCachedPrivilegesRequest, value: Types.Names) =
            { state with Application = value }

    let securityClearCachedPrivilegesRequest = SecurityClearCachedPrivilegesRequestBuilder()

    type SecurityClearCachedRealmsRequest = {
        Realms: Types.Names
        Usernames: string list option
    }

        with
        static member ToRequest(req: SecurityClearCachedRealmsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/realm/{req.Realms}/_clear_cache"
                let queryParams =
                    [
                        req.Usernames |> Option.map (fun v -> "usernames", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityClearCachedRealmsResponse = System.Text.Json.JsonElement

    type SecurityClearCachedRealmsRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedRealmsRequest =
            {
                Realms = Unchecked.defaultof<_>
                Usernames = None
            }

        [<CustomOperation("realms")>]
        member _.Realms(state: SecurityClearCachedRealmsRequest, value: Types.Names) =
            { state with Realms = value }

        [<CustomOperation("usernames")>]
        member _.Usernames(state: SecurityClearCachedRealmsRequest, value: string list) =
            { state with Usernames = Some value }

    let securityClearCachedRealmsRequest = SecurityClearCachedRealmsRequestBuilder()

    module ClearCachedRealms =
        let withUsernames (value: string list) (req: SecurityClearCachedRealmsRequest) =
            { req with Usernames = Some value }

    type SecurityClearCachedRolesRequest = {
        Name: Types.Names
    }

        with
        static member ToRequest(req: SecurityClearCachedRolesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{req.Name}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityClearCachedRolesResponse = System.Text.Json.JsonElement

    type SecurityClearCachedRolesRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedRolesRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityClearCachedRolesRequest, value: Types.Names) =
            { state with Name = value }

    let securityClearCachedRolesRequest = SecurityClearCachedRolesRequestBuilder()

    type SecurityClearCachedServiceTokensRequest = {
        Namespace: Types.Namespace
        Service: Types.Service
        Name: Types.Names
    }

        with
        static member ToRequest(req: SecurityClearCachedServiceTokensRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{req.Namespace}/{req.Service}/credential/token/{req.Name}/_clear_cache"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityClearCachedServiceTokensResponse = System.Text.Json.JsonElement

    type SecurityClearCachedServiceTokensRequestBuilder() =
        member _.Yield(_: unit) : SecurityClearCachedServiceTokensRequest =
            {
                Namespace = Unchecked.defaultof<_>
                Service = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: SecurityClearCachedServiceTokensRequest, value: Types.Namespace) =
            { state with Namespace = value }

        [<CustomOperation("service")>]
        member _.Service(state: SecurityClearCachedServiceTokensRequest, value: Types.Service) =
            { state with Service = value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityClearCachedServiceTokensRequest, value: Types.Names) =
            { state with Name = value }

    let securityClearCachedServiceTokensRequest = SecurityClearCachedServiceTokensRequestBuilder()

    type SecurityCreateApiKeyRequest = {
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, Types.RoleDescriptor> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
    }

        with
        static member ToRequest(req: SecurityCreateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityCreateApiKeyResponse = System.Text.Json.JsonElement

    type SecurityCreateApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityCreateApiKeyRequest =
            {
                Refresh = None
                Expiration = None
                Name = None
                RoleDescriptors = None
                Metadata = None
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityCreateApiKeyRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityCreateApiKeyRequest, value: Types.Duration) =
            { state with Expiration = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityCreateApiKeyRequest, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("roleDescriptors")>]
        member _.RoleDescriptors(state: SecurityCreateApiKeyRequest, value: Map<string, Types.RoleDescriptor>) =
            { state with RoleDescriptors = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityCreateApiKeyRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

    let securityCreateApiKeyRequest = SecurityCreateApiKeyRequestBuilder()

    module CreateApiKey =
        let withRefresh (value: Types.Refresh) (req: SecurityCreateApiKeyRequest) =
            { req with Refresh = Some value }
        let withExpiration (value: Types.Duration) (req: SecurityCreateApiKeyRequest) =
            { req with Expiration = Some value }
        let withName (value: Types.Name) (req: SecurityCreateApiKeyRequest) =
            { req with Name = Some value }
        let withRoleDescriptors (value: Map<string, Types.RoleDescriptor>) (req: SecurityCreateApiKeyRequest) =
            { req with RoleDescriptors = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityCreateApiKeyRequest) =
            { req with Metadata = Some value }

    type SecurityCreateCrossClusterApiKeyRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("access")>]
        Access: Types.Access
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("certificate_identity")>]
        CertificateIdentity: string option
    }

        with
        static member ToRequest(req: SecurityCreateCrossClusterApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/cross_cluster/api_key"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityCreateCrossClusterApiKeyResponse = System.Text.Json.JsonElement

    type SecurityCreateCrossClusterApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityCreateCrossClusterApiKeyRequest =
            {
                Access = Unchecked.defaultof<_>
                Expiration = None
                Metadata = None
                Name = Unchecked.defaultof<_>
                CertificateIdentity = None
            }

        [<CustomOperation("access")>]
        member _.Access(state: SecurityCreateCrossClusterApiKeyRequest, value: Types.Access) =
            { state with Access = value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityCreateCrossClusterApiKeyRequest, value: Types.Duration) =
            { state with Expiration = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityCreateCrossClusterApiKeyRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityCreateCrossClusterApiKeyRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("certificateIdentity")>]
        member _.CertificateIdentity(state: SecurityCreateCrossClusterApiKeyRequest, value: string) =
            { state with CertificateIdentity = Some value }

    let securityCreateCrossClusterApiKeyRequest = SecurityCreateCrossClusterApiKeyRequestBuilder()

    module CreateCrossClusterApiKey =
        let withAccess (value: Types.Access) (req: SecurityCreateCrossClusterApiKeyRequest) =
            { req with Access = value }
        let withExpiration (value: Types.Duration) (req: SecurityCreateCrossClusterApiKeyRequest) =
            { req with Expiration = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityCreateCrossClusterApiKeyRequest) =
            { req with Metadata = Some value }
        let withName (value: Types.Name) (req: SecurityCreateCrossClusterApiKeyRequest) =
            { req with Name = value }
        let withCertificateIdentity (value: string) (req: SecurityCreateCrossClusterApiKeyRequest) =
            { req with CertificateIdentity = Some value }

    type SecurityCreateServiceTokenRequest = {
        Namespace: Types.Namespace
        Service: Types.Service
        Name: Types.Name
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityCreateServiceTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{req.Namespace}/{req.Service}/credential/token/{req.Name}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityCreateServiceTokenResponse = System.Text.Json.JsonElement

    type SecurityCreateServiceTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityCreateServiceTokenRequest =
            {
                Namespace = Unchecked.defaultof<_>
                Service = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: SecurityCreateServiceTokenRequest, value: Types.Namespace) =
            { state with Namespace = value }

        [<CustomOperation("service")>]
        member _.Service(state: SecurityCreateServiceTokenRequest, value: Types.Service) =
            { state with Service = value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityCreateServiceTokenRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityCreateServiceTokenRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityCreateServiceTokenRequest = SecurityCreateServiceTokenRequestBuilder()

    module CreateServiceToken =
        let withRefresh (value: Types.Refresh) (req: SecurityCreateServiceTokenRequest) =
            { req with Refresh = Some value }

    type SecurityDelegatePkiRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("x509_certificate_chain")>]
        X509CertificateChain: string list
    }

        with
        static member ToRequest(req: SecurityDelegatePkiRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/delegate_pki"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityDelegatePkiResponse = System.Text.Json.JsonElement

    type SecurityDelegatePkiRequestBuilder() =
        member _.Yield(_: unit) : SecurityDelegatePkiRequest =
            {
                X509CertificateChain = Unchecked.defaultof<_>
            }

        [<CustomOperation("x509CertificateChain")>]
        member _.X509CertificateChain(state: SecurityDelegatePkiRequest, value: string list) =
            { state with X509CertificateChain = value }

    let securityDelegatePkiRequest = SecurityDelegatePkiRequestBuilder()

    module DelegatePki =
        let withX509CertificateChain (value: string list) (req: SecurityDelegatePkiRequest) =
            { req with X509CertificateChain = value }

    type SecurityDeletePrivilegesRequest = {
        Application: Types.Name
        Name: Types.Names
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDeletePrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/{req.Application}/{req.Name}"
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

    type SecurityDeletePrivilegesResponse = Map<string, Map<string, Types.FoundStatus>>

    type SecurityDeletePrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeletePrivilegesRequest =
            {
                Application = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("application")>]
        member _.Application(state: SecurityDeletePrivilegesRequest, value: Types.Name) =
            { state with Application = value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeletePrivilegesRequest, value: Types.Names) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeletePrivilegesRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDeletePrivilegesRequest = SecurityDeletePrivilegesRequestBuilder()

    module DeletePrivileges =
        let withRefresh (value: Types.Refresh) (req: SecurityDeletePrivilegesRequest) =
            { req with Refresh = Some value }

    type SecurityDeleteRoleRequest = {
        Name: Types.Name
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDeleteRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{req.Name}"
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

    type SecurityDeleteRoleResponse = System.Text.Json.JsonElement

    type SecurityDeleteRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteRoleRequest =
            {
                Name = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeleteRoleRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteRoleRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDeleteRoleRequest = SecurityDeleteRoleRequestBuilder()

    module DeleteRole =
        let withRefresh (value: Types.Refresh) (req: SecurityDeleteRoleRequest) =
            { req with Refresh = Some value }

    type SecurityDeleteRoleMappingRequest = {
        Name: Types.Name
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDeleteRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role_mapping/{req.Name}"
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

    type SecurityDeleteRoleMappingResponse = System.Text.Json.JsonElement

    type SecurityDeleteRoleMappingRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteRoleMappingRequest =
            {
                Name = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeleteRoleMappingRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteRoleMappingRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDeleteRoleMappingRequest = SecurityDeleteRoleMappingRequestBuilder()

    module DeleteRoleMapping =
        let withRefresh (value: Types.Refresh) (req: SecurityDeleteRoleMappingRequest) =
            { req with Refresh = Some value }

    type SecurityDeleteServiceTokenRequest = {
        Namespace: Types.Namespace
        Service: Types.Service
        Name: Types.Name
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDeleteServiceTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{req.Namespace}/{req.Service}/credential/token/{req.Name}"
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

    type SecurityDeleteServiceTokenResponse = System.Text.Json.JsonElement

    type SecurityDeleteServiceTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteServiceTokenRequest =
            {
                Namespace = Unchecked.defaultof<_>
                Service = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: SecurityDeleteServiceTokenRequest, value: Types.Namespace) =
            { state with Namespace = value }

        [<CustomOperation("service")>]
        member _.Service(state: SecurityDeleteServiceTokenRequest, value: Types.Service) =
            { state with Service = value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityDeleteServiceTokenRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteServiceTokenRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDeleteServiceTokenRequest = SecurityDeleteServiceTokenRequestBuilder()

    module DeleteServiceToken =
        let withRefresh (value: Types.Refresh) (req: SecurityDeleteServiceTokenRequest) =
            { req with Refresh = Some value }

    type SecurityDeleteUserRequest = {
        Username: Types.Username
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDeleteUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.Username}"
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

    type SecurityDeleteUserResponse = System.Text.Json.JsonElement

    type SecurityDeleteUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityDeleteUserRequest =
            {
                Username = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityDeleteUserRequest, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDeleteUserRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDeleteUserRequest = SecurityDeleteUserRequestBuilder()

    module DeleteUser =
        let withRefresh (value: Types.Refresh) (req: SecurityDeleteUserRequest) =
            { req with Refresh = Some value }

    type SecurityDisableUserRequest = {
        Username: Types.Username
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDisableUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.Username}/_disable"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityDisableUserResponse = System.Text.Json.JsonElement

    type SecurityDisableUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityDisableUserRequest =
            {
                Username = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityDisableUserRequest, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDisableUserRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDisableUserRequest = SecurityDisableUserRequestBuilder()

    module DisableUser =
        let withRefresh (value: Types.Refresh) (req: SecurityDisableUserRequest) =
            { req with Refresh = Some value }

    type SecurityDisableUserProfileRequest = {
        Uid: Types.UserProfileId
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityDisableUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{req.Uid}/_disable"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityDisableUserProfileResponse = Types.AcknowledgedResponseBase

    type SecurityDisableUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityDisableUserProfileRequest =
            {
                Uid = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityDisableUserProfileRequest, value: Types.UserProfileId) =
            { state with Uid = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityDisableUserProfileRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityDisableUserProfileRequest = SecurityDisableUserProfileRequestBuilder()

    module DisableUserProfile =
        let withRefresh (value: Types.Refresh) (req: SecurityDisableUserProfileRequest) =
            { req with Refresh = Some value }

    type SecurityEnableUserRequest = {
        Username: Types.Username
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityEnableUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.Username}/_enable"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityEnableUserResponse = System.Text.Json.JsonElement

    type SecurityEnableUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityEnableUserRequest =
            {
                Username = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityEnableUserRequest, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityEnableUserRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityEnableUserRequest = SecurityEnableUserRequestBuilder()

    module EnableUser =
        let withRefresh (value: Types.Refresh) (req: SecurityEnableUserRequest) =
            { req with Refresh = Some value }

    type SecurityEnableUserProfileRequest = {
        Uid: Types.UserProfileId
        Refresh: Types.Refresh option
    }

        with
        static member ToRequest(req: SecurityEnableUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{req.Uid}/_enable"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityEnableUserProfileResponse = Types.AcknowledgedResponseBase

    type SecurityEnableUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityEnableUserProfileRequest =
            {
                Uid = Unchecked.defaultof<_>
                Refresh = None
            }

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityEnableUserProfileRequest, value: Types.UserProfileId) =
            { state with Uid = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityEnableUserProfileRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

    let securityEnableUserProfileRequest = SecurityEnableUserProfileRequestBuilder()

    module EnableUserProfile =
        let withRefresh (value: Types.Refresh) (req: SecurityEnableUserProfileRequest) =
            { req with Refresh = Some value }

    type SecurityEnrollKibanaRequest = | SecurityEnrollKibanaRequest

        with
        static member ToRequest(req: SecurityEnrollKibanaRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/enroll/kibana"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityEnrollKibanaResponse = System.Text.Json.JsonElement

    type SecurityEnrollKibanaRequestBuilder() =
        member _.Yield(_: unit) : SecurityEnrollKibanaRequest =
            {
            }

    let securityEnrollKibanaRequest = SecurityEnrollKibanaRequestBuilder()

    type SecurityEnrollNodeRequest = | SecurityEnrollNodeRequest

        with
        static member ToRequest(req: SecurityEnrollNodeRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/enroll/node"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityEnrollNodeResponse = System.Text.Json.JsonElement

    type SecurityEnrollNodeRequestBuilder() =
        member _.Yield(_: unit) : SecurityEnrollNodeRequest =
            {
            }

    let securityEnrollNodeRequest = SecurityEnrollNodeRequestBuilder()

    type SecurityGetApiKeyRequest = {
        Id: Types.Id option
        Name: Types.Name option
        Owner: bool option
        RealmName: Types.Name option
        Username: Types.Username option
        WithLimitedBy: bool option
        ActiveOnly: bool option
        WithProfileUid: bool option
    }

        with
        static member ToRequest(req: SecurityGetApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key"
                let queryParams =
                    [
                        req.Id |> Option.map (fun v -> "id", Fes.Http.toQueryValue v)
                        req.Name |> Option.map (fun v -> "name", Fes.Http.toQueryValue v)
                        req.Owner |> Option.map (fun v -> "owner", Fes.Http.toQueryValue v)
                        req.RealmName |> Option.map (fun v -> "realm_name", Fes.Http.toQueryValue v)
                        req.Username |> Option.map (fun v -> "username", Fes.Http.toQueryValue v)
                        req.WithLimitedBy |> Option.map (fun v -> "with_limited_by", Fes.Http.toQueryValue v)
                        req.ActiveOnly |> Option.map (fun v -> "active_only", Fes.Http.toQueryValue v)
                        req.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
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

    type SecurityGetApiKeyResponse = System.Text.Json.JsonElement

    type SecurityGetApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetApiKeyRequest =
            {
                Id = None
                Name = None
                Owner = None
                RealmName = None
                Username = None
                WithLimitedBy = None
                ActiveOnly = None
                WithProfileUid = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SecurityGetApiKeyRequest, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetApiKeyRequest, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("owner")>]
        member _.Owner(state: SecurityGetApiKeyRequest, value: bool) =
            { state with Owner = Some value }

        [<CustomOperation("realmName")>]
        member _.RealmName(state: SecurityGetApiKeyRequest, value: Types.Name) =
            { state with RealmName = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGetApiKeyRequest, value: Types.Username) =
            { state with Username = Some value }

        [<CustomOperation("withLimitedBy")>]
        member _.WithLimitedBy(state: SecurityGetApiKeyRequest, value: bool) =
            { state with WithLimitedBy = Some value }

        [<CustomOperation("activeOnly")>]
        member _.ActiveOnly(state: SecurityGetApiKeyRequest, value: bool) =
            { state with ActiveOnly = Some value }

        [<CustomOperation("withProfileUid")>]
        member _.WithProfileUid(state: SecurityGetApiKeyRequest, value: bool) =
            { state with WithProfileUid = Some value }

    let securityGetApiKeyRequest = SecurityGetApiKeyRequestBuilder()

    module GetApiKey =
        let withId (value: Types.Id) (req: SecurityGetApiKeyRequest) =
            { req with Id = Some value }
        let withName (value: Types.Name) (req: SecurityGetApiKeyRequest) =
            { req with Name = Some value }
        let withOwner (value: bool) (req: SecurityGetApiKeyRequest) =
            { req with Owner = Some value }
        let withRealmName (value: Types.Name) (req: SecurityGetApiKeyRequest) =
            { req with RealmName = Some value }
        let withUsername (value: Types.Username) (req: SecurityGetApiKeyRequest) =
            { req with Username = Some value }
        let withWithLimitedBy (value: bool) (req: SecurityGetApiKeyRequest) =
            { req with WithLimitedBy = Some value }
        let withActiveOnly (value: bool) (req: SecurityGetApiKeyRequest) =
            { req with ActiveOnly = Some value }
        let withWithProfileUid (value: bool) (req: SecurityGetApiKeyRequest) =
            { req with WithProfileUid = Some value }

    type SecurityGetBuiltinPrivilegesRequest = | SecurityGetBuiltinPrivilegesRequest

        with
        static member ToRequest(req: SecurityGetBuiltinPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/_builtin"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetBuiltinPrivilegesResponse = System.Text.Json.JsonElement

    type SecurityGetBuiltinPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetBuiltinPrivilegesRequest =
            {
            }

    let securityGetBuiltinPrivilegesRequest = SecurityGetBuiltinPrivilegesRequestBuilder()

    type SecurityGetPrivilegesRequest = {
        Application: Types.Name
        Name: Types.Names
    }

        with
        static member ToRequest(req: SecurityGetPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege/{req.Application}/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetPrivilegesResponse = Map<string, Map<string, Types.SecurityPutPrivilegesActions>>

    type SecurityGetPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetPrivilegesRequest =
            {
                Application = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("application")>]
        member _.Application(state: SecurityGetPrivilegesRequest, value: Types.Name) =
            { state with Application = value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetPrivilegesRequest, value: Types.Names) =
            { state with Name = value }

    let securityGetPrivilegesRequest = SecurityGetPrivilegesRequestBuilder()

    type SecurityGetRoleRequest = {
        Name: Types.Names
    }

        with
        static member ToRequest(req: SecurityGetRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetRoleResponse = Map<string, Types.Role>

    type SecurityGetRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetRoleRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetRoleRequest, value: Types.Names) =
            { state with Name = value }

    let securityGetRoleRequest = SecurityGetRoleRequestBuilder()

    type SecurityGetRoleMappingRequest = {
        Name: Types.Names
    }

        with
        static member ToRequest(req: SecurityGetRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role_mapping/{req.Name}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetRoleMappingResponse = Map<string, Types.SecurityTypesRoleMapping>

    type SecurityGetRoleMappingRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetRoleMappingRequest =
            {
                Name = Unchecked.defaultof<_>
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityGetRoleMappingRequest, value: Types.Names) =
            { state with Name = value }

    let securityGetRoleMappingRequest = SecurityGetRoleMappingRequestBuilder()

    type SecurityGetServiceAccountsRequest = {
        Namespace: Types.Namespace
        Service: Types.Service
    }

        with
        static member ToRequest(req: SecurityGetServiceAccountsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{req.Namespace}/{req.Service}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetServiceAccountsResponse = Map<string, Types.RoleDescriptorWrapper>

    type SecurityGetServiceAccountsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetServiceAccountsRequest =
            {
                Namespace = Unchecked.defaultof<_>
                Service = Unchecked.defaultof<_>
            }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: SecurityGetServiceAccountsRequest, value: Types.Namespace) =
            { state with Namespace = value }

        [<CustomOperation("service")>]
        member _.Service(state: SecurityGetServiceAccountsRequest, value: Types.Service) =
            { state with Service = value }

    let securityGetServiceAccountsRequest = SecurityGetServiceAccountsRequestBuilder()

    type SecurityGetServiceCredentialsRequest = {
        Namespace: Types.Namespace
        Service: Types.Name
    }

        with
        static member ToRequest(req: SecurityGetServiceCredentialsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/service/{req.Namespace}/{req.Service}/credential"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetServiceCredentialsResponse = System.Text.Json.JsonElement

    type SecurityGetServiceCredentialsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetServiceCredentialsRequest =
            {
                Namespace = Unchecked.defaultof<_>
                Service = Unchecked.defaultof<_>
            }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: SecurityGetServiceCredentialsRequest, value: Types.Namespace) =
            { state with Namespace = value }

        [<CustomOperation("service")>]
        member _.Service(state: SecurityGetServiceCredentialsRequest, value: Types.Name) =
            { state with Service = value }

    let securityGetServiceCredentialsRequest = SecurityGetServiceCredentialsRequestBuilder()

    type SecurityGetSettingsRequest = {
        MasterTimeout: Types.Duration option
    }

        with
        static member ToRequest(req: SecurityGetSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/settings"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
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

    type SecurityGetSettingsResponse = System.Text.Json.JsonElement

    type SecurityGetSettingsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetSettingsRequest =
            {
                MasterTimeout = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SecurityGetSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

    let securityGetSettingsRequest = SecurityGetSettingsRequestBuilder()

    module GetSettings =
        let withMasterTimeout (value: Types.Duration) (req: SecurityGetSettingsRequest) =
            { req with MasterTimeout = Some value }

    type SecurityGetStatsRequest = | SecurityGetStatsRequest

        with
        static member ToRequest(req: SecurityGetStatsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/stats"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetStatsResponse = System.Text.Json.JsonElement

    type SecurityGetStatsRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetStatsRequest =
            {
            }

    let securityGetStatsRequest = SecurityGetStatsRequestBuilder()

    type SecurityGetTokenRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("grant_type")>]
        GrantType: Types.AccessTokenGrantType option
        [<System.Text.Json.Serialization.JsonPropertyName("scope")>]
        Scope: string option
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: Types.Password option
        [<System.Text.Json.Serialization.JsonPropertyName("kerberos_ticket")>]
        KerberosTicket: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_token")>]
        RefreshToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: Types.Username option
    }

        with
        static member ToRequest(req: SecurityGetTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/oauth2/token"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetTokenResponse = System.Text.Json.JsonElement

    type SecurityGetTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetTokenRequest =
            {
                GrantType = None
                Scope = None
                Password = None
                KerberosTicket = None
                RefreshToken = None
                Username = None
            }

        [<CustomOperation("grantType")>]
        member _.GrantType(state: SecurityGetTokenRequest, value: Types.AccessTokenGrantType) =
            { state with GrantType = Some value }

        [<CustomOperation("scope")>]
        member _.Scope(state: SecurityGetTokenRequest, value: string) =
            { state with Scope = Some value }

        [<CustomOperation("password")>]
        member _.Password(state: SecurityGetTokenRequest, value: Types.Password) =
            { state with Password = Some value }

        [<CustomOperation("kerberosTicket")>]
        member _.KerberosTicket(state: SecurityGetTokenRequest, value: string) =
            { state with KerberosTicket = Some value }

        [<CustomOperation("refreshToken")>]
        member _.RefreshToken(state: SecurityGetTokenRequest, value: string) =
            { state with RefreshToken = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGetTokenRequest, value: Types.Username) =
            { state with Username = Some value }

    let securityGetTokenRequest = SecurityGetTokenRequestBuilder()

    module GetToken =
        let withGrantType (value: Types.AccessTokenGrantType) (req: SecurityGetTokenRequest) =
            { req with GrantType = Some value }
        let withScope (value: string) (req: SecurityGetTokenRequest) =
            { req with Scope = Some value }
        let withPassword (value: Types.Password) (req: SecurityGetTokenRequest) =
            { req with Password = Some value }
        let withKerberosTicket (value: string) (req: SecurityGetTokenRequest) =
            { req with KerberosTicket = Some value }
        let withRefreshToken (value: string) (req: SecurityGetTokenRequest) =
            { req with RefreshToken = Some value }
        let withUsername (value: Types.Username) (req: SecurityGetTokenRequest) =
            { req with Username = Some value }

    type SecurityGetUserRequest = {
        Username: System.Text.Json.JsonElement
        WithProfileUid: bool option
    }

        with
        static member ToRequest(req: SecurityGetUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.Username}"
                let queryParams =
                    [
                        req.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
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

    type SecurityGetUserResponse = Map<string, Types.User>

    type SecurityGetUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetUserRequest =
            {
                Username = Unchecked.defaultof<_>
                WithProfileUid = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGetUserRequest, value: System.Text.Json.JsonElement) =
            { state with Username = value }

        [<CustomOperation("withProfileUid")>]
        member _.WithProfileUid(state: SecurityGetUserRequest, value: bool) =
            { state with WithProfileUid = Some value }

    let securityGetUserRequest = SecurityGetUserRequestBuilder()

    module GetUser =
        let withWithProfileUid (value: bool) (req: SecurityGetUserRequest) =
            { req with WithProfileUid = Some value }

    type SecurityGetUserPrivilegesRequest = | SecurityGetUserPrivilegesRequest

        with
        static member ToRequest(req: SecurityGetUserPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/_privileges"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGetUserPrivilegesResponse = System.Text.Json.JsonElement

    type SecurityGetUserPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetUserPrivilegesRequest =
            {
            }

    let securityGetUserPrivilegesRequest = SecurityGetUserPrivilegesRequestBuilder()

    type SecurityGetUserProfileRequest = {
        Uid: System.Text.Json.JsonElement
        Data: System.Text.Json.JsonElement option
    }

        with
        static member ToRequest(req: SecurityGetUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{req.Uid}"
                let queryParams =
                    [
                        req.Data |> Option.map (fun v -> "data", Fes.Http.toQueryValue v)
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

    type SecurityGetUserProfileResponse = System.Text.Json.JsonElement

    type SecurityGetUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityGetUserProfileRequest =
            {
                Uid = Unchecked.defaultof<_>
                Data = None
            }

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityGetUserProfileRequest, value: System.Text.Json.JsonElement) =
            { state with Uid = value }

        [<CustomOperation("data")>]
        member _.Data(state: SecurityGetUserProfileRequest, value: System.Text.Json.JsonElement) =
            { state with Data = Some value }

    let securityGetUserProfileRequest = SecurityGetUserProfileRequestBuilder()

    module GetUserProfile =
        let withData (value: System.Text.Json.JsonElement) (req: SecurityGetUserProfileRequest) =
            { req with Data = Some value }

    type SecurityGrantApiKeyRequest = {
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("api_key")>]
        ApiKey: Types.GrantApiKey
        [<System.Text.Json.Serialization.JsonPropertyName("grant_type")>]
        GrantType: Types.ApiKeyGrantType
        [<System.Text.Json.Serialization.JsonPropertyName("access_token")>]
        AccessToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: Types.Username option
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: Types.Password option
        [<System.Text.Json.Serialization.JsonPropertyName("run_as")>]
        RunAs: Types.Username option
    }

        with
        static member ToRequest(req: SecurityGrantApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key/grant"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityGrantApiKeyResponse = System.Text.Json.JsonElement

    type SecurityGrantApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityGrantApiKeyRequest =
            {
                Refresh = None
                ApiKey = Unchecked.defaultof<_>
                GrantType = Unchecked.defaultof<_>
                AccessToken = None
                Username = None
                Password = None
                RunAs = None
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityGrantApiKeyRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: SecurityGrantApiKeyRequest, value: Types.GrantApiKey) =
            { state with ApiKey = value }

        [<CustomOperation("grantType")>]
        member _.GrantType(state: SecurityGrantApiKeyRequest, value: Types.ApiKeyGrantType) =
            { state with GrantType = value }

        [<CustomOperation("accessToken")>]
        member _.AccessToken(state: SecurityGrantApiKeyRequest, value: string) =
            { state with AccessToken = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityGrantApiKeyRequest, value: Types.Username) =
            { state with Username = Some value }

        [<CustomOperation("password")>]
        member _.Password(state: SecurityGrantApiKeyRequest, value: Types.Password) =
            { state with Password = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: SecurityGrantApiKeyRequest, value: Types.Username) =
            { state with RunAs = Some value }

    let securityGrantApiKeyRequest = SecurityGrantApiKeyRequestBuilder()

    module GrantApiKey =
        let withRefresh (value: Types.Refresh) (req: SecurityGrantApiKeyRequest) =
            { req with Refresh = Some value }
        let withApiKey (value: Types.GrantApiKey) (req: SecurityGrantApiKeyRequest) =
            { req with ApiKey = value }
        let withGrantType (value: Types.ApiKeyGrantType) (req: SecurityGrantApiKeyRequest) =
            { req with GrantType = value }
        let withAccessToken (value: string) (req: SecurityGrantApiKeyRequest) =
            { req with AccessToken = Some value }
        let withUsername (value: Types.Username) (req: SecurityGrantApiKeyRequest) =
            { req with Username = Some value }
        let withPassword (value: Types.Password) (req: SecurityGrantApiKeyRequest) =
            { req with Password = Some value }
        let withRunAs (value: Types.Username) (req: SecurityGrantApiKeyRequest) =
            { req with RunAs = Some value }

    type SecurityHasPrivilegesRequest = {
        User: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("application")>]
        Application: Types.ApplicationPrivilegesCheck list option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: Types.ClusterPrivilege list option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexPrivilegesCheck list option
    }

        with
        static member ToRequest(req: SecurityHasPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.User}/_has_privileges"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityHasPrivilegesResponse = System.Text.Json.JsonElement

    type SecurityHasPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityHasPrivilegesRequest =
            {
                User = Unchecked.defaultof<_>
                Application = None
                Cluster = None
                Index = None
            }

        [<CustomOperation("user")>]
        member _.User(state: SecurityHasPrivilegesRequest, value: Types.Name) =
            { state with User = value }

        [<CustomOperation("application")>]
        member _.Application(state: SecurityHasPrivilegesRequest, value: Types.ApplicationPrivilegesCheck list) =
            { state with Application = Some value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: SecurityHasPrivilegesRequest, value: Types.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: SecurityHasPrivilegesRequest, value: Types.IndexPrivilegesCheck list) =
            { state with Index = Some value }

    let securityHasPrivilegesRequest = SecurityHasPrivilegesRequestBuilder()

    module HasPrivileges =
        let withApplication (value: Types.ApplicationPrivilegesCheck list) (req: SecurityHasPrivilegesRequest) =
            { req with Application = Some value }
        let withCluster (value: Types.ClusterPrivilege list) (req: SecurityHasPrivilegesRequest) =
            { req with Cluster = Some value }
        let withIndex (value: Types.IndexPrivilegesCheck list) (req: SecurityHasPrivilegesRequest) =
            { req with Index = Some value }

    type SecurityHasPrivilegesUserProfileRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("uids")>]
        Uids: Types.UserProfileId list
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: Types.PrivilegesCheck
    }

        with
        static member ToRequest(req: SecurityHasPrivilegesUserProfileRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/_has_privileges"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityHasPrivilegesUserProfileResponse = System.Text.Json.JsonElement

    type SecurityHasPrivilegesUserProfileRequestBuilder() =
        member _.Yield(_: unit) : SecurityHasPrivilegesUserProfileRequest =
            {
                Uids = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
            }

        [<CustomOperation("uids")>]
        member _.Uids(state: SecurityHasPrivilegesUserProfileRequest, value: Types.UserProfileId list) =
            { state with Uids = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: SecurityHasPrivilegesUserProfileRequest, value: Types.PrivilegesCheck) =
            { state with Privileges = value }

    let securityHasPrivilegesUserProfileRequest = SecurityHasPrivilegesUserProfileRequestBuilder()

    module HasPrivilegesUserProfile =
        let withUids (value: Types.UserProfileId list) (req: SecurityHasPrivilegesUserProfileRequest) =
            { req with Uids = value }
        let withPrivileges (value: Types.PrivilegesCheck) (req: SecurityHasPrivilegesUserProfileRequest) =
            { req with Privileges = value }

    type SecurityInvalidateApiKeyRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: Types.Id list option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("owner")>]
        Owner: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("realm_name")>]
        RealmName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: Types.Username option
    }

        with
        static member ToRequest(req: SecurityInvalidateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityInvalidateApiKeyResponse = System.Text.Json.JsonElement

    type SecurityInvalidateApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityInvalidateApiKeyRequest =
            {
                Id = None
                Ids = None
                Name = None
                Owner = None
                RealmName = None
                Username = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SecurityInvalidateApiKeyRequest, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("ids")>]
        member _.Ids(state: SecurityInvalidateApiKeyRequest, value: Types.Id list) =
            { state with Ids = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityInvalidateApiKeyRequest, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("owner")>]
        member _.Owner(state: SecurityInvalidateApiKeyRequest, value: bool) =
            { state with Owner = Some value }

        [<CustomOperation("realmName")>]
        member _.RealmName(state: SecurityInvalidateApiKeyRequest, value: string) =
            { state with RealmName = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityInvalidateApiKeyRequest, value: Types.Username) =
            { state with Username = Some value }

    let securityInvalidateApiKeyRequest = SecurityInvalidateApiKeyRequestBuilder()

    module InvalidateApiKey =
        let withId (value: Types.Id) (req: SecurityInvalidateApiKeyRequest) =
            { req with Id = Some value }
        let withIds (value: Types.Id list) (req: SecurityInvalidateApiKeyRequest) =
            { req with Ids = Some value }
        let withName (value: Types.Name) (req: SecurityInvalidateApiKeyRequest) =
            { req with Name = Some value }
        let withOwner (value: bool) (req: SecurityInvalidateApiKeyRequest) =
            { req with Owner = Some value }
        let withRealmName (value: string) (req: SecurityInvalidateApiKeyRequest) =
            { req with RealmName = Some value }
        let withUsername (value: Types.Username) (req: SecurityInvalidateApiKeyRequest) =
            { req with Username = Some value }

    type SecurityInvalidateTokenRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: string option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_token")>]
        RefreshToken: string option
        [<System.Text.Json.Serialization.JsonPropertyName("realm_name")>]
        RealmName: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: Types.Username option
    }

        with
        static member ToRequest(req: SecurityInvalidateTokenRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/oauth2/token"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Delete
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityInvalidateTokenResponse = System.Text.Json.JsonElement

    type SecurityInvalidateTokenRequestBuilder() =
        member _.Yield(_: unit) : SecurityInvalidateTokenRequest =
            {
                Token = None
                RefreshToken = None
                RealmName = None
                Username = None
            }

        [<CustomOperation("token")>]
        member _.Token(state: SecurityInvalidateTokenRequest, value: string) =
            { state with Token = Some value }

        [<CustomOperation("refreshToken")>]
        member _.RefreshToken(state: SecurityInvalidateTokenRequest, value: string) =
            { state with RefreshToken = Some value }

        [<CustomOperation("realmName")>]
        member _.RealmName(state: SecurityInvalidateTokenRequest, value: Types.Name) =
            { state with RealmName = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityInvalidateTokenRequest, value: Types.Username) =
            { state with Username = Some value }

    let securityInvalidateTokenRequest = SecurityInvalidateTokenRequestBuilder()

    module InvalidateToken =
        let withToken (value: string) (req: SecurityInvalidateTokenRequest) =
            { req with Token = Some value }
        let withRefreshToken (value: string) (req: SecurityInvalidateTokenRequest) =
            { req with RefreshToken = Some value }
        let withRealmName (value: Types.Name) (req: SecurityInvalidateTokenRequest) =
            { req with RealmName = Some value }
        let withUsername (value: Types.Username) (req: SecurityInvalidateTokenRequest) =
            { req with Username = Some value }

    type SecurityOidcAuthenticateRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("nonce")>]
        Nonce: string
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string option
        [<System.Text.Json.Serialization.JsonPropertyName("redirect_uri")>]
        RedirectUri: string
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string
    }

        with
        static member ToRequest(req: SecurityOidcAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/oidc/authenticate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityOidcAuthenticateResponse = System.Text.Json.JsonElement

    type SecurityOidcAuthenticateRequestBuilder() =
        member _.Yield(_: unit) : SecurityOidcAuthenticateRequest =
            {
                Nonce = Unchecked.defaultof<_>
                Realm = None
                RedirectUri = Unchecked.defaultof<_>
                State = Unchecked.defaultof<_>
            }

        [<CustomOperation("nonce")>]
        member _.Nonce(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with Nonce = value }

        [<CustomOperation("realm")>]
        member _.Realm(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with Realm = Some value }

        [<CustomOperation("redirectUri")>]
        member _.RedirectUri(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with RedirectUri = value }

        [<CustomOperation("state")>]
        member _.State(state: SecurityOidcAuthenticateRequest, value: string) =
            { state with State = value }

    let securityOidcAuthenticateRequest = SecurityOidcAuthenticateRequestBuilder()

    module OidcAuthenticate =
        let withNonce (value: string) (req: SecurityOidcAuthenticateRequest) =
            { req with Nonce = value }
        let withRealm (value: string) (req: SecurityOidcAuthenticateRequest) =
            { req with Realm = Some value }
        let withRedirectUri (value: string) (req: SecurityOidcAuthenticateRequest) =
            { req with RedirectUri = value }
        let withState (value: string) (req: SecurityOidcAuthenticateRequest) =
            { req with State = value }

    type SecurityOidcLogoutRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: string
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_token")>]
        RefreshToken: string option
    }

        with
        static member ToRequest(req: SecurityOidcLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/oidc/logout"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityOidcLogoutResponse = System.Text.Json.JsonElement

    type SecurityOidcLogoutRequestBuilder() =
        member _.Yield(_: unit) : SecurityOidcLogoutRequest =
            {
                Token = Unchecked.defaultof<_>
                RefreshToken = None
            }

        [<CustomOperation("token")>]
        member _.Token(state: SecurityOidcLogoutRequest, value: string) =
            { state with Token = value }

        [<CustomOperation("refreshToken")>]
        member _.RefreshToken(state: SecurityOidcLogoutRequest, value: string) =
            { state with RefreshToken = Some value }

    let securityOidcLogoutRequest = SecurityOidcLogoutRequestBuilder()

    module OidcLogout =
        let withToken (value: string) (req: SecurityOidcLogoutRequest) =
            { req with Token = value }
        let withRefreshToken (value: string) (req: SecurityOidcLogoutRequest) =
            { req with RefreshToken = Some value }

    type SecurityOidcPrepareAuthenticationRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("iss")>]
        Iss: string option
        [<System.Text.Json.Serialization.JsonPropertyName("login_hint")>]
        LoginHint: string option
        [<System.Text.Json.Serialization.JsonPropertyName("nonce")>]
        Nonce: string option
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string option
    }

        with
        static member ToRequest(req: SecurityOidcPrepareAuthenticationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/oidc/prepare"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityOidcPrepareAuthenticationResponse = System.Text.Json.JsonElement

    type SecurityOidcPrepareAuthenticationRequestBuilder() =
        member _.Yield(_: unit) : SecurityOidcPrepareAuthenticationRequest =
            {
                Iss = None
                LoginHint = None
                Nonce = None
                Realm = None
                State = None
            }

        [<CustomOperation("iss")>]
        member _.Iss(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with Iss = Some value }

        [<CustomOperation("loginHint")>]
        member _.LoginHint(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with LoginHint = Some value }

        [<CustomOperation("nonce")>]
        member _.Nonce(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with Nonce = Some value }

        [<CustomOperation("realm")>]
        member _.Realm(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with Realm = Some value }

        [<CustomOperation("state")>]
        member _.State(state: SecurityOidcPrepareAuthenticationRequest, value: string) =
            { state with State = Some value }

    let securityOidcPrepareAuthenticationRequest = SecurityOidcPrepareAuthenticationRequestBuilder()

    module OidcPrepareAuthentication =
        let withIss (value: string) (req: SecurityOidcPrepareAuthenticationRequest) =
            { req with Iss = Some value }
        let withLoginHint (value: string) (req: SecurityOidcPrepareAuthenticationRequest) =
            { req with LoginHint = Some value }
        let withNonce (value: string) (req: SecurityOidcPrepareAuthenticationRequest) =
            { req with Nonce = Some value }
        let withRealm (value: string) (req: SecurityOidcPrepareAuthenticationRequest) =
            { req with Realm = Some value }
        let withState (value: string) (req: SecurityOidcPrepareAuthenticationRequest) =
            { req with State = Some value }

    type SecurityPutPrivilegesRequest = {
        Refresh: Types.Refresh option
        Document: obj
    }

        with
        static member ToRequest(req: SecurityPutPrivilegesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/privilege"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req.Document
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityPutPrivilegesResponse = Map<string, Map<string, Types.CreatedStatus>>

    type SecurityPutPrivilegesRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutPrivilegesRequest =
            {
                Refresh = None
                Document = Unchecked.defaultof<_>
            }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutPrivilegesRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("document")>]
        member _.Document(state: SecurityPutPrivilegesRequest, value) =
            { state with Document = value }

    let securityPutPrivilegesRequest = SecurityPutPrivilegesRequestBuilder()

    module PutPrivileges =
        let withRefresh (value: Types.Refresh) (req: SecurityPutPrivilegesRequest) =
            { req with Refresh = Some value }

    type SecurityPutRoleRequest = {
        Name: Types.Name
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("applications")>]
        Applications: Types.ApplicationPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: Types.ClusterPrivilege list option
        [<System.Text.Json.Serialization.JsonPropertyName("global")>]
        Global: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.IndicesPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_indices")>]
        RemoteIndices: Types.RemoteIndicesPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: Types.RemoteClusterPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("run_as")>]
        RunAs: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("transient_metadata")>]
        TransientMetadata: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: SecurityPutRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role/{req.Name}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityPutRoleResponse = System.Text.Json.JsonElement

    type SecurityPutRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutRoleRequest =
            {
                Name = Unchecked.defaultof<_>
                Refresh = None
                Applications = None
                Cluster = None
                Global = None
                Indices = None
                RemoteIndices = None
                RemoteCluster = None
                Metadata = None
                RunAs = None
                Description = None
                TransientMetadata = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityPutRoleRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutRoleRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: SecurityPutRoleRequest, value: Types.ApplicationPrivileges list) =
            { state with Applications = Some value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: SecurityPutRoleRequest, value: Types.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: SecurityPutRoleRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Global = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SecurityPutRoleRequest, value: Types.IndicesPrivileges list) =
            { state with Indices = Some value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: SecurityPutRoleRequest, value: Types.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: SecurityPutRoleRequest, value: Types.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityPutRoleRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: SecurityPutRoleRequest, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: SecurityPutRoleRequest, value: string) =
            { state with Description = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: SecurityPutRoleRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

    let securityPutRoleRequest = SecurityPutRoleRequestBuilder()

    module PutRole =
        let withRefresh (value: Types.Refresh) (req: SecurityPutRoleRequest) =
            { req with Refresh = Some value }
        let withApplications (value: Types.ApplicationPrivileges list) (req: SecurityPutRoleRequest) =
            { req with Applications = Some value }
        let withCluster (value: Types.ClusterPrivilege list) (req: SecurityPutRoleRequest) =
            { req with Cluster = Some value }
        let withGlobal (value: Map<string, System.Text.Json.JsonElement>) (req: SecurityPutRoleRequest) =
            { req with Global = Some value }
        let withIndices (value: Types.IndicesPrivileges list) (req: SecurityPutRoleRequest) =
            { req with Indices = Some value }
        let withRemoteIndices (value: Types.RemoteIndicesPrivileges list) (req: SecurityPutRoleRequest) =
            { req with RemoteIndices = Some value }
        let withRemoteCluster (value: Types.RemoteClusterPrivileges list) (req: SecurityPutRoleRequest) =
            { req with RemoteCluster = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityPutRoleRequest) =
            { req with Metadata = Some value }
        let withRunAs (value: string list) (req: SecurityPutRoleRequest) =
            { req with RunAs = Some value }
        let withDescription (value: string) (req: SecurityPutRoleRequest) =
            { req with Description = Some value }
        let withTransientMetadata (value: Map<string, System.Text.Json.JsonElement>) (req: SecurityPutRoleRequest) =
            { req with TransientMetadata = Some value }

    type SecurityPutRoleMappingRequest = {
        Name: Types.Name
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("role_templates")>]
        RoleTemplates: Types.RoleTemplate list option
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: Types.RoleMappingRule option
        [<System.Text.Json.Serialization.JsonPropertyName("run_as")>]
        RunAs: string list option
    }

        with
        static member ToRequest(req: SecurityPutRoleMappingRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/role_mapping/{req.Name}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityPutRoleMappingResponse = System.Text.Json.JsonElement

    type SecurityPutRoleMappingRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutRoleMappingRequest =
            {
                Name = Unchecked.defaultof<_>
                Refresh = None
                Enabled = None
                Metadata = None
                Roles = None
                RoleTemplates = None
                Rules = None
                RunAs = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: SecurityPutRoleMappingRequest, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutRoleMappingRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: SecurityPutRoleMappingRequest, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityPutRoleMappingRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: SecurityPutRoleMappingRequest, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("roleTemplates")>]
        member _.RoleTemplates(state: SecurityPutRoleMappingRequest, value: Types.RoleTemplate list) =
            { state with RoleTemplates = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: SecurityPutRoleMappingRequest, value: Types.RoleMappingRule) =
            { state with Rules = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: SecurityPutRoleMappingRequest, value: string list) =
            { state with RunAs = Some value }

    let securityPutRoleMappingRequest = SecurityPutRoleMappingRequestBuilder()

    module PutRoleMapping =
        let withRefresh (value: Types.Refresh) (req: SecurityPutRoleMappingRequest) =
            { req with Refresh = Some value }
        let withEnabled (value: bool) (req: SecurityPutRoleMappingRequest) =
            { req with Enabled = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityPutRoleMappingRequest) =
            { req with Metadata = Some value }
        let withRoles (value: string list) (req: SecurityPutRoleMappingRequest) =
            { req with Roles = Some value }
        let withRoleTemplates (value: Types.RoleTemplate list) (req: SecurityPutRoleMappingRequest) =
            { req with RoleTemplates = Some value }
        let withRules (value: Types.RoleMappingRule) (req: SecurityPutRoleMappingRequest) =
            { req with Rules = Some value }
        let withRunAs (value: string list) (req: SecurityPutRoleMappingRequest) =
            { req with RunAs = Some value }

    type SecurityPutUserRequest = {
        Username: Types.Username
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        bodyUsername: Types.Username option
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("full_name")>]
        FullName: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: Types.Password option
        [<System.Text.Json.Serialization.JsonPropertyName("password_hash")>]
        PasswordHash: string option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

        with
        static member ToRequest(req: SecurityPutUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/user/{req.Username}"
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
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityPutUserResponse = System.Text.Json.JsonElement

    type SecurityPutUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityPutUserRequest =
            {
                Username = Unchecked.defaultof<_>
                Refresh = None
                bodyUsername = None
                Email = None
                FullName = None
                Metadata = None
                Password = None
                PasswordHash = None
                Roles = None
                Enabled = None
            }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityPutUserRequest, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityPutUserRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: SecurityPutUserRequest, value: Types.Username) =
            { state with bodyUsername = Some value }

        [<CustomOperation("email")>]
        member _.Email(state: SecurityPutUserRequest, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: SecurityPutUserRequest, value: string option) =
            { state with FullName = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityPutUserRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("password")>]
        member _.Password(state: SecurityPutUserRequest, value: Types.Password) =
            { state with Password = Some value }

        [<CustomOperation("passwordHash")>]
        member _.PasswordHash(state: SecurityPutUserRequest, value: string) =
            { state with PasswordHash = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: SecurityPutUserRequest, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: SecurityPutUserRequest, value: bool) =
            { state with Enabled = Some value }

    let securityPutUserRequest = SecurityPutUserRequestBuilder()

    module PutUser =
        let withRefresh (value: Types.Refresh) (req: SecurityPutUserRequest) =
            { req with Refresh = Some value }
        let withUsername (value: Types.Username) (req: SecurityPutUserRequest) =
            { req with bodyUsername = Some value }
        let withEmail (value: string option) (req: SecurityPutUserRequest) =
            { req with Email = Some value }
        let withFullName (value: string option) (req: SecurityPutUserRequest) =
            { req with FullName = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityPutUserRequest) =
            { req with Metadata = Some value }
        let withPassword (value: Types.Password) (req: SecurityPutUserRequest) =
            { req with Password = Some value }
        let withPasswordHash (value: string) (req: SecurityPutUserRequest) =
            { req with PasswordHash = Some value }
        let withRoles (value: string list) (req: SecurityPutUserRequest) =
            { req with Roles = Some value }
        let withEnabled (value: bool) (req: SecurityPutUserRequest) =
            { req with Enabled = Some value }

    type SecurityQueryApiKeysRequest = {
        WithLimitedBy: bool option
        WithProfileUid: bool option
        TypedKeys: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, Types.ApiKeyAggregationContainer> option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.ApiKeyQueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: Types.SortResults option
    }

        with
        static member ToRequest(req: SecurityQueryApiKeysRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/_query/api_key"
                let queryParams =
                    [
                        req.WithLimitedBy |> Option.map (fun v -> "with_limited_by", Fes.Http.toQueryValue v)
                        req.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
                        req.TypedKeys |> Option.map (fun v -> "typed_keys", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityQueryApiKeysResponse = System.Text.Json.JsonElement

    type SecurityQueryApiKeysRequestBuilder() =
        member _.Yield(_: unit) : SecurityQueryApiKeysRequest =
            {
                WithLimitedBy = None
                WithProfileUid = None
                TypedKeys = None
                Aggregations = None
                Query = None
                From = None
                Sort = None
                Size = None
                SearchAfter = None
            }

        [<CustomOperation("withLimitedBy")>]
        member _.WithLimitedBy(state: SecurityQueryApiKeysRequest, value: bool) =
            { state with WithLimitedBy = Some value }

        [<CustomOperation("withProfileUid")>]
        member _.WithProfileUid(state: SecurityQueryApiKeysRequest, value: bool) =
            { state with WithProfileUid = Some value }

        [<CustomOperation("typedKeys")>]
        member _.TypedKeys(state: SecurityQueryApiKeysRequest, value: bool) =
            { state with TypedKeys = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: SecurityQueryApiKeysRequest, value: Map<string, Types.ApiKeyAggregationContainer>) =
            { state with Aggregations = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SecurityQueryApiKeysRequest, value: Types.ApiKeyQueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SecurityQueryApiKeysRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SecurityQueryApiKeysRequest, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SecurityQueryApiKeysRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: SecurityQueryApiKeysRequest, value: Types.SortResults) =
            { state with SearchAfter = Some value }

    let securityQueryApiKeysRequest = SecurityQueryApiKeysRequestBuilder()

    module QueryApiKeys =
        let withWithLimitedBy (value: bool) (req: SecurityQueryApiKeysRequest) =
            { req with WithLimitedBy = Some value }
        let withWithProfileUid (value: bool) (req: SecurityQueryApiKeysRequest) =
            { req with WithProfileUid = Some value }
        let withTypedKeys (value: bool) (req: SecurityQueryApiKeysRequest) =
            { req with TypedKeys = Some value }
        let withAggregations (value: Map<string, Types.ApiKeyAggregationContainer>) (req: SecurityQueryApiKeysRequest) =
            { req with Aggregations = Some value }
        let withQuery (value: Types.ApiKeyQueryContainer) (req: SecurityQueryApiKeysRequest) =
            { req with Query = Some value }
        let withFrom (value: Types.Integer) (req: SecurityQueryApiKeysRequest) =
            { req with From = Some value }
        let withSort (value: Types.Sort) (req: SecurityQueryApiKeysRequest) =
            { req with Sort = Some value }
        let withSize (value: Types.Integer) (req: SecurityQueryApiKeysRequest) =
            { req with Size = Some value }
        let withSearchAfter (value: Types.SortResults) (req: SecurityQueryApiKeysRequest) =
            { req with SearchAfter = Some value }

    type SecurityQueryRoleRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.RoleQueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: Types.SortResults option
    }

        with
        static member ToRequest(req: SecurityQueryRoleRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/_query/role"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityQueryRoleResponse = System.Text.Json.JsonElement

    type SecurityQueryRoleRequestBuilder() =
        member _.Yield(_: unit) : SecurityQueryRoleRequest =
            {
                Query = None
                From = None
                Sort = None
                Size = None
                SearchAfter = None
            }

        [<CustomOperation("query")>]
        member _.Query(state: SecurityQueryRoleRequest, value: Types.RoleQueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SecurityQueryRoleRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SecurityQueryRoleRequest, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SecurityQueryRoleRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: SecurityQueryRoleRequest, value: Types.SortResults) =
            { state with SearchAfter = Some value }

    let securityQueryRoleRequest = SecurityQueryRoleRequestBuilder()

    module QueryRole =
        let withQuery (value: Types.RoleQueryContainer) (req: SecurityQueryRoleRequest) =
            { req with Query = Some value }
        let withFrom (value: Types.Integer) (req: SecurityQueryRoleRequest) =
            { req with From = Some value }
        let withSort (value: Types.Sort) (req: SecurityQueryRoleRequest) =
            { req with Sort = Some value }
        let withSize (value: Types.Integer) (req: SecurityQueryRoleRequest) =
            { req with Size = Some value }
        let withSearchAfter (value: Types.SortResults) (req: SecurityQueryRoleRequest) =
            { req with SearchAfter = Some value }

    type SecurityQueryUserRequest = {
        WithProfileUid: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: Types.UserQueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: Types.Sort option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("search_after")>]
        SearchAfter: Types.SortResults option
    }

        with
        static member ToRequest(req: SecurityQueryUserRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/_query/user"
                let queryParams =
                    [
                        req.WithProfileUid |> Option.map (fun v -> "with_profile_uid", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityQueryUserResponse = System.Text.Json.JsonElement

    type SecurityQueryUserRequestBuilder() =
        member _.Yield(_: unit) : SecurityQueryUserRequest =
            {
                WithProfileUid = None
                Query = None
                From = None
                Sort = None
                Size = None
                SearchAfter = None
            }

        [<CustomOperation("withProfileUid")>]
        member _.WithProfileUid(state: SecurityQueryUserRequest, value: bool) =
            { state with WithProfileUid = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: SecurityQueryUserRequest, value: Types.UserQueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SecurityQueryUserRequest, value: Types.Integer) =
            { state with From = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: SecurityQueryUserRequest, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SecurityQueryUserRequest, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: SecurityQueryUserRequest, value: Types.SortResults) =
            { state with SearchAfter = Some value }

    let securityQueryUserRequest = SecurityQueryUserRequestBuilder()

    module QueryUser =
        let withWithProfileUid (value: bool) (req: SecurityQueryUserRequest) =
            { req with WithProfileUid = Some value }
        let withQuery (value: Types.UserQueryContainer) (req: SecurityQueryUserRequest) =
            { req with Query = Some value }
        let withFrom (value: Types.Integer) (req: SecurityQueryUserRequest) =
            { req with From = Some value }
        let withSort (value: Types.Sort) (req: SecurityQueryUserRequest) =
            { req with Sort = Some value }
        let withSize (value: Types.Integer) (req: SecurityQueryUserRequest) =
            { req with Size = Some value }
        let withSearchAfter (value: Types.SortResults) (req: SecurityQueryUserRequest) =
            { req with SearchAfter = Some value }

    type SecuritySamlAuthenticateRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("content")>]
        Content: string
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: Types.Ids
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string option
    }

        with
        static member ToRequest(req: SecuritySamlAuthenticateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/authenticate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySamlAuthenticateResponse = System.Text.Json.JsonElement

    type SecuritySamlAuthenticateRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlAuthenticateRequest =
            {
                Content = Unchecked.defaultof<_>
                Ids = Unchecked.defaultof<_>
                Realm = None
            }

        [<CustomOperation("content")>]
        member _.Content(state: SecuritySamlAuthenticateRequest, value: string) =
            { state with Content = value }

        [<CustomOperation("ids")>]
        member _.Ids(state: SecuritySamlAuthenticateRequest, value: Types.Ids) =
            { state with Ids = value }

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlAuthenticateRequest, value: string) =
            { state with Realm = Some value }

    let securitySamlAuthenticateRequest = SecuritySamlAuthenticateRequestBuilder()

    module SamlAuthenticate =
        let withContent (value: string) (req: SecuritySamlAuthenticateRequest) =
            { req with Content = value }
        let withIds (value: Types.Ids) (req: SecuritySamlAuthenticateRequest) =
            { req with Ids = value }
        let withRealm (value: string) (req: SecuritySamlAuthenticateRequest) =
            { req with Realm = Some value }

    type SecuritySamlCompleteLogoutRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: Types.Ids
        [<System.Text.Json.Serialization.JsonPropertyName("query_string")>]
        QueryString: string option
        [<System.Text.Json.Serialization.JsonPropertyName("content")>]
        Content: string option
    }

        with
        static member ToRequest(req: SecuritySamlCompleteLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/complete_logout"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySamlCompleteLogoutResponse = unit

    type SecuritySamlCompleteLogoutRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlCompleteLogoutRequest =
            {
                Realm = Unchecked.defaultof<_>
                Ids = Unchecked.defaultof<_>
                QueryString = None
                Content = None
            }

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlCompleteLogoutRequest, value: string) =
            { state with Realm = value }

        [<CustomOperation("ids")>]
        member _.Ids(state: SecuritySamlCompleteLogoutRequest, value: Types.Ids) =
            { state with Ids = value }

        [<CustomOperation("queryString")>]
        member _.QueryString(state: SecuritySamlCompleteLogoutRequest, value: string) =
            { state with QueryString = Some value }

        [<CustomOperation("content")>]
        member _.Content(state: SecuritySamlCompleteLogoutRequest, value: string) =
            { state with Content = Some value }

    let securitySamlCompleteLogoutRequest = SecuritySamlCompleteLogoutRequestBuilder()

    module SamlCompleteLogout =
        let withRealm (value: string) (req: SecuritySamlCompleteLogoutRequest) =
            { req with Realm = value }
        let withIds (value: Types.Ids) (req: SecuritySamlCompleteLogoutRequest) =
            { req with Ids = value }
        let withQueryString (value: string) (req: SecuritySamlCompleteLogoutRequest) =
            { req with QueryString = Some value }
        let withContent (value: string) (req: SecuritySamlCompleteLogoutRequest) =
            { req with Content = Some value }

    type SecuritySamlInvalidateRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("acs")>]
        Acs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("query_string")>]
        QueryString: string
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string option
    }

        with
        static member ToRequest(req: SecuritySamlInvalidateRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/invalidate"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySamlInvalidateResponse = System.Text.Json.JsonElement

    type SecuritySamlInvalidateRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlInvalidateRequest =
            {
                Acs = None
                QueryString = Unchecked.defaultof<_>
                Realm = None
            }

        [<CustomOperation("acs")>]
        member _.Acs(state: SecuritySamlInvalidateRequest, value: string) =
            { state with Acs = Some value }

        [<CustomOperation("queryString")>]
        member _.QueryString(state: SecuritySamlInvalidateRequest, value: string) =
            { state with QueryString = value }

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlInvalidateRequest, value: string) =
            { state with Realm = Some value }

    let securitySamlInvalidateRequest = SecuritySamlInvalidateRequestBuilder()

    module SamlInvalidate =
        let withAcs (value: string) (req: SecuritySamlInvalidateRequest) =
            { req with Acs = Some value }
        let withQueryString (value: string) (req: SecuritySamlInvalidateRequest) =
            { req with QueryString = value }
        let withRealm (value: string) (req: SecuritySamlInvalidateRequest) =
            { req with Realm = Some value }

    type SecuritySamlLogoutRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: string
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_token")>]
        RefreshToken: string option
    }

        with
        static member ToRequest(req: SecuritySamlLogoutRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/logout"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySamlLogoutResponse = System.Text.Json.JsonElement

    type SecuritySamlLogoutRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlLogoutRequest =
            {
                Token = Unchecked.defaultof<_>
                RefreshToken = None
            }

        [<CustomOperation("token")>]
        member _.Token(state: SecuritySamlLogoutRequest, value: string) =
            { state with Token = value }

        [<CustomOperation("refreshToken")>]
        member _.RefreshToken(state: SecuritySamlLogoutRequest, value: string) =
            { state with RefreshToken = Some value }

    let securitySamlLogoutRequest = SecuritySamlLogoutRequestBuilder()

    module SamlLogout =
        let withToken (value: string) (req: SecuritySamlLogoutRequest) =
            { req with Token = value }
        let withRefreshToken (value: string) (req: SecuritySamlLogoutRequest) =
            { req with RefreshToken = Some value }

    type SecuritySamlPrepareAuthenticationRequest = {
        [<System.Text.Json.Serialization.JsonPropertyName("acs")>]
        Acs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string option
        [<System.Text.Json.Serialization.JsonPropertyName("relay_state")>]
        RelayState: string option
    }

        with
        static member ToRequest(req: SecuritySamlPrepareAuthenticationRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/prepare"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySamlPrepareAuthenticationResponse = System.Text.Json.JsonElement

    type SecuritySamlPrepareAuthenticationRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlPrepareAuthenticationRequest =
            {
                Acs = None
                Realm = None
                RelayState = None
            }

        [<CustomOperation("acs")>]
        member _.Acs(state: SecuritySamlPrepareAuthenticationRequest, value: string) =
            { state with Acs = Some value }

        [<CustomOperation("realm")>]
        member _.Realm(state: SecuritySamlPrepareAuthenticationRequest, value: string) =
            { state with Realm = Some value }

        [<CustomOperation("relayState")>]
        member _.RelayState(state: SecuritySamlPrepareAuthenticationRequest, value: string) =
            { state with RelayState = Some value }

    let securitySamlPrepareAuthenticationRequest = SecuritySamlPrepareAuthenticationRequestBuilder()

    module SamlPrepareAuthentication =
        let withAcs (value: string) (req: SecuritySamlPrepareAuthenticationRequest) =
            { req with Acs = Some value }
        let withRealm (value: string) (req: SecuritySamlPrepareAuthenticationRequest) =
            { req with Realm = Some value }
        let withRelayState (value: string) (req: SecuritySamlPrepareAuthenticationRequest) =
            { req with RelayState = Some value }

    type SecuritySamlServiceProviderMetadataRequest = {
        RealmName: Types.Name
    }

        with
        static member ToRequest(req: SecuritySamlServiceProviderMetadataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/saml/metadata/{req.RealmName}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Get
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySamlServiceProviderMetadataResponse = System.Text.Json.JsonElement

    type SecuritySamlServiceProviderMetadataRequestBuilder() =
        member _.Yield(_: unit) : SecuritySamlServiceProviderMetadataRequest =
            {
                RealmName = Unchecked.defaultof<_>
            }

        [<CustomOperation("realmName")>]
        member _.RealmName(state: SecuritySamlServiceProviderMetadataRequest, value: Types.Name) =
            { state with RealmName = value }

    let securitySamlServiceProviderMetadataRequest = SecuritySamlServiceProviderMetadataRequestBuilder()

    type SecuritySuggestUserProfilesRequest = {
        Data: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        bodyData: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("hint")>]
        Hint: Types.Hint option
    }

        with
        static member ToRequest(req: SecuritySuggestUserProfilesRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/_suggest"
                let queryParams =
                    [
                        req.Data |> Option.map (fun v -> "data", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecuritySuggestUserProfilesResponse = System.Text.Json.JsonElement

    type SecuritySuggestUserProfilesRequestBuilder() =
        member _.Yield(_: unit) : SecuritySuggestUserProfilesRequest =
            {
                Data = None
                Name = None
                Size = None
                bodyData = None
                Hint = None
            }

        [<CustomOperation("data")>]
        member _.Data(state: SecuritySuggestUserProfilesRequest, value: System.Text.Json.JsonElement) =
            { state with Data = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: SecuritySuggestUserProfilesRequest, value: string) =
            { state with Name = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SecuritySuggestUserProfilesRequest, value: Types.Long) =
            { state with Size = Some value }

        [<CustomOperation("data")>]
        member _.Data(state: SecuritySuggestUserProfilesRequest, value: System.Text.Json.JsonElement) =
            { state with bodyData = Some value }

        [<CustomOperation("hint")>]
        member _.Hint(state: SecuritySuggestUserProfilesRequest, value: Types.Hint) =
            { state with Hint = Some value }

    let securitySuggestUserProfilesRequest = SecuritySuggestUserProfilesRequestBuilder()

    module SuggestUserProfiles =
        let withData (value: System.Text.Json.JsonElement) (req: SecuritySuggestUserProfilesRequest) =
            { req with bodyData = Some value }
        let withName (value: string) (req: SecuritySuggestUserProfilesRequest) =
            { req with Name = Some value }
        let withSize (value: Types.Long) (req: SecuritySuggestUserProfilesRequest) =
            { req with Size = Some value }
        let withData (value: System.Text.Json.JsonElement) (req: SecuritySuggestUserProfilesRequest) =
            { req with bodyData = Some value }
        let withHint (value: Types.Hint) (req: SecuritySuggestUserProfilesRequest) =
            { req with Hint = Some value }

    type SecurityUpdateApiKeyRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, Types.RoleDescriptor> option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: Types.Duration option
    }

        with
        static member ToRequest(req: SecurityUpdateApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/api_key/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityUpdateApiKeyResponse = System.Text.Json.JsonElement

    type SecurityUpdateApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateApiKeyRequest =
            {
                Id = Unchecked.defaultof<_>
                RoleDescriptors = None
                Metadata = None
                Expiration = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SecurityUpdateApiKeyRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("roleDescriptors")>]
        member _.RoleDescriptors(state: SecurityUpdateApiKeyRequest, value: Map<string, Types.RoleDescriptor>) =
            { state with RoleDescriptors = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityUpdateApiKeyRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityUpdateApiKeyRequest, value: Types.Duration) =
            { state with Expiration = Some value }

    let securityUpdateApiKeyRequest = SecurityUpdateApiKeyRequestBuilder()

    module UpdateApiKey =
        let withRoleDescriptors (value: Map<string, Types.RoleDescriptor>) (req: SecurityUpdateApiKeyRequest) =
            { req with RoleDescriptors = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityUpdateApiKeyRequest) =
            { req with Metadata = Some value }
        let withExpiration (value: Types.Duration) (req: SecurityUpdateApiKeyRequest) =
            { req with Expiration = Some value }

    type SecurityUpdateCrossClusterApiKeyRequest = {
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("access")>]
        Access: Types.Access
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("certificate_identity")>]
        CertificateIdentity: string option
    }

        with
        static member ToRequest(req: SecurityUpdateCrossClusterApiKeyRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/cross_cluster/api_key/{req.Id}"
                let fullPath = path
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Put
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityUpdateCrossClusterApiKeyResponse = System.Text.Json.JsonElement

    type SecurityUpdateCrossClusterApiKeyRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateCrossClusterApiKeyRequest =
            {
                Id = Unchecked.defaultof<_>
                Access = Unchecked.defaultof<_>
                Expiration = None
                Metadata = None
                CertificateIdentity = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: SecurityUpdateCrossClusterApiKeyRequest, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("access")>]
        member _.Access(state: SecurityUpdateCrossClusterApiKeyRequest, value: Types.Access) =
            { state with Access = value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: SecurityUpdateCrossClusterApiKeyRequest, value: Types.Duration) =
            { state with Expiration = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SecurityUpdateCrossClusterApiKeyRequest, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("certificateIdentity")>]
        member _.CertificateIdentity(state: SecurityUpdateCrossClusterApiKeyRequest, value: string) =
            { state with CertificateIdentity = Some value }

    let securityUpdateCrossClusterApiKeyRequest = SecurityUpdateCrossClusterApiKeyRequestBuilder()

    module UpdateCrossClusterApiKey =
        let withAccess (value: Types.Access) (req: SecurityUpdateCrossClusterApiKeyRequest) =
            { req with Access = value }
        let withExpiration (value: Types.Duration) (req: SecurityUpdateCrossClusterApiKeyRequest) =
            { req with Expiration = Some value }
        let withMetadata (value: Types.Metadata) (req: SecurityUpdateCrossClusterApiKeyRequest) =
            { req with Metadata = Some value }
        let withCertificateIdentity (value: string) (req: SecurityUpdateCrossClusterApiKeyRequest) =
            { req with CertificateIdentity = Some value }

    type SecurityUpdateSettingsRequest = {
        MasterTimeout: Types.Duration option
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("security")>]
        Security: Types.SecuritySettings option
        [<System.Text.Json.Serialization.JsonPropertyName("security-profile")>]
        SecurityProfile: Types.SecuritySettings option
        [<System.Text.Json.Serialization.JsonPropertyName("security-tokens")>]
        SecurityTokens: Types.SecuritySettings option
    }

        with
        static member ToRequest(req: SecurityUpdateSettingsRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/settings"
                let queryParams =
                    [
                        req.MasterTimeout |> Option.map (fun v -> "master_timeout", Fes.Http.toQueryValue v)
                        req.Timeout |> Option.map (fun v -> "timeout", Fes.Http.toQueryValue v)
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

    type SecurityUpdateSettingsResponse = System.Text.Json.JsonElement

    type SecurityUpdateSettingsRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateSettingsRequest =
            {
                MasterTimeout = None
                Timeout = None
                Security = None
                SecurityProfile = None
                SecurityTokens = None
            }

        [<CustomOperation("masterTimeout")>]
        member _.MasterTimeout(state: SecurityUpdateSettingsRequest, value: Types.Duration) =
            { state with MasterTimeout = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SecurityUpdateSettingsRequest, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("security")>]
        member _.Security(state: SecurityUpdateSettingsRequest, value: Types.SecuritySettings) =
            { state with Security = Some value }

        [<CustomOperation("securityProfile")>]
        member _.SecurityProfile(state: SecurityUpdateSettingsRequest, value: Types.SecuritySettings) =
            { state with SecurityProfile = Some value }

        [<CustomOperation("securityTokens")>]
        member _.SecurityTokens(state: SecurityUpdateSettingsRequest, value: Types.SecuritySettings) =
            { state with SecurityTokens = Some value }

    let securityUpdateSettingsRequest = SecurityUpdateSettingsRequestBuilder()

    module UpdateSettings =
        let withMasterTimeout (value: Types.Duration) (req: SecurityUpdateSettingsRequest) =
            { req with MasterTimeout = Some value }
        let withTimeout (value: Types.Duration) (req: SecurityUpdateSettingsRequest) =
            { req with Timeout = Some value }
        let withSecurity (value: Types.SecuritySettings) (req: SecurityUpdateSettingsRequest) =
            { req with Security = Some value }
        let withSecurityProfile (value: Types.SecuritySettings) (req: SecurityUpdateSettingsRequest) =
            { req with SecurityProfile = Some value }
        let withSecurityTokens (value: Types.SecuritySettings) (req: SecurityUpdateSettingsRequest) =
            { req with SecurityTokens = Some value }

    type SecurityUpdateUserProfileDataRequest = {
        Uid: Types.UserProfileId
        IfSeqNo: Types.SequenceNumber option
        IfPrimaryTerm: Types.Long option
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("labels")>]
        Labels: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: Map<string, System.Text.Json.JsonElement> option
    }

        with
        static member ToRequest(req: SecurityUpdateUserProfileDataRequest) : Result<Fes.Http.RequestMsg, exn> =
            try
                let path = $"/_security/profile/{req.Uid}/_data"
                let queryParams =
                    [
                        req.IfSeqNo |> Option.map (fun v -> "if_seq_no", Fes.Http.toQueryValue v)
                        req.IfPrimaryTerm |> Option.map (fun v -> "if_primary_term", Fes.Http.toQueryValue v)
                        req.Refresh |> Option.map (fun v -> "refresh", Fes.Http.toQueryValue v)
                    ] |> List.choose id
                let queryString =
                    if List.isEmpty queryParams then ""
                    else "?" + (queryParams |> List.map (fun (k, v) -> k + "=" + v) |> String.concat "&")
                let fullPath = path + queryString
                fullPath
                |> Fes.Http.Request.fromPath
                |> Fes.Http.Request.withMethod Fes.Http.Method.Post
                |> Fes.Http.Request.withJsonBody req
                |> Result.Ok
            with ex -> Result.Error ex

    type SecurityUpdateUserProfileDataResponse = Types.AcknowledgedResponseBase

    type SecurityUpdateUserProfileDataRequestBuilder() =
        member _.Yield(_: unit) : SecurityUpdateUserProfileDataRequest =
            {
                Uid = Unchecked.defaultof<_>
                IfSeqNo = None
                IfPrimaryTerm = None
                Refresh = None
                Labels = None
                Data = None
            }

        [<CustomOperation("uid")>]
        member _.Uid(state: SecurityUpdateUserProfileDataRequest, value: Types.UserProfileId) =
            { state with Uid = value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: SecurityUpdateUserProfileDataRequest, value: Types.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: SecurityUpdateUserProfileDataRequest, value: Types.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: SecurityUpdateUserProfileDataRequest, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("labels")>]
        member _.Labels(state: SecurityUpdateUserProfileDataRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Labels = Some value }

        [<CustomOperation("data")>]
        member _.Data(state: SecurityUpdateUserProfileDataRequest, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Data = Some value }

    let securityUpdateUserProfileDataRequest = SecurityUpdateUserProfileDataRequestBuilder()

    module UpdateUserProfileData =
        let withIfSeqNo (value: Types.SequenceNumber) (req: SecurityUpdateUserProfileDataRequest) =
            { req with IfSeqNo = Some value }
        let withIfPrimaryTerm (value: Types.Long) (req: SecurityUpdateUserProfileDataRequest) =
            { req with IfPrimaryTerm = Some value }
        let withRefresh (value: Types.Refresh) (req: SecurityUpdateUserProfileDataRequest) =
            { req with Refresh = Some value }
        let withLabels (value: Map<string, System.Text.Json.JsonElement>) (req: SecurityUpdateUserProfileDataRequest) =
            { req with Labels = Some value }
        let withData (value: Map<string, System.Text.Json.JsonElement>) (req: SecurityUpdateUserProfileDataRequest) =
            { req with Data = Some value }

