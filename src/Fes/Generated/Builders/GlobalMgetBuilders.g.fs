// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalMgetBuilders =

    type OperationBuilder() =
        member _.Yield(_: unit) : Operation =
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
        member _.Id(state: Operation, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Operation, value: CoreTypes.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Operation, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Operation, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("storedFields")>]
        member _.StoredFields(state: Operation, value: CoreTypes.Fields) =
            { state with StoredFields = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Operation, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Operation, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let operation = OperationBuilder()

