// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module NodesInfo =

    type DeprecationIndexing = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: System.Text.Json.JsonElement
    }

    type NodeInfoHttp = {
        [<System.Text.Json.Serialization.JsonPropertyName("bound_address")>]
        BoundAddress: string list
        [<System.Text.Json.Serialization.JsonPropertyName("max_content_length")>]
        MaxContentLength: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_content_length_in_bytes")>]
        MaxContentLengthInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("publish_address")>]
        PublishAddress: string
    }

    type NodeInfoJvmMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("direct_max")>]
        DirectMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("direct_max_in_bytes")>]
        DirectMaxInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_init")>]
        HeapInit: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_init_in_bytes")>]
        HeapInitInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_init")>]
        NonHeapInit: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_init_in_bytes")>]
        NonHeapInitInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_max")>]
        NonHeapMax: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_max_in_bytes")>]
        NonHeapMaxInBytes: CoreTypes.Long
    }

    type NodeJvmInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("gc_collectors")>]
        GcCollectors: string list
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodeInfoJvmMemory
        [<System.Text.Json.Serialization.JsonPropertyName("memory_pools")>]
        MemoryPools: string list
        [<System.Text.Json.Serialization.JsonPropertyName("pid")>]
        Pid: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("vm_name")>]
        VmName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("vm_vendor")>]
        VmVendor: string
        [<System.Text.Json.Serialization.JsonPropertyName("vm_version")>]
        VmVersion: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("using_bundled_jdk")>]
        UsingBundledJdk: bool
        [<System.Text.Json.Serialization.JsonPropertyName("using_compressed_ordinary_object_pointers")>]
        UsingCompressedOrdinaryObjectPointers: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("input_arguments")>]
        InputArguments: string list
    }

    type NodeInfoOSCPU = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: string
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size_in_bytes")>]
        CacheSizeInBytes: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("cores_per_socket")>]
        CoresPerSocket: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("mhz")>]
        Mhz: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_cores")>]
        TotalCores: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_sockets")>]
        TotalSockets: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("vendor")>]
        Vendor: string
    }

    type NodeInfoMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: CoreTypes.Long
    }

    type NodeOperatingSystemInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("arch")>]
        Arch: string
        [<System.Text.Json.Serialization.JsonPropertyName("available_processors")>]
        AvailableProcessors: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("allocated_processors")>]
        AllocatedProcessors: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("pretty_name")>]
        PrettyName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_interval_in_millis")>]
        RefreshIntervalInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: NodeInfoOSCPU option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodeInfoMemory option
        [<System.Text.Json.Serialization.JsonPropertyName("swap")>]
        Swap: NodeInfoMemory option
    }

    type NodeProcessInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("mlockall")>]
        Mlockall: bool
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_interval_in_millis")>]
        RefreshIntervalInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis>
    }

    type NodeInfoSettingsClusterElection = {
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: CoreTypes.Name
    }

    type NodeInfoSettingsCluster = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndicesTypes.IndexRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("election")>]
        Election: NodeInfoSettingsClusterElection
        [<System.Text.Json.Serialization.JsonPropertyName("initial_master_nodes")>]
        InitialMasterNodes: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecation_indexing")>]
        DeprecationIndexing: DeprecationIndexing option
    }

    type NodeInfoSettingsNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("attr")>]
        Attr: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("max_local_storage_nodes")>]
        MaxLocalStorageNodes: string option
    }

    type NodeInfoPath = {
        [<System.Text.Json.Serialization.JsonPropertyName("logs")>]
        Logs: string option
        [<System.Text.Json.Serialization.JsonPropertyName("home")>]
        Home: string option
        [<System.Text.Json.Serialization.JsonPropertyName("repo")>]
        Repo: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: System.Text.Json.JsonElement option
    }

    type NodeInfoRepositoriesUrl = {
        [<System.Text.Json.Serialization.JsonPropertyName("allowed_urls")>]
        AllowedUrls: string
    }

    type NodeInfoRepositories = {
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: NodeInfoRepositoriesUrl
    }

    type NodeInfoDiscover = {
        [<System.Text.Json.Serialization.JsonPropertyName("seed_hosts")>]
        SeedHosts: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
        [<System.Text.Json.Serialization.JsonPropertyName("seed_providers")>]
        SeedProviders: string list option
    }

    type NodeInfoAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("destructive_requires_name")>]
        DestructiveRequiresName: string
    }

    type NodeInfoClient = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type NodeInfoSettingsHttpType = {
        [<System.Text.Json.Serialization.JsonPropertyName("default")>]
        Default: string
    }

    type NodeInfoSettingsHttp = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: NodeInfoSettingsHttpType
        [<System.Text.Json.Serialization.JsonPropertyName("type.default")>]
        TypeDefault: string option
        [<System.Text.Json.Serialization.JsonPropertyName("compression")>]
        Compression: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: System.Text.Json.JsonElement option
    }

    type NodeInfoBootstrap = {
        [<System.Text.Json.Serialization.JsonPropertyName("memory_lock")>]
        MemoryLock: string
    }

    type NodeInfoSettingsTransportType = {
        [<System.Text.Json.Serialization.JsonPropertyName("default")>]
        Default: string
    }

    type NodeInfoSettingsTransportFeatures = {
        [<System.Text.Json.Serialization.JsonPropertyName("x-pack")>]
        XPack: string
    }

    type NodeInfoSettingsTransport = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: NodeInfoSettingsTransportType
        [<System.Text.Json.Serialization.JsonPropertyName("type.default")>]
        TypeDefault: string option
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: NodeInfoSettingsTransportFeatures option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_deserialization_errors")>]
        IgnoreDeserializationErrors: CoreTypes.Stringified<bool> option
    }

    type NodeInfoSettingsNetwork = {
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: System.Text.Json.JsonElement option
    }

    type NodeInfoXpackLicenseType = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type NodeInfoXpackLicense = {
        [<System.Text.Json.Serialization.JsonPropertyName("self_generated")>]
        SelfGenerated: NodeInfoXpackLicenseType
    }

    type NodeInfoXpackSecuritySsl = {
        [<System.Text.Json.Serialization.JsonPropertyName("ssl")>]
        Ssl: Map<string, string>
    }

    type NodeInfoXpackSecurityAuthcRealmsStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string option
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: string
    }

    type NodeInfoXpackSecurityAuthcRealms = {
        [<System.Text.Json.Serialization.JsonPropertyName("file")>]
        File: Map<string, NodeInfoXpackSecurityAuthcRealmsStatus> option
        [<System.Text.Json.Serialization.JsonPropertyName("native")>]
        Native: Map<string, NodeInfoXpackSecurityAuthcRealmsStatus> option
        [<System.Text.Json.Serialization.JsonPropertyName("pki")>]
        Pki: Map<string, NodeInfoXpackSecurityAuthcRealmsStatus> option
    }

    type NodeInfoXpackSecurityAuthcToken = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string
    }

    type NodeInfoXpackSecurityAuthc = {
        [<System.Text.Json.Serialization.JsonPropertyName("realms")>]
        Realms: NodeInfoXpackSecurityAuthcRealms option
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: NodeInfoXpackSecurityAuthcToken option
    }

    type NodeInfoXpackSecurity = {
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodeInfoXpackSecuritySsl option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodeInfoXpackSecuritySsl option
        [<System.Text.Json.Serialization.JsonPropertyName("authc")>]
        Authc: NodeInfoXpackSecurityAuthc option
    }

    type NodeInfoXpackMl = {
        [<System.Text.Json.Serialization.JsonPropertyName("use_auto_machine_memory_percent")>]
        UseAutoMachineMemoryPercent: bool option
    }

    type NodeInfoXpack = {
        [<System.Text.Json.Serialization.JsonPropertyName("license")>]
        License: NodeInfoXpackLicense option
        [<System.Text.Json.Serialization.JsonPropertyName("security")>]
        Security: NodeInfoXpackSecurity
        [<System.Text.Json.Serialization.JsonPropertyName("notification")>]
        Notification: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: NodeInfoXpackMl option
    }

    type NodeInfoScript = {
        [<System.Text.Json.Serialization.JsonPropertyName("allowed_types")>]
        AllowedTypes: string
        [<System.Text.Json.Serialization.JsonPropertyName("disable_max_compilations_rate")>]
        DisableMaxCompilationsRate: string option
    }

    type NodeInfoSearchRemote = {
        [<System.Text.Json.Serialization.JsonPropertyName("connect")>]
        Connect: string
    }

    type NodeInfoSearch = {
        [<System.Text.Json.Serialization.JsonPropertyName("remote")>]
        Remote: NodeInfoSearchRemote
    }

    type NodeInfoIngestDownloader = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string
    }

    type NodeInfoIngestInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("downloader")>]
        Downloader: NodeInfoIngestDownloader
    }

    type NodeInfoSettingsIngest = {
        [<System.Text.Json.Serialization.JsonPropertyName("attachment")>]
        Attachment: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("append")>]
        Append: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("csv")>]
        Csv: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("convert")>]
        Convert: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("date")>]
        Date: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("date_index_name")>]
        DateIndexName: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("dot_expander")>]
        DotExpander: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("enrich")>]
        Enrich: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("fail")>]
        Fail: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("foreach")>]
        Foreach: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("json")>]
        Json: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("user_agent")>]
        UserAgent: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("kv")>]
        Kv: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("geoip")>]
        Geoip: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("grok")>]
        Grok: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("gsub")>]
        Gsub: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("join")>]
        Join: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("lowercase")>]
        Lowercase: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("remove")>]
        Remove: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("rename")>]
        Rename: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("set")>]
        Set: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("split")>]
        Split: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("trim")>]
        Trim: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("uppercase")>]
        Uppercase: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("urldecode")>]
        Urldecode: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("dissect")>]
        Dissect: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("set_security_user")>]
        SetSecurityUser: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("drop")>]
        Drop: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("circle")>]
        Circle: NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("inference")>]
        Inference: NodeInfoIngestInfo option
    }

    type NodeInfoSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: NodeInfoSettingsCluster
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: NodeInfoSettingsNode
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: NodeInfoPath option
        [<System.Text.Json.Serialization.JsonPropertyName("repositories")>]
        Repositories: NodeInfoRepositories option
        [<System.Text.Json.Serialization.JsonPropertyName("discovery")>]
        Discovery: NodeInfoDiscover option
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: NodeInfoAction option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: NodeInfoClient option
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodeInfoSettingsHttp
        [<System.Text.Json.Serialization.JsonPropertyName("bootstrap")>]
        Bootstrap: NodeInfoBootstrap option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodeInfoSettingsTransport
        [<System.Text.Json.Serialization.JsonPropertyName("network")>]
        Network: NodeInfoSettingsNetwork option
        [<System.Text.Json.Serialization.JsonPropertyName("xpack")>]
        Xpack: NodeInfoXpack option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: NodeInfoScript option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: NodeInfoSearch option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: NodeInfoSettingsIngest option
    }

    type NodeThreadPoolInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("core")>]
        Core: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type NodeInfoTransport = {
        [<System.Text.Json.Serialization.JsonPropertyName("bound_address")>]
        BoundAddress: string list
        [<System.Text.Json.Serialization.JsonPropertyName("publish_address")>]
        PublishAddress: string
        [<System.Text.Json.Serialization.JsonPropertyName("profiles")>]
        Profiles: Map<string, string>
    }

    type NodeInfoIngestProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    type NodeInfoIngest = {
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: NodeInfoIngestProcessor list
    }

    type NodeInfoAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("types")>]
        Types: string list
    }

    type RemoveClusterServer = {
        [<System.Text.Json.Serialization.JsonPropertyName("bound_address")>]
        BoundAddress: CoreTypes.TransportAddress list
        [<System.Text.Json.Serialization.JsonPropertyName("publish_address")>]
        PublishAddress: CoreTypes.TransportAddress
    }

    type NodeInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("build_flavor")>]
        BuildFlavor: string
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("build_type")>]
        BuildType: string
        [<System.Text.Json.Serialization.JsonPropertyName("component_versions")>]
        ComponentVersions: Map<CoreTypes.Name, CoreTypes.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodeInfoHttp option
        [<System.Text.Json.Serialization.JsonPropertyName("index_version")>]
        IndexVersion: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: CoreTypes.Ip
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: NodeJvmInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("os")>]
        Os: NodeOperatingSystemInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("plugins")>]
        Plugins: CoreTypes.PluginStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: NodeProcessInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: CoreTypes.NodeRoles
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: NodeInfoSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("thread_pool")>]
        ThreadPool: Map<string, NodeThreadPoolInfo> option
        [<System.Text.Json.Serialization.JsonPropertyName("total_indexing_buffer")>]
        TotalIndexingBuffer: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_indexing_buffer_in_bytes")>]
        TotalIndexingBufferInBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodeInfoTransport option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: CoreTypes.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("transport_version")>]
        TransportVersion: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("modules")>]
        Modules: CoreTypes.PluginStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: NodeInfoIngest option
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, NodeInfoAggregation> option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster_server")>]
        RemoteClusterServer: RemoveClusterServer option
    }

    [<RequireQualifiedAccess>]
    type NodesInfoMetric =
        | All
        | None
        | Settings
        | Os
        | Process
        | Jvm
        | ThreadPool
        | Transport
        | Http
        | RemoteClusterServer
        | Plugins
        | Ingest
        | Aggregations
        | Indices

    [<RequireQualifiedAccess>]
    type NodesInfoMetrics =
        | NodesInfoMetric of NodesInfoMetric
        | Array of NodesInfoMetric list

    type ResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodeInfo>
    }

