// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalReindexBuilders =

    type DestinationBuilder() =
        member _.Yield(_: unit) : Destination =
            {
                Index = Unchecked.defaultof<_>
                OpType = None
                Pipeline = None
                Routing = None
                VersionType = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Destination, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("opType")>]
        member _.OpType(state: Destination, value: CoreTypes.OpType) =
            { state with OpType = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Destination, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Destination, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Destination, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let destination = DestinationBuilder()

    type RemoteSourceBuilder() =
        member _.Yield(_: unit) : RemoteSource =
            {
                ConnectTimeout = None
                Headers = None
                Host = Unchecked.defaultof<_>
                Username = None
                Password = None
                ApiKey = None
                SocketTimeout = None
            }

        [<CustomOperation("connectTimeout")>]
        member _.ConnectTimeout(state: RemoteSource, value: CoreTypes.Duration) =
            { state with ConnectTimeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: RemoteSource, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: RemoteSource, value: CoreTypes.Host) =
            { state with Host = value }

        [<CustomOperation("username")>]
        member _.Username(state: RemoteSource, value: CoreTypes.Username) =
            { state with Username = Some value }

        [<CustomOperation("password")>]
        member _.Password(state: RemoteSource, value: CoreTypes.Password) =
            { state with Password = Some value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: RemoteSource, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("socketTimeout")>]
        member _.SocketTimeout(state: RemoteSource, value: CoreTypes.Duration) =
            { state with SocketTimeout = Some value }

    let remoteSource = RemoteSourceBuilder()

    type SourceBuilder() =
        member _.Yield(_: unit) : Source =
            {
                Index = Unchecked.defaultof<_>
                Query = None
                Remote = None
                ProjectRouting = None
                Size = None
                Slice = None
                Sort = None
                Source = None
                RuntimeMappings = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Source, value: CoreTypes.Indices) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: Source, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("remote")>]
        member _.Remote(state: Source, value: GlobalReindex.RemoteSource) =
            { state with Remote = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: Source, value: CoreTypes.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Source, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: Source, value: CoreTypes.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Source, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Source, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Source, value: CoreTypes.RuntimeFields) =
            { state with RuntimeMappings = Some value }

    let source = SourceBuilder()

