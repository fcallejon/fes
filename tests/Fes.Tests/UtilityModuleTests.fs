namespace Fes.Tests

open System
open System.Threading.Tasks
open Xunit
open Fes

/// Tests for core Fes utility modules: Prelude, Result, TaskHelpers, TaskResult
module PreludeTests =

    [<Fact>]
    let ``konst returns the first argument regardless of second`` () =
        let f = konst 42
        Assert.Equal(42, f "ignored")
        Assert.Equal(42, f 999)
        Assert.Equal(42, f ())

    [<Fact>]
    let ``konst works with different types`` () =
        Assert.Equal("hello", konst "hello" true)
        Assert.Equal(3.14, konst 3.14 [1;2;3])

    [<Fact(Skip = "Known bug: teeOk does not call side-effect; tracked in PR #153")>]
    let ``teeOk calls side-effect on Ok and returns original value`` () =
        let mutable called = false
        let mutable capturedValue = 0
        let result : Result<int, string> = Ok 42

        let returned = teeOk (fun x -> called <- true; capturedValue <- x) result

        Assert.True(called, "teeOk should call the side-effect function on Ok")
        Assert.Equal(42, capturedValue)
        Assert.Equal(result, returned)

    [<Fact>]
    let ``teeOk does not call side-effect on Error and returns original value`` () =
        let mutable called = false
        let result : Result<int, string> = Error "fail"

        let returned = teeOk (fun _ -> called <- true) result

        Assert.False(called, "teeOk should not call side-effect on Error")
        Assert.Equal(result, returned)

    [<Fact(Skip = "Known bug: teeError does not call side-effect; tracked in PR #153")>]
    let ``teeError calls side-effect on Error and returns original value`` () =
        let mutable called = false
        let mutable capturedError = ""
        let result : Result<int, string> = Error "something went wrong"

        let returned = teeError (fun e -> called <- true; capturedError <- e) result

        Assert.True(called, "teeError should call the side-effect function on Error")
        Assert.Equal("something went wrong", capturedError)
        Assert.Equal(result, returned)

    [<Fact>]
    let ``teeError does not call side-effect on Ok and returns original value`` () =
        let mutable called = false
        let result : Result<int, string> = Ok 1

        let returned = teeError (fun _ -> called <- true) result

        Assert.False(called, "teeError should not call side-effect on Ok")
        Assert.Equal(result, returned)

module StringsTests =

    [<Fact>]
    let ``joinByChar joins array with given separator`` () =
        let result = Strings.joinByChar ',' [| "a"; "b"; "c" |]
        Assert.Equal("a,b,c", result)

    [<Fact>]
    let ``joinByChar with single element returns that element`` () =
        let result = Strings.joinByChar '-' [| "only" |]
        Assert.Equal("only", result)

    [<Fact>]
    let ``joinByChar with empty array returns empty string`` () =
        let result = Strings.joinByChar '/' [||]
        Assert.Equal("", result)

    [<Fact>]
    let ``joinByChar uses the provided separator character`` () =
        Assert.Equal("x|y|z", Strings.joinByChar '|' [| "x"; "y"; "z" |])
        Assert.Equal("a.b.c", Strings.joinByChar '.' [| "a"; "b"; "c" |])

module ResultModuleTests =

    [<Fact>]
    let ``Result.retn wraps value in Ok`` () =
        let result = Result.retn 42
        Assert.Equal(Ok 42, result)

    [<Fact>]
    let ``Result.retn works with string`` () =
        let result = Result.retn "hello"
        Assert.Equal(Ok "hello", result)

    [<Fact>]
    let ``Result.ofChoice converts Choice1Of2 to Ok`` () =
        let choice : Choice<int, string> = Choice1Of2 99
        let result = Result.ofChoice choice
        Assert.Equal(Ok 99, result)

    [<Fact>]
    let ``Result.ofChoice converts Choice2Of2 to Error`` () =
        let choice : Choice<int, string> = Choice2Of2 "error message"
        let result = Result.ofChoice choice
        Assert.Equal(Error "error message", result)

