// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalMsearchBuilders =

    type MultisearchHeaderBuilder() =
        member _.Yield(_: unit) : MultisearchHeader =
            {
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                Index = None
                Preference = None
                ProjectRouting = None
                RequestCache = None
                Routing = None
                SearchType = None
                CcsMinimizeRoundtrips = None
                AllowPartialSearchResults = None
                IgnoreThrottled = None
            }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: MultisearchHeader, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: MultisearchHeader, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: MultisearchHeader, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: MultisearchHeader, value: Types.Indices) =
            { state with Index = Some value }

        [<CustomOperation("preference")>]
        member _.Preference(state: MultisearchHeader, value: string) =
            { state with Preference = Some value }

        [<CustomOperation("projectRouting")>]
        member _.ProjectRouting(state: MultisearchHeader, value: Types.ProjectRouting) =
            { state with ProjectRouting = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: MultisearchHeader, value: bool) =
            { state with RequestCache = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: MultisearchHeader, value: Types.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: MultisearchHeader, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("ccsMinimizeRoundtrips")>]
        member _.CcsMinimizeRoundtrips(state: MultisearchHeader, value: bool) =
            { state with CcsMinimizeRoundtrips = Some value }

        [<CustomOperation("allowPartialSearchResults")>]
        member _.AllowPartialSearchResults(state: MultisearchHeader, value: bool) =
            { state with AllowPartialSearchResults = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: MultisearchHeader, value: bool) =
            { state with IgnoreThrottled = Some value }

    let multisearchHeader = MultisearchHeaderBuilder()

