namespace Fes.Tests

open System
open System.Threading.Tasks
open Xunit
open Fes

/// Tests for core utility modules: Result, TaskResult, TaskHelpers, Prelude (konst/strings)
module CoreModuleTests =

    // ==========================================================================
    // Result module
    // ==========================================================================

    module ResultTests =

        [<Fact>]
        let ``Result.retn wraps value in Ok`` () =
            let result = Result.retn 42
            Assert.Equal(Ok 42, result)

        [<Fact>]
        let ``Result.retn with string value`` () =
            let result = Result.retn "hello"
            Assert.Equal(Ok "hello", result)

        [<Fact>]
        let ``Result.ofChoice Choice1Of2 becomes Ok`` () =
            let choice = Choice1Of2 42
            let result = Result.ofChoice choice
            Assert.Equal(Ok 42, result)

        [<Fact>]
        let ``Result.ofChoice Choice2Of2 becomes Error`` () =
            let choice = Choice2Of2 "error"
            let result = Result.ofChoice choice
            Assert.Equal(Error "error", result)

    // ==========================================================================
    // TaskHelpers module
    // ==========================================================================

    module TaskHelpersTests =

        [<Fact>]
        let ``TaskHelpers.retn creates completed task`` () =
            let t = TaskHelpers.retn 42
            Assert.True(t.IsCompleted)
            Assert.Equal(42, t.Result)

        [<Fact>]
        let ``TaskHelpers.map transforms task result`` () =
            let t = Task.FromResult(10)
            let mapped = TaskHelpers.map (fun x -> x * 2) t
            Assert.Equal(20, mapped.Result)

        [<Fact>]
        let ``TaskHelpers.bind chains tasks`` () =
            let t = Task.FromResult(5)
            let bound = TaskHelpers.bind (fun x -> Task.FromResult(x + 3)) t
            Assert.Equal(8, bound.Result)

        [<Fact>]
        let ``TaskHelpers.mapOut composes value transformation`` () =
            let fn : int -> Task<int> = fun x -> Task.FromResult(x + 1)
            let mapped = TaskHelpers.mapOut (fun x -> x * 10) fn
            Assert.Equal(30, (mapped 2).Result)

        [<Fact>]
        let ``TaskHelpers.mapIn transforms input`` () =
            let fn : int -> Task<int> = fun x -> Task.FromResult(x + 1)
            let mapped = TaskHelpers.mapIn (fun (s: string) -> s.Length) fn
            Assert.Equal(4, (mapped "abc").Result)

    // ==========================================================================
    // TaskResult module
    // ==========================================================================

    module TaskResultTests =

        [<Fact>]
        let ``TaskResult.retn wraps value in Ok task`` () =
            let tr : TaskResult<int, string> = TaskResult.retn 42
            Assert.Equal(Ok 42, tr.Result)

        [<Fact>]
        let ``TaskResult.bind propagates Ok`` () =
            let tr = TaskResult.retn 5
            let result = TaskResult.bind (fun x -> TaskResult.retn (x * 2)) tr
            Assert.Equal(Ok 10, result.Result)

        [<Fact>]
        let ``TaskResult.bind short-circuits on Error`` () =
            let tr : TaskResult<int, string> = Task.FromResult(Error "fail")
            let mutable called = false
            let result = TaskResult.bind (fun _ -> called <- true; TaskResult.retn 0) tr
            Assert.False(called)
            Assert.Equal(Error "fail", result.Result)

        [<Fact>]
        let ``TaskResult.map transforms Ok value`` () =
            let tr = TaskResult.retn 3
            let result = TaskResult.map (fun x -> x + 1) tr
            Assert.Equal(Ok 4, result.Result)

        [<Fact>]
        let ``TaskResult.map does not transform Error`` () =
            let tr : TaskResult<int, string> = Task.FromResult(Error "oops")
            let mutable called = false
            let result = TaskResult.map (fun x -> called <- true; x + 1) tr
            Assert.False(called)
            Assert.Equal(Error "oops", result.Result)

        [<Fact>]
        let ``TaskResult.mapError transforms Error value`` () =
            let tr : TaskResult<int, string> = Task.FromResult(Error "bad")
            let result = TaskResult.mapError (fun e -> e.Length) tr
            Assert.Equal(Error 3, result.Result)

        [<Fact>]
        let ``TaskResult.mapError does not affect Ok`` () =
            let tr : TaskResult<int, string> = TaskResult.retn 7
            let mutable called = false
            let result = TaskResult.mapError (fun _ -> called <- true; 0) tr
            Assert.False(called)
            Assert.Equal(Ok 7, result.Result)

        [<Fact>]
        let ``TaskResult.ofTask wraps successful task in Ok`` () =
            let t = Task.FromResult(99)
            let result = TaskResult.ofTask t
            Assert.Equal(Ok 99, result.Result)

        [<Fact>]
        let ``TaskResult.ofTask wraps thrown exception in Error`` () =
            let t : Task<int> = Task.FromException<int>(InvalidOperationException("test error"))
            let result = TaskResult.ofTask t
            match result.Result with
            | Error ex -> Assert.Contains("test error", ex.Message)
            | Ok _ -> Assert.Fail("Expected Error but got Ok")

        [<Fact>]
        let ``TaskResult.ofChoice Choice1Of2 becomes Ok`` () =
            let t = Task.FromResult(Choice1Of2 42)
            let result = TaskResult.ofChoice t
            Assert.Equal(Ok 42, result.Result)

        [<Fact>]
        let ``TaskResult.ofChoice Choice2Of2 becomes Error`` () =
            let t = Task.FromResult(Choice2Of2 "err")
            let result : TaskResult<int, string> = TaskResult.ofChoice t
            Assert.Equal(Error "err", result.Result)

    // ==========================================================================
    // Prelude: konst and Strings
    // ==========================================================================

    module PreludeTests =

        [<Fact>]
        let ``konst always returns first argument`` () =
            let f = konst 42
            Assert.Equal(42, f "ignored")
            Assert.Equal(42, f 999)
            Assert.Equal(42, f ())

        [<Fact>]
        let ``konst works with different types`` () =
            let f = konst "hello"
            Assert.Equal("hello", f 0)
            Assert.Equal("hello", f true)

    module StringsTests =

        [<Fact>]
        let ``joinByChar joins strings with separator`` () =
            let result = joinByChar ',' [| "a"; "b"; "c" |]
            Assert.Equal("a,b,c", result)

        [<Fact>]
        let ``joinByChar with empty array returns empty string`` () =
            let result = joinByChar ',' [||]
            Assert.Equal("", result)

        [<Fact>]
        let ``joinByChar with single element returns that element`` () =
            let result = joinByChar '/' [| "only" |]
            Assert.Equal("only", result)
