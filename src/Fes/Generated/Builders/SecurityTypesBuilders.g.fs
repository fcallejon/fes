// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityTypesBuilders =

    type AccessBuilder() =
        member _.Yield(_: unit) : Access =
            {
                Replication = None
                Search = None
            }

        [<CustomOperation("replication")>]
        member _.Replication(state: Access, value: SecurityTypes.ReplicationAccess list) =
            { state with Replication = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Access, value: SecurityTypes.SearchAccess list) =
            { state with Search = Some value }

    let access = AccessBuilder()

    type ApiKeyBuilder() =
        member _.Yield(_: unit) : ApiKey =
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
        member _.Id(state: ApiKey, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("name")>]
        member _.Name(state: ApiKey, value: CoreTypes.Name) =
            { state with Name = value }

        [<CustomOperation("type'")>]
        member _.Type(state: ApiKey, value: SecurityTypes.ApiKeyType) =
            { state with Type = value }

        [<CustomOperation("creation")>]
        member _.Creation(state: ApiKey, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with Creation = value }

        [<CustomOperation("expiration")>]
        member _.Expiration(state: ApiKey, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with Expiration = Some value }

        [<CustomOperation("invalidated")>]
        member _.Invalidated(state: ApiKey, value: bool) =
            { state with Invalidated = value }

        [<CustomOperation("invalidation")>]
        member _.Invalidation(state: ApiKey, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with Invalidation = Some value }

        [<CustomOperation("username")>]
        member _.Username(state: ApiKey, value: CoreTypes.Username) =
            { state with Username = value }

        [<CustomOperation("realm")>]
        member _.Realm(state: ApiKey, value: string) =
            { state with Realm = value }

        [<CustomOperation("realmType")>]
        member _.RealmType(state: ApiKey, value: string) =
            { state with RealmType = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: ApiKey, value: CoreTypes.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roleDescriptors")>]
        member _.RoleDescriptors(state: ApiKey, value: Map<string, SecurityTypes.RoleDescriptor>) =
            { state with RoleDescriptors = Some value }

        [<CustomOperation("limitedBy")>]
        member _.LimitedBy(state: ApiKey, value: Map<string, SecurityTypes.RoleDescriptor> list) =
            { state with LimitedBy = Some value }

        [<CustomOperation("access")>]
        member _.Access(state: ApiKey, value: SecurityTypes.Access) =
            { state with Access = Some value }

        [<CustomOperation("certificateIdentity")>]
        member _.CertificateIdentity(state: ApiKey, value: string) =
            { state with CertificateIdentity = Some value }

        [<CustomOperation("profileUid")>]
        member _.ProfileUid(state: ApiKey, value: string) =
            { state with ProfileUid = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: ApiKey, value: CoreTypes.SortResults) =
            { state with Sort = Some value }

    let apiKey = ApiKeyBuilder()

    type FieldSecurityBuilder() =
        member _.Yield(_: unit) : FieldSecurity =
            {
                Except = None
                Grant = None
            }

        [<CustomOperation("except")>]
        member _.Except(state: FieldSecurity, value: CoreTypes.Fields) =
            { state with Except = Some value }

        [<CustomOperation("grant")>]
        member _.Grant(state: FieldSecurity, value: CoreTypes.Fields) =
            { state with Grant = Some value }

    let fieldSecurity = FieldSecurityBuilder()

    type IndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : IndicesPrivileges =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: IndicesPrivileges, value: SecurityTypes.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: IndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: IndicesPrivileges, value: SecurityTypes.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: IndicesPrivileges, value: SecurityTypes.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: IndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let indicesPrivileges = IndicesPrivilegesBuilder()

    type IndicesPrivilegesBaseBuilder() =
        member _.Yield(_: unit) : IndicesPrivilegesBase =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: IndicesPrivilegesBase, value: SecurityTypes.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: IndicesPrivilegesBase, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: IndicesPrivilegesBase, value: SecurityTypes.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: IndicesPrivilegesBase, value: SecurityTypes.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: IndicesPrivilegesBase, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let indicesPrivilegesBase = IndicesPrivilegesBaseBuilder()

    type RemoteIndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : RemoteIndicesPrivileges =
            {
                Clusters = Unchecked.defaultof<_>
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: RemoteIndicesPrivileges, value: CoreTypes.Names) =
            { state with Clusters = value }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: RemoteIndicesPrivileges, value: SecurityTypes.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: RemoteIndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: RemoteIndicesPrivileges, value: SecurityTypes.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: RemoteIndicesPrivileges, value: SecurityTypes.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: RemoteIndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let remoteIndicesPrivileges = RemoteIndicesPrivilegesBuilder()

    type RemoteUserIndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : RemoteUserIndicesPrivileges =
            {
                Clusters = Unchecked.defaultof<_>
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = Unchecked.defaultof<_>
            }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: RemoteUserIndicesPrivileges, value: string list) =
            { state with Clusters = value }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: RemoteUserIndicesPrivileges, value: SecurityTypes.FieldSecurity list) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: RemoteUserIndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: RemoteUserIndicesPrivileges, value: SecurityTypes.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: RemoteUserIndicesPrivileges, value: SecurityTypes.IndicesPrivilegesQuery list) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: RemoteUserIndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = value }

    let remoteUserIndicesPrivileges = RemoteUserIndicesPrivilegesBuilder()

    type RoleDescriptorBuilder() =
        member _.Yield(_: unit) : RoleDescriptor =
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
        member _.Cluster(state: RoleDescriptor, value: SecurityTypes.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: RoleDescriptor, value: SecurityTypes.IndicesPrivileges list) =
            { state with Indices = Some value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: RoleDescriptor, value: SecurityTypes.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: RoleDescriptor, value: SecurityTypes.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: RoleDescriptor, value: System.Text.Json.JsonElement) =
            { state with Global = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: RoleDescriptor, value: SecurityTypes.ApplicationPrivileges list) =
            { state with Applications = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: RoleDescriptor, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: RoleDescriptor, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: RoleDescriptor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("restriction")>]
        member _.Restriction(state: RoleDescriptor, value: SecurityTypes.Restriction) =
            { state with Restriction = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: RoleDescriptor, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

    let roleDescriptor = RoleDescriptorBuilder()

    type RoleDescriptorReadBuilder() =
        member _.Yield(_: unit) : RoleDescriptorRead =
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
        member _.Cluster(state: RoleDescriptorRead, value: SecurityTypes.ClusterPrivilege list) =
            { state with Cluster = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: RoleDescriptorRead, value: SecurityTypes.IndicesPrivileges list) =
            { state with Indices = value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: RoleDescriptorRead, value: SecurityTypes.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: RoleDescriptorRead, value: SecurityTypes.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: RoleDescriptorRead, value: System.Text.Json.JsonElement) =
            { state with Global = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: RoleDescriptorRead, value: SecurityTypes.ApplicationPrivileges list) =
            { state with Applications = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: RoleDescriptorRead, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: RoleDescriptorRead, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: RoleDescriptorRead, value: string) =
            { state with Description = Some value }

        [<CustomOperation("restriction")>]
        member _.Restriction(state: RoleDescriptorRead, value: SecurityTypes.Restriction) =
            { state with Restriction = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: RoleDescriptorRead, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

    let roleDescriptorRead = RoleDescriptorReadBuilder()

    type RoleMappingBuilder() =
        member _.Yield(_: unit) : RoleMapping =
            {
                Enabled = Unchecked.defaultof<_>
                Metadata = Unchecked.defaultof<_>
                Roles = None
                RoleTemplates = None
                Rules = Unchecked.defaultof<_>
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: RoleMapping, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: RoleMapping, value: CoreTypes.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: RoleMapping, value: string list) =
            { state with Roles = Some value }

        [<CustomOperation("roleTemplates")>]
        member _.RoleTemplates(state: RoleMapping, value: SecurityTypes.RoleTemplate list) =
            { state with RoleTemplates = Some value }

        [<CustomOperation("rules")>]
        member _.Rules(state: RoleMapping, value: SecurityTypes.RoleMappingRule) =
            { state with Rules = value }

    let roleMapping = RoleMappingBuilder()

    module RoleMappingRule =

        let any (value: SecurityTypes.RoleMappingRule list) =
            RoleMappingRule.Any value

        let all (value: SecurityTypes.RoleMappingRule list) =
            RoleMappingRule.All value

        let field (field: string) (value: System.Text.Json.JsonElement) =
            RoleMappingRule.Field (field, value)

        let except (value: SecurityTypes.RoleMappingRule) =
            RoleMappingRule.Except value

    type RoleTemplateScriptBuilder() =
        member _.Yield(_: unit) : RoleTemplateScript =
            {
                Source = None
                Id = None
                Params = None
                Lang = None
                Options = None
            }

        [<CustomOperation("source")>]
        member _.Source(state: RoleTemplateScript, value: SecurityTypes.RoleTemplateInlineQuery) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: RoleTemplateScript, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: RoleTemplateScript, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: RoleTemplateScript, value: CoreTypes.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("options")>]
        member _.Options(state: RoleTemplateScript, value: Map<string, string>) =
            { state with Options = Some value }

    let roleTemplateScript = RoleTemplateScriptBuilder()

    let ofSource (value: SecurityTypes.RoleTemplateInlineQuery) : RoleTemplateScript =
        {
            Source = value
            Id = None
            Params = None
            Lang = None
            Options = None
        }

    type SearchAccessBuilder() =
        member _.Yield(_: unit) : SearchAccess =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = None
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: SearchAccess, value: SecurityTypes.FieldSecurity) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: SearchAccess, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("query")>]
        member _.Query(state: SearchAccess, value: SecurityTypes.IndicesPrivilegesQuery) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: SearchAccess, value: bool) =
            { state with AllowRestrictedIndices = Some value }

    let searchAccess = SearchAccessBuilder()

    type UserBuilder() =
        member _.Yield(_: unit) : User =
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
        member _.Email(state: User, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: User, value: CoreTypes.Name option) =
            { state with FullName = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: User, value: CoreTypes.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: User, value: string list) =
            { state with Roles = value }

        [<CustomOperation("username")>]
        member _.Username(state: User, value: CoreTypes.Username) =
            { state with Username = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: User, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("profileUid")>]
        member _.ProfileUid(state: User, value: SecurityTypes.UserProfileId) =
            { state with ProfileUid = Some value }

    let user = UserBuilder()

    type UserIndicesPrivilegesBuilder() =
        member _.Yield(_: unit) : UserIndicesPrivileges =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = Unchecked.defaultof<_>
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: UserIndicesPrivileges, value: SecurityTypes.FieldSecurity list) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: UserIndicesPrivileges, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: UserIndicesPrivileges, value: SecurityTypes.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: UserIndicesPrivileges, value: SecurityTypes.IndicesPrivilegesQuery list) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: UserIndicesPrivileges, value: bool) =
            { state with AllowRestrictedIndices = value }

    let userIndicesPrivileges = UserIndicesPrivilegesBuilder()

    type UserIndicesPrivilegesBaseBuilder() =
        member _.Yield(_: unit) : UserIndicesPrivilegesBase =
            {
                FieldSecurity = None
                Names = Unchecked.defaultof<_>
                Privileges = Unchecked.defaultof<_>
                Query = None
                AllowRestrictedIndices = Unchecked.defaultof<_>
            }

        [<CustomOperation("fieldSecurity")>]
        member _.FieldSecurity(state: UserIndicesPrivilegesBase, value: SecurityTypes.FieldSecurity list) =
            { state with FieldSecurity = Some value }

        [<CustomOperation("names")>]
        member _.Names(state: UserIndicesPrivilegesBase, value: System.Text.Json.JsonElement) =
            { state with Names = value }

        [<CustomOperation("privileges")>]
        member _.Privileges(state: UserIndicesPrivilegesBase, value: SecurityTypes.IndexPrivilege list) =
            { state with Privileges = value }

        [<CustomOperation("query")>]
        member _.Query(state: UserIndicesPrivilegesBase, value: SecurityTypes.IndicesPrivilegesQuery list) =
            { state with Query = Some value }

        [<CustomOperation("allowRestrictedIndices")>]
        member _.AllowRestrictedIndices(state: UserIndicesPrivilegesBase, value: bool) =
            { state with AllowRestrictedIndices = value }

    let userIndicesPrivilegesBase = UserIndicesPrivilegesBaseBuilder()

    type UserProfileUserBuilder() =
        member _.Yield(_: unit) : UserProfileUser =
            {
                Email = None
                FullName = None
                RealmName = Unchecked.defaultof<_>
                RealmDomain = None
                Roles = Unchecked.defaultof<_>
                Username = Unchecked.defaultof<_>
            }

        [<CustomOperation("email")>]
        member _.Email(state: UserProfileUser, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: UserProfileUser, value: CoreTypes.Name option) =
            { state with FullName = Some value }

        [<CustomOperation("realmName")>]
        member _.RealmName(state: UserProfileUser, value: CoreTypes.Name) =
            { state with RealmName = value }

        [<CustomOperation("realmDomain")>]
        member _.RealmDomain(state: UserProfileUser, value: CoreTypes.Name) =
            { state with RealmDomain = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: UserProfileUser, value: string list) =
            { state with Roles = value }

        [<CustomOperation("username")>]
        member _.Username(state: UserProfileUser, value: CoreTypes.Username) =
            { state with Username = value }

    let userProfileUser = UserProfileUserBuilder()

