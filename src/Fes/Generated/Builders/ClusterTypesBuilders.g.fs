// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module ClusterTypesBuilders =

    type ComponentTemplateNodeBuilder() =
        member _.Yield(_: unit) : Types.ComponentTemplateNode =
            {
                Template = Unchecked.defaultof<_>
                Version = None
                Meta = None
                Deprecated = None
                CreatedDate = None
                CreatedDateMillis = None
                ModifiedDate = None
                ModifiedDateMillis = None
            }

        [<CustomOperation("template")>]
        member _.Template(state: Types.ComponentTemplateNode, value: Types.ComponentTemplateSummary) =
            { state with Template = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.ComponentTemplateNode, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ComponentTemplateNode, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: Types.ComponentTemplateNode, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: Types.ComponentTemplateNode, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: Types.ComponentTemplateNode, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.ComponentTemplateNode, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.ComponentTemplateNode, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let componentTemplateNode = ComponentTemplateNodeBuilder()

    type ComponentTemplateNodeWithRolloverBuilder() =
        member _.Yield(_: unit) : Types.ComponentTemplateNodeWithRollover =
            {
                Template = Unchecked.defaultof<_>
                Version = None
                Meta = None
                Deprecated = None
                CreatedDate = None
                CreatedDateMillis = None
                ModifiedDate = None
                ModifiedDateMillis = None
            }

        [<CustomOperation("template")>]
        member _.Template(state: Types.ComponentTemplateNodeWithRollover, value: Types.ComponentTemplateSummaryRes) =
            { state with Template = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.ComponentTemplateNodeWithRollover, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ComponentTemplateNodeWithRollover, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: Types.ComponentTemplateNodeWithRollover, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: Types.ComponentTemplateNodeWithRollover, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: Types.ComponentTemplateNodeWithRollover, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.ComponentTemplateNodeWithRollover, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.ComponentTemplateNodeWithRollover, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let componentTemplateNodeWithRollover = ComponentTemplateNodeWithRolloverBuilder()

    type ComponentTemplateSummaryBuilder() =
        member _.Yield(_: unit) : Types.ComponentTemplateSummary =
            {
                Meta = None
                Version = None
                Settings = None
                Mappings = None
                Aliases = None
                Lifecycle = None
                DataStreamOptions = None
            }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ComponentTemplateSummary, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.ComponentTemplateSummary, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.ComponentTemplateSummary, value: Map<Types.IndexName, Types.IndexSettings>) =
            { state with Settings = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.ComponentTemplateSummary, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.ComponentTemplateSummary, value: Map<string, Types.AliasDefinition>) =
            { state with Aliases = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.ComponentTemplateSummary, value: Types.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: Types.ComponentTemplateSummary, value: Types.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let componentTemplateSummary = ComponentTemplateSummaryBuilder()

    type ComponentTemplateSummaryResBuilder() =
        member _.Yield(_: unit) : Types.ComponentTemplateSummaryRes =
            {
                Lifecycle = None
                Meta = None
                Version = None
                Settings = None
                Mappings = None
                Aliases = None
                DataStreamOptions = None
            }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.ComponentTemplateSummaryRes, value: Types.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.ComponentTemplateSummaryRes, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.ComponentTemplateSummaryRes, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.ComponentTemplateSummaryRes, value: Map<Types.IndexName, Types.IndexSettings>) =
            { state with Settings = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.ComponentTemplateSummaryRes, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.ComponentTemplateSummaryRes, value: Map<string, Types.AliasDefinition>) =
            { state with Aliases = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: Types.ComponentTemplateSummaryRes, value: Types.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let componentTemplateSummaryRes = ComponentTemplateSummaryResBuilder()

