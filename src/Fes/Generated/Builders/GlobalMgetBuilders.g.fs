// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalMgetBuilders =

    type GlobalMgetOperationBuilder() =
        member _.Yield(_: unit) : Types.GlobalMgetOperation =
            {
                Id = Unchecked.defaultof<_>
                Index = None
                Routing = None
                Source = None
                StoredFields = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.GlobalMgetOperation, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.GlobalMgetOperation, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.GlobalMgetOperation, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.GlobalMgetOperation, value: Types.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: Types.GlobalMgetOperation, value: Types.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.GlobalMgetOperation, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.GlobalMgetOperation, value: Types.VersionType) =
            { state with VersionType = Some value }

    let globalMgetOperation = GlobalMgetOperationBuilder()

