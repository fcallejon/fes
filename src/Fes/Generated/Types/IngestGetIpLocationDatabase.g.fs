// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IngestGetIpLocationDatabase =

    type DatabaseConfigurationMetadata = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("database")>]
        Database: IngestTypes.DatabaseConfigurationFull
    }

