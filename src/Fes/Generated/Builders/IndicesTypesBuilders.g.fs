// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesTypesBuilders =

    type AliasBuilder() =
        member _.Yield(_: unit) : Alias =
            {
                Filter = None
                IndexRouting = None
                IsHidden = None
                IsWriteIndex = None
                Routing = None
                SearchRouting = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: Alias, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: Alias, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isHidden")>]
        member _.IsHidden(state: Alias, value: bool) =
            { state with IsHidden = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: Alias, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Alias, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: Alias, value: string) =
            { state with SearchRouting = Some value }

    let alias = AliasBuilder()

    type AliasDefinitionBuilder() =
        member _.Yield(_: unit) : AliasDefinition =
            {
                Filter = None
                IndexRouting = None
                IsWriteIndex = None
                Routing = None
                SearchRouting = None
                IsHidden = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: AliasDefinition, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: AliasDefinition, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: AliasDefinition, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: AliasDefinition, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: AliasDefinition, value: string) =
            { state with SearchRouting = Some value }

        [<CustomOperation("isHidden")>]
        member _.IsHidden(state: AliasDefinition, value: bool) =
            { state with IsHidden = Some value }

    let aliasDefinition = AliasDefinitionBuilder()

    type DataStreamBuilder() =
        member _.Yield(_: unit) : DataStream =
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
        member _.Meta(state: DataStream, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowCustomRouting")>]
        member _.AllowCustomRouting(state: DataStream, value: bool) =
            { state with AllowCustomRouting = Some value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: DataStream, value: IndicesTypes.FailureStore) =
            { state with FailureStore = Some value }

        [<CustomOperation("generation")>]
        member _.Generation(state: DataStream, value: Types.Integer) =
            { state with Generation = value }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: DataStream, value: bool) =
            { state with Hidden = value }

        [<CustomOperation("ilmPolicy")>]
        member _.IlmPolicy(state: DataStream, value: Types.Name) =
            { state with IlmPolicy = Some value }

        [<CustomOperation("nextGenerationManagedBy")>]
        member _.NextGenerationManagedBy(state: DataStream, value: IndicesTypes.ManagedBy) =
            { state with NextGenerationManagedBy = value }

        [<CustomOperation("preferIlm")>]
        member _.PreferIlm(state: DataStream, value: bool) =
            { state with PreferIlm = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: DataStream, value: IndicesTypes.DataStreamIndex list) =
            { state with Indices = value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: DataStream, value: IndicesTypes.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: DataStream, value: Types.DataStreamName) =
            { state with Name = value }

        [<CustomOperation("replicated")>]
        member _.Replicated(state: DataStream, value: bool) =
            { state with Replicated = Some value }

        [<CustomOperation("rolloverOnWrite")>]
        member _.RolloverOnWrite(state: DataStream, value: bool) =
            { state with RolloverOnWrite = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: DataStream, value: IndicesTypes.IndexSettings) =
            { state with Settings = value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: DataStream, value: TypesMapping.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: DataStream, value: Types.HealthStatus) =
            { state with Status = value }

        [<CustomOperation("system")>]
        member _.System(state: DataStream, value: bool) =
            { state with System = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: DataStream, value: Types.Name) =
            { state with Template = value }

        [<CustomOperation("timestampField")>]
        member _.TimestampField(state: DataStream, value: IndicesTypes.DataStreamTimestampField) =
            { state with TimestampField = value }

        [<CustomOperation("indexMode")>]
        member _.IndexMode(state: DataStream, value: IndicesTypes.IndexMode) =
            { state with IndexMode = Some value }

    let dataStream = DataStreamBuilder()

    type DataStreamFailureStoreBuilder() =
        member _.Yield(_: unit) : DataStreamFailureStore =
            {
                Enabled = None
                Lifecycle = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: DataStreamFailureStore, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: DataStreamFailureStore, value: IndicesTypes.FailureStoreLifecycle) =
            { state with Lifecycle = Some value }

    let dataStreamFailureStore = DataStreamFailureStoreBuilder()

    type DataStreamFailureStoreTemplateBuilder() =
        member _.Yield(_: unit) : DataStreamFailureStoreTemplate =
            {
                Enabled = None
                Lifecycle = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: DataStreamFailureStoreTemplate, value: bool option) =
            { state with Enabled = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: DataStreamFailureStoreTemplate, value: IndicesTypes.FailureStoreLifecycleTemplate option) =
            { state with Lifecycle = Some value }

    let dataStreamFailureStoreTemplate = DataStreamFailureStoreTemplateBuilder()

    type DataStreamIndexBuilder() =
        member _.Yield(_: unit) : DataStreamIndex =
            {
                IndexName = Unchecked.defaultof<_>
                IndexUuid = Unchecked.defaultof<_>
                IlmPolicy = None
                ManagedBy = None
                PreferIlm = None
                IndexMode = None
            }

        [<CustomOperation("indexName")>]
        member _.IndexName(state: DataStreamIndex, value: Types.IndexName) =
            { state with IndexName = value }

        [<CustomOperation("indexUuid")>]
        member _.IndexUuid(state: DataStreamIndex, value: Types.Uuid) =
            { state with IndexUuid = value }

        [<CustomOperation("ilmPolicy")>]
        member _.IlmPolicy(state: DataStreamIndex, value: Types.Name) =
            { state with IlmPolicy = Some value }

        [<CustomOperation("managedBy")>]
        member _.ManagedBy(state: DataStreamIndex, value: IndicesTypes.ManagedBy) =
            { state with ManagedBy = Some value }

        [<CustomOperation("preferIlm")>]
        member _.PreferIlm(state: DataStreamIndex, value: bool) =
            { state with PreferIlm = Some value }

        [<CustomOperation("indexMode")>]
        member _.IndexMode(state: DataStreamIndex, value: IndicesTypes.IndexMode) =
            { state with IndexMode = Some value }

    let dataStreamIndex = DataStreamIndexBuilder()

    type DataStreamLifecycleBuilder() =
        member _.Yield(_: unit) : DataStreamLifecycle =
            {
                DataRetention = None
                Downsampling = None
                DownsamplingMethod = None
                Enabled = None
                FrozenAfter = None
            }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: DataStreamLifecycle, value: Types.Duration) =
            { state with DataRetention = Some value }

        [<CustomOperation("downsampling")>]
        member _.Downsampling(state: DataStreamLifecycle, value: IndicesTypes.DownsamplingRound list) =
            { state with Downsampling = Some value }

        [<CustomOperation("downsamplingMethod")>]
        member _.DownsamplingMethod(state: DataStreamLifecycle, value: IndicesTypes.SamplingMethod) =
            { state with DownsamplingMethod = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: DataStreamLifecycle, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("frozenAfter")>]
        member _.FrozenAfter(state: DataStreamLifecycle, value: Types.Duration) =
            { state with FrozenAfter = Some value }

    let dataStreamLifecycle = DataStreamLifecycleBuilder()

    type DataStreamLifecycleRolloverConditionsBuilder() =
        member _.Yield(_: unit) : DataStreamLifecycleRolloverConditions =
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
        member _.MinAge(state: DataStreamLifecycleRolloverConditions, value: Types.Duration) =
            { state with MinAge = Some value }

        [<CustomOperation("maxAge")>]
        member _.MaxAge(state: DataStreamLifecycleRolloverConditions, value: string) =
            { state with MaxAge = Some value }

        [<CustomOperation("minDocs")>]
        member _.MinDocs(state: DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MinDocs = Some value }

        [<CustomOperation("maxDocs")>]
        member _.MaxDocs(state: DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MaxDocs = Some value }

        [<CustomOperation("minSize")>]
        member _.MinSize(state: DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MinSize = Some value }

        [<CustomOperation("maxSize")>]
        member _.MaxSize(state: DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MaxSize = Some value }

        [<CustomOperation("minPrimaryShardSize")>]
        member _.MinPrimaryShardSize(state: DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MinPrimaryShardSize = Some value }

        [<CustomOperation("maxPrimaryShardSize")>]
        member _.MaxPrimaryShardSize(state: DataStreamLifecycleRolloverConditions, value: Types.ByteSize) =
            { state with MaxPrimaryShardSize = Some value }

        [<CustomOperation("minPrimaryShardDocs")>]
        member _.MinPrimaryShardDocs(state: DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MinPrimaryShardDocs = Some value }

        [<CustomOperation("maxPrimaryShardDocs")>]
        member _.MaxPrimaryShardDocs(state: DataStreamLifecycleRolloverConditions, value: Types.Long) =
            { state with MaxPrimaryShardDocs = Some value }

    let dataStreamLifecycleRolloverConditions = DataStreamLifecycleRolloverConditionsBuilder()

    type DataStreamVisibilityBuilder() =
        member _.Yield(_: unit) : DataStreamVisibility =
            {
                Hidden = None
                AllowCustomRouting = None
                FailureStore = None
            }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: DataStreamVisibility, value: bool) =
            { state with Hidden = Some value }

        [<CustomOperation("allowCustomRouting")>]
        member _.AllowCustomRouting(state: DataStreamVisibility, value: bool) =
            { state with AllowCustomRouting = Some value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: DataStreamVisibility, value: bool) =
            { state with FailureStore = Some value }

    let dataStreamVisibility = DataStreamVisibilityBuilder()

    type FailureStoreLifecycleBuilder() =
        member _.Yield(_: unit) : FailureStoreLifecycle =
            {
                DataRetention = None
                Enabled = None
            }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: FailureStoreLifecycle, value: Types.Duration) =
            { state with DataRetention = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: FailureStoreLifecycle, value: bool) =
            { state with Enabled = Some value }

    let failureStoreLifecycle = FailureStoreLifecycleBuilder()

    type FailureStoreLifecycleTemplateBuilder() =
        member _.Yield(_: unit) : FailureStoreLifecycleTemplate =
            {
                DataRetention = None
                Enabled = None
            }

        [<CustomOperation("dataRetention")>]
        member _.DataRetention(state: FailureStoreLifecycleTemplate, value: Types.Duration option) =
            { state with DataRetention = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: FailureStoreLifecycleTemplate, value: bool) =
            { state with Enabled = Some value }

    let failureStoreLifecycleTemplate = FailureStoreLifecycleTemplateBuilder()

    type IndexRoutingBuilder() =
        member _.Yield(_: unit) : IndexRouting =
            {
                Allocation = None
                Rebalance = None
            }

        [<CustomOperation("allocation")>]
        member _.Allocation(state: IndexRouting, value: IndicesTypes.IndexRoutingAllocation) =
            { state with Allocation = Some value }

        [<CustomOperation("rebalance")>]
        member _.Rebalance(state: IndexRouting, value: IndicesTypes.IndexRoutingRebalance) =
            { state with Rebalance = Some value }

    let indexRouting = IndexRoutingBuilder()

    type IndexRoutingAllocationBuilder() =
        member _.Yield(_: unit) : IndexRoutingAllocation =
            {
                Enable = None
                Include = None
                InitialRecovery = None
                Disk = None
            }

        [<CustomOperation("enable")>]
        member _.Enable(state: IndexRoutingAllocation, value: IndicesTypes.IndexRoutingAllocationOptions) =
            { state with Enable = Some value }

        [<CustomOperation("include")>]
        member _.Include(state: IndexRoutingAllocation, value: IndicesTypes.IndexRoutingAllocationInclude) =
            { state with Include = Some value }

        [<CustomOperation("initialRecovery")>]
        member _.InitialRecovery(state: IndexRoutingAllocation, value: IndicesTypes.IndexRoutingAllocationInitialRecovery) =
            { state with InitialRecovery = Some value }

        [<CustomOperation("disk")>]
        member _.Disk(state: IndexRoutingAllocation, value: IndicesTypes.IndexRoutingAllocationDisk) =
            { state with Disk = Some value }

    let indexRoutingAllocation = IndexRoutingAllocationBuilder()

    type IndexRoutingAllocationIncludeBuilder() =
        member _.Yield(_: unit) : IndexRoutingAllocationInclude =
            {
                TierPreference = None
                Id = None
            }

        [<CustomOperation("tierPreference")>]
        member _.TierPreference(state: IndexRoutingAllocationInclude, value: string) =
            { state with TierPreference = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: IndexRoutingAllocationInclude, value: Types.Id) =
            { state with Id = Some value }

    let indexRoutingAllocationInclude = IndexRoutingAllocationIncludeBuilder()

    type IndexSegmentSortBuilder() =
        member _.Yield(_: unit) : IndexSegmentSort =
            {
                Field = None
                Order = None
                Mode = None
                Missing = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: IndexSegmentSort, value: Types.Fields) =
            { state with Field = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: IndexSegmentSort, value: System.Text.Json.JsonElement) =
            { state with Order = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: IndexSegmentSort, value: System.Text.Json.JsonElement) =
            { state with Mode = Some value }

        [<CustomOperation("missing")>]
        member _.Missing(state: IndexSegmentSort, value: System.Text.Json.JsonElement) =
            { state with Missing = Some value }

    let indexSegmentSort = IndexSegmentSortBuilder()

    type IndexSettingBlocksBuilder() =
        member _.Yield(_: unit) : IndexSettingBlocks =
            {
                ReadOnly = None
                ReadOnlyAllowDelete = None
                Read = None
                Write = None
                Metadata = None
            }

        [<CustomOperation("readOnly")>]
        member _.ReadOnly(state: IndexSettingBlocks, value: SpecUtils.Stringified<bool>) =
            { state with ReadOnly = Some value }

        [<CustomOperation("readOnlyAllowDelete")>]
        member _.ReadOnlyAllowDelete(state: IndexSettingBlocks, value: SpecUtils.Stringified<bool>) =
            { state with ReadOnlyAllowDelete = Some value }

        [<CustomOperation("read")>]
        member _.Read(state: IndexSettingBlocks, value: SpecUtils.Stringified<bool>) =
            { state with Read = Some value }

        [<CustomOperation("write")>]
        member _.Write(state: IndexSettingBlocks, value: SpecUtils.Stringified<bool>) =
            { state with Write = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: IndexSettingBlocks, value: SpecUtils.Stringified<bool>) =
            { state with Metadata = Some value }

    let indexSettingBlocks = IndexSettingBlocksBuilder()

    type IndexSettingsBuilder() =
        member _.Yield(_: unit) : IndexSettings =
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
        member _.Index(state: IndexSettings, value: IndicesTypes.IndexSettings) =
            { state with Index = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: IndexSettings, value: string) =
            { state with Mode = Some value }

        [<CustomOperation("routingPath")>]
        member _.RoutingPath(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with RoutingPath = Some value }

        [<CustomOperation("softDeletes")>]
        member _.SoftDeletes(state: IndexSettings, value: IndicesTypes.SoftDeletes) =
            { state with SoftDeletes = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: IndexSettings, value: IndicesTypes.IndexSegmentSort) =
            { state with Sort = Some value }

        [<CustomOperation("numberOfShards")>]
        member _.NumberOfShards(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with NumberOfShards = Some value }

        [<CustomOperation("numberOfReplicas")>]
        member _.NumberOfReplicas(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with NumberOfReplicas = Some value }

        [<CustomOperation("numberOfRoutingShards")>]
        member _.NumberOfRoutingShards(state: IndexSettings, value: Types.Integer) =
            { state with NumberOfRoutingShards = Some value }

        [<CustomOperation("checkOnStartup")>]
        member _.CheckOnStartup(state: IndexSettings, value: IndicesTypes.IndexCheckOnStartup) =
            { state with CheckOnStartup = Some value }

        [<CustomOperation("codec")>]
        member _.Codec(state: IndexSettings, value: string) =
            { state with Codec = Some value }

        [<CustomOperation("routingPartitionSize")>]
        member _.RoutingPartitionSize(state: IndexSettings, value: SpecUtils.Stringified<Types.Integer>) =
            { state with RoutingPartitionSize = Some value }

        [<CustomOperation("loadFixedBitsetFiltersEagerly")>]
        member _.LoadFixedBitsetFiltersEagerly(state: IndexSettings, value: bool) =
            { state with LoadFixedBitsetFiltersEagerly = Some value }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with Hidden = Some value }

        [<CustomOperation("autoExpandReplicas")>]
        member _.AutoExpandReplicas(state: IndexSettings, value: SpecUtils.WithNullValue<string>) =
            { state with AutoExpandReplicas = Some value }

        [<CustomOperation("merge")>]
        member _.Merge(state: IndexSettings, value: IndicesTypes.Merge) =
            { state with Merge = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: IndexSettings, value: IndicesTypes.SettingsSearch) =
            { state with Search = Some value }

        [<CustomOperation("refreshInterval")>]
        member _.RefreshInterval(state: IndexSettings, value: Types.Duration) =
            { state with RefreshInterval = Some value }

        [<CustomOperation("maxResultWindow")>]
        member _.MaxResultWindow(state: IndexSettings, value: Types.Integer) =
            { state with MaxResultWindow = Some value }

        [<CustomOperation("maxInnerResultWindow")>]
        member _.MaxInnerResultWindow(state: IndexSettings, value: Types.Integer) =
            { state with MaxInnerResultWindow = Some value }

        [<CustomOperation("maxRescoreWindow")>]
        member _.MaxRescoreWindow(state: IndexSettings, value: Types.Integer) =
            { state with MaxRescoreWindow = Some value }

        [<CustomOperation("maxDocvalueFieldsSearch")>]
        member _.MaxDocvalueFieldsSearch(state: IndexSettings, value: Types.Integer) =
            { state with MaxDocvalueFieldsSearch = Some value }

        [<CustomOperation("maxScriptFields")>]
        member _.MaxScriptFields(state: IndexSettings, value: Types.Integer) =
            { state with MaxScriptFields = Some value }

        [<CustomOperation("maxNgramDiff")>]
        member _.MaxNgramDiff(state: IndexSettings, value: Types.Integer) =
            { state with MaxNgramDiff = Some value }

        [<CustomOperation("maxShingleDiff")>]
        member _.MaxShingleDiff(state: IndexSettings, value: Types.Integer) =
            { state with MaxShingleDiff = Some value }

        [<CustomOperation("blocks")>]
        member _.Blocks(state: IndexSettings, value: IndicesTypes.IndexSettingBlocks) =
            { state with Blocks = Some value }

        [<CustomOperation("maxRefreshListeners")>]
        member _.MaxRefreshListeners(state: IndexSettings, value: Types.Integer) =
            { state with MaxRefreshListeners = Some value }

        [<CustomOperation("analyze")>]
        member _.Analyze(state: IndexSettings, value: IndicesTypes.SettingsAnalyze) =
            { state with Analyze = Some value }

        [<CustomOperation("highlight")>]
        member _.Highlight(state: IndexSettings, value: IndicesTypes.SettingsHighlight) =
            { state with Highlight = Some value }

        [<CustomOperation("maxTermsCount")>]
        member _.MaxTermsCount(state: IndexSettings, value: Types.Integer) =
            { state with MaxTermsCount = Some value }

        [<CustomOperation("maxRegexLength")>]
        member _.MaxRegexLength(state: IndexSettings, value: Types.Integer) =
            { state with MaxRegexLength = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: IndexSettings, value: IndicesTypes.IndexRouting) =
            { state with Routing = Some value }

        [<CustomOperation("gcDeletes")>]
        member _.GcDeletes(state: IndexSettings, value: Types.Duration) =
            { state with GcDeletes = Some value }

        [<CustomOperation("defaultPipeline")>]
        member _.DefaultPipeline(state: IndexSettings, value: Types.PipelineName) =
            { state with DefaultPipeline = Some value }

        [<CustomOperation("finalPipeline")>]
        member _.FinalPipeline(state: IndexSettings, value: Types.PipelineName) =
            { state with FinalPipeline = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: IndexSettings, value: IndicesTypes.IndexSettingsLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("providedName")>]
        member _.ProvidedName(state: IndexSettings, value: Types.Name) =
            { state with ProvidedName = Some value }

        [<CustomOperation("creationDate")>]
        member _.CreationDate(state: IndexSettings, value: SpecUtils.Stringified<Types.EpochTime<Types.UnitMillis>>) =
            { state with CreationDate = Some value }

        [<CustomOperation("creationDateString")>]
        member _.CreationDateString(state: IndexSettings, value: Types.DateTime) =
            { state with CreationDateString = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: IndexSettings, value: Types.Uuid) =
            { state with Uuid = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndexSettings, value: IndicesTypes.IndexVersioning) =
            { state with Version = Some value }

        [<CustomOperation("verifiedBeforeClose")>]
        member _.VerifiedBeforeClose(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with VerifiedBeforeClose = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with Format = Some value }

        [<CustomOperation("maxSlicesPerScroll")>]
        member _.MaxSlicesPerScroll(state: IndexSettings, value: Types.Integer) =
            { state with MaxSlicesPerScroll = Some value }

        [<CustomOperation("translog")>]
        member _.Translog(state: IndexSettings, value: IndicesTypes.Translog) =
            { state with Translog = Some value }

        [<CustomOperation("queryString")>]
        member _.QueryString(state: IndexSettings, value: IndicesTypes.SettingsQueryString) =
            { state with QueryString = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: IndexSettings, value: System.Text.Json.JsonElement) =
            { state with Priority = Some value }

        [<CustomOperation("topMetricsMaxSize")>]
        member _.TopMetricsMaxSize(state: IndexSettings, value: Types.Integer) =
            { state with TopMetricsMaxSize = Some value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: IndexSettings, value: IndicesTypes.IndexSettingsAnalysis) =
            { state with Analysis = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndexSettings, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("timeSeries")>]
        member _.TimeSeries(state: IndexSettings, value: IndicesTypes.IndexSettingsTimeSeries) =
            { state with TimeSeries = Some value }

        [<CustomOperation("queries")>]
        member _.Queries(state: IndexSettings, value: IndicesTypes.Queries) =
            { state with Queries = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: IndexSettings, value: Map<string, IndicesTypes.SettingsSimilarity>) =
            { state with Similarity = Some value }

        [<CustomOperation("mapping")>]
        member _.Mapping(state: IndexSettings, value: IndicesTypes.MappingLimitSettings) =
            { state with Mapping = Some value }

        [<CustomOperation("indexingSlowlog")>]
        member _.IndexingSlowlog(state: IndexSettings, value: IndicesTypes.IndexingSlowlogSettings) =
            { state with IndexingSlowlog = Some value }

        [<CustomOperation("indexingPressure")>]
        member _.IndexingPressure(state: IndexSettings, value: IndicesTypes.IndexingPressure) =
            { state with IndexingPressure = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: IndexSettings, value: IndicesTypes.Storage) =
            { state with Store = Some value }

    let indexSettings = IndexSettingsBuilder()

    type IndexSettingsAnalysisBuilder() =
        member _.Yield(_: unit) : IndexSettingsAnalysis =
            {
                Analyzer = None
                CharFilter = None
                Filter = None
                Normalizer = None
                Tokenizer = None
            }

        [<CustomOperation("analyzer")>]
        member _.Analyzer(state: IndexSettingsAnalysis, value: Map<string, TypesAnalysis.Analyzer>) =
            { state with Analyzer = Some value }

        [<CustomOperation("charFilter")>]
        member _.CharFilter(state: IndexSettingsAnalysis, value: Map<string, TypesAnalysis.CharFilter>) =
            { state with CharFilter = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: IndexSettingsAnalysis, value: Map<string, TypesAnalysis.TokenFilter>) =
            { state with Filter = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: IndexSettingsAnalysis, value: Map<string, TypesAnalysis.Normalizer>) =
            { state with Normalizer = Some value }

        [<CustomOperation("tokenizer")>]
        member _.Tokenizer(state: IndexSettingsAnalysis, value: Map<string, TypesAnalysis.Tokenizer>) =
            { state with Tokenizer = Some value }

    let indexSettingsAnalysis = IndexSettingsAnalysisBuilder()

    type IndexSettingsLifecycleBuilder() =
        member _.Yield(_: unit) : IndexSettingsLifecycle =
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
        member _.Name(state: IndexSettingsLifecycle, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("indexingComplete")>]
        member _.IndexingComplete(state: IndexSettingsLifecycle, value: SpecUtils.Stringified<bool>) =
            { state with IndexingComplete = Some value }

        [<CustomOperation("originationDate")>]
        member _.OriginationDate(state: IndexSettingsLifecycle, value: Types.Long) =
            { state with OriginationDate = Some value }

        [<CustomOperation("parseOriginationDate")>]
        member _.ParseOriginationDate(state: IndexSettingsLifecycle, value: bool) =
            { state with ParseOriginationDate = Some value }

        [<CustomOperation("step")>]
        member _.Step(state: IndexSettingsLifecycle, value: IndicesTypes.IndexSettingsLifecycleStep) =
            { state with Step = Some value }

        [<CustomOperation("rolloverAlias")>]
        member _.RolloverAlias(state: IndexSettingsLifecycle, value: string) =
            { state with RolloverAlias = Some value }

        [<CustomOperation("preferIlm")>]
        member _.PreferIlm(state: IndexSettingsLifecycle, value: System.Text.Json.JsonElement) =
            { state with PreferIlm = Some value }

    let indexSettingsLifecycle = IndexSettingsLifecycleBuilder()

    type IndexSettingsTimeSeriesBuilder() =
        member _.Yield(_: unit) : IndexSettingsTimeSeries =
            {
                EndTime = None
                StartTime = None
            }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: IndexSettingsTimeSeries, value: Types.DateTime) =
            { state with EndTime = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: IndexSettingsTimeSeries, value: Types.DateTime) =
            { state with StartTime = Some value }

    let indexSettingsTimeSeries = IndexSettingsTimeSeriesBuilder()

    type IndexStateBuilder() =
        member _.Yield(_: unit) : IndexState =
            {
                Aliases = None
                Mappings = None
                Settings = None
                Defaults = None
                DataStream = None
                Lifecycle = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndexState, value: Map<Types.IndexName, IndicesTypes.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndexState, value: TypesMapping.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndexState, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("defaults")>]
        member _.Defaults(state: IndexState, value: IndicesTypes.IndexSettings) =
            { state with Defaults = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: IndexState, value: Types.DataStreamName) =
            { state with DataStream = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: IndexState, value: IndicesTypes.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

    let indexState = IndexStateBuilder()

    type IndexTemplateBuilder() =
        member _.Yield(_: unit) : IndexTemplate =
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
        member _.IndexPatterns(state: IndexTemplate, value: Types.Names) =
            { state with IndexPatterns = value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: IndexTemplate, value: Types.Name list) =
            { state with ComposedOf = value }

        [<CustomOperation("template")>]
        member _.Template(state: IndexTemplate, value: IndicesTypes.IndexTemplateSummary) =
            { state with Template = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: IndexTemplate, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: IndexTemplate, value: Types.Long) =
            { state with Priority = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: IndexTemplate, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowAutoCreate")>]
        member _.AllowAutoCreate(state: IndexTemplate, value: bool) =
            { state with AllowAutoCreate = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: IndexTemplate, value: IndicesTypes.IndexTemplateDataStreamConfiguration) =
            { state with DataStream = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IndexTemplate, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("ignoreMissingComponentTemplates")>]
        member _.IgnoreMissingComponentTemplates(state: IndexTemplate, value: Types.Names) =
            { state with IgnoreMissingComponentTemplates = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: IndexTemplate, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: IndexTemplate, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: IndexTemplate, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: IndexTemplate, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let indexTemplate = IndexTemplateBuilder()

    type IndexTemplateDataStreamConfigurationBuilder() =
        member _.Yield(_: unit) : IndexTemplateDataStreamConfiguration =
            {
                Hidden = None
                AllowCustomRouting = None
            }

        [<CustomOperation("hidden")>]
        member _.Hidden(state: IndexTemplateDataStreamConfiguration, value: bool) =
            { state with Hidden = Some value }

        [<CustomOperation("allowCustomRouting")>]
        member _.AllowCustomRouting(state: IndexTemplateDataStreamConfiguration, value: bool) =
            { state with AllowCustomRouting = Some value }

    let indexTemplateDataStreamConfiguration = IndexTemplateDataStreamConfigurationBuilder()

    type IndexTemplateSummaryBuilder() =
        member _.Yield(_: unit) : IndexTemplateSummary =
            {
                Aliases = None
                Mappings = None
                Settings = None
                Lifecycle = None
                DataStreamOptions = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndexTemplateSummary, value: Map<Types.IndexName, IndicesTypes.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndexTemplateSummary, value: TypesMapping.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndexTemplateSummary, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: IndexTemplateSummary, value: IndicesTypes.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: IndexTemplateSummary, value: IndicesTypes.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let indexTemplateSummary = IndexTemplateSummaryBuilder()

    type IndexTemplateSummaryWithRolloverBuilder() =
        member _.Yield(_: unit) : IndexTemplateSummaryWithRollover =
            {
                Lifecycle = None
                Aliases = None
                Mappings = None
                Settings = None
                DataStreamOptions = None
            }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: IndexTemplateSummaryWithRollover, value: IndicesTypes.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndexTemplateSummaryWithRollover, value: Map<Types.IndexName, IndicesTypes.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndexTemplateSummaryWithRollover, value: TypesMapping.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndexTemplateSummaryWithRollover, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: IndexTemplateSummaryWithRollover, value: IndicesTypes.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let indexTemplateSummaryWithRollover = IndexTemplateSummaryWithRolloverBuilder()

    type IndexTemplateWithRolloverBuilder() =
        member _.Yield(_: unit) : IndexTemplateWithRollover =
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
        member _.Template(state: IndexTemplateWithRollover, value: IndicesTypes.IndexTemplateSummaryWithRollover) =
            { state with Template = Some value }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: IndexTemplateWithRollover, value: Types.Names) =
            { state with IndexPatterns = value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: IndexTemplateWithRollover, value: Types.Name list) =
            { state with ComposedOf = value }

        [<CustomOperation("version")>]
        member _.Version(state: IndexTemplateWithRollover, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: IndexTemplateWithRollover, value: Types.Long) =
            { state with Priority = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: IndexTemplateWithRollover, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("allowAutoCreate")>]
        member _.AllowAutoCreate(state: IndexTemplateWithRollover, value: bool) =
            { state with AllowAutoCreate = Some value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: IndexTemplateWithRollover, value: IndicesTypes.IndexTemplateDataStreamConfiguration) =
            { state with DataStream = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: IndexTemplateWithRollover, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("ignoreMissingComponentTemplates")>]
        member _.IgnoreMissingComponentTemplates(state: IndexTemplateWithRollover, value: Types.Names) =
            { state with IgnoreMissingComponentTemplates = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: IndexTemplateWithRollover, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: IndexTemplateWithRollover, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: IndexTemplateWithRollover, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: IndexTemplateWithRollover, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let indexTemplateWithRollover = IndexTemplateWithRolloverBuilder()

    type IndexVersioningBuilder() =
        member _.Yield(_: unit) : IndexVersioning =
            {
                Created = None
                CreatedString = None
            }

        [<CustomOperation("created")>]
        member _.Created(state: IndexVersioning, value: Types.VersionString) =
            { state with Created = Some value }

        [<CustomOperation("createdString")>]
        member _.CreatedString(state: IndexVersioning, value: string) =
            { state with CreatedString = Some value }

    let indexVersioning = IndexVersioningBuilder()

    type IndexingSlowlogSettingsBuilder() =
        member _.Yield(_: unit) : IndexingSlowlogSettings =
            {
                Level = None
                Source = None
                Reformat = None
                Threshold = None
            }

        [<CustomOperation("level")>]
        member _.Level(state: IndexingSlowlogSettings, value: string) =
            { state with Level = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: IndexingSlowlogSettings, value: Types.Integer) =
            { state with Source = Some value }

        [<CustomOperation("reformat")>]
        member _.Reformat(state: IndexingSlowlogSettings, value: bool) =
            { state with Reformat = Some value }

        [<CustomOperation("threshold")>]
        member _.Threshold(state: IndexingSlowlogSettings, value: IndicesTypes.IndexingSlowlogTresholds) =
            { state with Threshold = Some value }

    let indexingSlowlogSettings = IndexingSlowlogSettingsBuilder()

    type MappingLimitSettingsBuilder() =
        member _.Yield(_: unit) : MappingLimitSettings =
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
        member _.Coerce(state: MappingLimitSettings, value: bool) =
            { state with Coerce = Some value }

        [<CustomOperation("totalFields")>]
        member _.TotalFields(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsTotalFields) =
            { state with TotalFields = Some value }

        [<CustomOperation("depth")>]
        member _.Depth(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsDepth) =
            { state with Depth = Some value }

        [<CustomOperation("nestedFields")>]
        member _.NestedFields(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsNestedFields) =
            { state with NestedFields = Some value }

        [<CustomOperation("nestedObjects")>]
        member _.NestedObjects(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsNestedObjects) =
            { state with NestedObjects = Some value }

        [<CustomOperation("fieldNameLength")>]
        member _.FieldNameLength(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsFieldNameLength) =
            { state with FieldNameLength = Some value }

        [<CustomOperation("dimensionFields")>]
        member _.DimensionFields(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsDimensionFields) =
            { state with DimensionFields = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: MappingLimitSettings, value: IndicesTypes.MappingLimitSettingsSourceFields) =
            { state with Source = Some value }

        [<CustomOperation("ignoreMalformed")>]
        member _.IgnoreMalformed(state: MappingLimitSettings, value: System.Text.Json.JsonElement) =
            { state with IgnoreMalformed = Some value }

    let mappingLimitSettings = MappingLimitSettingsBuilder()

    type MappingLimitSettingsTotalFieldsBuilder() =
        member _.Yield(_: unit) : MappingLimitSettingsTotalFields =
            {
                Limit = None
                IgnoreDynamicBeyondLimit = None
            }

        [<CustomOperation("limit")>]
        member _.Limit(state: MappingLimitSettingsTotalFields, value: System.Text.Json.JsonElement) =
            { state with Limit = Some value }

        [<CustomOperation("ignoreDynamicBeyondLimit")>]
        member _.IgnoreDynamicBeyondLimit(state: MappingLimitSettingsTotalFields, value: System.Text.Json.JsonElement) =
            { state with IgnoreDynamicBeyondLimit = Some value }

    let mappingLimitSettingsTotalFields = MappingLimitSettingsTotalFieldsBuilder()

    type MergeSchedulerBuilder() =
        member _.Yield(_: unit) : MergeScheduler =
            {
                MaxThreadCount = None
                MaxMergeCount = None
            }

        [<CustomOperation("maxThreadCount")>]
        member _.MaxThreadCount(state: MergeScheduler, value: SpecUtils.Stringified<Types.Integer>) =
            { state with MaxThreadCount = Some value }

        [<CustomOperation("maxMergeCount")>]
        member _.MaxMergeCount(state: MergeScheduler, value: SpecUtils.Stringified<Types.Integer>) =
            { state with MaxMergeCount = Some value }

    let mergeScheduler = MergeSchedulerBuilder()

    type SettingsSearchBuilder() =
        member _.Yield(_: unit) : SettingsSearch =
            {
                Idle = None
                Slowlog = None
            }

        [<CustomOperation("idle")>]
        member _.Idle(state: SettingsSearch, value: IndicesTypes.SearchIdle) =
            { state with Idle = Some value }

        [<CustomOperation("slowlog")>]
        member _.Slowlog(state: SettingsSearch, value: IndicesTypes.SlowlogSettings) =
            { state with Slowlog = Some value }

    let settingsSearch = SettingsSearchBuilder()

    type SettingsSimilarityBm25Builder() =
        member _.Yield(_: unit) : SettingsSimilarityBm25 =
            {
                Type = Unchecked.defaultof<_>
                B = None
                DiscountOverlaps = None
                K1 = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: SettingsSimilarityBm25, value: string) =
            { state with Type = value }

        [<CustomOperation("b")>]
        member _.B(state: SettingsSimilarityBm25, value: Types.Double) =
            { state with B = Some value }

        [<CustomOperation("discountOverlaps")>]
        member _.DiscountOverlaps(state: SettingsSimilarityBm25, value: bool) =
            { state with DiscountOverlaps = Some value }

        [<CustomOperation("k1")>]
        member _.K1(state: SettingsSimilarityBm25, value: Types.Double) =
            { state with K1 = Some value }

    let settingsSimilarityBm25 = SettingsSimilarityBm25Builder()

    type SlowlogSettingsBuilder() =
        member _.Yield(_: unit) : SlowlogSettings =
            {
                Level = None
                Source = None
                Reformat = None
                Threshold = None
            }

        [<CustomOperation("level")>]
        member _.Level(state: SlowlogSettings, value: string) =
            { state with Level = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SlowlogSettings, value: Types.Integer) =
            { state with Source = Some value }

        [<CustomOperation("reformat")>]
        member _.Reformat(state: SlowlogSettings, value: bool) =
            { state with Reformat = Some value }

        [<CustomOperation("threshold")>]
        member _.Threshold(state: SlowlogSettings, value: IndicesTypes.SlowlogTresholds) =
            { state with Threshold = Some value }

    let slowlogSettings = SlowlogSettingsBuilder()

    type SlowlogTresholdLevelsBuilder() =
        member _.Yield(_: unit) : SlowlogTresholdLevels =
            {
                Warn = None
                Info = None
                Debug = None
                Trace = None
            }

        [<CustomOperation("warn")>]
        member _.Warn(state: SlowlogTresholdLevels, value: Types.Duration) =
            { state with Warn = Some value }

        [<CustomOperation("info")>]
        member _.Info(state: SlowlogTresholdLevels, value: Types.Duration) =
            { state with Info = Some value }

        [<CustomOperation("debug")>]
        member _.Debug(state: SlowlogTresholdLevels, value: Types.Duration) =
            { state with Debug = Some value }

        [<CustomOperation("trace")>]
        member _.Trace(state: SlowlogTresholdLevels, value: Types.Duration) =
            { state with Trace = Some value }

    let slowlogTresholdLevels = SlowlogTresholdLevelsBuilder()

    type SlowlogTresholdsBuilder() =
        member _.Yield(_: unit) : SlowlogTresholds =
            {
                Query = None
                Fetch = None
            }

        [<CustomOperation("query")>]
        member _.Query(state: SlowlogTresholds, value: IndicesTypes.SlowlogTresholdLevels) =
            { state with Query = Some value }

        [<CustomOperation("fetch")>]
        member _.Fetch(state: SlowlogTresholds, value: IndicesTypes.SlowlogTresholdLevels) =
            { state with Fetch = Some value }

    let slowlogTresholds = SlowlogTresholdsBuilder()

    type SoftDeletesBuilder() =
        member _.Yield(_: unit) : SoftDeletes =
            {
                Enabled = None
                RetentionLease = None
            }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: SoftDeletes, value: bool) =
            { state with Enabled = Some value }

        [<CustomOperation("retentionLease")>]
        member _.RetentionLease(state: SoftDeletes, value: IndicesTypes.RetentionLease) =
            { state with RetentionLease = Some value }

    let softDeletes = SoftDeletesBuilder()

    type StorageBuilder() =
        member _.Yield(_: unit) : Storage =
            {
                Type = Unchecked.defaultof<_>
                AllowMmap = None
                StatsRefreshInterval = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Storage, value: IndicesTypes.StorageType) =
            { state with Type = value }

        [<CustomOperation("allowMmap")>]
        member _.AllowMmap(state: Storage, value: bool) =
            { state with AllowMmap = Some value }

        [<CustomOperation("statsRefreshInterval")>]
        member _.StatsRefreshInterval(state: Storage, value: Types.Duration) =
            { state with StatsRefreshInterval = Some value }

    let storage = StorageBuilder()

    type TranslogBuilder() =
        member _.Yield(_: unit) : Translog =
            {
                SyncInterval = None
                Durability = None
                FlushThresholdSize = None
                Retention = None
            }

        [<CustomOperation("syncInterval")>]
        member _.SyncInterval(state: Translog, value: Types.Duration) =
            { state with SyncInterval = Some value }

        [<CustomOperation("durability")>]
        member _.Durability(state: Translog, value: IndicesTypes.TranslogDurability) =
            { state with Durability = Some value }

        [<CustomOperation("flushThresholdSize")>]
        member _.FlushThresholdSize(state: Translog, value: Types.ByteSize) =
            { state with FlushThresholdSize = Some value }

        [<CustomOperation("retention")>]
        member _.Retention(state: Translog, value: IndicesTypes.TranslogRetention) =
            { state with Retention = Some value }

    let translog = TranslogBuilder()

    type TranslogRetentionBuilder() =
        member _.Yield(_: unit) : TranslogRetention =
            {
                Size = None
                Age = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: TranslogRetention, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("age")>]
        member _.Age(state: TranslogRetention, value: Types.Duration) =
            { state with Age = Some value }

    let translogRetention = TranslogRetentionBuilder()

