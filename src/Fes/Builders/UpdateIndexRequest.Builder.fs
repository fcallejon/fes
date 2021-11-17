namespace Fes.Builders

[<AutoOpen>]
module UpdateIndexRequestBuilder =
    open Fes.DSL.Indices
    
    type UpdateIndexSettingsRequestBuilder () =
        member _.Yield _ =
            { UpdateIndexSettingsRequest.Target = None
              Settings = None
              Parameters = None }
        
        [<CustomOperation "target" >]
        member _.Target (state: UpdateIndexSettingsRequest, value) = { state with Target = Some value }
        
        [<CustomOperation "settings" >]
        member _.Settings (state: UpdateIndexSettingsRequest, value) = { state with Settings = Some value }
        
        [<CustomOperation "parameters" >]
        member _.Parameters (state: UpdateIndexSettingsRequest, value) = { state with Parameters = Some value }
        
    type UpdateRequestQueryParamsBuilder () =
        member _.Yield _ =
            { UpdateRequestQueryParams.AllowNoIndices = None
              FlatSettings = None
              IgnoreUnavailable = None
              PreserveExisting = None
              ExpandWildcards = None
              MasterTimeout = None
              Timeout = None }
        
        [<CustomOperation "allowNoIndices" >]
        member _.AllowNoIndices (state: UpdateRequestQueryParams, value) = { state with AllowNoIndices = Some value }
        
        [<CustomOperation "flatSettings" >]
        member _.FlatSettings (state: UpdateRequestQueryParams, value) = { state with FlatSettings = Some value }
        
        [<CustomOperation "ignoreUnavailable" >]
        member _.IgnoreUnavailable (state: UpdateRequestQueryParams, value) = { state with IgnoreUnavailable = Some value }
        
        [<CustomOperation "preserveExisting" >]
        member _.PreserveExisting (state: UpdateRequestQueryParams, value) = { state with PreserveExisting = Some value }
        
        [<CustomOperation "expandWildcards" >]
        member _.ExpandWildcards (state: UpdateRequestQueryParams, value) = { state with ExpandWildcards = Some value }
        
        [<CustomOperation "masterTimeout" >]
        member _.MasterTimeout (state: UpdateRequestQueryParams, value) = { state with MasterTimeout = Some value }
        
        [<CustomOperation "timeout" >]
        member _.Timeout (state: UpdateRequestQueryParams, value) = { state with Timeout = Some value }
        
    let updateIndexSettingsRequest = UpdateIndexSettingsRequestBuilder()
    let updateRequestQueryParams = UpdateRequestQueryParamsBuilder()