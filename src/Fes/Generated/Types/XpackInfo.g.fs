// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module XpackInfo =

    type BuildInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("date")>]
        Date: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("hash")>]
        Hash: string
    }

    type NativeCodeInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString
    }

    type Feature = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: bool
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("native_code_info")>]
        NativeCodeInfo: XpackInfo.NativeCodeInformation option
    }

    type Features = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregate_metric")>]
        AggregateMetric: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("analytics")>]
        Analytics: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("ccr")>]
        Ccr: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("data_streams")>]
        DataStreams: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("data_tiers")>]
        DataTiers: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("enrich")>]
        Enrich: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("enterprise_search")>]
        EnterpriseSearch: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("eql")>]
        Eql: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("esql")>]
        Esql: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("graph")>]
        Graph: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("gpu_vector_indexing")>]
        GpuVectorIndexing: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("ilm")>]
        Ilm: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("logstash")>]
        Logstash: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("logsdb")>]
        Logsdb: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("monitoring")>]
        Monitoring: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("rollup")>]
        Rollup: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_fields")>]
        RuntimeFields: XpackInfo.Feature option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable_snapshots")>]
        SearchableSnapshots: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("security")>]
        Security: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("slm")>]
        Slm: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("spatial")>]
        Spatial: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("sql")>]
        Sql: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("universal_profiling")>]
        UniversalProfiling: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("voting_only")>]
        VotingOnly: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("watcher")>]
        Watcher: XpackInfo.Feature
        [<System.Text.Json.Serialization.JsonPropertyName("archive")>]
        Archive: XpackInfo.Feature
    }

    type MinimalLicenseInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("expiry_date_in_millis")>]
        ExpiryDateInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: LicenseTypes.LicenseType
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: LicenseTypes.LicenseStatus
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: LicenseTypes.LicenseType
        [<System.Text.Json.Serialization.JsonPropertyName("uid")>]
        Uid: string
    }

    [<RequireQualifiedAccess>]
    type XPackCategory =
        | Build
        | Features
        | License

