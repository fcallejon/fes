// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalMsearch =

    type MultiSearchItem<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type ResponseItem<'tDocument> =
        | MultiSearchItem of MultiSearchItem<'tDocument>
        | ErrorResponseBase of CoreTypes.ErrorResponseBase

    type MultiSearchResult<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("responses")>]
        Responses: ResponseItem<'tDocument> list
    }

    /// Contains parameters used to limit or change the subsequent search body request.
    type MultisearchHeader = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: CoreTypes.ExpandWildcards option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("preference")>]
        Preference: string option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: CoreTypes.ProjectRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache")>]
        RequestCache: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: CoreTypes.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("search_type")>]
        SearchType: CoreTypes.SearchType option
        [<System.Text.Json.Serialization.JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
    }

    [<RequireQualifiedAccess>]
    type RequestItem =
        | MultisearchHeader of MultisearchHeader
        | SearchRequestBody of GlobalSearchTypes.SearchRequestBody

