namespace Fes.Tests

open Xunit
open Fes

module PreludeTests =

    [<Fact>]
    let ``teeOk calls f and returns Ok result unchanged`` () =
        let mutable called = false
        let mutable capturedValue = -1
        let f x = called <- true; capturedValue <- x
        let input = Ok 42
        let result = teeOk f input
        Assert.True(called, "f should have been called")
        Assert.Equal(42, capturedValue)
        Assert.Equal(input, result)

    [<Fact>]
    let ``teeOk does not call f for Error result`` () =
        let mutable called = false
        let f _ = called <- true
        let input: Result<int, string> = Error "oops"
        let result = teeOk f input
        Assert.False(called, "f should not have been called")
        Assert.Equal(input, result)

    [<Fact>]
    let ``teeError calls f and returns Error result unchanged`` () =
        let mutable called = false
        let mutable capturedValue = ""
        let f x = called <- true; capturedValue <- x
        let input: Result<int, string> = Error "boom"
        let result = teeError f input
        Assert.True(called, "f should have been called")
        Assert.Equal("boom", capturedValue)
        Assert.Equal(input, result)

    [<Fact>]
    let ``teeError does not call f for Ok result`` () =
        let mutable called = false
        let f _ = called <- true
        let input: Result<int, string> = Ok 1
        let result = teeError f input
        Assert.False(called, "f should not have been called")
        Assert.Equal(input, result)
