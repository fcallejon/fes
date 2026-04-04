// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesTypesBuilders =

    type AliasBuilder() =
        member _.Yield(_: unit) : Types.Alias =
            {
                Filter = None
                IndexRouting = None
                IsHidden = None
                IsWriteIndex = None
                Routing = None
                SearchRouting = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.Alias, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: Types.Alias, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isHidden")>]
        member _.IsHidden(state: Types.Alias, value: bool) =
            { state with IsHidden = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: Types.Alias, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.Alias, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: Types.Alias, value: string) =
            { state with SearchRouting = Some value }

    let alias = AliasBuilder()

    type AliasDefinitionBuilder() =
        member _.Yield(_: unit) : Types.AliasDefinition =
            {
                Filter = None
                IndexRouting = None
                IsWriteIndex = None
                Routing = None
                SearchRouting = None
                IsHidden = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.AliasDefinition, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: Types.AliasDefinition, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: Types.AliasDefinition, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.AliasDefinition, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: Types.AliasDefinition, value: string) =
            { state with SearchRouting = Some value }

        [<CustomOperation("isHidden")>]
        member _.IsHidden(state: Types.AliasDefinition, value: bool) =
            { state with IsHidden = Some value }

    let aliasDefinition = AliasDefinitionBuilder()

    type DataStreamBuilder() =
        member _.Yield(_: unit) : Types.DataStream =
            {
                Meta = None
                AllowCustomRouting = None
                FailureStore = None
                Generation = Unchecked.defaultof<_>
                Hidden = Unchecked.defaultof<_>
                IlmPolicy = None
                NextGenerationManagedBy = Unchecked.defaultof<_>
                PreferIlm = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                Lifecycle = None
                Name = Unchecked.defaultof<_>
                Replicated = None
                RolloverOnWrite = Unchecked.defaultof<_>
                Settings = Unchecked.defaultof<_>
                Mappings = None
                Status = Unchecked.defaultof<_>
                System = None
                Template = Unchecked.defaultof<_>
                TimestampField = Unchecked.defaultof<_>
                IndexMode = None
            }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.DataStream, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowCustomRouting")>]
        member _.AllowCustomRouting(state: Types.DataStream, value: bool) =
            { state with AllowCustomRouting = Some value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: Types.DataStream, value: Types.FailureStore) =
            { state with FailureStore = Some value }

        [<CustomOperation("generation")>]
        member _.Generation(state: Types.DataStream, value: Types.Integer) =
            { state with Generation = value }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: Types.DataStream, value: bool) =
            { state with Hidden = value }

        [<CustomOperation("ilmPolicy")>]
        member _.IlmPolicy(state: Types.DataStream, value: Types.Name) =
            { state with IlmPolicy = Some value }

        [<CustomOperation("nextGenerationManagedBy")>]
        member _.NextGenerationManagedBy(state: Types.DataStream, value: Types.ManagedBy) =
            { state with NextGenerationManagedBy = value }

        [<CustomOperation("preferIlm")>]
        member _.PreferIlm(state: Types.DataStream, value: bool) =
            { state with PreferIlm = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.DataStream, value: Types.DataStreamIndex list) =
            { state with Indices = value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.DataStream, value: Types.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.DataStream, value: Types.DataStreamName) =
            { state with Name = value }

        [<CustomOperation("replicated")>]
        member _.Replicated(state: Types.DataStream, value: bool) =
            { state with Replicated = Some value }

        [<CustomOperation("rolloverOnWrite")>]
        member _.RolloverOnWrite(state: Types.DataStream, value: bool) =
            { state with RolloverOnWrite = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.DataStream, value: Types.IndexSettings) =
            { state with Settings = value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.DataStream, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.DataStream, value: Types.HealthStatus) =
            { state with Status = value }

        [<CustomOperation("system")>]
        member _.System(state: Types.DataStream, value: bool) =
            { state with System = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: Types.DataStream, value: Types.Name) =
            { state with Template = value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: Types.DataStream, value: Types.DataStreamTimestampField) =
            { state with TimestampField = value }

        [<CustomOperation("indexMode")>]
        member _.IndexMode(state: Types.DataStream, value: Types.IndexMode) =
            { state with IndexMode = Some value }

    let dataStream = DataStreamBuilder()

    type DataStreamFailureStoreBuilder() =
        member _.Yield(_: unit) : Types.DataStreamFailureStore =
            {
                Enabled = None
                Lifecycle = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.DataStreamFailureStore, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.DataStreamFailureStore, value: Types.FailureStoreLifecycle) =
            { state with Lifecycle = Some value }

    let dataStreamFailureStore = DataStreamFailureStoreBuilder()

    type DataStreamFailureStoreTemplateBuilder() =
        member _.Yield(_: unit) : Types.DataStreamFailureStoreTemplate =
            {
                Enabled = None
                Lifecycle = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.DataStreamFailureStoreTemplate, value: bool option) =
            { state with Enabled = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.DataStreamFailureStoreTemplate, value: Types.FailureStoreLifecycleTemplate option) =
            { state with Lifecycle = Some value }

    let dataStreamFailureStoreTemplate = DataStreamFailureStoreTemplateBuilder()

    type DataStreamIndexBuilder() =
        member _.Yield(_: unit) : Types.DataStreamIndex =
            {
                IndexName = Unchecked.defaultof<_>
                IndexUuid = Unchecked.defaultof<_>
                IlmPolicy = None
                ManagedBy = None
                PreferIlm = None
                IndexMode = None
            }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: Types.DataStreamIndex, value: Types.IndexName) =
            { state with IndexName = value }

        [<CustomOperation("indexUuid")>]
        member _.IndexUuid(state: Types.DataStreamIndex, value: Types.Uuid) =
            { state with IndexUuid = value }

        [<CustomOperation("ilmPolicy")>]
        member _.IlmPolicy(state: Types.DataStreamIndex, value: Types.Name) =
            { state with IlmPolicy = Some value }

        [<CustomOperation("managedBy")>]
        member _.ManagedBy(state: Types.DataStreamIndex, value: Types.ManagedBy) =
            { state with ManagedBy = Some value }

        [<CustomOperation("preferIlm")>]
        member _.PreferIlm(state: Types.DataStreamIndex, value: bool) =
            { state with PreferIlm = Some value }

        [<CustomOperation("indexMode")>]
        member _.IndexMode(state: Types.DataStreamIndex, value: Types.IndexMode) =
            { state with IndexMode = Some value }

    let dataStreamIndex = DataStreamIndexBuilder()

    type DataStreamLifecycleBuilder() =
        member _.Yield(_: unit) : Types.DataStreamLifecycle =
            {
                DataRetention = None
                Downsampling = None
                DownsamplingMethod = None
                Enabled = None
                FrozenAfter = None
            }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: Types.DataStreamLifecycle, value: Types.Duration) =
            { state with DataRetention = Some value }

        [<CustomOperation("downsampling")>]
        member _.Downsampling(state: Types.DataStreamLifecycle, value: Types.DownsamplingRound list) =
            { state with Downsampling = Some value }

        [<CustomOperation("downsamplingMethod")>]
        member _.DownsamplingMethod(state: Types.DataStreamLifecycle, value: Types.SamplingMethod) =
            { state with DownsamplingMethod = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.DataStreamLifecycle, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("frozenAfter")>]
        member _.FrozenAfter(state: Types.DataStreamLifecycle, value: Types.Duration) =
            { state with FrozenAfter = Some value }

    let dataStreamLifecycle = DataStreamLifecycleBuilder()

    type DataStreamLifecycleRolloverConditionsBuilder() =
        member _.Yield(_: unit) : Types.DataStreamLifecycleRolloverConditions =
            {
                MinAge = None
                MaxAge = None
                MinDocs = None
                MaxDocs = None
                MinSize = None
                MaxSize = None
                MinPrimaryShardSize = None
                MaxPrimaryShardSize = None
                MinPrimaryShardDocs = None
                MaxPrimaryShardDocs = None
            }

        [<CustomOperation("minAge")>]
        member _.MinAge(state: Types.DataStreamLifecycleRolloverConditions, value: Types.Duration) =
            { state with MinAge = Some value }

        [<CustomOperation("maxAge")>]
        member _.MaxAge(state: Types.DataStreamLifecycleRolloverConditions, value: string) =
            { state with MaxAge = Some value }

        [<CustomOperation("minDocs")>]
        member _.MinDocs(state: Types.DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MinDocs = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: Types.DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("minSize")>]
        member _.MinSize(state: Types.DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MinSize = Some value }

        [<CustomOperation("maxSize")>]
        member _.MaxSize(state: Types.DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MaxSize = Some value }

        [<CustomOperation("minPrimaryShardSize")>]
        member _.MinPrimaryShardSize(state: Types.DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MinPrimaryShardSize = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: Types.DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("minPrimaryShardDocs")>]
        member _.MinPrimaryShardDocs(state: Types.DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MinPrimaryShardDocs = Some value }

        [<CustomOperation("maxPrimaryShardDocs")>]
        member _.MaxPrimaryShardDocs(state: Types.DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MaxPrimaryShardDocs = Some value }

    let dataStreamLifecycleRolloverConditions = DataStreamLifecycleRolloverConditionsBuilder()

    type DataStreamVisibilityBuilder() =
        member _.Yield(_: unit) : Types.DataStreamVisibility =
            {
                Hidden = None
                AllowCustomRouting = None
                FailureStore = None
            }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: Types.DataStreamVisibility, value: bool) =
            { state with Hidden = Some value }

        [<CustomOperation("allowCustomRouting")>]
        member _.AllowCustomRouting(state: Types.DataStreamVisibility, value: bool) =
            { state with AllowCustomRouting = Some value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: Types.DataStreamVisibility, value: bool) =
            { state with FailureStore = Some value }

    let dataStreamVisibility = DataStreamVisibilityBuilder()

    type FailureStoreLifecycleBuilder() =
        member _.Yield(_: unit) : Types.FailureStoreLifecycle =
            {
                DataRetention = None
                Enabled = None
            }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: Types.FailureStoreLifecycle, value: Types.Duration) =
            { state with DataRetention = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.FailureStoreLifecycle, value: bool) =
            { state with Enabled = Some value }

    let failureStoreLifecycle = FailureStoreLifecycleBuilder()

    type FailureStoreLifecycleTemplateBuilder() =
        member _.Yield(_: unit) : Types.FailureStoreLifecycleTemplate =
            {
                DataRetention = None
                Enabled = None
            }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: Types.FailureStoreLifecycleTemplate, value: Types.Duration option) =
            { state with DataRetention = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.FailureStoreLifecycleTemplate, value: bool) =
            { state with Enabled = Some value }

    let failureStoreLifecycleTemplate = FailureStoreLifecycleTemplateBuilder()

    type IndexRoutingBuilder() =
        member _.Yield(_: unit) : Types.IndexRouting =
            {
                Allocation = None
                Rebalance = None
            }

        [<CustomOperation("allocation")>]
        member _.Allocation(state: Types.IndexRouting, value: Types.IndexRoutingAllocation) =
            { state with Allocation = Some value }

        [<CustomOperation("rebalance")>]
        member _.Rebalance(state: Types.IndexRouting, value: Types.IndexRoutingRebalance) =
            { state with Rebalance = Some value }

    let indexRouting = IndexRoutingBuilder()

    type IndexRoutingAllocationBuilder() =
        member _.Yield(_: unit) : Types.IndexRoutingAllocation =
            {
                Enable = None
                Include = None
                InitialRecovery = None
                Disk = None
            }

        [<CustomOperation("enable")>]
        member _.Enable(state: Types.IndexRoutingAllocation, value: Types.IndexRoutingAllocationOptions) =
            { state with Enable = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: Types.IndexRoutingAllocation, value: Types.IndexRoutingAllocationInclude) =
            { state with Include = Some value }

        [<CustomOperation("initialRecovery")>]
        member _.InitialRecovery(state: Types.IndexRoutingAllocation, value: Types.IndexRoutingAllocationInitialRecovery) =
            { state with InitialRecovery = Some value }

        [<CustomOperation("disk")>]
        member _.Disk(state: Types.IndexRoutingAllocation, value: Types.IndexRoutingAllocationDisk) =
            { state with Disk = Some value }

    let indexRoutingAllocation = IndexRoutingAllocationBuilder()

    type IndexRoutingAllocationIncludeBuilder() =
        member _.Yield(_: unit) : Types.IndexRoutingAllocationInclude =
            {
                TierPreference = None
                Id = None
            }

        [<CustomOperation("tierPreference")>]
        member _.TierPreference(state: Types.IndexRoutingAllocationInclude, value: string) =
            { state with TierPreference = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.IndexRoutingAllocationInclude, value: Types.Id) =
            { state with Id = Some value }

    let indexRoutingAllocationInclude = IndexRoutingAllocationIncludeBuilder()

    type IndexSegmentSortBuilder() =
        member _.Yield(_: unit) : Types.IndexSegmentSort =
            {
                Field = None
                Order = None
                Mode = None
                Missing = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.IndexSegmentSort, value: Types.Fields) =
            { state with Field = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.IndexSegmentSort, value: System.Text.Json.JsonElement) =
            { state with Order = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.IndexSegmentSort, value: System.Text.Json.JsonElement) =
            { state with Mode = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.IndexSegmentSort, value: System.Text.Json.JsonElement) =
            { state with Missing = Some value }

    let indexSegmentSort = IndexSegmentSortBuilder()

    type IndexSettingBlocksBuilder() =
        member _.Yield(_: unit) : Types.IndexSettingBlocks =
            {
                ReadOnly = None
                ReadOnlyAllowDelete = None
                Read = None
                Write = None
                Metadata = None
            }

        [<CustomOperation("readOnly")>]
        member _.ReadOnly(state: Types.IndexSettingBlocks, value: Types.Stringified<bool>) =
            { state with ReadOnly = Some value }

        [<CustomOperation("readOnlyAllowDelete")>]
        member _.ReadOnlyAllowDelete(state: Types.IndexSettingBlocks, value: Types.Stringified<bool>) =
            { state with ReadOnlyAllowDelete = Some value }

        [<CustomOperation("read")>]
        member _.Read(state: Types.IndexSettingBlocks, value: Types.Stringified<bool>) =
            { state with Read = Some value }

        [<CustomOperation("write")>]
        member _.Write(state: Types.IndexSettingBlocks, value: Types.Stringified<bool>) =
            { state with Write = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.IndexSettingBlocks, value: Types.Stringified<bool>) =
            { state with Metadata = Some value }

    let indexSettingBlocks = IndexSettingBlocksBuilder()

    type IndexSettingsBuilder() =
        member _.Yield(_: unit) : Types.IndexSettings =
            {
                Index = None
                Mode = None
                RoutingPath = None
                SoftDeletes = None
                Sort = None
                NumberOfShards = None
                NumberOfReplicas = None
                NumberOfRoutingShards = None
                CheckOnStartup = None
                Codec = None
                RoutingPartitionSize = None
                LoadFixedBitsetFiltersEagerly = None
                Hidden = None
                AutoExpandReplicas = None
                Merge = None
                Search = None
                RefreshInterval = None
                MaxResultWindow = None
                MaxInnerResultWindow = None
                MaxRescoreWindow = None
                MaxDocvalueFieldsSearch = None
                MaxScriptFields = None
                MaxNgramDiff = None
                MaxShingleDiff = None
                Blocks = None
                MaxRefreshListeners = None
                Analyze = None
                Highlight = None
                MaxTermsCount = None
                MaxRegexLength = None
                Routing = None
                GcDeletes = None
                DefaultPipeline = None
                FinalPipeline = None
                Lifecycle = None
                ProvidedName = None
                CreationDate = None
                CreationDateString = None
                Uuid = None
                Version = None
                VerifiedBeforeClose = None
                Format = None
                MaxSlicesPerScroll = None
                Translog = None
                QueryString = None
                Priority = None
                TopMetricsMaxSize = None
                Analysis = None
                Settings = None
                TimeSeries = None
                Queries = None
                Similarity = None
                Mapping = None
                IndexingSlowlog = None
                IndexingPressure = None
                Store = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IndexSettings, value: Types.IndexSettings) =
            { state with Index = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.IndexSettings, value: string) =
            { state with Mode = Some value }

        [<CustomOperation("routingPath")>]
        member _.RoutingPath(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with RoutingPath = Some value }

        [<CustomOperation("softDeletes")>]
        member _.SoftDeletes(state: Types.IndexSettings, value: Types.SoftDeletes) =
            { state with SoftDeletes = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.IndexSettings, value: Types.IndexSegmentSort) =
            { state with Sort = Some value }

        [<CustomOperation("numberOfShards")>]
        member _.NumberOfShards(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with NumberOfShards = Some value }

        [<CustomOperation("numberOfReplicas")>]
        member _.NumberOfReplicas(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with NumberOfReplicas = Some value }

        [<CustomOperation("numberOfRoutingShards")>]
        member _.NumberOfRoutingShards(state: Types.IndexSettings, value: Types.Integer) =
            { state with NumberOfRoutingShards = Some value }

        [<CustomOperation("checkOnStartup")>]
        member _.CheckOnStartup(state: Types.IndexSettings, value: Types.IndexCheckOnStartup) =
            { state with CheckOnStartup = Some value }

        [<CustomOperation("codec")>]
        member _.Codec(state: Types.IndexSettings, value: string) =
            { state with Codec = Some value }

        [<CustomOperation("routingPartitionSize")>]
        member _.RoutingPartitionSize(state: Types.IndexSettings, value: Types.Stringified<Types.Integer>) =
            { state with RoutingPartitionSize = Some value }

        [<CustomOperation("loadFixedBitsetFiltersEagerly")>]
        member _.LoadFixedBitsetFiltersEagerly(state: Types.IndexSettings, value: bool) =
            { state with LoadFixedBitsetFiltersEagerly = Some value }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with Hidden = Some value }

        [<CustomOperation("autoExpandReplicas")>]
        member _.AutoExpandReplicas(state: Types.IndexSettings, value: Types.WithNullValue<string>) =
            { state with AutoExpandReplicas = Some value }

        [<CustomOperation("merge")>]
        member _.Merge(state: Types.IndexSettings, value: Types.Merge) =
            { state with Merge = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Types.IndexSettings, value: Types.SettingsSearch) =
            { state with Search = Some value }

        [<CustomOperation("refreshInterval")>]
        member _.RefreshInterval(state: Types.IndexSettings, value: Types.Duration) =
            { state with RefreshInterval = Some value }

        [<CustomOperation("maxResultWindow")>]
        member _.MaxResultWindow(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxResultWindow = Some value }

        [<CustomOperation("maxInnerResultWindow")>]
        member _.MaxInnerResultWindow(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxInnerResultWindow = Some value }

        [<CustomOperation("maxRescoreWindow")>]
        member _.MaxRescoreWindow(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxRescoreWindow = Some value }

        [<CustomOperation("maxDocvalueFieldsSearch")>]
        member _.MaxDocvalueFieldsSearch(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxDocvalueFieldsSearch = Some value }

        [<CustomOperation("maxScriptFields")>]
        member _.MaxScriptFields(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxScriptFields = Some value }

        [<CustomOperation("maxNgramDiff")>]
        member _.MaxNgramDiff(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxNgramDiff = Some value }

        [<CustomOperation("maxShingleDiff")>]
        member _.MaxShingleDiff(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxShingleDiff = Some value }

        [<CustomOperation("blocks")>]
        member _.Blocks(state: Types.IndexSettings, value: Types.IndexSettingBlocks) =
            { state with Blocks = Some value }

        [<CustomOperation("maxRefreshListeners")>]
        member _.MaxRefreshListeners(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxRefreshListeners = Some value }

        [<CustomOperation("analyze")>]
        member _.Analyze(state: Types.IndexSettings, value: Types.SettingsAnalyze) =
            { state with Analyze = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: Types.IndexSettings, value: Types.SettingsHighlight) =
            { state with Highlight = Some value }

        [<CustomOperation("maxTermsCount")>]
        member _.MaxTermsCount(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxTermsCount = Some value }

        [<CustomOperation("maxRegexLength")>]
        member _.MaxRegexLength(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxRegexLength = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.IndexSettings, value: Types.IndexRouting) =
            { state with Routing = Some value }

        [<CustomOperation("gcDeletes")>]
        member _.GcDeletes(state: Types.IndexSettings, value: Types.Duration) =
            { state with GcDeletes = Some value }

        [<CustomOperation("defaultPipeline")>]
        member _.DefaultPipeline(state: Types.IndexSettings, value: Types.PipelineName) =
            { state with DefaultPipeline = Some value }

        [<CustomOperation("finalPipeline")>]
        member _.FinalPipeline(state: Types.IndexSettings, value: Types.PipelineName) =
            { state with FinalPipeline = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.IndexSettings, value: Types.IndexSettingsLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("providedName")>]
        member _.ProvidedName(state: Types.IndexSettings, value: Types.Name) =
            { state with ProvidedName = Some value }

        [<CustomOperation("creationDate")>]
        member _.CreationDate(state: Types.IndexSettings, value: Types.Stringified<Types.EpochTime<Types.UnitMillis>>) =
            { state with CreationDate = Some value }

        [<CustomOperation("creationDateString")>]
        member _.CreationDateString(state: Types.IndexSettings, value: Types.DateTime) =
            { state with CreationDateString = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: Types.IndexSettings, value: Types.Uuid) =
            { state with Uuid = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.IndexSettings, value: Types.IndexVersioning) =
            { state with Version = Some value }

        [<CustomOperation("verifiedBeforeClose")>]
        member _.VerifiedBeforeClose(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with VerifiedBeforeClose = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with Format = Some value }

        [<CustomOperation("maxSlicesPerScroll")>]
        member _.MaxSlicesPerScroll(state: Types.IndexSettings, value: Types.Integer) =
            { state with MaxSlicesPerScroll = Some value }

        [<CustomOperation("translog")>]
        member _.Translog(state: Types.IndexSettings, value: Types.Translog) =
            { state with Translog = Some value }

        [<CustomOperation("queryString")>]
        member _.QueryString(state: Types.IndexSettings, value: Types.SettingsQueryString) =
            { state with QueryString = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.IndexSettings, value: System.Text.Json.JsonElement) =
            { state with Priority = Some value }

        [<CustomOperation("topMetricsMaxSize")>]
        member _.TopMetricsMaxSize(state: Types.IndexSettings, value: Types.Integer) =
            { state with TopMetricsMaxSize = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: Types.IndexSettings, value: Types.IndexSettingsAnalysis) =
            { state with Analysis = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.IndexSettings, value: Types.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("timeSeries")>]
        member _.TimeSeries(state: Types.IndexSettings, value: Types.IndexSettingsTimeSeries) =
            { state with TimeSeries = Some value }

        [<CustomOperation("queries")>]
        member _.Queries(state: Types.IndexSettings, value: Types.Queries) =
            { state with Queries = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.IndexSettings, value: Map<string, Types.SettingsSimilarity>) =
            { state with Similarity = Some value }

        [<CustomOperation("mapping")>]
        member _.Mapping(state: Types.IndexSettings, value: Types.MappingLimitSettings) =
            { state with Mapping = Some value }

        [<CustomOperation("indexingSlowlog")>]
        member _.IndexingSlowlog(state: Types.IndexSettings, value: Types.IndexingSlowlogSettings) =
            { state with IndexingSlowlog = Some value }

        [<CustomOperation("indexingPressure")>]
        member _.IndexingPressure(state: Types.IndexSettings, value: Types.IndicesTypesIndexingPressure) =
            { state with IndexingPressure = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IndexSettings, value: Types.Storage) =
            { state with Store = Some value }

    let indexSettings = IndexSettingsBuilder()

    type IndexSettingsAnalysisBuilder() =
        member _.Yield(_: unit) : Types.IndexSettingsAnalysis =
            {
                Analyzer = None
                CharFilter = None
                Filter = None
                Normalizer = None
                Tokenizer = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: Types.IndexSettingsAnalysis, value: Map<string, Types.Analyzer>) =
            { state with Analyzer = Some value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: Types.IndexSettingsAnalysis, value: Map<string, Types.CharFilter>) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.IndexSettingsAnalysis, value: Map<string, Types.TokenFilter>) =
            { state with Filter = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: Types.IndexSettingsAnalysis, value: Map<string, Types.Normalizer>) =
            { state with Normalizer = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: Types.IndexSettingsAnalysis, value: Map<string, Types.Tokenizer>) =
            { state with Tokenizer = Some value }

    let indexSettingsAnalysis = IndexSettingsAnalysisBuilder()

    type IndexSettingsLifecycleBuilder() =
        member _.Yield(_: unit) : Types.IndexSettingsLifecycle =
            {
                Name = None
                IndexingComplete = None
                OriginationDate = None
                ParseOriginationDate = None
                Step = None
                RolloverAlias = None
                PreferIlm = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.IndexSettingsLifecycle, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("indexingComplete")>]
        member _.IndexingComplete(state: Types.IndexSettingsLifecycle, value: Types.Stringified<bool>) =
            { state with IndexingComplete = Some value }

        [<CustomOperation("originationDate")>]
        member _.OriginationDate(state: Types.IndexSettingsLifecycle, value: Types.Long) =
            { state with OriginationDate = Some value }

        [<CustomOperation("parseOriginationDate")>]
        member _.ParseOriginationDate(state: Types.IndexSettingsLifecycle, value: bool) =
            { state with ParseOriginationDate = Some value }

        [<CustomOperation("step")>]
        member _.Step(state: Types.IndexSettingsLifecycle, value: Types.IndexSettingsLifecycleStep) =
            { state with Step = Some value }

        [<CustomOperation("rolloverAlias")>]
        member _.RolloverAlias(state: Types.IndexSettingsLifecycle, value: string) =
            { state with RolloverAlias = Some value }

        [<CustomOperation("preferIlm")>]
        member _.PreferIlm(state: Types.IndexSettingsLifecycle, value: System.Text.Json.JsonElement) =
            { state with PreferIlm = Some value }

    let indexSettingsLifecycle = IndexSettingsLifecycleBuilder()

    type IndexSettingsTimeSeriesBuilder() =
        member _.Yield(_: unit) : Types.IndexSettingsTimeSeries =
            {
                EndTime = None
                StartTime = None
            }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: Types.IndexSettingsTimeSeries, value: Types.DateTime) =
            { state with EndTime = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.IndexSettingsTimeSeries, value: Types.DateTime) =
            { state with StartTime = Some value }

    let indexSettingsTimeSeries = IndexSettingsTimeSeriesBuilder()

    type IndexStateBuilder() =
        member _.Yield(_: unit) : Types.IndexState =
            {
                Aliases = None
                Mappings = None
                Settings = None
                Defaults = None
                DataStream = None
                Lifecycle = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.IndexState, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.IndexState, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.IndexState, value: Types.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("defaults")>]
        member _.Defaults(state: Types.IndexState, value: Types.IndexSettings) =
            { state with Defaults = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: Types.IndexState, value: Types.DataStreamName) =
            { state with DataStream = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.IndexState, value: Types.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

    let indexState = IndexStateBuilder()

    type IndexTemplateBuilder() =
        member _.Yield(_: unit) : Types.IndexTemplate =
            {
                IndexPatterns = Unchecked.defaultof<_>
                ComposedOf = Unchecked.defaultof<_>
                Template = None
                Version = None
                Priority = None
                Meta = None
                AllowAutoCreate = None
                DataStream = None
                Deprecated = None
                IgnoreMissingComponentTemplates = None
                CreatedDate = None
                CreatedDateMillis = None
                ModifiedDate = None
                ModifiedDateMillis = None
            }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: Types.IndexTemplate, value: Types.Names) =
            { state with IndexPatterns = value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: Types.IndexTemplate, value: Types.Name list) =
            { state with ComposedOf = value }

        [<CustomOperation("template")>]
        member _.Template(state: Types.IndexTemplate, value: Types.IndexTemplateSummary) =
            { state with Template = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.IndexTemplate, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.IndexTemplate, value: Types.Long) =
            { state with Priority = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IndexTemplate, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowAutoCreate")>]
        member _.AllowAutoCreate(state: Types.IndexTemplate, value: bool) =
            { state with AllowAutoCreate = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: Types.IndexTemplate, value: Types.IndexTemplateDataStreamConfiguration) =
            { state with DataStream = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: Types.IndexTemplate, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("ignoreMissingComponentTemplates")>]
        member _.IgnoreMissingComponentTemplates(state: Types.IndexTemplate, value: Types.Names) =
            { state with IgnoreMissingComponentTemplates = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: Types.IndexTemplate, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: Types.IndexTemplate, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.IndexTemplate, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.IndexTemplate, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let indexTemplate = IndexTemplateBuilder()

    type IndexTemplateDataStreamConfigurationBuilder() =
        member _.Yield(_: unit) : Types.IndexTemplateDataStreamConfiguration =
            {
                Hidden = None
                AllowCustomRouting = None
            }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: Types.IndexTemplateDataStreamConfiguration, value: bool) =
            { state with Hidden = Some value }

        [<CustomOperation("allowCustomRouting")>]
        member _.AllowCustomRouting(state: Types.IndexTemplateDataStreamConfiguration, value: bool) =
            { state with AllowCustomRouting = Some value }

    let indexTemplateDataStreamConfiguration = IndexTemplateDataStreamConfigurationBuilder()

    type IndexTemplateSummaryBuilder() =
        member _.Yield(_: unit) : Types.IndexTemplateSummary =
            {
                Aliases = None
                Mappings = None
                Settings = None
                Lifecycle = None
                DataStreamOptions = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.IndexTemplateSummary, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.IndexTemplateSummary, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.IndexTemplateSummary, value: Types.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.IndexTemplateSummary, value: Types.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: Types.IndexTemplateSummary, value: Types.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let indexTemplateSummary = IndexTemplateSummaryBuilder()

    type IndexTemplateSummaryWithRolloverBuilder() =
        member _.Yield(_: unit) : Types.IndexTemplateSummaryWithRollover =
            {
                Lifecycle = None
                Aliases = None
                Mappings = None
                Settings = None
                DataStreamOptions = None
            }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.IndexTemplateSummaryWithRollover, value: Types.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.IndexTemplateSummaryWithRollover, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.IndexTemplateSummaryWithRollover, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.IndexTemplateSummaryWithRollover, value: Types.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: Types.IndexTemplateSummaryWithRollover, value: Types.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let indexTemplateSummaryWithRollover = IndexTemplateSummaryWithRolloverBuilder()

    type IndexTemplateWithRolloverBuilder() =
        member _.Yield(_: unit) : Types.IndexTemplateWithRollover =
            {
                Template = None
                IndexPatterns = Unchecked.defaultof<_>
                ComposedOf = Unchecked.defaultof<_>
                Version = None
                Priority = None
                Meta = None
                AllowAutoCreate = None
                DataStream = None
                Deprecated = None
                IgnoreMissingComponentTemplates = None
                CreatedDate = None
                CreatedDateMillis = None
                ModifiedDate = None
                ModifiedDateMillis = None
            }

        [<CustomOperation("template")>]
        member _.Template(state: Types.IndexTemplateWithRollover, value: Types.IndexTemplateSummaryWithRollover) =
            { state with Template = Some value }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: Types.IndexTemplateWithRollover, value: Types.Names) =
            { state with IndexPatterns = value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: Types.IndexTemplateWithRollover, value: Types.Name list) =
            { state with ComposedOf = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.IndexTemplateWithRollover, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.IndexTemplateWithRollover, value: Types.Long) =
            { state with Priority = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IndexTemplateWithRollover, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowAutoCreate")>]
        member _.AllowAutoCreate(state: Types.IndexTemplateWithRollover, value: bool) =
            { state with AllowAutoCreate = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: Types.IndexTemplateWithRollover, value: Types.IndexTemplateDataStreamConfiguration) =
            { state with DataStream = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: Types.IndexTemplateWithRollover, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("ignoreMissingComponentTemplates")>]
        member _.IgnoreMissingComponentTemplates(state: Types.IndexTemplateWithRollover, value: Types.Names) =
            { state with IgnoreMissingComponentTemplates = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: Types.IndexTemplateWithRollover, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: Types.IndexTemplateWithRollover, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.IndexTemplateWithRollover, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.IndexTemplateWithRollover, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let indexTemplateWithRollover = IndexTemplateWithRolloverBuilder()

    type IndexVersioningBuilder() =
        member _.Yield(_: unit) : Types.IndexVersioning =
            {
                Created = None
                CreatedString = None
            }

        [<CustomOperation("created")>]
        member _.Created(state: Types.IndexVersioning, value: Types.VersionString) =
            { state with Created = Some value }

        [<CustomOperation("createdString")>]
        member _.CreatedString(state: Types.IndexVersioning, value: string) =
            { state with CreatedString = Some value }

    let indexVersioning = IndexVersioningBuilder()

    type IndexingSlowlogSettingsBuilder() =
        member _.Yield(_: unit) : Types.IndexingSlowlogSettings =
            {
                Level = None
                Source = None
                Reformat = None
                Threshold = None
            }

        [<CustomOperation("level")>]
        member _.Level(state: Types.IndexingSlowlogSettings, value: string) =
            { state with Level = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.IndexingSlowlogSettings, value: Types.Integer) =
            { state with Source = Some value }

        [<CustomOperation("reformat")>]
        member _.Reformat(state: Types.IndexingSlowlogSettings, value: bool) =
            { state with Reformat = Some value }

        [<CustomOperation("threshold")>]
        member _.Threshold(state: Types.IndexingSlowlogSettings, value: Types.IndexingSlowlogTresholds) =
            { state with Threshold = Some value }

    let indexingSlowlogSettings = IndexingSlowlogSettingsBuilder()

    type MappingLimitSettingsBuilder() =
        member _.Yield(_: unit) : Types.MappingLimitSettings =
            {
                Coerce = None
                TotalFields = None
                Depth = None
                NestedFields = None
                NestedObjects = None
                FieldNameLength = None
                DimensionFields = None
                Source = None
                IgnoreMalformed = None
            }

        [<CustomOperation("coerce")>]
        member _.Coerce(state: Types.MappingLimitSettings, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("totalFields")>]
        member _.TotalFields(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsTotalFields) =
            { state with TotalFields = Some value }

        [<CustomOperation("depth")>]
        member _.Depth(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsDepth) =
            { state with Depth = Some value }

        [<CustomOperation("nestedFields")>]
        member _.NestedFields(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsNestedFields) =
            { state with NestedFields = Some value }

        [<CustomOperation("nestedObjects")>]
        member _.NestedObjects(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsNestedObjects) =
            { state with NestedObjects = Some value }

        [<CustomOperation("fieldNameLength")>]
        member _.FieldNameLength(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsFieldNameLength) =
            { state with FieldNameLength = Some value }

        [<CustomOperation("dimensionFields")>]
        member _.DimensionFields(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsDimensionFields) =
            { state with DimensionFields = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.MappingLimitSettings, value: Types.MappingLimitSettingsSourceFields) =
            { state with Source = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: Types.MappingLimitSettings, value: System.Text.Json.JsonElement) =
            { state with IgnoreMalformed = Some value }

    let mappingLimitSettings = MappingLimitSettingsBuilder()

    type MappingLimitSettingsTotalFieldsBuilder() =
        member _.Yield(_: unit) : Types.MappingLimitSettingsTotalFields =
            {
                Limit = None
                IgnoreDynamicBeyondLimit = None
            }

        [<CustomOperation("limit")>]
        member _.Limit(state: Types.MappingLimitSettingsTotalFields, value: System.Text.Json.JsonElement) =
            { state with Limit = Some value }

        [<CustomOperation("ignoreDynamicBeyondLimit")>]
        member _.IgnoreDynamicBeyondLimit(state: Types.MappingLimitSettingsTotalFields, value: System.Text.Json.JsonElement) =
            { state with IgnoreDynamicBeyondLimit = Some value }

    let mappingLimitSettingsTotalFields = MappingLimitSettingsTotalFieldsBuilder()

    type MergeSchedulerBuilder() =
        member _.Yield(_: unit) : Types.MergeScheduler =
            {
                MaxThreadCount = None
                MaxMergeCount = None
            }

        [<CustomOperation("maxThreadCount")>]
        member _.MaxThreadCount(state: Types.MergeScheduler, value: Types.Stringified<Types.Integer>) =
            { state with MaxThreadCount = Some value }

        [<CustomOperation("maxMergeCount")>]
        member _.MaxMergeCount(state: Types.MergeScheduler, value: Types.Stringified<Types.Integer>) =
            { state with MaxMergeCount = Some value }

    let mergeScheduler = MergeSchedulerBuilder()

    type SettingsSearchBuilder() =
        member _.Yield(_: unit) : Types.SettingsSearch =
            {
                Idle = None
                Slowlog = None
            }

        [<CustomOperation("idle")>]
        member _.Idle(state: Types.SettingsSearch, value: Types.SearchIdle) =
            { state with Idle = Some value }

        [<CustomOperation("slowlog")>]
        member _.Slowlog(state: Types.SettingsSearch, value: Types.SlowlogSettings) =
            { state with Slowlog = Some value }

    let settingsSearch = SettingsSearchBuilder()

    type SettingsSimilarityBm25Builder() =
        member _.Yield(_: unit) : Types.SettingsSimilarityBm25 =
            {
                Type = "BM25"
                B = None
                DiscountOverlaps = None
                K1 = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.SettingsSimilarityBm25, value: string) =
            { state with Type = value }

        [<CustomOperation("b")>]
        member _.B(state: Types.SettingsSimilarityBm25, value: Types.Double) =
            { state with B = Some value }

        [<CustomOperation("discountOverlaps")>]
        member _.DiscountOverlaps(state: Types.SettingsSimilarityBm25, value: bool) =
            { state with DiscountOverlaps = Some value }

        [<CustomOperation("k1")>]
        member _.K1(state: Types.SettingsSimilarityBm25, value: Types.Double) =
            { state with K1 = Some value }

    let settingsSimilarityBm25 = SettingsSimilarityBm25Builder()

    type SlowlogSettingsBuilder() =
        member _.Yield(_: unit) : Types.SlowlogSettings =
            {
                Level = None
                Source = None
                Reformat = None
                Threshold = None
            }

        [<CustomOperation("level")>]
        member _.Level(state: Types.SlowlogSettings, value: string) =
            { state with Level = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.SlowlogSettings, value: Types.Integer) =
            { state with Source = Some value }

        [<CustomOperation("reformat")>]
        member _.Reformat(state: Types.SlowlogSettings, value: bool) =
            { state with Reformat = Some value }

        [<CustomOperation("threshold")>]
        member _.Threshold(state: Types.SlowlogSettings, value: Types.SlowlogTresholds) =
            { state with Threshold = Some value }

    let slowlogSettings = SlowlogSettingsBuilder()

    type SlowlogTresholdLevelsBuilder() =
        member _.Yield(_: unit) : Types.SlowlogTresholdLevels =
            {
                Warn = None
                Info = None
                Debug = None
                Trace = None
            }

        [<CustomOperation("warn")>]
        member _.Warn(state: Types.SlowlogTresholdLevels, value: Types.Duration) =
            { state with Warn = Some value }

        [<CustomOperation("info")>]
        member _.Info(state: Types.SlowlogTresholdLevels, value: Types.Duration) =
            { state with Info = Some value }

        [<CustomOperation("debug")>]
        member _.Debug(state: Types.SlowlogTresholdLevels, value: Types.Duration) =
            { state with Debug = Some value }

        [<CustomOperation("trace")>]
        member _.Trace(state: Types.SlowlogTresholdLevels, value: Types.Duration) =
            { state with Trace = Some value }

    let slowlogTresholdLevels = SlowlogTresholdLevelsBuilder()

    type SlowlogTresholdsBuilder() =
        member _.Yield(_: unit) : Types.SlowlogTresholds =
            {
                Query = None
                Fetch = None
            }

        [<CustomOperation("query")>]
        member _.Query(state: Types.SlowlogTresholds, value: Types.SlowlogTresholdLevels) =
            { state with Query = Some value }

        [<CustomOperation("fetch")>]
        member _.Fetch(state: Types.SlowlogTresholds, value: Types.SlowlogTresholdLevels) =
            { state with Fetch = Some value }

    let slowlogTresholds = SlowlogTresholdsBuilder()

    type SoftDeletesBuilder() =
        member _.Yield(_: unit) : Types.SoftDeletes =
            {
                Enabled = None
                RetentionLease = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.SoftDeletes, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("retentionLease")>]
        member _.RetentionLease(state: Types.SoftDeletes, value: Types.RetentionLease) =
            { state with RetentionLease = Some value }

    let softDeletes = SoftDeletesBuilder()

    type StorageBuilder() =
        member _.Yield(_: unit) : Types.Storage =
            {
                Type = Unchecked.defaultof<_>
                AllowMmap = None
                StatsRefreshInterval = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.Storage, value: Types.StorageType) =
            { state with Type = value }

        [<CustomOperation("allowMmap")>]
        member _.AllowMmap(state: Types.Storage, value: bool) =
            { state with AllowMmap = Some value }

        [<CustomOperation("statsRefreshInterval")>]
        member _.StatsRefreshInterval(state: Types.Storage, value: Types.Duration) =
            { state with StatsRefreshInterval = Some value }

    let storage = StorageBuilder()

    type TranslogBuilder() =
        member _.Yield(_: unit) : Types.Translog =
            {
                SyncInterval = None
                Durability = None
                FlushThresholdSize = None
                Retention = None
            }

        [<CustomOperation("syncInterval")>]
        member _.SyncInterval(state: Types.Translog, value: Types.Duration) =
            { state with SyncInterval = Some value }

        [<CustomOperation("durability")>]
        member _.Durability(state: Types.Translog, value: Types.TranslogDurability) =
            { state with Durability = Some value }

        [<CustomOperation("flushThresholdSize")>]
        member _.FlushThresholdSize(state: Types.Translog, value: Types.ByteSize) =
            { state with FlushThresholdSize = Some value }

        [<CustomOperation("retention")>]
        member _.Retention(state: Types.Translog, value: Types.TranslogRetention) =
            { state with Retention = Some value }

    let translog = TranslogBuilder()

    type TranslogRetentionBuilder() =
        member _.Yield(_: unit) : Types.TranslogRetention =
            {
                Size = None
                Age = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TranslogRetention, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("age")>]
        member _.Age(state: Types.TranslogRetention, value: Types.Duration) =
            { state with Age = Some value }

    let translogRetention = TranslogRetentionBuilder()

