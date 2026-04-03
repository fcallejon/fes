// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityTypesBuilders =

    type AccessBuilder() =
        member _.Yield(_: unit) : Types.Access =
            {
                Replication = None
                Search = None
            }

        [<CustomOperation("replication")>]
        member _.Replication(state: Types.Access, value: Types.ReplicationAccess list) =
            { state with Replication = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Types.Access, value: Types.SearchAccess list) =
            { state with Search = Some value }

    let access = AccessBuilder()

    type ApiKeyBuilder() =
        member _.Yield(_: unit) : Types.ApiKey =
            {
                Id = Unchecked.defaultof<_>
                Name = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Creation = Unchecked.defaultof<_>
                Expiration = None
                Invalidated = Unchecked.defaultof<_>
                Invalidation = None
                Username = Unchecked.defaultof<_>
                Realm = Unchecked.defaultof<_>
                RealmType = None
                Metadata = Unchecked.defaultof<_>
                RoleDescriptors = None
                LimitedBy = None
                Access = None
                CertificateIdentity = None
                ProfileUid = None
                Sort = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ApiKey, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.ApiKey, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ApiKey, value: Types.ApiKeyType) =
            { state with Type = value }

        [<CustomOperation("creation")>]
        member _.Creation(state: Types.ApiKey, value: Types.EpochTime<Types.UnitMillis>) =
            { state with Creation = value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: Types.ApiKey, value: Types.EpochTime<Types.UnitMillis>) =
            { state with Expiration = Some value }

        [<CustomOperation("invalidated")>]
        member _.Invalidated(state: Types.ApiKey, value: bool) =
            { state with Invalidated = value }

        [<CustomOperation("invalidation")>]
        member _.Invalidation(state: Types.ApiKey, value: Types.EpochTime<Types.UnitMillis>) =
            { state with Invalidation = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: Types.ApiKey, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("realm")>]
        member _.Realm(state: Types.ApiKey, value: string) =
            { state with Realm = value }

        [<CustomOperation("realmType")>]
        member _.RealmType(state: Types.ApiKey, value: string) =
            { state with RealmType = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.ApiKey, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roleDescriptors")>]
        member _.RoleDescriptors(state: Types.ApiKey, value: Map<string, Types.RoleDescriptor>) =
            { state with RoleDescriptors = Some value }

        [<CustomOperation("limitedBy")>]
        member _.LimitedBy(state: Types.ApiKey, value: Map<string, Types.RoleDescriptor> list) =
            { state with LimitedBy = Some value }

        [<CustomOperation("access")>]
        member _.Access(state: Types.ApiKey, value: Types.Access) =
            { state with Access = Some value }

        [<CustomOperation("certificateIdentity")>]
        member _.CertificateIdentity(state: Types.ApiKey, value: string) =
            { state with CertificateIdentity = Some value }

        [<CustomOperation("profileUid")>]
        member _.ProfileUid(state: Types.ApiKey, value: string) =
            { state with ProfileUid = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.ApiKey, value: Types.SortResults) =
            { state with Sort = Some value }

    let apiKey = ApiKeyBuilder()

    type FieldSecurityBuilder() =
        member _.Yield(_: unit) : Types.FieldSecurity =
            {
                Except = None
                Grant = None
            }

        [<CustomOperation("except")>]
        member _.Except(state: Types.FieldSecurity, value: Types.Fields) =
            { state with Except = Some value }

        [<CustomOperation("grant")>]
        member _.Grant(state: Types.FieldSecurity, value: Types.Fields) =
            { state with Grant = Some value }

    let fieldSecurity = FieldSecurityBuilder()

    type IndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : Types.IndicesPrivileges =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.IndicesPrivileges, value: Types.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.IndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: Types.IndicesPrivileges, value: Types.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.IndicesPrivileges, value: Types.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.IndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let indicesPrivileges = IndicesPrivilegesBuilder()

    type IndicesPrivilegesBaseBuilder() =
        member _.Yield(_: unit) : Types.IndicesPrivilegesBase =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.IndicesPrivilegesBase, value: Types.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.IndicesPrivilegesBase, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: Types.IndicesPrivilegesBase, value: Types.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.IndicesPrivilegesBase, value: Types.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.IndicesPrivilegesBase, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let indicesPrivilegesBase = IndicesPrivilegesBaseBuilder()

    type RemoteIndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : Types.RemoteIndicesPrivileges =
            {
                Clusters = Unchecked.defaultof<_>
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: Types.RemoteIndicesPrivileges, value: Types.Names) =
            { state with Clusters = value }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.RemoteIndicesPrivileges, value: Types.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.RemoteIndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: Types.RemoteIndicesPrivileges, value: Types.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.RemoteIndicesPrivileges, value: Types.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.RemoteIndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let remoteIndicesPrivileges = RemoteIndicesPrivilegesBuilder()

    type RemoteUserIndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : Types.RemoteUserIndicesPrivileges =
            {
                Clusters = Unchecked.defaultof<_>
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = Unchecked.defaultof<_>
            }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: Types.RemoteUserIndicesPrivileges, value: string list) =
            { state with Clusters = value }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.RemoteUserIndicesPrivileges, value: Types.FieldSecurity list) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.RemoteUserIndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: Types.RemoteUserIndicesPrivileges, value: Types.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.RemoteUserIndicesPrivileges, value: Types.IndicesPrivilegesQuery list) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.RemoteUserIndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = value }

    let remoteUserIndicesPrivileges = RemoteUserIndicesPrivilegesBuilder()

    type RoleDescriptorBuilder() =
        member _.Yield(_: unit) : Types.RoleDescriptor =
            {
                Cluster = None
                Indices = None
                RemoteIndices = None
                RemoteCluster = None
                Global = None
                Applications = None
                Metadata = None
                RunAs = None
                Description = None
                Restriction = None
                TransientMetadata = None
            }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.RoleDescriptor, value: Types.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.RoleDescriptor, value: Types.IndicesPrivileges list) =
            { state with Indices = Some value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: Types.RoleDescriptor, value: Types.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: Types.RoleDescriptor, value: Types.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: Types.RoleDescriptor, value: System.Text.Json.JsonElement) =
            { state with Global = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: Types.RoleDescriptor, value: Types.ApplicationPrivileges list) =
            { state with Applications = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.RoleDescriptor, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: Types.RoleDescriptor, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RoleDescriptor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("restriction")>]
        member _.Restriction(state: Types.RoleDescriptor, value: Types.Restriction) =
            { state with Restriction = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: Types.RoleDescriptor, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

    let roleDescriptor = RoleDescriptorBuilder()

    type RoleDescriptorReadBuilder() =
        member _.Yield(_: unit) : Types.RoleDescriptorRead =
            {
                Cluster = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                RemoteIndices = None
                RemoteCluster = None
                Global = None
                Applications = None
                Metadata = None
                RunAs = None
                Description = None
                Restriction = None
                TransientMetadata = None
            }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.RoleDescriptorRead, value: Types.ClusterPrivilege list) =
            { state with Cluster = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.RoleDescriptorRead, value: Types.IndicesPrivileges list) =
            { state with Indices = value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: Types.RoleDescriptorRead, value: Types.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: Types.RoleDescriptorRead, value: Types.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: Types.RoleDescriptorRead, value: System.Text.Json.JsonElement) =
            { state with Global = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: Types.RoleDescriptorRead, value: Types.ApplicationPrivileges list) =
            { state with Applications = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.RoleDescriptorRead, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: Types.RoleDescriptorRead, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RoleDescriptorRead, value: string) =
            { state with Description = Some value }

        [<CustomOperation("restriction")>]
        member _.Restriction(state: Types.RoleDescriptorRead, value: Types.Restriction) =
            { state with Restriction = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: Types.RoleDescriptorRead, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

    let roleDescriptorRead = RoleDescriptorReadBuilder()

    type SecurityTypesRoleMappingBuilder() =
        member _.Yield(_: unit) : Types.SecurityTypesRoleMapping =
            {
                Enabled = Unchecked.defaultof<_>
                Metadata = Unchecked.defaultof<_>
                Roles = None
                RoleTemplates = None
                Rules = Unchecked.defaultof<_>
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.SecurityTypesRoleMapping, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.SecurityTypesRoleMapping, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.SecurityTypesRoleMapping, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("roleTemplates")>]
        member _.RoleTemplates(state: Types.SecurityTypesRoleMapping, value: Types.RoleTemplate list) =
            { state with RoleTemplates = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: Types.SecurityTypesRoleMapping, value: Types.RoleMappingRule) =
            { state with Rules = value }

    let securityTypesRoleMapping = SecurityTypesRoleMappingBuilder()

    module RoleMappingRule =

        let any (value: Types.RoleMappingRule list) =
            Types.RoleMappingRule.Any value

        let all (value: Types.RoleMappingRule list) =
            Types.RoleMappingRule.All value

        let field (field: string) (value: System.Text.Json.JsonElement) =
            Types.RoleMappingRule.Field (field, value)

        let except (value: Types.RoleMappingRule) =
            Types.RoleMappingRule.Except value

    type RoleTemplateScriptBuilder() =
        member _.Yield(_: unit) : Types.RoleTemplateScript =
            {
                Source = None
                Id = None
                Params = None
                Lang = None
                Options = None
            }

        [<CustomOperation("source")>]
        member _.Source(state: Types.RoleTemplateScript, value: Types.RoleTemplateInlineQuery) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.RoleTemplateScript, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.RoleTemplateScript, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: Types.RoleTemplateScript, value: Types.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("options")>]
        member _.Options(state: Types.RoleTemplateScript, value: Map<string, string>) =
            { state with Options = Some value }

    let roleTemplateScript = RoleTemplateScriptBuilder()

    let createRoleTemplateScript (value: Types.RoleTemplateInlineQuery) : Types.RoleTemplateScript =
        {
            Source = Some value
            Id = None
            Params = None
            Lang = None
            Options = None
        }

    type SearchAccessBuilder() =
        member _.Yield(_: unit) : Types.SearchAccess =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.SearchAccess, value: Types.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.SearchAccess, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.SearchAccess, value: Types.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.SearchAccess, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let searchAccess = SearchAccessBuilder()

    type UserBuilder() =
        member _.Yield(_: unit) : Types.User =
            {
                Email = None
                FullName = None
                Metadata = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                Username = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
                ProfileUid = None
            }

        [<CustomOperation("email")>]
        member _.Email(state: Types.User, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: Types.User, value: Types.Name option) =
            { state with FullName = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.User, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.User, value: string list) =
            { state with Roles = value }

        [<CustomOperation("username")>]
        member _.Username(state: Types.User, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.User, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("profileUid")>]
        member _.ProfileUid(state: Types.User, value: Types.UserProfileId) =
            { state with ProfileUid = Some value }

    let user = UserBuilder()

    type UserIndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : Types.UserIndicesPrivileges =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = Unchecked.defaultof<_>
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.UserIndicesPrivileges, value: Types.FieldSecurity list) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.UserIndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: Types.UserIndicesPrivileges, value: Types.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.UserIndicesPrivileges, value: Types.IndicesPrivilegesQuery list) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.UserIndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = value }

    let userIndicesPrivileges = UserIndicesPrivilegesBuilder()

    type UserIndicesPrivilegesBaseBuilder() =
        member _.Yield(_: unit) : Types.UserIndicesPrivilegesBase =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = Unchecked.defaultof<_>
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: Types.UserIndicesPrivilegesBase, value: Types.FieldSecurity list) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: Types.UserIndicesPrivilegesBase, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: Types.UserIndicesPrivilegesBase, value: Types.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.UserIndicesPrivilegesBase, value: Types.IndicesPrivilegesQuery list) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: Types.UserIndicesPrivilegesBase, value: bool) =
            { state with AllowRestrictedIndices = value }

    let userIndicesPrivilegesBase = UserIndicesPrivilegesBaseBuilder()

    type UserProfileUserBuilder() =
        member _.Yield(_: unit) : Types.UserProfileUser =
            {
                Email = None
                FullName = None
                RealmName = Unchecked.defaultof<_>
                RealmDomain = None
                Roles = Unchecked.defaultof<_>
                Username = Unchecked.defaultof<_>
            }

        [<CustomOperation("email")>]
        member _.Email(state: Types.UserProfileUser, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: Types.UserProfileUser, value: Types.Name option) =
            { state with FullName = Some value }

        [<CustomOperation("realmName")>]
        member _.RealmName(state: Types.UserProfileUser, value: Types.Name) =
            { state with RealmName = value }

        [<CustomOperation("realmDomain")>]
        member _.RealmDomain(state: Types.UserProfileUser, value: Types.Name) =
            { state with RealmDomain = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.UserProfileUser, value: string list) =
            { state with Roles = value }

        [<CustomOperation("username")>]
        member _.Username(state: Types.UserProfileUser, value: Types.Username) =
            { state with Username = value }

    let userProfileUser = UserProfileUserBuilder()

