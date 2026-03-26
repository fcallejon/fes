namespace Fes.Tests

open Fes
open Xunit

module PreludeTests =

    // -------------------------------------------------------------------------
    // teeOk
    // -------------------------------------------------------------------------

    [<Fact>]
    let ``teeOk calls f when result is Ok`` () =
        let mutable called = false
        let r = Ok 42
        let result = teeOk (fun _ -> called <- true) r
        Assert.True(called)
        Assert.Equal(r, result)

    [<Fact>]
    let ``teeOk passes the Ok value to f`` () =
        let mutable captured = 0
        let r = Ok 99
        teeOk (fun x -> captured <- x) r |> ignore
        Assert.Equal(99, captured)

    [<Fact>]
    let ``teeOk does not call f when result is Error`` () =
        let mutable called = false
        let r: Result<int, string> = Error "oops"
        let result = teeOk (fun _ -> called <- true) r
        Assert.False(called)
        Assert.Equal(r, result)

    [<Fact>]
    let ``teeOk returns the original result unchanged for Ok`` () =
        let r = Ok "hello"
        let result = teeOk ignore r
        Assert.Equal(r, result)

    [<Fact>]
    let ``teeOk returns the original result unchanged for Error`` () =
        let r: Result<string, int> = Error 5
        let result = teeOk ignore r
        Assert.Equal(r, result)

    // -------------------------------------------------------------------------
    // teeError
    // -------------------------------------------------------------------------

    [<Fact>]
    let ``teeError calls f when result is Error`` () =
        let mutable called = false
        let r: Result<int, string> = Error "bad"
        let result = teeError (fun _ -> called <- true) r
        Assert.True(called)
        Assert.Equal(r, result)

    [<Fact>]
    let ``teeError passes the Error value to f`` () =
        let mutable captured = ""
        let r: Result<int, string> = Error "failure"
        teeError (fun e -> captured <- e) r |> ignore
        Assert.Equal("failure", captured)

    [<Fact>]
    let ``teeError does not call f when result is Ok`` () =
        let mutable called = false
        let r = Ok 1
        let result = teeError (fun _ -> called <- true) r
        Assert.False(called)
        Assert.Equal(r, result)

    [<Fact>]
    let ``teeError returns the original result unchanged for Ok`` () =
        let r = Ok 42
        let result = teeError ignore r
        Assert.Equal(r, result)

    [<Fact>]
    let ``teeError returns the original result unchanged for Error`` () =
        let r: Result<int, exn> = Error (exn "err")
        let result = teeError ignore r
        Assert.Equal(r, result)
