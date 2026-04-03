// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IngestGeoIpStats =

    type GeoIpDownloadStatistics = {
        [<System.Text.Json.Serialization.JsonPropertyName("successful_downloads")>]
        SuccessfulDownloads: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failed_downloads")>]
        FailedDownloads: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_download_time")>]
        TotalDownloadTime: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("databases_count")>]
        DatabasesCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("skipped_updates")>]
        SkippedUpdates: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("expired_databases")>]
        ExpiredDatabases: CoreTypes.Integer
    }

    type GeoIpNodeDatabaseName = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    /// Downloaded databases for the node. The field key is the node ID.
    type GeoIpNodeDatabases = {
        [<System.Text.Json.Serialization.JsonPropertyName("databases")>]
        Databases: GeoIpNodeDatabaseName list
        [<System.Text.Json.Serialization.JsonPropertyName("files_in_temp")>]
        FilesInTemp: string list
    }

