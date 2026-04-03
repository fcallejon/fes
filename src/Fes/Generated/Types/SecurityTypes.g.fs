// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityTypes =

    type ReplicationAccess = {
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool option
    }

    type FieldSecurity = {
        [<System.Text.Json.Serialization.JsonPropertyName("except")>]
        Except: CoreTypes.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("grant")>]
        Grant: CoreTypes.Fields option
    }

    [<RequireQualifiedAccess>]
    type RoleTemplateInlineQuery =
        | String of string
        | QueryContainer of CoreTypes.QueryContainer

    type RoleTemplateScript = {
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: RoleTemplateInlineQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: CoreTypes.ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: Map<string, string> option
    }

    type RoleTemplateQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: RoleTemplateScript option
    }

    /// While creating or updating a role you can provide either a JSON structure or a string to the API.
    [<RequireQualifiedAccess>]
    type IndicesPrivilegesQuery =
        | String of string
        | QueryContainer of CoreTypes.QueryContainer
        | RoleTemplateQuery of RoleTemplateQuery

    type SearchAccess = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool option
    }

    type Access = {
        [<System.Text.Json.Serialization.JsonPropertyName("replication")>]
        Replication: ReplicationAccess list option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: SearchAccess list option
    }

    [<RequireQualifiedAccess>]
    type ApiKeyType =
        | Rest
        | CrossCluster

    [<RequireQualifiedAccess>]
    type ClusterPrivilege =
        | All
        | CancelTask
        | CreateSnapshot
        | CrossClusterReplication
        | CrossClusterSearch
        | DelegatePki
        | GrantApiKey
        | Manage
        | ManageApiKey
        | ManageAutoscaling
        | ManageBehavioralAnalytics
        | ManageCcr
        | ManageDataFrameTransforms
        | ManageDataStreamGlobalRetention
        | ManageEnrich
        | ManageEsql
        | ManageIlm
        | ManageIndexTemplates
        | ManageInference
        | ManageIngestPipelines
        | ManageLogstashPipelines
        | ManageMl
        | ManageOidc
        | ManageOwnApiKey
        | ManagePipeline
        | ManageRollup
        | ManageSaml
        | ManageSearchApplication
        | ManageSearchQueryRules
        | ManageSearchSynonyms
        | ManageSecurity
        | ManageServiceAccount
        | ManageSlm
        | ManageToken
        | ManageTransform
        | ManageUserProfile
        | ManageWatcher
        | Monitor
        | MonitorDataFrameTransforms
        | MonitorDataStreamGlobalRetention
        | MonitorEnrich
        | MonitorEsql
        | MonitorInference
        | MonitorMl
        | MonitorRollup
        | MonitorSnapshot
        | MonitorStats
        | MonitorTextStructure
        | MonitorTransform
        | MonitorWatcher
        | None
        | PostBehavioralAnalyticsEvent
        | ReadCcr
        | ReadFleetSecrets
        | ReadIlm
        | ReadPipeline
        | ReadSecurity
        | ReadSlm
        | TransportClient
        | WriteConnectorSecrets
        | WriteFleetSecrets
        | ReadProjectRouting
        | ManageProjectRouting
        | Custom of string

    [<RequireQualifiedAccess>]
    type IndexPrivilege =
        | All
        | AutoConfigure
        | Create
        | CreateDoc
        | CreateIndex
        | CreateView
        | CrossClusterReplication
        | CrossClusterReplicationInternal
        | Delete
        | DeleteIndex
        | DeleteView
        | Index
        | Maintenance
        | Manage
        | ManageDataStreamLifecycle
        | ManageFollowIndex
        | ManageIlm
        | ManageLeaderIndex
        | ManageView
        | Monitor
        | None
        | Read
        | ReadCrossCluster
        | ReadViewMetadata
        | ViewIndexMetadata
        | Write
        | Custom of string

    type IndicesPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool option
    }

    /// The subset of index level privileges that can be defined for remote clusters.
    type RemoteIndicesPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: CoreTypes.Names
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool option
    }

    [<RequireQualifiedAccess>]
    type RemoteClusterPrivilege =
        | MonitorEnrich
        | MonitorStats

    /// The subset of cluster level privileges that can be defined for remote clusters.
    type RemoteClusterPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: CoreTypes.Names
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: RemoteClusterPrivilege list
    }

    type ManageUserPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("applications")>]
        Applications: string list
    }

    type ApplicationGlobalUserPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("manage")>]
        Manage: ManageUserPrivileges
    }

    type GlobalPrivilege = {
        [<System.Text.Json.Serialization.JsonPropertyName("application")>]
        Application: ApplicationGlobalUserPrivileges
    }

    type ApplicationPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("application")>]
        Application: string
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: string list
        [<System.Text.Json.Serialization.JsonPropertyName("resources")>]
        Resources: string list
    }

    [<RequireQualifiedAccess>]
    type RestrictionWorkflow =
        | SearchApplicationQuery
        | Custom of string

    type Restriction = {
        [<System.Text.Json.Serialization.JsonPropertyName("workflows")>]
        Workflows: RestrictionWorkflow list
    }

    type RoleDescriptor = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: ClusterPrivilege list option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_indices")>]
        RemoteIndices: RemoteIndicesPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: RemoteClusterPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("global")>]
        Global: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("applications")>]
        Applications: ApplicationPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("run_as")>]
        RunAs: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("restriction")>]
        Restriction: Restriction option
        [<System.Text.Json.Serialization.JsonPropertyName("transient_metadata")>]
        TransientMetadata: Map<string, System.Text.Json.JsonElement> option
    }

    type ApiKey = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ApiKeyType
        [<System.Text.Json.Serialization.JsonPropertyName("creation")>]
        Creation: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("expiration")>]
        Expiration: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("invalidated")>]
        Invalidated: bool
        [<System.Text.Json.Serialization.JsonPropertyName("invalidation")>]
        Invalidation: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: CoreTypes.Username
        [<System.Text.Json.Serialization.JsonPropertyName("realm")>]
        Realm: string
        [<System.Text.Json.Serialization.JsonPropertyName("realm_type")>]
        RealmType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata
        [<System.Text.Json.Serialization.JsonPropertyName("role_descriptors")>]
        RoleDescriptors: Map<string, RoleDescriptor> option
        [<System.Text.Json.Serialization.JsonPropertyName("limited_by")>]
        LimitedBy: Map<string, RoleDescriptor> list option
        [<System.Text.Json.Serialization.JsonPropertyName("access")>]
        Access: Access option
        [<System.Text.Json.Serialization.JsonPropertyName("certificate_identity")>]
        CertificateIdentity: string option
        [<System.Text.Json.Serialization.JsonPropertyName("profile_uid")>]
        ProfileUid: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_sort")>]
        Sort: CoreTypes.SortResults option
    }

    [<RequireQualifiedAccess>]
    type ApiKeyManagedBy =
        | Cloud
        | Elasticsearch

    type BulkError = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<string, CoreTypes.ErrorCause>
    }

    type ClusterNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    type CreatedStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("created")>]
        Created: bool
    }

    [<RequireQualifiedAccess>]
    type GrantType =
        | Password
        | AccessToken

    type IndicesPrivilegesBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool option
    }

    type RolesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("dls")>]
        Dls: XpackUsage.SecurityRolesDls
    }

    type NodeSecurityStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: RolesStats
    }

    type RealmInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type RemoteUserIndicesPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("clusters")>]
        Clusters: string list
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity list option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery list option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool
    }

    type RoleDescriptorRead = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: ClusterPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesPrivileges list
        [<System.Text.Json.Serialization.JsonPropertyName("remote_indices")>]
        RemoteIndices: RemoteIndicesPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: RemoteClusterPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("global")>]
        Global: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("applications")>]
        Applications: ApplicationPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("run_as")>]
        RunAs: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("restriction")>]
        Restriction: Restriction option
        [<System.Text.Json.Serialization.JsonPropertyName("transient_metadata")>]
        TransientMetadata: Map<string, System.Text.Json.JsonElement> option
    }

    [<RequireQualifiedAccess>]
    type TemplateFormat =
        | String
        | Json

    type RoleTemplate = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: TemplateFormat option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: CoreTypes.Script
    }

    [<RequireQualifiedAccess>]
    type RoleMappingRule =
        | Any of RoleMappingRule list
        | All of RoleMappingRule list
        | Field of field: string * System.Text.Json.JsonElement
        | Except of RoleMappingRule

    type RoleMapping = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("role_templates")>]
        RoleTemplates: RoleTemplate list option
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: RoleMappingRule
    }

    type SecuritySettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndicesTypes.IndexSettings option
    }

    type UserProfileId = string

    type User = {
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("full_name")>]
        FullName: CoreTypes.Name option option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: CoreTypes.Username
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("profile_uid")>]
        ProfileUid: UserProfileId option
    }

    type UserIndicesPrivileges = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity list option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery list option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool
    }

    type UserIndicesPrivilegesBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_security")>]
        FieldSecurity: FieldSecurity list option
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: IndicesPrivilegesQuery list option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool
    }

    type UserProfileUser = {
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("full_name")>]
        FullName: CoreTypes.Name option option
        [<System.Text.Json.Serialization.JsonPropertyName("realm_name")>]
        RealmName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("realm_domain")>]
        RealmDomain: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: string list
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: CoreTypes.Username
    }

    type UserProfile = {
        [<System.Text.Json.Serialization.JsonPropertyName("uid")>]
        Uid: UserProfileId
        [<System.Text.Json.Serialization.JsonPropertyName("user")>]
        User: UserProfileUser
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("labels")>]
        Labels: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    type UserProfileHitMetadata = {
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: CoreTypes.SequenceNumber
    }

    type UserProfileWithMetadata = {
        [<System.Text.Json.Serialization.JsonPropertyName("last_synchronized")>]
        LastSynchronized: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("_doc")>]
        Doc: UserProfileHitMetadata
    }

