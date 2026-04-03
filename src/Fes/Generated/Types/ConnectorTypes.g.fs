// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ConnectorTypes =

    type Dependency = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.ScalarValue
    }

    [<RequireQualifiedAccess>]
    type DisplayType =
        | Textbox
        | Textarea
        | Numeric
        | Toggle
        | Dropdown

    type SelectOption = {
        [<System.Text.Json.Serialization.JsonPropertyName("label")>]
        Label: string
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.ScalarValue
    }

    [<RequireQualifiedAccess>]
    type ConnectorFieldType =
        | Str
        | Int
        | List
        | Bool

    type LessThanValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: CoreTypes.Double
    }

    type GreaterThanValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: CoreTypes.Double
    }

    type ListTypeValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: string
    }

    type IncludedInValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: CoreTypes.ScalarValue list
    }

    type RegexValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: string
    }

    [<RequireQualifiedAccess>]
    type Validation =
        | LessThanValidation of LessThanValidation
        | GreaterThanValidation of GreaterThanValidation
        | ListTypeValidation of ListTypeValidation
        | IncludedInValidation of IncludedInValidation
        | RegexValidation of RegexValidation

    type ConnectorConfigProperties = {
        [<System.Text.Json.Serialization.JsonPropertyName("category")>]
        Category: string option
        [<System.Text.Json.Serialization.JsonPropertyName("default_value")>]
        DefaultValue: CoreTypes.ScalarValue
        [<System.Text.Json.Serialization.JsonPropertyName("depends_on")>]
        DependsOn: Dependency list
        [<System.Text.Json.Serialization.JsonPropertyName("display")>]
        Display: DisplayType
        [<System.Text.Json.Serialization.JsonPropertyName("label")>]
        Label: string
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: SelectOption list
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("placeholder")>]
        Placeholder: string option
        [<System.Text.Json.Serialization.JsonPropertyName("required")>]
        Required: bool
        [<System.Text.Json.Serialization.JsonPropertyName("sensitive")>]
        Sensitive: bool
        [<System.Text.Json.Serialization.JsonPropertyName("tooltip")>]
        Tooltip: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ConnectorFieldType option
        [<System.Text.Json.Serialization.JsonPropertyName("ui_restrictions")>]
        UiRestrictions: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("validations")>]
        Validations: Validation list option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement
    }

    type ConnectorConfiguration = Map<string, ConnectorConfigProperties>

    type CustomSchedulingConfigurationOverrides = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_crawl_depth")>]
        MaxCrawlDepth: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("sitemap_discovery_disabled")>]
        SitemapDiscoveryDisabled: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("domain_allowlist")>]
        DomainAllowlist: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("sitemap_urls")>]
        SitemapUrls: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("seed_urls")>]
        SeedUrls: string list option
    }

    type CustomScheduling = {
        [<System.Text.Json.Serialization.JsonPropertyName("configuration_overrides")>]
        ConfigurationOverrides: CustomSchedulingConfigurationOverrides
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: string
        [<System.Text.Json.Serialization.JsonPropertyName("last_synced")>]
        LastSynced: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    type ConnectorCustomScheduling = Map<string, CustomScheduling>

    type FeatureEnabled = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type SyncRulesFeature = {
        [<System.Text.Json.Serialization.JsonPropertyName("advanced")>]
        Advanced: FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("basic")>]
        Basic: FeatureEnabled option
    }

    type ConnectorFeatures = {
        [<System.Text.Json.Serialization.JsonPropertyName("document_level_security")>]
        DocumentLevelSecurity: FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("incremental_sync")>]
        IncrementalSync: FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("native_connector_api_keys")>]
        NativeConnectorApiKeys: FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("sync_rules")>]
        SyncRules: SyncRulesFeature option
    }

    type FilteringAdvancedSnippet = {
        [<System.Text.Json.Serialization.JsonPropertyName("created_at")>]
        CreatedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("updated_at")>]
        UpdatedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement
    }

    [<RequireQualifiedAccess>]
    type FilteringPolicy =
        | Exclude
        | Include

    [<RequireQualifiedAccess>]
    type FilteringRuleRule =
        | Contains
        | EndsWith
        | Equals
        | Regex
        | StartsWith
        | Gt
        | Lt

    type FilteringRule = {
        [<System.Text.Json.Serialization.JsonPropertyName("created_at")>]
        CreatedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: FilteringPolicy
        [<System.Text.Json.Serialization.JsonPropertyName("rule")>]
        Rule: FilteringRuleRule
        [<System.Text.Json.Serialization.JsonPropertyName("updated_at")>]
        UpdatedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    type FilteringValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: CoreTypes.Id list
        [<System.Text.Json.Serialization.JsonPropertyName("messages")>]
        Messages: string list
    }

    [<RequireQualifiedAccess>]
    type FilteringValidationState =
        | Edited
        | Invalid
        | Valid

    type FilteringRulesValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("errors")>]
        Errors: FilteringValidation list
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: FilteringValidationState
    }

    type FilteringRules = {
        [<System.Text.Json.Serialization.JsonPropertyName("advanced_snippet")>]
        AdvancedSnippet: FilteringAdvancedSnippet
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: FilteringRule list
        [<System.Text.Json.Serialization.JsonPropertyName("validation")>]
        Validation: FilteringRulesValidation
    }

    type FilteringConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: FilteringRules
        [<System.Text.Json.Serialization.JsonPropertyName("domain")>]
        Domain: string option
        [<System.Text.Json.Serialization.JsonPropertyName("draft")>]
        Draft: FilteringRules
    }

    [<RequireQualifiedAccess>]
    type SyncStatus =
        | Canceling
        | Canceled
        | Completed
        | Error
        | InProgress
        | Pending
        | Suspended

    type IngestPipelineParams = {
        [<System.Text.Json.Serialization.JsonPropertyName("extract_binary_content")>]
        ExtractBinaryContent: bool
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("reduce_whitespace")>]
        ReduceWhitespace: bool
        [<System.Text.Json.Serialization.JsonPropertyName("run_ml_inference")>]
        RunMlInference: bool
    }

    type ConnectorScheduling = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: string
    }

    type SchedulingConfiguration = {
        [<System.Text.Json.Serialization.JsonPropertyName("access_control")>]
        AccessControl: ConnectorScheduling option
        [<System.Text.Json.Serialization.JsonPropertyName("full")>]
        Full: ConnectorScheduling option
        [<System.Text.Json.Serialization.JsonPropertyName("incremental")>]
        Incremental: ConnectorScheduling option
    }

    [<RequireQualifiedAccess>]
    type ConnectorStatus =
        | Created
        | NeedsConfiguration
        | Configured
        | Connected
        | Error

    type Connector = {
        [<System.Text.Json.Serialization.JsonPropertyName("api_key_id")>]
        ApiKeyId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("api_key_secret_id")>]
        ApiKeySecretId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("configuration")>]
        Configuration: ConnectorConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("custom_scheduling")>]
        CustomScheduling: ConnectorCustomScheduling
        [<System.Text.Json.Serialization.JsonPropertyName("deleted")>]
        Deleted: bool
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: ConnectorFeatures option
        [<System.Text.Json.Serialization.JsonPropertyName("filtering")>]
        Filtering: FilteringConfig list
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: CoreTypes.IndexName option option
        [<System.Text.Json.Serialization.JsonPropertyName("is_native")>]
        IsNative: bool
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_error")>]
        LastAccessControlSyncError: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_scheduled_at")>]
        LastAccessControlSyncScheduledAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_status")>]
        LastAccessControlSyncStatus: SyncStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("last_deleted_document_count")>]
        LastDeletedDocumentCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_incremental_sync_scheduled_at")>]
        LastIncrementalSyncScheduledAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_indexed_document_count")>]
        LastIndexedDocumentCount: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("last_seen")>]
        LastSeen: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_sync_error")>]
        LastSyncError: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_sync_scheduled_at")>]
        LastSyncScheduledAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_sync_status")>]
        LastSyncStatus: SyncStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("last_synced")>]
        LastSynced: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: IngestPipelineParams option
        [<System.Text.Json.Serialization.JsonPropertyName("scheduling")>]
        Scheduling: SchedulingConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("service_type")>]
        ServiceType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ConnectorStatus
        [<System.Text.Json.Serialization.JsonPropertyName("sync_cursor")>]
        SyncCursor: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("sync_now")>]
        SyncNow: bool
    }

    type SyncJobConnectorReference = {
        [<System.Text.Json.Serialization.JsonPropertyName("configuration")>]
        Configuration: ConnectorConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("filtering")>]
        Filtering: FilteringRules
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: string
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: IngestPipelineParams option
        [<System.Text.Json.Serialization.JsonPropertyName("service_type")>]
        ServiceType: string
        [<System.Text.Json.Serialization.JsonPropertyName("sync_cursor")>]
        SyncCursor: System.Text.Json.JsonElement option
    }

    [<RequireQualifiedAccess>]
    type SyncJobType =
        | Full
        | Incremental
        | AccessControl

    [<RequireQualifiedAccess>]
    type SyncJobTriggerMethod =
        | OnDemand
        | Scheduled

    type ConnectorSyncJob = {
        [<System.Text.Json.Serialization.JsonPropertyName("cancelation_requested_at")>]
        CancelationRequestedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("canceled_at")>]
        CanceledAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("completed_at")>]
        CompletedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("connector")>]
        Connector: SyncJobConnectorReference
        [<System.Text.Json.Serialization.JsonPropertyName("created_at")>]
        CreatedAt: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("deleted_document_count")>]
        DeletedDocumentCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_document_count")>]
        IndexedDocumentCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_document_volume")>]
        IndexedDocumentVolume: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: SyncJobType
        [<System.Text.Json.Serialization.JsonPropertyName("last_seen")>]
        LastSeen: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("started_at")>]
        StartedAt: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: SyncStatus
        [<System.Text.Json.Serialization.JsonPropertyName("total_document_count")>]
        TotalDocumentCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_method")>]
        TriggerMethod: SyncJobTriggerMethod
        [<System.Text.Json.Serialization.JsonPropertyName("worker_hostname")>]
        WorkerHostname: string option
    }

