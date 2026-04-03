// Auto-generated enum round-trip tests — do not edit manually

module Fes.Tests.Generated.EnumRoundTripTests

open Xunit
open FsUnit.Xunit
open Fes
open Fes.Generated

[<Fact>]
let ``FailureStoreStatus.NotApplicableOrUnknown round-trips`` () =
    let value = Types.FailureStoreStatus.NotApplicableOrUnknown
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FailureStoreStatus> json
    roundTripped |> should equal Types.FailureStoreStatus.NotApplicableOrUnknown

[<Fact>]
let ``FailureStoreStatus.Used round-trips`` () =
    let value = Types.FailureStoreStatus.Used
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FailureStoreStatus> json
    roundTripped |> should equal Types.FailureStoreStatus.Used

[<Fact>]
let ``FailureStoreStatus.NotEnabled round-trips`` () =
    let value = Types.FailureStoreStatus.NotEnabled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FailureStoreStatus> json
    roundTripped |> should equal Types.FailureStoreStatus.NotEnabled

[<Fact>]
let ``FailureStoreStatus.Failed round-trips`` () =
    let value = Types.FailureStoreStatus.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FailureStoreStatus> json
    roundTripped |> should equal Types.FailureStoreStatus.Failed

[<Fact>]
let ``OperationType.Index round-trips`` () =
    let value = Types.OperationType.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OperationType> json
    roundTripped |> should equal Types.OperationType.Index

[<Fact>]
let ``OperationType.Create round-trips`` () =
    let value = Types.OperationType.Create
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OperationType> json
    roundTripped |> should equal Types.OperationType.Create

[<Fact>]
let ``OperationType.Update round-trips`` () =
    let value = Types.OperationType.Update
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OperationType> json
    roundTripped |> should equal Types.OperationType.Update

[<Fact>]
let ``OperationType.Delete round-trips`` () =
    let value = Types.OperationType.Delete
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OperationType> json
    roundTripped |> should equal Types.OperationType.Delete

[<Fact>]
let ``RestMethod.GET round-trips`` () =
    let value = Types.RestMethod.GET
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RestMethod> json
    roundTripped |> should equal Types.RestMethod.GET

[<Fact>]
let ``RestMethod.HEAD round-trips`` () =
    let value = Types.RestMethod.HEAD
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RestMethod> json
    roundTripped |> should equal Types.RestMethod.HEAD

[<Fact>]
let ``RestMethod.POST round-trips`` () =
    let value = Types.RestMethod.POST
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RestMethod> json
    roundTripped |> should equal Types.RestMethod.POST

[<Fact>]
let ``RestMethod.PUT round-trips`` () =
    let value = Types.RestMethod.PUT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RestMethod> json
    roundTripped |> should equal Types.RestMethod.PUT

[<Fact>]
let ``RestMethod.DELETE round-trips`` () =
    let value = Types.RestMethod.DELETE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RestMethod> json
    roundTripped |> should equal Types.RestMethod.DELETE

[<Fact>]
let ``ImpactArea.Search round-trips`` () =
    let value = Types.ImpactArea.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImpactArea> json
    roundTripped |> should equal Types.ImpactArea.Search

[<Fact>]
let ``ImpactArea.Ingest round-trips`` () =
    let value = Types.ImpactArea.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImpactArea> json
    roundTripped |> should equal Types.ImpactArea.Ingest

[<Fact>]
let ``ImpactArea.Backup round-trips`` () =
    let value = Types.ImpactArea.Backup
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImpactArea> json
    roundTripped |> should equal Types.ImpactArea.Backup

[<Fact>]
let ``ImpactArea.DeploymentManagement round-trips`` () =
    let value = Types.ImpactArea.DeploymentManagement
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImpactArea> json
    roundTripped |> should equal Types.ImpactArea.DeploymentManagement

[<Fact>]
let ``IndicatorHealthStatus.Green round-trips`` () =
    let value = Types.IndicatorHealthStatus.Green
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicatorHealthStatus> json
    roundTripped |> should equal Types.IndicatorHealthStatus.Green

[<Fact>]
let ``IndicatorHealthStatus.Yellow round-trips`` () =
    let value = Types.IndicatorHealthStatus.Yellow
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicatorHealthStatus> json
    roundTripped |> should equal Types.IndicatorHealthStatus.Yellow

[<Fact>]
let ``IndicatorHealthStatus.Red round-trips`` () =
    let value = Types.IndicatorHealthStatus.Red
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicatorHealthStatus> json
    roundTripped |> should equal Types.IndicatorHealthStatus.Red

[<Fact>]
let ``IndicatorHealthStatus.Unknown round-trips`` () =
    let value = Types.IndicatorHealthStatus.Unknown
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicatorHealthStatus> json
    roundTripped |> should equal Types.IndicatorHealthStatus.Unknown

[<Fact>]
let ``IndicatorHealthStatus.Unavailable round-trips`` () =
    let value = Types.IndicatorHealthStatus.Unavailable
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicatorHealthStatus> json
    roundTripped |> should equal Types.IndicatorHealthStatus.Unavailable

[<Fact>]
let ``PainlessContext.PainlessTest round-trips`` () =
    let value = Types.PainlessContext.PainlessTest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.PainlessTest

[<Fact>]
let ``PainlessContext.Filter round-trips`` () =
    let value = Types.PainlessContext.Filter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.Filter

[<Fact>]
let ``PainlessContext.Score round-trips`` () =
    let value = Types.PainlessContext.Score
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.Score

[<Fact>]
let ``PainlessContext.BooleanField round-trips`` () =
    let value = Types.PainlessContext.BooleanField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.BooleanField

[<Fact>]
let ``PainlessContext.DateField round-trips`` () =
    let value = Types.PainlessContext.DateField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.DateField

[<Fact>]
let ``PainlessContext.DoubleField round-trips`` () =
    let value = Types.PainlessContext.DoubleField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.DoubleField

[<Fact>]
let ``PainlessContext.GeoPointField round-trips`` () =
    let value = Types.PainlessContext.GeoPointField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.GeoPointField

[<Fact>]
let ``PainlessContext.IpField round-trips`` () =
    let value = Types.PainlessContext.IpField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.IpField

[<Fact>]
let ``PainlessContext.KeywordField round-trips`` () =
    let value = Types.PainlessContext.KeywordField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.KeywordField

[<Fact>]
let ``PainlessContext.LongField round-trips`` () =
    let value = Types.PainlessContext.LongField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.LongField

[<Fact>]
let ``PainlessContext.CompositeField round-trips`` () =
    let value = Types.PainlessContext.CompositeField
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PainlessContext> json
    roundTripped |> should equal Types.PainlessContext.CompositeField

[<Fact>]
let ``BoundaryScanner.Chars round-trips`` () =
    let value = Types.BoundaryScanner.Chars
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.BoundaryScanner> json
    roundTripped |> should equal Types.BoundaryScanner.Chars

[<Fact>]
let ``BoundaryScanner.Sentence round-trips`` () =
    let value = Types.BoundaryScanner.Sentence
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.BoundaryScanner> json
    roundTripped |> should equal Types.BoundaryScanner.Sentence

[<Fact>]
let ``BoundaryScanner.Word round-trips`` () =
    let value = Types.BoundaryScanner.Word
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.BoundaryScanner> json
    roundTripped |> should equal Types.BoundaryScanner.Word

[<Fact>]
let ``HighlighterEncoder.Default round-trips`` () =
    let value = Types.HighlighterEncoder.Default
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterEncoder> json
    roundTripped |> should equal Types.HighlighterEncoder.Default

[<Fact>]
let ``HighlighterEncoder.Html round-trips`` () =
    let value = Types.HighlighterEncoder.Html
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterEncoder> json
    roundTripped |> should equal Types.HighlighterEncoder.Html

[<Fact>]
let ``HighlighterFragmenter.Simple round-trips`` () =
    let value = Types.HighlighterFragmenter.Simple
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterFragmenter> json
    roundTripped |> should equal Types.HighlighterFragmenter.Simple

[<Fact>]
let ``HighlighterFragmenter.Span round-trips`` () =
    let value = Types.HighlighterFragmenter.Span
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterFragmenter> json
    roundTripped |> should equal Types.HighlighterFragmenter.Span

[<Fact>]
let ``HighlighterOrder.Score round-trips`` () =
    let value = Types.HighlighterOrder.Score
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterOrder> json
    roundTripped |> should equal Types.HighlighterOrder.Score

[<Fact>]
let ``HighlighterTagsSchema.Styled round-trips`` () =
    let value = Types.HighlighterTagsSchema.Styled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterTagsSchema> json
    roundTripped |> should equal Types.HighlighterTagsSchema.Styled

[<Fact>]
let ``HighlighterType.Plain round-trips`` () =
    let value = Types.HighlighterType.Plain
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterType> json
    roundTripped |> should equal Types.HighlighterType.Plain

[<Fact>]
let ``HighlighterType.Fvh round-trips`` () =
    let value = Types.HighlighterType.Fvh
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterType> json
    roundTripped |> should equal Types.HighlighterType.Fvh

[<Fact>]
let ``HighlighterType.Unified round-trips`` () =
    let value = Types.HighlighterType.Unified
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HighlighterType> json
    roundTripped |> should equal Types.HighlighterType.Unified

[<Fact>]
let ``ScoreMode.Avg round-trips`` () =
    let value = Types.ScoreMode.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreMode> json
    roundTripped |> should equal Types.ScoreMode.Avg

[<Fact>]
let ``ScoreMode.Max round-trips`` () =
    let value = Types.ScoreMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreMode> json
    roundTripped |> should equal Types.ScoreMode.Max

[<Fact>]
let ``ScoreMode.Min round-trips`` () =
    let value = Types.ScoreMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreMode> json
    roundTripped |> should equal Types.ScoreMode.Min

[<Fact>]
let ``ScoreMode.Multiply round-trips`` () =
    let value = Types.ScoreMode.Multiply
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreMode> json
    roundTripped |> should equal Types.ScoreMode.Multiply

[<Fact>]
let ``ScoreMode.Total round-trips`` () =
    let value = Types.ScoreMode.Total
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreMode> json
    roundTripped |> should equal Types.ScoreMode.Total

[<Fact>]
let ``StringDistance.Internal round-trips`` () =
    let value = Types.StringDistance.Internal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StringDistance> json
    roundTripped |> should equal Types.StringDistance.Internal

[<Fact>]
let ``StringDistance.DamerauLevenshtein round-trips`` () =
    let value = Types.StringDistance.DamerauLevenshtein
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StringDistance> json
    roundTripped |> should equal Types.StringDistance.DamerauLevenshtein

[<Fact>]
let ``StringDistance.Levenshtein round-trips`` () =
    let value = Types.StringDistance.Levenshtein
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StringDistance> json
    roundTripped |> should equal Types.StringDistance.Levenshtein

[<Fact>]
let ``StringDistance.JaroWinkler round-trips`` () =
    let value = Types.StringDistance.JaroWinkler
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StringDistance> json
    roundTripped |> should equal Types.StringDistance.JaroWinkler

[<Fact>]
let ``StringDistance.Ngram round-trips`` () =
    let value = Types.StringDistance.Ngram
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StringDistance> json
    roundTripped |> should equal Types.StringDistance.Ngram

[<Fact>]
let ``SuggestSort.Score round-trips`` () =
    let value = Types.SuggestSort.Score
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SuggestSort> json
    roundTripped |> should equal Types.SuggestSort.Score

[<Fact>]
let ``SuggestSort.Frequency round-trips`` () =
    let value = Types.SuggestSort.Frequency
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SuggestSort> json
    roundTripped |> should equal Types.SuggestSort.Frequency

[<Fact>]
let ``TotalHitsRelation.Eq round-trips`` () =
    let value = Types.TotalHitsRelation.Eq
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TotalHitsRelation> json
    roundTripped |> should equal Types.TotalHitsRelation.Eq

[<Fact>]
let ``TotalHitsRelation.Gte round-trips`` () =
    let value = Types.TotalHitsRelation.Gte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TotalHitsRelation> json
    roundTripped |> should equal Types.TotalHitsRelation.Gte

[<Fact>]
let ``GridAggregationType.Geotile round-trips`` () =
    let value = Types.GridAggregationType.Geotile
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GridAggregationType> json
    roundTripped |> should equal Types.GridAggregationType.Geotile

[<Fact>]
let ``GridAggregationType.Geohex round-trips`` () =
    let value = Types.GridAggregationType.Geohex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GridAggregationType> json
    roundTripped |> should equal Types.GridAggregationType.Geohex

[<Fact>]
let ``GridType.Grid round-trips`` () =
    let value = Types.GridType.Grid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GridType> json
    roundTripped |> should equal Types.GridType.Grid

[<Fact>]
let ``GridType.Point round-trips`` () =
    let value = Types.GridType.Point
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GridType> json
    roundTripped |> should equal Types.GridType.Point

[<Fact>]
let ``GridType.Centroid round-trips`` () =
    let value = Types.GridType.Centroid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GridType> json
    roundTripped |> should equal Types.GridType.Centroid

[<Fact>]
let ``Bytes.B round-trips`` () =
    let value = Types.Bytes.B
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Bytes> json
    roundTripped |> should equal Types.Bytes.B

[<Fact>]
let ``Bytes.Kb round-trips`` () =
    let value = Types.Bytes.Kb
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Bytes> json
    roundTripped |> should equal Types.Bytes.Kb

[<Fact>]
let ``Bytes.Mb round-trips`` () =
    let value = Types.Bytes.Mb
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Bytes> json
    roundTripped |> should equal Types.Bytes.Mb

[<Fact>]
let ``Bytes.Gb round-trips`` () =
    let value = Types.Bytes.Gb
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Bytes> json
    roundTripped |> should equal Types.Bytes.Gb

[<Fact>]
let ``Bytes.Tb round-trips`` () =
    let value = Types.Bytes.Tb
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Bytes> json
    roundTripped |> should equal Types.Bytes.Tb

[<Fact>]
let ``Bytes.Pb round-trips`` () =
    let value = Types.Bytes.Pb
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Bytes> json
    roundTripped |> should equal Types.Bytes.Pb

[<Fact>]
let ``ClusterInfoTarget.All round-trips`` () =
    let value = Types.ClusterInfoTarget.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterInfoTarget> json
    roundTripped |> should equal Types.ClusterInfoTarget.All

[<Fact>]
let ``ClusterInfoTarget.Http round-trips`` () =
    let value = Types.ClusterInfoTarget.Http
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterInfoTarget> json
    roundTripped |> should equal Types.ClusterInfoTarget.Http

[<Fact>]
let ``ClusterInfoTarget.Ingest round-trips`` () =
    let value = Types.ClusterInfoTarget.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterInfoTarget> json
    roundTripped |> should equal Types.ClusterInfoTarget.Ingest

[<Fact>]
let ``ClusterInfoTarget.ThreadPool round-trips`` () =
    let value = Types.ClusterInfoTarget.ThreadPool
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterInfoTarget> json
    roundTripped |> should equal Types.ClusterInfoTarget.ThreadPool

[<Fact>]
let ``ClusterInfoTarget.Script round-trips`` () =
    let value = Types.ClusterInfoTarget.Script
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterInfoTarget> json
    roundTripped |> should equal Types.ClusterInfoTarget.Script

[<Fact>]
let ``ClusterSearchStatus.Running round-trips`` () =
    let value = Types.ClusterSearchStatus.Running
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterSearchStatus> json
    roundTripped |> should equal Types.ClusterSearchStatus.Running

[<Fact>]
let ``ClusterSearchStatus.Successful round-trips`` () =
    let value = Types.ClusterSearchStatus.Successful
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterSearchStatus> json
    roundTripped |> should equal Types.ClusterSearchStatus.Successful

[<Fact>]
let ``ClusterSearchStatus.Partial round-trips`` () =
    let value = Types.ClusterSearchStatus.Partial
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterSearchStatus> json
    roundTripped |> should equal Types.ClusterSearchStatus.Partial

[<Fact>]
let ``ClusterSearchStatus.Skipped round-trips`` () =
    let value = Types.ClusterSearchStatus.Skipped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterSearchStatus> json
    roundTripped |> should equal Types.ClusterSearchStatus.Skipped

[<Fact>]
let ``ClusterSearchStatus.Failed round-trips`` () =
    let value = Types.ClusterSearchStatus.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterSearchStatus> json
    roundTripped |> should equal Types.ClusterSearchStatus.Failed

[<Fact>]
let ``CommonStatsFlag.All round-trips`` () =
    let value = Types.CommonStatsFlag.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.All

[<Fact>]
let ``CommonStatsFlag.Store round-trips`` () =
    let value = Types.CommonStatsFlag.Store
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Store

[<Fact>]
let ``CommonStatsFlag.Indexing round-trips`` () =
    let value = Types.CommonStatsFlag.Indexing
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Indexing

[<Fact>]
let ``CommonStatsFlag.Get round-trips`` () =
    let value = Types.CommonStatsFlag.Get
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Get

[<Fact>]
let ``CommonStatsFlag.Search round-trips`` () =
    let value = Types.CommonStatsFlag.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Search

[<Fact>]
let ``CommonStatsFlag.Merge round-trips`` () =
    let value = Types.CommonStatsFlag.Merge
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Merge

[<Fact>]
let ``CommonStatsFlag.Flush round-trips`` () =
    let value = Types.CommonStatsFlag.Flush
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Flush

[<Fact>]
let ``CommonStatsFlag.Refresh round-trips`` () =
    let value = Types.CommonStatsFlag.Refresh
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Refresh

[<Fact>]
let ``CommonStatsFlag.QueryCache round-trips`` () =
    let value = Types.CommonStatsFlag.QueryCache
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.QueryCache

[<Fact>]
let ``CommonStatsFlag.Fielddata round-trips`` () =
    let value = Types.CommonStatsFlag.Fielddata
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Fielddata

[<Fact>]
let ``CommonStatsFlag.Docs round-trips`` () =
    let value = Types.CommonStatsFlag.Docs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Docs

[<Fact>]
let ``CommonStatsFlag.Warmer round-trips`` () =
    let value = Types.CommonStatsFlag.Warmer
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Warmer

[<Fact>]
let ``CommonStatsFlag.Completion round-trips`` () =
    let value = Types.CommonStatsFlag.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Completion

[<Fact>]
let ``CommonStatsFlag.Segments round-trips`` () =
    let value = Types.CommonStatsFlag.Segments
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Segments

[<Fact>]
let ``CommonStatsFlag.Translog round-trips`` () =
    let value = Types.CommonStatsFlag.Translog
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Translog

[<Fact>]
let ``CommonStatsFlag.RequestCache round-trips`` () =
    let value = Types.CommonStatsFlag.RequestCache
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.RequestCache

[<Fact>]
let ``CommonStatsFlag.Recovery round-trips`` () =
    let value = Types.CommonStatsFlag.Recovery
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Recovery

[<Fact>]
let ``CommonStatsFlag.Bulk round-trips`` () =
    let value = Types.CommonStatsFlag.Bulk
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Bulk

[<Fact>]
let ``CommonStatsFlag.ShardStats round-trips`` () =
    let value = Types.CommonStatsFlag.ShardStats
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.ShardStats

[<Fact>]
let ``CommonStatsFlag.Mappings round-trips`` () =
    let value = Types.CommonStatsFlag.Mappings
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.Mappings

[<Fact>]
let ``CommonStatsFlag.DenseVector round-trips`` () =
    let value = Types.CommonStatsFlag.DenseVector
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.DenseVector

[<Fact>]
let ``CommonStatsFlag.SparseVector round-trips`` () =
    let value = Types.CommonStatsFlag.SparseVector
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CommonStatsFlag> json
    roundTripped |> should equal Types.CommonStatsFlag.SparseVector

[<Fact>]
let ``Conflicts.Abort round-trips`` () =
    let value = Types.Conflicts.Abort
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Conflicts> json
    roundTripped |> should equal Types.Conflicts.Abort

[<Fact>]
let ``Conflicts.Proceed round-trips`` () =
    let value = Types.Conflicts.Proceed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Conflicts> json
    roundTripped |> should equal Types.Conflicts.Proceed

[<Fact>]
let ``DFIIndependenceMeasure.Standardized round-trips`` () =
    let value = Types.DFIIndependenceMeasure.Standardized
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFIIndependenceMeasure> json
    roundTripped |> should equal Types.DFIIndependenceMeasure.Standardized

[<Fact>]
let ``DFIIndependenceMeasure.Saturated round-trips`` () =
    let value = Types.DFIIndependenceMeasure.Saturated
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFIIndependenceMeasure> json
    roundTripped |> should equal Types.DFIIndependenceMeasure.Saturated

[<Fact>]
let ``DFIIndependenceMeasure.Chisquared round-trips`` () =
    let value = Types.DFIIndependenceMeasure.Chisquared
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFIIndependenceMeasure> json
    roundTripped |> should equal Types.DFIIndependenceMeasure.Chisquared

[<Fact>]
let ``DFRAfterEffect.No round-trips`` () =
    let value = Types.DFRAfterEffect.No
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRAfterEffect> json
    roundTripped |> should equal Types.DFRAfterEffect.No

[<Fact>]
let ``DFRAfterEffect.B round-trips`` () =
    let value = Types.DFRAfterEffect.B
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRAfterEffect> json
    roundTripped |> should equal Types.DFRAfterEffect.B

[<Fact>]
let ``DFRAfterEffect.L round-trips`` () =
    let value = Types.DFRAfterEffect.L
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRAfterEffect> json
    roundTripped |> should equal Types.DFRAfterEffect.L

[<Fact>]
let ``DFRBasicModel.Be round-trips`` () =
    let value = Types.DFRBasicModel.Be
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.Be

[<Fact>]
let ``DFRBasicModel.D round-trips`` () =
    let value = Types.DFRBasicModel.D
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.D

[<Fact>]
let ``DFRBasicModel.G round-trips`` () =
    let value = Types.DFRBasicModel.G
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.G

[<Fact>]
let ``DFRBasicModel.If round-trips`` () =
    let value = Types.DFRBasicModel.If
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.If

[<Fact>]
let ``DFRBasicModel.In round-trips`` () =
    let value = Types.DFRBasicModel.In
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.In

[<Fact>]
let ``DFRBasicModel.Ine round-trips`` () =
    let value = Types.DFRBasicModel.Ine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.Ine

[<Fact>]
let ``DFRBasicModel.P round-trips`` () =
    let value = Types.DFRBasicModel.P
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DFRBasicModel> json
    roundTripped |> should equal Types.DFRBasicModel.P

[<Fact>]
let ``DistanceUnit.In round-trips`` () =
    let value = Types.DistanceUnit.In
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.In

[<Fact>]
let ``DistanceUnit.Ft round-trips`` () =
    let value = Types.DistanceUnit.Ft
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Ft

[<Fact>]
let ``DistanceUnit.Yd round-trips`` () =
    let value = Types.DistanceUnit.Yd
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Yd

[<Fact>]
let ``DistanceUnit.Mi round-trips`` () =
    let value = Types.DistanceUnit.Mi
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Mi

[<Fact>]
let ``DistanceUnit.Nmi round-trips`` () =
    let value = Types.DistanceUnit.Nmi
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Nmi

[<Fact>]
let ``DistanceUnit.Km round-trips`` () =
    let value = Types.DistanceUnit.Km
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Km

[<Fact>]
let ``DistanceUnit.M round-trips`` () =
    let value = Types.DistanceUnit.M
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.M

[<Fact>]
let ``DistanceUnit.Cm round-trips`` () =
    let value = Types.DistanceUnit.Cm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Cm

[<Fact>]
let ``DistanceUnit.Mm round-trips`` () =
    let value = Types.DistanceUnit.Mm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DistanceUnit> json
    roundTripped |> should equal Types.DistanceUnit.Mm

[<Fact>]
let ``DiversifyRetrieverTypes.Mmr round-trips`` () =
    let value = Types.DiversifyRetrieverTypes.Mmr
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DiversifyRetrieverTypes> json
    roundTripped |> should equal Types.DiversifyRetrieverTypes.Mmr

[<Fact>]
let ``ExpandWildcard.All round-trips`` () =
    let value = Types.ExpandWildcard.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExpandWildcard> json
    roundTripped |> should equal Types.ExpandWildcard.All

[<Fact>]
let ``ExpandWildcard.Open round-trips`` () =
    let value = Types.ExpandWildcard.Open
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExpandWildcard> json
    roundTripped |> should equal Types.ExpandWildcard.Open

[<Fact>]
let ``ExpandWildcard.Closed round-trips`` () =
    let value = Types.ExpandWildcard.Closed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExpandWildcard> json
    roundTripped |> should equal Types.ExpandWildcard.Closed

[<Fact>]
let ``ExpandWildcard.Hidden round-trips`` () =
    let value = Types.ExpandWildcard.Hidden
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExpandWildcard> json
    roundTripped |> should equal Types.ExpandWildcard.Hidden

[<Fact>]
let ``ExpandWildcard.None round-trips`` () =
    let value = Types.ExpandWildcard.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExpandWildcard> json
    roundTripped |> should equal Types.ExpandWildcard.None

[<Fact>]
let ``FieldSortNumericType.Long round-trips`` () =
    let value = Types.FieldSortNumericType.Long
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldSortNumericType> json
    roundTripped |> should equal Types.FieldSortNumericType.Long

[<Fact>]
let ``FieldSortNumericType.Double round-trips`` () =
    let value = Types.FieldSortNumericType.Double
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldSortNumericType> json
    roundTripped |> should equal Types.FieldSortNumericType.Double

[<Fact>]
let ``FieldSortNumericType.Date round-trips`` () =
    let value = Types.FieldSortNumericType.Date
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldSortNumericType> json
    roundTripped |> should equal Types.FieldSortNumericType.Date

[<Fact>]
let ``FieldSortNumericType.DateNanos round-trips`` () =
    let value = Types.FieldSortNumericType.DateNanos
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldSortNumericType> json
    roundTripped |> should equal Types.FieldSortNumericType.DateNanos

[<Fact>]
let ``GeoDistanceType.Arc round-trips`` () =
    let value = Types.GeoDistanceType.Arc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoDistanceType> json
    roundTripped |> should equal Types.GeoDistanceType.Arc

[<Fact>]
let ``GeoDistanceType.Plane round-trips`` () =
    let value = Types.GeoDistanceType.Plane
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoDistanceType> json
    roundTripped |> should equal Types.GeoDistanceType.Plane

[<Fact>]
let ``GeoShapeRelation.Intersects round-trips`` () =
    let value = Types.GeoShapeRelation.Intersects
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoShapeRelation> json
    roundTripped |> should equal Types.GeoShapeRelation.Intersects

[<Fact>]
let ``GeoShapeRelation.Disjoint round-trips`` () =
    let value = Types.GeoShapeRelation.Disjoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoShapeRelation> json
    roundTripped |> should equal Types.GeoShapeRelation.Disjoint

[<Fact>]
let ``GeoShapeRelation.Within round-trips`` () =
    let value = Types.GeoShapeRelation.Within
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoShapeRelation> json
    roundTripped |> should equal Types.GeoShapeRelation.Within

[<Fact>]
let ``GeoShapeRelation.Contains round-trips`` () =
    let value = Types.GeoShapeRelation.Contains
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoShapeRelation> json
    roundTripped |> should equal Types.GeoShapeRelation.Contains

[<Fact>]
let ``HealthStatus.Green round-trips`` () =
    let value = Types.HealthStatus.Green
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HealthStatus> json
    roundTripped |> should equal Types.HealthStatus.Green

[<Fact>]
let ``HealthStatus.Yellow round-trips`` () =
    let value = Types.HealthStatus.Yellow
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HealthStatus> json
    roundTripped |> should equal Types.HealthStatus.Yellow

[<Fact>]
let ``HealthStatus.Red round-trips`` () =
    let value = Types.HealthStatus.Red
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HealthStatus> json
    roundTripped |> should equal Types.HealthStatus.Red

[<Fact>]
let ``HealthStatus.Unknown round-trips`` () =
    let value = Types.HealthStatus.Unknown
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HealthStatus> json
    roundTripped |> should equal Types.HealthStatus.Unknown

[<Fact>]
let ``HealthStatus.Unavailable round-trips`` () =
    let value = Types.HealthStatus.Unavailable
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HealthStatus> json
    roundTripped |> should equal Types.HealthStatus.Unavailable

[<Fact>]
let ``IBDistribution.Ll round-trips`` () =
    let value = Types.IBDistribution.Ll
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IBDistribution> json
    roundTripped |> should equal Types.IBDistribution.Ll

[<Fact>]
let ``IBDistribution.Spl round-trips`` () =
    let value = Types.IBDistribution.Spl
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IBDistribution> json
    roundTripped |> should equal Types.IBDistribution.Spl

[<Fact>]
let ``IBLambda.Df round-trips`` () =
    let value = Types.IBLambda.Df
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IBLambda> json
    roundTripped |> should equal Types.IBLambda.Df

[<Fact>]
let ``IBLambda.Ttf round-trips`` () =
    let value = Types.IBLambda.Ttf
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IBLambda> json
    roundTripped |> should equal Types.IBLambda.Ttf

[<Fact>]
let ``Level.Cluster round-trips`` () =
    let value = Types.Level.Cluster
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Level> json
    roundTripped |> should equal Types.Level.Cluster

[<Fact>]
let ``Level.Indices round-trips`` () =
    let value = Types.Level.Indices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Level> json
    roundTripped |> should equal Types.Level.Indices

[<Fact>]
let ``Level.Shards round-trips`` () =
    let value = Types.Level.Shards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Level> json
    roundTripped |> should equal Types.Level.Shards

[<Fact>]
let ``LifecycleOperationMode.RUNNING round-trips`` () =
    let value = Types.LifecycleOperationMode.RUNNING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LifecycleOperationMode> json
    roundTripped |> should equal Types.LifecycleOperationMode.RUNNING

[<Fact>]
let ``LifecycleOperationMode.STOPPING round-trips`` () =
    let value = Types.LifecycleOperationMode.STOPPING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LifecycleOperationMode> json
    roundTripped |> should equal Types.LifecycleOperationMode.STOPPING

[<Fact>]
let ``LifecycleOperationMode.STOPPED round-trips`` () =
    let value = Types.LifecycleOperationMode.STOPPED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LifecycleOperationMode> json
    roundTripped |> should equal Types.LifecycleOperationMode.STOPPED

[<Fact>]
let ``NodeRole.Master round-trips`` () =
    let value = Types.NodeRole.Master
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.Master

[<Fact>]
let ``NodeRole.Data round-trips`` () =
    let value = Types.NodeRole.Data
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.Data

[<Fact>]
let ``NodeRole.DataCold round-trips`` () =
    let value = Types.NodeRole.DataCold
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.DataCold

[<Fact>]
let ``NodeRole.DataContent round-trips`` () =
    let value = Types.NodeRole.DataContent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.DataContent

[<Fact>]
let ``NodeRole.DataFrozen round-trips`` () =
    let value = Types.NodeRole.DataFrozen
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.DataFrozen

[<Fact>]
let ``NodeRole.DataHot round-trips`` () =
    let value = Types.NodeRole.DataHot
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.DataHot

[<Fact>]
let ``NodeRole.DataWarm round-trips`` () =
    let value = Types.NodeRole.DataWarm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.DataWarm

[<Fact>]
let ``NodeRole.Client round-trips`` () =
    let value = Types.NodeRole.Client
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.Client

[<Fact>]
let ``NodeRole.Ingest round-trips`` () =
    let value = Types.NodeRole.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.Ingest

[<Fact>]
let ``NodeRole.Ml round-trips`` () =
    let value = Types.NodeRole.Ml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.Ml

[<Fact>]
let ``NodeRole.VotingOnly round-trips`` () =
    let value = Types.NodeRole.VotingOnly
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.VotingOnly

[<Fact>]
let ``NodeRole.Transform round-trips`` () =
    let value = Types.NodeRole.Transform
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.Transform

[<Fact>]
let ``NodeRole.RemoteClusterClient round-trips`` () =
    let value = Types.NodeRole.RemoteClusterClient
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.RemoteClusterClient

[<Fact>]
let ``NodeRole.CoordinatingOnly round-trips`` () =
    let value = Types.NodeRole.CoordinatingOnly
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeRole> json
    roundTripped |> should equal Types.NodeRole.CoordinatingOnly

[<Fact>]
let ``NodeStatsLevel.Node round-trips`` () =
    let value = Types.NodeStatsLevel.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsLevel> json
    roundTripped |> should equal Types.NodeStatsLevel.Node

[<Fact>]
let ``NodeStatsLevel.Indices round-trips`` () =
    let value = Types.NodeStatsLevel.Indices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsLevel> json
    roundTripped |> should equal Types.NodeStatsLevel.Indices

[<Fact>]
let ``NodeStatsLevel.Shards round-trips`` () =
    let value = Types.NodeStatsLevel.Shards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsLevel> json
    roundTripped |> should equal Types.NodeStatsLevel.Shards

[<Fact>]
let ``Normalization.No round-trips`` () =
    let value = Types.Normalization.No
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Normalization> json
    roundTripped |> should equal Types.Normalization.No

[<Fact>]
let ``Normalization.H1 round-trips`` () =
    let value = Types.Normalization.H1
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Normalization> json
    roundTripped |> should equal Types.Normalization.H1

[<Fact>]
let ``Normalization.H2 round-trips`` () =
    let value = Types.Normalization.H2
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Normalization> json
    roundTripped |> should equal Types.Normalization.H2

[<Fact>]
let ``Normalization.H3 round-trips`` () =
    let value = Types.Normalization.H3
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Normalization> json
    roundTripped |> should equal Types.Normalization.H3

[<Fact>]
let ``Normalization.Z round-trips`` () =
    let value = Types.Normalization.Z
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Normalization> json
    roundTripped |> should equal Types.Normalization.Z

[<Fact>]
let ``OpType.Index round-trips`` () =
    let value = Types.OpType.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpType> json
    roundTripped |> should equal Types.OpType.Index

[<Fact>]
let ``OpType.Create round-trips`` () =
    let value = Types.OpType.Create
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpType> json
    roundTripped |> should equal Types.OpType.Create

[<Fact>]
let ``Refresh.True round-trips`` () =
    let value = Types.Refresh.True
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Refresh> json
    roundTripped |> should equal Types.Refresh.True

[<Fact>]
let ``Refresh.False round-trips`` () =
    let value = Types.Refresh.False
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Refresh> json
    roundTripped |> should equal Types.Refresh.False

[<Fact>]
let ``Refresh.WaitFor round-trips`` () =
    let value = Types.Refresh.WaitFor
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Refresh> json
    roundTripped |> should equal Types.Refresh.WaitFor

[<Fact>]
let ``Result.Created round-trips`` () =
    let value = Types.Result.Created
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Result> json
    roundTripped |> should equal Types.Result.Created

[<Fact>]
let ``Result.Updated round-trips`` () =
    let value = Types.Result.Updated
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Result> json
    roundTripped |> should equal Types.Result.Updated

[<Fact>]
let ``Result.Deleted round-trips`` () =
    let value = Types.Result.Deleted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Result> json
    roundTripped |> should equal Types.Result.Deleted

[<Fact>]
let ``Result.NotFound round-trips`` () =
    let value = Types.Result.NotFound
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Result> json
    roundTripped |> should equal Types.Result.NotFound

[<Fact>]
let ``Result.Noop round-trips`` () =
    let value = Types.Result.Noop
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Result> json
    roundTripped |> should equal Types.Result.Noop

[<Fact>]
let ``ScoreNormalizer.None round-trips`` () =
    let value = Types.ScoreNormalizer.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreNormalizer> json
    roundTripped |> should equal Types.ScoreNormalizer.None

[<Fact>]
let ``ScoreNormalizer.Minmax round-trips`` () =
    let value = Types.ScoreNormalizer.Minmax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreNormalizer> json
    roundTripped |> should equal Types.ScoreNormalizer.Minmax

[<Fact>]
let ``ScoreNormalizer.L2Norm round-trips`` () =
    let value = Types.ScoreNormalizer.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScoreNormalizer> json
    roundTripped |> should equal Types.ScoreNormalizer.L2Norm

[<Fact>]
let ``ScriptLanguage.Painless round-trips`` () =
    let value = Types.ScriptLanguage.Painless
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptLanguage> json
    roundTripped |> should equal Types.ScriptLanguage.Painless

[<Fact>]
let ``ScriptLanguage.Expression round-trips`` () =
    let value = Types.ScriptLanguage.Expression
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptLanguage> json
    roundTripped |> should equal Types.ScriptLanguage.Expression

[<Fact>]
let ``ScriptLanguage.Mustache round-trips`` () =
    let value = Types.ScriptLanguage.Mustache
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptLanguage> json
    roundTripped |> should equal Types.ScriptLanguage.Mustache

[<Fact>]
let ``ScriptLanguage.Java round-trips`` () =
    let value = Types.ScriptLanguage.Java
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptLanguage> json
    roundTripped |> should equal Types.ScriptLanguage.Java

[<Fact>]
let ``ScriptSortType.String round-trips`` () =
    let value = Types.ScriptSortType.String
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptSortType> json
    roundTripped |> should equal Types.ScriptSortType.String

[<Fact>]
let ``ScriptSortType.Number round-trips`` () =
    let value = Types.ScriptSortType.Number
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptSortType> json
    roundTripped |> should equal Types.ScriptSortType.Number

[<Fact>]
let ``ScriptSortType.Version round-trips`` () =
    let value = Types.ScriptSortType.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ScriptSortType> json
    roundTripped |> should equal Types.ScriptSortType.Version

[<Fact>]
let ``SearchType.QueryThenFetch round-trips`` () =
    let value = Types.SearchType.QueryThenFetch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SearchType> json
    roundTripped |> should equal Types.SearchType.QueryThenFetch

[<Fact>]
let ``SearchType.DfsQueryThenFetch round-trips`` () =
    let value = Types.SearchType.DfsQueryThenFetch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SearchType> json
    roundTripped |> should equal Types.SearchType.DfsQueryThenFetch

[<Fact>]
let ``SlicesCalculation.Auto round-trips`` () =
    let value = Types.SlicesCalculation.Auto
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SlicesCalculation> json
    roundTripped |> should equal Types.SlicesCalculation.Auto

[<Fact>]
let ``SortMode.Min round-trips`` () =
    let value = Types.SortMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortMode> json
    roundTripped |> should equal Types.SortMode.Min

[<Fact>]
let ``SortMode.Max round-trips`` () =
    let value = Types.SortMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortMode> json
    roundTripped |> should equal Types.SortMode.Max

[<Fact>]
let ``SortMode.Sum round-trips`` () =
    let value = Types.SortMode.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortMode> json
    roundTripped |> should equal Types.SortMode.Sum

[<Fact>]
let ``SortMode.Avg round-trips`` () =
    let value = Types.SortMode.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortMode> json
    roundTripped |> should equal Types.SortMode.Avg

[<Fact>]
let ``SortMode.Median round-trips`` () =
    let value = Types.SortMode.Median
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortMode> json
    roundTripped |> should equal Types.SortMode.Median

[<Fact>]
let ``SortOrder.Asc round-trips`` () =
    let value = Types.SortOrder.Asc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortOrder> json
    roundTripped |> should equal Types.SortOrder.Asc

[<Fact>]
let ``SortOrder.Desc round-trips`` () =
    let value = Types.SortOrder.Desc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortOrder> json
    roundTripped |> should equal Types.SortOrder.Desc

[<Fact>]
let ``SuggestMode.Missing round-trips`` () =
    let value = Types.SuggestMode.Missing
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SuggestMode> json
    roundTripped |> should equal Types.SuggestMode.Missing

[<Fact>]
let ``SuggestMode.Popular round-trips`` () =
    let value = Types.SuggestMode.Popular
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SuggestMode> json
    roundTripped |> should equal Types.SuggestMode.Popular

[<Fact>]
let ``SuggestMode.Always round-trips`` () =
    let value = Types.SuggestMode.Always
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SuggestMode> json
    roundTripped |> should equal Types.SuggestMode.Always

[<Fact>]
let ``ThreadType.Cpu round-trips`` () =
    let value = Types.ThreadType.Cpu
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ThreadType> json
    roundTripped |> should equal Types.ThreadType.Cpu

[<Fact>]
let ``ThreadType.Wait round-trips`` () =
    let value = Types.ThreadType.Wait
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ThreadType> json
    roundTripped |> should equal Types.ThreadType.Wait

[<Fact>]
let ``ThreadType.Block round-trips`` () =
    let value = Types.ThreadType.Block
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ThreadType> json
    roundTripped |> should equal Types.ThreadType.Block

[<Fact>]
let ``ThreadType.Gpu round-trips`` () =
    let value = Types.ThreadType.Gpu
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ThreadType> json
    roundTripped |> should equal Types.ThreadType.Gpu

[<Fact>]
let ``ThreadType.Mem round-trips`` () =
    let value = Types.ThreadType.Mem
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ThreadType> json
    roundTripped |> should equal Types.ThreadType.Mem

[<Fact>]
let ``TimeUnit.Nanos round-trips`` () =
    let value = Types.TimeUnit.Nanos
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.Nanos

[<Fact>]
let ``TimeUnit.Micros round-trips`` () =
    let value = Types.TimeUnit.Micros
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.Micros

[<Fact>]
let ``TimeUnit.Ms round-trips`` () =
    let value = Types.TimeUnit.Ms
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.Ms

[<Fact>]
let ``TimeUnit.S round-trips`` () =
    let value = Types.TimeUnit.S
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.S

[<Fact>]
let ``TimeUnit.M round-trips`` () =
    let value = Types.TimeUnit.M
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.M

[<Fact>]
let ``TimeUnit.H round-trips`` () =
    let value = Types.TimeUnit.H
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.H

[<Fact>]
let ``TimeUnit.D round-trips`` () =
    let value = Types.TimeUnit.D
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeUnit> json
    roundTripped |> should equal Types.TimeUnit.D

[<Fact>]
let ``VersionType.Internal round-trips`` () =
    let value = Types.VersionType.Internal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.VersionType> json
    roundTripped |> should equal Types.VersionType.Internal

[<Fact>]
let ``VersionType.External round-trips`` () =
    let value = Types.VersionType.External
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.VersionType> json
    roundTripped |> should equal Types.VersionType.External

[<Fact>]
let ``VersionType.ExternalGte round-trips`` () =
    let value = Types.VersionType.ExternalGte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.VersionType> json
    roundTripped |> should equal Types.VersionType.ExternalGte

[<Fact>]
let ``WaitForActiveShardOptions.All round-trips`` () =
    let value = Types.WaitForActiveShardOptions.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForActiveShardOptions> json
    roundTripped |> should equal Types.WaitForActiveShardOptions.All

[<Fact>]
let ``WaitForActiveShardOptions.IndexSetting round-trips`` () =
    let value = Types.WaitForActiveShardOptions.IndexSetting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForActiveShardOptions> json
    roundTripped |> should equal Types.WaitForActiveShardOptions.IndexSetting

[<Fact>]
let ``WaitForEvents.Immediate round-trips`` () =
    let value = Types.WaitForEvents.Immediate
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForEvents> json
    roundTripped |> should equal Types.WaitForEvents.Immediate

[<Fact>]
let ``WaitForEvents.Urgent round-trips`` () =
    let value = Types.WaitForEvents.Urgent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForEvents> json
    roundTripped |> should equal Types.WaitForEvents.Urgent

[<Fact>]
let ``WaitForEvents.High round-trips`` () =
    let value = Types.WaitForEvents.High
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForEvents> json
    roundTripped |> should equal Types.WaitForEvents.High

[<Fact>]
let ``WaitForEvents.Normal round-trips`` () =
    let value = Types.WaitForEvents.Normal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForEvents> json
    roundTripped |> should equal Types.WaitForEvents.Normal

[<Fact>]
let ``WaitForEvents.Low round-trips`` () =
    let value = Types.WaitForEvents.Low
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForEvents> json
    roundTripped |> should equal Types.WaitForEvents.Low

[<Fact>]
let ``WaitForEvents.Languid round-trips`` () =
    let value = Types.WaitForEvents.Languid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WaitForEvents> json
    roundTripped |> should equal Types.WaitForEvents.Languid

[<Fact>]
let ``CalendarInterval.Second round-trips`` () =
    let value = Types.CalendarInterval.Second
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Second

[<Fact>]
let ``CalendarInterval.Minute round-trips`` () =
    let value = Types.CalendarInterval.Minute
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Minute

[<Fact>]
let ``CalendarInterval.Hour round-trips`` () =
    let value = Types.CalendarInterval.Hour
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Hour

[<Fact>]
let ``CalendarInterval.Day round-trips`` () =
    let value = Types.CalendarInterval.Day
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Day

[<Fact>]
let ``CalendarInterval.Week round-trips`` () =
    let value = Types.CalendarInterval.Week
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Week

[<Fact>]
let ``CalendarInterval.Month round-trips`` () =
    let value = Types.CalendarInterval.Month
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Month

[<Fact>]
let ``CalendarInterval.Quarter round-trips`` () =
    let value = Types.CalendarInterval.Quarter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Quarter

[<Fact>]
let ``CalendarInterval.Year round-trips`` () =
    let value = Types.CalendarInterval.Year
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CalendarInterval> json
    roundTripped |> should equal Types.CalendarInterval.Year

[<Fact>]
let ``CardinalityExecutionMode.GlobalOrdinals round-trips`` () =
    let value = Types.CardinalityExecutionMode.GlobalOrdinals
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CardinalityExecutionMode> json
    roundTripped |> should equal Types.CardinalityExecutionMode.GlobalOrdinals

[<Fact>]
let ``CardinalityExecutionMode.SegmentOrdinals round-trips`` () =
    let value = Types.CardinalityExecutionMode.SegmentOrdinals
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CardinalityExecutionMode> json
    roundTripped |> should equal Types.CardinalityExecutionMode.SegmentOrdinals

[<Fact>]
let ``CardinalityExecutionMode.Direct round-trips`` () =
    let value = Types.CardinalityExecutionMode.Direct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CardinalityExecutionMode> json
    roundTripped |> should equal Types.CardinalityExecutionMode.Direct

[<Fact>]
let ``CardinalityExecutionMode.SaveMemoryHeuristic round-trips`` () =
    let value = Types.CardinalityExecutionMode.SaveMemoryHeuristic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CardinalityExecutionMode> json
    roundTripped |> should equal Types.CardinalityExecutionMode.SaveMemoryHeuristic

[<Fact>]
let ``CardinalityExecutionMode.SaveTimeHeuristic round-trips`` () =
    let value = Types.CardinalityExecutionMode.SaveTimeHeuristic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CardinalityExecutionMode> json
    roundTripped |> should equal Types.CardinalityExecutionMode.SaveTimeHeuristic

[<Fact>]
let ``GapPolicy.Skip round-trips`` () =
    let value = Types.GapPolicy.Skip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GapPolicy> json
    roundTripped |> should equal Types.GapPolicy.Skip

[<Fact>]
let ``GapPolicy.InsertZeros round-trips`` () =
    let value = Types.GapPolicy.InsertZeros
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GapPolicy> json
    roundTripped |> should equal Types.GapPolicy.InsertZeros

[<Fact>]
let ``GapPolicy.KeepValues round-trips`` () =
    let value = Types.GapPolicy.KeepValues
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GapPolicy> json
    roundTripped |> should equal Types.GapPolicy.KeepValues

[<Fact>]
let ``HoltWintersType.Add round-trips`` () =
    let value = Types.HoltWintersType.Add
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HoltWintersType> json
    roundTripped |> should equal Types.HoltWintersType.Add

[<Fact>]
let ``HoltWintersType.Mult round-trips`` () =
    let value = Types.HoltWintersType.Mult
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HoltWintersType> json
    roundTripped |> should equal Types.HoltWintersType.Mult

[<Fact>]
let ``MinimumInterval.Second round-trips`` () =
    let value = Types.MinimumInterval.Second
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MinimumInterval> json
    roundTripped |> should equal Types.MinimumInterval.Second

[<Fact>]
let ``MinimumInterval.Minute round-trips`` () =
    let value = Types.MinimumInterval.Minute
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MinimumInterval> json
    roundTripped |> should equal Types.MinimumInterval.Minute

[<Fact>]
let ``MinimumInterval.Hour round-trips`` () =
    let value = Types.MinimumInterval.Hour
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MinimumInterval> json
    roundTripped |> should equal Types.MinimumInterval.Hour

[<Fact>]
let ``MinimumInterval.Day round-trips`` () =
    let value = Types.MinimumInterval.Day
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MinimumInterval> json
    roundTripped |> should equal Types.MinimumInterval.Day

[<Fact>]
let ``MinimumInterval.Month round-trips`` () =
    let value = Types.MinimumInterval.Month
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MinimumInterval> json
    roundTripped |> should equal Types.MinimumInterval.Month

[<Fact>]
let ``MinimumInterval.Year round-trips`` () =
    let value = Types.MinimumInterval.Year
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MinimumInterval> json
    roundTripped |> should equal Types.MinimumInterval.Year

[<Fact>]
let ``MissingOrder.First round-trips`` () =
    let value = Types.MissingOrder.First
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MissingOrder> json
    roundTripped |> should equal Types.MissingOrder.First

[<Fact>]
let ``MissingOrder.Last round-trips`` () =
    let value = Types.MissingOrder.Last
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MissingOrder> json
    roundTripped |> should equal Types.MissingOrder.Last

[<Fact>]
let ``MissingOrder.Default round-trips`` () =
    let value = Types.MissingOrder.Default
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MissingOrder> json
    roundTripped |> should equal Types.MissingOrder.Default

[<Fact>]
let ``NormalizeMethod.Rescale01 round-trips`` () =
    let value = Types.NormalizeMethod.Rescale01
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NormalizeMethod> json
    roundTripped |> should equal Types.NormalizeMethod.Rescale01

[<Fact>]
let ``NormalizeMethod.Rescale0100 round-trips`` () =
    let value = Types.NormalizeMethod.Rescale0100
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NormalizeMethod> json
    roundTripped |> should equal Types.NormalizeMethod.Rescale0100

[<Fact>]
let ``NormalizeMethod.PercentOfSum round-trips`` () =
    let value = Types.NormalizeMethod.PercentOfSum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NormalizeMethod> json
    roundTripped |> should equal Types.NormalizeMethod.PercentOfSum

[<Fact>]
let ``NormalizeMethod.Mean round-trips`` () =
    let value = Types.NormalizeMethod.Mean
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NormalizeMethod> json
    roundTripped |> should equal Types.NormalizeMethod.Mean

[<Fact>]
let ``NormalizeMethod.ZScore round-trips`` () =
    let value = Types.NormalizeMethod.ZScore
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NormalizeMethod> json
    roundTripped |> should equal Types.NormalizeMethod.ZScore

[<Fact>]
let ``NormalizeMethod.Softmax round-trips`` () =
    let value = Types.NormalizeMethod.Softmax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NormalizeMethod> json
    roundTripped |> should equal Types.NormalizeMethod.Softmax

[<Fact>]
let ``RateMode.Sum round-trips`` () =
    let value = Types.RateMode.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RateMode> json
    roundTripped |> should equal Types.RateMode.Sum

[<Fact>]
let ``RateMode.ValueCount round-trips`` () =
    let value = Types.RateMode.ValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RateMode> json
    roundTripped |> should equal Types.RateMode.ValueCount

[<Fact>]
let ``SamplerAggregationExecutionHint.Map round-trips`` () =
    let value = Types.SamplerAggregationExecutionHint.Map
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SamplerAggregationExecutionHint> json
    roundTripped |> should equal Types.SamplerAggregationExecutionHint.Map

[<Fact>]
let ``SamplerAggregationExecutionHint.GlobalOrdinals round-trips`` () =
    let value = Types.SamplerAggregationExecutionHint.GlobalOrdinals
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SamplerAggregationExecutionHint> json
    roundTripped |> should equal Types.SamplerAggregationExecutionHint.GlobalOrdinals

[<Fact>]
let ``SamplerAggregationExecutionHint.BytesHash round-trips`` () =
    let value = Types.SamplerAggregationExecutionHint.BytesHash
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SamplerAggregationExecutionHint> json
    roundTripped |> should equal Types.SamplerAggregationExecutionHint.BytesHash

[<Fact>]
let ``TDigestExecutionHint.Default round-trips`` () =
    let value = Types.TDigestExecutionHint.Default
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TDigestExecutionHint> json
    roundTripped |> should equal Types.TDigestExecutionHint.Default

[<Fact>]
let ``TDigestExecutionHint.HighAccuracy round-trips`` () =
    let value = Types.TDigestExecutionHint.HighAccuracy
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TDigestExecutionHint> json
    roundTripped |> should equal Types.TDigestExecutionHint.HighAccuracy

[<Fact>]
let ``TTestType.Paired round-trips`` () =
    let value = Types.TTestType.Paired
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TTestType> json
    roundTripped |> should equal Types.TTestType.Paired

[<Fact>]
let ``TTestType.Homoscedastic round-trips`` () =
    let value = Types.TTestType.Homoscedastic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TTestType> json
    roundTripped |> should equal Types.TTestType.Homoscedastic

[<Fact>]
let ``TTestType.Heteroscedastic round-trips`` () =
    let value = Types.TTestType.Heteroscedastic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TTestType> json
    roundTripped |> should equal Types.TTestType.Heteroscedastic

[<Fact>]
let ``TermsAggregationCollectMode.DepthFirst round-trips`` () =
    let value = Types.TermsAggregationCollectMode.DepthFirst
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermsAggregationCollectMode> json
    roundTripped |> should equal Types.TermsAggregationCollectMode.DepthFirst

[<Fact>]
let ``TermsAggregationCollectMode.BreadthFirst round-trips`` () =
    let value = Types.TermsAggregationCollectMode.BreadthFirst
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermsAggregationCollectMode> json
    roundTripped |> should equal Types.TermsAggregationCollectMode.BreadthFirst

[<Fact>]
let ``TermsAggregationExecutionHint.Map round-trips`` () =
    let value = Types.TermsAggregationExecutionHint.Map
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermsAggregationExecutionHint> json
    roundTripped |> should equal Types.TermsAggregationExecutionHint.Map

[<Fact>]
let ``TermsAggregationExecutionHint.GlobalOrdinals round-trips`` () =
    let value = Types.TermsAggregationExecutionHint.GlobalOrdinals
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermsAggregationExecutionHint> json
    roundTripped |> should equal Types.TermsAggregationExecutionHint.GlobalOrdinals

[<Fact>]
let ``TermsAggregationExecutionHint.GlobalOrdinalsHash round-trips`` () =
    let value = Types.TermsAggregationExecutionHint.GlobalOrdinalsHash
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermsAggregationExecutionHint> json
    roundTripped |> should equal Types.TermsAggregationExecutionHint.GlobalOrdinalsHash

[<Fact>]
let ``TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality round-trips`` () =
    let value = Types.TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermsAggregationExecutionHint> json
    roundTripped |> should equal Types.TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality

[<Fact>]
let ``ValueType.String round-trips`` () =
    let value = Types.ValueType.String
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.String

[<Fact>]
let ``ValueType.Long round-trips`` () =
    let value = Types.ValueType.Long
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Long

[<Fact>]
let ``ValueType.Double round-trips`` () =
    let value = Types.ValueType.Double
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Double

[<Fact>]
let ``ValueType.Number round-trips`` () =
    let value = Types.ValueType.Number
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Number

[<Fact>]
let ``ValueType.Date round-trips`` () =
    let value = Types.ValueType.Date
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Date

[<Fact>]
let ``ValueType.DateNanos round-trips`` () =
    let value = Types.ValueType.DateNanos
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.DateNanos

[<Fact>]
let ``ValueType.Ip round-trips`` () =
    let value = Types.ValueType.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Ip

[<Fact>]
let ``ValueType.Numeric round-trips`` () =
    let value = Types.ValueType.Numeric
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Numeric

[<Fact>]
let ``ValueType.GeoPoint round-trips`` () =
    let value = Types.ValueType.GeoPoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.GeoPoint

[<Fact>]
let ``ValueType.Boolean round-trips`` () =
    let value = Types.ValueType.Boolean
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ValueType> json
    roundTripped |> should equal Types.ValueType.Boolean

[<Fact>]
let ``CjkBigramIgnoredScript.Han round-trips`` () =
    let value = Types.CjkBigramIgnoredScript.Han
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CjkBigramIgnoredScript> json
    roundTripped |> should equal Types.CjkBigramIgnoredScript.Han

[<Fact>]
let ``CjkBigramIgnoredScript.Hangul round-trips`` () =
    let value = Types.CjkBigramIgnoredScript.Hangul
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CjkBigramIgnoredScript> json
    roundTripped |> should equal Types.CjkBigramIgnoredScript.Hangul

[<Fact>]
let ``CjkBigramIgnoredScript.Hiragana round-trips`` () =
    let value = Types.CjkBigramIgnoredScript.Hiragana
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CjkBigramIgnoredScript> json
    roundTripped |> should equal Types.CjkBigramIgnoredScript.Hiragana

[<Fact>]
let ``CjkBigramIgnoredScript.Katakana round-trips`` () =
    let value = Types.CjkBigramIgnoredScript.Katakana
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CjkBigramIgnoredScript> json
    roundTripped |> should equal Types.CjkBigramIgnoredScript.Katakana

[<Fact>]
let ``DelimitedPayloadEncoding.Int round-trips`` () =
    let value = Types.DelimitedPayloadEncoding.Int
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DelimitedPayloadEncoding> json
    roundTripped |> should equal Types.DelimitedPayloadEncoding.Int

[<Fact>]
let ``DelimitedPayloadEncoding.Float round-trips`` () =
    let value = Types.DelimitedPayloadEncoding.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DelimitedPayloadEncoding> json
    roundTripped |> should equal Types.DelimitedPayloadEncoding.Float

[<Fact>]
let ``DelimitedPayloadEncoding.Identity round-trips`` () =
    let value = Types.DelimitedPayloadEncoding.Identity
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DelimitedPayloadEncoding> json
    roundTripped |> should equal Types.DelimitedPayloadEncoding.Identity

[<Fact>]
let ``EdgeNGramSide.Front round-trips`` () =
    let value = Types.EdgeNGramSide.Front
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EdgeNGramSide> json
    roundTripped |> should equal Types.EdgeNGramSide.Front

[<Fact>]
let ``EdgeNGramSide.Back round-trips`` () =
    let value = Types.EdgeNGramSide.Back
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EdgeNGramSide> json
    roundTripped |> should equal Types.EdgeNGramSide.Back

[<Fact>]
let ``IcuCollationAlternate.Shifted round-trips`` () =
    let value = Types.IcuCollationAlternate.Shifted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationAlternate> json
    roundTripped |> should equal Types.IcuCollationAlternate.Shifted

[<Fact>]
let ``IcuCollationAlternate.NonIgnorable round-trips`` () =
    let value = Types.IcuCollationAlternate.NonIgnorable
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationAlternate> json
    roundTripped |> should equal Types.IcuCollationAlternate.NonIgnorable

[<Fact>]
let ``IcuCollationCaseFirst.Lower round-trips`` () =
    let value = Types.IcuCollationCaseFirst.Lower
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationCaseFirst> json
    roundTripped |> should equal Types.IcuCollationCaseFirst.Lower

[<Fact>]
let ``IcuCollationCaseFirst.Upper round-trips`` () =
    let value = Types.IcuCollationCaseFirst.Upper
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationCaseFirst> json
    roundTripped |> should equal Types.IcuCollationCaseFirst.Upper

[<Fact>]
let ``IcuCollationDecomposition.No round-trips`` () =
    let value = Types.IcuCollationDecomposition.No
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationDecomposition> json
    roundTripped |> should equal Types.IcuCollationDecomposition.No

[<Fact>]
let ``IcuCollationDecomposition.Identical round-trips`` () =
    let value = Types.IcuCollationDecomposition.Identical
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationDecomposition> json
    roundTripped |> should equal Types.IcuCollationDecomposition.Identical

[<Fact>]
let ``IcuCollationStrength.Primary round-trips`` () =
    let value = Types.IcuCollationStrength.Primary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationStrength> json
    roundTripped |> should equal Types.IcuCollationStrength.Primary

[<Fact>]
let ``IcuCollationStrength.Secondary round-trips`` () =
    let value = Types.IcuCollationStrength.Secondary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationStrength> json
    roundTripped |> should equal Types.IcuCollationStrength.Secondary

[<Fact>]
let ``IcuCollationStrength.Tertiary round-trips`` () =
    let value = Types.IcuCollationStrength.Tertiary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationStrength> json
    roundTripped |> should equal Types.IcuCollationStrength.Tertiary

[<Fact>]
let ``IcuCollationStrength.Quaternary round-trips`` () =
    let value = Types.IcuCollationStrength.Quaternary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationStrength> json
    roundTripped |> should equal Types.IcuCollationStrength.Quaternary

[<Fact>]
let ``IcuCollationStrength.Identical round-trips`` () =
    let value = Types.IcuCollationStrength.Identical
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuCollationStrength> json
    roundTripped |> should equal Types.IcuCollationStrength.Identical

[<Fact>]
let ``IcuNormalizationMode.Decompose round-trips`` () =
    let value = Types.IcuNormalizationMode.Decompose
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuNormalizationMode> json
    roundTripped |> should equal Types.IcuNormalizationMode.Decompose

[<Fact>]
let ``IcuNormalizationMode.Compose round-trips`` () =
    let value = Types.IcuNormalizationMode.Compose
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuNormalizationMode> json
    roundTripped |> should equal Types.IcuNormalizationMode.Compose

[<Fact>]
let ``IcuNormalizationType.Nfc round-trips`` () =
    let value = Types.IcuNormalizationType.Nfc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuNormalizationType> json
    roundTripped |> should equal Types.IcuNormalizationType.Nfc

[<Fact>]
let ``IcuNormalizationType.Nfkc round-trips`` () =
    let value = Types.IcuNormalizationType.Nfkc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuNormalizationType> json
    roundTripped |> should equal Types.IcuNormalizationType.Nfkc

[<Fact>]
let ``IcuNormalizationType.NfkcCf round-trips`` () =
    let value = Types.IcuNormalizationType.NfkcCf
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuNormalizationType> json
    roundTripped |> should equal Types.IcuNormalizationType.NfkcCf

[<Fact>]
let ``IcuTransformDirection.Forward round-trips`` () =
    let value = Types.IcuTransformDirection.Forward
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuTransformDirection> json
    roundTripped |> should equal Types.IcuTransformDirection.Forward

[<Fact>]
let ``IcuTransformDirection.Reverse round-trips`` () =
    let value = Types.IcuTransformDirection.Reverse
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IcuTransformDirection> json
    roundTripped |> should equal Types.IcuTransformDirection.Reverse

[<Fact>]
let ``KeepTypesMode.Include round-trips`` () =
    let value = Types.KeepTypesMode.Include
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.KeepTypesMode> json
    roundTripped |> should equal Types.KeepTypesMode.Include

[<Fact>]
let ``KeepTypesMode.Exclude round-trips`` () =
    let value = Types.KeepTypesMode.Exclude
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.KeepTypesMode> json
    roundTripped |> should equal Types.KeepTypesMode.Exclude

[<Fact>]
let ``KuromojiTokenizationMode.Normal round-trips`` () =
    let value = Types.KuromojiTokenizationMode.Normal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.KuromojiTokenizationMode> json
    roundTripped |> should equal Types.KuromojiTokenizationMode.Normal

[<Fact>]
let ``KuromojiTokenizationMode.Search round-trips`` () =
    let value = Types.KuromojiTokenizationMode.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.KuromojiTokenizationMode> json
    roundTripped |> should equal Types.KuromojiTokenizationMode.Search

[<Fact>]
let ``KuromojiTokenizationMode.Extended round-trips`` () =
    let value = Types.KuromojiTokenizationMode.Extended
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.KuromojiTokenizationMode> json
    roundTripped |> should equal Types.KuromojiTokenizationMode.Extended

[<Fact>]
let ``LowercaseTokenFilterLanguages.Greek round-trips`` () =
    let value = Types.LowercaseTokenFilterLanguages.Greek
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LowercaseTokenFilterLanguages> json
    roundTripped |> should equal Types.LowercaseTokenFilterLanguages.Greek

[<Fact>]
let ``LowercaseTokenFilterLanguages.Irish round-trips`` () =
    let value = Types.LowercaseTokenFilterLanguages.Irish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LowercaseTokenFilterLanguages> json
    roundTripped |> should equal Types.LowercaseTokenFilterLanguages.Irish

[<Fact>]
let ``LowercaseTokenFilterLanguages.Turkish round-trips`` () =
    let value = Types.LowercaseTokenFilterLanguages.Turkish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LowercaseTokenFilterLanguages> json
    roundTripped |> should equal Types.LowercaseTokenFilterLanguages.Turkish

[<Fact>]
let ``NoriDecompoundMode.Discard round-trips`` () =
    let value = Types.NoriDecompoundMode.Discard
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NoriDecompoundMode> json
    roundTripped |> should equal Types.NoriDecompoundMode.Discard

[<Fact>]
let ``NoriDecompoundMode.None round-trips`` () =
    let value = Types.NoriDecompoundMode.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NoriDecompoundMode> json
    roundTripped |> should equal Types.NoriDecompoundMode.None

[<Fact>]
let ``NoriDecompoundMode.Mixed round-trips`` () =
    let value = Types.NoriDecompoundMode.Mixed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NoriDecompoundMode> json
    roundTripped |> should equal Types.NoriDecompoundMode.Mixed

[<Fact>]
let ``PhoneticEncoder.Metaphone round-trips`` () =
    let value = Types.PhoneticEncoder.Metaphone
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Metaphone

[<Fact>]
let ``PhoneticEncoder.DoubleMetaphone round-trips`` () =
    let value = Types.PhoneticEncoder.DoubleMetaphone
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.DoubleMetaphone

[<Fact>]
let ``PhoneticEncoder.Soundex round-trips`` () =
    let value = Types.PhoneticEncoder.Soundex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Soundex

[<Fact>]
let ``PhoneticEncoder.RefinedSoundex round-trips`` () =
    let value = Types.PhoneticEncoder.RefinedSoundex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.RefinedSoundex

[<Fact>]
let ``PhoneticEncoder.Caverphone1 round-trips`` () =
    let value = Types.PhoneticEncoder.Caverphone1
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Caverphone1

[<Fact>]
let ``PhoneticEncoder.Caverphone2 round-trips`` () =
    let value = Types.PhoneticEncoder.Caverphone2
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Caverphone2

[<Fact>]
let ``PhoneticEncoder.Cologne round-trips`` () =
    let value = Types.PhoneticEncoder.Cologne
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Cologne

[<Fact>]
let ``PhoneticEncoder.Nysiis round-trips`` () =
    let value = Types.PhoneticEncoder.Nysiis
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Nysiis

[<Fact>]
let ``PhoneticEncoder.Koelnerphonetik round-trips`` () =
    let value = Types.PhoneticEncoder.Koelnerphonetik
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Koelnerphonetik

[<Fact>]
let ``PhoneticEncoder.Haasephonetik round-trips`` () =
    let value = Types.PhoneticEncoder.Haasephonetik
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.Haasephonetik

[<Fact>]
let ``PhoneticEncoder.BeiderMorse round-trips`` () =
    let value = Types.PhoneticEncoder.BeiderMorse
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.BeiderMorse

[<Fact>]
let ``PhoneticEncoder.DaitchMokotoff round-trips`` () =
    let value = Types.PhoneticEncoder.DaitchMokotoff
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticEncoder> json
    roundTripped |> should equal Types.PhoneticEncoder.DaitchMokotoff

[<Fact>]
let ``PhoneticLanguage.Any round-trips`` () =
    let value = Types.PhoneticLanguage.Any
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Any

[<Fact>]
let ``PhoneticLanguage.Common round-trips`` () =
    let value = Types.PhoneticLanguage.Common
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Common

[<Fact>]
let ``PhoneticLanguage.Cyrillic round-trips`` () =
    let value = Types.PhoneticLanguage.Cyrillic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Cyrillic

[<Fact>]
let ``PhoneticLanguage.English round-trips`` () =
    let value = Types.PhoneticLanguage.English
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.English

[<Fact>]
let ``PhoneticLanguage.French round-trips`` () =
    let value = Types.PhoneticLanguage.French
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.French

[<Fact>]
let ``PhoneticLanguage.German round-trips`` () =
    let value = Types.PhoneticLanguage.German
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.German

[<Fact>]
let ``PhoneticLanguage.Hebrew round-trips`` () =
    let value = Types.PhoneticLanguage.Hebrew
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Hebrew

[<Fact>]
let ``PhoneticLanguage.Hungarian round-trips`` () =
    let value = Types.PhoneticLanguage.Hungarian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Hungarian

[<Fact>]
let ``PhoneticLanguage.Polish round-trips`` () =
    let value = Types.PhoneticLanguage.Polish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Polish

[<Fact>]
let ``PhoneticLanguage.Romanian round-trips`` () =
    let value = Types.PhoneticLanguage.Romanian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Romanian

[<Fact>]
let ``PhoneticLanguage.Russian round-trips`` () =
    let value = Types.PhoneticLanguage.Russian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Russian

[<Fact>]
let ``PhoneticLanguage.Spanish round-trips`` () =
    let value = Types.PhoneticLanguage.Spanish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticLanguage> json
    roundTripped |> should equal Types.PhoneticLanguage.Spanish

[<Fact>]
let ``PhoneticNameType.Generic round-trips`` () =
    let value = Types.PhoneticNameType.Generic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticNameType> json
    roundTripped |> should equal Types.PhoneticNameType.Generic

[<Fact>]
let ``PhoneticNameType.Ashkenazi round-trips`` () =
    let value = Types.PhoneticNameType.Ashkenazi
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticNameType> json
    roundTripped |> should equal Types.PhoneticNameType.Ashkenazi

[<Fact>]
let ``PhoneticNameType.Sephardic round-trips`` () =
    let value = Types.PhoneticNameType.Sephardic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticNameType> json
    roundTripped |> should equal Types.PhoneticNameType.Sephardic

[<Fact>]
let ``PhoneticRuleType.Approx round-trips`` () =
    let value = Types.PhoneticRuleType.Approx
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticRuleType> json
    roundTripped |> should equal Types.PhoneticRuleType.Approx

[<Fact>]
let ``PhoneticRuleType.Exact round-trips`` () =
    let value = Types.PhoneticRuleType.Exact
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PhoneticRuleType> json
    roundTripped |> should equal Types.PhoneticRuleType.Exact

[<Fact>]
let ``SnowballLanguage.Arabic round-trips`` () =
    let value = Types.SnowballLanguage.Arabic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Arabic

[<Fact>]
let ``SnowballLanguage.Armenian round-trips`` () =
    let value = Types.SnowballLanguage.Armenian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Armenian

[<Fact>]
let ``SnowballLanguage.Basque round-trips`` () =
    let value = Types.SnowballLanguage.Basque
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Basque

[<Fact>]
let ``SnowballLanguage.Catalan round-trips`` () =
    let value = Types.SnowballLanguage.Catalan
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Catalan

[<Fact>]
let ``SnowballLanguage.Danish round-trips`` () =
    let value = Types.SnowballLanguage.Danish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Danish

[<Fact>]
let ``SnowballLanguage.Dutch round-trips`` () =
    let value = Types.SnowballLanguage.Dutch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Dutch

[<Fact>]
let ``SnowballLanguage.English round-trips`` () =
    let value = Types.SnowballLanguage.English
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.English

[<Fact>]
let ``SnowballLanguage.Estonian round-trips`` () =
    let value = Types.SnowballLanguage.Estonian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Estonian

[<Fact>]
let ``SnowballLanguage.Finnish round-trips`` () =
    let value = Types.SnowballLanguage.Finnish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Finnish

[<Fact>]
let ``SnowballLanguage.French round-trips`` () =
    let value = Types.SnowballLanguage.French
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.French

[<Fact>]
let ``SnowballLanguage.German round-trips`` () =
    let value = Types.SnowballLanguage.German
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.German

[<Fact>]
let ``SnowballLanguage.German2 round-trips`` () =
    let value = Types.SnowballLanguage.German2
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.German2

[<Fact>]
let ``SnowballLanguage.Hungarian round-trips`` () =
    let value = Types.SnowballLanguage.Hungarian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Hungarian

[<Fact>]
let ``SnowballLanguage.Italian round-trips`` () =
    let value = Types.SnowballLanguage.Italian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Italian

[<Fact>]
let ``SnowballLanguage.Irish round-trips`` () =
    let value = Types.SnowballLanguage.Irish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Irish

[<Fact>]
let ``SnowballLanguage.Kp round-trips`` () =
    let value = Types.SnowballLanguage.Kp
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Kp

[<Fact>]
let ``SnowballLanguage.Lithuanian round-trips`` () =
    let value = Types.SnowballLanguage.Lithuanian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Lithuanian

[<Fact>]
let ``SnowballLanguage.Lovins round-trips`` () =
    let value = Types.SnowballLanguage.Lovins
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Lovins

[<Fact>]
let ``SnowballLanguage.Norwegian round-trips`` () =
    let value = Types.SnowballLanguage.Norwegian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Norwegian

[<Fact>]
let ``SnowballLanguage.Porter round-trips`` () =
    let value = Types.SnowballLanguage.Porter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Porter

[<Fact>]
let ``SnowballLanguage.Portuguese round-trips`` () =
    let value = Types.SnowballLanguage.Portuguese
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Portuguese

[<Fact>]
let ``SnowballLanguage.Romanian round-trips`` () =
    let value = Types.SnowballLanguage.Romanian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Romanian

[<Fact>]
let ``SnowballLanguage.Russian round-trips`` () =
    let value = Types.SnowballLanguage.Russian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Russian

[<Fact>]
let ``SnowballLanguage.Serbian round-trips`` () =
    let value = Types.SnowballLanguage.Serbian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Serbian

[<Fact>]
let ``SnowballLanguage.Spanish round-trips`` () =
    let value = Types.SnowballLanguage.Spanish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Spanish

[<Fact>]
let ``SnowballLanguage.Swedish round-trips`` () =
    let value = Types.SnowballLanguage.Swedish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Swedish

[<Fact>]
let ``SnowballLanguage.Turkish round-trips`` () =
    let value = Types.SnowballLanguage.Turkish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnowballLanguage> json
    roundTripped |> should equal Types.SnowballLanguage.Turkish

[<Fact>]
let ``StopWordLanguage.Arabic round-trips`` () =
    let value = Types.StopWordLanguage.Arabic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Arabic

[<Fact>]
let ``StopWordLanguage.Armenian round-trips`` () =
    let value = Types.StopWordLanguage.Armenian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Armenian

[<Fact>]
let ``StopWordLanguage.Basque round-trips`` () =
    let value = Types.StopWordLanguage.Basque
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Basque

[<Fact>]
let ``StopWordLanguage.Bengali round-trips`` () =
    let value = Types.StopWordLanguage.Bengali
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Bengali

[<Fact>]
let ``StopWordLanguage.Brazilian round-trips`` () =
    let value = Types.StopWordLanguage.Brazilian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Brazilian

[<Fact>]
let ``StopWordLanguage.Bulgarian round-trips`` () =
    let value = Types.StopWordLanguage.Bulgarian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Bulgarian

[<Fact>]
let ``StopWordLanguage.Catalan round-trips`` () =
    let value = Types.StopWordLanguage.Catalan
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Catalan

[<Fact>]
let ``StopWordLanguage.Cjk round-trips`` () =
    let value = Types.StopWordLanguage.Cjk
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Cjk

[<Fact>]
let ``StopWordLanguage.Czech round-trips`` () =
    let value = Types.StopWordLanguage.Czech
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Czech

[<Fact>]
let ``StopWordLanguage.Danish round-trips`` () =
    let value = Types.StopWordLanguage.Danish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Danish

[<Fact>]
let ``StopWordLanguage.Dutch round-trips`` () =
    let value = Types.StopWordLanguage.Dutch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Dutch

[<Fact>]
let ``StopWordLanguage.English round-trips`` () =
    let value = Types.StopWordLanguage.English
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.English

[<Fact>]
let ``StopWordLanguage.Estonian round-trips`` () =
    let value = Types.StopWordLanguage.Estonian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Estonian

[<Fact>]
let ``StopWordLanguage.Finnish round-trips`` () =
    let value = Types.StopWordLanguage.Finnish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Finnish

[<Fact>]
let ``StopWordLanguage.French round-trips`` () =
    let value = Types.StopWordLanguage.French
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.French

[<Fact>]
let ``StopWordLanguage.Galician round-trips`` () =
    let value = Types.StopWordLanguage.Galician
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Galician

[<Fact>]
let ``StopWordLanguage.German round-trips`` () =
    let value = Types.StopWordLanguage.German
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.German

[<Fact>]
let ``StopWordLanguage.Greek round-trips`` () =
    let value = Types.StopWordLanguage.Greek
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Greek

[<Fact>]
let ``StopWordLanguage.Hindi round-trips`` () =
    let value = Types.StopWordLanguage.Hindi
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Hindi

[<Fact>]
let ``StopWordLanguage.Hungarian round-trips`` () =
    let value = Types.StopWordLanguage.Hungarian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Hungarian

[<Fact>]
let ``StopWordLanguage.Indonesian round-trips`` () =
    let value = Types.StopWordLanguage.Indonesian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Indonesian

[<Fact>]
let ``StopWordLanguage.Irish round-trips`` () =
    let value = Types.StopWordLanguage.Irish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Irish

[<Fact>]
let ``StopWordLanguage.Italian round-trips`` () =
    let value = Types.StopWordLanguage.Italian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Italian

[<Fact>]
let ``StopWordLanguage.Latvian round-trips`` () =
    let value = Types.StopWordLanguage.Latvian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Latvian

[<Fact>]
let ``StopWordLanguage.Lithuanian round-trips`` () =
    let value = Types.StopWordLanguage.Lithuanian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Lithuanian

[<Fact>]
let ``StopWordLanguage.Norwegian round-trips`` () =
    let value = Types.StopWordLanguage.Norwegian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Norwegian

[<Fact>]
let ``StopWordLanguage.Persian round-trips`` () =
    let value = Types.StopWordLanguage.Persian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Persian

[<Fact>]
let ``StopWordLanguage.Portuguese round-trips`` () =
    let value = Types.StopWordLanguage.Portuguese
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Portuguese

[<Fact>]
let ``StopWordLanguage.Romanian round-trips`` () =
    let value = Types.StopWordLanguage.Romanian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Romanian

[<Fact>]
let ``StopWordLanguage.Russian round-trips`` () =
    let value = Types.StopWordLanguage.Russian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Russian

[<Fact>]
let ``StopWordLanguage.Serbian round-trips`` () =
    let value = Types.StopWordLanguage.Serbian
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Serbian

[<Fact>]
let ``StopWordLanguage.Sorani round-trips`` () =
    let value = Types.StopWordLanguage.Sorani
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Sorani

[<Fact>]
let ``StopWordLanguage.Spanish round-trips`` () =
    let value = Types.StopWordLanguage.Spanish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Spanish

[<Fact>]
let ``StopWordLanguage.Swedish round-trips`` () =
    let value = Types.StopWordLanguage.Swedish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Swedish

[<Fact>]
let ``StopWordLanguage.Thai round-trips`` () =
    let value = Types.StopWordLanguage.Thai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Thai

[<Fact>]
let ``StopWordLanguage.Turkish round-trips`` () =
    let value = Types.StopWordLanguage.Turkish
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.Turkish

[<Fact>]
let ``StopWordLanguage.None round-trips`` () =
    let value = Types.StopWordLanguage.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StopWordLanguage> json
    roundTripped |> should equal Types.StopWordLanguage.None

[<Fact>]
let ``SynonymFormat.Solr round-trips`` () =
    let value = Types.SynonymFormat.Solr
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SynonymFormat> json
    roundTripped |> should equal Types.SynonymFormat.Solr

[<Fact>]
let ``SynonymFormat.Wordnet round-trips`` () =
    let value = Types.SynonymFormat.Wordnet
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SynonymFormat> json
    roundTripped |> should equal Types.SynonymFormat.Wordnet

[<Fact>]
let ``TokenChar.Letter round-trips`` () =
    let value = Types.TokenChar.Letter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenChar> json
    roundTripped |> should equal Types.TokenChar.Letter

[<Fact>]
let ``TokenChar.Digit round-trips`` () =
    let value = Types.TokenChar.Digit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenChar> json
    roundTripped |> should equal Types.TokenChar.Digit

[<Fact>]
let ``TokenChar.Whitespace round-trips`` () =
    let value = Types.TokenChar.Whitespace
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenChar> json
    roundTripped |> should equal Types.TokenChar.Whitespace

[<Fact>]
let ``TokenChar.Punctuation round-trips`` () =
    let value = Types.TokenChar.Punctuation
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenChar> json
    roundTripped |> should equal Types.TokenChar.Punctuation

[<Fact>]
let ``TokenChar.Symbol round-trips`` () =
    let value = Types.TokenChar.Symbol
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenChar> json
    roundTripped |> should equal Types.TokenChar.Symbol

[<Fact>]
let ``TokenChar.Custom round-trips`` () =
    let value = Types.TokenChar.Custom
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenChar> json
    roundTripped |> should equal Types.TokenChar.Custom

[<Fact>]
let ``DenseVectorElementType.Bit round-trips`` () =
    let value = Types.DenseVectorElementType.Bit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorElementType> json
    roundTripped |> should equal Types.DenseVectorElementType.Bit

[<Fact>]
let ``DenseVectorElementType.Byte round-trips`` () =
    let value = Types.DenseVectorElementType.Byte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorElementType> json
    roundTripped |> should equal Types.DenseVectorElementType.Byte

[<Fact>]
let ``DenseVectorElementType.Float round-trips`` () =
    let value = Types.DenseVectorElementType.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorElementType> json
    roundTripped |> should equal Types.DenseVectorElementType.Float

[<Fact>]
let ``DenseVectorElementType.Bfloat16 round-trips`` () =
    let value = Types.DenseVectorElementType.Bfloat16
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorElementType> json
    roundTripped |> should equal Types.DenseVectorElementType.Bfloat16

[<Fact>]
let ``DenseVectorIndexOptionsType.BbqFlat round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.BbqFlat
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.BbqFlat

[<Fact>]
let ``DenseVectorIndexOptionsType.BbqHnsw round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.BbqHnsw
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.BbqHnsw

[<Fact>]
let ``DenseVectorIndexOptionsType.BbqDisk round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.BbqDisk
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.BbqDisk

[<Fact>]
let ``DenseVectorIndexOptionsType.Flat round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.Flat
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.Flat

[<Fact>]
let ``DenseVectorIndexOptionsType.Hnsw round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.Hnsw
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.Hnsw

[<Fact>]
let ``DenseVectorIndexOptionsType.Int4Flat round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.Int4Flat
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.Int4Flat

[<Fact>]
let ``DenseVectorIndexOptionsType.Int4Hnsw round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.Int4Hnsw
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.Int4Hnsw

[<Fact>]
let ``DenseVectorIndexOptionsType.Int8Flat round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.Int8Flat
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.Int8Flat

[<Fact>]
let ``DenseVectorIndexOptionsType.Int8Hnsw round-trips`` () =
    let value = Types.DenseVectorIndexOptionsType.Int8Hnsw
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorIndexOptionsType> json
    roundTripped |> should equal Types.DenseVectorIndexOptionsType.Int8Hnsw

[<Fact>]
let ``DenseVectorSimilarity.Cosine round-trips`` () =
    let value = Types.DenseVectorSimilarity.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorSimilarity> json
    roundTripped |> should equal Types.DenseVectorSimilarity.Cosine

[<Fact>]
let ``DenseVectorSimilarity.DotProduct round-trips`` () =
    let value = Types.DenseVectorSimilarity.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorSimilarity> json
    roundTripped |> should equal Types.DenseVectorSimilarity.DotProduct

[<Fact>]
let ``DenseVectorSimilarity.L2Norm round-trips`` () =
    let value = Types.DenseVectorSimilarity.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorSimilarity> json
    roundTripped |> should equal Types.DenseVectorSimilarity.L2Norm

[<Fact>]
let ``DenseVectorSimilarity.MaxInnerProduct round-trips`` () =
    let value = Types.DenseVectorSimilarity.MaxInnerProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DenseVectorSimilarity> json
    roundTripped |> should equal Types.DenseVectorSimilarity.MaxInnerProduct

[<Fact>]
let ``DynamicMapping.Strict round-trips`` () =
    let value = Types.DynamicMapping.Strict
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DynamicMapping> json
    roundTripped |> should equal Types.DynamicMapping.Strict

[<Fact>]
let ``DynamicMapping.Runtime round-trips`` () =
    let value = Types.DynamicMapping.Runtime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DynamicMapping> json
    roundTripped |> should equal Types.DynamicMapping.Runtime

[<Fact>]
let ``DynamicMapping.True round-trips`` () =
    let value = Types.DynamicMapping.True
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DynamicMapping> json
    roundTripped |> should equal Types.DynamicMapping.True

[<Fact>]
let ``DynamicMapping.False round-trips`` () =
    let value = Types.DynamicMapping.False
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DynamicMapping> json
    roundTripped |> should equal Types.DynamicMapping.False

[<Fact>]
let ``FieldType.None round-trips`` () =
    let value = Types.FieldType.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.None

[<Fact>]
let ``FieldType.GeoPoint round-trips`` () =
    let value = Types.FieldType.GeoPoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.GeoPoint

[<Fact>]
let ``FieldType.GeoShape round-trips`` () =
    let value = Types.FieldType.GeoShape
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.GeoShape

[<Fact>]
let ``FieldType.Ip round-trips`` () =
    let value = Types.FieldType.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Ip

[<Fact>]
let ``FieldType.Binary round-trips`` () =
    let value = Types.FieldType.Binary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Binary

[<Fact>]
let ``FieldType.Keyword round-trips`` () =
    let value = Types.FieldType.Keyword
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Keyword

[<Fact>]
let ``FieldType.Text round-trips`` () =
    let value = Types.FieldType.Text
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Text

[<Fact>]
let ``FieldType.SearchAsYouType round-trips`` () =
    let value = Types.FieldType.SearchAsYouType
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.SearchAsYouType

[<Fact>]
let ``FieldType.Date round-trips`` () =
    let value = Types.FieldType.Date
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Date

[<Fact>]
let ``FieldType.DateNanos round-trips`` () =
    let value = Types.FieldType.DateNanos
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.DateNanos

[<Fact>]
let ``FieldType.Boolean round-trips`` () =
    let value = Types.FieldType.Boolean
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Boolean

[<Fact>]
let ``FieldType.Completion round-trips`` () =
    let value = Types.FieldType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Completion

[<Fact>]
let ``FieldType.Nested round-trips`` () =
    let value = Types.FieldType.Nested
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Nested

[<Fact>]
let ``FieldType.Object round-trips`` () =
    let value = Types.FieldType.Object
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Object

[<Fact>]
let ``FieldType.Passthrough round-trips`` () =
    let value = Types.FieldType.Passthrough
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Passthrough

[<Fact>]
let ``FieldType.Version round-trips`` () =
    let value = Types.FieldType.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Version

[<Fact>]
let ``FieldType.Murmur3 round-trips`` () =
    let value = Types.FieldType.Murmur3
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Murmur3

[<Fact>]
let ``FieldType.TokenCount round-trips`` () =
    let value = Types.FieldType.TokenCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.TokenCount

[<Fact>]
let ``FieldType.Percolator round-trips`` () =
    let value = Types.FieldType.Percolator
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Percolator

[<Fact>]
let ``FieldType.Integer round-trips`` () =
    let value = Types.FieldType.Integer
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Integer

[<Fact>]
let ``FieldType.Long round-trips`` () =
    let value = Types.FieldType.Long
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Long

[<Fact>]
let ``FieldType.Short round-trips`` () =
    let value = Types.FieldType.Short
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Short

[<Fact>]
let ``FieldType.Byte round-trips`` () =
    let value = Types.FieldType.Byte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Byte

[<Fact>]
let ``FieldType.Float round-trips`` () =
    let value = Types.FieldType.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Float

[<Fact>]
let ``FieldType.HalfFloat round-trips`` () =
    let value = Types.FieldType.HalfFloat
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.HalfFloat

[<Fact>]
let ``FieldType.ScaledFloat round-trips`` () =
    let value = Types.FieldType.ScaledFloat
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.ScaledFloat

[<Fact>]
let ``FieldType.Double round-trips`` () =
    let value = Types.FieldType.Double
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Double

[<Fact>]
let ``FieldType.IntegerRange round-trips`` () =
    let value = Types.FieldType.IntegerRange
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.IntegerRange

[<Fact>]
let ``FieldType.FloatRange round-trips`` () =
    let value = Types.FieldType.FloatRange
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.FloatRange

[<Fact>]
let ``FieldType.LongRange round-trips`` () =
    let value = Types.FieldType.LongRange
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.LongRange

[<Fact>]
let ``FieldType.DoubleRange round-trips`` () =
    let value = Types.FieldType.DoubleRange
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.DoubleRange

[<Fact>]
let ``FieldType.DateRange round-trips`` () =
    let value = Types.FieldType.DateRange
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.DateRange

[<Fact>]
let ``FieldType.IpRange round-trips`` () =
    let value = Types.FieldType.IpRange
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.IpRange

[<Fact>]
let ``FieldType.Alias round-trips`` () =
    let value = Types.FieldType.Alias
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Alias

[<Fact>]
let ``FieldType.Join round-trips`` () =
    let value = Types.FieldType.Join
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Join

[<Fact>]
let ``FieldType.RankFeature round-trips`` () =
    let value = Types.FieldType.RankFeature
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.RankFeature

[<Fact>]
let ``FieldType.RankFeatures round-trips`` () =
    let value = Types.FieldType.RankFeatures
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.RankFeatures

[<Fact>]
let ``FieldType.Flattened round-trips`` () =
    let value = Types.FieldType.Flattened
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Flattened

[<Fact>]
let ``FieldType.Shape round-trips`` () =
    let value = Types.FieldType.Shape
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Shape

[<Fact>]
let ``FieldType.Histogram round-trips`` () =
    let value = Types.FieldType.Histogram
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.Histogram

[<Fact>]
let ``FieldType.ConstantKeyword round-trips`` () =
    let value = Types.FieldType.ConstantKeyword
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.ConstantKeyword

[<Fact>]
let ``FieldType.CountedKeyword round-trips`` () =
    let value = Types.FieldType.CountedKeyword
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.CountedKeyword

[<Fact>]
let ``FieldType.AggregateMetricDouble round-trips`` () =
    let value = Types.FieldType.AggregateMetricDouble
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.AggregateMetricDouble

[<Fact>]
let ``FieldType.DenseVector round-trips`` () =
    let value = Types.FieldType.DenseVector
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.DenseVector

[<Fact>]
let ``FieldType.SemanticText round-trips`` () =
    let value = Types.FieldType.SemanticText
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.SemanticText

[<Fact>]
let ``FieldType.SparseVector round-trips`` () =
    let value = Types.FieldType.SparseVector
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.SparseVector

[<Fact>]
let ``FieldType.MatchOnlyText round-trips`` () =
    let value = Types.FieldType.MatchOnlyText
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.MatchOnlyText

[<Fact>]
let ``FieldType.IcuCollationKeyword round-trips`` () =
    let value = Types.FieldType.IcuCollationKeyword
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldType> json
    roundTripped |> should equal Types.FieldType.IcuCollationKeyword

[<Fact>]
let ``GeoOrientation.Right round-trips`` () =
    let value = Types.GeoOrientation.Right
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoOrientation> json
    roundTripped |> should equal Types.GeoOrientation.Right

[<Fact>]
let ``GeoOrientation.Left round-trips`` () =
    let value = Types.GeoOrientation.Left
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoOrientation> json
    roundTripped |> should equal Types.GeoOrientation.Left

[<Fact>]
let ``GeoPointMetricType.Gauge round-trips`` () =
    let value = Types.GeoPointMetricType.Gauge
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoPointMetricType> json
    roundTripped |> should equal Types.GeoPointMetricType.Gauge

[<Fact>]
let ``GeoPointMetricType.Counter round-trips`` () =
    let value = Types.GeoPointMetricType.Counter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoPointMetricType> json
    roundTripped |> should equal Types.GeoPointMetricType.Counter

[<Fact>]
let ``GeoPointMetricType.Position round-trips`` () =
    let value = Types.GeoPointMetricType.Position
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoPointMetricType> json
    roundTripped |> should equal Types.GeoPointMetricType.Position

[<Fact>]
let ``GeoStrategy.Recursive round-trips`` () =
    let value = Types.GeoStrategy.Recursive
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoStrategy> json
    roundTripped |> should equal Types.GeoStrategy.Recursive

[<Fact>]
let ``GeoStrategy.Term round-trips`` () =
    let value = Types.GeoStrategy.Term
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoStrategy> json
    roundTripped |> should equal Types.GeoStrategy.Term

[<Fact>]
let ``IndexOptions.Docs round-trips`` () =
    let value = Types.IndexOptions.Docs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexOptions> json
    roundTripped |> should equal Types.IndexOptions.Docs

[<Fact>]
let ``IndexOptions.Freqs round-trips`` () =
    let value = Types.IndexOptions.Freqs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexOptions> json
    roundTripped |> should equal Types.IndexOptions.Freqs

[<Fact>]
let ``IndexOptions.Positions round-trips`` () =
    let value = Types.IndexOptions.Positions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexOptions> json
    roundTripped |> should equal Types.IndexOptions.Positions

[<Fact>]
let ``IndexOptions.Offsets round-trips`` () =
    let value = Types.IndexOptions.Offsets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexOptions> json
    roundTripped |> should equal Types.IndexOptions.Offsets

[<Fact>]
let ``MatchType.Simple round-trips`` () =
    let value = Types.MatchType.Simple
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MatchType> json
    roundTripped |> should equal Types.MatchType.Simple

[<Fact>]
let ``MatchType.Regex round-trips`` () =
    let value = Types.MatchType.Regex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MatchType> json
    roundTripped |> should equal Types.MatchType.Regex

[<Fact>]
let ``OnScriptError.Fail round-trips`` () =
    let value = Types.OnScriptError.Fail
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OnScriptError> json
    roundTripped |> should equal Types.OnScriptError.Fail

[<Fact>]
let ``OnScriptError.Continue round-trips`` () =
    let value = Types.OnScriptError.Continue
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OnScriptError> json
    roundTripped |> should equal Types.OnScriptError.Continue

[<Fact>]
let ``RankVectorElementType.Byte round-trips`` () =
    let value = Types.RankVectorElementType.Byte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RankVectorElementType> json
    roundTripped |> should equal Types.RankVectorElementType.Byte

[<Fact>]
let ``RankVectorElementType.Float round-trips`` () =
    let value = Types.RankVectorElementType.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RankVectorElementType> json
    roundTripped |> should equal Types.RankVectorElementType.Float

[<Fact>]
let ``RankVectorElementType.Bit round-trips`` () =
    let value = Types.RankVectorElementType.Bit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RankVectorElementType> json
    roundTripped |> should equal Types.RankVectorElementType.Bit

[<Fact>]
let ``RuntimeFieldType.Boolean round-trips`` () =
    let value = Types.RuntimeFieldType.Boolean
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Boolean

[<Fact>]
let ``RuntimeFieldType.Composite round-trips`` () =
    let value = Types.RuntimeFieldType.Composite
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Composite

[<Fact>]
let ``RuntimeFieldType.Date round-trips`` () =
    let value = Types.RuntimeFieldType.Date
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Date

[<Fact>]
let ``RuntimeFieldType.Double round-trips`` () =
    let value = Types.RuntimeFieldType.Double
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Double

[<Fact>]
let ``RuntimeFieldType.GeoPoint round-trips`` () =
    let value = Types.RuntimeFieldType.GeoPoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.GeoPoint

[<Fact>]
let ``RuntimeFieldType.GeoShape round-trips`` () =
    let value = Types.RuntimeFieldType.GeoShape
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.GeoShape

[<Fact>]
let ``RuntimeFieldType.Ip round-trips`` () =
    let value = Types.RuntimeFieldType.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Ip

[<Fact>]
let ``RuntimeFieldType.Keyword round-trips`` () =
    let value = Types.RuntimeFieldType.Keyword
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Keyword

[<Fact>]
let ``RuntimeFieldType.Long round-trips`` () =
    let value = Types.RuntimeFieldType.Long
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Long

[<Fact>]
let ``RuntimeFieldType.Lookup round-trips`` () =
    let value = Types.RuntimeFieldType.Lookup
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuntimeFieldType> json
    roundTripped |> should equal Types.RuntimeFieldType.Lookup

[<Fact>]
let ``SourceFieldMode.Disabled round-trips`` () =
    let value = Types.SourceFieldMode.Disabled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SourceFieldMode> json
    roundTripped |> should equal Types.SourceFieldMode.Disabled

[<Fact>]
let ``SourceFieldMode.Stored round-trips`` () =
    let value = Types.SourceFieldMode.Stored
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SourceFieldMode> json
    roundTripped |> should equal Types.SourceFieldMode.Stored

[<Fact>]
let ``SourceFieldMode.Synthetic round-trips`` () =
    let value = Types.SourceFieldMode.Synthetic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SourceFieldMode> json
    roundTripped |> should equal Types.SourceFieldMode.Synthetic

[<Fact>]
let ``Subobjects.True round-trips`` () =
    let value = Types.Subobjects.True
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Subobjects> json
    roundTripped |> should equal Types.Subobjects.True

[<Fact>]
let ``Subobjects.False round-trips`` () =
    let value = Types.Subobjects.False
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Subobjects> json
    roundTripped |> should equal Types.Subobjects.False

[<Fact>]
let ``Subobjects.Auto round-trips`` () =
    let value = Types.Subobjects.Auto
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Subobjects> json
    roundTripped |> should equal Types.Subobjects.Auto

[<Fact>]
let ``SyntheticSourceKeepEnum.None round-trips`` () =
    let value = Types.SyntheticSourceKeepEnum.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyntheticSourceKeepEnum> json
    roundTripped |> should equal Types.SyntheticSourceKeepEnum.None

[<Fact>]
let ``SyntheticSourceKeepEnum.Arrays round-trips`` () =
    let value = Types.SyntheticSourceKeepEnum.Arrays
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyntheticSourceKeepEnum> json
    roundTripped |> should equal Types.SyntheticSourceKeepEnum.Arrays

[<Fact>]
let ``SyntheticSourceKeepEnum.All round-trips`` () =
    let value = Types.SyntheticSourceKeepEnum.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyntheticSourceKeepEnum> json
    roundTripped |> should equal Types.SyntheticSourceKeepEnum.All

[<Fact>]
let ``TermVectorOption.No round-trips`` () =
    let value = Types.TermVectorOption.No
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.No

[<Fact>]
let ``TermVectorOption.Yes round-trips`` () =
    let value = Types.TermVectorOption.Yes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.Yes

[<Fact>]
let ``TermVectorOption.WithOffsets round-trips`` () =
    let value = Types.TermVectorOption.WithOffsets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.WithOffsets

[<Fact>]
let ``TermVectorOption.WithPositions round-trips`` () =
    let value = Types.TermVectorOption.WithPositions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.WithPositions

[<Fact>]
let ``TermVectorOption.WithPositionsOffsets round-trips`` () =
    let value = Types.TermVectorOption.WithPositionsOffsets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.WithPositionsOffsets

[<Fact>]
let ``TermVectorOption.WithPositionsOffsetsPayloads round-trips`` () =
    let value = Types.TermVectorOption.WithPositionsOffsetsPayloads
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.WithPositionsOffsetsPayloads

[<Fact>]
let ``TermVectorOption.WithPositionsPayloads round-trips`` () =
    let value = Types.TermVectorOption.WithPositionsPayloads
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TermVectorOption> json
    roundTripped |> should equal Types.TermVectorOption.WithPositionsPayloads

[<Fact>]
let ``TimeSeriesMetricType.Gauge round-trips`` () =
    let value = Types.TimeSeriesMetricType.Gauge
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeSeriesMetricType> json
    roundTripped |> should equal Types.TimeSeriesMetricType.Gauge

[<Fact>]
let ``TimeSeriesMetricType.Counter round-trips`` () =
    let value = Types.TimeSeriesMetricType.Counter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeSeriesMetricType> json
    roundTripped |> should equal Types.TimeSeriesMetricType.Counter

[<Fact>]
let ``TimeSeriesMetricType.Summary round-trips`` () =
    let value = Types.TimeSeriesMetricType.Summary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeSeriesMetricType> json
    roundTripped |> should equal Types.TimeSeriesMetricType.Summary

[<Fact>]
let ``TimeSeriesMetricType.Histogram round-trips`` () =
    let value = Types.TimeSeriesMetricType.Histogram
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeSeriesMetricType> json
    roundTripped |> should equal Types.TimeSeriesMetricType.Histogram

[<Fact>]
let ``TimeSeriesMetricType.Position round-trips`` () =
    let value = Types.TimeSeriesMetricType.Position
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TimeSeriesMetricType> json
    roundTripped |> should equal Types.TimeSeriesMetricType.Position

[<Fact>]
let ``ChildScoreMode.None round-trips`` () =
    let value = Types.ChildScoreMode.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChildScoreMode> json
    roundTripped |> should equal Types.ChildScoreMode.None

[<Fact>]
let ``ChildScoreMode.Avg round-trips`` () =
    let value = Types.ChildScoreMode.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChildScoreMode> json
    roundTripped |> should equal Types.ChildScoreMode.Avg

[<Fact>]
let ``ChildScoreMode.Sum round-trips`` () =
    let value = Types.ChildScoreMode.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChildScoreMode> json
    roundTripped |> should equal Types.ChildScoreMode.Sum

[<Fact>]
let ``ChildScoreMode.Max round-trips`` () =
    let value = Types.ChildScoreMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChildScoreMode> json
    roundTripped |> should equal Types.ChildScoreMode.Max

[<Fact>]
let ``ChildScoreMode.Min round-trips`` () =
    let value = Types.ChildScoreMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChildScoreMode> json
    roundTripped |> should equal Types.ChildScoreMode.Min

[<Fact>]
let ``CombinedFieldsOperator.Or round-trips`` () =
    let value = Types.CombinedFieldsOperator.Or
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CombinedFieldsOperator> json
    roundTripped |> should equal Types.CombinedFieldsOperator.Or

[<Fact>]
let ``CombinedFieldsOperator.And round-trips`` () =
    let value = Types.CombinedFieldsOperator.And
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CombinedFieldsOperator> json
    roundTripped |> should equal Types.CombinedFieldsOperator.And

[<Fact>]
let ``CombinedFieldsZeroTerms.None round-trips`` () =
    let value = Types.CombinedFieldsZeroTerms.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CombinedFieldsZeroTerms> json
    roundTripped |> should equal Types.CombinedFieldsZeroTerms.None

[<Fact>]
let ``CombinedFieldsZeroTerms.All round-trips`` () =
    let value = Types.CombinedFieldsZeroTerms.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CombinedFieldsZeroTerms> json
    roundTripped |> should equal Types.CombinedFieldsZeroTerms.All

[<Fact>]
let ``FieldValueFactorModifier.None round-trips`` () =
    let value = Types.FieldValueFactorModifier.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.None

[<Fact>]
let ``FieldValueFactorModifier.Log round-trips`` () =
    let value = Types.FieldValueFactorModifier.Log
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Log

[<Fact>]
let ``FieldValueFactorModifier.Log1p round-trips`` () =
    let value = Types.FieldValueFactorModifier.Log1p
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Log1p

[<Fact>]
let ``FieldValueFactorModifier.Log2p round-trips`` () =
    let value = Types.FieldValueFactorModifier.Log2p
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Log2p

[<Fact>]
let ``FieldValueFactorModifier.Ln round-trips`` () =
    let value = Types.FieldValueFactorModifier.Ln
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Ln

[<Fact>]
let ``FieldValueFactorModifier.Ln1p round-trips`` () =
    let value = Types.FieldValueFactorModifier.Ln1p
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Ln1p

[<Fact>]
let ``FieldValueFactorModifier.Ln2p round-trips`` () =
    let value = Types.FieldValueFactorModifier.Ln2p
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Ln2p

[<Fact>]
let ``FieldValueFactorModifier.Square round-trips`` () =
    let value = Types.FieldValueFactorModifier.Square
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Square

[<Fact>]
let ``FieldValueFactorModifier.Sqrt round-trips`` () =
    let value = Types.FieldValueFactorModifier.Sqrt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Sqrt

[<Fact>]
let ``FieldValueFactorModifier.Reciprocal round-trips`` () =
    let value = Types.FieldValueFactorModifier.Reciprocal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldValueFactorModifier> json
    roundTripped |> should equal Types.FieldValueFactorModifier.Reciprocal

[<Fact>]
let ``FunctionBoostMode.Multiply round-trips`` () =
    let value = Types.FunctionBoostMode.Multiply
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionBoostMode> json
    roundTripped |> should equal Types.FunctionBoostMode.Multiply

[<Fact>]
let ``FunctionBoostMode.Replace round-trips`` () =
    let value = Types.FunctionBoostMode.Replace
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionBoostMode> json
    roundTripped |> should equal Types.FunctionBoostMode.Replace

[<Fact>]
let ``FunctionBoostMode.Sum round-trips`` () =
    let value = Types.FunctionBoostMode.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionBoostMode> json
    roundTripped |> should equal Types.FunctionBoostMode.Sum

[<Fact>]
let ``FunctionBoostMode.Avg round-trips`` () =
    let value = Types.FunctionBoostMode.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionBoostMode> json
    roundTripped |> should equal Types.FunctionBoostMode.Avg

[<Fact>]
let ``FunctionBoostMode.Max round-trips`` () =
    let value = Types.FunctionBoostMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionBoostMode> json
    roundTripped |> should equal Types.FunctionBoostMode.Max

[<Fact>]
let ``FunctionBoostMode.Min round-trips`` () =
    let value = Types.FunctionBoostMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionBoostMode> json
    roundTripped |> should equal Types.FunctionBoostMode.Min

[<Fact>]
let ``FunctionScoreMode.Multiply round-trips`` () =
    let value = Types.FunctionScoreMode.Multiply
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionScoreMode> json
    roundTripped |> should equal Types.FunctionScoreMode.Multiply

[<Fact>]
let ``FunctionScoreMode.Sum round-trips`` () =
    let value = Types.FunctionScoreMode.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionScoreMode> json
    roundTripped |> should equal Types.FunctionScoreMode.Sum

[<Fact>]
let ``FunctionScoreMode.Avg round-trips`` () =
    let value = Types.FunctionScoreMode.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionScoreMode> json
    roundTripped |> should equal Types.FunctionScoreMode.Avg

[<Fact>]
let ``FunctionScoreMode.First round-trips`` () =
    let value = Types.FunctionScoreMode.First
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionScoreMode> json
    roundTripped |> should equal Types.FunctionScoreMode.First

[<Fact>]
let ``FunctionScoreMode.Max round-trips`` () =
    let value = Types.FunctionScoreMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionScoreMode> json
    roundTripped |> should equal Types.FunctionScoreMode.Max

[<Fact>]
let ``FunctionScoreMode.Min round-trips`` () =
    let value = Types.FunctionScoreMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FunctionScoreMode> json
    roundTripped |> should equal Types.FunctionScoreMode.Min

[<Fact>]
let ``GeoExecution.Memory round-trips`` () =
    let value = Types.GeoExecution.Memory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoExecution> json
    roundTripped |> should equal Types.GeoExecution.Memory

[<Fact>]
let ``GeoExecution.Indexed round-trips`` () =
    let value = Types.GeoExecution.Indexed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoExecution> json
    roundTripped |> should equal Types.GeoExecution.Indexed

[<Fact>]
let ``GeoValidationMethod.Coerce round-trips`` () =
    let value = Types.GeoValidationMethod.Coerce
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoValidationMethod> json
    roundTripped |> should equal Types.GeoValidationMethod.Coerce

[<Fact>]
let ``GeoValidationMethod.IgnoreMalformed round-trips`` () =
    let value = Types.GeoValidationMethod.IgnoreMalformed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoValidationMethod> json
    roundTripped |> should equal Types.GeoValidationMethod.IgnoreMalformed

[<Fact>]
let ``GeoValidationMethod.Strict round-trips`` () =
    let value = Types.GeoValidationMethod.Strict
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoValidationMethod> json
    roundTripped |> should equal Types.GeoValidationMethod.Strict

[<Fact>]
let ``MultiValueMode.Min round-trips`` () =
    let value = Types.MultiValueMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MultiValueMode> json
    roundTripped |> should equal Types.MultiValueMode.Min

[<Fact>]
let ``MultiValueMode.Max round-trips`` () =
    let value = Types.MultiValueMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MultiValueMode> json
    roundTripped |> should equal Types.MultiValueMode.Max

[<Fact>]
let ``MultiValueMode.Avg round-trips`` () =
    let value = Types.MultiValueMode.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MultiValueMode> json
    roundTripped |> should equal Types.MultiValueMode.Avg

[<Fact>]
let ``MultiValueMode.Sum round-trips`` () =
    let value = Types.MultiValueMode.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MultiValueMode> json
    roundTripped |> should equal Types.MultiValueMode.Sum

[<Fact>]
let ``Operator.And round-trips`` () =
    let value = Types.Operator.And
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Operator> json
    roundTripped |> should equal Types.Operator.And

[<Fact>]
let ``Operator.Or round-trips`` () =
    let value = Types.Operator.Or
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Operator> json
    roundTripped |> should equal Types.Operator.Or

[<Fact>]
let ``RangeRelation.Within round-trips`` () =
    let value = Types.RangeRelation.Within
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RangeRelation> json
    roundTripped |> should equal Types.RangeRelation.Within

[<Fact>]
let ``RangeRelation.Contains round-trips`` () =
    let value = Types.RangeRelation.Contains
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RangeRelation> json
    roundTripped |> should equal Types.RangeRelation.Contains

[<Fact>]
let ``RangeRelation.Intersects round-trips`` () =
    let value = Types.RangeRelation.Intersects
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RangeRelation> json
    roundTripped |> should equal Types.RangeRelation.Intersects

[<Fact>]
let ``SimpleQueryStringFlag.NONE round-trips`` () =
    let value = Types.SimpleQueryStringFlag.NONE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.NONE

[<Fact>]
let ``SimpleQueryStringFlag.AND round-trips`` () =
    let value = Types.SimpleQueryStringFlag.AND
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.AND

[<Fact>]
let ``SimpleQueryStringFlag.NOT round-trips`` () =
    let value = Types.SimpleQueryStringFlag.NOT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.NOT

[<Fact>]
let ``SimpleQueryStringFlag.OR round-trips`` () =
    let value = Types.SimpleQueryStringFlag.OR
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.OR

[<Fact>]
let ``SimpleQueryStringFlag.PREFIX round-trips`` () =
    let value = Types.SimpleQueryStringFlag.PREFIX
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.PREFIX

[<Fact>]
let ``SimpleQueryStringFlag.PHRASE round-trips`` () =
    let value = Types.SimpleQueryStringFlag.PHRASE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.PHRASE

[<Fact>]
let ``SimpleQueryStringFlag.PRECEDENCE round-trips`` () =
    let value = Types.SimpleQueryStringFlag.PRECEDENCE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.PRECEDENCE

[<Fact>]
let ``SimpleQueryStringFlag.ESCAPE round-trips`` () =
    let value = Types.SimpleQueryStringFlag.ESCAPE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.ESCAPE

[<Fact>]
let ``SimpleQueryStringFlag.WHITESPACE round-trips`` () =
    let value = Types.SimpleQueryStringFlag.WHITESPACE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.WHITESPACE

[<Fact>]
let ``SimpleQueryStringFlag.FUZZY round-trips`` () =
    let value = Types.SimpleQueryStringFlag.FUZZY
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.FUZZY

[<Fact>]
let ``SimpleQueryStringFlag.NEAR round-trips`` () =
    let value = Types.SimpleQueryStringFlag.NEAR
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.NEAR

[<Fact>]
let ``SimpleQueryStringFlag.SLOP round-trips`` () =
    let value = Types.SimpleQueryStringFlag.SLOP
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.SLOP

[<Fact>]
let ``SimpleQueryStringFlag.ALL round-trips`` () =
    let value = Types.SimpleQueryStringFlag.ALL
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SimpleQueryStringFlag> json
    roundTripped |> should equal Types.SimpleQueryStringFlag.ALL

[<Fact>]
let ``TextQueryType.BestFields round-trips`` () =
    let value = Types.TextQueryType.BestFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TextQueryType> json
    roundTripped |> should equal Types.TextQueryType.BestFields

[<Fact>]
let ``TextQueryType.MostFields round-trips`` () =
    let value = Types.TextQueryType.MostFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TextQueryType> json
    roundTripped |> should equal Types.TextQueryType.MostFields

[<Fact>]
let ``TextQueryType.CrossFields round-trips`` () =
    let value = Types.TextQueryType.CrossFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TextQueryType> json
    roundTripped |> should equal Types.TextQueryType.CrossFields

[<Fact>]
let ``TextQueryType.Phrase round-trips`` () =
    let value = Types.TextQueryType.Phrase
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TextQueryType> json
    roundTripped |> should equal Types.TextQueryType.Phrase

[<Fact>]
let ``TextQueryType.PhrasePrefix round-trips`` () =
    let value = Types.TextQueryType.PhrasePrefix
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TextQueryType> json
    roundTripped |> should equal Types.TextQueryType.PhrasePrefix

[<Fact>]
let ``TextQueryType.BoolPrefix round-trips`` () =
    let value = Types.TextQueryType.BoolPrefix
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TextQueryType> json
    roundTripped |> should equal Types.TextQueryType.BoolPrefix

[<Fact>]
let ``ZeroTermsQuery.All round-trips`` () =
    let value = Types.ZeroTermsQuery.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ZeroTermsQuery> json
    roundTripped |> should equal Types.ZeroTermsQuery.All

[<Fact>]
let ``ZeroTermsQuery.None round-trips`` () =
    let value = Types.ZeroTermsQuery.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ZeroTermsQuery> json
    roundTripped |> should equal Types.ZeroTermsQuery.None

[<Fact>]
let ``CatAliasesColumn.Alias round-trips`` () =
    let value = Types.CatAliasesColumn.Alias
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAliasesColumn> json
    roundTripped |> should equal Types.CatAliasesColumn.Alias

[<Fact>]
let ``CatAliasesColumn.Index round-trips`` () =
    let value = Types.CatAliasesColumn.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAliasesColumn> json
    roundTripped |> should equal Types.CatAliasesColumn.Index

[<Fact>]
let ``CatAliasesColumn.Filter round-trips`` () =
    let value = Types.CatAliasesColumn.Filter
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAliasesColumn> json
    roundTripped |> should equal Types.CatAliasesColumn.Filter

[<Fact>]
let ``CatAliasesColumn.RoutingIndex round-trips`` () =
    let value = Types.CatAliasesColumn.RoutingIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAliasesColumn> json
    roundTripped |> should equal Types.CatAliasesColumn.RoutingIndex

[<Fact>]
let ``CatAliasesColumn.RoutingSearch round-trips`` () =
    let value = Types.CatAliasesColumn.RoutingSearch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAliasesColumn> json
    roundTripped |> should equal Types.CatAliasesColumn.RoutingSearch

[<Fact>]
let ``CatAliasesColumn.IsWriteIndex round-trips`` () =
    let value = Types.CatAliasesColumn.IsWriteIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAliasesColumn> json
    roundTripped |> should equal Types.CatAliasesColumn.IsWriteIndex

[<Fact>]
let ``CatAllocationColumn.Shards round-trips`` () =
    let value = Types.CatAllocationColumn.Shards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.Shards

[<Fact>]
let ``CatAllocationColumn.ShardsUndesired round-trips`` () =
    let value = Types.CatAllocationColumn.ShardsUndesired
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.ShardsUndesired

[<Fact>]
let ``CatAllocationColumn.WriteLoadForecast round-trips`` () =
    let value = Types.CatAllocationColumn.WriteLoadForecast
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.WriteLoadForecast

[<Fact>]
let ``CatAllocationColumn.DiskIndicesForecast round-trips`` () =
    let value = Types.CatAllocationColumn.DiskIndicesForecast
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.DiskIndicesForecast

[<Fact>]
let ``CatAllocationColumn.DiskIndices round-trips`` () =
    let value = Types.CatAllocationColumn.DiskIndices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.DiskIndices

[<Fact>]
let ``CatAllocationColumn.DiskUsed round-trips`` () =
    let value = Types.CatAllocationColumn.DiskUsed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.DiskUsed

[<Fact>]
let ``CatAllocationColumn.DiskAvail round-trips`` () =
    let value = Types.CatAllocationColumn.DiskAvail
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.DiskAvail

[<Fact>]
let ``CatAllocationColumn.DiskTotal round-trips`` () =
    let value = Types.CatAllocationColumn.DiskTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.DiskTotal

[<Fact>]
let ``CatAllocationColumn.DiskPercent round-trips`` () =
    let value = Types.CatAllocationColumn.DiskPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.DiskPercent

[<Fact>]
let ``CatAllocationColumn.Host round-trips`` () =
    let value = Types.CatAllocationColumn.Host
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.Host

[<Fact>]
let ``CatAllocationColumn.Ip round-trips`` () =
    let value = Types.CatAllocationColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.Ip

[<Fact>]
let ``CatAllocationColumn.Node round-trips`` () =
    let value = Types.CatAllocationColumn.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.Node

[<Fact>]
let ``CatAllocationColumn.NodeRole round-trips`` () =
    let value = Types.CatAllocationColumn.NodeRole
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAllocationColumn> json
    roundTripped |> should equal Types.CatAllocationColumn.NodeRole

[<Fact>]
let ``CatAnomalyDetectorColumn.AssignmentExplanation round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.AssignmentExplanation
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.AssignmentExplanation

[<Fact>]
let ``CatAnomalyDetectorColumn.BucketsCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.BucketsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.BucketsCount

[<Fact>]
let ``CatAnomalyDetectorColumn.BucketsTimeExpAvg round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.BucketsTimeExpAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.BucketsTimeExpAvg

[<Fact>]
let ``CatAnomalyDetectorColumn.BucketsTimeExpAvgHour round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.BucketsTimeExpAvgHour
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.BucketsTimeExpAvgHour

[<Fact>]
let ``CatAnomalyDetectorColumn.BucketsTimeMax round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.BucketsTimeMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.BucketsTimeMax

[<Fact>]
let ``CatAnomalyDetectorColumn.BucketsTimeMin round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.BucketsTimeMin
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.BucketsTimeMin

[<Fact>]
let ``CatAnomalyDetectorColumn.BucketsTimeTotal round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.BucketsTimeTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.BucketsTimeTotal

[<Fact>]
let ``CatAnomalyDetectorColumn.DataBuckets round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataBuckets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataBuckets

[<Fact>]
let ``CatAnomalyDetectorColumn.DataEarliestRecord round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataEarliestRecord
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataEarliestRecord

[<Fact>]
let ``CatAnomalyDetectorColumn.DataEmptyBuckets round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataEmptyBuckets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataEmptyBuckets

[<Fact>]
let ``CatAnomalyDetectorColumn.DataInputBytes round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataInputBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataInputBytes

[<Fact>]
let ``CatAnomalyDetectorColumn.DataInputFields round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataInputFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataInputFields

[<Fact>]
let ``CatAnomalyDetectorColumn.DataInputRecords round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataInputRecords
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataInputRecords

[<Fact>]
let ``CatAnomalyDetectorColumn.DataInvalidDates round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataInvalidDates
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataInvalidDates

[<Fact>]
let ``CatAnomalyDetectorColumn.DataLast round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataLast
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataLast

[<Fact>]
let ``CatAnomalyDetectorColumn.DataLastEmptyBucket round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataLastEmptyBucket
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataLastEmptyBucket

[<Fact>]
let ``CatAnomalyDetectorColumn.DataLastSparseBucket round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataLastSparseBucket
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataLastSparseBucket

[<Fact>]
let ``CatAnomalyDetectorColumn.DataLatestRecord round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataLatestRecord
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataLatestRecord

[<Fact>]
let ``CatAnomalyDetectorColumn.DataMissingFields round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataMissingFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataMissingFields

[<Fact>]
let ``CatAnomalyDetectorColumn.DataOutOfOrderTimestamps round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataOutOfOrderTimestamps
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataOutOfOrderTimestamps

[<Fact>]
let ``CatAnomalyDetectorColumn.DataProcessedFields round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataProcessedFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataProcessedFields

[<Fact>]
let ``CatAnomalyDetectorColumn.DataProcessedRecords round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataProcessedRecords
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataProcessedRecords

[<Fact>]
let ``CatAnomalyDetectorColumn.DataSparseBuckets round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.DataSparseBuckets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.DataSparseBuckets

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsMemoryAvg round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsMemoryAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsMemoryAvg

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsMemoryMax round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsMemoryMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsMemoryMax

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsMemoryMin round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsMemoryMin
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsMemoryMin

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsMemoryTotal round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsMemoryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsMemoryTotal

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsRecordsAvg round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsRecordsAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsRecordsAvg

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsRecordsMax round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsRecordsMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsRecordsMax

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsRecordsMin round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsRecordsMin
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsRecordsMin

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsRecordsTotal round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsRecordsTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsRecordsTotal

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsTimeAvg round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsTimeAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsTimeAvg

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsTimeMax round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsTimeMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsTimeMax

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsTimeMin round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsTimeMin
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsTimeMin

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsTimeTotal round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsTimeTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsTimeTotal

[<Fact>]
let ``CatAnomalyDetectorColumn.ForecastsTotal round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ForecastsTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ForecastsTotal

[<Fact>]
let ``CatAnomalyDetectorColumn.Id round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.Id

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelBucketAllocationFailures round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelBucketAllocationFailures
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelBucketAllocationFailures

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelByFields round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelByFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelByFields

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelBytes round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelBytes

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelBytesExceeded round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelBytesExceeded
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelBytesExceeded

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelCategorizationStatus round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelCategorizationStatus
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelCategorizationStatus

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelCategorizedDocCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelCategorizedDocCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelCategorizedDocCount

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelDeadCategoryCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelDeadCategoryCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelDeadCategoryCount

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelFailedCategoryCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelFailedCategoryCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelFailedCategoryCount

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelFrequentCategoryCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelFrequentCategoryCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelFrequentCategoryCount

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelLogTime round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelLogTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelLogTime

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelMemoryLimit round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelMemoryLimit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelMemoryLimit

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelMemoryStatus round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelMemoryStatus
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelMemoryStatus

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelOverFields round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelOverFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelOverFields

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelPartitionFields round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelPartitionFields
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelPartitionFields

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelRareCategoryCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelRareCategoryCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelRareCategoryCount

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelTimestamp round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelTimestamp
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelTimestamp

[<Fact>]
let ``CatAnomalyDetectorColumn.ModelTotalCategoryCount round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.ModelTotalCategoryCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.ModelTotalCategoryCount

[<Fact>]
let ``CatAnomalyDetectorColumn.NodeAddress round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.NodeAddress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.NodeAddress

[<Fact>]
let ``CatAnomalyDetectorColumn.NodeEphemeralId round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.NodeEphemeralId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.NodeEphemeralId

[<Fact>]
let ``CatAnomalyDetectorColumn.NodeId round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.NodeId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.NodeId

[<Fact>]
let ``CatAnomalyDetectorColumn.NodeName round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.NodeName
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.NodeName

[<Fact>]
let ``CatAnomalyDetectorColumn.OpenedTime round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.OpenedTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.OpenedTime

[<Fact>]
let ``CatAnomalyDetectorColumn.State round-trips`` () =
    let value = Types.CatAnomalyDetectorColumn.State
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatAnomalyDetectorColumn> json
    roundTripped |> should equal Types.CatAnomalyDetectorColumn.State

[<Fact>]
let ``CatCircuitBreakerColumn.NodeId round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.NodeId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.NodeId

[<Fact>]
let ``CatCircuitBreakerColumn.NodeName round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.NodeName
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.NodeName

[<Fact>]
let ``CatCircuitBreakerColumn.Breaker round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.Breaker
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.Breaker

[<Fact>]
let ``CatCircuitBreakerColumn.Limit round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.Limit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.Limit

[<Fact>]
let ``CatCircuitBreakerColumn.LimitBytes round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.LimitBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.LimitBytes

[<Fact>]
let ``CatCircuitBreakerColumn.Estimated round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.Estimated
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.Estimated

[<Fact>]
let ``CatCircuitBreakerColumn.EstimatedBytes round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.EstimatedBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.EstimatedBytes

[<Fact>]
let ``CatCircuitBreakerColumn.Tripped round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.Tripped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.Tripped

[<Fact>]
let ``CatCircuitBreakerColumn.Overhead round-trips`` () =
    let value = Types.CatCircuitBreakerColumn.Overhead
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCircuitBreakerColumn> json
    roundTripped |> should equal Types.CatCircuitBreakerColumn.Overhead

[<Fact>]
let ``CatComponentColumn.Name round-trips`` () =
    let value = Types.CatComponentColumn.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.Name

[<Fact>]
let ``CatComponentColumn.Version round-trips`` () =
    let value = Types.CatComponentColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.Version

[<Fact>]
let ``CatComponentColumn.AliasCount round-trips`` () =
    let value = Types.CatComponentColumn.AliasCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.AliasCount

[<Fact>]
let ``CatComponentColumn.MappingCount round-trips`` () =
    let value = Types.CatComponentColumn.MappingCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.MappingCount

[<Fact>]
let ``CatComponentColumn.SettingsCount round-trips`` () =
    let value = Types.CatComponentColumn.SettingsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.SettingsCount

[<Fact>]
let ``CatComponentColumn.MetadataCount round-trips`` () =
    let value = Types.CatComponentColumn.MetadataCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.MetadataCount

[<Fact>]
let ``CatComponentColumn.IncludedIn round-trips`` () =
    let value = Types.CatComponentColumn.IncludedIn
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatComponentColumn> json
    roundTripped |> should equal Types.CatComponentColumn.IncludedIn

[<Fact>]
let ``CatCountColumn.Epoch round-trips`` () =
    let value = Types.CatCountColumn.Epoch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCountColumn> json
    roundTripped |> should equal Types.CatCountColumn.Epoch

[<Fact>]
let ``CatCountColumn.Timestamp round-trips`` () =
    let value = Types.CatCountColumn.Timestamp
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCountColumn> json
    roundTripped |> should equal Types.CatCountColumn.Timestamp

[<Fact>]
let ``CatCountColumn.Count round-trips`` () =
    let value = Types.CatCountColumn.Count
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatCountColumn> json
    roundTripped |> should equal Types.CatCountColumn.Count

[<Fact>]
let ``CatDatafeedColumn.Ae round-trips`` () =
    let value = Types.CatDatafeedColumn.Ae
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Ae

[<Fact>]
let ``CatDatafeedColumn.Bc round-trips`` () =
    let value = Types.CatDatafeedColumn.Bc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Bc

[<Fact>]
let ``CatDatafeedColumn.Id round-trips`` () =
    let value = Types.CatDatafeedColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Id

[<Fact>]
let ``CatDatafeedColumn.Na round-trips`` () =
    let value = Types.CatDatafeedColumn.Na
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Na

[<Fact>]
let ``CatDatafeedColumn.Ne round-trips`` () =
    let value = Types.CatDatafeedColumn.Ne
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Ne

[<Fact>]
let ``CatDatafeedColumn.Ni round-trips`` () =
    let value = Types.CatDatafeedColumn.Ni
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Ni

[<Fact>]
let ``CatDatafeedColumn.Nn round-trips`` () =
    let value = Types.CatDatafeedColumn.Nn
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Nn

[<Fact>]
let ``CatDatafeedColumn.Sba round-trips`` () =
    let value = Types.CatDatafeedColumn.Sba
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Sba

[<Fact>]
let ``CatDatafeedColumn.Sc round-trips`` () =
    let value = Types.CatDatafeedColumn.Sc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Sc

[<Fact>]
let ``CatDatafeedColumn.Seah round-trips`` () =
    let value = Types.CatDatafeedColumn.Seah
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.Seah

[<Fact>]
let ``CatDatafeedColumn.St round-trips`` () =
    let value = Types.CatDatafeedColumn.St
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.St

[<Fact>]
let ``CatDatafeedColumn.S round-trips`` () =
    let value = Types.CatDatafeedColumn.S
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDatafeedColumn> json
    roundTripped |> should equal Types.CatDatafeedColumn.S

[<Fact>]
let ``CatDfaColumn.AssignmentExplanation round-trips`` () =
    let value = Types.CatDfaColumn.AssignmentExplanation
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.AssignmentExplanation

[<Fact>]
let ``CatDfaColumn.CreateTime round-trips`` () =
    let value = Types.CatDfaColumn.CreateTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.CreateTime

[<Fact>]
let ``CatDfaColumn.Description round-trips`` () =
    let value = Types.CatDfaColumn.Description
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.Description

[<Fact>]
let ``CatDfaColumn.DestIndex round-trips`` () =
    let value = Types.CatDfaColumn.DestIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.DestIndex

[<Fact>]
let ``CatDfaColumn.FailureReason round-trips`` () =
    let value = Types.CatDfaColumn.FailureReason
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.FailureReason

[<Fact>]
let ``CatDfaColumn.Id round-trips`` () =
    let value = Types.CatDfaColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.Id

[<Fact>]
let ``CatDfaColumn.ModelMemoryLimit round-trips`` () =
    let value = Types.CatDfaColumn.ModelMemoryLimit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.ModelMemoryLimit

[<Fact>]
let ``CatDfaColumn.NodeAddress round-trips`` () =
    let value = Types.CatDfaColumn.NodeAddress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.NodeAddress

[<Fact>]
let ``CatDfaColumn.NodeEphemeralId round-trips`` () =
    let value = Types.CatDfaColumn.NodeEphemeralId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.NodeEphemeralId

[<Fact>]
let ``CatDfaColumn.NodeId round-trips`` () =
    let value = Types.CatDfaColumn.NodeId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.NodeId

[<Fact>]
let ``CatDfaColumn.NodeName round-trips`` () =
    let value = Types.CatDfaColumn.NodeName
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.NodeName

[<Fact>]
let ``CatDfaColumn.Progress round-trips`` () =
    let value = Types.CatDfaColumn.Progress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.Progress

[<Fact>]
let ``CatDfaColumn.SourceIndex round-trips`` () =
    let value = Types.CatDfaColumn.SourceIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.SourceIndex

[<Fact>]
let ``CatDfaColumn.State round-trips`` () =
    let value = Types.CatDfaColumn.State
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.State

[<Fact>]
let ``CatDfaColumn.Type round-trips`` () =
    let value = Types.CatDfaColumn.Type
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.Type

[<Fact>]
let ``CatDfaColumn.Version round-trips`` () =
    let value = Types.CatDfaColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatDfaColumn> json
    roundTripped |> should equal Types.CatDfaColumn.Version

[<Fact>]
let ``CatFieldDataColumn.Id round-trips`` () =
    let value = Types.CatFieldDataColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatFieldDataColumn> json
    roundTripped |> should equal Types.CatFieldDataColumn.Id

[<Fact>]
let ``CatFieldDataColumn.Host round-trips`` () =
    let value = Types.CatFieldDataColumn.Host
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatFieldDataColumn> json
    roundTripped |> should equal Types.CatFieldDataColumn.Host

[<Fact>]
let ``CatFieldDataColumn.Ip round-trips`` () =
    let value = Types.CatFieldDataColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatFieldDataColumn> json
    roundTripped |> should equal Types.CatFieldDataColumn.Ip

[<Fact>]
let ``CatFieldDataColumn.Node round-trips`` () =
    let value = Types.CatFieldDataColumn.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatFieldDataColumn> json
    roundTripped |> should equal Types.CatFieldDataColumn.Node

[<Fact>]
let ``CatFieldDataColumn.Field round-trips`` () =
    let value = Types.CatFieldDataColumn.Field
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatFieldDataColumn> json
    roundTripped |> should equal Types.CatFieldDataColumn.Field

[<Fact>]
let ``CatFieldDataColumn.Size round-trips`` () =
    let value = Types.CatFieldDataColumn.Size
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatFieldDataColumn> json
    roundTripped |> should equal Types.CatFieldDataColumn.Size

[<Fact>]
let ``CatHealthColumn.Epoch round-trips`` () =
    let value = Types.CatHealthColumn.Epoch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Epoch

[<Fact>]
let ``CatHealthColumn.Timestamp round-trips`` () =
    let value = Types.CatHealthColumn.Timestamp
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Timestamp

[<Fact>]
let ``CatHealthColumn.Cluster round-trips`` () =
    let value = Types.CatHealthColumn.Cluster
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Cluster

[<Fact>]
let ``CatHealthColumn.Status round-trips`` () =
    let value = Types.CatHealthColumn.Status
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Status

[<Fact>]
let ``CatHealthColumn.NodeTotal round-trips`` () =
    let value = Types.CatHealthColumn.NodeTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.NodeTotal

[<Fact>]
let ``CatHealthColumn.NodeData round-trips`` () =
    let value = Types.CatHealthColumn.NodeData
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.NodeData

[<Fact>]
let ``CatHealthColumn.Shards round-trips`` () =
    let value = Types.CatHealthColumn.Shards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Shards

[<Fact>]
let ``CatHealthColumn.Pri round-trips`` () =
    let value = Types.CatHealthColumn.Pri
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Pri

[<Fact>]
let ``CatHealthColumn.Relo round-trips`` () =
    let value = Types.CatHealthColumn.Relo
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Relo

[<Fact>]
let ``CatHealthColumn.Init round-trips`` () =
    let value = Types.CatHealthColumn.Init
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Init

[<Fact>]
let ``CatHealthColumn.Unassign round-trips`` () =
    let value = Types.CatHealthColumn.Unassign
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.Unassign

[<Fact>]
let ``CatHealthColumn.UnassignPri round-trips`` () =
    let value = Types.CatHealthColumn.UnassignPri
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.UnassignPri

[<Fact>]
let ``CatHealthColumn.PendingTasks round-trips`` () =
    let value = Types.CatHealthColumn.PendingTasks
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.PendingTasks

[<Fact>]
let ``CatHealthColumn.MaxTaskWaitTime round-trips`` () =
    let value = Types.CatHealthColumn.MaxTaskWaitTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.MaxTaskWaitTime

[<Fact>]
let ``CatHealthColumn.ActiveShardsPercent round-trips`` () =
    let value = Types.CatHealthColumn.ActiveShardsPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatHealthColumn> json
    roundTripped |> should equal Types.CatHealthColumn.ActiveShardsPercent

[<Fact>]
let ``CatIndicesColumn.Health round-trips`` () =
    let value = Types.CatIndicesColumn.Health
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.Health

[<Fact>]
let ``CatIndicesColumn.Status round-trips`` () =
    let value = Types.CatIndicesColumn.Status
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.Status

[<Fact>]
let ``CatIndicesColumn.Index round-trips`` () =
    let value = Types.CatIndicesColumn.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.Index

[<Fact>]
let ``CatIndicesColumn.Uuid round-trips`` () =
    let value = Types.CatIndicesColumn.Uuid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.Uuid

[<Fact>]
let ``CatIndicesColumn.Pri round-trips`` () =
    let value = Types.CatIndicesColumn.Pri
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.Pri

[<Fact>]
let ``CatIndicesColumn.Rep round-trips`` () =
    let value = Types.CatIndicesColumn.Rep
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.Rep

[<Fact>]
let ``CatIndicesColumn.DocsCount round-trips`` () =
    let value = Types.CatIndicesColumn.DocsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.DocsCount

[<Fact>]
let ``CatIndicesColumn.DocsDeleted round-trips`` () =
    let value = Types.CatIndicesColumn.DocsDeleted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.DocsDeleted

[<Fact>]
let ``CatIndicesColumn.CreationDate round-trips`` () =
    let value = Types.CatIndicesColumn.CreationDate
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.CreationDate

[<Fact>]
let ``CatIndicesColumn.CreationDateString round-trips`` () =
    let value = Types.CatIndicesColumn.CreationDateString
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.CreationDateString

[<Fact>]
let ``CatIndicesColumn.StoreSize round-trips`` () =
    let value = Types.CatIndicesColumn.StoreSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.StoreSize

[<Fact>]
let ``CatIndicesColumn.PriStoreSize round-trips`` () =
    let value = Types.CatIndicesColumn.PriStoreSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriStoreSize

[<Fact>]
let ``CatIndicesColumn.DatasetSize round-trips`` () =
    let value = Types.CatIndicesColumn.DatasetSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.DatasetSize

[<Fact>]
let ``CatIndicesColumn.CompletionSize round-trips`` () =
    let value = Types.CatIndicesColumn.CompletionSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.CompletionSize

[<Fact>]
let ``CatIndicesColumn.PriCompletionSize round-trips`` () =
    let value = Types.CatIndicesColumn.PriCompletionSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriCompletionSize

[<Fact>]
let ``CatIndicesColumn.FielddataMemorySize round-trips`` () =
    let value = Types.CatIndicesColumn.FielddataMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.FielddataMemorySize

[<Fact>]
let ``CatIndicesColumn.PriFielddataMemorySize round-trips`` () =
    let value = Types.CatIndicesColumn.PriFielddataMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriFielddataMemorySize

[<Fact>]
let ``CatIndicesColumn.FielddataEvictions round-trips`` () =
    let value = Types.CatIndicesColumn.FielddataEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.FielddataEvictions

[<Fact>]
let ``CatIndicesColumn.PriFielddataEvictions round-trips`` () =
    let value = Types.CatIndicesColumn.PriFielddataEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriFielddataEvictions

[<Fact>]
let ``CatIndicesColumn.QueryCacheMemorySize round-trips`` () =
    let value = Types.CatIndicesColumn.QueryCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.QueryCacheMemorySize

[<Fact>]
let ``CatIndicesColumn.PriQueryCacheMemorySize round-trips`` () =
    let value = Types.CatIndicesColumn.PriQueryCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriQueryCacheMemorySize

[<Fact>]
let ``CatIndicesColumn.QueryCacheEvictions round-trips`` () =
    let value = Types.CatIndicesColumn.QueryCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.QueryCacheEvictions

[<Fact>]
let ``CatIndicesColumn.PriQueryCacheEvictions round-trips`` () =
    let value = Types.CatIndicesColumn.PriQueryCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriQueryCacheEvictions

[<Fact>]
let ``CatIndicesColumn.RequestCacheMemorySize round-trips`` () =
    let value = Types.CatIndicesColumn.RequestCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RequestCacheMemorySize

[<Fact>]
let ``CatIndicesColumn.PriRequestCacheMemorySize round-trips`` () =
    let value = Types.CatIndicesColumn.PriRequestCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRequestCacheMemorySize

[<Fact>]
let ``CatIndicesColumn.RequestCacheEvictions round-trips`` () =
    let value = Types.CatIndicesColumn.RequestCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RequestCacheEvictions

[<Fact>]
let ``CatIndicesColumn.PriRequestCacheEvictions round-trips`` () =
    let value = Types.CatIndicesColumn.PriRequestCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRequestCacheEvictions

[<Fact>]
let ``CatIndicesColumn.RequestCacheHitCount round-trips`` () =
    let value = Types.CatIndicesColumn.RequestCacheHitCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RequestCacheHitCount

[<Fact>]
let ``CatIndicesColumn.PriRequestCacheHitCount round-trips`` () =
    let value = Types.CatIndicesColumn.PriRequestCacheHitCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRequestCacheHitCount

[<Fact>]
let ``CatIndicesColumn.RequestCacheMissCount round-trips`` () =
    let value = Types.CatIndicesColumn.RequestCacheMissCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RequestCacheMissCount

[<Fact>]
let ``CatIndicesColumn.PriRequestCacheMissCount round-trips`` () =
    let value = Types.CatIndicesColumn.PriRequestCacheMissCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRequestCacheMissCount

[<Fact>]
let ``CatIndicesColumn.FlushTotal round-trips`` () =
    let value = Types.CatIndicesColumn.FlushTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.FlushTotal

[<Fact>]
let ``CatIndicesColumn.PriFlushTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriFlushTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriFlushTotal

[<Fact>]
let ``CatIndicesColumn.FlushTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.FlushTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.FlushTotalTime

[<Fact>]
let ``CatIndicesColumn.PriFlushTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriFlushTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriFlushTotalTime

[<Fact>]
let ``CatIndicesColumn.GetCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.GetCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetCurrent

[<Fact>]
let ``CatIndicesColumn.PriGetCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetCurrent

[<Fact>]
let ``CatIndicesColumn.GetTime round-trips`` () =
    let value = Types.CatIndicesColumn.GetTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetTime

[<Fact>]
let ``CatIndicesColumn.PriGetTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetTime

[<Fact>]
let ``CatIndicesColumn.GetTotal round-trips`` () =
    let value = Types.CatIndicesColumn.GetTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetTotal

[<Fact>]
let ``CatIndicesColumn.PriGetTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetTotal

[<Fact>]
let ``CatIndicesColumn.GetExistsTime round-trips`` () =
    let value = Types.CatIndicesColumn.GetExistsTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetExistsTime

[<Fact>]
let ``CatIndicesColumn.PriGetExistsTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetExistsTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetExistsTime

[<Fact>]
let ``CatIndicesColumn.GetExistsTotal round-trips`` () =
    let value = Types.CatIndicesColumn.GetExistsTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetExistsTotal

[<Fact>]
let ``CatIndicesColumn.PriGetExistsTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetExistsTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetExistsTotal

[<Fact>]
let ``CatIndicesColumn.GetMissingTime round-trips`` () =
    let value = Types.CatIndicesColumn.GetMissingTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetMissingTime

[<Fact>]
let ``CatIndicesColumn.PriGetMissingTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetMissingTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetMissingTime

[<Fact>]
let ``CatIndicesColumn.GetMissingTotal round-trips`` () =
    let value = Types.CatIndicesColumn.GetMissingTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.GetMissingTotal

[<Fact>]
let ``CatIndicesColumn.PriGetMissingTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriGetMissingTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriGetMissingTotal

[<Fact>]
let ``CatIndicesColumn.IndexingDeleteCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingDeleteCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingDeleteCurrent

[<Fact>]
let ``CatIndicesColumn.PriIndexingDeleteCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingDeleteCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingDeleteCurrent

[<Fact>]
let ``CatIndicesColumn.IndexingDeleteTime round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingDeleteTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingDeleteTime

[<Fact>]
let ``CatIndicesColumn.PriIndexingDeleteTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingDeleteTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingDeleteTime

[<Fact>]
let ``CatIndicesColumn.IndexingDeleteTotal round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingDeleteTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingDeleteTotal

[<Fact>]
let ``CatIndicesColumn.PriIndexingDeleteTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingDeleteTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingDeleteTotal

[<Fact>]
let ``CatIndicesColumn.IndexingIndexCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingIndexCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingIndexCurrent

[<Fact>]
let ``CatIndicesColumn.PriIndexingIndexCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingIndexCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingIndexCurrent

[<Fact>]
let ``CatIndicesColumn.IndexingIndexTime round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingIndexTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingIndexTime

[<Fact>]
let ``CatIndicesColumn.PriIndexingIndexTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingIndexTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingIndexTime

[<Fact>]
let ``CatIndicesColumn.IndexingIndexTotal round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingIndexTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingIndexTotal

[<Fact>]
let ``CatIndicesColumn.PriIndexingIndexTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingIndexTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingIndexTotal

[<Fact>]
let ``CatIndicesColumn.IndexingIndexFailed round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingIndexFailed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingIndexFailed

[<Fact>]
let ``CatIndicesColumn.PriIndexingIndexFailed round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingIndexFailed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingIndexFailed

[<Fact>]
let ``CatIndicesColumn.IndexingIndexFailedDueToVersionConflict round-trips`` () =
    let value = Types.CatIndicesColumn.IndexingIndexFailedDueToVersionConflict
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.IndexingIndexFailedDueToVersionConflict

[<Fact>]
let ``CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict round-trips`` () =
    let value = Types.CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict

[<Fact>]
let ``CatIndicesColumn.MergesCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.MergesCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesCurrent

[<Fact>]
let ``CatIndicesColumn.PriMergesCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesCurrent

[<Fact>]
let ``CatIndicesColumn.MergesCurrentDocs round-trips`` () =
    let value = Types.CatIndicesColumn.MergesCurrentDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesCurrentDocs

[<Fact>]
let ``CatIndicesColumn.PriMergesCurrentDocs round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesCurrentDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesCurrentDocs

[<Fact>]
let ``CatIndicesColumn.MergesCurrentSize round-trips`` () =
    let value = Types.CatIndicesColumn.MergesCurrentSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesCurrentSize

[<Fact>]
let ``CatIndicesColumn.PriMergesCurrentSize round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesCurrentSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesCurrentSize

[<Fact>]
let ``CatIndicesColumn.MergesTotal round-trips`` () =
    let value = Types.CatIndicesColumn.MergesTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesTotal

[<Fact>]
let ``CatIndicesColumn.PriMergesTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesTotal

[<Fact>]
let ``CatIndicesColumn.MergesTotalDocs round-trips`` () =
    let value = Types.CatIndicesColumn.MergesTotalDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesTotalDocs

[<Fact>]
let ``CatIndicesColumn.PriMergesTotalDocs round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesTotalDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesTotalDocs

[<Fact>]
let ``CatIndicesColumn.MergesTotalSize round-trips`` () =
    let value = Types.CatIndicesColumn.MergesTotalSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesTotalSize

[<Fact>]
let ``CatIndicesColumn.PriMergesTotalSize round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesTotalSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesTotalSize

[<Fact>]
let ``CatIndicesColumn.MergesTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.MergesTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MergesTotalTime

[<Fact>]
let ``CatIndicesColumn.PriMergesTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriMergesTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMergesTotalTime

[<Fact>]
let ``CatIndicesColumn.RefreshTotal round-trips`` () =
    let value = Types.CatIndicesColumn.RefreshTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RefreshTotal

[<Fact>]
let ``CatIndicesColumn.PriRefreshTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriRefreshTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRefreshTotal

[<Fact>]
let ``CatIndicesColumn.RefreshTime round-trips`` () =
    let value = Types.CatIndicesColumn.RefreshTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RefreshTime

[<Fact>]
let ``CatIndicesColumn.PriRefreshTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriRefreshTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRefreshTime

[<Fact>]
let ``CatIndicesColumn.RefreshExternalTotal round-trips`` () =
    let value = Types.CatIndicesColumn.RefreshExternalTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RefreshExternalTotal

[<Fact>]
let ``CatIndicesColumn.PriRefreshExternalTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriRefreshExternalTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRefreshExternalTotal

[<Fact>]
let ``CatIndicesColumn.RefreshExternalTime round-trips`` () =
    let value = Types.CatIndicesColumn.RefreshExternalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RefreshExternalTime

[<Fact>]
let ``CatIndicesColumn.PriRefreshExternalTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriRefreshExternalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRefreshExternalTime

[<Fact>]
let ``CatIndicesColumn.RefreshListeners round-trips`` () =
    let value = Types.CatIndicesColumn.RefreshListeners
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.RefreshListeners

[<Fact>]
let ``CatIndicesColumn.PriRefreshListeners round-trips`` () =
    let value = Types.CatIndicesColumn.PriRefreshListeners
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriRefreshListeners

[<Fact>]
let ``CatIndicesColumn.SearchFetchCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.SearchFetchCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchFetchCurrent

[<Fact>]
let ``CatIndicesColumn.PriSearchFetchCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchFetchCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchFetchCurrent

[<Fact>]
let ``CatIndicesColumn.SearchFetchTime round-trips`` () =
    let value = Types.CatIndicesColumn.SearchFetchTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchFetchTime

[<Fact>]
let ``CatIndicesColumn.PriSearchFetchTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchFetchTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchFetchTime

[<Fact>]
let ``CatIndicesColumn.SearchFetchTotal round-trips`` () =
    let value = Types.CatIndicesColumn.SearchFetchTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchFetchTotal

[<Fact>]
let ``CatIndicesColumn.PriSearchFetchTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchFetchTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchFetchTotal

[<Fact>]
let ``CatIndicesColumn.SearchOpenContexts round-trips`` () =
    let value = Types.CatIndicesColumn.SearchOpenContexts
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchOpenContexts

[<Fact>]
let ``CatIndicesColumn.PriSearchOpenContexts round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchOpenContexts
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchOpenContexts

[<Fact>]
let ``CatIndicesColumn.SearchQueryCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.SearchQueryCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchQueryCurrent

[<Fact>]
let ``CatIndicesColumn.PriSearchQueryCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchQueryCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchQueryCurrent

[<Fact>]
let ``CatIndicesColumn.SearchQueryTime round-trips`` () =
    let value = Types.CatIndicesColumn.SearchQueryTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchQueryTime

[<Fact>]
let ``CatIndicesColumn.PriSearchQueryTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchQueryTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchQueryTime

[<Fact>]
let ``CatIndicesColumn.SearchQueryTotal round-trips`` () =
    let value = Types.CatIndicesColumn.SearchQueryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchQueryTotal

[<Fact>]
let ``CatIndicesColumn.PriSearchQueryTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchQueryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchQueryTotal

[<Fact>]
let ``CatIndicesColumn.SearchScrollCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.SearchScrollCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchScrollCurrent

[<Fact>]
let ``CatIndicesColumn.PriSearchScrollCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchScrollCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchScrollCurrent

[<Fact>]
let ``CatIndicesColumn.SearchScrollTime round-trips`` () =
    let value = Types.CatIndicesColumn.SearchScrollTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchScrollTime

[<Fact>]
let ``CatIndicesColumn.PriSearchScrollTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchScrollTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchScrollTime

[<Fact>]
let ``CatIndicesColumn.SearchScrollTotal round-trips`` () =
    let value = Types.CatIndicesColumn.SearchScrollTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SearchScrollTotal

[<Fact>]
let ``CatIndicesColumn.PriSearchScrollTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriSearchScrollTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSearchScrollTotal

[<Fact>]
let ``CatIndicesColumn.SegmentsCount round-trips`` () =
    let value = Types.CatIndicesColumn.SegmentsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SegmentsCount

[<Fact>]
let ``CatIndicesColumn.PriSegmentsCount round-trips`` () =
    let value = Types.CatIndicesColumn.PriSegmentsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSegmentsCount

[<Fact>]
let ``CatIndicesColumn.SegmentsMemory round-trips`` () =
    let value = Types.CatIndicesColumn.SegmentsMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SegmentsMemory

[<Fact>]
let ``CatIndicesColumn.PriSegmentsMemory round-trips`` () =
    let value = Types.CatIndicesColumn.PriSegmentsMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSegmentsMemory

[<Fact>]
let ``CatIndicesColumn.SegmentsIndexWriterMemory round-trips`` () =
    let value = Types.CatIndicesColumn.SegmentsIndexWriterMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SegmentsIndexWriterMemory

[<Fact>]
let ``CatIndicesColumn.PriSegmentsIndexWriterMemory round-trips`` () =
    let value = Types.CatIndicesColumn.PriSegmentsIndexWriterMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSegmentsIndexWriterMemory

[<Fact>]
let ``CatIndicesColumn.SegmentsVersionMapMemory round-trips`` () =
    let value = Types.CatIndicesColumn.SegmentsVersionMapMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SegmentsVersionMapMemory

[<Fact>]
let ``CatIndicesColumn.PriSegmentsVersionMapMemory round-trips`` () =
    let value = Types.CatIndicesColumn.PriSegmentsVersionMapMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSegmentsVersionMapMemory

[<Fact>]
let ``CatIndicesColumn.SegmentsFixedBitsetMemory round-trips`` () =
    let value = Types.CatIndicesColumn.SegmentsFixedBitsetMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SegmentsFixedBitsetMemory

[<Fact>]
let ``CatIndicesColumn.PriSegmentsFixedBitsetMemory round-trips`` () =
    let value = Types.CatIndicesColumn.PriSegmentsFixedBitsetMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSegmentsFixedBitsetMemory

[<Fact>]
let ``CatIndicesColumn.WarmerCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.WarmerCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.WarmerCurrent

[<Fact>]
let ``CatIndicesColumn.PriWarmerCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriWarmerCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriWarmerCurrent

[<Fact>]
let ``CatIndicesColumn.WarmerTotal round-trips`` () =
    let value = Types.CatIndicesColumn.WarmerTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.WarmerTotal

[<Fact>]
let ``CatIndicesColumn.PriWarmerTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriWarmerTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriWarmerTotal

[<Fact>]
let ``CatIndicesColumn.WarmerTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.WarmerTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.WarmerTotalTime

[<Fact>]
let ``CatIndicesColumn.PriWarmerTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriWarmerTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriWarmerTotalTime

[<Fact>]
let ``CatIndicesColumn.SuggestCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.SuggestCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SuggestCurrent

[<Fact>]
let ``CatIndicesColumn.PriSuggestCurrent round-trips`` () =
    let value = Types.CatIndicesColumn.PriSuggestCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSuggestCurrent

[<Fact>]
let ``CatIndicesColumn.SuggestTime round-trips`` () =
    let value = Types.CatIndicesColumn.SuggestTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SuggestTime

[<Fact>]
let ``CatIndicesColumn.PriSuggestTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriSuggestTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSuggestTime

[<Fact>]
let ``CatIndicesColumn.SuggestTotal round-trips`` () =
    let value = Types.CatIndicesColumn.SuggestTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SuggestTotal

[<Fact>]
let ``CatIndicesColumn.PriSuggestTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriSuggestTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSuggestTotal

[<Fact>]
let ``CatIndicesColumn.MemoryTotal round-trips`` () =
    let value = Types.CatIndicesColumn.MemoryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.MemoryTotal

[<Fact>]
let ``CatIndicesColumn.PriMemoryTotal round-trips`` () =
    let value = Types.CatIndicesColumn.PriMemoryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriMemoryTotal

[<Fact>]
let ``CatIndicesColumn.BulkTotalOperations round-trips`` () =
    let value = Types.CatIndicesColumn.BulkTotalOperations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.BulkTotalOperations

[<Fact>]
let ``CatIndicesColumn.PriBulkTotalOperations round-trips`` () =
    let value = Types.CatIndicesColumn.PriBulkTotalOperations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriBulkTotalOperations

[<Fact>]
let ``CatIndicesColumn.BulkTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.BulkTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.BulkTotalTime

[<Fact>]
let ``CatIndicesColumn.PriBulkTotalTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriBulkTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriBulkTotalTime

[<Fact>]
let ``CatIndicesColumn.BulkTotalSizeInBytes round-trips`` () =
    let value = Types.CatIndicesColumn.BulkTotalSizeInBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.BulkTotalSizeInBytes

[<Fact>]
let ``CatIndicesColumn.PriBulkTotalSizeInBytes round-trips`` () =
    let value = Types.CatIndicesColumn.PriBulkTotalSizeInBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriBulkTotalSizeInBytes

[<Fact>]
let ``CatIndicesColumn.BulkAvgTime round-trips`` () =
    let value = Types.CatIndicesColumn.BulkAvgTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.BulkAvgTime

[<Fact>]
let ``CatIndicesColumn.PriBulkAvgTime round-trips`` () =
    let value = Types.CatIndicesColumn.PriBulkAvgTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriBulkAvgTime

[<Fact>]
let ``CatIndicesColumn.BulkAvgSizeInBytes round-trips`` () =
    let value = Types.CatIndicesColumn.BulkAvgSizeInBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.BulkAvgSizeInBytes

[<Fact>]
let ``CatIndicesColumn.PriBulkAvgSizeInBytes round-trips`` () =
    let value = Types.CatIndicesColumn.PriBulkAvgSizeInBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriBulkAvgSizeInBytes

[<Fact>]
let ``CatIndicesColumn.DenseVectorValueCount round-trips`` () =
    let value = Types.CatIndicesColumn.DenseVectorValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.DenseVectorValueCount

[<Fact>]
let ``CatIndicesColumn.PriDenseVectorValueCount round-trips`` () =
    let value = Types.CatIndicesColumn.PriDenseVectorValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriDenseVectorValueCount

[<Fact>]
let ``CatIndicesColumn.SparseVectorValueCount round-trips`` () =
    let value = Types.CatIndicesColumn.SparseVectorValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.SparseVectorValueCount

[<Fact>]
let ``CatIndicesColumn.PriSparseVectorValueCount round-trips`` () =
    let value = Types.CatIndicesColumn.PriSparseVectorValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatIndicesColumn> json
    roundTripped |> should equal Types.CatIndicesColumn.PriSparseVectorValueCount

[<Fact>]
let ``CatMasterColumn.Id round-trips`` () =
    let value = Types.CatMasterColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatMasterColumn> json
    roundTripped |> should equal Types.CatMasterColumn.Id

[<Fact>]
let ``CatMasterColumn.Host round-trips`` () =
    let value = Types.CatMasterColumn.Host
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatMasterColumn> json
    roundTripped |> should equal Types.CatMasterColumn.Host

[<Fact>]
let ``CatMasterColumn.Ip round-trips`` () =
    let value = Types.CatMasterColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatMasterColumn> json
    roundTripped |> should equal Types.CatMasterColumn.Ip

[<Fact>]
let ``CatMasterColumn.Node round-trips`` () =
    let value = Types.CatMasterColumn.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatMasterColumn> json
    roundTripped |> should equal Types.CatMasterColumn.Node

[<Fact>]
let ``CatNodeColumn.Build round-trips`` () =
    let value = Types.CatNodeColumn.Build
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Build

[<Fact>]
let ``CatNodeColumn.CompletionSize round-trips`` () =
    let value = Types.CatNodeColumn.CompletionSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.CompletionSize

[<Fact>]
let ``CatNodeColumn.Cpu round-trips`` () =
    let value = Types.CatNodeColumn.Cpu
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Cpu

[<Fact>]
let ``CatNodeColumn.DiskAvail round-trips`` () =
    let value = Types.CatNodeColumn.DiskAvail
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.DiskAvail

[<Fact>]
let ``CatNodeColumn.DiskTotal round-trips`` () =
    let value = Types.CatNodeColumn.DiskTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.DiskTotal

[<Fact>]
let ``CatNodeColumn.DiskUsed round-trips`` () =
    let value = Types.CatNodeColumn.DiskUsed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.DiskUsed

[<Fact>]
let ``CatNodeColumn.DiskUsedPercent round-trips`` () =
    let value = Types.CatNodeColumn.DiskUsedPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.DiskUsedPercent

[<Fact>]
let ``CatNodeColumn.FielddataEvictions round-trips`` () =
    let value = Types.CatNodeColumn.FielddataEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FielddataEvictions

[<Fact>]
let ``CatNodeColumn.FielddataMemorySize round-trips`` () =
    let value = Types.CatNodeColumn.FielddataMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FielddataMemorySize

[<Fact>]
let ``CatNodeColumn.FileDescCurrent round-trips`` () =
    let value = Types.CatNodeColumn.FileDescCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FileDescCurrent

[<Fact>]
let ``CatNodeColumn.FileDescMax round-trips`` () =
    let value = Types.CatNodeColumn.FileDescMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FileDescMax

[<Fact>]
let ``CatNodeColumn.FileDescPercent round-trips`` () =
    let value = Types.CatNodeColumn.FileDescPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FileDescPercent

[<Fact>]
let ``CatNodeColumn.FlushTotal round-trips`` () =
    let value = Types.CatNodeColumn.FlushTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FlushTotal

[<Fact>]
let ``CatNodeColumn.FlushTotalTime round-trips`` () =
    let value = Types.CatNodeColumn.FlushTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.FlushTotalTime

[<Fact>]
let ``CatNodeColumn.GetCurrent round-trips`` () =
    let value = Types.CatNodeColumn.GetCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetCurrent

[<Fact>]
let ``CatNodeColumn.GetExistsTime round-trips`` () =
    let value = Types.CatNodeColumn.GetExistsTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetExistsTime

[<Fact>]
let ``CatNodeColumn.GetExistsTotal round-trips`` () =
    let value = Types.CatNodeColumn.GetExistsTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetExistsTotal

[<Fact>]
let ``CatNodeColumn.GetMissingTime round-trips`` () =
    let value = Types.CatNodeColumn.GetMissingTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetMissingTime

[<Fact>]
let ``CatNodeColumn.GetMissingTotal round-trips`` () =
    let value = Types.CatNodeColumn.GetMissingTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetMissingTotal

[<Fact>]
let ``CatNodeColumn.GetTime round-trips`` () =
    let value = Types.CatNodeColumn.GetTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetTime

[<Fact>]
let ``CatNodeColumn.GetTotal round-trips`` () =
    let value = Types.CatNodeColumn.GetTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.GetTotal

[<Fact>]
let ``CatNodeColumn.HeapCurrent round-trips`` () =
    let value = Types.CatNodeColumn.HeapCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.HeapCurrent

[<Fact>]
let ``CatNodeColumn.HeapMax round-trips`` () =
    let value = Types.CatNodeColumn.HeapMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.HeapMax

[<Fact>]
let ``CatNodeColumn.HeapPercent round-trips`` () =
    let value = Types.CatNodeColumn.HeapPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.HeapPercent

[<Fact>]
let ``CatNodeColumn.HttpAddress round-trips`` () =
    let value = Types.CatNodeColumn.HttpAddress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.HttpAddress

[<Fact>]
let ``CatNodeColumn.Id round-trips`` () =
    let value = Types.CatNodeColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Id

[<Fact>]
let ``CatNodeColumn.IndexingDeleteCurrent round-trips`` () =
    let value = Types.CatNodeColumn.IndexingDeleteCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingDeleteCurrent

[<Fact>]
let ``CatNodeColumn.IndexingDeleteTime round-trips`` () =
    let value = Types.CatNodeColumn.IndexingDeleteTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingDeleteTime

[<Fact>]
let ``CatNodeColumn.IndexingDeleteTotal round-trips`` () =
    let value = Types.CatNodeColumn.IndexingDeleteTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingDeleteTotal

[<Fact>]
let ``CatNodeColumn.IndexingIndexCurrent round-trips`` () =
    let value = Types.CatNodeColumn.IndexingIndexCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingIndexCurrent

[<Fact>]
let ``CatNodeColumn.IndexingIndexFailed round-trips`` () =
    let value = Types.CatNodeColumn.IndexingIndexFailed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingIndexFailed

[<Fact>]
let ``CatNodeColumn.IndexingIndexFailedDueToVersionConflict round-trips`` () =
    let value = Types.CatNodeColumn.IndexingIndexFailedDueToVersionConflict
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingIndexFailedDueToVersionConflict

[<Fact>]
let ``CatNodeColumn.IndexingIndexTime round-trips`` () =
    let value = Types.CatNodeColumn.IndexingIndexTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingIndexTime

[<Fact>]
let ``CatNodeColumn.IndexingIndexTotal round-trips`` () =
    let value = Types.CatNodeColumn.IndexingIndexTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.IndexingIndexTotal

[<Fact>]
let ``CatNodeColumn.Ip round-trips`` () =
    let value = Types.CatNodeColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Ip

[<Fact>]
let ``CatNodeColumn.Jdk round-trips`` () =
    let value = Types.CatNodeColumn.Jdk
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Jdk

[<Fact>]
let ``CatNodeColumn.Load1m round-trips`` () =
    let value = Types.CatNodeColumn.Load1m
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Load1m

[<Fact>]
let ``CatNodeColumn.Load5m round-trips`` () =
    let value = Types.CatNodeColumn.Load5m
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Load5m

[<Fact>]
let ``CatNodeColumn.Load15m round-trips`` () =
    let value = Types.CatNodeColumn.Load15m
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Load15m

[<Fact>]
let ``CatNodeColumn.AvailableProcessors round-trips`` () =
    let value = Types.CatNodeColumn.AvailableProcessors
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.AvailableProcessors

[<Fact>]
let ``CatNodeColumn.MappingsTotalCount round-trips`` () =
    let value = Types.CatNodeColumn.MappingsTotalCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MappingsTotalCount

[<Fact>]
let ``CatNodeColumn.MappingsTotalEstimatedOverheadInBytes round-trips`` () =
    let value = Types.CatNodeColumn.MappingsTotalEstimatedOverheadInBytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MappingsTotalEstimatedOverheadInBytes

[<Fact>]
let ``CatNodeColumn.Master round-trips`` () =
    let value = Types.CatNodeColumn.Master
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Master

[<Fact>]
let ``CatNodeColumn.MergesCurrent round-trips`` () =
    let value = Types.CatNodeColumn.MergesCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesCurrent

[<Fact>]
let ``CatNodeColumn.MergesCurrentDocs round-trips`` () =
    let value = Types.CatNodeColumn.MergesCurrentDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesCurrentDocs

[<Fact>]
let ``CatNodeColumn.MergesCurrentSize round-trips`` () =
    let value = Types.CatNodeColumn.MergesCurrentSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesCurrentSize

[<Fact>]
let ``CatNodeColumn.MergesTotal round-trips`` () =
    let value = Types.CatNodeColumn.MergesTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesTotal

[<Fact>]
let ``CatNodeColumn.MergesTotalDocs round-trips`` () =
    let value = Types.CatNodeColumn.MergesTotalDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesTotalDocs

[<Fact>]
let ``CatNodeColumn.MergesTotalSize round-trips`` () =
    let value = Types.CatNodeColumn.MergesTotalSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesTotalSize

[<Fact>]
let ``CatNodeColumn.MergesTotalTime round-trips`` () =
    let value = Types.CatNodeColumn.MergesTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.MergesTotalTime

[<Fact>]
let ``CatNodeColumn.Name round-trips`` () =
    let value = Types.CatNodeColumn.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Name

[<Fact>]
let ``CatNodeColumn.NodeRole round-trips`` () =
    let value = Types.CatNodeColumn.NodeRole
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.NodeRole

[<Fact>]
let ``CatNodeColumn.Pid round-trips`` () =
    let value = Types.CatNodeColumn.Pid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Pid

[<Fact>]
let ``CatNodeColumn.Port round-trips`` () =
    let value = Types.CatNodeColumn.Port
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Port

[<Fact>]
let ``CatNodeColumn.QueryCacheMemorySize round-trips`` () =
    let value = Types.CatNodeColumn.QueryCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.QueryCacheMemorySize

[<Fact>]
let ``CatNodeColumn.QueryCacheEvictions round-trips`` () =
    let value = Types.CatNodeColumn.QueryCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.QueryCacheEvictions

[<Fact>]
let ``CatNodeColumn.QueryCacheHitCount round-trips`` () =
    let value = Types.CatNodeColumn.QueryCacheHitCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.QueryCacheHitCount

[<Fact>]
let ``CatNodeColumn.QueryCacheMissCount round-trips`` () =
    let value = Types.CatNodeColumn.QueryCacheMissCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.QueryCacheMissCount

[<Fact>]
let ``CatNodeColumn.RamCurrent round-trips`` () =
    let value = Types.CatNodeColumn.RamCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RamCurrent

[<Fact>]
let ``CatNodeColumn.RamMax round-trips`` () =
    let value = Types.CatNodeColumn.RamMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RamMax

[<Fact>]
let ``CatNodeColumn.RamPercent round-trips`` () =
    let value = Types.CatNodeColumn.RamPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RamPercent

[<Fact>]
let ``CatNodeColumn.RefreshTotal round-trips`` () =
    let value = Types.CatNodeColumn.RefreshTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RefreshTotal

[<Fact>]
let ``CatNodeColumn.RefreshTime round-trips`` () =
    let value = Types.CatNodeColumn.RefreshTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RefreshTime

[<Fact>]
let ``CatNodeColumn.RequestCacheMemorySize round-trips`` () =
    let value = Types.CatNodeColumn.RequestCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RequestCacheMemorySize

[<Fact>]
let ``CatNodeColumn.RequestCacheEvictions round-trips`` () =
    let value = Types.CatNodeColumn.RequestCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RequestCacheEvictions

[<Fact>]
let ``CatNodeColumn.RequestCacheHitCount round-trips`` () =
    let value = Types.CatNodeColumn.RequestCacheHitCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RequestCacheHitCount

[<Fact>]
let ``CatNodeColumn.RequestCacheMissCount round-trips`` () =
    let value = Types.CatNodeColumn.RequestCacheMissCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.RequestCacheMissCount

[<Fact>]
let ``CatNodeColumn.ScriptCompilations round-trips`` () =
    let value = Types.CatNodeColumn.ScriptCompilations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.ScriptCompilations

[<Fact>]
let ``CatNodeColumn.ScriptCacheEvictions round-trips`` () =
    let value = Types.CatNodeColumn.ScriptCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.ScriptCacheEvictions

[<Fact>]
let ``CatNodeColumn.SearchFetchCurrent round-trips`` () =
    let value = Types.CatNodeColumn.SearchFetchCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchFetchCurrent

[<Fact>]
let ``CatNodeColumn.SearchFetchTime round-trips`` () =
    let value = Types.CatNodeColumn.SearchFetchTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchFetchTime

[<Fact>]
let ``CatNodeColumn.SearchFetchTotal round-trips`` () =
    let value = Types.CatNodeColumn.SearchFetchTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchFetchTotal

[<Fact>]
let ``CatNodeColumn.SearchOpenContexts round-trips`` () =
    let value = Types.CatNodeColumn.SearchOpenContexts
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchOpenContexts

[<Fact>]
let ``CatNodeColumn.SearchQueryCurrent round-trips`` () =
    let value = Types.CatNodeColumn.SearchQueryCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchQueryCurrent

[<Fact>]
let ``CatNodeColumn.SearchQueryTime round-trips`` () =
    let value = Types.CatNodeColumn.SearchQueryTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchQueryTime

[<Fact>]
let ``CatNodeColumn.SearchQueryTotal round-trips`` () =
    let value = Types.CatNodeColumn.SearchQueryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchQueryTotal

[<Fact>]
let ``CatNodeColumn.SearchScrollCurrent round-trips`` () =
    let value = Types.CatNodeColumn.SearchScrollCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchScrollCurrent

[<Fact>]
let ``CatNodeColumn.SearchScrollTime round-trips`` () =
    let value = Types.CatNodeColumn.SearchScrollTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchScrollTime

[<Fact>]
let ``CatNodeColumn.SearchScrollTotal round-trips`` () =
    let value = Types.CatNodeColumn.SearchScrollTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SearchScrollTotal

[<Fact>]
let ``CatNodeColumn.SegmentsCount round-trips`` () =
    let value = Types.CatNodeColumn.SegmentsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SegmentsCount

[<Fact>]
let ``CatNodeColumn.SegmentsFixedBitsetMemory round-trips`` () =
    let value = Types.CatNodeColumn.SegmentsFixedBitsetMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SegmentsFixedBitsetMemory

[<Fact>]
let ``CatNodeColumn.SegmentsIndexWriterMemory round-trips`` () =
    let value = Types.CatNodeColumn.SegmentsIndexWriterMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SegmentsIndexWriterMemory

[<Fact>]
let ``CatNodeColumn.SegmentsMemory round-trips`` () =
    let value = Types.CatNodeColumn.SegmentsMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SegmentsMemory

[<Fact>]
let ``CatNodeColumn.SegmentsVersionMapMemory round-trips`` () =
    let value = Types.CatNodeColumn.SegmentsVersionMapMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SegmentsVersionMapMemory

[<Fact>]
let ``CatNodeColumn.ShardStatsTotalCount round-trips`` () =
    let value = Types.CatNodeColumn.ShardStatsTotalCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.ShardStatsTotalCount

[<Fact>]
let ``CatNodeColumn.SuggestCurrent round-trips`` () =
    let value = Types.CatNodeColumn.SuggestCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SuggestCurrent

[<Fact>]
let ``CatNodeColumn.SuggestTime round-trips`` () =
    let value = Types.CatNodeColumn.SuggestTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SuggestTime

[<Fact>]
let ``CatNodeColumn.SuggestTotal round-trips`` () =
    let value = Types.CatNodeColumn.SuggestTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.SuggestTotal

[<Fact>]
let ``CatNodeColumn.Uptime round-trips`` () =
    let value = Types.CatNodeColumn.Uptime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Uptime

[<Fact>]
let ``CatNodeColumn.Version round-trips`` () =
    let value = Types.CatNodeColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeColumn> json
    roundTripped |> should equal Types.CatNodeColumn.Version

[<Fact>]
let ``CatNodeattrsColumn.Node round-trips`` () =
    let value = Types.CatNodeattrsColumn.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Node

[<Fact>]
let ``CatNodeattrsColumn.Id round-trips`` () =
    let value = Types.CatNodeattrsColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Id

[<Fact>]
let ``CatNodeattrsColumn.Pid round-trips`` () =
    let value = Types.CatNodeattrsColumn.Pid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Pid

[<Fact>]
let ``CatNodeattrsColumn.Host round-trips`` () =
    let value = Types.CatNodeattrsColumn.Host
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Host

[<Fact>]
let ``CatNodeattrsColumn.Ip round-trips`` () =
    let value = Types.CatNodeattrsColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Ip

[<Fact>]
let ``CatNodeattrsColumn.Port round-trips`` () =
    let value = Types.CatNodeattrsColumn.Port
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Port

[<Fact>]
let ``CatNodeattrsColumn.Attr round-trips`` () =
    let value = Types.CatNodeattrsColumn.Attr
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Attr

[<Fact>]
let ``CatNodeattrsColumn.Value round-trips`` () =
    let value = Types.CatNodeattrsColumn.Value
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatNodeattrsColumn> json
    roundTripped |> should equal Types.CatNodeattrsColumn.Value

[<Fact>]
let ``CatPendingTasksColumn.InsertOrder round-trips`` () =
    let value = Types.CatPendingTasksColumn.InsertOrder
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPendingTasksColumn> json
    roundTripped |> should equal Types.CatPendingTasksColumn.InsertOrder

[<Fact>]
let ``CatPendingTasksColumn.TimeInQueue round-trips`` () =
    let value = Types.CatPendingTasksColumn.TimeInQueue
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPendingTasksColumn> json
    roundTripped |> should equal Types.CatPendingTasksColumn.TimeInQueue

[<Fact>]
let ``CatPendingTasksColumn.Priority round-trips`` () =
    let value = Types.CatPendingTasksColumn.Priority
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPendingTasksColumn> json
    roundTripped |> should equal Types.CatPendingTasksColumn.Priority

[<Fact>]
let ``CatPendingTasksColumn.Source round-trips`` () =
    let value = Types.CatPendingTasksColumn.Source
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPendingTasksColumn> json
    roundTripped |> should equal Types.CatPendingTasksColumn.Source

[<Fact>]
let ``CatPluginsColumn.Id round-trips`` () =
    let value = Types.CatPluginsColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPluginsColumn> json
    roundTripped |> should equal Types.CatPluginsColumn.Id

[<Fact>]
let ``CatPluginsColumn.Name round-trips`` () =
    let value = Types.CatPluginsColumn.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPluginsColumn> json
    roundTripped |> should equal Types.CatPluginsColumn.Name

[<Fact>]
let ``CatPluginsColumn.Component round-trips`` () =
    let value = Types.CatPluginsColumn.Component
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPluginsColumn> json
    roundTripped |> should equal Types.CatPluginsColumn.Component

[<Fact>]
let ``CatPluginsColumn.Version round-trips`` () =
    let value = Types.CatPluginsColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPluginsColumn> json
    roundTripped |> should equal Types.CatPluginsColumn.Version

[<Fact>]
let ``CatPluginsColumn.Description round-trips`` () =
    let value = Types.CatPluginsColumn.Description
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatPluginsColumn> json
    roundTripped |> should equal Types.CatPluginsColumn.Description

[<Fact>]
let ``CatRecoveryColumn.Index round-trips`` () =
    let value = Types.CatRecoveryColumn.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Index

[<Fact>]
let ``CatRecoveryColumn.Shard round-trips`` () =
    let value = Types.CatRecoveryColumn.Shard
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Shard

[<Fact>]
let ``CatRecoveryColumn.StartTime round-trips`` () =
    let value = Types.CatRecoveryColumn.StartTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.StartTime

[<Fact>]
let ``CatRecoveryColumn.StartTimeMillis round-trips`` () =
    let value = Types.CatRecoveryColumn.StartTimeMillis
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.StartTimeMillis

[<Fact>]
let ``CatRecoveryColumn.StopTime round-trips`` () =
    let value = Types.CatRecoveryColumn.StopTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.StopTime

[<Fact>]
let ``CatRecoveryColumn.StopTimeMillis round-trips`` () =
    let value = Types.CatRecoveryColumn.StopTimeMillis
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.StopTimeMillis

[<Fact>]
let ``CatRecoveryColumn.Time round-trips`` () =
    let value = Types.CatRecoveryColumn.Time
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Time

[<Fact>]
let ``CatRecoveryColumn.Type round-trips`` () =
    let value = Types.CatRecoveryColumn.Type
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Type

[<Fact>]
let ``CatRecoveryColumn.Stage round-trips`` () =
    let value = Types.CatRecoveryColumn.Stage
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Stage

[<Fact>]
let ``CatRecoveryColumn.SourceHost round-trips`` () =
    let value = Types.CatRecoveryColumn.SourceHost
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.SourceHost

[<Fact>]
let ``CatRecoveryColumn.SourceNode round-trips`` () =
    let value = Types.CatRecoveryColumn.SourceNode
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.SourceNode

[<Fact>]
let ``CatRecoveryColumn.TargetHost round-trips`` () =
    let value = Types.CatRecoveryColumn.TargetHost
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.TargetHost

[<Fact>]
let ``CatRecoveryColumn.TargetNode round-trips`` () =
    let value = Types.CatRecoveryColumn.TargetNode
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.TargetNode

[<Fact>]
let ``CatRecoveryColumn.Repository round-trips`` () =
    let value = Types.CatRecoveryColumn.Repository
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Repository

[<Fact>]
let ``CatRecoveryColumn.Snapshot round-trips`` () =
    let value = Types.CatRecoveryColumn.Snapshot
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Snapshot

[<Fact>]
let ``CatRecoveryColumn.Files round-trips`` () =
    let value = Types.CatRecoveryColumn.Files
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Files

[<Fact>]
let ``CatRecoveryColumn.FilesRecovered round-trips`` () =
    let value = Types.CatRecoveryColumn.FilesRecovered
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.FilesRecovered

[<Fact>]
let ``CatRecoveryColumn.FilesPercent round-trips`` () =
    let value = Types.CatRecoveryColumn.FilesPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.FilesPercent

[<Fact>]
let ``CatRecoveryColumn.FilesTotal round-trips`` () =
    let value = Types.CatRecoveryColumn.FilesTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.FilesTotal

[<Fact>]
let ``CatRecoveryColumn.Bytes round-trips`` () =
    let value = Types.CatRecoveryColumn.Bytes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.Bytes

[<Fact>]
let ``CatRecoveryColumn.BytesRecovered round-trips`` () =
    let value = Types.CatRecoveryColumn.BytesRecovered
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.BytesRecovered

[<Fact>]
let ``CatRecoveryColumn.BytesPercent round-trips`` () =
    let value = Types.CatRecoveryColumn.BytesPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.BytesPercent

[<Fact>]
let ``CatRecoveryColumn.BytesTotal round-trips`` () =
    let value = Types.CatRecoveryColumn.BytesTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.BytesTotal

[<Fact>]
let ``CatRecoveryColumn.TranslogOps round-trips`` () =
    let value = Types.CatRecoveryColumn.TranslogOps
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.TranslogOps

[<Fact>]
let ``CatRecoveryColumn.TranslogOpsRecovered round-trips`` () =
    let value = Types.CatRecoveryColumn.TranslogOpsRecovered
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.TranslogOpsRecovered

[<Fact>]
let ``CatRecoveryColumn.TranslogOpsPercent round-trips`` () =
    let value = Types.CatRecoveryColumn.TranslogOpsPercent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatRecoveryColumn> json
    roundTripped |> should equal Types.CatRecoveryColumn.TranslogOpsPercent

[<Fact>]
let ``CatSegmentsColumn.Index round-trips`` () =
    let value = Types.CatSegmentsColumn.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Index

[<Fact>]
let ``CatSegmentsColumn.Shard round-trips`` () =
    let value = Types.CatSegmentsColumn.Shard
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Shard

[<Fact>]
let ``CatSegmentsColumn.Prirep round-trips`` () =
    let value = Types.CatSegmentsColumn.Prirep
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Prirep

[<Fact>]
let ``CatSegmentsColumn.Ip round-trips`` () =
    let value = Types.CatSegmentsColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Ip

[<Fact>]
let ``CatSegmentsColumn.Segment round-trips`` () =
    let value = Types.CatSegmentsColumn.Segment
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Segment

[<Fact>]
let ``CatSegmentsColumn.Generation round-trips`` () =
    let value = Types.CatSegmentsColumn.Generation
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Generation

[<Fact>]
let ``CatSegmentsColumn.DocsCount round-trips`` () =
    let value = Types.CatSegmentsColumn.DocsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.DocsCount

[<Fact>]
let ``CatSegmentsColumn.DocsDeleted round-trips`` () =
    let value = Types.CatSegmentsColumn.DocsDeleted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.DocsDeleted

[<Fact>]
let ``CatSegmentsColumn.Size round-trips`` () =
    let value = Types.CatSegmentsColumn.Size
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Size

[<Fact>]
let ``CatSegmentsColumn.SizeMemory round-trips`` () =
    let value = Types.CatSegmentsColumn.SizeMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.SizeMemory

[<Fact>]
let ``CatSegmentsColumn.Committed round-trips`` () =
    let value = Types.CatSegmentsColumn.Committed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Committed

[<Fact>]
let ``CatSegmentsColumn.Searchable round-trips`` () =
    let value = Types.CatSegmentsColumn.Searchable
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Searchable

[<Fact>]
let ``CatSegmentsColumn.Version round-trips`` () =
    let value = Types.CatSegmentsColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Version

[<Fact>]
let ``CatSegmentsColumn.Compound round-trips`` () =
    let value = Types.CatSegmentsColumn.Compound
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Compound

[<Fact>]
let ``CatSegmentsColumn.Id round-trips`` () =
    let value = Types.CatSegmentsColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSegmentsColumn> json
    roundTripped |> should equal Types.CatSegmentsColumn.Id

[<Fact>]
let ``CatShardColumn.CompletionSize round-trips`` () =
    let value = Types.CatShardColumn.CompletionSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.CompletionSize

[<Fact>]
let ``CatShardColumn.DatasetSize round-trips`` () =
    let value = Types.CatShardColumn.DatasetSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.DatasetSize

[<Fact>]
let ``CatShardColumn.DenseVectorValueCount round-trips`` () =
    let value = Types.CatShardColumn.DenseVectorValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.DenseVectorValueCount

[<Fact>]
let ``CatShardColumn.Docs round-trips`` () =
    let value = Types.CatShardColumn.Docs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Docs

[<Fact>]
let ``CatShardColumn.FielddataEvictions round-trips`` () =
    let value = Types.CatShardColumn.FielddataEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.FielddataEvictions

[<Fact>]
let ``CatShardColumn.FielddataMemorySize round-trips`` () =
    let value = Types.CatShardColumn.FielddataMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.FielddataMemorySize

[<Fact>]
let ``CatShardColumn.FlushTotal round-trips`` () =
    let value = Types.CatShardColumn.FlushTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.FlushTotal

[<Fact>]
let ``CatShardColumn.FlushTotalTime round-trips`` () =
    let value = Types.CatShardColumn.FlushTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.FlushTotalTime

[<Fact>]
let ``CatShardColumn.GetCurrent round-trips`` () =
    let value = Types.CatShardColumn.GetCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetCurrent

[<Fact>]
let ``CatShardColumn.GetExistsTime round-trips`` () =
    let value = Types.CatShardColumn.GetExistsTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetExistsTime

[<Fact>]
let ``CatShardColumn.GetExistsTotal round-trips`` () =
    let value = Types.CatShardColumn.GetExistsTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetExistsTotal

[<Fact>]
let ``CatShardColumn.GetMissingTime round-trips`` () =
    let value = Types.CatShardColumn.GetMissingTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetMissingTime

[<Fact>]
let ``CatShardColumn.GetMissingTotal round-trips`` () =
    let value = Types.CatShardColumn.GetMissingTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetMissingTotal

[<Fact>]
let ``CatShardColumn.GetTime round-trips`` () =
    let value = Types.CatShardColumn.GetTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetTime

[<Fact>]
let ``CatShardColumn.GetTotal round-trips`` () =
    let value = Types.CatShardColumn.GetTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.GetTotal

[<Fact>]
let ``CatShardColumn.Id round-trips`` () =
    let value = Types.CatShardColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Id

[<Fact>]
let ``CatShardColumn.Index round-trips`` () =
    let value = Types.CatShardColumn.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Index

[<Fact>]
let ``CatShardColumn.IndexingDeleteCurrent round-trips`` () =
    let value = Types.CatShardColumn.IndexingDeleteCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingDeleteCurrent

[<Fact>]
let ``CatShardColumn.IndexingDeleteTime round-trips`` () =
    let value = Types.CatShardColumn.IndexingDeleteTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingDeleteTime

[<Fact>]
let ``CatShardColumn.IndexingDeleteTotal round-trips`` () =
    let value = Types.CatShardColumn.IndexingDeleteTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingDeleteTotal

[<Fact>]
let ``CatShardColumn.IndexingIndexCurrent round-trips`` () =
    let value = Types.CatShardColumn.IndexingIndexCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingIndexCurrent

[<Fact>]
let ``CatShardColumn.IndexingIndexFailedDueToVersionConflict round-trips`` () =
    let value = Types.CatShardColumn.IndexingIndexFailedDueToVersionConflict
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingIndexFailedDueToVersionConflict

[<Fact>]
let ``CatShardColumn.IndexingIndexFailed round-trips`` () =
    let value = Types.CatShardColumn.IndexingIndexFailed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingIndexFailed

[<Fact>]
let ``CatShardColumn.IndexingIndexTime round-trips`` () =
    let value = Types.CatShardColumn.IndexingIndexTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingIndexTime

[<Fact>]
let ``CatShardColumn.IndexingIndexTotal round-trips`` () =
    let value = Types.CatShardColumn.IndexingIndexTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.IndexingIndexTotal

[<Fact>]
let ``CatShardColumn.Ip round-trips`` () =
    let value = Types.CatShardColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Ip

[<Fact>]
let ``CatShardColumn.MergesCurrent round-trips`` () =
    let value = Types.CatShardColumn.MergesCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesCurrent

[<Fact>]
let ``CatShardColumn.MergesCurrentDocs round-trips`` () =
    let value = Types.CatShardColumn.MergesCurrentDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesCurrentDocs

[<Fact>]
let ``CatShardColumn.MergesCurrentSize round-trips`` () =
    let value = Types.CatShardColumn.MergesCurrentSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesCurrentSize

[<Fact>]
let ``CatShardColumn.MergesTotal round-trips`` () =
    let value = Types.CatShardColumn.MergesTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesTotal

[<Fact>]
let ``CatShardColumn.MergesTotalDocs round-trips`` () =
    let value = Types.CatShardColumn.MergesTotalDocs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesTotalDocs

[<Fact>]
let ``CatShardColumn.MergesTotalSize round-trips`` () =
    let value = Types.CatShardColumn.MergesTotalSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesTotalSize

[<Fact>]
let ``CatShardColumn.MergesTotalTime round-trips`` () =
    let value = Types.CatShardColumn.MergesTotalTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.MergesTotalTime

[<Fact>]
let ``CatShardColumn.Node round-trips`` () =
    let value = Types.CatShardColumn.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Node

[<Fact>]
let ``CatShardColumn.Prirep round-trips`` () =
    let value = Types.CatShardColumn.Prirep
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Prirep

[<Fact>]
let ``CatShardColumn.QueryCacheEvictions round-trips`` () =
    let value = Types.CatShardColumn.QueryCacheEvictions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.QueryCacheEvictions

[<Fact>]
let ``CatShardColumn.QueryCacheMemorySize round-trips`` () =
    let value = Types.CatShardColumn.QueryCacheMemorySize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.QueryCacheMemorySize

[<Fact>]
let ``CatShardColumn.RecoverysourceType round-trips`` () =
    let value = Types.CatShardColumn.RecoverysourceType
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.RecoverysourceType

[<Fact>]
let ``CatShardColumn.RefreshTime round-trips`` () =
    let value = Types.CatShardColumn.RefreshTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.RefreshTime

[<Fact>]
let ``CatShardColumn.RefreshTotal round-trips`` () =
    let value = Types.CatShardColumn.RefreshTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.RefreshTotal

[<Fact>]
let ``CatShardColumn.SearchFetchCurrent round-trips`` () =
    let value = Types.CatShardColumn.SearchFetchCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchFetchCurrent

[<Fact>]
let ``CatShardColumn.SearchFetchTime round-trips`` () =
    let value = Types.CatShardColumn.SearchFetchTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchFetchTime

[<Fact>]
let ``CatShardColumn.SearchFetchTotal round-trips`` () =
    let value = Types.CatShardColumn.SearchFetchTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchFetchTotal

[<Fact>]
let ``CatShardColumn.SearchOpenContexts round-trips`` () =
    let value = Types.CatShardColumn.SearchOpenContexts
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchOpenContexts

[<Fact>]
let ``CatShardColumn.SearchQueryCurrent round-trips`` () =
    let value = Types.CatShardColumn.SearchQueryCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchQueryCurrent

[<Fact>]
let ``CatShardColumn.SearchQueryTime round-trips`` () =
    let value = Types.CatShardColumn.SearchQueryTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchQueryTime

[<Fact>]
let ``CatShardColumn.SearchQueryTotal round-trips`` () =
    let value = Types.CatShardColumn.SearchQueryTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchQueryTotal

[<Fact>]
let ``CatShardColumn.SearchScrollCurrent round-trips`` () =
    let value = Types.CatShardColumn.SearchScrollCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchScrollCurrent

[<Fact>]
let ``CatShardColumn.SearchScrollTime round-trips`` () =
    let value = Types.CatShardColumn.SearchScrollTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchScrollTime

[<Fact>]
let ``CatShardColumn.SearchScrollTotal round-trips`` () =
    let value = Types.CatShardColumn.SearchScrollTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SearchScrollTotal

[<Fact>]
let ``CatShardColumn.SegmentsCount round-trips`` () =
    let value = Types.CatShardColumn.SegmentsCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SegmentsCount

[<Fact>]
let ``CatShardColumn.SegmentsFixedBitsetMemory round-trips`` () =
    let value = Types.CatShardColumn.SegmentsFixedBitsetMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SegmentsFixedBitsetMemory

[<Fact>]
let ``CatShardColumn.SegmentsIndexWriterMemory round-trips`` () =
    let value = Types.CatShardColumn.SegmentsIndexWriterMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SegmentsIndexWriterMemory

[<Fact>]
let ``CatShardColumn.SegmentsMemory round-trips`` () =
    let value = Types.CatShardColumn.SegmentsMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SegmentsMemory

[<Fact>]
let ``CatShardColumn.SegmentsVersionMapMemory round-trips`` () =
    let value = Types.CatShardColumn.SegmentsVersionMapMemory
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SegmentsVersionMapMemory

[<Fact>]
let ``CatShardColumn.SeqNoGlobalCheckpoint round-trips`` () =
    let value = Types.CatShardColumn.SeqNoGlobalCheckpoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SeqNoGlobalCheckpoint

[<Fact>]
let ``CatShardColumn.SeqNoLocalCheckpoint round-trips`` () =
    let value = Types.CatShardColumn.SeqNoLocalCheckpoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SeqNoLocalCheckpoint

[<Fact>]
let ``CatShardColumn.SeqNoMax round-trips`` () =
    let value = Types.CatShardColumn.SeqNoMax
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SeqNoMax

[<Fact>]
let ``CatShardColumn.Shard round-trips`` () =
    let value = Types.CatShardColumn.Shard
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Shard

[<Fact>]
let ``CatShardColumn.DsparseVectorValueCount round-trips`` () =
    let value = Types.CatShardColumn.DsparseVectorValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.DsparseVectorValueCount

[<Fact>]
let ``CatShardColumn.State round-trips`` () =
    let value = Types.CatShardColumn.State
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.State

[<Fact>]
let ``CatShardColumn.Store round-trips`` () =
    let value = Types.CatShardColumn.Store
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.Store

[<Fact>]
let ``CatShardColumn.SuggestCurrent round-trips`` () =
    let value = Types.CatShardColumn.SuggestCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SuggestCurrent

[<Fact>]
let ``CatShardColumn.SuggestTime round-trips`` () =
    let value = Types.CatShardColumn.SuggestTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SuggestTime

[<Fact>]
let ``CatShardColumn.SuggestTotal round-trips`` () =
    let value = Types.CatShardColumn.SuggestTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SuggestTotal

[<Fact>]
let ``CatShardColumn.SyncId round-trips`` () =
    let value = Types.CatShardColumn.SyncId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.SyncId

[<Fact>]
let ``CatShardColumn.UnassignedAt round-trips`` () =
    let value = Types.CatShardColumn.UnassignedAt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.UnassignedAt

[<Fact>]
let ``CatShardColumn.UnassignedDetails round-trips`` () =
    let value = Types.CatShardColumn.UnassignedDetails
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.UnassignedDetails

[<Fact>]
let ``CatShardColumn.UnassignedFor round-trips`` () =
    let value = Types.CatShardColumn.UnassignedFor
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.UnassignedFor

[<Fact>]
let ``CatShardColumn.UnassignedReason round-trips`` () =
    let value = Types.CatShardColumn.UnassignedReason
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatShardColumn> json
    roundTripped |> should equal Types.CatShardColumn.UnassignedReason

[<Fact>]
let ``CatSnapshotsColumn.Id round-trips`` () =
    let value = Types.CatSnapshotsColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.Id

[<Fact>]
let ``CatSnapshotsColumn.Repository round-trips`` () =
    let value = Types.CatSnapshotsColumn.Repository
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.Repository

[<Fact>]
let ``CatSnapshotsColumn.Status round-trips`` () =
    let value = Types.CatSnapshotsColumn.Status
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.Status

[<Fact>]
let ``CatSnapshotsColumn.StartEpoch round-trips`` () =
    let value = Types.CatSnapshotsColumn.StartEpoch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.StartEpoch

[<Fact>]
let ``CatSnapshotsColumn.StartTime round-trips`` () =
    let value = Types.CatSnapshotsColumn.StartTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.StartTime

[<Fact>]
let ``CatSnapshotsColumn.EndEpoch round-trips`` () =
    let value = Types.CatSnapshotsColumn.EndEpoch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.EndEpoch

[<Fact>]
let ``CatSnapshotsColumn.EndTime round-trips`` () =
    let value = Types.CatSnapshotsColumn.EndTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.EndTime

[<Fact>]
let ``CatSnapshotsColumn.Duration round-trips`` () =
    let value = Types.CatSnapshotsColumn.Duration
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.Duration

[<Fact>]
let ``CatSnapshotsColumn.Indices round-trips`` () =
    let value = Types.CatSnapshotsColumn.Indices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.Indices

[<Fact>]
let ``CatSnapshotsColumn.SuccessfulShards round-trips`` () =
    let value = Types.CatSnapshotsColumn.SuccessfulShards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.SuccessfulShards

[<Fact>]
let ``CatSnapshotsColumn.FailedShards round-trips`` () =
    let value = Types.CatSnapshotsColumn.FailedShards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.FailedShards

[<Fact>]
let ``CatSnapshotsColumn.TotalShards round-trips`` () =
    let value = Types.CatSnapshotsColumn.TotalShards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.TotalShards

[<Fact>]
let ``CatSnapshotsColumn.Reason round-trips`` () =
    let value = Types.CatSnapshotsColumn.Reason
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatSnapshotsColumn> json
    roundTripped |> should equal Types.CatSnapshotsColumn.Reason

[<Fact>]
let ``CatTasksColumn.Id round-trips`` () =
    let value = Types.CatTasksColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Id

[<Fact>]
let ``CatTasksColumn.Action round-trips`` () =
    let value = Types.CatTasksColumn.Action
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Action

[<Fact>]
let ``CatTasksColumn.TaskId round-trips`` () =
    let value = Types.CatTasksColumn.TaskId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.TaskId

[<Fact>]
let ``CatTasksColumn.ParentTaskId round-trips`` () =
    let value = Types.CatTasksColumn.ParentTaskId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.ParentTaskId

[<Fact>]
let ``CatTasksColumn.Type round-trips`` () =
    let value = Types.CatTasksColumn.Type
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Type

[<Fact>]
let ``CatTasksColumn.StartTime round-trips`` () =
    let value = Types.CatTasksColumn.StartTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.StartTime

[<Fact>]
let ``CatTasksColumn.Timestamp round-trips`` () =
    let value = Types.CatTasksColumn.Timestamp
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Timestamp

[<Fact>]
let ``CatTasksColumn.RunningTimeNs round-trips`` () =
    let value = Types.CatTasksColumn.RunningTimeNs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.RunningTimeNs

[<Fact>]
let ``CatTasksColumn.RunningTime round-trips`` () =
    let value = Types.CatTasksColumn.RunningTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.RunningTime

[<Fact>]
let ``CatTasksColumn.NodeId round-trips`` () =
    let value = Types.CatTasksColumn.NodeId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.NodeId

[<Fact>]
let ``CatTasksColumn.Ip round-trips`` () =
    let value = Types.CatTasksColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Ip

[<Fact>]
let ``CatTasksColumn.Port round-trips`` () =
    let value = Types.CatTasksColumn.Port
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Port

[<Fact>]
let ``CatTasksColumn.Node round-trips`` () =
    let value = Types.CatTasksColumn.Node
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Node

[<Fact>]
let ``CatTasksColumn.Version round-trips`` () =
    let value = Types.CatTasksColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.Version

[<Fact>]
let ``CatTasksColumn.XOpaqueId round-trips`` () =
    let value = Types.CatTasksColumn.XOpaqueId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTasksColumn> json
    roundTripped |> should equal Types.CatTasksColumn.XOpaqueId

[<Fact>]
let ``CatTemplatesColumn.Name round-trips`` () =
    let value = Types.CatTemplatesColumn.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTemplatesColumn> json
    roundTripped |> should equal Types.CatTemplatesColumn.Name

[<Fact>]
let ``CatTemplatesColumn.IndexPatterns round-trips`` () =
    let value = Types.CatTemplatesColumn.IndexPatterns
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTemplatesColumn> json
    roundTripped |> should equal Types.CatTemplatesColumn.IndexPatterns

[<Fact>]
let ``CatTemplatesColumn.Order round-trips`` () =
    let value = Types.CatTemplatesColumn.Order
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTemplatesColumn> json
    roundTripped |> should equal Types.CatTemplatesColumn.Order

[<Fact>]
let ``CatTemplatesColumn.Version round-trips`` () =
    let value = Types.CatTemplatesColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTemplatesColumn> json
    roundTripped |> should equal Types.CatTemplatesColumn.Version

[<Fact>]
let ``CatTemplatesColumn.ComposedOf round-trips`` () =
    let value = Types.CatTemplatesColumn.ComposedOf
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTemplatesColumn> json
    roundTripped |> should equal Types.CatTemplatesColumn.ComposedOf

[<Fact>]
let ``CatThreadPoolColumn.Active round-trips`` () =
    let value = Types.CatThreadPoolColumn.Active
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Active

[<Fact>]
let ``CatThreadPoolColumn.Completed round-trips`` () =
    let value = Types.CatThreadPoolColumn.Completed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Completed

[<Fact>]
let ``CatThreadPoolColumn.Core round-trips`` () =
    let value = Types.CatThreadPoolColumn.Core
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Core

[<Fact>]
let ``CatThreadPoolColumn.EphemeralId round-trips`` () =
    let value = Types.CatThreadPoolColumn.EphemeralId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.EphemeralId

[<Fact>]
let ``CatThreadPoolColumn.Host round-trips`` () =
    let value = Types.CatThreadPoolColumn.Host
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Host

[<Fact>]
let ``CatThreadPoolColumn.Ip round-trips`` () =
    let value = Types.CatThreadPoolColumn.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Ip

[<Fact>]
let ``CatThreadPoolColumn.KeepAlive round-trips`` () =
    let value = Types.CatThreadPoolColumn.KeepAlive
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.KeepAlive

[<Fact>]
let ``CatThreadPoolColumn.Largest round-trips`` () =
    let value = Types.CatThreadPoolColumn.Largest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Largest

[<Fact>]
let ``CatThreadPoolColumn.Max round-trips`` () =
    let value = Types.CatThreadPoolColumn.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Max

[<Fact>]
let ``CatThreadPoolColumn.Name round-trips`` () =
    let value = Types.CatThreadPoolColumn.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Name

[<Fact>]
let ``CatThreadPoolColumn.NodeId round-trips`` () =
    let value = Types.CatThreadPoolColumn.NodeId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.NodeId

[<Fact>]
let ``CatThreadPoolColumn.NodeName round-trips`` () =
    let value = Types.CatThreadPoolColumn.NodeName
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.NodeName

[<Fact>]
let ``CatThreadPoolColumn.Pid round-trips`` () =
    let value = Types.CatThreadPoolColumn.Pid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Pid

[<Fact>]
let ``CatThreadPoolColumn.PoolSize round-trips`` () =
    let value = Types.CatThreadPoolColumn.PoolSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.PoolSize

[<Fact>]
let ``CatThreadPoolColumn.Port round-trips`` () =
    let value = Types.CatThreadPoolColumn.Port
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Port

[<Fact>]
let ``CatThreadPoolColumn.Queue round-trips`` () =
    let value = Types.CatThreadPoolColumn.Queue
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Queue

[<Fact>]
let ``CatThreadPoolColumn.QueueSize round-trips`` () =
    let value = Types.CatThreadPoolColumn.QueueSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.QueueSize

[<Fact>]
let ``CatThreadPoolColumn.Rejected round-trips`` () =
    let value = Types.CatThreadPoolColumn.Rejected
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Rejected

[<Fact>]
let ``CatThreadPoolColumn.Size round-trips`` () =
    let value = Types.CatThreadPoolColumn.Size
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Size

[<Fact>]
let ``CatThreadPoolColumn.Type round-trips`` () =
    let value = Types.CatThreadPoolColumn.Type
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatThreadPoolColumn> json
    roundTripped |> should equal Types.CatThreadPoolColumn.Type

[<Fact>]
let ``CatTrainedModelsColumn.CreateTime round-trips`` () =
    let value = Types.CatTrainedModelsColumn.CreateTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.CreateTime

[<Fact>]
let ``CatTrainedModelsColumn.CreatedBy round-trips`` () =
    let value = Types.CatTrainedModelsColumn.CreatedBy
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.CreatedBy

[<Fact>]
let ``CatTrainedModelsColumn.DataFrameAnalyticsId round-trips`` () =
    let value = Types.CatTrainedModelsColumn.DataFrameAnalyticsId
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.DataFrameAnalyticsId

[<Fact>]
let ``CatTrainedModelsColumn.Description round-trips`` () =
    let value = Types.CatTrainedModelsColumn.Description
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.Description

[<Fact>]
let ``CatTrainedModelsColumn.HeapSize round-trips`` () =
    let value = Types.CatTrainedModelsColumn.HeapSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.HeapSize

[<Fact>]
let ``CatTrainedModelsColumn.Id round-trips`` () =
    let value = Types.CatTrainedModelsColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.Id

[<Fact>]
let ``CatTrainedModelsColumn.IngestCount round-trips`` () =
    let value = Types.CatTrainedModelsColumn.IngestCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.IngestCount

[<Fact>]
let ``CatTrainedModelsColumn.IngestCurrent round-trips`` () =
    let value = Types.CatTrainedModelsColumn.IngestCurrent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.IngestCurrent

[<Fact>]
let ``CatTrainedModelsColumn.IngestFailed round-trips`` () =
    let value = Types.CatTrainedModelsColumn.IngestFailed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.IngestFailed

[<Fact>]
let ``CatTrainedModelsColumn.IngestPipelines round-trips`` () =
    let value = Types.CatTrainedModelsColumn.IngestPipelines
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.IngestPipelines

[<Fact>]
let ``CatTrainedModelsColumn.IngestTime round-trips`` () =
    let value = Types.CatTrainedModelsColumn.IngestTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.IngestTime

[<Fact>]
let ``CatTrainedModelsColumn.License round-trips`` () =
    let value = Types.CatTrainedModelsColumn.License
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.License

[<Fact>]
let ``CatTrainedModelsColumn.Operations round-trips`` () =
    let value = Types.CatTrainedModelsColumn.Operations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.Operations

[<Fact>]
let ``CatTrainedModelsColumn.Version round-trips`` () =
    let value = Types.CatTrainedModelsColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTrainedModelsColumn> json
    roundTripped |> should equal Types.CatTrainedModelsColumn.Version

[<Fact>]
let ``CatTransformColumn.ChangesLastDetectionTime round-trips`` () =
    let value = Types.CatTransformColumn.ChangesLastDetectionTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.ChangesLastDetectionTime

[<Fact>]
let ``CatTransformColumn.Checkpoint round-trips`` () =
    let value = Types.CatTransformColumn.Checkpoint
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Checkpoint

[<Fact>]
let ``CatTransformColumn.CheckpointDurationTimeExpAvg round-trips`` () =
    let value = Types.CatTransformColumn.CheckpointDurationTimeExpAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.CheckpointDurationTimeExpAvg

[<Fact>]
let ``CatTransformColumn.CheckpointProgress round-trips`` () =
    let value = Types.CatTransformColumn.CheckpointProgress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.CheckpointProgress

[<Fact>]
let ``CatTransformColumn.CreateTime round-trips`` () =
    let value = Types.CatTransformColumn.CreateTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.CreateTime

[<Fact>]
let ``CatTransformColumn.DeleteTime round-trips`` () =
    let value = Types.CatTransformColumn.DeleteTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.DeleteTime

[<Fact>]
let ``CatTransformColumn.Description round-trips`` () =
    let value = Types.CatTransformColumn.Description
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Description

[<Fact>]
let ``CatTransformColumn.DestIndex round-trips`` () =
    let value = Types.CatTransformColumn.DestIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.DestIndex

[<Fact>]
let ``CatTransformColumn.DocumentsDeleted round-trips`` () =
    let value = Types.CatTransformColumn.DocumentsDeleted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.DocumentsDeleted

[<Fact>]
let ``CatTransformColumn.DocumentsIndexed round-trips`` () =
    let value = Types.CatTransformColumn.DocumentsIndexed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.DocumentsIndexed

[<Fact>]
let ``CatTransformColumn.DocsPerSecond round-trips`` () =
    let value = Types.CatTransformColumn.DocsPerSecond
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.DocsPerSecond

[<Fact>]
let ``CatTransformColumn.DocumentsProcessed round-trips`` () =
    let value = Types.CatTransformColumn.DocumentsProcessed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.DocumentsProcessed

[<Fact>]
let ``CatTransformColumn.Frequency round-trips`` () =
    let value = Types.CatTransformColumn.Frequency
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Frequency

[<Fact>]
let ``CatTransformColumn.Id round-trips`` () =
    let value = Types.CatTransformColumn.Id
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Id

[<Fact>]
let ``CatTransformColumn.IndexFailure round-trips`` () =
    let value = Types.CatTransformColumn.IndexFailure
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.IndexFailure

[<Fact>]
let ``CatTransformColumn.IndexTime round-trips`` () =
    let value = Types.CatTransformColumn.IndexTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.IndexTime

[<Fact>]
let ``CatTransformColumn.IndexTotal round-trips`` () =
    let value = Types.CatTransformColumn.IndexTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.IndexTotal

[<Fact>]
let ``CatTransformColumn.IndexedDocumentsExpAvg round-trips`` () =
    let value = Types.CatTransformColumn.IndexedDocumentsExpAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.IndexedDocumentsExpAvg

[<Fact>]
let ``CatTransformColumn.LastSearchTime round-trips`` () =
    let value = Types.CatTransformColumn.LastSearchTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.LastSearchTime

[<Fact>]
let ``CatTransformColumn.MaxPageSearchSize round-trips`` () =
    let value = Types.CatTransformColumn.MaxPageSearchSize
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.MaxPageSearchSize

[<Fact>]
let ``CatTransformColumn.PagesProcessed round-trips`` () =
    let value = Types.CatTransformColumn.PagesProcessed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.PagesProcessed

[<Fact>]
let ``CatTransformColumn.Pipeline round-trips`` () =
    let value = Types.CatTransformColumn.Pipeline
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Pipeline

[<Fact>]
let ``CatTransformColumn.ProcessedDocumentsExpAvg round-trips`` () =
    let value = Types.CatTransformColumn.ProcessedDocumentsExpAvg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.ProcessedDocumentsExpAvg

[<Fact>]
let ``CatTransformColumn.ProcessingTime round-trips`` () =
    let value = Types.CatTransformColumn.ProcessingTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.ProcessingTime

[<Fact>]
let ``CatTransformColumn.Reason round-trips`` () =
    let value = Types.CatTransformColumn.Reason
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Reason

[<Fact>]
let ``CatTransformColumn.SearchFailure round-trips`` () =
    let value = Types.CatTransformColumn.SearchFailure
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.SearchFailure

[<Fact>]
let ``CatTransformColumn.SearchTime round-trips`` () =
    let value = Types.CatTransformColumn.SearchTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.SearchTime

[<Fact>]
let ``CatTransformColumn.SearchTotal round-trips`` () =
    let value = Types.CatTransformColumn.SearchTotal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.SearchTotal

[<Fact>]
let ``CatTransformColumn.SourceIndex round-trips`` () =
    let value = Types.CatTransformColumn.SourceIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.SourceIndex

[<Fact>]
let ``CatTransformColumn.State round-trips`` () =
    let value = Types.CatTransformColumn.State
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.State

[<Fact>]
let ``CatTransformColumn.TransformType round-trips`` () =
    let value = Types.CatTransformColumn.TransformType
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.TransformType

[<Fact>]
let ``CatTransformColumn.TriggerCount round-trips`` () =
    let value = Types.CatTransformColumn.TriggerCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.TriggerCount

[<Fact>]
let ``CatTransformColumn.Version round-trips`` () =
    let value = Types.CatTransformColumn.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CatTransformColumn> json
    roundTripped |> should equal Types.CatTransformColumn.Version

[<Fact>]
let ``FollowerIndexStatus.Active round-trips`` () =
    let value = Types.FollowerIndexStatus.Active
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FollowerIndexStatus> json
    roundTripped |> should equal Types.FollowerIndexStatus.Active

[<Fact>]
let ``FollowerIndexStatus.Paused round-trips`` () =
    let value = Types.FollowerIndexStatus.Paused
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FollowerIndexStatus> json
    roundTripped |> should equal Types.FollowerIndexStatus.Paused

[<Fact>]
let ``AllocationExplainDecision.NO round-trips`` () =
    let value = Types.AllocationExplainDecision.NO
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AllocationExplainDecision> json
    roundTripped |> should equal Types.AllocationExplainDecision.NO

[<Fact>]
let ``AllocationExplainDecision.YES round-trips`` () =
    let value = Types.AllocationExplainDecision.YES
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AllocationExplainDecision> json
    roundTripped |> should equal Types.AllocationExplainDecision.YES

[<Fact>]
let ``AllocationExplainDecision.THROTTLE round-trips`` () =
    let value = Types.AllocationExplainDecision.THROTTLE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AllocationExplainDecision> json
    roundTripped |> should equal Types.AllocationExplainDecision.THROTTLE

[<Fact>]
let ``AllocationExplainDecision.ALWAYS round-trips`` () =
    let value = Types.AllocationExplainDecision.ALWAYS
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AllocationExplainDecision> json
    roundTripped |> should equal Types.AllocationExplainDecision.ALWAYS

[<Fact>]
let ``Decision.Yes round-trips`` () =
    let value = Types.Decision.Yes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.Yes

[<Fact>]
let ``Decision.No round-trips`` () =
    let value = Types.Decision.No
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.No

[<Fact>]
let ``Decision.WorseBalance round-trips`` () =
    let value = Types.Decision.WorseBalance
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.WorseBalance

[<Fact>]
let ``Decision.Throttled round-trips`` () =
    let value = Types.Decision.Throttled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.Throttled

[<Fact>]
let ``Decision.AwaitingInfo round-trips`` () =
    let value = Types.Decision.AwaitingInfo
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.AwaitingInfo

[<Fact>]
let ``Decision.AllocationDelayed round-trips`` () =
    let value = Types.Decision.AllocationDelayed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.AllocationDelayed

[<Fact>]
let ``Decision.NoValidShardCopy round-trips`` () =
    let value = Types.Decision.NoValidShardCopy
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.NoValidShardCopy

[<Fact>]
let ``Decision.NoAttempt round-trips`` () =
    let value = Types.Decision.NoAttempt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Decision> json
    roundTripped |> should equal Types.Decision.NoAttempt

[<Fact>]
let ``UnassignedInformationReason.INDEXCREATED round-trips`` () =
    let value = Types.UnassignedInformationReason.INDEXCREATED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.INDEXCREATED

[<Fact>]
let ``UnassignedInformationReason.CLUSTERRECOVERED round-trips`` () =
    let value = Types.UnassignedInformationReason.CLUSTERRECOVERED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.CLUSTERRECOVERED

[<Fact>]
let ``UnassignedInformationReason.INDEXREOPENED round-trips`` () =
    let value = Types.UnassignedInformationReason.INDEXREOPENED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.INDEXREOPENED

[<Fact>]
let ``UnassignedInformationReason.DANGLINGINDEXIMPORTED round-trips`` () =
    let value = Types.UnassignedInformationReason.DANGLINGINDEXIMPORTED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.DANGLINGINDEXIMPORTED

[<Fact>]
let ``UnassignedInformationReason.NEWINDEXRESTORED round-trips`` () =
    let value = Types.UnassignedInformationReason.NEWINDEXRESTORED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.NEWINDEXRESTORED

[<Fact>]
let ``UnassignedInformationReason.EXISTINGINDEXRESTORED round-trips`` () =
    let value = Types.UnassignedInformationReason.EXISTINGINDEXRESTORED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.EXISTINGINDEXRESTORED

[<Fact>]
let ``UnassignedInformationReason.REPLICAADDED round-trips`` () =
    let value = Types.UnassignedInformationReason.REPLICAADDED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.REPLICAADDED

[<Fact>]
let ``UnassignedInformationReason.ALLOCATIONFAILED round-trips`` () =
    let value = Types.UnassignedInformationReason.ALLOCATIONFAILED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.ALLOCATIONFAILED

[<Fact>]
let ``UnassignedInformationReason.NODELEFT round-trips`` () =
    let value = Types.UnassignedInformationReason.NODELEFT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.NODELEFT

[<Fact>]
let ``UnassignedInformationReason.REROUTECANCELLED round-trips`` () =
    let value = Types.UnassignedInformationReason.REROUTECANCELLED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.REROUTECANCELLED

[<Fact>]
let ``UnassignedInformationReason.REINITIALIZED round-trips`` () =
    let value = Types.UnassignedInformationReason.REINITIALIZED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.REINITIALIZED

[<Fact>]
let ``UnassignedInformationReason.REALLOCATEDREPLICA round-trips`` () =
    let value = Types.UnassignedInformationReason.REALLOCATEDREPLICA
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.REALLOCATEDREPLICA

[<Fact>]
let ``UnassignedInformationReason.PRIMARYFAILED round-trips`` () =
    let value = Types.UnassignedInformationReason.PRIMARYFAILED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.PRIMARYFAILED

[<Fact>]
let ``UnassignedInformationReason.FORCEDEMPTYPRIMARY round-trips`` () =
    let value = Types.UnassignedInformationReason.FORCEDEMPTYPRIMARY
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.FORCEDEMPTYPRIMARY

[<Fact>]
let ``UnassignedInformationReason.MANUALALLOCATION round-trips`` () =
    let value = Types.UnassignedInformationReason.MANUALALLOCATION
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UnassignedInformationReason> json
    roundTripped |> should equal Types.UnassignedInformationReason.MANUALALLOCATION

[<Fact>]
let ``ClusterStateMetric.All round-trips`` () =
    let value = Types.ClusterStateMetric.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.All

[<Fact>]
let ``ClusterStateMetric.Version round-trips`` () =
    let value = Types.ClusterStateMetric.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.Version

[<Fact>]
let ``ClusterStateMetric.MasterNode round-trips`` () =
    let value = Types.ClusterStateMetric.MasterNode
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.MasterNode

[<Fact>]
let ``ClusterStateMetric.Blocks round-trips`` () =
    let value = Types.ClusterStateMetric.Blocks
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.Blocks

[<Fact>]
let ``ClusterStateMetric.Nodes round-trips`` () =
    let value = Types.ClusterStateMetric.Nodes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.Nodes

[<Fact>]
let ``ClusterStateMetric.Metadata round-trips`` () =
    let value = Types.ClusterStateMetric.Metadata
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.Metadata

[<Fact>]
let ``ClusterStateMetric.RoutingTable round-trips`` () =
    let value = Types.ClusterStateMetric.RoutingTable
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.RoutingTable

[<Fact>]
let ``ClusterStateMetric.RoutingNodes round-trips`` () =
    let value = Types.ClusterStateMetric.RoutingNodes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.RoutingNodes

[<Fact>]
let ``ClusterStateMetric.Customs round-trips`` () =
    let value = Types.ClusterStateMetric.Customs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterStateMetric> json
    roundTripped |> should equal Types.ClusterStateMetric.Customs

[<Fact>]
let ``ShardState.INIT round-trips`` () =
    let value = Types.ShardState.INIT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.INIT

[<Fact>]
let ``ShardState.SUCCESS round-trips`` () =
    let value = Types.ShardState.SUCCESS
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.SUCCESS

[<Fact>]
let ``ShardState.FAILED round-trips`` () =
    let value = Types.ShardState.FAILED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.FAILED

[<Fact>]
let ``ShardState.ABORTED round-trips`` () =
    let value = Types.ShardState.ABORTED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.ABORTED

[<Fact>]
let ``ShardState.MISSING round-trips`` () =
    let value = Types.ShardState.MISSING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.MISSING

[<Fact>]
let ``ShardState.WAITING round-trips`` () =
    let value = Types.ShardState.WAITING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.WAITING

[<Fact>]
let ``ShardState.QUEUED round-trips`` () =
    let value = Types.ShardState.QUEUED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.QUEUED

[<Fact>]
let ``ShardState.PAUSEDFORNODEREMOVAL round-trips`` () =
    let value = Types.ShardState.PAUSEDFORNODEREMOVAL
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardState> json
    roundTripped |> should equal Types.ShardState.PAUSEDFORNODEREMOVAL

[<Fact>]
let ``SortType.Doc round-trips`` () =
    let value = Types.SortType.Doc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortType> json
    roundTripped |> should equal Types.SortType.Doc

[<Fact>]
let ``SortType.GeoDistance round-trips`` () =
    let value = Types.SortType.GeoDistance
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortType> json
    roundTripped |> should equal Types.SortType.GeoDistance

[<Fact>]
let ``SortType.Score round-trips`` () =
    let value = Types.SortType.Score
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortType> json
    roundTripped |> should equal Types.SortType.Score

[<Fact>]
let ``SortType.Script round-trips`` () =
    let value = Types.SortType.Script
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortType> json
    roundTripped |> should equal Types.SortType.Script

[<Fact>]
let ``SortType.FieldSort round-trips`` () =
    let value = Types.SortType.FieldSort
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SortType> json
    roundTripped |> should equal Types.SortType.FieldSort

[<Fact>]
let ``ConnectorFieldType.Str round-trips`` () =
    let value = Types.ConnectorFieldType.Str
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorFieldType> json
    roundTripped |> should equal Types.ConnectorFieldType.Str

[<Fact>]
let ``ConnectorFieldType.Int round-trips`` () =
    let value = Types.ConnectorFieldType.Int
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorFieldType> json
    roundTripped |> should equal Types.ConnectorFieldType.Int

[<Fact>]
let ``ConnectorFieldType.List round-trips`` () =
    let value = Types.ConnectorFieldType.List
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorFieldType> json
    roundTripped |> should equal Types.ConnectorFieldType.List

[<Fact>]
let ``ConnectorFieldType.Bool round-trips`` () =
    let value = Types.ConnectorFieldType.Bool
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorFieldType> json
    roundTripped |> should equal Types.ConnectorFieldType.Bool

[<Fact>]
let ``ConnectorStatus.Created round-trips`` () =
    let value = Types.ConnectorStatus.Created
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorStatus> json
    roundTripped |> should equal Types.ConnectorStatus.Created

[<Fact>]
let ``ConnectorStatus.NeedsConfiguration round-trips`` () =
    let value = Types.ConnectorStatus.NeedsConfiguration
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorStatus> json
    roundTripped |> should equal Types.ConnectorStatus.NeedsConfiguration

[<Fact>]
let ``ConnectorStatus.Configured round-trips`` () =
    let value = Types.ConnectorStatus.Configured
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorStatus> json
    roundTripped |> should equal Types.ConnectorStatus.Configured

[<Fact>]
let ``ConnectorStatus.Connected round-trips`` () =
    let value = Types.ConnectorStatus.Connected
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorStatus> json
    roundTripped |> should equal Types.ConnectorStatus.Connected

[<Fact>]
let ``ConnectorStatus.Error round-trips`` () =
    let value = Types.ConnectorStatus.Error
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectorStatus> json
    roundTripped |> should equal Types.ConnectorStatus.Error

[<Fact>]
let ``DisplayType.Textbox round-trips`` () =
    let value = Types.DisplayType.Textbox
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DisplayType> json
    roundTripped |> should equal Types.DisplayType.Textbox

[<Fact>]
let ``DisplayType.Textarea round-trips`` () =
    let value = Types.DisplayType.Textarea
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DisplayType> json
    roundTripped |> should equal Types.DisplayType.Textarea

[<Fact>]
let ``DisplayType.Numeric round-trips`` () =
    let value = Types.DisplayType.Numeric
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DisplayType> json
    roundTripped |> should equal Types.DisplayType.Numeric

[<Fact>]
let ``DisplayType.Toggle round-trips`` () =
    let value = Types.DisplayType.Toggle
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DisplayType> json
    roundTripped |> should equal Types.DisplayType.Toggle

[<Fact>]
let ``DisplayType.Dropdown round-trips`` () =
    let value = Types.DisplayType.Dropdown
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DisplayType> json
    roundTripped |> should equal Types.DisplayType.Dropdown

[<Fact>]
let ``FilteringPolicy.Exclude round-trips`` () =
    let value = Types.FilteringPolicy.Exclude
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringPolicy> json
    roundTripped |> should equal Types.FilteringPolicy.Exclude

[<Fact>]
let ``FilteringPolicy.Include round-trips`` () =
    let value = Types.FilteringPolicy.Include
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringPolicy> json
    roundTripped |> should equal Types.FilteringPolicy.Include

[<Fact>]
let ``FilteringRuleRule.Contains round-trips`` () =
    let value = Types.FilteringRuleRule.Contains
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.Contains

[<Fact>]
let ``FilteringRuleRule.EndsWith round-trips`` () =
    let value = Types.FilteringRuleRule.EndsWith
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.EndsWith

[<Fact>]
let ``FilteringRuleRule.Equals round-trips`` () =
    let value = Types.FilteringRuleRule.Equals
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.Equals

[<Fact>]
let ``FilteringRuleRule.Regex round-trips`` () =
    let value = Types.FilteringRuleRule.Regex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.Regex

[<Fact>]
let ``FilteringRuleRule.StartsWith round-trips`` () =
    let value = Types.FilteringRuleRule.StartsWith
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.StartsWith

[<Fact>]
let ``FilteringRuleRule.Gt round-trips`` () =
    let value = Types.FilteringRuleRule.Gt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.Gt

[<Fact>]
let ``FilteringRuleRule.Lt round-trips`` () =
    let value = Types.FilteringRuleRule.Lt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringRuleRule> json
    roundTripped |> should equal Types.FilteringRuleRule.Lt

[<Fact>]
let ``FilteringValidationState.Edited round-trips`` () =
    let value = Types.FilteringValidationState.Edited
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringValidationState> json
    roundTripped |> should equal Types.FilteringValidationState.Edited

[<Fact>]
let ``FilteringValidationState.Invalid round-trips`` () =
    let value = Types.FilteringValidationState.Invalid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringValidationState> json
    roundTripped |> should equal Types.FilteringValidationState.Invalid

[<Fact>]
let ``FilteringValidationState.Valid round-trips`` () =
    let value = Types.FilteringValidationState.Valid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilteringValidationState> json
    roundTripped |> should equal Types.FilteringValidationState.Valid

[<Fact>]
let ``SyncJobTriggerMethod.OnDemand round-trips`` () =
    let value = Types.SyncJobTriggerMethod.OnDemand
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncJobTriggerMethod> json
    roundTripped |> should equal Types.SyncJobTriggerMethod.OnDemand

[<Fact>]
let ``SyncJobTriggerMethod.Scheduled round-trips`` () =
    let value = Types.SyncJobTriggerMethod.Scheduled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncJobTriggerMethod> json
    roundTripped |> should equal Types.SyncJobTriggerMethod.Scheduled

[<Fact>]
let ``SyncJobType.Full round-trips`` () =
    let value = Types.SyncJobType.Full
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncJobType> json
    roundTripped |> should equal Types.SyncJobType.Full

[<Fact>]
let ``SyncJobType.Incremental round-trips`` () =
    let value = Types.SyncJobType.Incremental
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncJobType> json
    roundTripped |> should equal Types.SyncJobType.Incremental

[<Fact>]
let ``SyncJobType.AccessControl round-trips`` () =
    let value = Types.SyncJobType.AccessControl
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncJobType> json
    roundTripped |> should equal Types.SyncJobType.AccessControl

[<Fact>]
let ``SyncStatus.Canceling round-trips`` () =
    let value = Types.SyncStatus.Canceling
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.Canceling

[<Fact>]
let ``SyncStatus.Canceled round-trips`` () =
    let value = Types.SyncStatus.Canceled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.Canceled

[<Fact>]
let ``SyncStatus.Completed round-trips`` () =
    let value = Types.SyncStatus.Completed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.Completed

[<Fact>]
let ``SyncStatus.Error round-trips`` () =
    let value = Types.SyncStatus.Error
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.Error

[<Fact>]
let ``SyncStatus.InProgress round-trips`` () =
    let value = Types.SyncStatus.InProgress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.InProgress

[<Fact>]
let ``SyncStatus.Pending round-trips`` () =
    let value = Types.SyncStatus.Pending
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.Pending

[<Fact>]
let ``SyncStatus.Suspended round-trips`` () =
    let value = Types.SyncStatus.Suspended
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SyncStatus> json
    roundTripped |> should equal Types.SyncStatus.Suspended

[<Fact>]
let ``PolicyType.GeoMatch round-trips`` () =
    let value = Types.PolicyType.GeoMatch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PolicyType> json
    roundTripped |> should equal Types.PolicyType.GeoMatch

[<Fact>]
let ``PolicyType.Match round-trips`` () =
    let value = Types.PolicyType.Match
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PolicyType> json
    roundTripped |> should equal Types.PolicyType.Match

[<Fact>]
let ``PolicyType.Range round-trips`` () =
    let value = Types.PolicyType.Range
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PolicyType> json
    roundTripped |> should equal Types.PolicyType.Range

[<Fact>]
let ``EnrichPolicyPhase.SCHEDULED round-trips`` () =
    let value = Types.EnrichPolicyPhase.SCHEDULED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EnrichPolicyPhase> json
    roundTripped |> should equal Types.EnrichPolicyPhase.SCHEDULED

[<Fact>]
let ``EnrichPolicyPhase.RUNNING round-trips`` () =
    let value = Types.EnrichPolicyPhase.RUNNING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EnrichPolicyPhase> json
    roundTripped |> should equal Types.EnrichPolicyPhase.RUNNING

[<Fact>]
let ``EnrichPolicyPhase.COMPLETE round-trips`` () =
    let value = Types.EnrichPolicyPhase.COMPLETE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EnrichPolicyPhase> json
    roundTripped |> should equal Types.EnrichPolicyPhase.COMPLETE

[<Fact>]
let ``EnrichPolicyPhase.FAILED round-trips`` () =
    let value = Types.EnrichPolicyPhase.FAILED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EnrichPolicyPhase> json
    roundTripped |> should equal Types.EnrichPolicyPhase.FAILED

[<Fact>]
let ``EnrichPolicyPhase.CANCELLED round-trips`` () =
    let value = Types.EnrichPolicyPhase.CANCELLED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EnrichPolicyPhase> json
    roundTripped |> should equal Types.EnrichPolicyPhase.CANCELLED

[<Fact>]
let ``ResultPosition.Tail round-trips`` () =
    let value = Types.ResultPosition.Tail
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ResultPosition> json
    roundTripped |> should equal Types.ResultPosition.Tail

[<Fact>]
let ``ResultPosition.Head round-trips`` () =
    let value = Types.ResultPosition.Head
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ResultPosition> json
    roundTripped |> should equal Types.ResultPosition.Head

[<Fact>]
let ``EsqlClusterStatus.Running round-trips`` () =
    let value = Types.EsqlClusterStatus.Running
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlClusterStatus> json
    roundTripped |> should equal Types.EsqlClusterStatus.Running

[<Fact>]
let ``EsqlClusterStatus.Successful round-trips`` () =
    let value = Types.EsqlClusterStatus.Successful
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlClusterStatus> json
    roundTripped |> should equal Types.EsqlClusterStatus.Successful

[<Fact>]
let ``EsqlClusterStatus.Partial round-trips`` () =
    let value = Types.EsqlClusterStatus.Partial
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlClusterStatus> json
    roundTripped |> should equal Types.EsqlClusterStatus.Partial

[<Fact>]
let ``EsqlClusterStatus.Skipped round-trips`` () =
    let value = Types.EsqlClusterStatus.Skipped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlClusterStatus> json
    roundTripped |> should equal Types.EsqlClusterStatus.Skipped

[<Fact>]
let ``EsqlClusterStatus.Failed round-trips`` () =
    let value = Types.EsqlClusterStatus.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlClusterStatus> json
    roundTripped |> should equal Types.EsqlClusterStatus.Failed

[<Fact>]
let ``EsqlFormat.Csv round-trips`` () =
    let value = Types.EsqlFormat.Csv
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Csv

[<Fact>]
let ``EsqlFormat.Json round-trips`` () =
    let value = Types.EsqlFormat.Json
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Json

[<Fact>]
let ``EsqlFormat.Tsv round-trips`` () =
    let value = Types.EsqlFormat.Tsv
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Tsv

[<Fact>]
let ``EsqlFormat.Txt round-trips`` () =
    let value = Types.EsqlFormat.Txt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Txt

[<Fact>]
let ``EsqlFormat.Yaml round-trips`` () =
    let value = Types.EsqlFormat.Yaml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Yaml

[<Fact>]
let ``EsqlFormat.Cbor round-trips`` () =
    let value = Types.EsqlFormat.Cbor
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Cbor

[<Fact>]
let ``EsqlFormat.Smile round-trips`` () =
    let value = Types.EsqlFormat.Smile
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Smile

[<Fact>]
let ``EsqlFormat.Arrow round-trips`` () =
    let value = Types.EsqlFormat.Arrow
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EsqlFormat> json
    roundTripped |> should equal Types.EsqlFormat.Arrow

[<Fact>]
let ``IndexCheckOnStartup.True round-trips`` () =
    let value = Types.IndexCheckOnStartup.True
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexCheckOnStartup> json
    roundTripped |> should equal Types.IndexCheckOnStartup.True

[<Fact>]
let ``IndexCheckOnStartup.False round-trips`` () =
    let value = Types.IndexCheckOnStartup.False
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexCheckOnStartup> json
    roundTripped |> should equal Types.IndexCheckOnStartup.False

[<Fact>]
let ``IndexCheckOnStartup.Checksum round-trips`` () =
    let value = Types.IndexCheckOnStartup.Checksum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexCheckOnStartup> json
    roundTripped |> should equal Types.IndexCheckOnStartup.Checksum

[<Fact>]
let ``IndexMode.Standard round-trips`` () =
    let value = Types.IndexMode.Standard
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexMode> json
    roundTripped |> should equal Types.IndexMode.Standard

[<Fact>]
let ``IndexMode.TimeSeries round-trips`` () =
    let value = Types.IndexMode.TimeSeries
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexMode> json
    roundTripped |> should equal Types.IndexMode.TimeSeries

[<Fact>]
let ``IndexMode.Logsdb round-trips`` () =
    let value = Types.IndexMode.Logsdb
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexMode> json
    roundTripped |> should equal Types.IndexMode.Logsdb

[<Fact>]
let ``IndexMode.Lookup round-trips`` () =
    let value = Types.IndexMode.Lookup
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexMode> json
    roundTripped |> should equal Types.IndexMode.Lookup

[<Fact>]
let ``IndexRoutingAllocationOptions.All round-trips`` () =
    let value = Types.IndexRoutingAllocationOptions.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingAllocationOptions> json
    roundTripped |> should equal Types.IndexRoutingAllocationOptions.All

[<Fact>]
let ``IndexRoutingAllocationOptions.Primaries round-trips`` () =
    let value = Types.IndexRoutingAllocationOptions.Primaries
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingAllocationOptions> json
    roundTripped |> should equal Types.IndexRoutingAllocationOptions.Primaries

[<Fact>]
let ``IndexRoutingAllocationOptions.NewPrimaries round-trips`` () =
    let value = Types.IndexRoutingAllocationOptions.NewPrimaries
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingAllocationOptions> json
    roundTripped |> should equal Types.IndexRoutingAllocationOptions.NewPrimaries

[<Fact>]
let ``IndexRoutingAllocationOptions.None round-trips`` () =
    let value = Types.IndexRoutingAllocationOptions.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingAllocationOptions> json
    roundTripped |> should equal Types.IndexRoutingAllocationOptions.None

[<Fact>]
let ``IndexRoutingRebalanceOptions.All round-trips`` () =
    let value = Types.IndexRoutingRebalanceOptions.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingRebalanceOptions> json
    roundTripped |> should equal Types.IndexRoutingRebalanceOptions.All

[<Fact>]
let ``IndexRoutingRebalanceOptions.Primaries round-trips`` () =
    let value = Types.IndexRoutingRebalanceOptions.Primaries
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingRebalanceOptions> json
    roundTripped |> should equal Types.IndexRoutingRebalanceOptions.Primaries

[<Fact>]
let ``IndexRoutingRebalanceOptions.Replicas round-trips`` () =
    let value = Types.IndexRoutingRebalanceOptions.Replicas
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingRebalanceOptions> json
    roundTripped |> should equal Types.IndexRoutingRebalanceOptions.Replicas

[<Fact>]
let ``IndexRoutingRebalanceOptions.None round-trips`` () =
    let value = Types.IndexRoutingRebalanceOptions.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexRoutingRebalanceOptions> json
    roundTripped |> should equal Types.IndexRoutingRebalanceOptions.None

[<Fact>]
let ``IndicesBlockOptions.Metadata round-trips`` () =
    let value = Types.IndicesBlockOptions.Metadata
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesBlockOptions> json
    roundTripped |> should equal Types.IndicesBlockOptions.Metadata

[<Fact>]
let ``IndicesBlockOptions.Read round-trips`` () =
    let value = Types.IndicesBlockOptions.Read
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesBlockOptions> json
    roundTripped |> should equal Types.IndicesBlockOptions.Read

[<Fact>]
let ``IndicesBlockOptions.ReadOnly round-trips`` () =
    let value = Types.IndicesBlockOptions.ReadOnly
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesBlockOptions> json
    roundTripped |> should equal Types.IndicesBlockOptions.ReadOnly

[<Fact>]
let ``IndicesBlockOptions.Write round-trips`` () =
    let value = Types.IndicesBlockOptions.Write
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesBlockOptions> json
    roundTripped |> should equal Types.IndicesBlockOptions.Write

[<Fact>]
let ``ManagedBy.IndexLifecycleManagement round-trips`` () =
    let value = Types.ManagedBy.IndexLifecycleManagement
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ManagedBy> json
    roundTripped |> should equal Types.ManagedBy.IndexLifecycleManagement

[<Fact>]
let ``ManagedBy.DataStreamLifecycle round-trips`` () =
    let value = Types.ManagedBy.DataStreamLifecycle
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ManagedBy> json
    roundTripped |> should equal Types.ManagedBy.DataStreamLifecycle

[<Fact>]
let ``ManagedBy.Unmanaged round-trips`` () =
    let value = Types.ManagedBy.Unmanaged
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ManagedBy> json
    roundTripped |> should equal Types.ManagedBy.Unmanaged

[<Fact>]
let ``NumericFielddataFormat.Array round-trips`` () =
    let value = Types.NumericFielddataFormat.Array
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NumericFielddataFormat> json
    roundTripped |> should equal Types.NumericFielddataFormat.Array

[<Fact>]
let ``NumericFielddataFormat.Disabled round-trips`` () =
    let value = Types.NumericFielddataFormat.Disabled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NumericFielddataFormat> json
    roundTripped |> should equal Types.NumericFielddataFormat.Disabled

[<Fact>]
let ``SamplingMethod.Aggregate round-trips`` () =
    let value = Types.SamplingMethod.Aggregate
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SamplingMethod> json
    roundTripped |> should equal Types.SamplingMethod.Aggregate

[<Fact>]
let ``SamplingMethod.LastValue round-trips`` () =
    let value = Types.SamplingMethod.LastValue
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SamplingMethod> json
    roundTripped |> should equal Types.SamplingMethod.LastValue

[<Fact>]
let ``SegmentSortMissing.Last round-trips`` () =
    let value = Types.SegmentSortMissing.Last
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SegmentSortMissing> json
    roundTripped |> should equal Types.SegmentSortMissing.Last

[<Fact>]
let ``SegmentSortMissing.First round-trips`` () =
    let value = Types.SegmentSortMissing.First
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SegmentSortMissing> json
    roundTripped |> should equal Types.SegmentSortMissing.First

[<Fact>]
let ``SegmentSortMode.Min round-trips`` () =
    let value = Types.SegmentSortMode.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SegmentSortMode> json
    roundTripped |> should equal Types.SegmentSortMode.Min

[<Fact>]
let ``SegmentSortMode.Max round-trips`` () =
    let value = Types.SegmentSortMode.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SegmentSortMode> json
    roundTripped |> should equal Types.SegmentSortMode.Max

[<Fact>]
let ``SegmentSortOrder.Asc round-trips`` () =
    let value = Types.SegmentSortOrder.Asc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SegmentSortOrder> json
    roundTripped |> should equal Types.SegmentSortOrder.Asc

[<Fact>]
let ``SegmentSortOrder.Desc round-trips`` () =
    let value = Types.SegmentSortOrder.Desc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SegmentSortOrder> json
    roundTripped |> should equal Types.SegmentSortOrder.Desc

[<Fact>]
let ``SourceMode.Disabled round-trips`` () =
    let value = Types.SourceMode.Disabled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SourceMode> json
    roundTripped |> should equal Types.SourceMode.Disabled

[<Fact>]
let ``SourceMode.Stored round-trips`` () =
    let value = Types.SourceMode.Stored
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SourceMode> json
    roundTripped |> should equal Types.SourceMode.Stored

[<Fact>]
let ``SourceMode.Synthetic round-trips`` () =
    let value = Types.SourceMode.Synthetic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SourceMode> json
    roundTripped |> should equal Types.SourceMode.Synthetic

[<Fact>]
let ``StorageType.Fs round-trips`` () =
    let value = Types.StorageType.Fs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StorageType> json
    roundTripped |> should equal Types.StorageType.Fs

[<Fact>]
let ``StorageType.Niofs round-trips`` () =
    let value = Types.StorageType.Niofs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StorageType> json
    roundTripped |> should equal Types.StorageType.Niofs

[<Fact>]
let ``StorageType.Mmapfs round-trips`` () =
    let value = Types.StorageType.Mmapfs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StorageType> json
    roundTripped |> should equal Types.StorageType.Mmapfs

[<Fact>]
let ``StorageType.Hybridfs round-trips`` () =
    let value = Types.StorageType.Hybridfs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StorageType> json
    roundTripped |> should equal Types.StorageType.Hybridfs

[<Fact>]
let ``TranslogDurability.Request round-trips`` () =
    let value = Types.TranslogDurability.Request
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TranslogDurability> json
    roundTripped |> should equal Types.TranslogDurability.Request

[<Fact>]
let ``TranslogDurability.Async round-trips`` () =
    let value = Types.TranslogDurability.Async
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TranslogDurability> json
    roundTripped |> should equal Types.TranslogDurability.Async

[<Fact>]
let ``IndicesGetFeature.Aliases round-trips`` () =
    let value = Types.IndicesGetFeature.Aliases
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesGetFeature> json
    roundTripped |> should equal Types.IndicesGetFeature.Aliases

[<Fact>]
let ``IndicesGetFeature.Mappings round-trips`` () =
    let value = Types.IndicesGetFeature.Mappings
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesGetFeature> json
    roundTripped |> should equal Types.IndicesGetFeature.Mappings

[<Fact>]
let ``IndicesGetFeature.Settings round-trips`` () =
    let value = Types.IndicesGetFeature.Settings
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndicesGetFeature> json
    roundTripped |> should equal Types.IndicesGetFeature.Settings

[<Fact>]
let ``ModeEnum.Upgrade round-trips`` () =
    let value = Types.ModeEnum.Upgrade
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ModeEnum> json
    roundTripped |> should equal Types.ModeEnum.Upgrade

[<Fact>]
let ``RecoveryStage.INIT round-trips`` () =
    let value = Types.RecoveryStage.INIT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryStage> json
    roundTripped |> should equal Types.RecoveryStage.INIT

[<Fact>]
let ``RecoveryStage.INDEX round-trips`` () =
    let value = Types.RecoveryStage.INDEX
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryStage> json
    roundTripped |> should equal Types.RecoveryStage.INDEX

[<Fact>]
let ``RecoveryStage.VERIFYINDEX round-trips`` () =
    let value = Types.RecoveryStage.VERIFYINDEX
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryStage> json
    roundTripped |> should equal Types.RecoveryStage.VERIFYINDEX

[<Fact>]
let ``RecoveryStage.TRANSLOG round-trips`` () =
    let value = Types.RecoveryStage.TRANSLOG
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryStage> json
    roundTripped |> should equal Types.RecoveryStage.TRANSLOG

[<Fact>]
let ``RecoveryStage.FINALIZE round-trips`` () =
    let value = Types.RecoveryStage.FINALIZE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryStage> json
    roundTripped |> should equal Types.RecoveryStage.FINALIZE

[<Fact>]
let ``RecoveryStage.DONE round-trips`` () =
    let value = Types.RecoveryStage.DONE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryStage> json
    roundTripped |> should equal Types.RecoveryStage.DONE

[<Fact>]
let ``RecoveryType.EMPTYSTORE round-trips`` () =
    let value = Types.RecoveryType.EMPTYSTORE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryType> json
    roundTripped |> should equal Types.RecoveryType.EMPTYSTORE

[<Fact>]
let ``RecoveryType.EXISTINGSTORE round-trips`` () =
    let value = Types.RecoveryType.EXISTINGSTORE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryType> json
    roundTripped |> should equal Types.RecoveryType.EXISTINGSTORE

[<Fact>]
let ``RecoveryType.LOCALSHARDS round-trips`` () =
    let value = Types.RecoveryType.LOCALSHARDS
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryType> json
    roundTripped |> should equal Types.RecoveryType.LOCALSHARDS

[<Fact>]
let ``RecoveryType.PEER round-trips`` () =
    let value = Types.RecoveryType.PEER
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryType> json
    roundTripped |> should equal Types.RecoveryType.PEER

[<Fact>]
let ``RecoveryType.SNAPSHOT round-trips`` () =
    let value = Types.RecoveryType.SNAPSHOT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RecoveryType> json
    roundTripped |> should equal Types.RecoveryType.SNAPSHOT

[<Fact>]
let ``ShardStoreAllocation.Primary round-trips`` () =
    let value = Types.ShardStoreAllocation.Primary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreAllocation> json
    roundTripped |> should equal Types.ShardStoreAllocation.Primary

[<Fact>]
let ``ShardStoreAllocation.Replica round-trips`` () =
    let value = Types.ShardStoreAllocation.Replica
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreAllocation> json
    roundTripped |> should equal Types.ShardStoreAllocation.Replica

[<Fact>]
let ``ShardStoreAllocation.Unused round-trips`` () =
    let value = Types.ShardStoreAllocation.Unused
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreAllocation> json
    roundTripped |> should equal Types.ShardStoreAllocation.Unused

[<Fact>]
let ``ShardStoreStatus.Green round-trips`` () =
    let value = Types.ShardStoreStatus.Green
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreStatus> json
    roundTripped |> should equal Types.ShardStoreStatus.Green

[<Fact>]
let ``ShardStoreStatus.Yellow round-trips`` () =
    let value = Types.ShardStoreStatus.Yellow
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreStatus> json
    roundTripped |> should equal Types.ShardStoreStatus.Yellow

[<Fact>]
let ``ShardStoreStatus.Red round-trips`` () =
    let value = Types.ShardStoreStatus.Red
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreStatus> json
    roundTripped |> should equal Types.ShardStoreStatus.Red

[<Fact>]
let ``ShardStoreStatus.All round-trips`` () =
    let value = Types.ShardStoreStatus.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardStoreStatus> json
    roundTripped |> should equal Types.ShardStoreStatus.All

[<Fact>]
let ``IndexMetadataState.Open round-trips`` () =
    let value = Types.IndexMetadataState.Open
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexMetadataState> json
    roundTripped |> should equal Types.IndexMetadataState.Open

[<Fact>]
let ``IndexMetadataState.Close round-trips`` () =
    let value = Types.IndexMetadataState.Close
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexMetadataState> json
    roundTripped |> should equal Types.IndexMetadataState.Close

[<Fact>]
let ``ShardRoutingState.UNASSIGNED round-trips`` () =
    let value = Types.ShardRoutingState.UNASSIGNED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardRoutingState> json
    roundTripped |> should equal Types.ShardRoutingState.UNASSIGNED

[<Fact>]
let ``ShardRoutingState.INITIALIZING round-trips`` () =
    let value = Types.ShardRoutingState.INITIALIZING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardRoutingState> json
    roundTripped |> should equal Types.ShardRoutingState.INITIALIZING

[<Fact>]
let ``ShardRoutingState.STARTED round-trips`` () =
    let value = Types.ShardRoutingState.STARTED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardRoutingState> json
    roundTripped |> should equal Types.ShardRoutingState.STARTED

[<Fact>]
let ``ShardRoutingState.RELOCATING round-trips`` () =
    let value = Types.ShardRoutingState.RELOCATING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardRoutingState> json
    roundTripped |> should equal Types.ShardRoutingState.RELOCATING

[<Fact>]
let ``Ai21ServiceType.Ai21 round-trips`` () =
    let value = Types.Ai21ServiceType.Ai21
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Ai21ServiceType> json
    roundTripped |> should equal Types.Ai21ServiceType.Ai21

[<Fact>]
let ``Ai21TaskType.Completion round-trips`` () =
    let value = Types.Ai21TaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Ai21TaskType> json
    roundTripped |> should equal Types.Ai21TaskType.Completion

[<Fact>]
let ``Ai21TaskType.ChatCompletion round-trips`` () =
    let value = Types.Ai21TaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Ai21TaskType> json
    roundTripped |> should equal Types.Ai21TaskType.ChatCompletion

[<Fact>]
let ``AlibabaCloudServiceType.AlibabacloudAiSearch round-trips`` () =
    let value = Types.AlibabaCloudServiceType.AlibabacloudAiSearch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AlibabaCloudServiceType> json
    roundTripped |> should equal Types.AlibabaCloudServiceType.AlibabacloudAiSearch

[<Fact>]
let ``AlibabaCloudTaskType.Completion round-trips`` () =
    let value = Types.AlibabaCloudTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AlibabaCloudTaskType> json
    roundTripped |> should equal Types.AlibabaCloudTaskType.Completion

[<Fact>]
let ``AlibabaCloudTaskType.Rerank round-trips`` () =
    let value = Types.AlibabaCloudTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AlibabaCloudTaskType> json
    roundTripped |> should equal Types.AlibabaCloudTaskType.Rerank

[<Fact>]
let ``AlibabaCloudTaskType.SparseEmbedding round-trips`` () =
    let value = Types.AlibabaCloudTaskType.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AlibabaCloudTaskType> json
    roundTripped |> should equal Types.AlibabaCloudTaskType.SparseEmbedding

[<Fact>]
let ``AlibabaCloudTaskType.TextEmbedding round-trips`` () =
    let value = Types.AlibabaCloudTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AlibabaCloudTaskType> json
    roundTripped |> should equal Types.AlibabaCloudTaskType.TextEmbedding

[<Fact>]
let ``AmazonBedrockServiceType.Amazonbedrock round-trips`` () =
    let value = Types.AmazonBedrockServiceType.Amazonbedrock
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonBedrockServiceType> json
    roundTripped |> should equal Types.AmazonBedrockServiceType.Amazonbedrock

[<Fact>]
let ``AmazonBedrockTaskType.ChatCompletion round-trips`` () =
    let value = Types.AmazonBedrockTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonBedrockTaskType> json
    roundTripped |> should equal Types.AmazonBedrockTaskType.ChatCompletion

[<Fact>]
let ``AmazonBedrockTaskType.Completion round-trips`` () =
    let value = Types.AmazonBedrockTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonBedrockTaskType> json
    roundTripped |> should equal Types.AmazonBedrockTaskType.Completion

[<Fact>]
let ``AmazonBedrockTaskType.TextEmbedding round-trips`` () =
    let value = Types.AmazonBedrockTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonBedrockTaskType> json
    roundTripped |> should equal Types.AmazonBedrockTaskType.TextEmbedding

[<Fact>]
let ``AmazonSageMakerApi.Openai round-trips`` () =
    let value = Types.AmazonSageMakerApi.Openai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonSageMakerApi> json
    roundTripped |> should equal Types.AmazonSageMakerApi.Openai

[<Fact>]
let ``AmazonSageMakerApi.Elastic round-trips`` () =
    let value = Types.AmazonSageMakerApi.Elastic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonSageMakerApi> json
    roundTripped |> should equal Types.AmazonSageMakerApi.Elastic

[<Fact>]
let ``AmazonSageMakerServiceType.AmazonSagemaker round-trips`` () =
    let value = Types.AmazonSageMakerServiceType.AmazonSagemaker
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AmazonSageMakerServiceType> json
    roundTripped |> should equal Types.AmazonSageMakerServiceType.AmazonSagemaker

[<Fact>]
let ``AnthropicServiceType.Anthropic round-trips`` () =
    let value = Types.AnthropicServiceType.Anthropic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AnthropicServiceType> json
    roundTripped |> should equal Types.AnthropicServiceType.Anthropic

[<Fact>]
let ``AnthropicTaskType.Completion round-trips`` () =
    let value = Types.AnthropicTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AnthropicTaskType> json
    roundTripped |> should equal Types.AnthropicTaskType.Completion

[<Fact>]
let ``AzureAiStudioServiceType.Azureaistudio round-trips`` () =
    let value = Types.AzureAiStudioServiceType.Azureaistudio
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureAiStudioServiceType> json
    roundTripped |> should equal Types.AzureAiStudioServiceType.Azureaistudio

[<Fact>]
let ``AzureAiStudioTaskType.Completion round-trips`` () =
    let value = Types.AzureAiStudioTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureAiStudioTaskType> json
    roundTripped |> should equal Types.AzureAiStudioTaskType.Completion

[<Fact>]
let ``AzureAiStudioTaskType.Rerank round-trips`` () =
    let value = Types.AzureAiStudioTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureAiStudioTaskType> json
    roundTripped |> should equal Types.AzureAiStudioTaskType.Rerank

[<Fact>]
let ``AzureAiStudioTaskType.TextEmbedding round-trips`` () =
    let value = Types.AzureAiStudioTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureAiStudioTaskType> json
    roundTripped |> should equal Types.AzureAiStudioTaskType.TextEmbedding

[<Fact>]
let ``AzureOpenAIServiceType.Azureopenai round-trips`` () =
    let value = Types.AzureOpenAIServiceType.Azureopenai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureOpenAIServiceType> json
    roundTripped |> should equal Types.AzureOpenAIServiceType.Azureopenai

[<Fact>]
let ``AzureOpenAITaskType.Completion round-trips`` () =
    let value = Types.AzureOpenAITaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureOpenAITaskType> json
    roundTripped |> should equal Types.AzureOpenAITaskType.Completion

[<Fact>]
let ``AzureOpenAITaskType.ChatCompletion round-trips`` () =
    let value = Types.AzureOpenAITaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureOpenAITaskType> json
    roundTripped |> should equal Types.AzureOpenAITaskType.ChatCompletion

[<Fact>]
let ``AzureOpenAITaskType.TextEmbedding round-trips`` () =
    let value = Types.AzureOpenAITaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AzureOpenAITaskType> json
    roundTripped |> should equal Types.AzureOpenAITaskType.TextEmbedding

[<Fact>]
let ``CohereEmbeddingType.Binary round-trips`` () =
    let value = Types.CohereEmbeddingType.Binary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereEmbeddingType> json
    roundTripped |> should equal Types.CohereEmbeddingType.Binary

[<Fact>]
let ``CohereEmbeddingType.Bit round-trips`` () =
    let value = Types.CohereEmbeddingType.Bit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereEmbeddingType> json
    roundTripped |> should equal Types.CohereEmbeddingType.Bit

[<Fact>]
let ``CohereEmbeddingType.Byte round-trips`` () =
    let value = Types.CohereEmbeddingType.Byte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereEmbeddingType> json
    roundTripped |> should equal Types.CohereEmbeddingType.Byte

[<Fact>]
let ``CohereEmbeddingType.Float round-trips`` () =
    let value = Types.CohereEmbeddingType.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereEmbeddingType> json
    roundTripped |> should equal Types.CohereEmbeddingType.Float

[<Fact>]
let ``CohereEmbeddingType.Int8 round-trips`` () =
    let value = Types.CohereEmbeddingType.Int8
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereEmbeddingType> json
    roundTripped |> should equal Types.CohereEmbeddingType.Int8

[<Fact>]
let ``CohereInputType.Classification round-trips`` () =
    let value = Types.CohereInputType.Classification
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereInputType> json
    roundTripped |> should equal Types.CohereInputType.Classification

[<Fact>]
let ``CohereInputType.Clustering round-trips`` () =
    let value = Types.CohereInputType.Clustering
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereInputType> json
    roundTripped |> should equal Types.CohereInputType.Clustering

[<Fact>]
let ``CohereInputType.Ingest round-trips`` () =
    let value = Types.CohereInputType.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereInputType> json
    roundTripped |> should equal Types.CohereInputType.Ingest

[<Fact>]
let ``CohereInputType.Search round-trips`` () =
    let value = Types.CohereInputType.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereInputType> json
    roundTripped |> should equal Types.CohereInputType.Search

[<Fact>]
let ``CohereServiceType.Cohere round-trips`` () =
    let value = Types.CohereServiceType.Cohere
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereServiceType> json
    roundTripped |> should equal Types.CohereServiceType.Cohere

[<Fact>]
let ``CohereSimilarityType.Cosine round-trips`` () =
    let value = Types.CohereSimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereSimilarityType> json
    roundTripped |> should equal Types.CohereSimilarityType.Cosine

[<Fact>]
let ``CohereSimilarityType.DotProduct round-trips`` () =
    let value = Types.CohereSimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereSimilarityType> json
    roundTripped |> should equal Types.CohereSimilarityType.DotProduct

[<Fact>]
let ``CohereSimilarityType.L2Norm round-trips`` () =
    let value = Types.CohereSimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereSimilarityType> json
    roundTripped |> should equal Types.CohereSimilarityType.L2Norm

[<Fact>]
let ``CohereTaskType.Completion round-trips`` () =
    let value = Types.CohereTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereTaskType> json
    roundTripped |> should equal Types.CohereTaskType.Completion

[<Fact>]
let ``CohereTaskType.Rerank round-trips`` () =
    let value = Types.CohereTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereTaskType> json
    roundTripped |> should equal Types.CohereTaskType.Rerank

[<Fact>]
let ``CohereTaskType.TextEmbedding round-trips`` () =
    let value = Types.CohereTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereTaskType> json
    roundTripped |> should equal Types.CohereTaskType.TextEmbedding

[<Fact>]
let ``CohereTruncateType.END round-trips`` () =
    let value = Types.CohereTruncateType.END
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereTruncateType> json
    roundTripped |> should equal Types.CohereTruncateType.END

[<Fact>]
let ``CohereTruncateType.NONE round-trips`` () =
    let value = Types.CohereTruncateType.NONE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereTruncateType> json
    roundTripped |> should equal Types.CohereTruncateType.NONE

[<Fact>]
let ``CohereTruncateType.START round-trips`` () =
    let value = Types.CohereTruncateType.START
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CohereTruncateType> json
    roundTripped |> should equal Types.CohereTruncateType.START

[<Fact>]
let ``ContentType.Text round-trips`` () =
    let value = Types.ContentType.Text
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ContentType> json
    roundTripped |> should equal Types.ContentType.Text

[<Fact>]
let ``ContentType.ImageUrl round-trips`` () =
    let value = Types.ContentType.ImageUrl
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ContentType> json
    roundTripped |> should equal Types.ContentType.ImageUrl

[<Fact>]
let ``ContentType.File round-trips`` () =
    let value = Types.ContentType.File
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ContentType> json
    roundTripped |> should equal Types.ContentType.File

[<Fact>]
let ``ContextualAIServiceType.Contextualai round-trips`` () =
    let value = Types.ContextualAIServiceType.Contextualai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ContextualAIServiceType> json
    roundTripped |> should equal Types.ContextualAIServiceType.Contextualai

[<Fact>]
let ``CustomServiceInputType.Classification round-trips`` () =
    let value = Types.CustomServiceInputType.Classification
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomServiceInputType> json
    roundTripped |> should equal Types.CustomServiceInputType.Classification

[<Fact>]
let ``CustomServiceInputType.Clustering round-trips`` () =
    let value = Types.CustomServiceInputType.Clustering
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomServiceInputType> json
    roundTripped |> should equal Types.CustomServiceInputType.Clustering

[<Fact>]
let ``CustomServiceInputType.Ingest round-trips`` () =
    let value = Types.CustomServiceInputType.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomServiceInputType> json
    roundTripped |> should equal Types.CustomServiceInputType.Ingest

[<Fact>]
let ``CustomServiceInputType.Search round-trips`` () =
    let value = Types.CustomServiceInputType.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomServiceInputType> json
    roundTripped |> should equal Types.CustomServiceInputType.Search

[<Fact>]
let ``CustomServiceType.Custom round-trips`` () =
    let value = Types.CustomServiceType.Custom
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomServiceType> json
    roundTripped |> should equal Types.CustomServiceType.Custom

[<Fact>]
let ``CustomTaskType.TextEmbedding round-trips`` () =
    let value = Types.CustomTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomTaskType> json
    roundTripped |> should equal Types.CustomTaskType.TextEmbedding

[<Fact>]
let ``CustomTaskType.SparseEmbedding round-trips`` () =
    let value = Types.CustomTaskType.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomTaskType> json
    roundTripped |> should equal Types.CustomTaskType.SparseEmbedding

[<Fact>]
let ``CustomTaskType.Rerank round-trips`` () =
    let value = Types.CustomTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomTaskType> json
    roundTripped |> should equal Types.CustomTaskType.Rerank

[<Fact>]
let ``CustomTaskType.Completion round-trips`` () =
    let value = Types.CustomTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CustomTaskType> json
    roundTripped |> should equal Types.CustomTaskType.Completion

[<Fact>]
let ``DeepSeekServiceType.Deepseek round-trips`` () =
    let value = Types.DeepSeekServiceType.Deepseek
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeepSeekServiceType> json
    roundTripped |> should equal Types.DeepSeekServiceType.Deepseek

[<Fact>]
let ``ElasticsearchServiceType.Elasticsearch round-trips`` () =
    let value = Types.ElasticsearchServiceType.Elasticsearch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ElasticsearchServiceType> json
    roundTripped |> should equal Types.ElasticsearchServiceType.Elasticsearch

[<Fact>]
let ``ElasticsearchTaskType.Rerank round-trips`` () =
    let value = Types.ElasticsearchTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ElasticsearchTaskType> json
    roundTripped |> should equal Types.ElasticsearchTaskType.Rerank

[<Fact>]
let ``ElasticsearchTaskType.SparseEmbedding round-trips`` () =
    let value = Types.ElasticsearchTaskType.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ElasticsearchTaskType> json
    roundTripped |> should equal Types.ElasticsearchTaskType.SparseEmbedding

[<Fact>]
let ``ElasticsearchTaskType.TextEmbedding round-trips`` () =
    let value = Types.ElasticsearchTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ElasticsearchTaskType> json
    roundTripped |> should equal Types.ElasticsearchTaskType.TextEmbedding

[<Fact>]
let ``ElserServiceType.Elser round-trips`` () =
    let value = Types.ElserServiceType.Elser
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ElserServiceType> json
    roundTripped |> should equal Types.ElserServiceType.Elser

[<Fact>]
let ``ElserTaskType.SparseEmbedding round-trips`` () =
    let value = Types.ElserTaskType.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ElserTaskType> json
    roundTripped |> should equal Types.ElserTaskType.SparseEmbedding

[<Fact>]
let ``EmbeddingContentFormat.Text round-trips`` () =
    let value = Types.EmbeddingContentFormat.Text
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmbeddingContentFormat> json
    roundTripped |> should equal Types.EmbeddingContentFormat.Text

[<Fact>]
let ``EmbeddingContentFormat.Base64 round-trips`` () =
    let value = Types.EmbeddingContentFormat.Base64
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmbeddingContentFormat> json
    roundTripped |> should equal Types.EmbeddingContentFormat.Base64

[<Fact>]
let ``EmbeddingContentType.Text round-trips`` () =
    let value = Types.EmbeddingContentType.Text
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmbeddingContentType> json
    roundTripped |> should equal Types.EmbeddingContentType.Text

[<Fact>]
let ``EmbeddingContentType.Image round-trips`` () =
    let value = Types.EmbeddingContentType.Image
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmbeddingContentType> json
    roundTripped |> should equal Types.EmbeddingContentType.Image

[<Fact>]
let ``FireworksAIServiceType.Fireworksai round-trips`` () =
    let value = Types.FireworksAIServiceType.Fireworksai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAIServiceType> json
    roundTripped |> should equal Types.FireworksAIServiceType.Fireworksai

[<Fact>]
let ``FireworksAISimilarityType.Cosine round-trips`` () =
    let value = Types.FireworksAISimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAISimilarityType> json
    roundTripped |> should equal Types.FireworksAISimilarityType.Cosine

[<Fact>]
let ``FireworksAISimilarityType.DotProduct round-trips`` () =
    let value = Types.FireworksAISimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAISimilarityType> json
    roundTripped |> should equal Types.FireworksAISimilarityType.DotProduct

[<Fact>]
let ``FireworksAISimilarityType.L2Norm round-trips`` () =
    let value = Types.FireworksAISimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAISimilarityType> json
    roundTripped |> should equal Types.FireworksAISimilarityType.L2Norm

[<Fact>]
let ``FireworksAITaskType.ChatCompletion round-trips`` () =
    let value = Types.FireworksAITaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAITaskType> json
    roundTripped |> should equal Types.FireworksAITaskType.ChatCompletion

[<Fact>]
let ``FireworksAITaskType.Completion round-trips`` () =
    let value = Types.FireworksAITaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAITaskType> json
    roundTripped |> should equal Types.FireworksAITaskType.Completion

[<Fact>]
let ``FireworksAITaskType.TextEmbedding round-trips`` () =
    let value = Types.FireworksAITaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FireworksAITaskType> json
    roundTripped |> should equal Types.FireworksAITaskType.TextEmbedding

[<Fact>]
let ``GoogleAiServiceType.Googleaistudio round-trips`` () =
    let value = Types.GoogleAiServiceType.Googleaistudio
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleAiServiceType> json
    roundTripped |> should equal Types.GoogleAiServiceType.Googleaistudio

[<Fact>]
let ``GoogleAiStudioTaskType.Completion round-trips`` () =
    let value = Types.GoogleAiStudioTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleAiStudioTaskType> json
    roundTripped |> should equal Types.GoogleAiStudioTaskType.Completion

[<Fact>]
let ``GoogleAiStudioTaskType.TextEmbedding round-trips`` () =
    let value = Types.GoogleAiStudioTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleAiStudioTaskType> json
    roundTripped |> should equal Types.GoogleAiStudioTaskType.TextEmbedding

[<Fact>]
let ``GoogleModelGardenProvider.Google round-trips`` () =
    let value = Types.GoogleModelGardenProvider.Google
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleModelGardenProvider> json
    roundTripped |> should equal Types.GoogleModelGardenProvider.Google

[<Fact>]
let ``GoogleModelGardenProvider.Anthropic round-trips`` () =
    let value = Types.GoogleModelGardenProvider.Anthropic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleModelGardenProvider> json
    roundTripped |> should equal Types.GoogleModelGardenProvider.Anthropic

[<Fact>]
let ``GoogleModelGardenProvider.Meta round-trips`` () =
    let value = Types.GoogleModelGardenProvider.Meta
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleModelGardenProvider> json
    roundTripped |> should equal Types.GoogleModelGardenProvider.Meta

[<Fact>]
let ``GoogleModelGardenProvider.HuggingFace round-trips`` () =
    let value = Types.GoogleModelGardenProvider.HuggingFace
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleModelGardenProvider> json
    roundTripped |> should equal Types.GoogleModelGardenProvider.HuggingFace

[<Fact>]
let ``GoogleModelGardenProvider.Mistral round-trips`` () =
    let value = Types.GoogleModelGardenProvider.Mistral
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleModelGardenProvider> json
    roundTripped |> should equal Types.GoogleModelGardenProvider.Mistral

[<Fact>]
let ``GoogleModelGardenProvider.Ai21 round-trips`` () =
    let value = Types.GoogleModelGardenProvider.Ai21
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleModelGardenProvider> json
    roundTripped |> should equal Types.GoogleModelGardenProvider.Ai21

[<Fact>]
let ``GoogleVertexAIServiceType.Googlevertexai round-trips`` () =
    let value = Types.GoogleVertexAIServiceType.Googlevertexai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleVertexAIServiceType> json
    roundTripped |> should equal Types.GoogleVertexAIServiceType.Googlevertexai

[<Fact>]
let ``GoogleVertexAITaskType.Rerank round-trips`` () =
    let value = Types.GoogleVertexAITaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleVertexAITaskType> json
    roundTripped |> should equal Types.GoogleVertexAITaskType.Rerank

[<Fact>]
let ``GoogleVertexAITaskType.TextEmbedding round-trips`` () =
    let value = Types.GoogleVertexAITaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleVertexAITaskType> json
    roundTripped |> should equal Types.GoogleVertexAITaskType.TextEmbedding

[<Fact>]
let ``GoogleVertexAITaskType.Completion round-trips`` () =
    let value = Types.GoogleVertexAITaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleVertexAITaskType> json
    roundTripped |> should equal Types.GoogleVertexAITaskType.Completion

[<Fact>]
let ``GoogleVertexAITaskType.ChatCompletion round-trips`` () =
    let value = Types.GoogleVertexAITaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GoogleVertexAITaskType> json
    roundTripped |> should equal Types.GoogleVertexAITaskType.ChatCompletion

[<Fact>]
let ``GroqServiceType.Groq round-trips`` () =
    let value = Types.GroqServiceType.Groq
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GroqServiceType> json
    roundTripped |> should equal Types.GroqServiceType.Groq

[<Fact>]
let ``GroqTaskType.ChatCompletion round-trips`` () =
    let value = Types.GroqTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GroqTaskType> json
    roundTripped |> should equal Types.GroqTaskType.ChatCompletion

[<Fact>]
let ``HuggingFaceServiceType.HuggingFace round-trips`` () =
    let value = Types.HuggingFaceServiceType.HuggingFace
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HuggingFaceServiceType> json
    roundTripped |> should equal Types.HuggingFaceServiceType.HuggingFace

[<Fact>]
let ``HuggingFaceTaskType.ChatCompletion round-trips`` () =
    let value = Types.HuggingFaceTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HuggingFaceTaskType> json
    roundTripped |> should equal Types.HuggingFaceTaskType.ChatCompletion

[<Fact>]
let ``HuggingFaceTaskType.Completion round-trips`` () =
    let value = Types.HuggingFaceTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HuggingFaceTaskType> json
    roundTripped |> should equal Types.HuggingFaceTaskType.Completion

[<Fact>]
let ``HuggingFaceTaskType.Rerank round-trips`` () =
    let value = Types.HuggingFaceTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HuggingFaceTaskType> json
    roundTripped |> should equal Types.HuggingFaceTaskType.Rerank

[<Fact>]
let ``HuggingFaceTaskType.TextEmbedding round-trips`` () =
    let value = Types.HuggingFaceTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HuggingFaceTaskType> json
    roundTripped |> should equal Types.HuggingFaceTaskType.TextEmbedding

[<Fact>]
let ``ImageUrlDetail.Auto round-trips`` () =
    let value = Types.ImageUrlDetail.Auto
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImageUrlDetail> json
    roundTripped |> should equal Types.ImageUrlDetail.Auto

[<Fact>]
let ``ImageUrlDetail.Low round-trips`` () =
    let value = Types.ImageUrlDetail.Low
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImageUrlDetail> json
    roundTripped |> should equal Types.ImageUrlDetail.Low

[<Fact>]
let ``ImageUrlDetail.High round-trips`` () =
    let value = Types.ImageUrlDetail.High
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ImageUrlDetail> json
    roundTripped |> should equal Types.ImageUrlDetail.High

[<Fact>]
let ``JinaAIElementType.Binary round-trips`` () =
    let value = Types.JinaAIElementType.Binary
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAIElementType> json
    roundTripped |> should equal Types.JinaAIElementType.Binary

[<Fact>]
let ``JinaAIElementType.Bit round-trips`` () =
    let value = Types.JinaAIElementType.Bit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAIElementType> json
    roundTripped |> should equal Types.JinaAIElementType.Bit

[<Fact>]
let ``JinaAIElementType.Float round-trips`` () =
    let value = Types.JinaAIElementType.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAIElementType> json
    roundTripped |> should equal Types.JinaAIElementType.Float

[<Fact>]
let ``JinaAIServiceType.Jinaai round-trips`` () =
    let value = Types.JinaAIServiceType.Jinaai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAIServiceType> json
    roundTripped |> should equal Types.JinaAIServiceType.Jinaai

[<Fact>]
let ``JinaAISimilarityType.Cosine round-trips`` () =
    let value = Types.JinaAISimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAISimilarityType> json
    roundTripped |> should equal Types.JinaAISimilarityType.Cosine

[<Fact>]
let ``JinaAISimilarityType.DotProduct round-trips`` () =
    let value = Types.JinaAISimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAISimilarityType> json
    roundTripped |> should equal Types.JinaAISimilarityType.DotProduct

[<Fact>]
let ``JinaAISimilarityType.L2Norm round-trips`` () =
    let value = Types.JinaAISimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAISimilarityType> json
    roundTripped |> should equal Types.JinaAISimilarityType.L2Norm

[<Fact>]
let ``JinaAITaskType.Embedding round-trips`` () =
    let value = Types.JinaAITaskType.Embedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITaskType> json
    roundTripped |> should equal Types.JinaAITaskType.Embedding

[<Fact>]
let ``JinaAITaskType.Rerank round-trips`` () =
    let value = Types.JinaAITaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITaskType> json
    roundTripped |> should equal Types.JinaAITaskType.Rerank

[<Fact>]
let ``JinaAITaskType.TextEmbedding round-trips`` () =
    let value = Types.JinaAITaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITaskType> json
    roundTripped |> should equal Types.JinaAITaskType.TextEmbedding

[<Fact>]
let ``JinaAITextEmbeddingTask.Classification round-trips`` () =
    let value = Types.JinaAITextEmbeddingTask.Classification
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITextEmbeddingTask> json
    roundTripped |> should equal Types.JinaAITextEmbeddingTask.Classification

[<Fact>]
let ``JinaAITextEmbeddingTask.Clustering round-trips`` () =
    let value = Types.JinaAITextEmbeddingTask.Clustering
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITextEmbeddingTask> json
    roundTripped |> should equal Types.JinaAITextEmbeddingTask.Clustering

[<Fact>]
let ``JinaAITextEmbeddingTask.Ingest round-trips`` () =
    let value = Types.JinaAITextEmbeddingTask.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITextEmbeddingTask> json
    roundTripped |> should equal Types.JinaAITextEmbeddingTask.Ingest

[<Fact>]
let ``JinaAITextEmbeddingTask.Search round-trips`` () =
    let value = Types.JinaAITextEmbeddingTask.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JinaAITextEmbeddingTask> json
    roundTripped |> should equal Types.JinaAITextEmbeddingTask.Search

[<Fact>]
let ``LlamaServiceType.Llama round-trips`` () =
    let value = Types.LlamaServiceType.Llama
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaServiceType> json
    roundTripped |> should equal Types.LlamaServiceType.Llama

[<Fact>]
let ``LlamaSimilarityType.Cosine round-trips`` () =
    let value = Types.LlamaSimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaSimilarityType> json
    roundTripped |> should equal Types.LlamaSimilarityType.Cosine

[<Fact>]
let ``LlamaSimilarityType.DotProduct round-trips`` () =
    let value = Types.LlamaSimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaSimilarityType> json
    roundTripped |> should equal Types.LlamaSimilarityType.DotProduct

[<Fact>]
let ``LlamaSimilarityType.L2Norm round-trips`` () =
    let value = Types.LlamaSimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaSimilarityType> json
    roundTripped |> should equal Types.LlamaSimilarityType.L2Norm

[<Fact>]
let ``LlamaTaskType.TextEmbedding round-trips`` () =
    let value = Types.LlamaTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaTaskType> json
    roundTripped |> should equal Types.LlamaTaskType.TextEmbedding

[<Fact>]
let ``LlamaTaskType.Completion round-trips`` () =
    let value = Types.LlamaTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaTaskType> json
    roundTripped |> should equal Types.LlamaTaskType.Completion

[<Fact>]
let ``LlamaTaskType.ChatCompletion round-trips`` () =
    let value = Types.LlamaTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LlamaTaskType> json
    roundTripped |> should equal Types.LlamaTaskType.ChatCompletion

[<Fact>]
let ``MistralServiceType.Mistral round-trips`` () =
    let value = Types.MistralServiceType.Mistral
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MistralServiceType> json
    roundTripped |> should equal Types.MistralServiceType.Mistral

[<Fact>]
let ``MistralTaskType.TextEmbedding round-trips`` () =
    let value = Types.MistralTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MistralTaskType> json
    roundTripped |> should equal Types.MistralTaskType.TextEmbedding

[<Fact>]
let ``MistralTaskType.Completion round-trips`` () =
    let value = Types.MistralTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MistralTaskType> json
    roundTripped |> should equal Types.MistralTaskType.Completion

[<Fact>]
let ``MistralTaskType.ChatCompletion round-trips`` () =
    let value = Types.MistralTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MistralTaskType> json
    roundTripped |> should equal Types.MistralTaskType.ChatCompletion

[<Fact>]
let ``NvidiaInputType.Ingest round-trips`` () =
    let value = Types.NvidiaInputType.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaInputType> json
    roundTripped |> should equal Types.NvidiaInputType.Ingest

[<Fact>]
let ``NvidiaInputType.Search round-trips`` () =
    let value = Types.NvidiaInputType.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaInputType> json
    roundTripped |> should equal Types.NvidiaInputType.Search

[<Fact>]
let ``NvidiaServiceType.Nvidia round-trips`` () =
    let value = Types.NvidiaServiceType.Nvidia
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaServiceType> json
    roundTripped |> should equal Types.NvidiaServiceType.Nvidia

[<Fact>]
let ``NvidiaSimilarityType.Cosine round-trips`` () =
    let value = Types.NvidiaSimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaSimilarityType> json
    roundTripped |> should equal Types.NvidiaSimilarityType.Cosine

[<Fact>]
let ``NvidiaSimilarityType.DotProduct round-trips`` () =
    let value = Types.NvidiaSimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaSimilarityType> json
    roundTripped |> should equal Types.NvidiaSimilarityType.DotProduct

[<Fact>]
let ``NvidiaSimilarityType.L2Norm round-trips`` () =
    let value = Types.NvidiaSimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaSimilarityType> json
    roundTripped |> should equal Types.NvidiaSimilarityType.L2Norm

[<Fact>]
let ``NvidiaTaskType.ChatCompletion round-trips`` () =
    let value = Types.NvidiaTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaTaskType> json
    roundTripped |> should equal Types.NvidiaTaskType.ChatCompletion

[<Fact>]
let ``NvidiaTaskType.Completion round-trips`` () =
    let value = Types.NvidiaTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaTaskType> json
    roundTripped |> should equal Types.NvidiaTaskType.Completion

[<Fact>]
let ``NvidiaTaskType.Rerank round-trips`` () =
    let value = Types.NvidiaTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaTaskType> json
    roundTripped |> should equal Types.NvidiaTaskType.Rerank

[<Fact>]
let ``NvidiaTaskType.TextEmbedding round-trips`` () =
    let value = Types.NvidiaTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NvidiaTaskType> json
    roundTripped |> should equal Types.NvidiaTaskType.TextEmbedding

[<Fact>]
let ``OpenAIServiceType.Openai round-trips`` () =
    let value = Types.OpenAIServiceType.Openai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAIServiceType> json
    roundTripped |> should equal Types.OpenAIServiceType.Openai

[<Fact>]
let ``OpenAISimilarityType.Cosine round-trips`` () =
    let value = Types.OpenAISimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAISimilarityType> json
    roundTripped |> should equal Types.OpenAISimilarityType.Cosine

[<Fact>]
let ``OpenAISimilarityType.DotProduct round-trips`` () =
    let value = Types.OpenAISimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAISimilarityType> json
    roundTripped |> should equal Types.OpenAISimilarityType.DotProduct

[<Fact>]
let ``OpenAISimilarityType.L2Norm round-trips`` () =
    let value = Types.OpenAISimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAISimilarityType> json
    roundTripped |> should equal Types.OpenAISimilarityType.L2Norm

[<Fact>]
let ``OpenAITaskType.ChatCompletion round-trips`` () =
    let value = Types.OpenAITaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAITaskType> json
    roundTripped |> should equal Types.OpenAITaskType.ChatCompletion

[<Fact>]
let ``OpenAITaskType.Completion round-trips`` () =
    let value = Types.OpenAITaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAITaskType> json
    roundTripped |> should equal Types.OpenAITaskType.Completion

[<Fact>]
let ``OpenAITaskType.TextEmbedding round-trips`` () =
    let value = Types.OpenAITaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenAITaskType> json
    roundTripped |> should equal Types.OpenAITaskType.TextEmbedding

[<Fact>]
let ``OpenShiftAiServiceType.OpenshiftAi round-trips`` () =
    let value = Types.OpenShiftAiServiceType.OpenshiftAi
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiServiceType> json
    roundTripped |> should equal Types.OpenShiftAiServiceType.OpenshiftAi

[<Fact>]
let ``OpenShiftAiSimilarityType.Cosine round-trips`` () =
    let value = Types.OpenShiftAiSimilarityType.Cosine
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiSimilarityType> json
    roundTripped |> should equal Types.OpenShiftAiSimilarityType.Cosine

[<Fact>]
let ``OpenShiftAiSimilarityType.DotProduct round-trips`` () =
    let value = Types.OpenShiftAiSimilarityType.DotProduct
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiSimilarityType> json
    roundTripped |> should equal Types.OpenShiftAiSimilarityType.DotProduct

[<Fact>]
let ``OpenShiftAiSimilarityType.L2Norm round-trips`` () =
    let value = Types.OpenShiftAiSimilarityType.L2Norm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiSimilarityType> json
    roundTripped |> should equal Types.OpenShiftAiSimilarityType.L2Norm

[<Fact>]
let ``OpenShiftAiTaskType.TextEmbedding round-trips`` () =
    let value = Types.OpenShiftAiTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiTaskType> json
    roundTripped |> should equal Types.OpenShiftAiTaskType.TextEmbedding

[<Fact>]
let ``OpenShiftAiTaskType.Completion round-trips`` () =
    let value = Types.OpenShiftAiTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiTaskType> json
    roundTripped |> should equal Types.OpenShiftAiTaskType.Completion

[<Fact>]
let ``OpenShiftAiTaskType.ChatCompletion round-trips`` () =
    let value = Types.OpenShiftAiTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiTaskType> json
    roundTripped |> should equal Types.OpenShiftAiTaskType.ChatCompletion

[<Fact>]
let ``OpenShiftAiTaskType.Rerank round-trips`` () =
    let value = Types.OpenShiftAiTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.OpenShiftAiTaskType> json
    roundTripped |> should equal Types.OpenShiftAiTaskType.Rerank

[<Fact>]
let ``ReasoningEffort.Xhigh round-trips`` () =
    let value = Types.ReasoningEffort.Xhigh
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningEffort> json
    roundTripped |> should equal Types.ReasoningEffort.Xhigh

[<Fact>]
let ``ReasoningEffort.High round-trips`` () =
    let value = Types.ReasoningEffort.High
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningEffort> json
    roundTripped |> should equal Types.ReasoningEffort.High

[<Fact>]
let ``ReasoningEffort.Medium round-trips`` () =
    let value = Types.ReasoningEffort.Medium
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningEffort> json
    roundTripped |> should equal Types.ReasoningEffort.Medium

[<Fact>]
let ``ReasoningEffort.Low round-trips`` () =
    let value = Types.ReasoningEffort.Low
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningEffort> json
    roundTripped |> should equal Types.ReasoningEffort.Low

[<Fact>]
let ``ReasoningEffort.Minimal round-trips`` () =
    let value = Types.ReasoningEffort.Minimal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningEffort> json
    roundTripped |> should equal Types.ReasoningEffort.Minimal

[<Fact>]
let ``ReasoningEffort.None round-trips`` () =
    let value = Types.ReasoningEffort.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningEffort> json
    roundTripped |> should equal Types.ReasoningEffort.None

[<Fact>]
let ``ReasoningSummary.Auto round-trips`` () =
    let value = Types.ReasoningSummary.Auto
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningSummary> json
    roundTripped |> should equal Types.ReasoningSummary.Auto

[<Fact>]
let ``ReasoningSummary.Concise round-trips`` () =
    let value = Types.ReasoningSummary.Concise
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningSummary> json
    roundTripped |> should equal Types.ReasoningSummary.Concise

[<Fact>]
let ``ReasoningSummary.Detailed round-trips`` () =
    let value = Types.ReasoningSummary.Detailed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ReasoningSummary> json
    roundTripped |> should equal Types.ReasoningSummary.Detailed

[<Fact>]
let ``TaskType.SparseEmbedding round-trips`` () =
    let value = Types.TaskType.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskType> json
    roundTripped |> should equal Types.TaskType.SparseEmbedding

[<Fact>]
let ``TaskType.TextEmbedding round-trips`` () =
    let value = Types.TaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskType> json
    roundTripped |> should equal Types.TaskType.TextEmbedding

[<Fact>]
let ``TaskType.Rerank round-trips`` () =
    let value = Types.TaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskType> json
    roundTripped |> should equal Types.TaskType.Rerank

[<Fact>]
let ``TaskType.Completion round-trips`` () =
    let value = Types.TaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskType> json
    roundTripped |> should equal Types.TaskType.Completion

[<Fact>]
let ``TaskType.ChatCompletion round-trips`` () =
    let value = Types.TaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskType> json
    roundTripped |> should equal Types.TaskType.ChatCompletion

[<Fact>]
let ``TaskType.Embedding round-trips`` () =
    let value = Types.TaskType.Embedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskType> json
    roundTripped |> should equal Types.TaskType.Embedding

[<Fact>]
let ``TaskTypeAi21.Completion round-trips`` () =
    let value = Types.TaskTypeAi21.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAi21> json
    roundTripped |> should equal Types.TaskTypeAi21.Completion

[<Fact>]
let ``TaskTypeAi21.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeAi21.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAi21> json
    roundTripped |> should equal Types.TaskTypeAi21.ChatCompletion

[<Fact>]
let ``TaskTypeAlibabaCloudAI.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeAlibabaCloudAI.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAlibabaCloudAI> json
    roundTripped |> should equal Types.TaskTypeAlibabaCloudAI.TextEmbedding

[<Fact>]
let ``TaskTypeAlibabaCloudAI.Rerank round-trips`` () =
    let value = Types.TaskTypeAlibabaCloudAI.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAlibabaCloudAI> json
    roundTripped |> should equal Types.TaskTypeAlibabaCloudAI.Rerank

[<Fact>]
let ``TaskTypeAlibabaCloudAI.Completion round-trips`` () =
    let value = Types.TaskTypeAlibabaCloudAI.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAlibabaCloudAI> json
    roundTripped |> should equal Types.TaskTypeAlibabaCloudAI.Completion

[<Fact>]
let ``TaskTypeAlibabaCloudAI.SparseEmbedding round-trips`` () =
    let value = Types.TaskTypeAlibabaCloudAI.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAlibabaCloudAI> json
    roundTripped |> should equal Types.TaskTypeAlibabaCloudAI.SparseEmbedding

[<Fact>]
let ``TaskTypeAmazonBedrock.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeAmazonBedrock.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonBedrock> json
    roundTripped |> should equal Types.TaskTypeAmazonBedrock.ChatCompletion

[<Fact>]
let ``TaskTypeAmazonBedrock.Completion round-trips`` () =
    let value = Types.TaskTypeAmazonBedrock.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonBedrock> json
    roundTripped |> should equal Types.TaskTypeAmazonBedrock.Completion

[<Fact>]
let ``TaskTypeAmazonBedrock.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeAmazonBedrock.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonBedrock> json
    roundTripped |> should equal Types.TaskTypeAmazonBedrock.TextEmbedding

[<Fact>]
let ``TaskTypeAmazonSageMaker.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeAmazonSageMaker.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonSageMaker> json
    roundTripped |> should equal Types.TaskTypeAmazonSageMaker.TextEmbedding

[<Fact>]
let ``TaskTypeAmazonSageMaker.Completion round-trips`` () =
    let value = Types.TaskTypeAmazonSageMaker.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonSageMaker> json
    roundTripped |> should equal Types.TaskTypeAmazonSageMaker.Completion

[<Fact>]
let ``TaskTypeAmazonSageMaker.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeAmazonSageMaker.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonSageMaker> json
    roundTripped |> should equal Types.TaskTypeAmazonSageMaker.ChatCompletion

[<Fact>]
let ``TaskTypeAmazonSageMaker.SparseEmbedding round-trips`` () =
    let value = Types.TaskTypeAmazonSageMaker.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonSageMaker> json
    roundTripped |> should equal Types.TaskTypeAmazonSageMaker.SparseEmbedding

[<Fact>]
let ``TaskTypeAmazonSageMaker.Rerank round-trips`` () =
    let value = Types.TaskTypeAmazonSageMaker.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAmazonSageMaker> json
    roundTripped |> should equal Types.TaskTypeAmazonSageMaker.Rerank

[<Fact>]
let ``TaskTypeAnthropic.Completion round-trips`` () =
    let value = Types.TaskTypeAnthropic.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAnthropic> json
    roundTripped |> should equal Types.TaskTypeAnthropic.Completion

[<Fact>]
let ``TaskTypeAzureAIStudio.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeAzureAIStudio.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAzureAIStudio> json
    roundTripped |> should equal Types.TaskTypeAzureAIStudio.TextEmbedding

[<Fact>]
let ``TaskTypeAzureAIStudio.Completion round-trips`` () =
    let value = Types.TaskTypeAzureAIStudio.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAzureAIStudio> json
    roundTripped |> should equal Types.TaskTypeAzureAIStudio.Completion

[<Fact>]
let ``TaskTypeAzureAIStudio.Rerank round-trips`` () =
    let value = Types.TaskTypeAzureAIStudio.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAzureAIStudio> json
    roundTripped |> should equal Types.TaskTypeAzureAIStudio.Rerank

[<Fact>]
let ``TaskTypeAzureOpenAI.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeAzureOpenAI.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAzureOpenAI> json
    roundTripped |> should equal Types.TaskTypeAzureOpenAI.TextEmbedding

[<Fact>]
let ``TaskTypeAzureOpenAI.Completion round-trips`` () =
    let value = Types.TaskTypeAzureOpenAI.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAzureOpenAI> json
    roundTripped |> should equal Types.TaskTypeAzureOpenAI.Completion

[<Fact>]
let ``TaskTypeAzureOpenAI.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeAzureOpenAI.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeAzureOpenAI> json
    roundTripped |> should equal Types.TaskTypeAzureOpenAI.ChatCompletion

[<Fact>]
let ``TaskTypeCohere.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeCohere.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCohere> json
    roundTripped |> should equal Types.TaskTypeCohere.TextEmbedding

[<Fact>]
let ``TaskTypeCohere.Rerank round-trips`` () =
    let value = Types.TaskTypeCohere.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCohere> json
    roundTripped |> should equal Types.TaskTypeCohere.Rerank

[<Fact>]
let ``TaskTypeCohere.Completion round-trips`` () =
    let value = Types.TaskTypeCohere.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCohere> json
    roundTripped |> should equal Types.TaskTypeCohere.Completion

[<Fact>]
let ``TaskTypeContextualAI.Rerank round-trips`` () =
    let value = Types.TaskTypeContextualAI.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeContextualAI> json
    roundTripped |> should equal Types.TaskTypeContextualAI.Rerank

[<Fact>]
let ``TaskTypeCustom.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeCustom.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCustom> json
    roundTripped |> should equal Types.TaskTypeCustom.TextEmbedding

[<Fact>]
let ``TaskTypeCustom.SparseEmbedding round-trips`` () =
    let value = Types.TaskTypeCustom.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCustom> json
    roundTripped |> should equal Types.TaskTypeCustom.SparseEmbedding

[<Fact>]
let ``TaskTypeCustom.Rerank round-trips`` () =
    let value = Types.TaskTypeCustom.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCustom> json
    roundTripped |> should equal Types.TaskTypeCustom.Rerank

[<Fact>]
let ``TaskTypeCustom.Completion round-trips`` () =
    let value = Types.TaskTypeCustom.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeCustom> json
    roundTripped |> should equal Types.TaskTypeCustom.Completion

[<Fact>]
let ``TaskTypeDeepSeek.Completion round-trips`` () =
    let value = Types.TaskTypeDeepSeek.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeDeepSeek> json
    roundTripped |> should equal Types.TaskTypeDeepSeek.Completion

[<Fact>]
let ``TaskTypeDeepSeek.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeDeepSeek.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeDeepSeek> json
    roundTripped |> should equal Types.TaskTypeDeepSeek.ChatCompletion

[<Fact>]
let ``TaskTypeELSER.SparseEmbedding round-trips`` () =
    let value = Types.TaskTypeELSER.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeELSER> json
    roundTripped |> should equal Types.TaskTypeELSER.SparseEmbedding

[<Fact>]
let ``TaskTypeElasticsearch.SparseEmbedding round-trips`` () =
    let value = Types.TaskTypeElasticsearch.SparseEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeElasticsearch> json
    roundTripped |> should equal Types.TaskTypeElasticsearch.SparseEmbedding

[<Fact>]
let ``TaskTypeElasticsearch.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeElasticsearch.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeElasticsearch> json
    roundTripped |> should equal Types.TaskTypeElasticsearch.TextEmbedding

[<Fact>]
let ``TaskTypeElasticsearch.Rerank round-trips`` () =
    let value = Types.TaskTypeElasticsearch.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeElasticsearch> json
    roundTripped |> should equal Types.TaskTypeElasticsearch.Rerank

[<Fact>]
let ``TaskTypeFireworksAI.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeFireworksAI.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeFireworksAI> json
    roundTripped |> should equal Types.TaskTypeFireworksAI.ChatCompletion

[<Fact>]
let ``TaskTypeFireworksAI.Completion round-trips`` () =
    let value = Types.TaskTypeFireworksAI.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeFireworksAI> json
    roundTripped |> should equal Types.TaskTypeFireworksAI.Completion

[<Fact>]
let ``TaskTypeFireworksAI.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeFireworksAI.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeFireworksAI> json
    roundTripped |> should equal Types.TaskTypeFireworksAI.TextEmbedding

[<Fact>]
let ``TaskTypeGoogleAIStudio.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeGoogleAIStudio.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGoogleAIStudio> json
    roundTripped |> should equal Types.TaskTypeGoogleAIStudio.TextEmbedding

[<Fact>]
let ``TaskTypeGoogleAIStudio.Completion round-trips`` () =
    let value = Types.TaskTypeGoogleAIStudio.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGoogleAIStudio> json
    roundTripped |> should equal Types.TaskTypeGoogleAIStudio.Completion

[<Fact>]
let ``TaskTypeGoogleVertexAI.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeGoogleVertexAI.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGoogleVertexAI> json
    roundTripped |> should equal Types.TaskTypeGoogleVertexAI.ChatCompletion

[<Fact>]
let ``TaskTypeGoogleVertexAI.Completion round-trips`` () =
    let value = Types.TaskTypeGoogleVertexAI.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGoogleVertexAI> json
    roundTripped |> should equal Types.TaskTypeGoogleVertexAI.Completion

[<Fact>]
let ``TaskTypeGoogleVertexAI.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeGoogleVertexAI.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGoogleVertexAI> json
    roundTripped |> should equal Types.TaskTypeGoogleVertexAI.TextEmbedding

[<Fact>]
let ``TaskTypeGoogleVertexAI.Rerank round-trips`` () =
    let value = Types.TaskTypeGoogleVertexAI.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGoogleVertexAI> json
    roundTripped |> should equal Types.TaskTypeGoogleVertexAI.Rerank

[<Fact>]
let ``TaskTypeGroq.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeGroq.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeGroq> json
    roundTripped |> should equal Types.TaskTypeGroq.ChatCompletion

[<Fact>]
let ``TaskTypeHuggingFace.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeHuggingFace.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeHuggingFace> json
    roundTripped |> should equal Types.TaskTypeHuggingFace.ChatCompletion

[<Fact>]
let ``TaskTypeHuggingFace.Completion round-trips`` () =
    let value = Types.TaskTypeHuggingFace.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeHuggingFace> json
    roundTripped |> should equal Types.TaskTypeHuggingFace.Completion

[<Fact>]
let ``TaskTypeHuggingFace.Rerank round-trips`` () =
    let value = Types.TaskTypeHuggingFace.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeHuggingFace> json
    roundTripped |> should equal Types.TaskTypeHuggingFace.Rerank

[<Fact>]
let ``TaskTypeHuggingFace.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeHuggingFace.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeHuggingFace> json
    roundTripped |> should equal Types.TaskTypeHuggingFace.TextEmbedding

[<Fact>]
let ``TaskTypeJinaAi.Embedding round-trips`` () =
    let value = Types.TaskTypeJinaAi.Embedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeJinaAi> json
    roundTripped |> should equal Types.TaskTypeJinaAi.Embedding

[<Fact>]
let ``TaskTypeJinaAi.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeJinaAi.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeJinaAi> json
    roundTripped |> should equal Types.TaskTypeJinaAi.TextEmbedding

[<Fact>]
let ``TaskTypeJinaAi.Rerank round-trips`` () =
    let value = Types.TaskTypeJinaAi.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeJinaAi> json
    roundTripped |> should equal Types.TaskTypeJinaAi.Rerank

[<Fact>]
let ``TaskTypeLlama.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeLlama.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeLlama> json
    roundTripped |> should equal Types.TaskTypeLlama.TextEmbedding

[<Fact>]
let ``TaskTypeLlama.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeLlama.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeLlama> json
    roundTripped |> should equal Types.TaskTypeLlama.ChatCompletion

[<Fact>]
let ``TaskTypeLlama.Completion round-trips`` () =
    let value = Types.TaskTypeLlama.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeLlama> json
    roundTripped |> should equal Types.TaskTypeLlama.Completion

[<Fact>]
let ``TaskTypeMistral.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeMistral.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeMistral> json
    roundTripped |> should equal Types.TaskTypeMistral.TextEmbedding

[<Fact>]
let ``TaskTypeMistral.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeMistral.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeMistral> json
    roundTripped |> should equal Types.TaskTypeMistral.ChatCompletion

[<Fact>]
let ``TaskTypeMistral.Completion round-trips`` () =
    let value = Types.TaskTypeMistral.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeMistral> json
    roundTripped |> should equal Types.TaskTypeMistral.Completion

[<Fact>]
let ``TaskTypeNvidia.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeNvidia.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeNvidia> json
    roundTripped |> should equal Types.TaskTypeNvidia.ChatCompletion

[<Fact>]
let ``TaskTypeNvidia.Completion round-trips`` () =
    let value = Types.TaskTypeNvidia.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeNvidia> json
    roundTripped |> should equal Types.TaskTypeNvidia.Completion

[<Fact>]
let ``TaskTypeNvidia.Rerank round-trips`` () =
    let value = Types.TaskTypeNvidia.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeNvidia> json
    roundTripped |> should equal Types.TaskTypeNvidia.Rerank

[<Fact>]
let ``TaskTypeNvidia.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeNvidia.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeNvidia> json
    roundTripped |> should equal Types.TaskTypeNvidia.TextEmbedding

[<Fact>]
let ``TaskTypeOpenAI.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeOpenAI.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenAI> json
    roundTripped |> should equal Types.TaskTypeOpenAI.TextEmbedding

[<Fact>]
let ``TaskTypeOpenAI.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeOpenAI.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenAI> json
    roundTripped |> should equal Types.TaskTypeOpenAI.ChatCompletion

[<Fact>]
let ``TaskTypeOpenAI.Completion round-trips`` () =
    let value = Types.TaskTypeOpenAI.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenAI> json
    roundTripped |> should equal Types.TaskTypeOpenAI.Completion

[<Fact>]
let ``TaskTypeOpenShiftAi.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeOpenShiftAi.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenShiftAi> json
    roundTripped |> should equal Types.TaskTypeOpenShiftAi.TextEmbedding

[<Fact>]
let ``TaskTypeOpenShiftAi.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeOpenShiftAi.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenShiftAi> json
    roundTripped |> should equal Types.TaskTypeOpenShiftAi.ChatCompletion

[<Fact>]
let ``TaskTypeOpenShiftAi.Completion round-trips`` () =
    let value = Types.TaskTypeOpenShiftAi.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenShiftAi> json
    roundTripped |> should equal Types.TaskTypeOpenShiftAi.Completion

[<Fact>]
let ``TaskTypeOpenShiftAi.Rerank round-trips`` () =
    let value = Types.TaskTypeOpenShiftAi.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeOpenShiftAi> json
    roundTripped |> should equal Types.TaskTypeOpenShiftAi.Rerank

[<Fact>]
let ``TaskTypeVoyageAI.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeVoyageAI.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeVoyageAI> json
    roundTripped |> should equal Types.TaskTypeVoyageAI.TextEmbedding

[<Fact>]
let ``TaskTypeVoyageAI.Rerank round-trips`` () =
    let value = Types.TaskTypeVoyageAI.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeVoyageAI> json
    roundTripped |> should equal Types.TaskTypeVoyageAI.Rerank

[<Fact>]
let ``TaskTypeWatsonx.TextEmbedding round-trips`` () =
    let value = Types.TaskTypeWatsonx.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeWatsonx> json
    roundTripped |> should equal Types.TaskTypeWatsonx.TextEmbedding

[<Fact>]
let ``TaskTypeWatsonx.ChatCompletion round-trips`` () =
    let value = Types.TaskTypeWatsonx.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeWatsonx> json
    roundTripped |> should equal Types.TaskTypeWatsonx.ChatCompletion

[<Fact>]
let ``TaskTypeWatsonx.Completion round-trips`` () =
    let value = Types.TaskTypeWatsonx.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TaskTypeWatsonx> json
    roundTripped |> should equal Types.TaskTypeWatsonx.Completion

[<Fact>]
let ``VoyageAIServiceType.Voyageai round-trips`` () =
    let value = Types.VoyageAIServiceType.Voyageai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.VoyageAIServiceType> json
    roundTripped |> should equal Types.VoyageAIServiceType.Voyageai

[<Fact>]
let ``VoyageAITaskType.TextEmbedding round-trips`` () =
    let value = Types.VoyageAITaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.VoyageAITaskType> json
    roundTripped |> should equal Types.VoyageAITaskType.TextEmbedding

[<Fact>]
let ``VoyageAITaskType.Rerank round-trips`` () =
    let value = Types.VoyageAITaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.VoyageAITaskType> json
    roundTripped |> should equal Types.VoyageAITaskType.Rerank

[<Fact>]
let ``WatsonxServiceType.Watsonxai round-trips`` () =
    let value = Types.WatsonxServiceType.Watsonxai
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatsonxServiceType> json
    roundTripped |> should equal Types.WatsonxServiceType.Watsonxai

[<Fact>]
let ``WatsonxTaskType.TextEmbedding round-trips`` () =
    let value = Types.WatsonxTaskType.TextEmbedding
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatsonxTaskType> json
    roundTripped |> should equal Types.WatsonxTaskType.TextEmbedding

[<Fact>]
let ``WatsonxTaskType.Rerank round-trips`` () =
    let value = Types.WatsonxTaskType.Rerank
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatsonxTaskType> json
    roundTripped |> should equal Types.WatsonxTaskType.Rerank

[<Fact>]
let ``WatsonxTaskType.ChatCompletion round-trips`` () =
    let value = Types.WatsonxTaskType.ChatCompletion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatsonxTaskType> json
    roundTripped |> should equal Types.WatsonxTaskType.ChatCompletion

[<Fact>]
let ``WatsonxTaskType.Completion round-trips`` () =
    let value = Types.WatsonxTaskType.Completion
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatsonxTaskType> json
    roundTripped |> should equal Types.WatsonxTaskType.Completion

[<Fact>]
let ``ConvertType.Integer round-trips`` () =
    let value = Types.ConvertType.Integer
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Integer

[<Fact>]
let ``ConvertType.Long round-trips`` () =
    let value = Types.ConvertType.Long
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Long

[<Fact>]
let ``ConvertType.Double round-trips`` () =
    let value = Types.ConvertType.Double
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Double

[<Fact>]
let ``ConvertType.Float round-trips`` () =
    let value = Types.ConvertType.Float
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Float

[<Fact>]
let ``ConvertType.Boolean round-trips`` () =
    let value = Types.ConvertType.Boolean
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Boolean

[<Fact>]
let ``ConvertType.Ip round-trips`` () =
    let value = Types.ConvertType.Ip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Ip

[<Fact>]
let ``ConvertType.String round-trips`` () =
    let value = Types.ConvertType.String
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.String

[<Fact>]
let ``ConvertType.Auto round-trips`` () =
    let value = Types.ConvertType.Auto
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConvertType> json
    roundTripped |> should equal Types.ConvertType.Auto

[<Fact>]
let ``FieldAccessPattern.Classic round-trips`` () =
    let value = Types.FieldAccessPattern.Classic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldAccessPattern> json
    roundTripped |> should equal Types.FieldAccessPattern.Classic

[<Fact>]
let ``FieldAccessPattern.Flexible round-trips`` () =
    let value = Types.FieldAccessPattern.Flexible
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FieldAccessPattern> json
    roundTripped |> should equal Types.FieldAccessPattern.Flexible

[<Fact>]
let ``FingerprintDigest.MD5 round-trips`` () =
    let value = Types.FingerprintDigest.MD5
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FingerprintDigest> json
    roundTripped |> should equal Types.FingerprintDigest.MD5

[<Fact>]
let ``FingerprintDigest.SHA1 round-trips`` () =
    let value = Types.FingerprintDigest.SHA1
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FingerprintDigest> json
    roundTripped |> should equal Types.FingerprintDigest.SHA1

[<Fact>]
let ``FingerprintDigest.SHA256 round-trips`` () =
    let value = Types.FingerprintDigest.SHA256
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FingerprintDigest> json
    roundTripped |> should equal Types.FingerprintDigest.SHA256

[<Fact>]
let ``FingerprintDigest.SHA512 round-trips`` () =
    let value = Types.FingerprintDigest.SHA512
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FingerprintDigest> json
    roundTripped |> should equal Types.FingerprintDigest.SHA512

[<Fact>]
let ``FingerprintDigest.MurmurHash3 round-trips`` () =
    let value = Types.FingerprintDigest.MurmurHash3
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FingerprintDigest> json
    roundTripped |> should equal Types.FingerprintDigest.MurmurHash3

[<Fact>]
let ``GeoGridTargetFormat.Geojson round-trips`` () =
    let value = Types.GeoGridTargetFormat.Geojson
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoGridTargetFormat> json
    roundTripped |> should equal Types.GeoGridTargetFormat.Geojson

[<Fact>]
let ``GeoGridTargetFormat.Wkt round-trips`` () =
    let value = Types.GeoGridTargetFormat.Wkt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoGridTargetFormat> json
    roundTripped |> should equal Types.GeoGridTargetFormat.Wkt

[<Fact>]
let ``GeoGridTileType.Geotile round-trips`` () =
    let value = Types.GeoGridTileType.Geotile
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoGridTileType> json
    roundTripped |> should equal Types.GeoGridTileType.Geotile

[<Fact>]
let ``GeoGridTileType.Geohex round-trips`` () =
    let value = Types.GeoGridTileType.Geohex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoGridTileType> json
    roundTripped |> should equal Types.GeoGridTileType.Geohex

[<Fact>]
let ``GeoGridTileType.Geohash round-trips`` () =
    let value = Types.GeoGridTileType.Geohash
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GeoGridTileType> json
    roundTripped |> should equal Types.GeoGridTileType.Geohash

[<Fact>]
let ``JsonProcessorConflictStrategy.Replace round-trips`` () =
    let value = Types.JsonProcessorConflictStrategy.Replace
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JsonProcessorConflictStrategy> json
    roundTripped |> should equal Types.JsonProcessorConflictStrategy.Replace

[<Fact>]
let ``JsonProcessorConflictStrategy.Merge round-trips`` () =
    let value = Types.JsonProcessorConflictStrategy.Merge
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JsonProcessorConflictStrategy> json
    roundTripped |> should equal Types.JsonProcessorConflictStrategy.Merge

[<Fact>]
let ``PipelineSimulationStatusOptions.Success round-trips`` () =
    let value = Types.PipelineSimulationStatusOptions.Success
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PipelineSimulationStatusOptions> json
    roundTripped |> should equal Types.PipelineSimulationStatusOptions.Success

[<Fact>]
let ``PipelineSimulationStatusOptions.Error round-trips`` () =
    let value = Types.PipelineSimulationStatusOptions.Error
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PipelineSimulationStatusOptions> json
    roundTripped |> should equal Types.PipelineSimulationStatusOptions.Error

[<Fact>]
let ``PipelineSimulationStatusOptions.ErrorIgnored round-trips`` () =
    let value = Types.PipelineSimulationStatusOptions.ErrorIgnored
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PipelineSimulationStatusOptions> json
    roundTripped |> should equal Types.PipelineSimulationStatusOptions.ErrorIgnored

[<Fact>]
let ``PipelineSimulationStatusOptions.Skipped round-trips`` () =
    let value = Types.PipelineSimulationStatusOptions.Skipped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PipelineSimulationStatusOptions> json
    roundTripped |> should equal Types.PipelineSimulationStatusOptions.Skipped

[<Fact>]
let ``PipelineSimulationStatusOptions.Dropped round-trips`` () =
    let value = Types.PipelineSimulationStatusOptions.Dropped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PipelineSimulationStatusOptions> json
    roundTripped |> should equal Types.PipelineSimulationStatusOptions.Dropped

[<Fact>]
let ``ShapeType.GeoShape round-trips`` () =
    let value = Types.ShapeType.GeoShape
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShapeType> json
    roundTripped |> should equal Types.ShapeType.GeoShape

[<Fact>]
let ``ShapeType.Shape round-trips`` () =
    let value = Types.ShapeType.Shape
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShapeType> json
    roundTripped |> should equal Types.ShapeType.Shape

[<Fact>]
let ``UserAgentProperty.Name round-trips`` () =
    let value = Types.UserAgentProperty.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UserAgentProperty> json
    roundTripped |> should equal Types.UserAgentProperty.Name

[<Fact>]
let ``UserAgentProperty.Os round-trips`` () =
    let value = Types.UserAgentProperty.Os
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UserAgentProperty> json
    roundTripped |> should equal Types.UserAgentProperty.Os

[<Fact>]
let ``UserAgentProperty.Device round-trips`` () =
    let value = Types.UserAgentProperty.Device
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UserAgentProperty> json
    roundTripped |> should equal Types.UserAgentProperty.Device

[<Fact>]
let ``UserAgentProperty.Original round-trips`` () =
    let value = Types.UserAgentProperty.Original
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UserAgentProperty> json
    roundTripped |> should equal Types.UserAgentProperty.Original

[<Fact>]
let ``UserAgentProperty.Version round-trips`` () =
    let value = Types.UserAgentProperty.Version
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.UserAgentProperty> json
    roundTripped |> should equal Types.UserAgentProperty.Version

[<Fact>]
let ``LicenseStatus.Active round-trips`` () =
    let value = Types.LicenseStatus.Active
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseStatus> json
    roundTripped |> should equal Types.LicenseStatus.Active

[<Fact>]
let ``LicenseStatus.Valid round-trips`` () =
    let value = Types.LicenseStatus.Valid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseStatus> json
    roundTripped |> should equal Types.LicenseStatus.Valid

[<Fact>]
let ``LicenseStatus.Invalid round-trips`` () =
    let value = Types.LicenseStatus.Invalid
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseStatus> json
    roundTripped |> should equal Types.LicenseStatus.Invalid

[<Fact>]
let ``LicenseStatus.Expired round-trips`` () =
    let value = Types.LicenseStatus.Expired
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseStatus> json
    roundTripped |> should equal Types.LicenseStatus.Expired

[<Fact>]
let ``LicenseType.Missing round-trips`` () =
    let value = Types.LicenseType.Missing
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Missing

[<Fact>]
let ``LicenseType.Trial round-trips`` () =
    let value = Types.LicenseType.Trial
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Trial

[<Fact>]
let ``LicenseType.Basic round-trips`` () =
    let value = Types.LicenseType.Basic
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Basic

[<Fact>]
let ``LicenseType.Standard round-trips`` () =
    let value = Types.LicenseType.Standard
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Standard

[<Fact>]
let ``LicenseType.Dev round-trips`` () =
    let value = Types.LicenseType.Dev
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Dev

[<Fact>]
let ``LicenseType.Silver round-trips`` () =
    let value = Types.LicenseType.Silver
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Silver

[<Fact>]
let ``LicenseType.Gold round-trips`` () =
    let value = Types.LicenseType.Gold
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Gold

[<Fact>]
let ``LicenseType.Platinum round-trips`` () =
    let value = Types.LicenseType.Platinum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Platinum

[<Fact>]
let ``LicenseType.Enterprise round-trips`` () =
    let value = Types.LicenseType.Enterprise
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.LicenseType> json
    roundTripped |> should equal Types.LicenseType.Enterprise

[<Fact>]
let ``DeprecationLevel.None round-trips`` () =
    let value = Types.DeprecationLevel.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeprecationLevel> json
    roundTripped |> should equal Types.DeprecationLevel.None

[<Fact>]
let ``DeprecationLevel.Info round-trips`` () =
    let value = Types.DeprecationLevel.Info
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeprecationLevel> json
    roundTripped |> should equal Types.DeprecationLevel.Info

[<Fact>]
let ``DeprecationLevel.Warning round-trips`` () =
    let value = Types.DeprecationLevel.Warning
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeprecationLevel> json
    roundTripped |> should equal Types.DeprecationLevel.Warning

[<Fact>]
let ``DeprecationLevel.Critical round-trips`` () =
    let value = Types.DeprecationLevel.Critical
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeprecationLevel> json
    roundTripped |> should equal Types.DeprecationLevel.Critical

[<Fact>]
let ``MigrationStatus.NOMIGRATIONNEEDED round-trips`` () =
    let value = Types.MigrationStatus.NOMIGRATIONNEEDED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MigrationStatus> json
    roundTripped |> should equal Types.MigrationStatus.NOMIGRATIONNEEDED

[<Fact>]
let ``MigrationStatus.MIGRATIONNEEDED round-trips`` () =
    let value = Types.MigrationStatus.MIGRATIONNEEDED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MigrationStatus> json
    roundTripped |> should equal Types.MigrationStatus.MIGRATIONNEEDED

[<Fact>]
let ``MigrationStatus.INPROGRESS round-trips`` () =
    let value = Types.MigrationStatus.INPROGRESS
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MigrationStatus> json
    roundTripped |> should equal Types.MigrationStatus.INPROGRESS

[<Fact>]
let ``MigrationStatus.ERROR round-trips`` () =
    let value = Types.MigrationStatus.ERROR
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MigrationStatus> json
    roundTripped |> should equal Types.MigrationStatus.ERROR

[<Fact>]
let ``AppliesTo.Actual round-trips`` () =
    let value = Types.AppliesTo.Actual
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AppliesTo> json
    roundTripped |> should equal Types.AppliesTo.Actual

[<Fact>]
let ``AppliesTo.Typical round-trips`` () =
    let value = Types.AppliesTo.Typical
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AppliesTo> json
    roundTripped |> should equal Types.AppliesTo.Typical

[<Fact>]
let ``AppliesTo.DiffFromTypical round-trips`` () =
    let value = Types.AppliesTo.DiffFromTypical
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AppliesTo> json
    roundTripped |> should equal Types.AppliesTo.DiffFromTypical

[<Fact>]
let ``AppliesTo.Time round-trips`` () =
    let value = Types.AppliesTo.Time
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AppliesTo> json
    roundTripped |> should equal Types.AppliesTo.Time

[<Fact>]
let ``CategorizationStatus.Ok round-trips`` () =
    let value = Types.CategorizationStatus.Ok
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CategorizationStatus> json
    roundTripped |> should equal Types.CategorizationStatus.Ok

[<Fact>]
let ``CategorizationStatus.Warn round-trips`` () =
    let value = Types.CategorizationStatus.Warn
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.CategorizationStatus> json
    roundTripped |> should equal Types.CategorizationStatus.Warn

[<Fact>]
let ``ChunkingMode.Auto round-trips`` () =
    let value = Types.ChunkingMode.Auto
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChunkingMode> json
    roundTripped |> should equal Types.ChunkingMode.Auto

[<Fact>]
let ``ChunkingMode.Manual round-trips`` () =
    let value = Types.ChunkingMode.Manual
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChunkingMode> json
    roundTripped |> should equal Types.ChunkingMode.Manual

[<Fact>]
let ``ChunkingMode.Off round-trips`` () =
    let value = Types.ChunkingMode.Off
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ChunkingMode> json
    roundTripped |> should equal Types.ChunkingMode.Off

[<Fact>]
let ``ConditionOperator.Gt round-trips`` () =
    let value = Types.ConditionOperator.Gt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOperator> json
    roundTripped |> should equal Types.ConditionOperator.Gt

[<Fact>]
let ``ConditionOperator.Gte round-trips`` () =
    let value = Types.ConditionOperator.Gte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOperator> json
    roundTripped |> should equal Types.ConditionOperator.Gte

[<Fact>]
let ``ConditionOperator.Lt round-trips`` () =
    let value = Types.ConditionOperator.Lt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOperator> json
    roundTripped |> should equal Types.ConditionOperator.Lt

[<Fact>]
let ``ConditionOperator.Lte round-trips`` () =
    let value = Types.ConditionOperator.Lte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOperator> json
    roundTripped |> should equal Types.ConditionOperator.Lte

[<Fact>]
let ``DatafeedState.Started round-trips`` () =
    let value = Types.DatafeedState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DatafeedState> json
    roundTripped |> should equal Types.DatafeedState.Started

[<Fact>]
let ``DatafeedState.Stopped round-trips`` () =
    let value = Types.DatafeedState.Stopped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DatafeedState> json
    roundTripped |> should equal Types.DatafeedState.Stopped

[<Fact>]
let ``DatafeedState.Starting round-trips`` () =
    let value = Types.DatafeedState.Starting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DatafeedState> json
    roundTripped |> should equal Types.DatafeedState.Starting

[<Fact>]
let ``DatafeedState.Stopping round-trips`` () =
    let value = Types.DatafeedState.Stopping
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DatafeedState> json
    roundTripped |> should equal Types.DatafeedState.Stopping

[<Fact>]
let ``DataframeState.Started round-trips`` () =
    let value = Types.DataframeState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataframeState> json
    roundTripped |> should equal Types.DataframeState.Started

[<Fact>]
let ``DataframeState.Stopped round-trips`` () =
    let value = Types.DataframeState.Stopped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataframeState> json
    roundTripped |> should equal Types.DataframeState.Stopped

[<Fact>]
let ``DataframeState.Starting round-trips`` () =
    let value = Types.DataframeState.Starting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataframeState> json
    roundTripped |> should equal Types.DataframeState.Starting

[<Fact>]
let ``DataframeState.Stopping round-trips`` () =
    let value = Types.DataframeState.Stopping
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataframeState> json
    roundTripped |> should equal Types.DataframeState.Stopping

[<Fact>]
let ``DataframeState.Failed round-trips`` () =
    let value = Types.DataframeState.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataframeState> json
    roundTripped |> should equal Types.DataframeState.Failed

[<Fact>]
let ``DeploymentAllocationState.Started round-trips`` () =
    let value = Types.DeploymentAllocationState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAllocationState> json
    roundTripped |> should equal Types.DeploymentAllocationState.Started

[<Fact>]
let ``DeploymentAllocationState.Starting round-trips`` () =
    let value = Types.DeploymentAllocationState.Starting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAllocationState> json
    roundTripped |> should equal Types.DeploymentAllocationState.Starting

[<Fact>]
let ``DeploymentAllocationState.FullyAllocated round-trips`` () =
    let value = Types.DeploymentAllocationState.FullyAllocated
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAllocationState> json
    roundTripped |> should equal Types.DeploymentAllocationState.FullyAllocated

[<Fact>]
let ``DeploymentAssignmentState.Started round-trips`` () =
    let value = Types.DeploymentAssignmentState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAssignmentState> json
    roundTripped |> should equal Types.DeploymentAssignmentState.Started

[<Fact>]
let ``DeploymentAssignmentState.Starting round-trips`` () =
    let value = Types.DeploymentAssignmentState.Starting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAssignmentState> json
    roundTripped |> should equal Types.DeploymentAssignmentState.Starting

[<Fact>]
let ``DeploymentAssignmentState.Stopping round-trips`` () =
    let value = Types.DeploymentAssignmentState.Stopping
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAssignmentState> json
    roundTripped |> should equal Types.DeploymentAssignmentState.Stopping

[<Fact>]
let ``DeploymentAssignmentState.Failed round-trips`` () =
    let value = Types.DeploymentAssignmentState.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DeploymentAssignmentState> json
    roundTripped |> should equal Types.DeploymentAssignmentState.Failed

[<Fact>]
let ``ExcludeFrequent.All round-trips`` () =
    let value = Types.ExcludeFrequent.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExcludeFrequent> json
    roundTripped |> should equal Types.ExcludeFrequent.All

[<Fact>]
let ``ExcludeFrequent.None round-trips`` () =
    let value = Types.ExcludeFrequent.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExcludeFrequent> json
    roundTripped |> should equal Types.ExcludeFrequent.None

[<Fact>]
let ``ExcludeFrequent.By round-trips`` () =
    let value = Types.ExcludeFrequent.By
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExcludeFrequent> json
    roundTripped |> should equal Types.ExcludeFrequent.By

[<Fact>]
let ``ExcludeFrequent.Over round-trips`` () =
    let value = Types.ExcludeFrequent.Over
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExcludeFrequent> json
    roundTripped |> should equal Types.ExcludeFrequent.Over

[<Fact>]
let ``FilterType.Include round-trips`` () =
    let value = Types.FilterType.Include
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilterType> json
    roundTripped |> should equal Types.FilterType.Include

[<Fact>]
let ``FilterType.Exclude round-trips`` () =
    let value = Types.FilterType.Exclude
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FilterType> json
    roundTripped |> should equal Types.FilterType.Exclude

[<Fact>]
let ``Include.Definition round-trips`` () =
    let value = Types.Include.Definition
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Include> json
    roundTripped |> should equal Types.Include.Definition

[<Fact>]
let ``Include.FeatureImportanceBaseline round-trips`` () =
    let value = Types.Include.FeatureImportanceBaseline
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Include> json
    roundTripped |> should equal Types.Include.FeatureImportanceBaseline

[<Fact>]
let ``Include.Hyperparameters round-trips`` () =
    let value = Types.Include.Hyperparameters
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Include> json
    roundTripped |> should equal Types.Include.Hyperparameters

[<Fact>]
let ``Include.TotalFeatureImportance round-trips`` () =
    let value = Types.Include.TotalFeatureImportance
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Include> json
    roundTripped |> should equal Types.Include.TotalFeatureImportance

[<Fact>]
let ``Include.DefinitionStatus round-trips`` () =
    let value = Types.Include.DefinitionStatus
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Include> json
    roundTripped |> should equal Types.Include.DefinitionStatus

[<Fact>]
let ``JobBlockedReason.Delete round-trips`` () =
    let value = Types.JobBlockedReason.Delete
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobBlockedReason> json
    roundTripped |> should equal Types.JobBlockedReason.Delete

[<Fact>]
let ``JobBlockedReason.Reset round-trips`` () =
    let value = Types.JobBlockedReason.Reset
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobBlockedReason> json
    roundTripped |> should equal Types.JobBlockedReason.Reset

[<Fact>]
let ``JobBlockedReason.Revert round-trips`` () =
    let value = Types.JobBlockedReason.Revert
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobBlockedReason> json
    roundTripped |> should equal Types.JobBlockedReason.Revert

[<Fact>]
let ``JobState.Closing round-trips`` () =
    let value = Types.JobState.Closing
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobState> json
    roundTripped |> should equal Types.JobState.Closing

[<Fact>]
let ``JobState.Closed round-trips`` () =
    let value = Types.JobState.Closed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobState> json
    roundTripped |> should equal Types.JobState.Closed

[<Fact>]
let ``JobState.Opened round-trips`` () =
    let value = Types.JobState.Opened
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobState> json
    roundTripped |> should equal Types.JobState.Opened

[<Fact>]
let ``JobState.Failed round-trips`` () =
    let value = Types.JobState.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobState> json
    roundTripped |> should equal Types.JobState.Failed

[<Fact>]
let ``JobState.Opening round-trips`` () =
    let value = Types.JobState.Opening
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.JobState> json
    roundTripped |> should equal Types.JobState.Opening

[<Fact>]
let ``MemoryStatus.Ok round-trips`` () =
    let value = Types.MemoryStatus.Ok
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MemoryStatus> json
    roundTripped |> should equal Types.MemoryStatus.Ok

[<Fact>]
let ``MemoryStatus.SoftLimit round-trips`` () =
    let value = Types.MemoryStatus.SoftLimit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MemoryStatus> json
    roundTripped |> should equal Types.MemoryStatus.SoftLimit

[<Fact>]
let ``MemoryStatus.HardLimit round-trips`` () =
    let value = Types.MemoryStatus.HardLimit
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MemoryStatus> json
    roundTripped |> should equal Types.MemoryStatus.HardLimit

[<Fact>]
let ``RoutingState.Failed round-trips`` () =
    let value = Types.RoutingState.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RoutingState> json
    roundTripped |> should equal Types.RoutingState.Failed

[<Fact>]
let ``RoutingState.Started round-trips`` () =
    let value = Types.RoutingState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RoutingState> json
    roundTripped |> should equal Types.RoutingState.Started

[<Fact>]
let ``RoutingState.Starting round-trips`` () =
    let value = Types.RoutingState.Starting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RoutingState> json
    roundTripped |> should equal Types.RoutingState.Starting

[<Fact>]
let ``RoutingState.Stopped round-trips`` () =
    let value = Types.RoutingState.Stopped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RoutingState> json
    roundTripped |> should equal Types.RoutingState.Stopped

[<Fact>]
let ``RoutingState.Stopping round-trips`` () =
    let value = Types.RoutingState.Stopping
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RoutingState> json
    roundTripped |> should equal Types.RoutingState.Stopping

[<Fact>]
let ``RuleAction.SkipResult round-trips`` () =
    let value = Types.RuleAction.SkipResult
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuleAction> json
    roundTripped |> should equal Types.RuleAction.SkipResult

[<Fact>]
let ``RuleAction.SkipModelUpdate round-trips`` () =
    let value = Types.RuleAction.SkipModelUpdate
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RuleAction> json
    roundTripped |> should equal Types.RuleAction.SkipModelUpdate

[<Fact>]
let ``SnapshotUpgradeState.LoadingOldState round-trips`` () =
    let value = Types.SnapshotUpgradeState.LoadingOldState
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotUpgradeState> json
    roundTripped |> should equal Types.SnapshotUpgradeState.LoadingOldState

[<Fact>]
let ``SnapshotUpgradeState.SavingNewState round-trips`` () =
    let value = Types.SnapshotUpgradeState.SavingNewState
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotUpgradeState> json
    roundTripped |> should equal Types.SnapshotUpgradeState.SavingNewState

[<Fact>]
let ``SnapshotUpgradeState.Stopped round-trips`` () =
    let value = Types.SnapshotUpgradeState.Stopped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotUpgradeState> json
    roundTripped |> should equal Types.SnapshotUpgradeState.Stopped

[<Fact>]
let ``SnapshotUpgradeState.Failed round-trips`` () =
    let value = Types.SnapshotUpgradeState.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotUpgradeState> json
    roundTripped |> should equal Types.SnapshotUpgradeState.Failed

[<Fact>]
let ``TokenizationTruncate.First round-trips`` () =
    let value = Types.TokenizationTruncate.First
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenizationTruncate> json
    roundTripped |> should equal Types.TokenizationTruncate.First

[<Fact>]
let ``TokenizationTruncate.Second round-trips`` () =
    let value = Types.TokenizationTruncate.Second
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenizationTruncate> json
    roundTripped |> should equal Types.TokenizationTruncate.Second

[<Fact>]
let ``TokenizationTruncate.None round-trips`` () =
    let value = Types.TokenizationTruncate.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TokenizationTruncate> json
    roundTripped |> should equal Types.TokenizationTruncate.None

[<Fact>]
let ``TrainedModelType.TreeEnsemble round-trips`` () =
    let value = Types.TrainedModelType.TreeEnsemble
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TrainedModelType> json
    roundTripped |> should equal Types.TrainedModelType.TreeEnsemble

[<Fact>]
let ``TrainedModelType.LangIdent round-trips`` () =
    let value = Types.TrainedModelType.LangIdent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TrainedModelType> json
    roundTripped |> should equal Types.TrainedModelType.LangIdent

[<Fact>]
let ``TrainedModelType.Pytorch round-trips`` () =
    let value = Types.TrainedModelType.Pytorch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TrainedModelType> json
    roundTripped |> should equal Types.TrainedModelType.Pytorch

[<Fact>]
let ``TrainingPriority.Normal round-trips`` () =
    let value = Types.TrainingPriority.Normal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TrainingPriority> json
    roundTripped |> should equal Types.TrainingPriority.Normal

[<Fact>]
let ``TrainingPriority.Low round-trips`` () =
    let value = Types.TrainingPriority.Low
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TrainingPriority> json
    roundTripped |> should equal Types.TrainingPriority.Low

[<Fact>]
let ``NodesInfoMetric.All round-trips`` () =
    let value = Types.NodesInfoMetric.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.All

[<Fact>]
let ``NodesInfoMetric.None round-trips`` () =
    let value = Types.NodesInfoMetric.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.None

[<Fact>]
let ``NodesInfoMetric.Settings round-trips`` () =
    let value = Types.NodesInfoMetric.Settings
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Settings

[<Fact>]
let ``NodesInfoMetric.Os round-trips`` () =
    let value = Types.NodesInfoMetric.Os
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Os

[<Fact>]
let ``NodesInfoMetric.Process round-trips`` () =
    let value = Types.NodesInfoMetric.Process
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Process

[<Fact>]
let ``NodesInfoMetric.Jvm round-trips`` () =
    let value = Types.NodesInfoMetric.Jvm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Jvm

[<Fact>]
let ``NodesInfoMetric.ThreadPool round-trips`` () =
    let value = Types.NodesInfoMetric.ThreadPool
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.ThreadPool

[<Fact>]
let ``NodesInfoMetric.Transport round-trips`` () =
    let value = Types.NodesInfoMetric.Transport
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Transport

[<Fact>]
let ``NodesInfoMetric.Http round-trips`` () =
    let value = Types.NodesInfoMetric.Http
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Http

[<Fact>]
let ``NodesInfoMetric.RemoteClusterServer round-trips`` () =
    let value = Types.NodesInfoMetric.RemoteClusterServer
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.RemoteClusterServer

[<Fact>]
let ``NodesInfoMetric.Plugins round-trips`` () =
    let value = Types.NodesInfoMetric.Plugins
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Plugins

[<Fact>]
let ``NodesInfoMetric.Ingest round-trips`` () =
    let value = Types.NodesInfoMetric.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Ingest

[<Fact>]
let ``NodesInfoMetric.Aggregations round-trips`` () =
    let value = Types.NodesInfoMetric.Aggregations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Aggregations

[<Fact>]
let ``NodesInfoMetric.Indices round-trips`` () =
    let value = Types.NodesInfoMetric.Indices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesInfoMetric> json
    roundTripped |> should equal Types.NodesInfoMetric.Indices

[<Fact>]
let ``NodeStatsMetric.All round-trips`` () =
    let value = Types.NodeStatsMetric.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.All

[<Fact>]
let ``NodeStatsMetric.None round-trips`` () =
    let value = Types.NodeStatsMetric.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.None

[<Fact>]
let ``NodeStatsMetric.Indices round-trips`` () =
    let value = Types.NodeStatsMetric.Indices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Indices

[<Fact>]
let ``NodeStatsMetric.Os round-trips`` () =
    let value = Types.NodeStatsMetric.Os
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Os

[<Fact>]
let ``NodeStatsMetric.Process round-trips`` () =
    let value = Types.NodeStatsMetric.Process
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Process

[<Fact>]
let ``NodeStatsMetric.Jvm round-trips`` () =
    let value = Types.NodeStatsMetric.Jvm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Jvm

[<Fact>]
let ``NodeStatsMetric.ThreadPool round-trips`` () =
    let value = Types.NodeStatsMetric.ThreadPool
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.ThreadPool

[<Fact>]
let ``NodeStatsMetric.Fs round-trips`` () =
    let value = Types.NodeStatsMetric.Fs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Fs

[<Fact>]
let ``NodeStatsMetric.Transport round-trips`` () =
    let value = Types.NodeStatsMetric.Transport
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Transport

[<Fact>]
let ``NodeStatsMetric.Http round-trips`` () =
    let value = Types.NodeStatsMetric.Http
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Http

[<Fact>]
let ``NodeStatsMetric.Breaker round-trips`` () =
    let value = Types.NodeStatsMetric.Breaker
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Breaker

[<Fact>]
let ``NodeStatsMetric.Script round-trips`` () =
    let value = Types.NodeStatsMetric.Script
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Script

[<Fact>]
let ``NodeStatsMetric.Discovery round-trips`` () =
    let value = Types.NodeStatsMetric.Discovery
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Discovery

[<Fact>]
let ``NodeStatsMetric.Ingest round-trips`` () =
    let value = Types.NodeStatsMetric.Ingest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Ingest

[<Fact>]
let ``NodeStatsMetric.AdaptiveSelection round-trips`` () =
    let value = Types.NodeStatsMetric.AdaptiveSelection
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.AdaptiveSelection

[<Fact>]
let ``NodeStatsMetric.ScriptCache round-trips`` () =
    let value = Types.NodeStatsMetric.ScriptCache
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.ScriptCache

[<Fact>]
let ``NodeStatsMetric.IndexingPressure round-trips`` () =
    let value = Types.NodeStatsMetric.IndexingPressure
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.IndexingPressure

[<Fact>]
let ``NodeStatsMetric.Repositories round-trips`` () =
    let value = Types.NodeStatsMetric.Repositories
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Repositories

[<Fact>]
let ``NodeStatsMetric.Allocations round-trips`` () =
    let value = Types.NodeStatsMetric.Allocations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodeStatsMetric> json
    roundTripped |> should equal Types.NodeStatsMetric.Allocations

[<Fact>]
let ``NodesUsageMetric.All round-trips`` () =
    let value = Types.NodesUsageMetric.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesUsageMetric> json
    roundTripped |> should equal Types.NodesUsageMetric.All

[<Fact>]
let ``NodesUsageMetric.RestActions round-trips`` () =
    let value = Types.NodesUsageMetric.RestActions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesUsageMetric> json
    roundTripped |> should equal Types.NodesUsageMetric.RestActions

[<Fact>]
let ``NodesUsageMetric.Aggregations round-trips`` () =
    let value = Types.NodesUsageMetric.Aggregations
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.NodesUsageMetric> json
    roundTripped |> should equal Types.NodesUsageMetric.Aggregations

[<Fact>]
let ``ProfilingOperationMode.RUNNING round-trips`` () =
    let value = Types.ProfilingOperationMode.RUNNING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ProfilingOperationMode> json
    roundTripped |> should equal Types.ProfilingOperationMode.RUNNING

[<Fact>]
let ``ProfilingOperationMode.STOPPING round-trips`` () =
    let value = Types.ProfilingOperationMode.STOPPING
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ProfilingOperationMode> json
    roundTripped |> should equal Types.ProfilingOperationMode.STOPPING

[<Fact>]
let ``ProfilingOperationMode.STOPPED round-trips`` () =
    let value = Types.ProfilingOperationMode.STOPPED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ProfilingOperationMode> json
    roundTripped |> should equal Types.ProfilingOperationMode.STOPPED

[<Fact>]
let ``QueryRuleCriteriaType.Global round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Global
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Global

[<Fact>]
let ``QueryRuleCriteriaType.Exact round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Exact
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Exact

[<Fact>]
let ``QueryRuleCriteriaType.Fuzzy round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Fuzzy
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Fuzzy

[<Fact>]
let ``QueryRuleCriteriaType.Prefix round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Prefix
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Prefix

[<Fact>]
let ``QueryRuleCriteriaType.Suffix round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Suffix
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Suffix

[<Fact>]
let ``QueryRuleCriteriaType.Contains round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Contains
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Contains

[<Fact>]
let ``QueryRuleCriteriaType.Lt round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Lt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Lt

[<Fact>]
let ``QueryRuleCriteriaType.Lte round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Lte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Lte

[<Fact>]
let ``QueryRuleCriteriaType.Gt round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Gt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Gt

[<Fact>]
let ``QueryRuleCriteriaType.Gte round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Gte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Gte

[<Fact>]
let ``QueryRuleCriteriaType.Always round-trips`` () =
    let value = Types.QueryRuleCriteriaType.Always
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleCriteriaType> json
    roundTripped |> should equal Types.QueryRuleCriteriaType.Always

[<Fact>]
let ``QueryRuleType.Pinned round-trips`` () =
    let value = Types.QueryRuleType.Pinned
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleType> json
    roundTripped |> should equal Types.QueryRuleType.Pinned

[<Fact>]
let ``QueryRuleType.Exclude round-trips`` () =
    let value = Types.QueryRuleType.Exclude
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.QueryRuleType> json
    roundTripped |> should equal Types.QueryRuleType.Exclude

[<Fact>]
let ``Metric.Min round-trips`` () =
    let value = Types.Metric.Min
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Metric> json
    roundTripped |> should equal Types.Metric.Min

[<Fact>]
let ``Metric.Max round-trips`` () =
    let value = Types.Metric.Max
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Metric> json
    roundTripped |> should equal Types.Metric.Max

[<Fact>]
let ``Metric.Sum round-trips`` () =
    let value = Types.Metric.Sum
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Metric> json
    roundTripped |> should equal Types.Metric.Sum

[<Fact>]
let ``Metric.Avg round-trips`` () =
    let value = Types.Metric.Avg
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Metric> json
    roundTripped |> should equal Types.Metric.Avg

[<Fact>]
let ``Metric.ValueCount round-trips`` () =
    let value = Types.Metric.ValueCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Metric> json
    roundTripped |> should equal Types.Metric.ValueCount

[<Fact>]
let ``IndexingJobState.Started round-trips`` () =
    let value = Types.IndexingJobState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexingJobState> json
    roundTripped |> should equal Types.IndexingJobState.Started

[<Fact>]
let ``IndexingJobState.Indexing round-trips`` () =
    let value = Types.IndexingJobState.Indexing
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexingJobState> json
    roundTripped |> should equal Types.IndexingJobState.Indexing

[<Fact>]
let ``IndexingJobState.Stopping round-trips`` () =
    let value = Types.IndexingJobState.Stopping
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexingJobState> json
    roundTripped |> should equal Types.IndexingJobState.Stopping

[<Fact>]
let ``IndexingJobState.Stopped round-trips`` () =
    let value = Types.IndexingJobState.Stopped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexingJobState> json
    roundTripped |> should equal Types.IndexingJobState.Stopped

[<Fact>]
let ``IndexingJobState.Aborting round-trips`` () =
    let value = Types.IndexingJobState.Aborting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexingJobState> json
    roundTripped |> should equal Types.IndexingJobState.Aborting

[<Fact>]
let ``EventType.PageView round-trips`` () =
    let value = Types.EventType.PageView
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EventType> json
    roundTripped |> should equal Types.EventType.PageView

[<Fact>]
let ``EventType.Search round-trips`` () =
    let value = Types.EventType.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EventType> json
    roundTripped |> should equal Types.EventType.Search

[<Fact>]
let ``EventType.SearchClick round-trips`` () =
    let value = Types.EventType.SearchClick
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EventType> json
    roundTripped |> should equal Types.EventType.SearchClick

[<Fact>]
let ``StatsLevel.Cluster round-trips`` () =
    let value = Types.StatsLevel.Cluster
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StatsLevel> json
    roundTripped |> should equal Types.StatsLevel.Cluster

[<Fact>]
let ``StatsLevel.Indices round-trips`` () =
    let value = Types.StatsLevel.Indices
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StatsLevel> json
    roundTripped |> should equal Types.StatsLevel.Indices

[<Fact>]
let ``StatsLevel.Shards round-trips`` () =
    let value = Types.StatsLevel.Shards
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StatsLevel> json
    roundTripped |> should equal Types.StatsLevel.Shards

[<Fact>]
let ``StorageOption.FullCopy round-trips`` () =
    let value = Types.StorageOption.FullCopy
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StorageOption> json
    roundTripped |> should equal Types.StorageOption.FullCopy

[<Fact>]
let ``StorageOption.SharedCache round-trips`` () =
    let value = Types.StorageOption.SharedCache
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StorageOption> json
    roundTripped |> should equal Types.StorageOption.SharedCache

[<Fact>]
let ``ApiKeyManagedBy.Cloud round-trips`` () =
    let value = Types.ApiKeyManagedBy.Cloud
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ApiKeyManagedBy> json
    roundTripped |> should equal Types.ApiKeyManagedBy.Cloud

[<Fact>]
let ``ApiKeyManagedBy.Elasticsearch round-trips`` () =
    let value = Types.ApiKeyManagedBy.Elasticsearch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ApiKeyManagedBy> json
    roundTripped |> should equal Types.ApiKeyManagedBy.Elasticsearch

[<Fact>]
let ``ApiKeyType.Rest round-trips`` () =
    let value = Types.ApiKeyType.Rest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ApiKeyType> json
    roundTripped |> should equal Types.ApiKeyType.Rest

[<Fact>]
let ``ApiKeyType.CrossCluster round-trips`` () =
    let value = Types.ApiKeyType.CrossCluster
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ApiKeyType> json
    roundTripped |> should equal Types.ApiKeyType.CrossCluster

[<Fact>]
let ``ClusterPrivilege.All round-trips`` () =
    let value = Types.ClusterPrivilege.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.All

[<Fact>]
let ``ClusterPrivilege.CancelTask round-trips`` () =
    let value = Types.ClusterPrivilege.CancelTask
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.CancelTask

[<Fact>]
let ``ClusterPrivilege.CreateSnapshot round-trips`` () =
    let value = Types.ClusterPrivilege.CreateSnapshot
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.CreateSnapshot

[<Fact>]
let ``ClusterPrivilege.CrossClusterReplication round-trips`` () =
    let value = Types.ClusterPrivilege.CrossClusterReplication
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.CrossClusterReplication

[<Fact>]
let ``ClusterPrivilege.CrossClusterSearch round-trips`` () =
    let value = Types.ClusterPrivilege.CrossClusterSearch
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.CrossClusterSearch

[<Fact>]
let ``ClusterPrivilege.DelegatePki round-trips`` () =
    let value = Types.ClusterPrivilege.DelegatePki
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.DelegatePki

[<Fact>]
let ``ClusterPrivilege.GrantApiKey round-trips`` () =
    let value = Types.ClusterPrivilege.GrantApiKey
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.GrantApiKey

[<Fact>]
let ``ClusterPrivilege.Manage round-trips`` () =
    let value = Types.ClusterPrivilege.Manage
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.Manage

[<Fact>]
let ``ClusterPrivilege.ManageApiKey round-trips`` () =
    let value = Types.ClusterPrivilege.ManageApiKey
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageApiKey

[<Fact>]
let ``ClusterPrivilege.ManageAutoscaling round-trips`` () =
    let value = Types.ClusterPrivilege.ManageAutoscaling
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageAutoscaling

[<Fact>]
let ``ClusterPrivilege.ManageBehavioralAnalytics round-trips`` () =
    let value = Types.ClusterPrivilege.ManageBehavioralAnalytics
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageBehavioralAnalytics

[<Fact>]
let ``ClusterPrivilege.ManageCcr round-trips`` () =
    let value = Types.ClusterPrivilege.ManageCcr
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageCcr

[<Fact>]
let ``ClusterPrivilege.ManageDataFrameTransforms round-trips`` () =
    let value = Types.ClusterPrivilege.ManageDataFrameTransforms
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageDataFrameTransforms

[<Fact>]
let ``ClusterPrivilege.ManageDataStreamGlobalRetention round-trips`` () =
    let value = Types.ClusterPrivilege.ManageDataStreamGlobalRetention
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageDataStreamGlobalRetention

[<Fact>]
let ``ClusterPrivilege.ManageEnrich round-trips`` () =
    let value = Types.ClusterPrivilege.ManageEnrich
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageEnrich

[<Fact>]
let ``ClusterPrivilege.ManageEsql round-trips`` () =
    let value = Types.ClusterPrivilege.ManageEsql
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageEsql

[<Fact>]
let ``ClusterPrivilege.ManageIlm round-trips`` () =
    let value = Types.ClusterPrivilege.ManageIlm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageIlm

[<Fact>]
let ``ClusterPrivilege.ManageIndexTemplates round-trips`` () =
    let value = Types.ClusterPrivilege.ManageIndexTemplates
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageIndexTemplates

[<Fact>]
let ``ClusterPrivilege.ManageInference round-trips`` () =
    let value = Types.ClusterPrivilege.ManageInference
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageInference

[<Fact>]
let ``ClusterPrivilege.ManageIngestPipelines round-trips`` () =
    let value = Types.ClusterPrivilege.ManageIngestPipelines
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageIngestPipelines

[<Fact>]
let ``ClusterPrivilege.ManageLogstashPipelines round-trips`` () =
    let value = Types.ClusterPrivilege.ManageLogstashPipelines
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageLogstashPipelines

[<Fact>]
let ``ClusterPrivilege.ManageMl round-trips`` () =
    let value = Types.ClusterPrivilege.ManageMl
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageMl

[<Fact>]
let ``ClusterPrivilege.ManageOidc round-trips`` () =
    let value = Types.ClusterPrivilege.ManageOidc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageOidc

[<Fact>]
let ``ClusterPrivilege.ManageOwnApiKey round-trips`` () =
    let value = Types.ClusterPrivilege.ManageOwnApiKey
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageOwnApiKey

[<Fact>]
let ``ClusterPrivilege.ManagePipeline round-trips`` () =
    let value = Types.ClusterPrivilege.ManagePipeline
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManagePipeline

[<Fact>]
let ``ClusterPrivilege.ManageRollup round-trips`` () =
    let value = Types.ClusterPrivilege.ManageRollup
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageRollup

[<Fact>]
let ``ClusterPrivilege.ManageSaml round-trips`` () =
    let value = Types.ClusterPrivilege.ManageSaml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageSaml

[<Fact>]
let ``ClusterPrivilege.ManageSearchApplication round-trips`` () =
    let value = Types.ClusterPrivilege.ManageSearchApplication
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageSearchApplication

[<Fact>]
let ``ClusterPrivilege.ManageSearchQueryRules round-trips`` () =
    let value = Types.ClusterPrivilege.ManageSearchQueryRules
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageSearchQueryRules

[<Fact>]
let ``ClusterPrivilege.ManageSearchSynonyms round-trips`` () =
    let value = Types.ClusterPrivilege.ManageSearchSynonyms
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageSearchSynonyms

[<Fact>]
let ``ClusterPrivilege.ManageSecurity round-trips`` () =
    let value = Types.ClusterPrivilege.ManageSecurity
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageSecurity

[<Fact>]
let ``ClusterPrivilege.ManageServiceAccount round-trips`` () =
    let value = Types.ClusterPrivilege.ManageServiceAccount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageServiceAccount

[<Fact>]
let ``ClusterPrivilege.ManageSlm round-trips`` () =
    let value = Types.ClusterPrivilege.ManageSlm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageSlm

[<Fact>]
let ``ClusterPrivilege.ManageToken round-trips`` () =
    let value = Types.ClusterPrivilege.ManageToken
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageToken

[<Fact>]
let ``ClusterPrivilege.ManageTransform round-trips`` () =
    let value = Types.ClusterPrivilege.ManageTransform
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageTransform

[<Fact>]
let ``ClusterPrivilege.ManageUserProfile round-trips`` () =
    let value = Types.ClusterPrivilege.ManageUserProfile
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageUserProfile

[<Fact>]
let ``ClusterPrivilege.ManageWatcher round-trips`` () =
    let value = Types.ClusterPrivilege.ManageWatcher
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageWatcher

[<Fact>]
let ``ClusterPrivilege.Monitor round-trips`` () =
    let value = Types.ClusterPrivilege.Monitor
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.Monitor

[<Fact>]
let ``ClusterPrivilege.MonitorDataFrameTransforms round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorDataFrameTransforms
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorDataFrameTransforms

[<Fact>]
let ``ClusterPrivilege.MonitorDataStreamGlobalRetention round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorDataStreamGlobalRetention
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorDataStreamGlobalRetention

[<Fact>]
let ``ClusterPrivilege.MonitorEnrich round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorEnrich
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorEnrich

[<Fact>]
let ``ClusterPrivilege.MonitorEsql round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorEsql
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorEsql

[<Fact>]
let ``ClusterPrivilege.MonitorInference round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorInference
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorInference

[<Fact>]
let ``ClusterPrivilege.MonitorMl round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorMl
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorMl

[<Fact>]
let ``ClusterPrivilege.MonitorRollup round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorRollup
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorRollup

[<Fact>]
let ``ClusterPrivilege.MonitorSnapshot round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorSnapshot
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorSnapshot

[<Fact>]
let ``ClusterPrivilege.MonitorStats round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorStats
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorStats

[<Fact>]
let ``ClusterPrivilege.MonitorTextStructure round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorTextStructure
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorTextStructure

[<Fact>]
let ``ClusterPrivilege.MonitorTransform round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorTransform
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorTransform

[<Fact>]
let ``ClusterPrivilege.MonitorWatcher round-trips`` () =
    let value = Types.ClusterPrivilege.MonitorWatcher
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.MonitorWatcher

[<Fact>]
let ``ClusterPrivilege.None round-trips`` () =
    let value = Types.ClusterPrivilege.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.None

[<Fact>]
let ``ClusterPrivilege.PostBehavioralAnalyticsEvent round-trips`` () =
    let value = Types.ClusterPrivilege.PostBehavioralAnalyticsEvent
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.PostBehavioralAnalyticsEvent

[<Fact>]
let ``ClusterPrivilege.ReadCcr round-trips`` () =
    let value = Types.ClusterPrivilege.ReadCcr
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadCcr

[<Fact>]
let ``ClusterPrivilege.ReadFleetSecrets round-trips`` () =
    let value = Types.ClusterPrivilege.ReadFleetSecrets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadFleetSecrets

[<Fact>]
let ``ClusterPrivilege.ReadIlm round-trips`` () =
    let value = Types.ClusterPrivilege.ReadIlm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadIlm

[<Fact>]
let ``ClusterPrivilege.ReadPipeline round-trips`` () =
    let value = Types.ClusterPrivilege.ReadPipeline
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadPipeline

[<Fact>]
let ``ClusterPrivilege.ReadSecurity round-trips`` () =
    let value = Types.ClusterPrivilege.ReadSecurity
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadSecurity

[<Fact>]
let ``ClusterPrivilege.ReadSlm round-trips`` () =
    let value = Types.ClusterPrivilege.ReadSlm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadSlm

[<Fact>]
let ``ClusterPrivilege.TransportClient round-trips`` () =
    let value = Types.ClusterPrivilege.TransportClient
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.TransportClient

[<Fact>]
let ``ClusterPrivilege.WriteConnectorSecrets round-trips`` () =
    let value = Types.ClusterPrivilege.WriteConnectorSecrets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.WriteConnectorSecrets

[<Fact>]
let ``ClusterPrivilege.WriteFleetSecrets round-trips`` () =
    let value = Types.ClusterPrivilege.WriteFleetSecrets
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.WriteFleetSecrets

[<Fact>]
let ``ClusterPrivilege.ReadProjectRouting round-trips`` () =
    let value = Types.ClusterPrivilege.ReadProjectRouting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ReadProjectRouting

[<Fact>]
let ``ClusterPrivilege.ManageProjectRouting round-trips`` () =
    let value = Types.ClusterPrivilege.ManageProjectRouting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ClusterPrivilege> json
    roundTripped |> should equal Types.ClusterPrivilege.ManageProjectRouting

[<Fact>]
let ``GrantType.Password round-trips`` () =
    let value = Types.GrantType.Password
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GrantType> json
    roundTripped |> should equal Types.GrantType.Password

[<Fact>]
let ``GrantType.AccessToken round-trips`` () =
    let value = Types.GrantType.AccessToken
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GrantType> json
    roundTripped |> should equal Types.GrantType.AccessToken

[<Fact>]
let ``IndexPrivilege.All round-trips`` () =
    let value = Types.IndexPrivilege.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.All

[<Fact>]
let ``IndexPrivilege.AutoConfigure round-trips`` () =
    let value = Types.IndexPrivilege.AutoConfigure
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.AutoConfigure

[<Fact>]
let ``IndexPrivilege.Create round-trips`` () =
    let value = Types.IndexPrivilege.Create
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Create

[<Fact>]
let ``IndexPrivilege.CreateDoc round-trips`` () =
    let value = Types.IndexPrivilege.CreateDoc
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.CreateDoc

[<Fact>]
let ``IndexPrivilege.CreateIndex round-trips`` () =
    let value = Types.IndexPrivilege.CreateIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.CreateIndex

[<Fact>]
let ``IndexPrivilege.CreateView round-trips`` () =
    let value = Types.IndexPrivilege.CreateView
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.CreateView

[<Fact>]
let ``IndexPrivilege.CrossClusterReplication round-trips`` () =
    let value = Types.IndexPrivilege.CrossClusterReplication
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.CrossClusterReplication

[<Fact>]
let ``IndexPrivilege.CrossClusterReplicationInternal round-trips`` () =
    let value = Types.IndexPrivilege.CrossClusterReplicationInternal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.CrossClusterReplicationInternal

[<Fact>]
let ``IndexPrivilege.Delete round-trips`` () =
    let value = Types.IndexPrivilege.Delete
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Delete

[<Fact>]
let ``IndexPrivilege.DeleteIndex round-trips`` () =
    let value = Types.IndexPrivilege.DeleteIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.DeleteIndex

[<Fact>]
let ``IndexPrivilege.DeleteView round-trips`` () =
    let value = Types.IndexPrivilege.DeleteView
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.DeleteView

[<Fact>]
let ``IndexPrivilege.Index round-trips`` () =
    let value = Types.IndexPrivilege.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Index

[<Fact>]
let ``IndexPrivilege.Maintenance round-trips`` () =
    let value = Types.IndexPrivilege.Maintenance
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Maintenance

[<Fact>]
let ``IndexPrivilege.Manage round-trips`` () =
    let value = Types.IndexPrivilege.Manage
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Manage

[<Fact>]
let ``IndexPrivilege.ManageDataStreamLifecycle round-trips`` () =
    let value = Types.IndexPrivilege.ManageDataStreamLifecycle
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ManageDataStreamLifecycle

[<Fact>]
let ``IndexPrivilege.ManageFollowIndex round-trips`` () =
    let value = Types.IndexPrivilege.ManageFollowIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ManageFollowIndex

[<Fact>]
let ``IndexPrivilege.ManageIlm round-trips`` () =
    let value = Types.IndexPrivilege.ManageIlm
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ManageIlm

[<Fact>]
let ``IndexPrivilege.ManageLeaderIndex round-trips`` () =
    let value = Types.IndexPrivilege.ManageLeaderIndex
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ManageLeaderIndex

[<Fact>]
let ``IndexPrivilege.ManageView round-trips`` () =
    let value = Types.IndexPrivilege.ManageView
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ManageView

[<Fact>]
let ``IndexPrivilege.Monitor round-trips`` () =
    let value = Types.IndexPrivilege.Monitor
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Monitor

[<Fact>]
let ``IndexPrivilege.None round-trips`` () =
    let value = Types.IndexPrivilege.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.None

[<Fact>]
let ``IndexPrivilege.Read round-trips`` () =
    let value = Types.IndexPrivilege.Read
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Read

[<Fact>]
let ``IndexPrivilege.ReadCrossCluster round-trips`` () =
    let value = Types.IndexPrivilege.ReadCrossCluster
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ReadCrossCluster

[<Fact>]
let ``IndexPrivilege.ReadViewMetadata round-trips`` () =
    let value = Types.IndexPrivilege.ReadViewMetadata
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ReadViewMetadata

[<Fact>]
let ``IndexPrivilege.ViewIndexMetadata round-trips`` () =
    let value = Types.IndexPrivilege.ViewIndexMetadata
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.ViewIndexMetadata

[<Fact>]
let ``IndexPrivilege.Write round-trips`` () =
    let value = Types.IndexPrivilege.Write
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.IndexPrivilege> json
    roundTripped |> should equal Types.IndexPrivilege.Write

[<Fact>]
let ``RemoteClusterPrivilege.MonitorEnrich round-trips`` () =
    let value = Types.RemoteClusterPrivilege.MonitorEnrich
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RemoteClusterPrivilege> json
    roundTripped |> should equal Types.RemoteClusterPrivilege.MonitorEnrich

[<Fact>]
let ``RemoteClusterPrivilege.MonitorStats round-trips`` () =
    let value = Types.RemoteClusterPrivilege.MonitorStats
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RemoteClusterPrivilege> json
    roundTripped |> should equal Types.RemoteClusterPrivilege.MonitorStats

[<Fact>]
let ``RestrictionWorkflow.SearchApplicationQuery round-trips`` () =
    let value = Types.RestrictionWorkflow.SearchApplicationQuery
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.RestrictionWorkflow> json
    roundTripped |> should equal Types.RestrictionWorkflow.SearchApplicationQuery

[<Fact>]
let ``TemplateFormat.String round-trips`` () =
    let value = Types.TemplateFormat.String
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TemplateFormat> json
    roundTripped |> should equal Types.TemplateFormat.String

[<Fact>]
let ``TemplateFormat.Json round-trips`` () =
    let value = Types.TemplateFormat.Json
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.TemplateFormat> json
    roundTripped |> should equal Types.TemplateFormat.Json

[<Fact>]
let ``AccessTokenGrantType.Password round-trips`` () =
    let value = Types.AccessTokenGrantType.Password
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AccessTokenGrantType> json
    roundTripped |> should equal Types.AccessTokenGrantType.Password

[<Fact>]
let ``AccessTokenGrantType.ClientCredentials round-trips`` () =
    let value = Types.AccessTokenGrantType.ClientCredentials
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AccessTokenGrantType> json
    roundTripped |> should equal Types.AccessTokenGrantType.ClientCredentials

[<Fact>]
let ``AccessTokenGrantType.Kerberos round-trips`` () =
    let value = Types.AccessTokenGrantType.Kerberos
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AccessTokenGrantType> json
    roundTripped |> should equal Types.AccessTokenGrantType.Kerberos

[<Fact>]
let ``AccessTokenGrantType.RefreshToken round-trips`` () =
    let value = Types.AccessTokenGrantType.RefreshToken
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AccessTokenGrantType> json
    roundTripped |> should equal Types.AccessTokenGrantType.RefreshToken

[<Fact>]
let ``ApiKeyGrantType.AccessToken round-trips`` () =
    let value = Types.ApiKeyGrantType.AccessToken
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ApiKeyGrantType> json
    roundTripped |> should equal Types.ApiKeyGrantType.AccessToken

[<Fact>]
let ``ApiKeyGrantType.Password round-trips`` () =
    let value = Types.ApiKeyGrantType.Password
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ApiKeyGrantType> json
    roundTripped |> should equal Types.ApiKeyGrantType.Password

[<Fact>]
let ``Type.Restart round-trips`` () =
    let value = Types.Type.Restart
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Type> json
    roundTripped |> should equal Types.Type.Restart

[<Fact>]
let ``Type.Remove round-trips`` () =
    let value = Types.Type.Remove
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Type> json
    roundTripped |> should equal Types.Type.Remove

[<Fact>]
let ``Type.Replace round-trips`` () =
    let value = Types.Type.Replace
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Type> json
    roundTripped |> should equal Types.Type.Replace

[<Fact>]
let ``ShutdownStatus.NotStarted round-trips`` () =
    let value = Types.ShutdownStatus.NotStarted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShutdownStatus> json
    roundTripped |> should equal Types.ShutdownStatus.NotStarted

[<Fact>]
let ``ShutdownStatus.InProgress round-trips`` () =
    let value = Types.ShutdownStatus.InProgress
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShutdownStatus> json
    roundTripped |> should equal Types.ShutdownStatus.InProgress

[<Fact>]
let ``ShutdownStatus.Stalled round-trips`` () =
    let value = Types.ShutdownStatus.Stalled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShutdownStatus> json
    roundTripped |> should equal Types.ShutdownStatus.Stalled

[<Fact>]
let ``ShutdownStatus.Complete round-trips`` () =
    let value = Types.ShutdownStatus.Complete
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShutdownStatus> json
    roundTripped |> should equal Types.ShutdownStatus.Complete

[<Fact>]
let ``ShutdownType.Remove round-trips`` () =
    let value = Types.ShutdownType.Remove
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShutdownType> json
    roundTripped |> should equal Types.ShutdownType.Remove

[<Fact>]
let ``ShutdownType.Restart round-trips`` () =
    let value = Types.ShutdownType.Restart
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShutdownType> json
    roundTripped |> should equal Types.ShutdownType.Restart

[<Fact>]
let ``MergeType.Index round-trips`` () =
    let value = Types.MergeType.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MergeType> json
    roundTripped |> should equal Types.MergeType.Index

[<Fact>]
let ``MergeType.Template round-trips`` () =
    let value = Types.MergeType.Template
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.MergeType> json
    roundTripped |> should equal Types.MergeType.Template

[<Fact>]
let ``ShardsStatsStage.DONE round-trips`` () =
    let value = Types.ShardsStatsStage.DONE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardsStatsStage> json
    roundTripped |> should equal Types.ShardsStatsStage.DONE

[<Fact>]
let ``ShardsStatsStage.FAILURE round-trips`` () =
    let value = Types.ShardsStatsStage.FAILURE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardsStatsStage> json
    roundTripped |> should equal Types.ShardsStatsStage.FAILURE

[<Fact>]
let ``ShardsStatsStage.FINALIZE round-trips`` () =
    let value = Types.ShardsStatsStage.FINALIZE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardsStatsStage> json
    roundTripped |> should equal Types.ShardsStatsStage.FINALIZE

[<Fact>]
let ``ShardsStatsStage.INIT round-trips`` () =
    let value = Types.ShardsStatsStage.INIT
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardsStatsStage> json
    roundTripped |> should equal Types.ShardsStatsStage.INIT

[<Fact>]
let ``ShardsStatsStage.STARTED round-trips`` () =
    let value = Types.ShardsStatsStage.STARTED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ShardsStatsStage> json
    roundTripped |> should equal Types.ShardsStatsStage.STARTED

[<Fact>]
let ``SnapshotSort.StartTime round-trips`` () =
    let value = Types.SnapshotSort.StartTime
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.StartTime

[<Fact>]
let ``SnapshotSort.Duration round-trips`` () =
    let value = Types.SnapshotSort.Duration
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.Duration

[<Fact>]
let ``SnapshotSort.Name round-trips`` () =
    let value = Types.SnapshotSort.Name
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.Name

[<Fact>]
let ``SnapshotSort.IndexCount round-trips`` () =
    let value = Types.SnapshotSort.IndexCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.IndexCount

[<Fact>]
let ``SnapshotSort.Repository round-trips`` () =
    let value = Types.SnapshotSort.Repository
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.Repository

[<Fact>]
let ``SnapshotSort.ShardCount round-trips`` () =
    let value = Types.SnapshotSort.ShardCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.ShardCount

[<Fact>]
let ``SnapshotSort.FailedShardCount round-trips`` () =
    let value = Types.SnapshotSort.FailedShardCount
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotSort> json
    roundTripped |> should equal Types.SnapshotSort.FailedShardCount

[<Fact>]
let ``SnapshotState.INPROGRESS round-trips`` () =
    let value = Types.SnapshotState.INPROGRESS
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotState> json
    roundTripped |> should equal Types.SnapshotState.INPROGRESS

[<Fact>]
let ``SnapshotState.SUCCESS round-trips`` () =
    let value = Types.SnapshotState.SUCCESS
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotState> json
    roundTripped |> should equal Types.SnapshotState.SUCCESS

[<Fact>]
let ``SnapshotState.FAILED round-trips`` () =
    let value = Types.SnapshotState.FAILED
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotState> json
    roundTripped |> should equal Types.SnapshotState.FAILED

[<Fact>]
let ``SnapshotState.PARTIAL round-trips`` () =
    let value = Types.SnapshotState.PARTIAL
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotState> json
    roundTripped |> should equal Types.SnapshotState.PARTIAL

[<Fact>]
let ``SnapshotState.INCOMPATIBLE round-trips`` () =
    let value = Types.SnapshotState.INCOMPATIBLE
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SnapshotState> json
    roundTripped |> should equal Types.SnapshotState.INCOMPATIBLE

[<Fact>]
let ``SqlFormat.Csv round-trips`` () =
    let value = Types.SqlFormat.Csv
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Csv

[<Fact>]
let ``SqlFormat.Json round-trips`` () =
    let value = Types.SqlFormat.Json
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Json

[<Fact>]
let ``SqlFormat.Tsv round-trips`` () =
    let value = Types.SqlFormat.Tsv
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Tsv

[<Fact>]
let ``SqlFormat.Txt round-trips`` () =
    let value = Types.SqlFormat.Txt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Txt

[<Fact>]
let ``SqlFormat.Yaml round-trips`` () =
    let value = Types.SqlFormat.Yaml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Yaml

[<Fact>]
let ``SqlFormat.Cbor round-trips`` () =
    let value = Types.SqlFormat.Cbor
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Cbor

[<Fact>]
let ``SqlFormat.Smile round-trips`` () =
    let value = Types.SqlFormat.Smile
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.SqlFormat> json
    roundTripped |> should equal Types.SqlFormat.Smile

[<Fact>]
let ``StreamType.Logs round-trips`` () =
    let value = Types.StreamType.Logs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StreamType> json
    roundTripped |> should equal Types.StreamType.Logs

[<Fact>]
let ``StreamType.LogsOtel round-trips`` () =
    let value = Types.StreamType.LogsOtel
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StreamType> json
    roundTripped |> should equal Types.StreamType.LogsOtel

[<Fact>]
let ``StreamType.LogsEcs round-trips`` () =
    let value = Types.StreamType.LogsEcs
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.StreamType> json
    roundTripped |> should equal Types.StreamType.LogsEcs

[<Fact>]
let ``GroupBy.Nodes round-trips`` () =
    let value = Types.GroupBy.Nodes
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GroupBy> json
    roundTripped |> should equal Types.GroupBy.Nodes

[<Fact>]
let ``GroupBy.Parents round-trips`` () =
    let value = Types.GroupBy.Parents
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GroupBy> json
    roundTripped |> should equal Types.GroupBy.Parents

[<Fact>]
let ``GroupBy.None round-trips`` () =
    let value = Types.GroupBy.None
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.GroupBy> json
    roundTripped |> should equal Types.GroupBy.None

[<Fact>]
let ``EcsCompatibilityType.Disabled round-trips`` () =
    let value = Types.EcsCompatibilityType.Disabled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EcsCompatibilityType> json
    roundTripped |> should equal Types.EcsCompatibilityType.Disabled

[<Fact>]
let ``EcsCompatibilityType.V1 round-trips`` () =
    let value = Types.EcsCompatibilityType.V1
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EcsCompatibilityType> json
    roundTripped |> should equal Types.EcsCompatibilityType.V1

[<Fact>]
let ``FormatType.Delimited round-trips`` () =
    let value = Types.FormatType.Delimited
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FormatType> json
    roundTripped |> should equal Types.FormatType.Delimited

[<Fact>]
let ``FormatType.Ndjson round-trips`` () =
    let value = Types.FormatType.Ndjson
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FormatType> json
    roundTripped |> should equal Types.FormatType.Ndjson

[<Fact>]
let ``FormatType.SemiStructuredText round-trips`` () =
    let value = Types.FormatType.SemiStructuredText
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FormatType> json
    roundTripped |> should equal Types.FormatType.SemiStructuredText

[<Fact>]
let ``FormatType.Xml round-trips`` () =
    let value = Types.FormatType.Xml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FormatType> json
    roundTripped |> should equal Types.FormatType.Xml

[<Fact>]
let ``FindStructureFormat.Ndjson round-trips`` () =
    let value = Types.FindStructureFormat.Ndjson
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FindStructureFormat> json
    roundTripped |> should equal Types.FindStructureFormat.Ndjson

[<Fact>]
let ``FindStructureFormat.Xml round-trips`` () =
    let value = Types.FindStructureFormat.Xml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FindStructureFormat> json
    roundTripped |> should equal Types.FindStructureFormat.Xml

[<Fact>]
let ``FindStructureFormat.Delimited round-trips`` () =
    let value = Types.FindStructureFormat.Delimited
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FindStructureFormat> json
    roundTripped |> should equal Types.FindStructureFormat.Delimited

[<Fact>]
let ``FindStructureFormat.SemiStructuredText round-trips`` () =
    let value = Types.FindStructureFormat.SemiStructuredText
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.FindStructureFormat> json
    roundTripped |> should equal Types.FindStructureFormat.SemiStructuredText

[<Fact>]
let ``AcknowledgementOptions.AwaitsSuccessfulExecution round-trips`` () =
    let value = Types.AcknowledgementOptions.AwaitsSuccessfulExecution
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AcknowledgementOptions> json
    roundTripped |> should equal Types.AcknowledgementOptions.AwaitsSuccessfulExecution

[<Fact>]
let ``AcknowledgementOptions.Ackable round-trips`` () =
    let value = Types.AcknowledgementOptions.Ackable
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AcknowledgementOptions> json
    roundTripped |> should equal Types.AcknowledgementOptions.Ackable

[<Fact>]
let ``AcknowledgementOptions.Acked round-trips`` () =
    let value = Types.AcknowledgementOptions.Acked
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.AcknowledgementOptions> json
    roundTripped |> should equal Types.AcknowledgementOptions.Acked

[<Fact>]
let ``ActionExecutionMode.Simulate round-trips`` () =
    let value = Types.ActionExecutionMode.Simulate
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionExecutionMode> json
    roundTripped |> should equal Types.ActionExecutionMode.Simulate

[<Fact>]
let ``ActionExecutionMode.ForceSimulate round-trips`` () =
    let value = Types.ActionExecutionMode.ForceSimulate
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionExecutionMode> json
    roundTripped |> should equal Types.ActionExecutionMode.ForceSimulate

[<Fact>]
let ``ActionExecutionMode.Execute round-trips`` () =
    let value = Types.ActionExecutionMode.Execute
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionExecutionMode> json
    roundTripped |> should equal Types.ActionExecutionMode.Execute

[<Fact>]
let ``ActionExecutionMode.ForceExecute round-trips`` () =
    let value = Types.ActionExecutionMode.ForceExecute
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionExecutionMode> json
    roundTripped |> should equal Types.ActionExecutionMode.ForceExecute

[<Fact>]
let ``ActionExecutionMode.Skip round-trips`` () =
    let value = Types.ActionExecutionMode.Skip
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionExecutionMode> json
    roundTripped |> should equal Types.ActionExecutionMode.Skip

[<Fact>]
let ``ActionStatusOptions.Success round-trips`` () =
    let value = Types.ActionStatusOptions.Success
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionStatusOptions> json
    roundTripped |> should equal Types.ActionStatusOptions.Success

[<Fact>]
let ``ActionStatusOptions.Failure round-trips`` () =
    let value = Types.ActionStatusOptions.Failure
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionStatusOptions> json
    roundTripped |> should equal Types.ActionStatusOptions.Failure

[<Fact>]
let ``ActionStatusOptions.Simulated round-trips`` () =
    let value = Types.ActionStatusOptions.Simulated
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionStatusOptions> json
    roundTripped |> should equal Types.ActionStatusOptions.Simulated

[<Fact>]
let ``ActionStatusOptions.Throttled round-trips`` () =
    let value = Types.ActionStatusOptions.Throttled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionStatusOptions> json
    roundTripped |> should equal Types.ActionStatusOptions.Throttled

[<Fact>]
let ``ActionType.Email round-trips`` () =
    let value = Types.ActionType.Email
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionType> json
    roundTripped |> should equal Types.ActionType.Email

[<Fact>]
let ``ActionType.Webhook round-trips`` () =
    let value = Types.ActionType.Webhook
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionType> json
    roundTripped |> should equal Types.ActionType.Webhook

[<Fact>]
let ``ActionType.Index round-trips`` () =
    let value = Types.ActionType.Index
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionType> json
    roundTripped |> should equal Types.ActionType.Index

[<Fact>]
let ``ActionType.Logging round-trips`` () =
    let value = Types.ActionType.Logging
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionType> json
    roundTripped |> should equal Types.ActionType.Logging

[<Fact>]
let ``ActionType.Slack round-trips`` () =
    let value = Types.ActionType.Slack
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionType> json
    roundTripped |> should equal Types.ActionType.Slack

[<Fact>]
let ``ActionType.Pagerduty round-trips`` () =
    let value = Types.ActionType.Pagerduty
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ActionType> json
    roundTripped |> should equal Types.ActionType.Pagerduty

[<Fact>]
let ``ConditionOp.NotEq round-trips`` () =
    let value = Types.ConditionOp.NotEq
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOp> json
    roundTripped |> should equal Types.ConditionOp.NotEq

[<Fact>]
let ``ConditionOp.Eq round-trips`` () =
    let value = Types.ConditionOp.Eq
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOp> json
    roundTripped |> should equal Types.ConditionOp.Eq

[<Fact>]
let ``ConditionOp.Lt round-trips`` () =
    let value = Types.ConditionOp.Lt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOp> json
    roundTripped |> should equal Types.ConditionOp.Lt

[<Fact>]
let ``ConditionOp.Gt round-trips`` () =
    let value = Types.ConditionOp.Gt
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOp> json
    roundTripped |> should equal Types.ConditionOp.Gt

[<Fact>]
let ``ConditionOp.Lte round-trips`` () =
    let value = Types.ConditionOp.Lte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOp> json
    roundTripped |> should equal Types.ConditionOp.Lte

[<Fact>]
let ``ConditionOp.Gte round-trips`` () =
    let value = Types.ConditionOp.Gte
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionOp> json
    roundTripped |> should equal Types.ConditionOp.Gte

[<Fact>]
let ``ConditionType.Always round-trips`` () =
    let value = Types.ConditionType.Always
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionType> json
    roundTripped |> should equal Types.ConditionType.Always

[<Fact>]
let ``ConditionType.Never round-trips`` () =
    let value = Types.ConditionType.Never
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionType> json
    roundTripped |> should equal Types.ConditionType.Never

[<Fact>]
let ``ConditionType.Script round-trips`` () =
    let value = Types.ConditionType.Script
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionType> json
    roundTripped |> should equal Types.ConditionType.Script

[<Fact>]
let ``ConditionType.Compare round-trips`` () =
    let value = Types.ConditionType.Compare
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionType> json
    roundTripped |> should equal Types.ConditionType.Compare

[<Fact>]
let ``ConditionType.ArrayCompare round-trips`` () =
    let value = Types.ConditionType.ArrayCompare
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConditionType> json
    roundTripped |> should equal Types.ConditionType.ArrayCompare

[<Fact>]
let ``ConnectionScheme.Http round-trips`` () =
    let value = Types.ConnectionScheme.Http
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectionScheme> json
    roundTripped |> should equal Types.ConnectionScheme.Http

[<Fact>]
let ``ConnectionScheme.Https round-trips`` () =
    let value = Types.ConnectionScheme.Https
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ConnectionScheme> json
    roundTripped |> should equal Types.ConnectionScheme.Https

[<Fact>]
let ``DataAttachmentFormat.Json round-trips`` () =
    let value = Types.DataAttachmentFormat.Json
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataAttachmentFormat> json
    roundTripped |> should equal Types.DataAttachmentFormat.Json

[<Fact>]
let ``DataAttachmentFormat.Yaml round-trips`` () =
    let value = Types.DataAttachmentFormat.Yaml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.DataAttachmentFormat> json
    roundTripped |> should equal Types.DataAttachmentFormat.Yaml

[<Fact>]
let ``Day.Sunday round-trips`` () =
    let value = Types.Day.Sunday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Sunday

[<Fact>]
let ``Day.Monday round-trips`` () =
    let value = Types.Day.Monday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Monday

[<Fact>]
let ``Day.Tuesday round-trips`` () =
    let value = Types.Day.Tuesday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Tuesday

[<Fact>]
let ``Day.Wednesday round-trips`` () =
    let value = Types.Day.Wednesday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Wednesday

[<Fact>]
let ``Day.Thursday round-trips`` () =
    let value = Types.Day.Thursday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Thursday

[<Fact>]
let ``Day.Friday round-trips`` () =
    let value = Types.Day.Friday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Friday

[<Fact>]
let ``Day.Saturday round-trips`` () =
    let value = Types.Day.Saturday
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Day> json
    roundTripped |> should equal Types.Day.Saturday

[<Fact>]
let ``EmailPriority.Lowest round-trips`` () =
    let value = Types.EmailPriority.Lowest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmailPriority> json
    roundTripped |> should equal Types.EmailPriority.Lowest

[<Fact>]
let ``EmailPriority.Low round-trips`` () =
    let value = Types.EmailPriority.Low
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmailPriority> json
    roundTripped |> should equal Types.EmailPriority.Low

[<Fact>]
let ``EmailPriority.Normal round-trips`` () =
    let value = Types.EmailPriority.Normal
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmailPriority> json
    roundTripped |> should equal Types.EmailPriority.Normal

[<Fact>]
let ``EmailPriority.High round-trips`` () =
    let value = Types.EmailPriority.High
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmailPriority> json
    roundTripped |> should equal Types.EmailPriority.High

[<Fact>]
let ``EmailPriority.Highest round-trips`` () =
    let value = Types.EmailPriority.Highest
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.EmailPriority> json
    roundTripped |> should equal Types.EmailPriority.Highest

[<Fact>]
let ``ExecutionPhase.AwaitsExecution round-trips`` () =
    let value = Types.ExecutionPhase.AwaitsExecution
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.AwaitsExecution

[<Fact>]
let ``ExecutionPhase.Started round-trips`` () =
    let value = Types.ExecutionPhase.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.Started

[<Fact>]
let ``ExecutionPhase.Input round-trips`` () =
    let value = Types.ExecutionPhase.Input
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.Input

[<Fact>]
let ``ExecutionPhase.Condition round-trips`` () =
    let value = Types.ExecutionPhase.Condition
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.Condition

[<Fact>]
let ``ExecutionPhase.Actions round-trips`` () =
    let value = Types.ExecutionPhase.Actions
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.Actions

[<Fact>]
let ``ExecutionPhase.WatchTransform round-trips`` () =
    let value = Types.ExecutionPhase.WatchTransform
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.WatchTransform

[<Fact>]
let ``ExecutionPhase.Aborted round-trips`` () =
    let value = Types.ExecutionPhase.Aborted
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.Aborted

[<Fact>]
let ``ExecutionPhase.Finished round-trips`` () =
    let value = Types.ExecutionPhase.Finished
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionPhase> json
    roundTripped |> should equal Types.ExecutionPhase.Finished

[<Fact>]
let ``ExecutionStatus.AwaitsExecution round-trips`` () =
    let value = Types.ExecutionStatus.AwaitsExecution
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.AwaitsExecution

[<Fact>]
let ``ExecutionStatus.Checking round-trips`` () =
    let value = Types.ExecutionStatus.Checking
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.Checking

[<Fact>]
let ``ExecutionStatus.ExecutionNotNeeded round-trips`` () =
    let value = Types.ExecutionStatus.ExecutionNotNeeded
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.ExecutionNotNeeded

[<Fact>]
let ``ExecutionStatus.Throttled round-trips`` () =
    let value = Types.ExecutionStatus.Throttled
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.Throttled

[<Fact>]
let ``ExecutionStatus.Executed round-trips`` () =
    let value = Types.ExecutionStatus.Executed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.Executed

[<Fact>]
let ``ExecutionStatus.Failed round-trips`` () =
    let value = Types.ExecutionStatus.Failed
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.Failed

[<Fact>]
let ``ExecutionStatus.DeletedWhileQueued round-trips`` () =
    let value = Types.ExecutionStatus.DeletedWhileQueued
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.DeletedWhileQueued

[<Fact>]
let ``ExecutionStatus.NotExecutedAlreadyQueued round-trips`` () =
    let value = Types.ExecutionStatus.NotExecutedAlreadyQueued
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ExecutionStatus> json
    roundTripped |> should equal Types.ExecutionStatus.NotExecutedAlreadyQueued

[<Fact>]
let ``HttpInputMethod.Head round-trips`` () =
    let value = Types.HttpInputMethod.Head
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HttpInputMethod> json
    roundTripped |> should equal Types.HttpInputMethod.Head

[<Fact>]
let ``HttpInputMethod.Get round-trips`` () =
    let value = Types.HttpInputMethod.Get
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HttpInputMethod> json
    roundTripped |> should equal Types.HttpInputMethod.Get

[<Fact>]
let ``HttpInputMethod.Post round-trips`` () =
    let value = Types.HttpInputMethod.Post
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HttpInputMethod> json
    roundTripped |> should equal Types.HttpInputMethod.Post

[<Fact>]
let ``HttpInputMethod.Put round-trips`` () =
    let value = Types.HttpInputMethod.Put
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HttpInputMethod> json
    roundTripped |> should equal Types.HttpInputMethod.Put

[<Fact>]
let ``HttpInputMethod.Delete round-trips`` () =
    let value = Types.HttpInputMethod.Delete
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.HttpInputMethod> json
    roundTripped |> should equal Types.HttpInputMethod.Delete

[<Fact>]
let ``InputType.Http round-trips`` () =
    let value = Types.InputType.Http
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.InputType> json
    roundTripped |> should equal Types.InputType.Http

[<Fact>]
let ``InputType.Search round-trips`` () =
    let value = Types.InputType.Search
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.InputType> json
    roundTripped |> should equal Types.InputType.Search

[<Fact>]
let ``InputType.Simple round-trips`` () =
    let value = Types.InputType.Simple
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.InputType> json
    roundTripped |> should equal Types.InputType.Simple

[<Fact>]
let ``Month.January round-trips`` () =
    let value = Types.Month.January
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.January

[<Fact>]
let ``Month.February round-trips`` () =
    let value = Types.Month.February
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.February

[<Fact>]
let ``Month.March round-trips`` () =
    let value = Types.Month.March
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.March

[<Fact>]
let ``Month.April round-trips`` () =
    let value = Types.Month.April
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.April

[<Fact>]
let ``Month.May round-trips`` () =
    let value = Types.Month.May
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.May

[<Fact>]
let ``Month.June round-trips`` () =
    let value = Types.Month.June
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.June

[<Fact>]
let ``Month.July round-trips`` () =
    let value = Types.Month.July
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.July

[<Fact>]
let ``Month.August round-trips`` () =
    let value = Types.Month.August
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.August

[<Fact>]
let ``Month.September round-trips`` () =
    let value = Types.Month.September
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.September

[<Fact>]
let ``Month.October round-trips`` () =
    let value = Types.Month.October
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.October

[<Fact>]
let ``Month.November round-trips`` () =
    let value = Types.Month.November
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.November

[<Fact>]
let ``Month.December round-trips`` () =
    let value = Types.Month.December
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Month> json
    roundTripped |> should equal Types.Month.December

[<Fact>]
let ``PagerDutyContextType.Link round-trips`` () =
    let value = Types.PagerDutyContextType.Link
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PagerDutyContextType> json
    roundTripped |> should equal Types.PagerDutyContextType.Link

[<Fact>]
let ``PagerDutyContextType.Image round-trips`` () =
    let value = Types.PagerDutyContextType.Image
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PagerDutyContextType> json
    roundTripped |> should equal Types.PagerDutyContextType.Image

[<Fact>]
let ``PagerDutyEventType.Trigger round-trips`` () =
    let value = Types.PagerDutyEventType.Trigger
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PagerDutyEventType> json
    roundTripped |> should equal Types.PagerDutyEventType.Trigger

[<Fact>]
let ``PagerDutyEventType.Resolve round-trips`` () =
    let value = Types.PagerDutyEventType.Resolve
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PagerDutyEventType> json
    roundTripped |> should equal Types.PagerDutyEventType.Resolve

[<Fact>]
let ``PagerDutyEventType.Acknowledge round-trips`` () =
    let value = Types.PagerDutyEventType.Acknowledge
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.PagerDutyEventType> json
    roundTripped |> should equal Types.PagerDutyEventType.Acknowledge

[<Fact>]
let ``Quantifier.Some round-trips`` () =
    let value = Types.Quantifier.Some
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Quantifier> json
    roundTripped |> should equal Types.Quantifier.Some

[<Fact>]
let ``Quantifier.All round-trips`` () =
    let value = Types.Quantifier.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.Quantifier> json
    roundTripped |> should equal Types.Quantifier.All

[<Fact>]
let ``ResponseContentType.Json round-trips`` () =
    let value = Types.ResponseContentType.Json
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ResponseContentType> json
    roundTripped |> should equal Types.ResponseContentType.Json

[<Fact>]
let ``ResponseContentType.Yaml round-trips`` () =
    let value = Types.ResponseContentType.Yaml
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ResponseContentType> json
    roundTripped |> should equal Types.ResponseContentType.Yaml

[<Fact>]
let ``ResponseContentType.Text round-trips`` () =
    let value = Types.ResponseContentType.Text
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.ResponseContentType> json
    roundTripped |> should equal Types.ResponseContentType.Text

[<Fact>]
let ``WatcherMetric.All round-trips`` () =
    let value = Types.WatcherMetric.All
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherMetric> json
    roundTripped |> should equal Types.WatcherMetric.All

[<Fact>]
let ``WatcherMetric.QueuedWatches round-trips`` () =
    let value = Types.WatcherMetric.QueuedWatches
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherMetric> json
    roundTripped |> should equal Types.WatcherMetric.QueuedWatches

[<Fact>]
let ``WatcherMetric.CurrentWatches round-trips`` () =
    let value = Types.WatcherMetric.CurrentWatches
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherMetric> json
    roundTripped |> should equal Types.WatcherMetric.CurrentWatches

[<Fact>]
let ``WatcherMetric.PendingWatches round-trips`` () =
    let value = Types.WatcherMetric.PendingWatches
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherMetric> json
    roundTripped |> should equal Types.WatcherMetric.PendingWatches

[<Fact>]
let ``WatcherState.Stopped round-trips`` () =
    let value = Types.WatcherState.Stopped
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherState> json
    roundTripped |> should equal Types.WatcherState.Stopped

[<Fact>]
let ``WatcherState.Starting round-trips`` () =
    let value = Types.WatcherState.Starting
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherState> json
    roundTripped |> should equal Types.WatcherState.Starting

[<Fact>]
let ``WatcherState.Started round-trips`` () =
    let value = Types.WatcherState.Started
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherState> json
    roundTripped |> should equal Types.WatcherState.Started

[<Fact>]
let ``WatcherState.Stopping round-trips`` () =
    let value = Types.WatcherState.Stopping
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.WatcherState> json
    roundTripped |> should equal Types.WatcherState.Stopping

[<Fact>]
let ``XPackCategory.Build round-trips`` () =
    let value = Types.XPackCategory.Build
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.XPackCategory> json
    roundTripped |> should equal Types.XPackCategory.Build

[<Fact>]
let ``XPackCategory.Features round-trips`` () =
    let value = Types.XPackCategory.Features
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.XPackCategory> json
    roundTripped |> should equal Types.XPackCategory.Features

[<Fact>]
let ``XPackCategory.License round-trips`` () =
    let value = Types.XPackCategory.License
    let json = Json.serialize value
    let roundTripped = Json.deserialize<Types.XPackCategory> json
    roundTripped |> should equal Types.XPackCategory.License

