namespace Fes.Tests

open Fes
open Xunit

module TaskResultTests =

    // -------------------------------------------------------------------------
    // teeOk
    // -------------------------------------------------------------------------

    [<Fact>]
    let ``teeOk calls side-effect on Ok value`` () =
        let mutable called = false
        let tr : TaskResult<int, exn> = TaskResult.retn 42
        let result = tr |> TaskResult.teeOk (fun _ -> called <- true) |> fun t -> t.Result
        Assert.True(called)
        Assert.Equal(Ok 42, result)

    [<Fact>]
    let ``teeOk does not call side-effect on Error`` () =
        let mutable called = false
        let tr : TaskResult<int, exn> = System.Threading.Tasks.Task.FromResult(Error (exn "boom"))
        let result = tr |> TaskResult.teeOk (fun _ -> called <- true) |> fun t -> t.Result
        Assert.False(called)
        Assert.True(Result.isError result)

    [<Fact>]
    let ``teeOk passes the correct value to side-effect`` () =
        let mutable seen = -1
        let tr : TaskResult<int, exn> = TaskResult.retn 99
        tr |> TaskResult.teeOk (fun v -> seen <- v) |> fun t -> t.Result |> ignore
        Assert.Equal(99, seen)

    // -------------------------------------------------------------------------
    // teeError
    // -------------------------------------------------------------------------

    [<Fact>]
    let ``teeError calls side-effect on Error value`` () =
        let mutable called = false
        let tr : TaskResult<int, exn> = System.Threading.Tasks.Task.FromResult(Error (exn "oops"))
        let result = tr |> TaskResult.teeError (fun _ -> called <- true) |> fun t -> t.Result
        Assert.True(called)
        Assert.True(Result.isError result)

    [<Fact>]
    let ``teeError does not call side-effect on Ok`` () =
        let mutable called = false
        let tr : TaskResult<int, exn> = TaskResult.retn 1
        let result = tr |> TaskResult.teeError (fun _ -> called <- true) |> fun t -> t.Result
        Assert.False(called)
        Assert.Equal(Ok 1, result)

    [<Fact>]
    let ``teeError passes the correct error to side-effect`` () =
        let expected = exn "failure"
        let mutable seen : exn option = None
        let tr : TaskResult<int, exn> = System.Threading.Tasks.Task.FromResult(Error expected)
        tr |> TaskResult.teeError (fun e -> seen <- Some e) |> fun t -> t.Result |> ignore
        Assert.Equal(Some expected, seen)

    // -------------------------------------------------------------------------
    // ignore
    // -------------------------------------------------------------------------

    [<Fact>]
    let ``ignore maps Ok value to unit`` () =
        let tr : TaskResult<int, exn> = TaskResult.retn 42
        let result = tr |> TaskResult.ignore |> fun t -> t.Result
        Assert.Equal(Ok (), result)

    [<Fact>]
    let ``ignore preserves Error`` () =
        let err = exn "error"
        let tr : TaskResult<int, exn> = System.Threading.Tasks.Task.FromResult(Error err)
        let result = tr |> TaskResult.ignore |> fun t -> t.Result
        Assert.Equal(Error err, result)
