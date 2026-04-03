// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IngestGetIpLocationDatabaseBuilders =

    type IngestGetIpLocationDatabaseDatabaseConfigurationMetadataBuilder() =
        member _.Yield(_: unit) : Types.IngestGetIpLocationDatabaseDatabaseConfigurationMetadata =
            {
                Id = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                ModifiedDateMillis = None
                ModifiedDate = None
                Database = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.IngestGetIpLocationDatabaseDatabaseConfigurationMetadata, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.IngestGetIpLocationDatabaseDatabaseConfigurationMetadata, value: Types.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.IngestGetIpLocationDatabaseDatabaseConfigurationMetadata, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.IngestGetIpLocationDatabaseDatabaseConfigurationMetadata, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("database")>]
        member _.Database(state: Types.IngestGetIpLocationDatabaseDatabaseConfigurationMetadata, value: Types.DatabaseConfigurationFull) =
            { state with Database = value }

    let ingestGetIpLocationDatabaseDatabaseConfigurationMetadata = IngestGetIpLocationDatabaseDatabaseConfigurationMetadataBuilder()

