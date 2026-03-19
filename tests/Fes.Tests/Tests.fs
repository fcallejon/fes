module Tests

open System
open System.Threading.Tasks
open Xunit
open Fes

module TaskResultTeeTests =

    [<Fact>]
    let ``teeOk calls side effect for Ok value`` () =
        let mutable called = false
        let result = TaskResult.retn 42 |> TaskResult.teeOk (fun x -> called <- true; Assert.Equal(42, x))
        Assert.Equal(Ok 42, result.Result)
        Assert.True(called)

    [<Fact>]
    let ``teeOk does not call side effect for Error value`` () =
        let mutable called = false
        let result : TaskResult<int, string> =
            Task.FromResult(Error "err") |> TaskResult.teeOk (fun _ -> called <- true)
        Assert.Equal(Error "err", result.Result)
        Assert.False(called)

    [<Fact>]
    let ``teeOk passes original value through unchanged`` () =
        let result = TaskResult.retn "hello" |> TaskResult.teeOk (fun _ -> ())
        Assert.Equal(Ok "hello", result.Result)

    [<Fact>]
    let ``teeError calls side effect for Error value`` () =
        let mutable called = false
        let result : TaskResult<int, string> =
            Task.FromResult(Error "oops") |> TaskResult.teeError (fun e -> called <- true; Assert.Equal("oops", e))
        Assert.Equal(Error "oops", result.Result)
        Assert.True(called)

    [<Fact>]
    let ``teeError does not call side effect for Ok value`` () =
        let mutable called = false
        let result = TaskResult.retn 1 |> TaskResult.teeError (fun _ -> called <- true)
        Assert.Equal(Ok 1, result.Result)
        Assert.False(called)

    [<Fact>]
    let ``teeError passes original error through unchanged`` () =
        let result : TaskResult<int, string> =
            Task.FromResult(Error "fail") |> TaskResult.teeError (fun _ -> ())
        Assert.Equal(Error "fail", result.Result)

module TaskResultIgnoreTests =

    [<Fact>]
    let ``ignore maps Ok value to unit`` () =
        let result = TaskResult.retn 42 |> TaskResult.ignore
        Assert.Equal(Ok (), result.Result)

    [<Fact>]
    let ``ignore preserves Error channel`` () =
        let result : TaskResult<unit, string> =
            Task.FromResult(Error "err") |> TaskResult.ignore
        Assert.Equal(Error "err", result.Result)