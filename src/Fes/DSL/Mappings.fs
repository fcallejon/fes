namespace Fes.DSL.Mappings

open System
open Fes.DSL.Fields.Fields
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open Fes.DSL.Fields

module IdentityMetadata =
    type Index = string
    type Type = string
    type Id = string

module DocumentMetadata =
    type Source = string
    type Size = int64
    type DocCount = int64
    type Meta = string

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
        static member ToJson fieldMapping =
            let mkFieldsOrProps (fs: (string * FieldType) []) =
                let mkFieldOrProp (key: string, value: FieldType) = key, jobj [ "type" .= (toJson value) ]
                fs
                |> Seq.map mkFieldOrProp
                |> JsonObject

            match fieldMapping with
            | Analyzer value -> jobj [ "analyzer" .= value ]
            | Boost value -> jobj [ "boost" .= value ]
            | Coerce value -> jobj [ "coerce" .= value ]
            | CopyTo value -> jobj [ "copy_to" .= value ]
            | DocValues value -> jobj [ "doc_values" .= value ]
            | Dynamic value -> jobj [ "dynamic" .= value ]
            | EagerGlobalOrdinals value -> jobj [ "eager_global_ordinals" .= value ]
            | Enabled value -> jobj [ "enabled" .= value ]
            | FieldData value -> jobj [ "fieldata" .= value ]
            | Format value -> jobj [ "format" .= value ]
            | IgnoreAbove value -> jobj [ "ignore_above" .= value ]
            | IgnoreMalformed value -> jobj [ "ignore_malformed" .= value ]
            | IndexOptions value -> jobj [ "index_options" .= value ]
            | IndexPhrases value -> jobj [ "index_phrases" .= value ]
            | Index value -> jobj [ "index" .= value ]
            | Normalizer value -> jobj [ "normalizer" .= value ]
            | Norms value -> jobj [ "norms" .= value ]
            | NullValue value -> jobj [ "null_value" .= value ]
            | PositionIncrementGap value -> jobj [ "position_increment_gap" .= value ]
            | SearchAnalyzer value -> jobj [ "search_analyzer" .= value ]
            | Similarity value -> jobj [ "similarity" .= value ]
            | Store value -> jobj [ "store" .= value ]
            | TermVector value -> jobj [ "term_vector" .= value ]
            | Meta value -> jobj [ "meta" .= (Array.ofSeq value) ]
            | IndexPrefixes (min, max) ->
                jobj [ "index_prefixes"
                       .= jobj [ "min_chars" .= min
                                 "max_chars" .= max ] ]
            | Fields value -> jobj [ "fields" .= (mkFieldsOrProps value) ]
            | Properties value -> jobj [ "properties" .= (mkFieldsOrProps value) ]

type MappingDefinition =
    { Name: string
      Type: FieldType
      Mappings: Mapping.FieldMapping [] }

type RuntimeMapping =
    { Name: string
      Type: FieldType
      Script: option<string> }