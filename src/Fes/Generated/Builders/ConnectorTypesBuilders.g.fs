// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module ConnectorTypesBuilders =

    type ConnectorBuilder() =
        member _.Yield(_: unit) : Connector =
            {
                ApiKeyId = None
                ApiKeySecretId = None
                Configuration = Unchecked.defaultof<_>
                CustomScheduling = Unchecked.defaultof<_>
                Deleted = Unchecked.defaultof<_>
                Description = None
                Error = None
                Features = None
                Filtering = Unchecked.defaultof<_>
                Id = None
                IndexName = None
                IsNative = Unchecked.defaultof<_>
                Language = None
                LastAccessControlSyncError = None
                LastAccessControlSyncScheduledAt = None
                LastAccessControlSyncStatus = None
                LastDeletedDocumentCount = None
                LastIncrementalSyncScheduledAt = None
                LastIndexedDocumentCount = None
                LastSeen = None
                LastSyncError = None
                LastSyncScheduledAt = None
                LastSyncStatus = None
                LastSynced = None
                Name = None
                Pipeline = None
                Scheduling = Unchecked.defaultof<_>
                ServiceType = None
                Status = Unchecked.defaultof<_>
                SyncCursor = None
                SyncNow = Unchecked.defaultof<_>
            }

        [<CustomOperation("apiKeyId")>]
        member _.ApiKeyId(state: Connector, value: string) =
            { state with ApiKeyId = Some value }

        [<CustomOperation("apiKeySecretId")>]
        member _.ApiKeySecretId(state: Connector, value: string) =
            { state with ApiKeySecretId = Some value }

        [<CustomOperation("configuration")>]
        member _.Configuration(state: Connector, value: ConnectorTypes.ConnectorConfiguration) =
            { state with Configuration = value }

        [<CustomOperation("customScheduling")>]
        member _.CustomScheduling(state: Connector, value: ConnectorTypes.ConnectorCustomScheduling) =
            { state with CustomScheduling = value }

        [<CustomOperation("deleted")>]
        member _.Deleted(state: Connector, value: bool) =
            { state with Deleted = value }

        [<CustomOperation("description")>]
        member _.Description(state: Connector, value: string) =
            { state with Description = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Connector, value: string option) =
            { state with Error = Some value }

        [<CustomOperation("features")>]
        member _.Features(state: Connector, value: ConnectorTypes.ConnectorFeatures) =
            { state with Features = Some value }

        [<CustomOperation("filtering")>]
        member _.Filtering(state: Connector, value: ConnectorTypes.FilteringConfig list) =
            { state with Filtering = value }

        [<CustomOperation("id")>]
        member _.Id(state: Connector, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: Connector, value: Types.IndexName option) =
            { state with IndexName = Some value }

        [<CustomOperation("isNative")>]
        member _.IsNative(state: Connector, value: bool) =
            { state with IsNative = value }

        [<CustomOperation("language")>]
        member _.Language(state: Connector, value: string) =
            { state with Language = Some value }

        [<CustomOperation("lastAccessControlSyncError")>]
        member _.LastAccessControlSyncError(state: Connector, value: string) =
            { state with LastAccessControlSyncError = Some value }

        [<CustomOperation("lastAccessControlSyncScheduledAt")>]
        member _.LastAccessControlSyncScheduledAt(state: Connector, value: Types.DateTime) =
            { state with LastAccessControlSyncScheduledAt = Some value }

        [<CustomOperation("lastAccessControlSyncStatus")>]
        member _.LastAccessControlSyncStatus(state: Connector, value: ConnectorTypes.SyncStatus) =
            { state with LastAccessControlSyncStatus = Some value }

        [<CustomOperation("lastDeletedDocumentCount")>]
        member _.LastDeletedDocumentCount(state: Connector, value: Types.Long) =
            { state with LastDeletedDocumentCount = Some value }

        [<CustomOperation("lastIncrementalSyncScheduledAt")>]
        member _.LastIncrementalSyncScheduledAt(state: Connector, value: Types.DateTime) =
            { state with LastIncrementalSyncScheduledAt = Some value }

        [<CustomOperation("lastIndexedDocumentCount")>]
        member _.LastIndexedDocumentCount(state: Connector, value: Types.Long) =
            { state with LastIndexedDocumentCount = Some value }

        [<CustomOperation("lastSeen")>]
        member _.LastSeen(state: Connector, value: Types.DateTime) =
            { state with LastSeen = Some value }

        [<CustomOperation("lastSyncError")>]
        member _.LastSyncError(state: Connector, value: string) =
            { state with LastSyncError = Some value }

        [<CustomOperation("lastSyncScheduledAt")>]
        member _.LastSyncScheduledAt(state: Connector, value: Types.DateTime) =
            { state with LastSyncScheduledAt = Some value }

        [<CustomOperation("lastSyncStatus")>]
        member _.LastSyncStatus(state: Connector, value: ConnectorTypes.SyncStatus) =
            { state with LastSyncStatus = Some value }

        [<CustomOperation("lastSynced")>]
        member _.LastSynced(state: Connector, value: Types.DateTime) =
            { state with LastSynced = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Connector, value: string) =
            { state with Name = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Connector, value: ConnectorTypes.IngestPipelineParams) =
            { state with Pipeline = Some value }

        [<CustomOperation("scheduling")>]
        member _.Scheduling(state: Connector, value: ConnectorTypes.SchedulingConfiguration) =
            { state with Scheduling = value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: Connector, value: string) =
            { state with ServiceType = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Connector, value: ConnectorTypes.ConnectorStatus) =
            { state with Status = value }

        [<CustomOperation("syncCursor")>]
        member _.SyncCursor(state: Connector, value: System.Text.Json.JsonElement) =
            { state with SyncCursor = Some value }

        [<CustomOperation("syncNow")>]
        member _.SyncNow(state: Connector, value: bool) =
            { state with SyncNow = value }

    let connector = ConnectorBuilder()

    type ConnectorConfigPropertiesBuilder() =
        member _.Yield(_: unit) : ConnectorConfigProperties =
            {
                Category = None
                DefaultValue = Unchecked.defaultof<_>
                DependsOn = Unchecked.defaultof<_>
                Display = Unchecked.defaultof<_>
                Label = Unchecked.defaultof<_>
                Options = Unchecked.defaultof<_>
                Order = None
                Placeholder = None
                Required = Unchecked.defaultof<_>
                Sensitive = Unchecked.defaultof<_>
                Tooltip = None
                Type = None
                UiRestrictions = None
                Validations = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("category")>]
        member _.Category(state: ConnectorConfigProperties, value: string) =
            { state with Category = Some value }

        [<CustomOperation("defaultValue")>]
        member _.DefaultValue(state: ConnectorConfigProperties, value: Types.ScalarValue) =
            { state with DefaultValue = value }

        [<CustomOperation("dependsOn")>]
        member _.DependsOn(state: ConnectorConfigProperties, value: ConnectorTypes.Dependency list) =
            { state with DependsOn = value }

        [<CustomOperation("display")>]
        member _.Display(state: ConnectorConfigProperties, value: ConnectorTypes.DisplayType) =
            { state with Display = value }

        [<CustomOperation("label")>]
        member _.Label(state: ConnectorConfigProperties, value: string) =
            { state with Label = value }

        [<CustomOperation("options")>]
        member _.Options(state: ConnectorConfigProperties, value: ConnectorTypes.SelectOption list) =
            { state with Options = value }

        [<CustomOperation("order")>]
        member _.Order(state: ConnectorConfigProperties, value: Types.Integer) =
            { state with Order = Some value }

        [<CustomOperation("placeholder")>]
        member _.Placeholder(state: ConnectorConfigProperties, value: string) =
            { state with Placeholder = Some value }

        [<CustomOperation("required")>]
        member _.Required(state: ConnectorConfigProperties, value: bool) =
            { state with Required = value }

        [<CustomOperation("sensitive")>]
        member _.Sensitive(state: ConnectorConfigProperties, value: bool) =
            { state with Sensitive = value }

        [<CustomOperation("tooltip")>]
        member _.Tooltip(state: ConnectorConfigProperties, value: string option) =
            { state with Tooltip = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ConnectorConfigProperties, value: ConnectorTypes.ConnectorFieldType) =
            { state with Type = Some value }

        [<CustomOperation("uiRestrictions")>]
        member _.UiRestrictions(state: ConnectorConfigProperties, value: string list) =
            { state with UiRestrictions = Some value }

        [<CustomOperation("validations")>]
        member _.Validations(state: ConnectorConfigProperties, value: ConnectorTypes.Validation list) =
            { state with Validations = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: ConnectorConfigProperties, value: System.Text.Json.JsonElement) =
            { state with Value = value }

    let connectorConfigProperties = ConnectorConfigPropertiesBuilder()

    type ConnectorFeaturesBuilder() =
        member _.Yield(_: unit) : ConnectorFeatures =
            {
                DocumentLevelSecurity = None
                IncrementalSync = None
                NativeConnectorApiKeys = None
                SyncRules = None
            }

        [<CustomOperation("documentLevelSecurity")>]
        member _.DocumentLevelSecurity(state: ConnectorFeatures, value: ConnectorTypes.FeatureEnabled) =
            { state with DocumentLevelSecurity = Some value }

        [<CustomOperation("incrementalSync")>]
        member _.IncrementalSync(state: ConnectorFeatures, value: ConnectorTypes.FeatureEnabled) =
            { state with IncrementalSync = Some value }

        [<CustomOperation("nativeConnectorApiKeys")>]
        member _.NativeConnectorApiKeys(state: ConnectorFeatures, value: ConnectorTypes.FeatureEnabled) =
            { state with NativeConnectorApiKeys = Some value }

        [<CustomOperation("syncRules")>]
        member _.SyncRules(state: ConnectorFeatures, value: ConnectorTypes.SyncRulesFeature) =
            { state with SyncRules = Some value }

    let connectorFeatures = ConnectorFeaturesBuilder()

    type ConnectorSyncJobBuilder() =
        member _.Yield(_: unit) : ConnectorSyncJob =
            {
                CancelationRequestedAt = None
                CanceledAt = None
                CompletedAt = None
                Connector = Unchecked.defaultof<_>
                CreatedAt = Unchecked.defaultof<_>
                DeletedDocumentCount = Unchecked.defaultof<_>
                Error = None
                Id = Unchecked.defaultof<_>
                IndexedDocumentCount = Unchecked.defaultof<_>
                IndexedDocumentVolume = Unchecked.defaultof<_>
                JobType = Unchecked.defaultof<_>
                LastSeen = None
                Metadata = Unchecked.defaultof<_>
                StartedAt = None
                Status = Unchecked.defaultof<_>
                TotalDocumentCount = Unchecked.defaultof<_>
                TriggerMethod = Unchecked.defaultof<_>
                WorkerHostname = None
            }

        [<CustomOperation("cancelationRequestedAt")>]
        member _.CancelationRequestedAt(state: ConnectorSyncJob, value: Types.DateTime) =
            { state with CancelationRequestedAt = Some value }

        [<CustomOperation("canceledAt")>]
        member _.CanceledAt(state: ConnectorSyncJob, value: Types.DateTime) =
            { state with CanceledAt = Some value }

        [<CustomOperation("completedAt")>]
        member _.CompletedAt(state: ConnectorSyncJob, value: Types.DateTime) =
            { state with CompletedAt = Some value }

        [<CustomOperation("connector")>]
        member _.Connector(state: ConnectorSyncJob, value: ConnectorTypes.SyncJobConnectorReference) =
            { state with Connector = value }

        [<CustomOperation("createdAt")>]
        member _.CreatedAt(state: ConnectorSyncJob, value: Types.DateTime) =
            { state with CreatedAt = value }

        [<CustomOperation("deletedDocumentCount")>]
        member _.DeletedDocumentCount(state: ConnectorSyncJob, value: Types.Long) =
            { state with DeletedDocumentCount = value }

        [<CustomOperation("error")>]
        member _.Error(state: ConnectorSyncJob, value: string) =
            { state with Error = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: ConnectorSyncJob, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("indexedDocumentCount")>]
        member _.IndexedDocumentCount(state: ConnectorSyncJob, value: Types.Long) =
            { state with IndexedDocumentCount = value }

        [<CustomOperation("indexedDocumentVolume")>]
        member _.IndexedDocumentVolume(state: ConnectorSyncJob, value: Types.Long) =
            { state with IndexedDocumentVolume = value }

        [<CustomOperation("jobType")>]
        member _.JobType(state: ConnectorSyncJob, value: ConnectorTypes.SyncJobType) =
            { state with JobType = value }

        [<CustomOperation("lastSeen")>]
        member _.LastSeen(state: ConnectorSyncJob, value: Types.DateTime) =
            { state with LastSeen = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: ConnectorSyncJob, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Metadata = value }

        [<CustomOperation("startedAt")>]
        member _.StartedAt(state: ConnectorSyncJob, value: Types.DateTime) =
            { state with StartedAt = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: ConnectorSyncJob, value: ConnectorTypes.SyncStatus) =
            { state with Status = value }

        [<CustomOperation("totalDocumentCount")>]
        member _.TotalDocumentCount(state: ConnectorSyncJob, value: Types.Long) =
            { state with TotalDocumentCount = value }

        [<CustomOperation("triggerMethod")>]
        member _.TriggerMethod(state: ConnectorSyncJob, value: ConnectorTypes.SyncJobTriggerMethod) =
            { state with TriggerMethod = value }

        [<CustomOperation("workerHostname")>]
        member _.WorkerHostname(state: ConnectorSyncJob, value: string) =
            { state with WorkerHostname = Some value }

    let connectorSyncJob = ConnectorSyncJobBuilder()

    type CustomSchedulingConfigurationOverridesBuilder() =
        member _.Yield(_: unit) : CustomSchedulingConfigurationOverrides =
            {
                MaxCrawlDepth = None
                SitemapDiscoveryDisabled = None
                DomainAllowlist = None
                SitemapUrls = None
                SeedUrls = None
            }

        [<CustomOperation("maxCrawlDepth")>]
        member _.MaxCrawlDepth(state: CustomSchedulingConfigurationOverrides, value: Types.Integer) =
            { state with MaxCrawlDepth = Some value }

        [<CustomOperation("sitemapDiscoveryDisabled")>]
        member _.SitemapDiscoveryDisabled(state: CustomSchedulingConfigurationOverrides, value: bool) =
            { state with SitemapDiscoveryDisabled = Some value }

        [<CustomOperation("domainAllowlist")>]
        member _.DomainAllowlist(state: CustomSchedulingConfigurationOverrides, value: string list) =
            { state with DomainAllowlist = Some value }

        [<CustomOperation("sitemapUrls")>]
        member _.SitemapUrls(state: CustomSchedulingConfigurationOverrides, value: string list) =
            { state with SitemapUrls = Some value }

        [<CustomOperation("seedUrls")>]
        member _.SeedUrls(state: CustomSchedulingConfigurationOverrides, value: string list) =
            { state with SeedUrls = Some value }

    let customSchedulingConfigurationOverrides = CustomSchedulingConfigurationOverridesBuilder()

    type FilteringAdvancedSnippetBuilder() =
        member _.Yield(_: unit) : FilteringAdvancedSnippet =
            {
                CreatedAt = None
                UpdatedAt = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("createdAt")>]
        member _.CreatedAt(state: FilteringAdvancedSnippet, value: Types.DateTime) =
            { state with CreatedAt = Some value }

        [<CustomOperation("updatedAt")>]
        member _.UpdatedAt(state: FilteringAdvancedSnippet, value: Types.DateTime) =
            { state with UpdatedAt = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: FilteringAdvancedSnippet, value: System.Text.Json.JsonElement) =
            { state with Value = value }

    let filteringAdvancedSnippet = FilteringAdvancedSnippetBuilder()

    type FilteringRuleBuilder() =
        member _.Yield(_: unit) : FilteringRule =
            {
                CreatedAt = None
                Field = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                Order = Unchecked.defaultof<_>
                Policy = Unchecked.defaultof<_>
                Rule = Unchecked.defaultof<_>
                UpdatedAt = None
                Value = Unchecked.defaultof<_>
            }

        [<CustomOperation("createdAt")>]
        member _.CreatedAt(state: FilteringRule, value: Types.DateTime) =
            { state with CreatedAt = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: FilteringRule, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("id")>]
        member _.Id(state: FilteringRule, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("order")>]
        member _.Order(state: FilteringRule, value: Types.Integer) =
            { state with Order = value }

        [<CustomOperation("policy")>]
        member _.Policy(state: FilteringRule, value: ConnectorTypes.FilteringPolicy) =
            { state with Policy = value }

        [<CustomOperation("rule")>]
        member _.Rule(state: FilteringRule, value: ConnectorTypes.FilteringRuleRule) =
            { state with Rule = value }

        [<CustomOperation("updatedAt")>]
        member _.UpdatedAt(state: FilteringRule, value: Types.DateTime) =
            { state with UpdatedAt = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: FilteringRule, value: string) =
            { state with Value = value }

    let filteringRule = FilteringRuleBuilder()

    type SchedulingConfigurationBuilder() =
        member _.Yield(_: unit) : SchedulingConfiguration =
            {
                AccessControl = None
                Full = None
                Incremental = None
            }

        [<CustomOperation("accessControl")>]
        member _.AccessControl(state: SchedulingConfiguration, value: ConnectorTypes.ConnectorScheduling) =
            { state with AccessControl = Some value }

        [<CustomOperation("full")>]
        member _.Full(state: SchedulingConfiguration, value: ConnectorTypes.ConnectorScheduling) =
            { state with Full = Some value }

        [<CustomOperation("incremental")>]
        member _.Incremental(state: SchedulingConfiguration, value: ConnectorTypes.ConnectorScheduling) =
            { state with Incremental = Some value }

    let schedulingConfiguration = SchedulingConfigurationBuilder()

    type SyncJobConnectorReferenceBuilder() =
        member _.Yield(_: unit) : SyncJobConnectorReference =
            {
                Configuration = Unchecked.defaultof<_>
                Filtering = Unchecked.defaultof<_>
                Id = Unchecked.defaultof<_>
                IndexName = Unchecked.defaultof<_>
                Language = None
                Pipeline = None
                ServiceType = Unchecked.defaultof<_>
                SyncCursor = None
            }

        [<CustomOperation("configuration")>]
        member _.Configuration(state: SyncJobConnectorReference, value: ConnectorTypes.ConnectorConfiguration) =
            { state with Configuration = value }

        [<CustomOperation("filtering")>]
        member _.Filtering(state: SyncJobConnectorReference, value: ConnectorTypes.FilteringRules) =
            { state with Filtering = value }

        [<CustomOperation("id")>]
        member _.Id(state: SyncJobConnectorReference, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: SyncJobConnectorReference, value: string) =
            { state with IndexName = value }

        [<CustomOperation("language")>]
        member _.Language(state: SyncJobConnectorReference, value: string) =
            { state with Language = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: SyncJobConnectorReference, value: ConnectorTypes.IngestPipelineParams) =
            { state with Pipeline = Some value }

        [<CustomOperation("serviceType")>]
        member _.ServiceType(state: SyncJobConnectorReference, value: string) =
            { state with ServiceType = value }

        [<CustomOperation("syncCursor")>]
        member _.SyncCursor(state: SyncJobConnectorReference, value: System.Text.Json.JsonElement) =
            { state with SyncCursor = Some value }

    let syncJobConnectorReference = SyncJobConnectorReferenceBuilder()

    type SyncRulesFeatureBuilder() =
        member _.Yield(_: unit) : SyncRulesFeature =
            {
                Advanced = None
                Basic = None
            }

        [<CustomOperation("advanced")>]
        member _.Advanced(state: SyncRulesFeature, value: ConnectorTypes.FeatureEnabled) =
            { state with Advanced = Some value }

        [<CustomOperation("basic")>]
        member _.Basic(state: SyncRulesFeature, value: ConnectorTypes.FeatureEnabled) =
            { state with Basic = Some value }

    let syncRulesFeature = SyncRulesFeatureBuilder()

