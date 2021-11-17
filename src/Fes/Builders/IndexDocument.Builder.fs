namespace Fes.Builders

[<AutoOpen>]
module IndexDocumentBuilder =
    open System
    open Fes.Contracts.Api
    
    type IndexDocumentBuilder<'TDocument> () =
        member _.Yield _ =
            { IndexDocument.Document = Unchecked.defaultof<'TDocument>
              Target = String.Empty
              Id = None
              Parameters = None }
        
        [<CustomOperation "document" >]
        member _.Document (state: IndexDocument<'TDocument>, value) = { state with Document = value }
        
        [<CustomOperation "target" >]
        member _.Target (state: IndexDocument<'TDocument>, value) = { state with Target = value }
        
        [<CustomOperation "id" >]
        member _.Id (state: IndexDocument<'TDocument>, value) = { state with Id = Some value }
        
        [<CustomOperation "parameters" >]
        member _.Parameters (state: IndexDocument<'TDocument>, value) = { state with Parameters = Some value }
        
    type IndexDocumentQueryParametersBuilder() =
        member _.Yield _ =
            { IndexDocumentQueryParameters.IfSeqNo = None 
              IfPrimaryTerm = None 
              OpType = None 
              Pipeline = None 
              Refresh = None 
              Routing = None 
              Version = None 
              VersionType = None 
              WaitForActiveShards = None 
              Timeout = None 
              RequireAlias = None }
        
        [<CustomOperation "ifSeqNo" >]
        member _.IfSeqNo (state: IndexDocumentQueryParameters, value) = { state with IfSeqNo = Some value }
        
        [<CustomOperation "ifPrimaryTerm" >]
        member _.IfPrimaryTerm (state: IndexDocumentQueryParameters, value) = { state with IfPrimaryTerm = Some value }
        
        [<CustomOperation "opType" >]
        member _.OpType (state: IndexDocumentQueryParameters, value) = { state with OpType = Some value }
        
        [<CustomOperation "pipeline" >]
        member _.Pipeline (state: IndexDocumentQueryParameters, value) = { state with Pipeline = Some value }
        
        [<CustomOperation "refresh" >]
        member _.Refresh (state: IndexDocumentQueryParameters, value) = { state with Refresh = Some value }
        
        [<CustomOperation "routing" >]
        member _.Routing (state: IndexDocumentQueryParameters, value) = { state with Routing = Some value }
        
        [<CustomOperation "version" >]
        member _.Version (state: IndexDocumentQueryParameters, value) = { state with Version = Some value }
        
        [<CustomOperation "versionType" >]
        member _.VersionType (state: IndexDocumentQueryParameters, value) = { state with VersionType = Some value }
        
        [<CustomOperation "waitForActiveShards" >]
        member _.WaitForActiveShards (state: IndexDocumentQueryParameters, value) = { state with WaitForActiveShards = Some value }
        
        [<CustomOperation "timeout" >]
        member _.Timeout (state: IndexDocumentQueryParameters, value) = { state with Timeout = Some value }
        
        [<CustomOperation "requireAlias" >]
        member _.RequireAlias (state: IndexDocumentQueryParameters, value) = { state with RequireAlias = Some value }
        
    let indexDocument<'TDocument> = IndexDocumentBuilder<'TDocument>()
    
    let indexDocumentParameters = IndexDocumentQueryParametersBuilder()