namespace Fes.DSL

open System.Text.RegularExpressions
open Fleece

module TimeUnits =
    [<Measure>] type d
    [<Measure>] type h
    [<Measure>] type m
    [<Measure>] type s
    [<Measure>] type ms
    [<Measure>] type micros
    [<Measure>] type nanos
    
type TimeoutUnit =
| Days of int<TimeUnits.d>
| Hours of int<TimeUnits.h>
| Minutes of int<TimeUnits.m>
| Seconds of int<TimeUnits.s>
| Milliseconds of int<TimeUnits.ms>
| Microseconds of int<TimeUnits.micros>
| Nanoseconds of int<TimeUnits.nanos>
with
    override x.ToString() =
        let inline _format (v, m) = $"%i{v}%s{m}"
        x
        |> ((function
           | TimeoutUnit.Days d -> int d, "d"
           | TimeoutUnit.Hours h -> int h, "h"
           | TimeoutUnit.Minutes m -> int m, "m"
           | TimeoutUnit.Seconds s -> int s, "s"
           | TimeoutUnit.Milliseconds ms -> int ms, "ms"
           | TimeoutUnit.Microseconds micros -> int micros, "micros"
           | TimeoutUnit.Nanoseconds nanos -> int nanos, "nanos")
           >> _format)

[<RequireQualifiedAccess>]
module TimeoutUnit =
    let unitRegex = Regex("^(\d{1,})(d|h|m|s|ms|micros|nanos)$", RegexOptions.Compiled ||| RegexOptions.Singleline)
    
type TimeoutUnit
with
    static member ofString value =
        let parse (rexMatch: Match) =
            if not <| rexMatch.Success
            then Error "Invalid value"
            else
                let value = int rexMatch.Groups[0].Value
                let measure = rexMatch.Groups[1].Value
                
                match measure with
                | "d" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.d> value
                    |> TimeoutUnit.Days
                    |> Ok
                | "h" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.h> value
                    |> TimeoutUnit.Hours
                    |> Ok
                | "m" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.m> value
                    |> TimeoutUnit.Minutes
                    |> Ok
                | "s" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.s> value
                    |> TimeoutUnit.Seconds
                    |> Ok
                | "ms" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.ms> value
                    |> TimeoutUnit.Milliseconds
                    |> Ok
                | "micros" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.micros> value
                    |> TimeoutUnit.Microseconds
                    |> Ok
                | "nanos" ->
                    LanguagePrimitives.Int32WithMeasure<TimeUnits.nanos> value
                    |> TimeoutUnit.Nanoseconds
                    |> Ok
                | invalid -> Error <| sprintf "Invalid value '%s'." invalid
        
        string value
        |> TimeoutUnit.unitRegex.Match
        |> parse
    
    static member ToJson value =
        value |> (string >> JString)

    static member OfJson value =
        match TimeoutUnit.ofString value with
        | Ok v -> Decode.Success v
        | Error _ ->  Decode.Fail.invalidValue value "Invalid value"
        
    static member get_Codec () = TimeoutUnit.OfJson <-> TimeoutUnit.ToJson