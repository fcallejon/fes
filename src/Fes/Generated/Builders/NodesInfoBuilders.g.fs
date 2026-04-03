// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module NodesInfoBuilders =

    type NodeInfoBuilder() =
        member _.Yield(_: unit) : Types.NodeInfo =
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
        member _.Attributes(state: Types.NodeInfo, value: Map<string, string>) =
            { state with Attributes = value }

        [<CustomOperation("buildFlavor")>]
        member _.BuildFlavor(state: Types.NodeInfo, value: string) =
            { state with BuildFlavor = value }

        [<CustomOperation("buildHash")>]
        member _.BuildHash(state: Types.NodeInfo, value: string) =
            { state with BuildHash = value }

        [<CustomOperation("buildType")>]
        member _.BuildType(state: Types.NodeInfo, value: string) =
            { state with BuildType = value }

        [<CustomOperation("componentVersions")>]
        member _.ComponentVersions(state: Types.NodeInfo, value: Map<Types.Name, Types.Integer>) =
            { state with ComponentVersions = value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.NodeInfo, value: Types.Host) =
            { state with Host = value }

        [<CustomOperation("http")>]
        member _.Http(state: Types.NodeInfo, value: Types.NodeInfoHttp) =
            { state with Http = Some value }

        [<CustomOperation("indexVersion")>]
        member _.IndexVersion(state: Types.NodeInfo, value: Types.VersionNumber) =
            { state with IndexVersion = value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.NodeInfo, value: Types.Ip) =
            { state with Ip = value }

        [<CustomOperation("jvm")>]
        member _.Jvm(state: Types.NodeInfo, value: Types.NodeJvmInfo) =
            { state with Jvm = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.NodeInfo, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("os")>]
        member _.Os(state: Types.NodeInfo, value: Types.NodeOperatingSystemInfo) =
            { state with Os = Some value }

        [<CustomOperation("plugins")>]
        member _.Plugins(state: Types.NodeInfo, value: Types.PluginStats list) =
            { state with Plugins = Some value }

        [<CustomOperation("process")>]
        member _.Process(state: Types.NodeInfo, value: Types.NodeProcessInfo) =
            { state with Process = Some value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.NodeInfo, value: Types.NodeRoles) =
            { state with Roles = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.NodeInfo, value: Types.NodeInfoSettings) =
            { state with Settings = Some value }

        [<CustomOperation("threadPool")>]
        member _.ThreadPool(state: Types.NodeInfo, value: Map<string, Types.NodeThreadPoolInfo>) =
            { state with ThreadPool = Some value }

        [<CustomOperation("totalIndexingBuffer")>]
        member _.TotalIndexingBuffer(state: Types.NodeInfo, value: Types.Long) =
            { state with TotalIndexingBuffer = Some value }

        [<CustomOperation("totalIndexingBufferInBytes")>]
        member _.TotalIndexingBufferInBytes(state: Types.NodeInfo, value: Types.ByteSize) =
            { state with TotalIndexingBufferInBytes = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: Types.NodeInfo, value: Types.NodeInfoTransport) =
            { state with Transport = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Types.NodeInfo, value: Types.TransportAddress) =
            { state with TransportAddress = value }

        [<CustomOperation("transportVersion")>]
        member _.TransportVersion(state: Types.NodeInfo, value: Types.VersionNumber) =
            { state with TransportVersion = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.NodeInfo, value: Types.VersionString) =
            { state with Version = value }

        [<CustomOperation("modules")>]
        member _.Modules(state: Types.NodeInfo, value: Types.PluginStats list) =
            { state with Modules = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Types.NodeInfo, value: Types.NodeInfoIngest) =
            { state with Ingest = Some value }

        [<CustomOperation("aggregations")>]
        member _.Aggregations(state: Types.NodeInfo, value: Map<string, Types.NodeInfoAggregation>) =
            { state with Aggregations = Some value }

        [<CustomOperation("remoteClusterServer")>]
        member _.RemoteClusterServer(state: Types.NodeInfo, value: Types.RemoveClusterServer) =
            { state with RemoteClusterServer = Some value }

    let nodeInfo = NodeInfoBuilder()

    type NodeInfoDiscoverBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoDiscover =
            {
                SeedHosts = None
                Type = None
                SeedProviders = None
            }

        [<CustomOperation("seedHosts")>]
        member _.SeedHosts(state: Types.NodeInfoDiscover, value: System.Text.Json.JsonElement) =
            { state with SeedHosts = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NodeInfoDiscover, value: string) =
            { state with Type = Some value }

        [<CustomOperation("seedProviders")>]
        member _.SeedProviders(state: Types.NodeInfoDiscover, value: string list) =
            { state with SeedProviders = Some value }

    let nodeInfoDiscover = NodeInfoDiscoverBuilder()

    type NodeInfoJvmMemoryBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoJvmMemory =
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
        member _.DirectMax(state: Types.NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with DirectMax = Some value }

        [<CustomOperation("directMaxInBytes")>]
        member _.DirectMaxInBytes(state: Types.NodeInfoJvmMemory, value: Types.Long) =
            { state with DirectMaxInBytes = value }

        [<CustomOperation("heapInit")>]
        member _.HeapInit(state: Types.NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with HeapInit = Some value }

        [<CustomOperation("heapInitInBytes")>]
        member _.HeapInitInBytes(state: Types.NodeInfoJvmMemory, value: Types.Long) =
            { state with HeapInitInBytes = value }

        [<CustomOperation("heapMax")>]
        member _.HeapMax(state: Types.NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with HeapMax = Some value }

        [<CustomOperation("heapMaxInBytes")>]
        member _.HeapMaxInBytes(state: Types.NodeInfoJvmMemory, value: Types.Long) =
            { state with HeapMaxInBytes = value }

        [<CustomOperation("nonHeapInit")>]
        member _.NonHeapInit(state: Types.NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with NonHeapInit = Some value }

        [<CustomOperation("nonHeapInitInBytes")>]
        member _.NonHeapInitInBytes(state: Types.NodeInfoJvmMemory, value: Types.Long) =
            { state with NonHeapInitInBytes = value }

        [<CustomOperation("nonHeapMax")>]
        member _.NonHeapMax(state: Types.NodeInfoJvmMemory, value: Types.ByteSize) =
            { state with NonHeapMax = Some value }

        [<CustomOperation("nonHeapMaxInBytes")>]
        member _.NonHeapMaxInBytes(state: Types.NodeInfoJvmMemory, value: Types.Long) =
            { state with NonHeapMaxInBytes = value }

    let nodeInfoJvmMemory = NodeInfoJvmMemoryBuilder()

    type NodeInfoPathBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoPath =
            {
                Logs = None
                Home = None
                Repo = None
                Data = None
            }

        [<CustomOperation("logs")>]
        member _.Logs(state: Types.NodeInfoPath, value: string) =
            { state with Logs = Some value }

        [<CustomOperation("home")>]
        member _.Home(state: Types.NodeInfoPath, value: string) =
            { state with Home = Some value }

        [<CustomOperation("repo")>]
        member _.Repo(state: Types.NodeInfoPath, value: string list) =
            { state with Repo = Some value }

        [<CustomOperation("data")>]
        member _.Data(state: Types.NodeInfoPath, value: System.Text.Json.JsonElement) =
            { state with Data = Some value }

    let nodeInfoPath = NodeInfoPathBuilder()

    type NodeInfoSettingsBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoSettings =
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
        member _.Cluster(state: Types.NodeInfoSettings, value: Types.NodeInfoSettingsCluster) =
            { state with Cluster = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.NodeInfoSettings, value: Types.NodeInfoSettingsNode) =
            { state with Node = value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.NodeInfoSettings, value: Types.NodeInfoPath) =
            { state with Path = Some value }

        [<CustomOperation("repositories")>]
        member _.Repositories(state: Types.NodeInfoSettings, value: Types.NodeInfoRepositories) =
            { state with Repositories = Some value }

        [<CustomOperation("discovery")>]
        member _.Discovery(state: Types.NodeInfoSettings, value: Types.NodeInfoDiscover) =
            { state with Discovery = Some value }

        [<CustomOperation("action")>]
        member _.Action(state: Types.NodeInfoSettings, value: Types.NodeInfoAction) =
            { state with Action = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: Types.NodeInfoSettings, value: Types.NodeInfoClient) =
            { state with Client = Some value }

        [<CustomOperation("http")>]
        member _.Http(state: Types.NodeInfoSettings, value: Types.NodeInfoSettingsHttp) =
            { state with Http = value }

        [<CustomOperation("bootstrap")>]
        member _.Bootstrap(state: Types.NodeInfoSettings, value: Types.NodeInfoBootstrap) =
            { state with Bootstrap = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: Types.NodeInfoSettings, value: Types.NodeInfoSettingsTransport) =
            { state with Transport = value }

        [<CustomOperation("network")>]
        member _.Network(state: Types.NodeInfoSettings, value: Types.NodeInfoSettingsNetwork) =
            { state with Network = Some value }

        [<CustomOperation("xpack")>]
        member _.Xpack(state: Types.NodeInfoSettings, value: Types.NodeInfoXpack) =
            { state with Xpack = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.NodeInfoSettings, value: Types.NodeInfoScript) =
            { state with Script = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Types.NodeInfoSettings, value: Types.NodeInfoSearch) =
            { state with Search = Some value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Types.NodeInfoSettings, value: Types.NodeInfoSettingsIngest) =
            { state with Ingest = Some value }

    let nodeInfoSettings = NodeInfoSettingsBuilder()

    type NodeInfoSettingsClusterBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoSettingsCluster =
            {
                Name = Unchecked.defaultof<_>
                Routing = None
                Election = Unchecked.defaultof<_>
                InitialMasterNodes = None
                DeprecationIndexing = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.NodeInfoSettingsCluster, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.NodeInfoSettingsCluster, value: Types.IndexRouting) =
            { state with Routing = Some value }

        [<CustomOperation("election")>]
        member _.Election(state: Types.NodeInfoSettingsCluster, value: Types.NodeInfoSettingsClusterElection) =
            { state with Election = value }

        [<CustomOperation("initialMasterNodes")>]
        member _.InitialMasterNodes(state: Types.NodeInfoSettingsCluster, value: System.Text.Json.JsonElement) =
            { state with InitialMasterNodes = Some value }

        [<CustomOperation("deprecationIndexing")>]
        member _.DeprecationIndexing(state: Types.NodeInfoSettingsCluster, value: Types.DeprecationIndexing) =
            { state with DeprecationIndexing = Some value }

    let nodeInfoSettingsCluster = NodeInfoSettingsClusterBuilder()

    type NodeInfoSettingsHttpBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoSettingsHttp =
            {
                Type = Unchecked.defaultof<_>
                TypeDefault = None
                Compression = None
                Port = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NodeInfoSettingsHttp, value: Types.NodeInfoSettingsHttpType) =
            { state with Type = value }

        [<CustomOperation("typeDefault")>]
        member _.TypeDefault(state: Types.NodeInfoSettingsHttp, value: string) =
            { state with TypeDefault = Some value }

        [<CustomOperation("compression")>]
        member _.Compression(state: Types.NodeInfoSettingsHttp, value: System.Text.Json.JsonElement) =
            { state with Compression = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.NodeInfoSettingsHttp, value: System.Text.Json.JsonElement) =
            { state with Port = Some value }

    let nodeInfoSettingsHttp = NodeInfoSettingsHttpBuilder()

    type NodeInfoSettingsIngestBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoSettingsIngest =
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
        member _.Attachment(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Attachment = Some value }

        [<CustomOperation("append")>]
        member _.Append(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Append = Some value }

        [<CustomOperation("csv")>]
        member _.Csv(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Csv = Some value }

        [<CustomOperation("convert")>]
        member _.Convert(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Convert = Some value }

        [<CustomOperation("date")>]
        member _.Date(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Date = Some value }

        [<CustomOperation("dateIndexName")>]
        member _.DateIndexName(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with DateIndexName = Some value }

        [<CustomOperation("dotExpander")>]
        member _.DotExpander(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with DotExpander = Some value }

        [<CustomOperation("enrich")>]
        member _.Enrich(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Enrich = Some value }

        [<CustomOperation("fail")>]
        member _.Fail(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Fail = Some value }

        [<CustomOperation("foreach")>]
        member _.Foreach(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Foreach = Some value }

        [<CustomOperation("json")>]
        member _.Json(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Json = Some value }

        [<CustomOperation("userAgent")>]
        member _.UserAgent(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with UserAgent = Some value }

        [<CustomOperation("kv")>]
        member _.Kv(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Kv = Some value }

        [<CustomOperation("geoip")>]
        member _.Geoip(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Geoip = Some value }

        [<CustomOperation("grok")>]
        member _.Grok(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Grok = Some value }

        [<CustomOperation("gsub")>]
        member _.Gsub(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Gsub = Some value }

        [<CustomOperation("join")>]
        member _.Join(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Join = Some value }

        [<CustomOperation("lowercase")>]
        member _.Lowercase(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Lowercase = Some value }

        [<CustomOperation("remove")>]
        member _.Remove(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Remove = Some value }

        [<CustomOperation("rename")>]
        member _.Rename(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Rename = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Script = Some value }

        [<CustomOperation("set")>]
        member _.Set(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Set = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Sort = Some value }

        [<CustomOperation("split")>]
        member _.Split(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Split = Some value }

        [<CustomOperation("trim")>]
        member _.Trim(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Trim = Some value }

        [<CustomOperation("uppercase")>]
        member _.Uppercase(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Uppercase = Some value }

        [<CustomOperation("urldecode")>]
        member _.Urldecode(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Urldecode = Some value }

        [<CustomOperation("bytes")>]
        member _.Bytes(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Bytes = Some value }

        [<CustomOperation("dissect")>]
        member _.Dissect(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Dissect = Some value }

        [<CustomOperation("setSecurityUser")>]
        member _.SetSecurityUser(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with SetSecurityUser = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Pipeline = Some value }

        [<CustomOperation("drop")>]
        member _.Drop(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Drop = Some value }

        [<CustomOperation("circle")>]
        member _.Circle(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Circle = Some value }

        [<CustomOperation("inference")>]
        member _.Inference(state: Types.NodeInfoSettingsIngest, value: Types.NodeInfoIngestInfo) =
            { state with Inference = Some value }

    let nodeInfoSettingsIngest = NodeInfoSettingsIngestBuilder()

    type NodeInfoSettingsTransportBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoSettingsTransport =
            {
                Type = Unchecked.defaultof<_>
                TypeDefault = None
                Features = None
                IgnoreDeserializationErrors = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NodeInfoSettingsTransport, value: Types.NodeInfoSettingsTransportType) =
            { state with Type = value }

        [<CustomOperation("typeDefault")>]
        member _.TypeDefault(state: Types.NodeInfoSettingsTransport, value: string) =
            { state with TypeDefault = Some value }

        [<CustomOperation("features")>]
        member _.Features(state: Types.NodeInfoSettingsTransport, value: Types.NodeInfoSettingsTransportFeatures) =
            { state with Features = Some value }

        [<CustomOperation("ignoreDeserializationErrors")>]
        member _.IgnoreDeserializationErrors(state: Types.NodeInfoSettingsTransport, value: Types.Stringified<bool>) =
            { state with IgnoreDeserializationErrors = Some value }

    let nodeInfoSettingsTransport = NodeInfoSettingsTransportBuilder()

    type NodeInfoXpackBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoXpack =
            {
                License = None
                Security = Unchecked.defaultof<_>
                Notification = None
                Ml = None
            }

        [<CustomOperation("license")>]
        member _.License(state: Types.NodeInfoXpack, value: Types.NodeInfoXpackLicense) =
            { state with License = Some value }

        [<CustomOperation("security")>]
        member _.Security(state: Types.NodeInfoXpack, value: Types.NodeInfoXpackSecurity) =
            { state with Security = value }

        [<CustomOperation("notification")>]
        member _.Notification(state: Types.NodeInfoXpack, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Notification = Some value }

        [<CustomOperation("ml")>]
        member _.Ml(state: Types.NodeInfoXpack, value: Types.NodeInfoXpackMl) =
            { state with Ml = Some value }

    let nodeInfoXpack = NodeInfoXpackBuilder()

    type NodeInfoXpackSecurityBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoXpackSecurity =
            {
                Http = None
                Enabled = Unchecked.defaultof<_>
                Transport = None
                Authc = None
            }

        [<CustomOperation("http")>]
        member _.Http(state: Types.NodeInfoXpackSecurity, value: Types.NodeInfoXpackSecuritySsl) =
            { state with Http = Some value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.NodeInfoXpackSecurity, value: string) =
            { state with Enabled = value }

        [<CustomOperation("transport")>]
        member _.Transport(state: Types.NodeInfoXpackSecurity, value: Types.NodeInfoXpackSecuritySsl) =
            { state with Transport = Some value }

        [<CustomOperation("authc")>]
        member _.Authc(state: Types.NodeInfoXpackSecurity, value: Types.NodeInfoXpackSecurityAuthc) =
            { state with Authc = Some value }

    let nodeInfoXpackSecurity = NodeInfoXpackSecurityBuilder()

    type NodeInfoXpackSecurityAuthcBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoXpackSecurityAuthc =
            {
                Realms = None
                Token = None
            }

        [<CustomOperation("realms")>]
        member _.Realms(state: Types.NodeInfoXpackSecurityAuthc, value: Types.NodeInfoXpackSecurityAuthcRealms) =
            { state with Realms = Some value }

        [<CustomOperation("token")>]
        member _.Token(state: Types.NodeInfoXpackSecurityAuthc, value: Types.NodeInfoXpackSecurityAuthcToken) =
            { state with Token = Some value }

    let nodeInfoXpackSecurityAuthc = NodeInfoXpackSecurityAuthcBuilder()

    type NodeInfoXpackSecurityAuthcRealmsBuilder() =
        member _.Yield(_: unit) : Types.NodeInfoXpackSecurityAuthcRealms =
            {
                File = None
                Native = None
                Pki = None
            }

        [<CustomOperation("file")>]
        member _.File(state: Types.NodeInfoXpackSecurityAuthcRealms, value: Map<string, Types.NodeInfoXpackSecurityAuthcRealmsStatus>) =
            { state with File = Some value }

        [<CustomOperation("native")>]
        member _.Native(state: Types.NodeInfoXpackSecurityAuthcRealms, value: Map<string, Types.NodeInfoXpackSecurityAuthcRealmsStatus>) =
            { state with Native = Some value }

        [<CustomOperation("pki")>]
        member _.Pki(state: Types.NodeInfoXpackSecurityAuthcRealms, value: Map<string, Types.NodeInfoXpackSecurityAuthcRealmsStatus>) =
            { state with Pki = Some value }

    let nodeInfoXpackSecurityAuthcRealms = NodeInfoXpackSecurityAuthcRealmsBuilder()

    type NodeOperatingSystemInfoBuilder() =
        member _.Yield(_: unit) : Types.NodeOperatingSystemInfo =
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
        member _.Arch(state: Types.NodeOperatingSystemInfo, value: string) =
            { state with Arch = value }

        [<CustomOperation("availableProcessors")>]
        member _.AvailableProcessors(state: Types.NodeOperatingSystemInfo, value: Types.Integer) =
            { state with AvailableProcessors = value }

        [<CustomOperation("allocatedProcessors")>]
        member _.AllocatedProcessors(state: Types.NodeOperatingSystemInfo, value: Types.Integer) =
            { state with AllocatedProcessors = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.NodeOperatingSystemInfo, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("prettyName")>]
        member _.PrettyName(state: Types.NodeOperatingSystemInfo, value: Types.Name) =
            { state with PrettyName = value }

        [<CustomOperation("refreshIntervalInMillis")>]
        member _.RefreshIntervalInMillis(state: Types.NodeOperatingSystemInfo, value: Types.DurationValue<Types.UnitMillis>) =
            { state with RefreshIntervalInMillis = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.NodeOperatingSystemInfo, value: Types.VersionString) =
            { state with Version = value }

        [<CustomOperation("cpu")>]
        member _.Cpu(state: Types.NodeOperatingSystemInfo, value: Types.NodeInfoOSCPU) =
            { state with Cpu = Some value }

        [<CustomOperation("mem")>]
        member _.Mem(state: Types.NodeOperatingSystemInfo, value: Types.NodeInfoMemory) =
            { state with Mem = Some value }

        [<CustomOperation("swap")>]
        member _.Swap(state: Types.NodeOperatingSystemInfo, value: Types.NodeInfoMemory) =
            { state with Swap = Some value }

    let nodeOperatingSystemInfo = NodeOperatingSystemInfoBuilder()

    type NodeThreadPoolInfoBuilder() =
        member _.Yield(_: unit) : Types.NodeThreadPoolInfo =
            {
                Core = None
                KeepAlive = None
                Max = None
                QueueSize = Unchecked.defaultof<_>
                Size = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("core")>]
        member _.Core(state: Types.NodeThreadPoolInfo, value: Types.Integer) =
            { state with Core = Some value }

        [<CustomOperation("keepAlive")>]
        member _.KeepAlive(state: Types.NodeThreadPoolInfo, value: Types.Duration) =
            { state with KeepAlive = Some value }

        [<CustomOperation("max")>]
        member _.Max(state: Types.NodeThreadPoolInfo, value: Types.Integer) =
            { state with Max = Some value }

        [<CustomOperation("queueSize")>]
        member _.QueueSize(state: Types.NodeThreadPoolInfo, value: Types.Integer) =
            { state with QueueSize = value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.NodeThreadPoolInfo, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.NodeThreadPoolInfo, value: string) =
            { state with Type = value }

    let nodeThreadPoolInfo = NodeThreadPoolInfoBuilder()

