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
        MaxContentLength: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_content_length_in_bytes")>]
        MaxContentLengthInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("publish_address")>]
        PublishAddress: string
    }

    type NodeInfoJvmMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("direct_max")>]
        DirectMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("direct_max_in_bytes")>]
        DirectMaxInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_init")>]
        HeapInit: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_init_in_bytes")>]
        HeapInitInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max")>]
        HeapMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_max_in_bytes")>]
        HeapMaxInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_init")>]
        NonHeapInit: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_init_in_bytes")>]
        NonHeapInitInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_max")>]
        NonHeapMax: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("non_heap_max_in_bytes")>]
        NonHeapMaxInBytes: Types.Long
    }

    type NodeJvmInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("gc_collectors")>]
        GcCollectors: string list
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodesInfo.NodeInfoJvmMemory
        [<System.Text.Json.Serialization.JsonPropertyName("memory_pools")>]
        MemoryPools: string list
        [<System.Text.Json.Serialization.JsonPropertyName("pid")>]
        Pid: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("start_time_in_millis")>]
        StartTimeInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("vm_name")>]
        VmName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("vm_vendor")>]
        VmVendor: string
        [<System.Text.Json.Serialization.JsonPropertyName("vm_version")>]
        VmVersion: Types.VersionString
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
        CacheSizeInBytes: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("cores_per_socket")>]
        CoresPerSocket: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("mhz")>]
        Mhz: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("model")>]
        Model: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_cores")>]
        TotalCores: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_sockets")>]
        TotalSockets: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("vendor")>]
        Vendor: string
    }

    type NodeInfoMemory = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_in_bytes")>]
        TotalInBytes: Types.Long
    }

    type NodeOperatingSystemInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("arch")>]
        Arch: string
        [<System.Text.Json.Serialization.JsonPropertyName("available_processors")>]
        AvailableProcessors: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("allocated_processors")>]
        AllocatedProcessors: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("pretty_name")>]
        PrettyName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_interval_in_millis")>]
        RefreshIntervalInMillis: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("cpu")>]
        Cpu: NodesInfo.NodeInfoOSCPU option
        [<System.Text.Json.Serialization.JsonPropertyName("mem")>]
        Mem: NodesInfo.NodeInfoMemory option
        [<System.Text.Json.Serialization.JsonPropertyName("swap")>]
        Swap: NodesInfo.NodeInfoMemory option
    }

    type NodeProcessInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("mlockall")>]
        Mlockall: bool
        [<System.Text.Json.Serialization.JsonPropertyName("refresh_interval_in_millis")>]
        RefreshIntervalInMillis: Types.DurationValue<Types.UnitMillis>
    }

    type NodeInfoSettingsClusterElection = {
        [<System.Text.Json.Serialization.JsonPropertyName("strategy")>]
        Strategy: Types.Name
    }

    type NodeInfoSettingsCluster = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndicesTypes.IndexRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("election")>]
        Election: NodesInfo.NodeInfoSettingsClusterElection
        [<System.Text.Json.Serialization.JsonPropertyName("initial_master_nodes")>]
        InitialMasterNodes: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecation_indexing")>]
        DeprecationIndexing: NodesInfo.DeprecationIndexing option
    }

    type NodeInfoSettingsNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
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
        Url: NodesInfo.NodeInfoRepositoriesUrl
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
        Type: NodesInfo.NodeInfoSettingsHttpType
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
        Type: NodesInfo.NodeInfoSettingsTransportType
        [<System.Text.Json.Serialization.JsonPropertyName("type.default")>]
        TypeDefault: string option
        [<System.Text.Json.Serialization.JsonPropertyName("features")>]
        Features: NodesInfo.NodeInfoSettingsTransportFeatures option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_deserialization_errors")>]
        IgnoreDeserializationErrors: SpecUtils.Stringified<bool> option
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
        SelfGenerated: NodesInfo.NodeInfoXpackLicenseType
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
        File: Map<string, NodesInfo.NodeInfoXpackSecurityAuthcRealmsStatus> option
        [<System.Text.Json.Serialization.JsonPropertyName("native")>]
        Native: Map<string, NodesInfo.NodeInfoXpackSecurityAuthcRealmsStatus> option
        [<System.Text.Json.Serialization.JsonPropertyName("pki")>]
        Pki: Map<string, NodesInfo.NodeInfoXpackSecurityAuthcRealmsStatus> option
    }

    type NodeInfoXpackSecurityAuthcToken = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string
    }

    type NodeInfoXpackSecurityAuthc = {
        [<System.Text.Json.Serialization.JsonPropertyName("realms")>]
        Realms: NodesInfo.NodeInfoXpackSecurityAuthcRealms option
        [<System.Text.Json.Serialization.JsonPropertyName("token")>]
        Token: NodesInfo.NodeInfoXpackSecurityAuthcToken option
    }

    type NodeInfoXpackSecurity = {
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodesInfo.NodeInfoXpackSecuritySsl option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodesInfo.NodeInfoXpackSecuritySsl option
        [<System.Text.Json.Serialization.JsonPropertyName("authc")>]
        Authc: NodesInfo.NodeInfoXpackSecurityAuthc option
    }

    type NodeInfoXpackMl = {
        [<System.Text.Json.Serialization.JsonPropertyName("use_auto_machine_memory_percent")>]
        UseAutoMachineMemoryPercent: bool option
    }

    type NodeInfoXpack = {
        [<System.Text.Json.Serialization.JsonPropertyName("license")>]
        License: NodesInfo.NodeInfoXpackLicense option
        [<System.Text.Json.Serialization.JsonPropertyName("security")>]
        Security: NodesInfo.NodeInfoXpackSecurity
        [<System.Text.Json.Serialization.JsonPropertyName("notification")>]
        Notification: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: NodesInfo.NodeInfoXpackMl option
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
        Remote: NodesInfo.NodeInfoSearchRemote
    }

    type NodeInfoIngestDownloader = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: string
    }

    type NodeInfoIngestInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("downloader")>]
        Downloader: NodesInfo.NodeInfoIngestDownloader
    }

    type NodeInfoSettingsIngest = {
        [<System.Text.Json.Serialization.JsonPropertyName("attachment")>]
        Attachment: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("append")>]
        Append: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("csv")>]
        Csv: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("convert")>]
        Convert: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("date")>]
        Date: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("date_index_name")>]
        DateIndexName: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("dot_expander")>]
        DotExpander: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("enrich")>]
        Enrich: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("fail")>]
        Fail: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("foreach")>]
        Foreach: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("json")>]
        Json: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("user_agent")>]
        UserAgent: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("kv")>]
        Kv: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("geoip")>]
        Geoip: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("grok")>]
        Grok: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("gsub")>]
        Gsub: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("join")>]
        Join: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("lowercase")>]
        Lowercase: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("remove")>]
        Remove: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("rename")>]
        Rename: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("set")>]
        Set: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("sort")>]
        Sort: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("split")>]
        Split: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("trim")>]
        Trim: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("uppercase")>]
        Uppercase: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("urldecode")>]
        Urldecode: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("bytes")>]
        Bytes: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("dissect")>]
        Dissect: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("set_security_user")>]
        SetSecurityUser: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("drop")>]
        Drop: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("circle")>]
        Circle: NodesInfo.NodeInfoIngestInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("inference")>]
        Inference: NodesInfo.NodeInfoIngestInfo option
    }

    type NodeInfoSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: NodesInfo.NodeInfoSettingsCluster
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: NodesInfo.NodeInfoSettingsNode
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: NodesInfo.NodeInfoPath option
        [<System.Text.Json.Serialization.JsonPropertyName("repositories")>]
        Repositories: NodesInfo.NodeInfoRepositories option
        [<System.Text.Json.Serialization.JsonPropertyName("discovery")>]
        Discovery: NodesInfo.NodeInfoDiscover option
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: NodesInfo.NodeInfoAction option
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: NodesInfo.NodeInfoClient option
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodesInfo.NodeInfoSettingsHttp
        [<System.Text.Json.Serialization.JsonPropertyName("bootstrap")>]
        Bootstrap: NodesInfo.NodeInfoBootstrap option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodesInfo.NodeInfoSettingsTransport
        [<System.Text.Json.Serialization.JsonPropertyName("network")>]
        Network: NodesInfo.NodeInfoSettingsNetwork option
        [<System.Text.Json.Serialization.JsonPropertyName("xpack")>]
        Xpack: NodesInfo.NodeInfoXpack option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: NodesInfo.NodeInfoScript option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: NodesInfo.NodeInfoSearch option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: NodesInfo.NodeInfoSettingsIngest option
    }

    type NodeThreadPoolInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("core")>]
        Core: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_alive")>]
        KeepAlive: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max")>]
        Max: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
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
        Processors: NodesInfo.NodeInfoIngestProcessor list
    }

    type NodeInfoAggregation = {
        [<System.Text.Json.Serialization.JsonPropertyName("types")>]
        Types: string list
    }

    type RemoveClusterServer = {
        [<System.Text.Json.Serialization.JsonPropertyName("bound_address")>]
        BoundAddress: Types.TransportAddress list
        [<System.Text.Json.Serialization.JsonPropertyName("publish_address")>]
        PublishAddress: Types.TransportAddress
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
        ComponentVersions: Map<Types.Name, Types.Integer>
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host
        [<System.Text.Json.Serialization.JsonPropertyName("http")>]
        Http: NodesInfo.NodeInfoHttp option
        [<System.Text.Json.Serialization.JsonPropertyName("index_version")>]
        IndexVersion: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("ip")>]
        Ip: Types.Ip
        [<System.Text.Json.Serialization.JsonPropertyName("jvm")>]
        Jvm: NodesInfo.NodeJvmInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("os")>]
        Os: NodesInfo.NodeOperatingSystemInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("plugins")>]
        Plugins: Types.PluginStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("process")>]
        Process: NodesInfo.NodeProcessInfo option
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Types.NodeRoles
        [<System.Text.Json.Serialization.JsonPropertyName("settings")>]
        Settings: NodesInfo.NodeInfoSettings option
        [<System.Text.Json.Serialization.JsonPropertyName("thread_pool")>]
        ThreadPool: Map<string, NodesInfo.NodeThreadPoolInfo> option
        [<System.Text.Json.Serialization.JsonPropertyName("total_indexing_buffer")>]
        TotalIndexingBuffer: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("total_indexing_buffer_in_bytes")>]
        TotalIndexingBufferInBytes: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: NodesInfo.NodeInfoTransport option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("transport_version")>]
        TransportVersion: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("modules")>]
        Modules: Types.PluginStats list option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest")>]
        Ingest: NodesInfo.NodeInfoIngest option
        [<System.Text.Json.Serialization.JsonPropertyName("aggregations")>]
        Aggregations: Map<string, NodesInfo.NodeInfoAggregation> option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster_server")>]
        RemoteClusterServer: NodesInfo.RemoveClusterServer option
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
        | NodesInfoMetric of NodesInfo.NodesInfoMetric
        | Array of NodesInfo.NodesInfoMetric list

    type ResponseBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, NodesInfo.NodeInfo>
    }

