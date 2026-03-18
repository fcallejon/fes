namespace Fes.Tests

open Fes
open Fes.DSL.Models.Types
open Xunit

/// Tests for JsonRes.ofString and Http.toQueryValue utility functions.
module JsonResAndHttpUtilsTests =

    // =========================================================================
    // JsonRes.ofString tests
    // =========================================================================

    [<Fact>]
    let ``JsonRes.ofString succeeds for valid JSON`` () =
        let json = "\"deleted\""
        let result = JsonRes.ofString<Result> json |> fun t -> t.Result
        match result with
        | Ok v -> Assert.Equal(Result.Deleted, v)
        | Error e -> failwith $"Expected Ok but got Error: {e}"

    [<Fact>]
    let ``JsonRes.ofString returns Error for invalid JSON`` () =
        let json = "\"not_a_valid_result\""
        let result = JsonRes.ofString<Result> json |> fun t -> t.Result
        match result with
        | Ok _ -> failwith "Expected Error but got Ok"
        | Error _ -> () // expected

    [<Fact>]
    let ``JsonRes.ofString returns Error for malformed JSON`` () =
        let json = "{ this is not json }"
        let result = JsonRes.ofString<Result> json |> fun t -> t.Result
        match result with
        | Ok _ -> failwith "Expected Error but got Ok"
        | Error _ -> () // expected

    [<Fact>]
    let ``JsonRes.ofString deserializes a record type correctly`` () =
        let json = """{"acknowledged":true,"shards_acknowledged":true,"index":"my_index"}"""
        let result = JsonRes.ofString<DSL.Operations.IndicesCreateResponse> json |> fun t -> t.Result
        match result with
        | Ok r ->
            Assert.True(r.Acknowledged)
            Assert.Equal("my_index", string r.Index)
        | Error e -> failwith $"Expected Ok but got Error: {e}"

    // =========================================================================
    // Http.toQueryValue tests
    // =========================================================================

    [<Fact>]
    let ``toQueryValue converts true to lowercase "true"`` () =
        let result = Http.toQueryValue true
        Assert.Equal("true", result)

    [<Fact>]
    let ``toQueryValue converts false to lowercase "false"`` () =
        let result = Http.toQueryValue false
        Assert.Equal("false", result)

    [<Fact>]
    let ``toQueryValue converts integer to string`` () =
        let result = Http.toQueryValue 42
        Assert.Equal("42", result)

    [<Fact>]
    let ``toQueryValue converts string to itself`` () =
        let result = Http.toQueryValue "hello"
        Assert.Equal("hello", result)
