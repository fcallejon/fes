namespace Fes.Tests

open System
open System.Threading.Tasks
open Xunit
open Fes

/// Tests for TaskResult composition helpers: mapIn, mapOut, bindIn, bindOut, after.
/// These functions are used in the core ElasticsearchClient.execute pipeline.
module TaskResultCompositionTests =

    // ==========================================================================
    // TaskResult.mapIn — transforms the input type of a function
    // ==========================================================================

    [<Fact>]
    let ``TaskResult.mapIn transforms input before calling function`` () =
        let fn : int -> TaskResult<int, exn> = fun x -> TaskResult.retn (x * 2)
        let adapted = TaskResult.mapIn (fun (s: string) -> s.Length) fn
        let result = (adapted "hello").Result
        Assert.Equal(Ok 10, result)

    [<Fact>]
    let ``TaskResult.mapIn propagates Error from underlying function`` () =
        let err = exn "fail"
        let fn : int -> TaskResult<int, exn> = fun _ -> Task.FromResult(Error err)
        let adapted = TaskResult.mapIn (fun (s: string) -> s.Length) fn
        let result = (adapted "abc").Result
        match result with
        | Error ex -> Assert.Equal("fail", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")

    // ==========================================================================
    // TaskResult.mapOut — transforms the output type of a function
    // ==========================================================================

    [<Fact>]
    let ``TaskResult.mapOut transforms the Ok result`` () =
        let fn : int -> TaskResult<int, exn> = fun x -> TaskResult.retn (x + 1)
        let adapted = TaskResult.mapOut (fun x -> x * 10) fn
        let result = (adapted 4).Result
        Assert.Equal(Ok 50, result)

    [<Fact>]
    let ``TaskResult.mapOut does not affect Error result`` () =
        let mutable called = false
        let err = exn "fail"
        let fn : int -> TaskResult<int, exn> = fun _ -> Task.FromResult(Error err)
        let adapted = TaskResult.mapOut (fun x -> called <- true; x * 10) fn
        let result = (adapted 0).Result
        Assert.False(called)
        match result with
        | Error ex -> Assert.Equal("fail", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")

    // ==========================================================================
    // TaskResult.bindIn — chains with a TaskResult-producing input transformer
    // ==========================================================================

    [<Fact>]
    let ``TaskResult.bindIn chains input transformation and function`` () =
        let inputFn : string -> TaskResult<int, exn> = fun s -> TaskResult.retn s.Length
        let fn : int -> TaskResult<string, exn> = fun n -> TaskResult.retn (String.replicate n "x")
        let combined = TaskResult.bindIn inputFn fn
        let result = (combined "hello").Result
        Assert.Equal(Ok "xxxxx", result)

    [<Fact>]
    let ``TaskResult.bindIn short-circuits when inputFn returns Error`` () =
        let mutable fnCalled = false
        let err = exn "input error"
        let inputFn : string -> TaskResult<int, exn> = fun _ -> Task.FromResult(Error err)
        let fn : int -> TaskResult<string, exn> = fun _ -> fnCalled <- true; TaskResult.retn "should not run"
        let combined = TaskResult.bindIn inputFn fn
        let result = (combined "abc").Result
        Assert.False(fnCalled)
        match result with
        | Error ex -> Assert.Equal("input error", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")

    // ==========================================================================
    // TaskResult.bindOut — chains the output of a function into another
    // ==========================================================================

    [<Fact>]
    let ``TaskResult.bindOut chains two TaskResult-returning functions`` () =
        let fn : int -> TaskResult<int, exn> = fun x -> TaskResult.retn (x + 1)
        let next : int -> TaskResult<string, exn> = fun n -> TaskResult.retn (string n)
        let combined = TaskResult.bindOut next fn
        let result = (combined 4).Result
        Assert.Equal(Ok "5", result)

    [<Fact>]
    let ``TaskResult.bindOut short-circuits when first function returns Error`` () =
        let mutable nextCalled = false
        let err = exn "first error"
        let fn : int -> TaskResult<int, exn> = fun _ -> Task.FromResult(Error err)
        let next : int -> TaskResult<string, exn> = fun _ -> nextCalled <- true; TaskResult.retn "oops"
        let combined = TaskResult.bindOut next fn
        let result = (combined 0).Result
        Assert.False(nextCalled)
        match result with
        | Error ex -> Assert.Equal("first error", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")

    [<Fact>]
    let ``TaskResult.bindOut propagates Error from second function`` () =
        let err = exn "second error"
        let fn : int -> TaskResult<int, exn> = fun x -> TaskResult.retn (x + 1)
        let next : int -> TaskResult<string, exn> = fun _ -> Task.FromResult(Error err)
        let combined = TaskResult.bindOut next fn
        let result = (combined 0).Result
        match result with
        | Error ex -> Assert.Equal("second error", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")

    // ==========================================================================
    // TaskResult.after — calls a side-effect with input and result, returns result
    // ==========================================================================

    [<Fact>]
    let ``TaskResult.after calls side-effect with input and Ok result`` () =
        let mutable capturedInput = 0
        let mutable capturedOutput = 0
        let fn : int -> TaskResult<int, exn> = fun x -> TaskResult.retn (x * 2)
        let withSideEffect = TaskResult.after (fun (a, b) -> capturedInput <- a; capturedOutput <- b) fn
        let result = (withSideEffect 5).Result
        Assert.Equal(5, capturedInput)
        Assert.Equal(10, capturedOutput)
        Assert.Equal(Ok 10, result)

    [<Fact>]
    let ``TaskResult.after returns original Ok value unchanged`` () =
        let fn : int -> TaskResult<int, exn> = fun x -> TaskResult.retn (x + 1)
        let withSideEffect = TaskResult.after (fun _ -> ()) fn
        let result = (withSideEffect 3).Result
        Assert.Equal(Ok 4, result)

    [<Fact>]
    let ``TaskResult.after does not call side-effect on Error`` () =
        let mutable called = false
        let err = exn "fail"
        let fn : int -> TaskResult<int, exn> = fun _ -> Task.FromResult(Error err)
        let withSideEffect = TaskResult.after (fun _ -> called <- true) fn
        let result = (withSideEffect 0).Result
        Assert.False(called)
        match result with
        | Error ex -> Assert.Equal("fail", ex.Message)
        | Ok _ -> Assert.Fail("Expected Error but got Ok")
