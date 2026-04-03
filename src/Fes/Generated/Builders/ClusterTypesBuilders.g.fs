// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module ClusterTypesBuilders =

    type ComponentTemplateNodeBuilder() =
        member _.Yield(_: unit) : ComponentTemplateNode =
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
        member _.Template(state: ComponentTemplateNode, value: ClusterTypes.ComponentTemplateSummary) =
            { state with Template = value }

        [<CustomOperation("version")>]
        member _.Version(state: ComponentTemplateNode, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: ComponentTemplateNode, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: ComponentTemplateNode, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: ComponentTemplateNode, value: CoreTypes.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: ComponentTemplateNode, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: ComponentTemplateNode, value: CoreTypes.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: ComponentTemplateNode, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let componentTemplateNode = ComponentTemplateNodeBuilder()

    type ComponentTemplateNodeWithRolloverBuilder() =
        member _.Yield(_: unit) : ComponentTemplateNodeWithRollover =
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
        member _.Template(state: ComponentTemplateNodeWithRollover, value: ClusterTypes.ComponentTemplateSummaryRes) =
            { state with Template = value }

        [<CustomOperation("version")>]
        member _.Version(state: ComponentTemplateNodeWithRollover, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: ComponentTemplateNodeWithRollover, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: ComponentTemplateNodeWithRollover, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: ComponentTemplateNodeWithRollover, value: CoreTypes.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: ComponentTemplateNodeWithRollover, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: ComponentTemplateNodeWithRollover, value: CoreTypes.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: ComponentTemplateNodeWithRollover, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

    let componentTemplateNodeWithRollover = ComponentTemplateNodeWithRolloverBuilder()

    type ComponentTemplateSummaryBuilder() =
        member _.Yield(_: unit) : ComponentTemplateSummary =
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
        member _.Meta(state: ComponentTemplateSummary, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ComponentTemplateSummary, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: ComponentTemplateSummary, value: Map<CoreTypes.IndexName, IndicesTypes.IndexSettings>) =
            { state with Settings = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: ComponentTemplateSummary, value: CoreTypes.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: ComponentTemplateSummary, value: Map<string, IndicesTypes.AliasDefinition>) =
            { state with Aliases = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: ComponentTemplateSummary, value: IndicesTypes.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: ComponentTemplateSummary, value: IndicesTypes.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let componentTemplateSummary = ComponentTemplateSummaryBuilder()

    type ComponentTemplateSummaryResBuilder() =
        member _.Yield(_: unit) : ComponentTemplateSummaryRes =
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
        member _.Lifecycle(state: ComponentTemplateSummaryRes, value: IndicesTypes.DataStreamLifecycleWithRollover) =
            { state with Lifecycle = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: ComponentTemplateSummaryRes, value: CoreTypes.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ComponentTemplateSummaryRes, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: ComponentTemplateSummaryRes, value: Map<CoreTypes.IndexName, IndicesTypes.IndexSettings>) =
            { state with Settings = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: ComponentTemplateSummaryRes, value: CoreTypes.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: ComponentTemplateSummaryRes, value: Map<string, IndicesTypes.AliasDefinition>) =
            { state with Aliases = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: ComponentTemplateSummaryRes, value: IndicesTypes.DataStreamOptions) =
            { state with DataStreamOptions = Some value }

    let componentTemplateSummaryRes = ComponentTemplateSummaryResBuilder()

