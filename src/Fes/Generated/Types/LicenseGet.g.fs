// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module LicenseGet =

    type LicenseInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("expiry_date")>]
        ExpiryDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("expiry_date_in_millis")>]
        ExpiryDateInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("issue_date")>]
        IssueDate: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("issue_date_in_millis")>]
        IssueDateInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("issued_to")>]
        IssuedTo: string
        [<System.Text.Json.Serialization.JsonPropertyName("issuer")>]
        Issuer: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_nodes")>]
        MaxNodes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_resource_units")>]
        MaxResourceUnits: CoreTypes.Integer option option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: LicenseTypes.LicenseStatus
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: LicenseTypes.LicenseType
        [<System.Text.Json.Serialization.JsonPropertyName("uid")>]
        Uid: CoreTypes.Uuid
        [<System.Text.Json.Serialization.JsonPropertyName("start_date_in_millis")>]
        StartDateInMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis>
    }

