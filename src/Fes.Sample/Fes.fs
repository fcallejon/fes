namespace Fes.Sample

open Fes.Builders

[<RequireQualifiedAccess>]
module Search =
    let mkTermSearch targetIndex fieldToQuery queryValue =        
        searchCommandRequest {
            target targetIndex
            seqNoPrimaryTerm true
            includeVersion true
            query (term {
                    value queryValue
                    field fieldToQuery })
        }
    
    let mkQueryString targetIndex fieldToQuery value =
        searchCommandRequest {
            target targetIndex
            seqNoPrimaryTerm true
            includeVersion true
            query (queryString {
                      query value
                      field fieldToQuery })
        }