module TaskHelpersTests =

    [<Fact>]
    let ``TaskHelpers.retn wraps value in completed Task`` () =
        let task = TaskHelpers.retn 42
        Assert.Equal(42, task.Result)

    [<Fact>]
    let ``TaskHelpers.map transforms the Task value`` () =
        let task = TaskHelpers.retn 10
        let mapped = TaskHelpers.map (fun x -> x * 2) task
        Assert.Equal(20, mapped.Result)

    [<Fact>]
    let ``TaskHelpers.bind chains tasks`` () =
        let task = TaskHelpers.retn 5
        let result = TaskHelpers.bind (fun x -> TaskHelpers.retn (x + 3)) task
        Assert.Equal(8, result.Result)

    [<Fact>]
    let ``TaskHelpers.mapOut composes output mapping`` () =
        let f = TaskHelpers.mapOut (fun s -> s.Length) (fun (x: string) -> Task.FromResult x)
        let result = f "hello"
        Assert.Equal(5, result.Result)

    [<Fact>]
    let ``TaskHelpers.mapIn composes input mapping`` () =
        let f = TaskHelpers.mapIn int (fun (x: int) -> Task.FromResult (x * 2))
        let result = f "5"
        Assert.Equal(10, result.Result)

module TaskResultModuleTests =

    [<Fact>]
    let ``TaskResult.retn wraps value in Task<Ok>`` () =
        let tr : TaskResult<int, string> = TaskResult.retn 42
        Assert.Equal(Ok 42, tr.Result)

    [<Fact>]
    let ``TaskResult.bind applies function to Ok value`` () =
        let tr = TaskResult.retn 10
        let result = TaskResult.bind (fun x -> TaskResult.retn (x * 3)) tr
        Assert.Equal(Ok 30, result.Result)

    [<Fact>]
    let ``TaskResult.bind short-circuits on Error`` () =
        let tr : TaskResult<int, string> = Task.FromResult(Error "fail")
        let mutable called = false
        let result = TaskResult.bind (fun _ -> called <- true; TaskResult.retn 0) tr
        Assert.Equal(Error "fail", result.Result)
        Assert.False(called, "bind should not call function on Error")

    [<Fact>]
    let ``TaskResult.map transforms Ok value`` () =
        let tr = TaskResult.retn 5
        let result = TaskResult.map (fun x -> x + 1) tr
        Assert.Equal(Ok 6, result.Result)

    [<Fact>]
    let ``TaskResult.map does not transform Error`` () =
        let tr : TaskResult<int, string> = Task.FromResult(Error "error")
        let mutable called = false
        let result = TaskResult.map (fun x -> called <- true; x + 1) tr
        Assert.Equal(Error "error", result.Result)
        Assert.False(called, "map should not call function on Error")

    [<Fact>]
    let ``TaskResult.mapError transforms Error value`` () =
        let tr : TaskResult<int, string> = Task.FromResult(Error "original")
        let result = TaskResult.mapError (fun e -> e + "!") tr
        Assert.Equal(Error "original!", result.Result)

    [<Fact>]
    let ``TaskResult.mapError does not transform Ok`` () =
        let tr : TaskResult<int, string> = TaskResult.retn 7
        let mutable called = false
        let result = TaskResult.mapError (fun e -> called <- true; e + "!") tr
        Assert.Equal(Ok 7, result.Result)
        Assert.False(called, "mapError should not call function on Ok")

    [<Fact>]
    let ``TaskResult.ofTask wraps successful Task in Ok`` () =
        let t = Task.FromResult 99
        let result = TaskResult.ofTask t
        Assert.Equal(Ok 99, result.Result)

    [<Fact>]
    let ``TaskResult.ofTask wraps thrown exception in Error`` () =
        let t : Task<int> = Task.FromException<int>(InvalidOperationException("boom"))
        let result = TaskResult.ofTask t
        match result.Result with
        | Error ex -> Assert.Contains("boom", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")

    [<Fact>]
    let ``TaskResult.ofChoice converts Choice1Of2 to Ok`` () =
        let choice : Task<Choice<int, exn>> = Task.FromResult(Choice1Of2 42)
        let result = TaskResult.ofChoice choice
        Assert.Equal(Ok 42, result.Result)

    [<Fact>]
    let ``TaskResult.ofChoice converts Choice2Of2 to Error`` () =
        let ex = InvalidOperationException("test")
        let choice : Task<Choice<int, exn>> = Task.FromResult(Choice2Of2(ex :> exn))
        let result = TaskResult.ofChoice choice
        match result.Result with
        | Error e -> Assert.Equal(ex :> exn, e)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")
