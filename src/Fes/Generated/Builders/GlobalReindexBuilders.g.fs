// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalReindexBuilders =

    type GlobalReindexDestinationBuilder() =
        member _.Yield(_: unit) : Types.GlobalReindexDestination =
            {
                Index = Unchecked.defaultof<_>
                OpType = None
                Pipeline = None
                Routing = None
                VersionType = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.GlobalReindexDestination, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("opType")>]
        member _.OpType(state: Types.GlobalReindexDestination, value: Types.OpType) =
            { state with OpType = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Types.GlobalReindexDestination, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.GlobalReindexDestination, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.GlobalReindexDestination, value: Types.VersionType) =
            { state with VersionType = Some value }

    let globalReindexDestination = GlobalReindexDestinationBuilder()

    type RemoteSourceBuilder() =
        member _.Yield(_: unit) : Types.RemoteSource =
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
        member _.ConnectTimeout(state: Types.RemoteSource, value: Types.Duration) =
            { state with ConnectTimeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.RemoteSource, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.RemoteSource, value: Types.Host) =
            { state with Host = value }

        [<CustomOperation("username")>]
        member _.Username(state: Types.RemoteSource, value: Types.Username) =
            { state with Username = Some value }

        [<CustomOperation("password")>]
        member _.Password(state: Types.RemoteSource, value: Types.Password) =
            { state with Password = Some value }

        [<CustomOperation("apiKey")>]
        member _.ApiKey(state: Types.RemoteSource, value: string) =
            { state with ApiKey = Some value }

        [<CustomOperation("socketTimeout")>]
        member _.SocketTimeout(state: Types.RemoteSource, value: Types.Duration) =
            { state with SocketTimeout = Some value }

    let remoteSource = RemoteSourceBuilder()

    type GlobalReindexSourceBuilder() =
        member _.Yield(_: unit) : Types.GlobalReindexSource =
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
        member _.Index(state: Types.GlobalReindexSource, value: Types.Indices) =
            { state with Index = value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.GlobalReindexSource, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("remote")>]
        member _.Remote(state: Types.GlobalReindexSource, value: Types.RemoteSource) =
            { state with Remote = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: Types.GlobalReindexSource, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.GlobalReindexSource, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("slice")>]
        member _.Slice(state: Types.GlobalReindexSource, value: Types.SlicedScroll) =
            { state with Slice = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.GlobalReindexSource, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.GlobalReindexSource, value: Types.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("runtimeMappings")>]
        member _.RuntimeMappings(state: Types.GlobalReindexSource, value: Types.RuntimeFields) =
            { state with RuntimeMappings = Some value }

    let globalReindexSource = GlobalReindexSourceBuilder()

