// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module XpackInfo =

    type BuildInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("date")>]
        Date: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("hash")>]
        Hash: string
    }

    type NativeCodeInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("build_hash")>]
        BuildHash: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
    }

    type Feature = {
        [<System.Text.Json.Serialization.JsonPropertyName("available")>]
        Available: bool
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool
        [<System.Text.Json.Serialization.JsonPropertyName("native_code_info")>]
        NativeCodeInfo: NativeCodeInformation option
    }

    type Features = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregate_metric")>]
        AggregateMetric: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("analytics")>]
        Analytics: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("ccr")>]
        Ccr: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("data_streams")>]
        DataStreams: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("data_tiers")>]
        DataTiers: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("enrich")>]
        Enrich: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("enterprise_search")>]
        EnterpriseSearch: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("eql")>]
        Eql: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("esql")>]
        Esql: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("graph")>]
        Graph: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("gpu_vector_indexing")>]
        GpuVectorIndexing: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("ilm")>]
        Ilm: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("logstash")>]
        Logstash: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("logsdb")>]
        Logsdb: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("ml")>]
        Ml: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("monitoring")>]
        Monitoring: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("rollup")>]
        Rollup: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("runtime_fields")>]
        RuntimeFields: Feature option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable_snapshots")>]
        SearchableSnapshots: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("security")>]
        Security: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("slm")>]
        Slm: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("spatial")>]
        Spatial: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("sql")>]
        Sql: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("universal_profiling")>]
        UniversalProfiling: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("voting_only")>]
        VotingOnly: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("watcher")>]
        Watcher: Feature
        [<System.Text.Json.Serialization.JsonPropertyName("archive")>]
        Archive: Feature
    }

    type MinimalLicenseInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("expiry_date_in_millis")>]
        ExpiryDateInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
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

