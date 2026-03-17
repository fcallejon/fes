module Tests

open System
open Xunit
open Fes

module PreludeTests =

    [<Fact>]
    let ``teeOk calls side effect for Ok value`` () =
        let mutable called = false
        let result = Ok 42 |> teeOk (fun x -> called <- true; Assert.Equal(42, x))
        Assert.True(called)
        Assert.Equal(Ok 42, result)

    [<Fact>]
    let ``teeOk does not call side effect for Error value`` () =
        let mutable called = false
        let result : Result<int, string> = Error "err" |> teeOk (fun _ -> called <- true)
        Assert.False(called)
        Assert.Equal(Error "err", result)

    [<Fact>]
    let ``teeOk returns original result unchanged`` () =
        let result = Ok "hello" |> teeOk (fun _ -> ())
        Assert.Equal(Ok "hello", result)

    [<Fact>]
    let ``teeError calls side effect for Error value`` () =
        let mutable called = false
        let result : Result<int, string> = Error "oops" |> teeError (fun e -> called <- true; Assert.Equal("oops", e))
        Assert.True(called)
        Assert.Equal(Error "oops", result)

    [<Fact>]
    let ``teeError does not call side effect for Ok value`` () =
        let mutable called = false
        let result = Ok 1 |> teeError (fun _ -> called <- true)
        Assert.False(called)
        Assert.Equal(Ok 1, result)

    [<Fact>]
    let ``teeError returns original result unchanged`` () =
        let result : Result<unit, string> = Error "fail" |> teeError (fun _ -> ())
        Assert.Equal(Error "fail", result)