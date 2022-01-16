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
            let mkFieldsOrProps (fs: (string * FieldType) []) =
                let mkFieldOrProp (key: string, value: FieldType) =
                    (key, jobj [ "type" .= (toJson value) ])

                fs
                |> Seq.map mkFieldOrProp
                |> Array.ofSeq
                |> PropertyList

            match fieldMapping with
            | Analyzer value -> ("analyzer", toJson value)
            | Boost value -> ("boost", toJson value)
            | Coerce value -> ("coerce", toJson value)
            | CopyTo value -> ("copy_to", toJson value)
            | DocValues value -> ("doc_values", toJson value)
            | Dynamic value -> ("dynamic", toJson value)
            | EagerGlobalOrdinals value -> ("eager_global_ordinals", toJson value)
            | Enabled value -> ("enabled", toJson value)
            | FieldData value -> ("fieldata", toJson value)
            | Format value -> ("format", toJson value)
            | IgnoreAbove value -> ("ignore_above", toJson value)
            | IgnoreMalformed value -> ("ignore_malformed", toJson value)
            | IndexOptions value -> ("index_options", toJson value)
            | IndexPhrases value -> ("index_phrases", toJson value)
            | Index value -> ("index", toJson value)
            | Normalizer value -> ("normalizer", toJson value)
            | Norms value -> ("norms", toJson value)
            | NullValue value -> ("null_value", toJson value)
            | PositionIncrementGap value -> ("position_increment_gap", toJson value)
            | SearchAnalyzer value -> ("search_analyzer", toJson value)
            | Similarity value -> ("similarity", toJson value)
            | Store value -> ("store", toJson value)
            | TermVector value -> ("term_vector", toJson value)
            | Meta value -> ("meta", toJson (Array.ofSeq value))
            | IndexPrefixes (min, max) ->
                ("index_prefixes",
                 jobj [ "min_chars" .= min
                        "max_chars" .= max ])
            | Fields value -> ("fields", toJson (mkFieldsOrProps value))
            | Properties value -> ("properties", toJson (mkFieldsOrProps value))
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
