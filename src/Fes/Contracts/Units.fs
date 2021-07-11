namespace Fes.DSL.Units

open Fleece.SystemTextJson

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
        
        static member ToJson value =
            value |> (string >> JString)