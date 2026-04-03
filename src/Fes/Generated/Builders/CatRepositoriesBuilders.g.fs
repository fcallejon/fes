// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatRepositoriesBuilders =

    type RepositoriesRecordBuilder() =
        member _.Yield(_: unit) : Types.RepositoriesRecord =
            {
                Id = None
                Type = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.RepositoriesRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.RepositoriesRecord, value: string) =
            { state with Type = Some value }

    let repositoriesRecord = RepositoriesRecordBuilder()

