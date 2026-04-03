// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IngestGetIpLocationDatabaseBuilders =

    type DatabaseConfigurationMetadataBuilder() =
        member _.Yield(_: unit) : DatabaseConfigurationMetadata =
            {
                Id = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                ModifiedDateMillis = None
                ModifiedDate = None
                Database = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: DatabaseConfigurationMetadata, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("version")>]
        member _.Version(state: DatabaseConfigurationMetadata, value: CoreTypes.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: DatabaseConfigurationMetadata, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: DatabaseConfigurationMetadata, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("database")>]
        member _.Database(state: DatabaseConfigurationMetadata, value: IngestTypes.DatabaseConfigurationFull) =
            { state with Database = value }

    let databaseConfigurationMetadata = DatabaseConfigurationMetadataBuilder()

