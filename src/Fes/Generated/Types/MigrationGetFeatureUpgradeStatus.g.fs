// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MigrationGetFeatureUpgradeStatus =

    [<RequireQualifiedAccess>]
    type MigrationStatus =
        | NOMIGRATIONNEEDED
        | MIGRATIONNEEDED
        | INPROGRESS
        | ERROR

    type MigrationFeatureIndexInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("failure_cause")>]
        FailureCause: CoreTypes.ErrorCause option
    }

    type MigrationFeature = {
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("minimum_index_version")>]
        MinimumIndexVersion: CoreTypes.VersionString
        [<System.Text.Json.Serialization.JsonPropertyName("migration_status")>]
        MigrationStatus: MigrationStatus
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: MigrationFeatureIndexInfo list
    }

