namespace Fes.DSL

open System
open Fleece
open Fleece.SystemTextJson
open Fes.DSL.Fields

module Mapping =

    type IndexOptions =
        | Docs
        | Freqs
        | Positions
        | Offsets
        static member ToJson indexOptions =
            match indexOptions with
            | Docs -> "docs"
            | Freqs -> "freqs"
            | Positions -> "positions"
            | Offsets -> "offsets"
            |> JString

    type Similarity =
        | Boolean
        | BM25
        static member ToJson termVector =
            match termVector with
            | Boolean -> "boolean"
            | BM25 -> "bm25"
            |> JString

    type TermVector =
        | No
        | Yes
        | WithPositions
        | WithOffsets
        | WithPositionsOffsets
        | WithPositionsPayloads
        | WithPositionsOffsetsPayloads
        static member ToJson termVector =
            match termVector with
            | TermVector.No -> "no"
            | TermVector.Yes -> "yes"
            | TermVector.WithPositions -> "with_positions"
            | TermVector.WithOffsets -> "with_offsets"
            | TermVector.WithPositionsOffsets -> "with_positions_offsets"
            | TermVector.WithPositionsPayloads -> "with_positions_payloads"
            | TermVector.WithPositionsOffsetsPayloads -> "with_positions_offsets_payloads"
            |> JString

    type FieldMapping =
        | Analyzer of string
        | Boost of int32
        | Coerce of bool
        | CopyTo of string
        | DocValues of bool
        | Dynamic of bool
        | EagerGlobalOrdinals of bool
        | Enabled of bool
        | FieldData of bool
        | Fields of (string * FieldType) []
        | Format of Formats.DateFormat
        | IgnoreAbove of int
        | IgnoreMalformed of bool
        | IndexOptions of IndexOptions
        | IndexPhrases of bool
        | IndexPrefixes of int * int
        | Index of bool
        | Meta of seq<string * Encoding>
        | Normalizer of string
        | Norms of bool
        | NullValue of string
        | PositionIncrementGap of int
        | Properties of (string * FieldType) []
        | SearchAnalyzer of string
        | Similarity of Similarity
        | Store of bool
        | TermVector of TermVector
        static member ToPropertyList fieldMapping =
            let inline mkFieldsOrProps (fs: (string * FieldType) []) =
                let mkFieldOrProp (key: string, value: FieldType) =
                    (key, PropertyList [| "type", value |])

                fs
                |> Seq.map mkFieldOrProp
                |> Array.ofSeq
                |> PropertyList

            match fieldMapping with
            | Analyzer value -> ("analyzer", value :> obj)
            | Boost value -> ("boost", value :> obj)
            | Coerce value -> ("coerce", value :> obj)
            | CopyTo value -> ("copy_to", value :> obj)
            | DocValues value -> ("doc_values", value :> obj)
            | Dynamic value -> ("dynamic", value :> obj)
            | EagerGlobalOrdinals value -> ("eager_global_ordinals", value :> obj)
            | Enabled value -> ("enabled", value :> obj)
            | FieldData value -> ("fieldata", value :> obj)
            | Format value -> ("format", value :> obj)
            | IgnoreAbove value -> ("ignore_above", value :> obj)
            | IgnoreMalformed value -> ("ignore_malformed", value :> obj)
            | IndexOptions value -> ("index_options", value :> obj)
            | IndexPhrases value -> ("index_phrases", value :> obj)
            | Index value -> ("index", value :> obj)
            | Normalizer value -> ("normalizer", value :> obj)
            | Norms value -> ("norms", value :> obj)
            | NullValue value -> ("null_value", value :> obj)
            | PositionIncrementGap value -> ("position_increment_gap", value :> obj)
            | SearchAnalyzer value -> ("search_analyzer", value :> obj)
            | Similarity value -> ("similarity", value :> obj)
            | Store value -> ("store", value :> obj)
            | TermVector value -> ("term_vector", value :> obj)
            | Meta value ->  ("meta", (Array.ofSeq value) :> obj)
            | IndexPrefixes (min, max) -> ("index_prefixes", PropertyList [| "min_chars", min; "max_chars", max |])
            | Fields value -> ("fields", (mkFieldsOrProps value))
            | Properties value -> ("properties", (mkFieldsOrProps value))
            |> Array.singleton
            |> PropertyList

type MappingDefinition =
    { Name: string
      Type: FieldType
      Mappings: Mapping.FieldMapping [] }

type RuntimeMapping =
    { Name: string
      Type: FieldType
      Script: option<string> }
