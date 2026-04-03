// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatTransformsBuilders =

    type TransformsRecordBuilder() =
        member _.Yield(_: unit) : TransformsRecord =
            {
                Id = None
                State = None
                Checkpoint = None
                DocumentsProcessed = None
                CheckpointProgress = None
                LastSearchTime = None
                ChangesLastDetectionTime = None
                CreateTime = None
                Version = None
                SourceIndex = None
                DestIndex = None
                Pipeline = None
                Description = None
                TransformType = None
                Frequency = None
                MaxPageSearchSize = None
                DocsPerSecond = None
                Reason = None
                SearchTotal = None
                SearchFailure = None
                SearchTime = None
                IndexTotal = None
                IndexFailure = None
                IndexTime = None
                DocumentsIndexed = None
                DeleteTime = None
                DocumentsDeleted = None
                TriggerCount = None
                PagesProcessed = None
                ProcessingTime = None
                CheckpointDurationTimeExpAvg = None
                IndexedDocumentsExpAvg = None
                ProcessedDocumentsExpAvg = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: TransformsRecord, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("state")>]
        member _.State(state: TransformsRecord, value: string) =
            { state with State = Some value }

        [<CustomOperation("checkpoint")>]
        member _.Checkpoint(state: TransformsRecord, value: string) =
            { state with Checkpoint = Some value }

        [<CustomOperation("documentsProcessed")>]
        member _.DocumentsProcessed(state: TransformsRecord, value: string) =
            { state with DocumentsProcessed = Some value }

        [<CustomOperation("checkpointProgress")>]
        member _.CheckpointProgress(state: TransformsRecord, value: string option) =
            { state with CheckpointProgress = Some value }

        [<CustomOperation("lastSearchTime")>]
        member _.LastSearchTime(state: TransformsRecord, value: string option) =
            { state with LastSearchTime = Some value }

        [<CustomOperation("changesLastDetectionTime")>]
        member _.ChangesLastDetectionTime(state: TransformsRecord, value: string option) =
            { state with ChangesLastDetectionTime = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: TransformsRecord, value: string) =
            { state with CreateTime = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TransformsRecord, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("sourceIndex")>]
        member _.SourceIndex(state: TransformsRecord, value: string) =
            { state with SourceIndex = Some value }

        [<CustomOperation("destIndex")>]
        member _.DestIndex(state: TransformsRecord, value: string) =
            { state with DestIndex = Some value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: TransformsRecord, value: string) =
            { state with Pipeline = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: TransformsRecord, value: string) =
            { state with Description = Some value }

        [<CustomOperation("transformType")>]
        member _.TransformType(state: TransformsRecord, value: string) =
            { state with TransformType = Some value }

        [<CustomOperation("frequency")>]
        member _.Frequency(state: TransformsRecord, value: string) =
            { state with Frequency = Some value }

        [<CustomOperation("maxPageSearchSize")>]
        member _.MaxPageSearchSize(state: TransformsRecord, value: string) =
            { state with MaxPageSearchSize = Some value }

        [<CustomOperation("docsPerSecond")>]
        member _.DocsPerSecond(state: TransformsRecord, value: string) =
            { state with DocsPerSecond = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: TransformsRecord, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("searchTotal")>]
        member _.SearchTotal(state: TransformsRecord, value: string) =
            { state with SearchTotal = Some value }

        [<CustomOperation("searchFailure")>]
        member _.SearchFailure(state: TransformsRecord, value: string) =
            { state with SearchFailure = Some value }

        [<CustomOperation("searchTime")>]
        member _.SearchTime(state: TransformsRecord, value: string) =
            { state with SearchTime = Some value }

        [<CustomOperation("indexTotal")>]
        member _.IndexTotal(state: TransformsRecord, value: string) =
            { state with IndexTotal = Some value }

        [<CustomOperation("indexFailure")>]
        member _.IndexFailure(state: TransformsRecord, value: string) =
            { state with IndexFailure = Some value }

        [<CustomOperation("indexTime")>]
        member _.IndexTime(state: TransformsRecord, value: string) =
            { state with IndexTime = Some value }

        [<CustomOperation("documentsIndexed")>]
        member _.DocumentsIndexed(state: TransformsRecord, value: string) =
            { state with DocumentsIndexed = Some value }

        [<CustomOperation("deleteTime")>]
        member _.DeleteTime(state: TransformsRecord, value: string) =
            { state with DeleteTime = Some value }

        [<CustomOperation("documentsDeleted")>]
        member _.DocumentsDeleted(state: TransformsRecord, value: string) =
            { state with DocumentsDeleted = Some value }

        [<CustomOperation("triggerCount")>]
        member _.TriggerCount(state: TransformsRecord, value: string) =
            { state with TriggerCount = Some value }

        [<CustomOperation("pagesProcessed")>]
        member _.PagesProcessed(state: TransformsRecord, value: string) =
            { state with PagesProcessed = Some value }

        [<CustomOperation("processingTime")>]
        member _.ProcessingTime(state: TransformsRecord, value: string) =
            { state with ProcessingTime = Some value }

        [<CustomOperation("checkpointDurationTimeExpAvg")>]
        member _.CheckpointDurationTimeExpAvg(state: TransformsRecord, value: string) =
            { state with CheckpointDurationTimeExpAvg = Some value }

        [<CustomOperation("indexedDocumentsExpAvg")>]
        member _.IndexedDocumentsExpAvg(state: TransformsRecord, value: string) =
            { state with IndexedDocumentsExpAvg = Some value }

        [<CustomOperation("processedDocumentsExpAvg")>]
        member _.ProcessedDocumentsExpAvg(state: TransformsRecord, value: string) =
            { state with ProcessedDocumentsExpAvg = Some value }

    let transformsRecord = TransformsRecordBuilder()

