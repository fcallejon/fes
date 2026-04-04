module Fes.Tests.HttpTests

open Xunit
open FsUnit.Xunit
open Fes

// ============================================================================
// Http.toQueryValue
// ============================================================================

[<Fact>]
let ``toQueryValue bool true returns lowercase true`` () =
    Http.toQueryValue true |> should equal "true"

[<Fact>]
let ``toQueryValue bool false returns lowercase false`` () =
    Http.toQueryValue false |> should equal "false"

[<Fact>]
let ``toQueryValue string returns string`` () =
    Http.toQueryValue "hello" |> should equal "hello"

[<Fact>]
let ``toQueryValue int returns string`` () =
    Http.toQueryValue 42 |> should equal "42"

[<Fact>]
let ``toQueryValue string list returns comma-separated`` () =
    Http.toQueryValue ["a"; "b"; "c"] |> should equal "a,b,c"

[<Fact>]
let ``toQueryValue empty string list returns empty string`` () =
    Http.toQueryValue ([] : string list) |> should equal ""

[<Fact>]
let ``toQueryValue single-element string list returns element`` () =
    Http.toQueryValue ["only"] |> should equal "only"

[<Fact>]
let ``toQueryValue int list returns comma-separated`` () =
    Http.toQueryValue [1; 2; 3] |> should equal "1,2,3"

// ============================================================================
// Http.toPathSegment
// ============================================================================

[<Fact>]
let ``toPathSegment string returns string`` () =
    Http.toPathSegment "my-index" |> should equal "my-index"

[<Fact>]
let ``toPathSegment string list returns comma-separated`` () =
    Http.toPathSegment (box ["idx1"; "idx2"; "idx3"]) |> should equal "idx1,idx2,idx3"

[<Fact>]
let ``toPathSegment empty string list returns empty string`` () =
    Http.toPathSegment (box ([] : string list)) |> should equal ""

[<Fact>]
let ``toPathSegment single-element string list returns element`` () =
    Http.toPathSegment (box ["only"]) |> should equal "only"

[<Fact>]
let ``toPathSegment int list returns comma-separated`` () =
    Http.toPathSegment (box [10; 20; 30]) |> should equal "10,20,30"
