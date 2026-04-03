// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module NodesInfoBuilders =

    type NodeInfoBuilder() =
        member _.Yield(_: unit) : NodeInfo =
            {
                Attributes = Unchecked.defaultof<_>
                BuildFlavor = Unchecked.defaultof<_>
                BuildHash = Unchecked.defaultof<_>
                BuildType = Unchecked.defaultof<_>
                ComponentVersions = Unchecked.defaultof<_>
                Host = Unchecked.defaultof<_>
                Http = None
                IndexVersion = Unchecked.defaultof<_>
                Ip = Unchecked.defaultof<_>
                Jvm = None
                Name = Unchecked.defaultof<_>
                Os = None
                Plugins = None
                Process = None
                Roles = Unchecked.defaultof<_>
                Settings = None
                ThreadPool = None
                TotalIndexingBuffer = None
                TotalIndexingBufferInBytes = None
                Transport = None
                TransportAddress = Unchecked.defaultof<_>
                TransportVersion = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                Modules = None
                Ingest = None
                Aggregations = None
                RemoteClusterServer = None
            }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: NodeInfo, value: Map<string, string>) =
            { state with Attributes = value }

        [<CustomOperation("buildFlavor")>]
        member _.BuildFlavor(state: NodeInfo, value: string) =
            { state with BuildFlavor = value }

        [<CustomOperation("buildHash")>]
        member _.BuildHash(state: NodeInfo, value: string) =
            { state with BuildHash = value }

        [<CustomOperation("buildType")>]
        member _.BuildType(state: NodeInfo, value: string) =
            { state with BuildType = value }

        [<CustomOperation("componentVersions")>]
        member _.ComponentVersions(state: NodeInfo, value: Map<Types.Name, Types.Integer>) =
            { state with ComponentVersions = value }

        [<CustomOperation("host")>]
        member _.Host(state: NodeInfo, value: Types.Host) =
            { state with Host = value }

        [<CustomOperation("http")>]
        member _.Http(state: NodeInfo, value: NodesInfo.NodeInfoHttp) =
            { state with Http = Some value }

        [<CustomOperation("indexVersion")>]
        member _.IndexVersion(state: NodeInfo, value: Types.VersionNumber) =
            { state with IndexVersion = value }

        [<CustomOperation("ip")>]
        member _.Ip(state: NodeInfo, value: Types.Ip) =
            { state with Ip = value }

        [<CustomOperation("jvm")>]
        member _.Jvm(state: NodeInfo, value: NodesInfo.NodeJvmInfo) =
            { state with Jvm = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: NodeInfo, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("os")>]
        member _.Os(state: NodeInfo, value: NodesInfo.NodeOperatingSystemInfo) =
            { state with Os = Some value }

        [<CustomOperation("plugins")>]
        member _.Plugins(state: NodeInfo, value: Types.PluginStats list) =
            { state with Plugins = Some value }

        [<CustomOperation("process")>]
        member _.Process(state: NodeInfo, value: NodesInfo.NodeProcessInfo) =
            { state with Process = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: NodeInfo, value: Types.NodeRoles) =
            { state with Roles = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: NodeInfo, value: NodesInfo.NodeInfoSettings) =
            { state with Settings = Some value }

        [<CustomOperation("threadPool")>]
        member _.ThreadPool(state: NodeInfo, value: Map<string, NodesInfo.NodeThreadPoolInfo>) =
            { state with ThreadPool = Some value }

        [<CustomOperation("totalIndexingBuffer")>]
        member _.TotalIndexingBuffer(state: NodeInfo, value: Types.Long) =
            { state with TotalIndexingBuffer = Some value }

        [<CustomOperation("totalIndexingBufferInBytes")>]
        member _.TotalIndexingBufferInBytes(state: NodeInfo, value: Types.ByteSize) =
            { state with TotalIndexingBufferInBytes = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: NodeInfo, value: NodesInfo.NodeInfoTransport) =
            { state with Transport = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: NodeInfo, value: Types.TransportAddress) =
            { state with TransportAddress = value }

        [<CustomOperation("transportVersion")>]
        member _.TransportVersion(state: NodeInfo, value: Types.VersionNumber) =
            { state with TransportVersion = value }

        [<CustomOperation("version")>]
        member _.Version(state: NodeInfo, value: Types.VersionString) =
            { state with Version = value }

        [<CustomOperation("modules")>]
        member _.Modules(state: NodeInfo, value: Types.PluginStats list) =
            { state with Modules = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: NodeInfo, value: NodesInfo.NodeInfoIngest) =
            { state with Ingest = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: NodeInfo, value: Map<string, NodesInfo.NodeInfoAggregation>) =
            { state with Aggregations = Some value }

        [<CustomOperation("remoteClusterServer")>]
        member _.RemoteClusterServer(state: NodeInfo, value: NodesInfo.RemoveClusterServer) =
            { state with RemoteClusterServer = Some value }

    let nodeInfo = NodeInfoBuilder()

    type NodeInfoDiscoverBuilder() =
        member _.Yield(_: unit) : NodeInfoDiscover =
            {
                SeedHosts = None
                Type = None
                SeedProviders = None
            }

        [<CustomOperation("seedHosts")>]
        member _.SeedHosts(state: NodeInfoDiscover, value: System.Text.Json.JsonElement) =
            { state with SeedHosts = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: NodeInfoDiscover, value: string) =
            { state with Type = Some value }

        [<CustomOperation("seedProviders")>]
        member _.SeedProviders(state: NodeInfoDiscover, value: string list) =
            { state with SeedProviders = Some value }

    let nodeInfoDiscover = NodeInfoDiscoverBuilder()

    type NodeInfoJvmMemoryBuilder() =
        member _.Yield(_: unit) : NodeInfoJvmMemory =
            {
                DirectMax = None
                DirectMaxInBytes = Unchecked.defaultof<_>
                HeapInit = None
                HeapInitInBytes = Unchecked.defaultof<_>
                HeapMax = None
                HeapMaxInBytes = Unchecked.defaultof<_>
                NonHeapInit = None
                NonHeapInitInBytes = Unchecked.defaultof<_>
                NonHeapMax = None
                NonHeapMaxInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("directMax")>]
        member _.DirectMax(state: NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with DirectMax = Some value }

        [<CustomOperation("directMaxInBytes")>]
        member _.DirectMaxInBytes(state: NodeInfoJvmMemory, value: Types.Long) =
            { state with DirectMaxInBytes = value }

        [<CustomOperation("heapInit")>]
        member _.HeapInit(state: NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with HeapInit = Some value }

        [<CustomOperation("heapInitInBytes")>]
        member _.HeapInitInBytes(state: NodeInfoJvmMemory, value: Types.Long) =
            { state with HeapInitInBytes = value }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with HeapMax = Some value }

        [<CustomOperation("heapMaxInBytes")>]
        member _.HeapMaxInBytes(state: NodeInfoJvmMemory, value: Types.Long) =
            { state with HeapMaxInBytes = value }

        [<CustomOperation("nonHeapInit")>]
        member _.NonHeapInit(state: NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with NonHeapInit = Some value }

        [<CustomOperation("nonHeapInitInBytes")>]
        member _.NonHeapInitInBytes(state: NodeInfoJvmMemory, value: Types.Long) =
            { state with NonHeapInitInBytes = value }

        [<CustomOperation("nonHeapMax")>]
        member _.NonHeapMax(state: NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with NonHeapMax = Some value }

        [<CustomOperation("nonHeapMaxInBytes")>]
        member _.NonHeapMaxInBytes(state: NodeInfoJvmMemory, value: Types.Long) =
            { state with NonHeapMaxInBytes = value }

    let nodeInfoJvmMemory = NodeInfoJvmMemoryBuilder()

    type NodeInfoPathBuilder() =
        member _.Yield(_: unit) : NodeInfoPath =
            {
                Logs = None
                Home = None
                Repo = None
                Data = None
            }

        [<CustomOperation("logs")>]
        member _.Logs(state: NodeInfoPath, value: string) =
            { state with Logs = Some value }

        [<CustomOperation("home")>]
        member _.Home(state: NodeInfoPath, value: string) =
            { state with Home = Some value }

        [<CustomOperation("repo")>]
        member _.Repo(state: NodeInfoPath, value: string list) =
            { state with Repo = Some value }

        [<CustomOperation("data")>]
        member _.Data(state: NodeInfoPath, value: System.Text.Json.JsonElement) =
            { state with Data = Some value }

    let nodeInfoPath = NodeInfoPathBuilder()

    type NodeInfoSettingsBuilder() =
        member _.Yield(_: unit) : NodeInfoSettings =
            {
                Cluster = Unchecked.defaultof<_>
                Node = Unchecked.defaultof<_>
                Path = None
                Repositories = None
                Discovery = None
                Action = None
                Client = None
                Http = Unchecked.defaultof<_>
                Bootstrap = None
                Transport = Unchecked.defaultof<_>
                Network = None
                Xpack = None
                Script = None
                Search = None
                Ingest = None
            }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: NodeInfoSettings, value: NodesInfo.NodeInfoSettingsCluster) =
            { state with Cluster = value }

        [<CustomOperation("node")>]
        member _.Node(state: NodeInfoSettings, value: NodesInfo.NodeInfoSettingsNode) =
            { state with Node = value }

        [<CustomOperation("path")>]
        member _.Path(state: NodeInfoSettings, value: NodesInfo.NodeInfoPath) =
            { state with Path = Some value }

        [<CustomOperation("repositories")>]
        member _.Repositories(state: NodeInfoSettings, value: NodesInfo.NodeInfoRepositories) =
            { state with Repositories = Some value }

        [<CustomOperation("discovery")>]
        member _.Discovery(state: NodeInfoSettings, value: NodesInfo.NodeInfoDiscover) =
            { state with Discovery = Some value }

        [<CustomOperation("action")>]
        member _.Action(state: NodeInfoSettings, value: NodesInfo.NodeInfoAction) =
            { state with Action = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: NodeInfoSettings, value: NodesInfo.NodeInfoClient) =
            { state with Client = Some value }

        [<CustomOperation("http")>]
        member _.Http(state: NodeInfoSettings, value: NodesInfo.NodeInfoSettingsHttp) =
            { state with Http = value }

        [<CustomOperation("bootstrap")>]
        member _.Bootstrap(state: NodeInfoSettings, value: NodesInfo.NodeInfoBootstrap) =
            { state with Bootstrap = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: NodeInfoSettings, value: NodesInfo.NodeInfoSettingsTransport) =
            { state with Transport = value }

        [<CustomOperation("network")>]
        member _.Network(state: NodeInfoSettings, value: NodesInfo.NodeInfoSettingsNetwork) =
            { state with Network = Some value }

        [<CustomOperation("xpack")>]
        member _.Xpack(state: NodeInfoSettings, value: NodesInfo.NodeInfoXpack) =
            { state with Xpack = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: NodeInfoSettings, value: NodesInfo.NodeInfoScript) =
            { state with Script = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: NodeInfoSettings, value: NodesInfo.NodeInfoSearch) =
            { state with Search = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: NodeInfoSettings, value: NodesInfo.NodeInfoSettingsIngest) =
            { state with Ingest = Some value }

    let nodeInfoSettings = NodeInfoSettingsBuilder()

    type NodeInfoSettingsClusterBuilder() =
        member _.Yield(_: unit) : NodeInfoSettingsCluster =
            {
                Name = Unchecked.defaultof<_>
                Routing = None
                Election = Unchecked.defaultof<_>
                InitialMasterNodes = None
                DeprecationIndexing = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: NodeInfoSettingsCluster, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: NodeInfoSettingsCluster, value: IndicesTypes.IndexRouting) =
            { state with Routing = Some value }

        [<CustomOperation("election")>]
        member _.Election(state: NodeInfoSettingsCluster, value: NodesInfo.NodeInfoSettingsClusterElection) =
            { state with Election = value }

        [<CustomOperation("initialMasterNodes")>]
        member _.InitialMasterNodes(state: NodeInfoSettingsCluster, value: System.Text.Json.JsonElement) =
            { state with InitialMasterNodes = Some value }

        [<CustomOperation("deprecationIndexing")>]
        member _.DeprecationIndexing(state: NodeInfoSettingsCluster, value: NodesInfo.DeprecationIndexing) =
            { state with DeprecationIndexing = Some value }

    let nodeInfoSettingsCluster = NodeInfoSettingsClusterBuilder()

    type NodeInfoSettingsHttpBuilder() =
        member _.Yield(_: unit) : NodeInfoSettingsHttp =
            {
                Type = Unchecked.defaultof<_>
                TypeDefault = None
                Compression = None
                Port = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NodeInfoSettingsHttp, value: NodesInfo.NodeInfoSettingsHttpType) =
            { state with Type = value }

        [<CustomOperation("typeDefault")>]
        member _.TypeDefault(state: NodeInfoSettingsHttp, value: string) =
            { state with TypeDefault = Some value }

        [<CustomOperation("compression")>]
        member _.Compression(state: NodeInfoSettingsHttp, value: System.Text.Json.JsonElement) =
            { state with Compression = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: NodeInfoSettingsHttp, value: System.Text.Json.JsonElement) =
            { state with Port = Some value }

    let nodeInfoSettingsHttp = NodeInfoSettingsHttpBuilder()

    type NodeInfoSettingsIngestBuilder() =
        member _.Yield(_: unit) : NodeInfoSettingsIngest =
            {
                Attachment = None
                Append = None
                Csv = None
                Convert = None
                Date = None
                DateIndexName = None
                DotExpander = None
                Enrich = None
                Fail = None
                Foreach = None
                Json = None
                UserAgent = None
                Kv = None
                Geoip = None
                Grok = None
                Gsub = None
                Join = None
                Lowercase = None
                Remove = None
                Rename = None
                Script = None
                Set = None
                Sort = None
                Split = None
                Trim = None
                Uppercase = None
                Urldecode = None
                Bytes = None
                Dissect = None
                SetSecurityUser = None
                Pipeline = None
                Drop = None
                Circle = None
                Inference = None
            }

        [<CustomOperation("attachment")>]
        member _.Attachment(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Attachment = Some value }

        [<CustomOperation("append")>]
        member _.Append(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Append = Some value }

        [<CustomOperation("csv")>]
        member _.Csv(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Csv = Some value }

        [<CustomOperation("convert")>]
        member _.Convert(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Convert = Some value }

        [<CustomOperation("date")>]
        member _.Date(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Date = Some value }

        [<CustomOperation("dateIndexName")>]
        member _.DateIndexName(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with DateIndexName = Some value }

        [<CustomOperation("dotExpander")>]
        member _.DotExpander(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with DotExpander = Some value }

        [<CustomOperation("enrich")>]
        member _.Enrich(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Enrich = Some value }

        [<CustomOperation("fail")>]
        member _.Fail(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Fail = Some value }

        [<CustomOperation("foreach")>]
        member _.Foreach(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Foreach = Some value }

        [<CustomOperation("json")>]
        member _.Json(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Json = Some value }

        [<CustomOperation("userAgent")>]
        member _.UserAgent(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with UserAgent = Some value }

        [<CustomOperation("kv")>]
        member _.Kv(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Kv = Some value }

        [<CustomOperation("geoip")>]
        member _.Geoip(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Geoip = Some value }

        [<CustomOperation("grok")>]
        member _.Grok(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Grok = Some value }

        [<CustomOperation("gsub")>]
        member _.Gsub(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Gsub = Some value }

        [<CustomOperation("join")>]
        member _.Join(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Join = Some value }

        [<CustomOperation("lowercase")>]
        member _.Lowercase(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Lowercase = Some value }

        [<CustomOperation("remove")>]
        member _.Remove(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Remove = Some value }

        [<CustomOperation("rename")>]
        member _.Rename(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Rename = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Script = Some value }

        [<CustomOperation("set")>]
        member _.Set(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Set = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Sort = Some value }

        [<CustomOperation("split")>]
        member _.Split(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Split = Some value }

        [<CustomOperation("trim")>]
        member _.Trim(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Trim = Some value }

        [<CustomOperation("uppercase")>]
        member _.Uppercase(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Uppercase = Some value }

        [<CustomOperation("urldecode")>]
        member _.Urldecode(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Urldecode = Some value }

        [<CustomOperation("bytes")>]
        member _.Bytes(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Bytes = Some value }

        [<CustomOperation("dissect")>]
        member _.Dissect(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Dissect = Some value }

        [<CustomOperation("setSecurityUser")>]
        member _.SetSecurityUser(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with SetSecurityUser = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Pipeline = Some value }

        [<CustomOperation("drop")>]
        member _.Drop(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Drop = Some value }

        [<CustomOperation("circle")>]
        member _.Circle(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Circle = Some value }

        [<CustomOperation("inference")>]
        member _.Inference(state: NodeInfoSettingsIngest, value: NodesInfo.NodeInfoIngestInfo) =
            { state with Inference = Some value }

    let nodeInfoSettingsIngest = NodeInfoSettingsIngestBuilder()

    type NodeInfoSettingsTransportBuilder() =
        member _.Yield(_: unit) : NodeInfoSettingsTransport =
            {
                Type = Unchecked.defaultof<_>
                TypeDefault = None
                Features = None
                IgnoreDeserializationErrors = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: NodeInfoSettingsTransport, value: NodesInfo.NodeInfoSettingsTransportType) =
            { state with Type = value }

        [<CustomOperation("typeDefault")>]
        member _.TypeDefault(state: NodeInfoSettingsTransport, value: string) =
            { state with TypeDefault = Some value }

        [<CustomOperation("features")>]
        member _.Features(state: NodeInfoSettingsTransport, value: NodesInfo.NodeInfoSettingsTransportFeatures) =
            { state with Features = Some value }

        [<CustomOperation("ignoreDeserializationErrors")>]
        member _.IgnoreDeserializationErrors(state: NodeInfoSettingsTransport, value: SpecUtils.Stringified<bool>) =
            { state with IgnoreDeserializationErrors = Some value }

    let nodeInfoSettingsTransport = NodeInfoSettingsTransportBuilder()

    type NodeInfoXpackBuilder() =
        member _.Yield(_: unit) : NodeInfoXpack =
            {
                License = None
                Security = Unchecked.defaultof<_>
                Notification = None
                Ml = None
            }

        [<CustomOperation("license")>]
        member _.License(state: NodeInfoXpack, value: NodesInfo.NodeInfoXpackLicense) =
            { state with License = Some value }

        [<CustomOperation("security")>]
        member _.Security(state: NodeInfoXpack, value: NodesInfo.NodeInfoXpackSecurity) =
            { state with Security = value }

        [<CustomOperation("notification")>]
        member _.Notification(state: NodeInfoXpack, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Notification = Some value }

        [<CustomOperation("ml")>]
        member _.Ml(state: NodeInfoXpack, value: NodesInfo.NodeInfoXpackMl) =
            { state with Ml = Some value }

    let nodeInfoXpack = NodeInfoXpackBuilder()

    type NodeInfoXpackSecurityBuilder() =
        member _.Yield(_: unit) : NodeInfoXpackSecurity =
            {
                Http = None
                Enabled = Unchecked.defaultof<_>
                Transport = None
                Authc = None
            }

        [<CustomOperation("http")>]
        member _.Http(state: NodeInfoXpackSecurity, value: NodesInfo.NodeInfoXpackSecuritySsl) =
            { state with Http = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: NodeInfoXpackSecurity, value: string) =
            { state with Enabled = value }

        [<CustomOperation("transport")>]
        member _.Transport(state: NodeInfoXpackSecurity, value: NodesInfo.NodeInfoXpackSecuritySsl) =
            { state with Transport = Some value }

        [<CustomOperation("authc")>]
        member _.Authc(state: NodeInfoXpackSecurity, value: NodesInfo.NodeInfoXpackSecurityAuthc) =
            { state with Authc = Some value }

    let nodeInfoXpackSecurity = NodeInfoXpackSecurityBuilder()

    type NodeInfoXpackSecurityAuthcBuilder() =
        member _.Yield(_: unit) : NodeInfoXpackSecurityAuthc =
            {
                Realms = None
                Token = None
            }

        [<CustomOperation("realms")>]
        member _.Realms(state: NodeInfoXpackSecurityAuthc, value: NodesInfo.NodeInfoXpackSecurityAuthcRealms) =
            { state with Realms = Some value }

        [<CustomOperation("token")>]
        member _.Token(state: NodeInfoXpackSecurityAuthc, value: NodesInfo.NodeInfoXpackSecurityAuthcToken) =
            { state with Token = Some value }

    let nodeInfoXpackSecurityAuthc = NodeInfoXpackSecurityAuthcBuilder()

    type NodeInfoXpackSecurityAuthcRealmsBuilder() =
        member _.Yield(_: unit) : NodeInfoXpackSecurityAuthcRealms =
            {
                File = None
                Native = None
                Pki = None
            }

        [<CustomOperation("file")>]
        member _.File(state: NodeInfoXpackSecurityAuthcRealms, value: Map<string, NodesInfo.NodeInfoXpackSecurityAuthcRealmsStatus>) =
            { state with File = Some value }

        [<CustomOperation("native")>]
        member _.Native(state: NodeInfoXpackSecurityAuthcRealms, value: Map<string, NodesInfo.NodeInfoXpackSecurityAuthcRealmsStatus>) =
            { state with Native = Some value }

        [<CustomOperation("pki")>]
        member _.Pki(state: NodeInfoXpackSecurityAuthcRealms, value: Map<string, NodesInfo.NodeInfoXpackSecurityAuthcRealmsStatus>) =
            { state with Pki = Some value }

    let nodeInfoXpackSecurityAuthcRealms = NodeInfoXpackSecurityAuthcRealmsBuilder()

    type NodeOperatingSystemInfoBuilder() =
        member _.Yield(_: unit) : NodeOperatingSystemInfo =
            {
                Arch = Unchecked.defaultof<_>
                AvailableProcessors = Unchecked.defaultof<_>
                AllocatedProcessors = None
                Name = Unchecked.defaultof<_>
                PrettyName = Unchecked.defaultof<_>
                RefreshIntervalInMillis = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                Cpu = None
                Mem = None
                Swap = None
            }

        [<CustomOperation("arch")>]
        member _.Arch(state: NodeOperatingSystemInfo, value: string) =
            { state with Arch = value }

        [<CustomOperation("availableProcessors")>]
        member _.AvailableProcessors(state: NodeOperatingSystemInfo, value: Types.Integer) =
            { state with AvailableProcessors = value }

        [<CustomOperation("allocatedProcessors")>]
        member _.AllocatedProcessors(state: NodeOperatingSystemInfo, value: Types.Integer) =
            { state with AllocatedProcessors = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: NodeOperatingSystemInfo, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("prettyName")>]
        member _.PrettyName(state: NodeOperatingSystemInfo, value: Types.Name) =
            { state with PrettyName = value }

        [<CustomOperation("refreshIntervalInMillis")>]
        member _.RefreshIntervalInMillis(state: NodeOperatingSystemInfo, value: Types.DurationValue<Types.UnitMillis>) =
            { state with RefreshIntervalInMillis = value }

        [<CustomOperation("version")>]
        member _.Version(state: NodeOperatingSystemInfo, value: Types.VersionString) =
            { state with Version = value }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: NodeOperatingSystemInfo, value: NodesInfo.NodeInfoOSCPU) =
            { state with Cpu = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: NodeOperatingSystemInfo, value: NodesInfo.NodeInfoMemory) =
            { state with Mem = Some value }

        [<CustomOperation("swap")>]
        member _.Swap(state: NodeOperatingSystemInfo, value: NodesInfo.NodeInfoMemory) =
            { state with Swap = Some value }

    let nodeOperatingSystemInfo = NodeOperatingSystemInfoBuilder()

    type NodeThreadPoolInfoBuilder() =
        member _.Yield(_: unit) : NodeThreadPoolInfo =
            {
                Core = None
                KeepAlive = None
                Max = None
                QueueSize = Unchecked.defaultof<_>
                Size = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("core")>]
        member _.Core(state: NodeThreadPoolInfo, value: Types.Integer) =
            { state with Core = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: NodeThreadPoolInfo, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("max")>]
        member _.Max(state: NodeThreadPoolInfo, value: Types.Integer) =
            { state with Max = Some value }

        [<CustomOperation("queueSize")>]
        member _.QueueSize(state: NodeThreadPoolInfo, value: Types.Integer) =
            { state with QueueSize = value }

        [<CustomOperation("size")>]
        member _.Size(state: NodeThreadPoolInfo, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: NodeThreadPoolInfo, value: string) =
            { state with Type = value }

    let nodeThreadPoolInfo = NodeThreadPoolInfoBuilder()

