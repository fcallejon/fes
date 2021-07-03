namespace Fes.Contracts.Fields

module FieldTypes =
    open Fleece.SystemTextJson
    
    type Keywords =
        | Keyword
        | ConstantKeyword
        | Wildcard
        static member ToJson value =
            match value with
            | Keyword -> JString(string "keyword")
            | ConstantKeyword -> JString(string "constant_keyword")
            | Wildcard -> JString(string "wildcard")

        static member OfJson value =
            match value with
            | JString "keyword" -> Decode.Success Keyword
            | JString "constant_keyword" -> Decode.Success ConstantKeyword
            | JString "wildcard" -> Decode.Success Wildcard
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Keywords value: %s{x}"
            | x -> Decode.Fail.strExpected x

    type Numeric =
        | Long
        | Integer
        | Short
        | Byte
        | Double
        | Float
        | HalfFloat
        | ScaledFloat
        | UnsignedLong
        static member ToJson value =
            match value with
            | Long -> JString "long"
            | Integer -> JString "integer"
            | Short -> JString "short"
            | Byte -> JString "byte"
            | Double -> JString "double"
            | Float -> JString "float"
            | HalfFloat -> JString "half_float"
            | ScaledFloat -> JString "scaled_float"
            | UnsignedLong -> JString "unsigned_long"

        static member OfJson value =
            match value with
            | JString "long" -> Decode.Success Long
            | JString "integer" -> Decode.Success Integer
            | JString "short" -> Decode.Success Short
            | JString "byte" -> Decode.Success Byte
            | JString "double" -> Decode.Success Double
            | JString "float" -> Decode.Success Float
            | JString "half_float" -> Decode.Success HalfFloat
            | JString "scaled_float" -> Decode.Success ScaledFloat
            | JString "unsigned_long" -> Decode.Success UnsignedLong
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Numeric value: %s{x}"
            | x -> Decode.Fail.strExpected x

    type DateTypes =
        | Date
        | DateNanos
        static member OfJson value =
            match value with
            | JString "date" -> Decode.Success Date
            | JString "date_nanos" -> Decode.Success DateNanos
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Date value: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | Date -> JString "date"
            | DateNanos -> JString "date_nanos"

    type TextTypes =
        | Text
        | AnnotatedText
        | Completion
        | SearchAsYouType
        | TokenCount
        static member OfJson value =
            match value with
            | JString "text" -> Decode.Success Text
            | JString "annotated_text" -> Decode.Success AnnotatedText
            | JString "completion" -> Decode.Success Completion
            | JString "search_as_you_type" -> Decode.Success SearchAsYouType
            | JString "token_count" -> Decode.Success TokenCount
            | JString x as v -> Decode.Fail.invalidValue v $"Wrong Text value: %s{x}"
            | x -> Decode.Fail.strExpected x

        static member ToJson value =
            match value with
            | Text -> JString "text"
            | AnnotatedText -> JString "annotated_text"
            | Completion -> JString "completion"
            | SearchAsYouType -> JString "search_as_you_type"
            | TokenCount -> JString "token_count"

module Fields =
    open Fleece.SystemTextJson

    type FieldType =
        | Keywords of FieldTypes.Keywords
        | Text of FieldTypes.TextTypes
        | Numeric of FieldTypes.Numeric
        | Date of FieldTypes.DateTypes
        static member OfJson value =
            let fieldType =
                [| (FieldTypes.Keywords.OfJson value
                    |> Result.map FieldType.Keywords)
                   (FieldTypes.TextTypes.OfJson value
                    |> Result.map FieldType.Text)
                   (FieldTypes.Numeric.OfJson value
                    |> Result.map FieldType.Numeric)
                   (FieldTypes.DateTypes.OfJson value
                    |> Result.map FieldType.Date) |]
                |> Array.tryPick
                    (function
                    | Result.Ok ft -> Some ft
                    | _ -> None)

            match fieldType with
            | Some fieldType' -> Decode.Success fieldType'
            | _ -> Decode.Fail.invalidValue value (sprintf "Wrong Text value: %s" <| string value)

        static member ToJson value =
            match value with
            | Text text -> toJson text
            | Keywords keywords -> toJson keywords
            | Numeric numeric -> toJson numeric
            | Date date -> toJson date

//TODO: Add types from https://www.elastic.co/guide/en/elasticsearch/reference/current/mapping-types.html#structured-data-types
