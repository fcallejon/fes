// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalBulkBuilders =

    type OperationBaseBuilder() =
        member _.Yield(_: unit) : Types.OperationBase =
            {
                Id = None
                Index = None
                Routing = None
                IfPrimaryTerm = None
                IfSeqNo = None
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.OperationBase, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.OperationBase, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.OperationBase, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: Types.OperationBase, value: Types.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: Types.OperationBase, value: Types.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.OperationBase, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.OperationBase, value: Types.VersionType) =
            { state with VersionType = Some value }

    let operationBase = OperationBaseBuilder()

    module Operation =

        let index (value: Types.IndexOperation) =
            Types.OperationContainer.Index value

        let create (value: Types.CreateOperation) =
            Types.OperationContainer.Create value

        let update (value: Types.UpdateOperation) =
            Types.OperationContainer.Update value

        let delete (value: Types.DeleteOperation) =
            Types.OperationContainer.Delete value

    type GlobalBulkResponseItemBuilder() =
        member _.Yield(_: unit) : Types.GlobalBulkResponseItem =
            {
                Id = None
                Index = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
                FailureStore = None
                Error = None
                PrimaryTerm = None
                Result = None
                SeqNo = None
                Shards = None
                Version = None
                ForcedRefresh = None
                Get = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.GlobalBulkResponseItem, value: string option) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.GlobalBulkResponseItem, value: string) =
            { state with Index = value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.GlobalBulkResponseItem, value: Types.Integer) =
            { state with Status = value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: Types.GlobalBulkResponseItem, value: Types.FailureStoreStatus) =
            { state with FailureStore = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.GlobalBulkResponseItem, value: Types.ErrorCause) =
            { state with Error = Some value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: Types.GlobalBulkResponseItem, value: Types.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("result")>]
        member _.Result(state: Types.GlobalBulkResponseItem, value: string) =
            { state with Result = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: Types.GlobalBulkResponseItem, value: Types.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.GlobalBulkResponseItem, value: Types.ShardStatistics) =
            { state with Shards = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.GlobalBulkResponseItem, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("forcedRefresh")>]
        member _.ForcedRefresh(state: Types.GlobalBulkResponseItem, value: bool) =
            { state with ForcedRefresh = Some value }

        [<CustomOperation("get")>]
        member _.Get(state: Types.GlobalBulkResponseItem, value: Types.InlineGet<Map<string, System.Text.Json.JsonElement>>) =
            { state with Get = Some value }

    let globalBulkResponseItem = GlobalBulkResponseItemBuilder()

    type UpdateOperationBuilder() =
        member _.Yield(_: unit) : Types.UpdateOperation =
            {
                RequireAlias = None
                RetryOnConflict = None
            }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: Types.UpdateOperation, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("retryOnConflict")>]
        member _.RetryOnConflict(state: Types.UpdateOperation, value: Types.Integer) =
            { state with RetryOnConflict = Some value }

    let updateOperation = UpdateOperationBuilder()

    type WriteOperationBuilder() =
        member _.Yield(_: unit) : Types.WriteOperation =
            {
                DynamicTemplates = None
                Pipeline = None
                RequireAlias = None
            }

        [<CustomOperation("dynamicTemplates")>]
        member _.DynamicTemplates(state: Types.WriteOperation, value: Map<string, string>) =
            { state with DynamicTemplates = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Types.WriteOperation, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: Types.WriteOperation, value: bool) =
            { state with RequireAlias = Some value }

    let writeOperation = WriteOperationBuilder()

