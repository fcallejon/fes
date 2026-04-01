namespace Fes.Tests

open System.Threading.Tasks
open Xunit
open Fes

module TaskResultTests =

    [<Fact>]
    let ``defaultValue returns value on Ok`` () =
        let result = TaskResult.retn 42 |> TaskResult.defaultValue 0
        Assert.Equal(42, result.Result)

    [<Fact>]
    let ``defaultValue returns default on Error`` () =
        let result : Task<int> =
            Task.FromResult(Error (exn "fail") : Result<int, exn>)
            |> TaskResult.defaultValue 99
        Assert.Equal(99, result.Result)

    [<Fact>]
    let ``defaultWith returns value on Ok`` () =
        let result = TaskResult.retn "hello" |> TaskResult.defaultWith (fun _ -> "fallback")
        Assert.Equal("hello", result.Result)

    [<Fact>]
    let ``defaultWith applies function on Error`` () =
        let result : Task<string> =
            Task.FromResult(Error "err" : Result<string, string>)
            |> TaskResult.defaultWith (fun e -> $"got: {e}")
        Assert.Equal("got: err", result.Result)

    [<Fact>]
    let ``toOption returns Some on Ok`` () =
        let result = TaskResult.retn 7 |> TaskResult.toOption
        Assert.Equal(Some 7, result.Result)

    [<Fact>]
    let ``toOption returns None on Error`` () =
        let result : Task<int option> =
            Task.FromResult(Error (exn "fail") : Result<int, exn>)
            |> TaskResult.toOption
        Assert.Equal(None, result.Result)

    [<Fact>]
    let ``catch recovers from Error`` () =
        let result : Task<Result<int, exn>> =
            Task.FromResult(Error (exn "bad") : Result<int, exn>)
            |> TaskResult.catch (fun _ -> TaskResult.retn 100)
        Assert.Equal(Ok 100, result.Result)

    [<Fact>]
    let ``catch passes through Ok unchanged`` () =
        let result =
            TaskResult.retn 5
            |> TaskResult.catch (fun _ -> TaskResult.retn 999)
        Assert.Equal(Ok 5, result.Result)
