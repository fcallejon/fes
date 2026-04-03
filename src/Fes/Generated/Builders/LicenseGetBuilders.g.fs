// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module LicenseGetBuilders =

    type LicenseInformationBuilder() =
        member _.Yield(_: unit) : Types.LicenseInformation =
            {
                ExpiryDate = None
                ExpiryDateInMillis = None
                IssueDate = Unchecked.defaultof<_>
                IssueDateInMillis = Unchecked.defaultof<_>
                IssuedTo = Unchecked.defaultof<_>
                Issuer = Unchecked.defaultof<_>
                MaxNodes = Unchecked.defaultof<_>
                MaxResourceUnits = None
                Status = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Uid = Unchecked.defaultof<_>
                StartDateInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("expiryDate")>]
        member _.ExpiryDate(state: Types.LicenseInformation, value: Types.DateTime) =
            { state with ExpiryDate = Some value }

        [<CustomOperation("expiryDateInMillis")>]
        member _.ExpiryDateInMillis(state: Types.LicenseInformation, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ExpiryDateInMillis = Some value }

        [<CustomOperation("issueDate")>]
        member _.IssueDate(state: Types.LicenseInformation, value: Types.DateTime) =
            { state with IssueDate = value }

        [<CustomOperation("issueDateInMillis")>]
        member _.IssueDateInMillis(state: Types.LicenseInformation, value: Types.EpochTime<Types.UnitMillis>) =
            { state with IssueDateInMillis = value }

        [<CustomOperation("issuedTo")>]
        member _.IssuedTo(state: Types.LicenseInformation, value: string) =
            { state with IssuedTo = value }

        [<CustomOperation("issuer")>]
        member _.Issuer(state: Types.LicenseInformation, value: string) =
            { state with Issuer = value }

        [<CustomOperation("maxNodes")>]
        member _.MaxNodes(state: Types.LicenseInformation, value: Types.Long option) =
            { state with MaxNodes = value }

        [<CustomOperation("maxResourceUnits")>]
        member _.MaxResourceUnits(state: Types.LicenseInformation, value: Types.Integer option) =
            { state with MaxResourceUnits = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.LicenseInformation, value: Types.LicenseStatus) =
            { state with Status = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.LicenseInformation, value: Types.LicenseType) =
            { state with Type = value }

        [<CustomOperation("uid")>]
        member _.Uid(state: Types.LicenseInformation, value: Types.Uuid) =
            { state with Uid = value }

        [<CustomOperation("startDateInMillis")>]
        member _.StartDateInMillis(state: Types.LicenseInformation, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartDateInMillis = value }

    let licenseInformation = LicenseInformationBuilder()

