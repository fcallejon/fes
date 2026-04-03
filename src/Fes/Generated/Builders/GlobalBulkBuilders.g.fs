// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalBulkBuilders =

    type OperationBaseBuilder() =
        member _.Yield(_: unit) : OperationBase =
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
        member _.Id(state: OperationBase, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: OperationBase, value: CoreTypes.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: OperationBase, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("ifPrimaryTerm")>]
        member _.IfPrimaryTerm(state: OperationBase, value: CoreTypes.Long) =
            { state with IfPrimaryTerm = Some value }

        [<CustomOperation("ifSeqNo")>]
        member _.IfSeqNo(state: OperationBase, value: CoreTypes.SequenceNumber) =
            { state with IfSeqNo = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: OperationBase, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: OperationBase, value: CoreTypes.VersionType) =
            { state with VersionType = Some value }

    let operationBase = OperationBaseBuilder()

    module Operation =

        let index (value: GlobalBulk.IndexOperation) =
            OperationContainer.Index value

        let create (value: GlobalBulk.CreateOperation) =
            OperationContainer.Create value

        let update (value: GlobalBulk.UpdateOperation) =
            OperationContainer.Update value

        let delete (value: GlobalBulk.DeleteOperation) =
            OperationContainer.Delete value

    type ResponseItemBuilder() =
        member _.Yield(_: unit) : ResponseItem =
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
        member _.Id(state: ResponseItem, value: string option) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: ResponseItem, value: string) =
            { state with Index = value }

        [<CustomOperation("status")>]
        member _.Status(state: ResponseItem, value: CoreTypes.Integer) =
            { state with Status = value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: ResponseItem, value: GlobalBulk.FailureStoreStatus) =
            { state with FailureStore = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: ResponseItem, value: CoreTypes.ErrorCause) =
            { state with Error = Some value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: ResponseItem, value: CoreTypes.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("result")>]
        member _.Result(state: ResponseItem, value: string) =
            { state with Result = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: ResponseItem, value: CoreTypes.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: ResponseItem, value: CoreTypes.ShardStatistics) =
            { state with Shards = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ResponseItem, value: CoreTypes.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("forcedRefresh")>]
        member _.ForcedRefresh(state: ResponseItem, value: bool) =
            { state with ForcedRefresh = Some value }

        [<CustomOperation("get")>]
        member _.Get(state: ResponseItem, value: CoreTypes.InlineGet<Map<string, System.Text.Json.JsonElement>>) =
            { state with Get = Some value }

    let responseItem = ResponseItemBuilder()

    type UpdateActionBuilder() =
        member _.Yield(_: unit) : UpdateAction =
            {
                DetectNoop = None
                Doc = None
                DocAsUpsert = None
                Script = None
                ScriptedUpsert = None
                Source = None
                Upsert = None
            }

        [<CustomOperation("detectNoop")>]
        member _.DetectNoop(state: UpdateAction, value: bool) =
            { state with DetectNoop = Some value }

        [<CustomOperation("doc")>]
        member _.Doc(state: UpdateAction, value: 'tPartialDocument) =
            { state with Doc = Some value }

        [<CustomOperation("docAsUpsert")>]
        member _.DocAsUpsert(state: UpdateAction, value: bool) =
            { state with DocAsUpsert = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: UpdateAction, value: CoreTypes.Script) =
            { state with Script = Some value }

        [<CustomOperation("scriptedUpsert")>]
        member _.ScriptedUpsert(state: UpdateAction, value: bool) =
            { state with ScriptedUpsert = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: UpdateAction, value: GlobalSearchTypes.SourceConfig) =
            { state with Source = Some value }

        [<CustomOperation("upsert")>]
        member _.Upsert(state: UpdateAction, value: 'tDocument) =
            { state with Upsert = Some value }

    let updateAction = UpdateActionBuilder()

    type UpdateOperationBuilder() =
        member _.Yield(_: unit) : UpdateOperation =
            {
                RequireAlias = None
                RetryOnConflict = None
            }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: UpdateOperation, value: bool) =
            { state with RequireAlias = Some value }

        [<CustomOperation("retryOnConflict")>]
        member _.RetryOnConflict(state: UpdateOperation, value: CoreTypes.Integer) =
            { state with RetryOnConflict = Some value }

    let updateOperation = UpdateOperationBuilder()

    type WriteOperationBuilder() =
        member _.Yield(_: unit) : WriteOperation =
            {
                DynamicTemplates = None
                Pipeline = None
                RequireAlias = None
            }

        [<CustomOperation("dynamicTemplates")>]
        member _.DynamicTemplates(state: WriteOperation, value: Map<string, string>) =
            { state with DynamicTemplates = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: WriteOperation, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("requireAlias")>]
        member _.RequireAlias(state: WriteOperation, value: bool) =
            { state with RequireAlias = Some value }

    let writeOperation = WriteOperationBuilder()

