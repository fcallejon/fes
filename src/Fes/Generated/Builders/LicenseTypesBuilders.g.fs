// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module LicenseTypesBuilders =

    type LicenseBuilder() =
        member _.Yield(_: unit) : License =
            {
                ExpiryDateInMillis = Unchecked.defaultof<_>
                IssueDateInMillis = Unchecked.defaultof<_>
                StartDateInMillis = None
                IssuedTo = Unchecked.defaultof<_>
                Issuer = Unchecked.defaultof<_>
                MaxNodes = None
                MaxResourceUnits = None
                Signature = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Uid = Unchecked.defaultof<_>
            }

        [<CustomOperation("expiryDateInMillis")>]
        member _.ExpiryDateInMillis(state: License, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ExpiryDateInMillis = value }

        [<CustomOperation("issueDateInMillis")>]
        member _.IssueDateInMillis(state: License, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with IssueDateInMillis = value }

        [<CustomOperation("startDateInMillis")>]
        member _.StartDateInMillis(state: License, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartDateInMillis = Some value }

        [<CustomOperation("issuedTo")>]
        member _.IssuedTo(state: License, value: string) =
            { state with IssuedTo = value }

        [<CustomOperation("issuer")>]
        member _.Issuer(state: License, value: string) =
            { state with Issuer = value }

        [<CustomOperation("maxNodes")>]
        member _.MaxNodes(state: License, value: CoreTypes.Long option) =
            { state with MaxNodes = Some value }

        [<CustomOperation("maxResourceUnits")>]
        member _.MaxResourceUnits(state: License, value: CoreTypes.Long) =
            { state with MaxResourceUnits = Some value }

        [<CustomOperation("signature")>]
        member _.Signature(state: License, value: string) =
            { state with Signature = value }

        [<CustomOperation("type'")>]
        member _.Type(state: License, value: LicenseTypes.LicenseType) =
            { state with Type = value }

        [<CustomOperation("uid")>]
        member _.Uid(state: License, value: string) =
            { state with Uid = value }

    let license = LicenseBuilder()

