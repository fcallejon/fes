// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ConnectorTypes =

    type Dependency = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.ScalarValue
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
        Value: Types.ScalarValue
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
        Constraint: Types.Double
    }

    type GreaterThanValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: Types.Double
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
        Constraint: Types.ScalarValue list
    }

    type RegexValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("constraint")>]
        Constraint: string
    }

    [<RequireQualifiedAccess>]
    type Validation =
        | LessThanValidation of ConnectorTypes.LessThanValidation
        | GreaterThanValidation of ConnectorTypes.GreaterThanValidation
        | ListTypeValidation of ConnectorTypes.ListTypeValidation
        | IncludedInValidation of ConnectorTypes.IncludedInValidation
        | RegexValidation of ConnectorTypes.RegexValidation

    type ConnectorConfigProperties = {
        [<System.Text.Json.Serialization.JsonPropertyName("category")>]
        Category: string option
        [<System.Text.Json.Serialization.JsonPropertyName("default_value")>]
        DefaultValue: Types.ScalarValue
        [<System.Text.Json.Serialization.JsonPropertyName("depends_on")>]
        DependsOn: ConnectorTypes.Dependency list
        [<System.Text.Json.Serialization.JsonPropertyName("display")>]
        Display: ConnectorTypes.DisplayType
        [<System.Text.Json.Serialization.JsonPropertyName("label")>]
        Label: string
        [<System.Text.Json.Serialization.JsonPropertyName("options")>]
        Options: ConnectorTypes.SelectOption list
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("placeholder")>]
        Placeholder: string option
        [<System.Text.Json.Serialization.JsonPropertyName("required")>]
        Required: bool
        [<System.Text.Json.Serialization.JsonPropertyName("sensitive")>]
        Sensitive: bool
        [<System.Text.Json.Serialization.JsonPropertyName("tooltip")>]
        Tooltip: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ConnectorTypes.ConnectorFieldType option
        [<System.Text.Json.Serialization.JsonPropertyName("ui_restrictions")>]
        UiRestrictions: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("validations")>]
        Validations: ConnectorTypes.Validation list option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement
    }

    type ConnectorConfiguration = Map<string, ConnectorTypes.ConnectorConfigProperties>

    type CustomSchedulingConfigurationOverrides = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_crawl_depth")>]
        MaxCrawlDepth: Types.Integer option
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
        ConfigurationOverrides: ConnectorTypes.CustomSchedulingConfigurationOverrides
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: string
        [<System.Text.Json.Serialization.JsonPropertyName("last_synced")>]
        LastSynced: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    type ConnectorCustomScheduling = Map<string, ConnectorTypes.CustomScheduling>

    type FeatureEnabled = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
    }

    type SyncRulesFeature = {
        [<System.Text.Json.Serialization.JsonPropertyName("advanced")>]
        Advanced: ConnectorTypes.FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("basic")>]
        Basic: ConnectorTypes.FeatureEnabled option
    }

    type ConnectorFeatures = {
        [<System.Text.Json.Serialization.JsonPropertyName("document_level_security")>]
        DocumentLevelSecurity: ConnectorTypes.FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("incremental_sync")>]
        IncrementalSync: ConnectorTypes.FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("native_connector_api_keys")>]
        NativeConnectorApiKeys: ConnectorTypes.FeatureEnabled option
        [<System.Text.Json.Serialization.JsonPropertyName("sync_rules")>]
        SyncRules: ConnectorTypes.SyncRulesFeature option
    }

    type FilteringAdvancedSnippet = {
        [<System.Text.Json.Serialization.JsonPropertyName("created_at")>]
        CreatedAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("updated_at")>]
        UpdatedAt: Types.DateTime option
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
        CreatedAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: ConnectorTypes.FilteringPolicy
        [<System.Text.Json.Serialization.JsonPropertyName("rule")>]
        Rule: ConnectorTypes.FilteringRuleRule
        [<System.Text.Json.Serialization.JsonPropertyName("updated_at")>]
        UpdatedAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    type FilteringValidation = {
        [<System.Text.Json.Serialization.JsonPropertyName("ids")>]
        Ids: Types.Id list
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
        Errors: ConnectorTypes.FilteringValidation list
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: ConnectorTypes.FilteringValidationState
    }

    type FilteringRules = {
        [<System.Text.Json.Serialization.JsonPropertyName("advanced_snippet")>]
        AdvancedSnippet: ConnectorTypes.FilteringAdvancedSnippet
        [<System.Text.Json.Serialization.JsonPropertyName("rules")>]
        Rules: ConnectorTypes.FilteringRule list
        [<System.Text.Json.Serialization.JsonPropertyName("validation")>]
        Validation: ConnectorTypes.FilteringRulesValidation
    }

    type FilteringConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: ConnectorTypes.FilteringRules
        [<System.Text.Json.Serialization.JsonPropertyName("domain")>]
        Domain: string option
        [<System.Text.Json.Serialization.JsonPropertyName("draft")>]
        Draft: ConnectorTypes.FilteringRules
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
        AccessControl: ConnectorTypes.ConnectorScheduling option
        [<System.Text.Json.Serialization.JsonPropertyName("full")>]
        Full: ConnectorTypes.ConnectorScheduling option
        [<System.Text.Json.Serialization.JsonPropertyName("incremental")>]
        Incremental: ConnectorTypes.ConnectorScheduling option
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
        Configuration: ConnectorTypes.ConnectorConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("custom_scheduling")>]
        CustomScheduling: ConnectorTypes.ConnectorCustomScheduling
        [<System.Text.Json.Serialization.JsonPropertyName("deleted")>]
        Deleted: bool
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: ConnectorTypes.ConnectorFeatures option
        [<System.Text.Json.Serialization.JsonPropertyName("filtering")>]
        Filtering: ConnectorTypes.FilteringConfig list
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: Types.IndexName option option
        [<System.Text.Json.Serialization.JsonPropertyName("is_native")>]
        IsNative: bool
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_error")>]
        LastAccessControlSyncError: string option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_scheduled_at")>]
        LastAccessControlSyncScheduledAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_access_control_sync_status")>]
        LastAccessControlSyncStatus: ConnectorTypes.SyncStatus option
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
        LastSyncStatus: ConnectorTypes.SyncStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("last_synced")>]
        LastSynced: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: ConnectorTypes.IngestPipelineParams option
        [<System.Text.Json.Serialization.JsonPropertyName("scheduling")>]
        Scheduling: ConnectorTypes.SchedulingConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("service_type")>]
        ServiceType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ConnectorTypes.ConnectorStatus
        [<System.Text.Json.Serialization.JsonPropertyName("sync_cursor")>]
        SyncCursor: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("sync_now")>]
        SyncNow: bool
    }

    type SyncJobConnectorReference = {
        [<System.Text.Json.Serialization.JsonPropertyName("configuration")>]
        Configuration: ConnectorTypes.ConnectorConfiguration
        [<System.Text.Json.Serialization.JsonPropertyName("filtering")>]
        Filtering: ConnectorTypes.FilteringRules
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: string
        [<System.Text.Json.Serialization.JsonPropertyName("language")>]
        Language: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: ConnectorTypes.IngestPipelineParams option
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
        CancelationRequestedAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("canceled_at")>]
        CanceledAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("completed_at")>]
        CompletedAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("connector")>]
        Connector: ConnectorTypes.SyncJobConnectorReference
        [<System.Text.Json.Serialization.JsonPropertyName("created_at")>]
        CreatedAt: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("deleted_document_count")>]
        DeletedDocumentCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: string option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_document_count")>]
        IndexedDocumentCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_document_volume")>]
        IndexedDocumentVolume: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("job_type")>]
        JobType: ConnectorTypes.SyncJobType
        [<System.Text.Json.Serialization.JsonPropertyName("last_seen")>]
        LastSeen: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("started_at")>]
        StartedAt: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ConnectorTypes.SyncStatus
        [<System.Text.Json.Serialization.JsonPropertyName("total_document_count")>]
        TotalDocumentCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_method")>]
        TriggerMethod: ConnectorTypes.SyncJobTriggerMethod
        [<System.Text.Json.Serialization.JsonPropertyName("worker_hostname")>]
        WorkerHostname: string option
    }

