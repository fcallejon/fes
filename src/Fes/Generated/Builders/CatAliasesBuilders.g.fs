// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatAliasesBuilders =

    type AliasesRecordBuilder() =
        member _.Yield(_: unit) : AliasesRecord =
            {
                Alias = None
                Index = None
                Filter = None
                RoutingIndex = None
                RoutingSearch = None
                IsWriteIndex = None
            }

        [<CustomOperation("alias")>]
        member _.Alias(state: AliasesRecord, value: string) =
            { state with Alias = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: AliasesRecord, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: AliasesRecord, value: string) =
            { state with Filter = Some value }

        [<CustomOperation("routingIndex")>]
        member _.RoutingIndex(state: AliasesRecord, value: string) =
            { state with RoutingIndex = Some value }

        [<CustomOperation("routingSearch")>]
        member _.RoutingSearch(state: AliasesRecord, value: string) =
            { state with RoutingSearch = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: AliasesRecord, value: string) =
            { state with IsWriteIndex = Some value }

    let aliasesRecord = AliasesRecordBuilder()

