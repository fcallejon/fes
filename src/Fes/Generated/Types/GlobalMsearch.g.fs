// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalMsearch =

    type MultiSearchItem<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type ResponseItem<'tDocument> =
        | MultiSearchItem of GlobalMsearch.MultiSearchItem<'tDocument>
        | ErrorResponseBase of Types.ErrorResponseBase

    type MultiSearchResult<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("responses")>]
        Responses: GlobalMsearch.ResponseItem<'tDocument> list
    }

    /// Contains parameters used to limit or change the subsequent search body request.
    type MultisearchHeader = {
        [<System.Text.Json.Serialization.JsonPropertyName("allow_no_indices")>]
        AllowNoIndices: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("expand_wildcards")>]
        ExpandWildcards: Types.ExpandWildcards option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unavailable")>]
        IgnoreUnavailable: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("preference")>]
        Preference: string option
        [<System.Text.Json.Serialization.JsonPropertyName("project_routing")>]
        ProjectRouting: Types.ProjectRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache")>]
        RequestCache: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("search_type")>]
        SearchType: Types.SearchType option
        [<System.Text.Json.Serialization.JsonPropertyName("ccs_minimize_roundtrips")>]
        CcsMinimizeRoundtrips: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_partial_search_results")>]
        AllowPartialSearchResults: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_throttled")>]
        IgnoreThrottled: bool option
    }

    [<RequireQualifiedAccess>]
    type RequestItem =
        | MultisearchHeader of GlobalMsearch.MultisearchHeader
        | SearchRequestBody of GlobalSearchTypes.SearchRequestBody

