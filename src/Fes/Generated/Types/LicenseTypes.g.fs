// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module LicenseTypes =

    [<RequireQualifiedAccess>]
    type LicenseType =
        | Missing
        | Trial
        | Basic
        | Standard
        | Dev
        | Silver
        | Gold
        | Platinum
        | Enterprise

    type License = {
        [<System.Text.Json.Serialization.JsonPropertyName("expiry_date_in_millis")>]
        ExpiryDateInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("issue_date_in_millis")>]
        IssueDateInMillis: Types.EpochTime<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("start_date_in_millis")>]
        StartDateInMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("issued_to")>]
        IssuedTo: string
        [<System.Text.Json.Serialization.JsonPropertyName("issuer")>]
        Issuer: string
        [<System.Text.Json.Serialization.JsonPropertyName("max_nodes")>]
        MaxNodes: Types.Long option option
        [<System.Text.Json.Serialization.JsonPropertyName("max_resource_units")>]
        MaxResourceUnits: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("signature")>]
        Signature: string
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: LicenseTypes.LicenseType
        [<System.Text.Json.Serialization.JsonPropertyName("uid")>]
        Uid: string
    }

    [<RequireQualifiedAccess>]
    type LicenseStatus =
        | Active
        | Valid
        | Invalid
        | Expired

