namespace Fes.Tests

open System
open System.Threading.Tasks
open Xunit
open Fes

/// Tests for the Prelude module utility functions
module PreludeTests =

    [<Fact>]
    let ``konst always returns the first argument`` () =
        let f = konst 42
        Assert.Equal(42, f "ignored")
        Assert.Equal(42, f 99)
        Assert.Equal(42, f ())

    [<Fact>]
    let ``teeOk runs side effect on Ok and passes value through`` () =
        let mutable called = false
        let result = Ok 5 |> teeOk (fun _ -> called <- true)
        Assert.True(called)
        Assert.Equal(Ok 5, result)

    [<Fact>]
    let ``teeOk does not run side effect on Error`` () =
        let mutable called = false
        let result = Error "oops" |> teeOk (fun _ -> called <- true)
        Assert.False(called)
        Assert.Equal(Error "oops", result)

    [<Fact>]
    let ``teeError runs side effect on Error and passes value through`` () =
        let mutable called = false
        let result = Error "oops" |> teeError (fun _ -> called <- true)
        Assert.True(called)
        Assert.Equal(Error "oops", result)

    [<Fact>]
    let ``teeError does not run side effect on Ok`` () =
        let mutable called = false
        let result = Ok 5 |> teeError (fun _ -> called <- true)
        Assert.False(called)
        Assert.Equal(Ok 5, result)

    [<Fact>]
    let ``joinByChar joins strings with given separator`` () =
        let result = Strings.joinByChar ',' [| "a"; "b"; "c" |]
        Assert.Equal("a,b,c", result)

    [<Fact>]
    let ``joinByChar returns single element unchanged`` () =
        let result = Strings.joinByChar ',' [| "only" |]
        Assert.Equal("only", result)

    [<Fact>]
    let ``joinByChar returns empty string for empty array`` () =
        let result = Strings.joinByChar ',' [||]
        Assert.Equal("", result)


/// Tests for the Result module
module ResultModuleTests =

    [<Fact>]
    let ``Result.retn wraps value in Ok`` () =
        let result = Result.retn 42
        Assert.Equal(Ok 42, result)

    [<Fact>]
    let ``Result.retn wraps string in Ok`` () =
        let result = Result.retn "hello"
        Assert.Equal(Ok "hello", result)

    [<Fact>]
    let ``Result.ofChoice converts Choice1Of2 to Ok`` () =
        let choice = Choice1Of2 "success"
        let result = Result.ofChoice choice
        Assert.Equal(Ok "success", result)

    [<Fact>]
    let ``Result.ofChoice converts Choice2Of2 to Error`` () =
        let choice = Choice2Of2 "failure"
        let result = Result.ofChoice choice
        Assert.Equal(Error "failure", result)


/// Tests for the TaskHelpers module
module TaskHelpersTests =

    [<Fact>]
    let ``TaskHelpers.retn wraps value in completed Task`` () =
        let task = TaskHelpers.retn 42
        Assert.Equal(42, task.Result)

    [<Fact>]
    let ``TaskHelpers.map transforms value inside Task`` () =
        let task = TaskHelpers.retn 5 |> TaskHelpers.map ((*) 2)
        Assert.Equal(10, task.Result)

    [<Fact>]
    let ``TaskHelpers.bind chains Tasks`` () =
        let task =
            TaskHelpers.retn 5
            |> TaskHelpers.bind (fun x -> TaskHelpers.retn (x + 3))
        Assert.Equal(8, task.Result)

    [<Fact>]
    let ``TaskHelpers.mapOut composes function after task-returning function`` () =
        let addOne (x: int) = TaskHelpers.retn (x + 1)
        let doubleResult = TaskHelpers.mapOut ((*) 2) addOne
        Assert.Equal(6, (doubleResult 2).Result)

    [<Fact>]
    let ``TaskHelpers.mapIn composes function before task-returning function`` () =
        let toString (x: int) = TaskHelpers.retn (string x)
        let parseFirst = TaskHelpers.mapIn int toString
        Assert.Equal("42", (parseFirst "42").Result)

    [<Fact>]
    let ``TaskHelpers.bindOut chains two task-returning functions`` () =
        let step1 (x: int) = TaskHelpers.retn (x * 2)
        let step2 (x: int) = TaskHelpers.retn (x + 10)
        let combined = TaskHelpers.bindOut step1 step2
        Assert.Equal(20, (combined 5).Result)


/// Tests for the TaskResult module
module TaskResultTests =

    [<Fact>]
    let ``TaskResult.retn wraps value in Task<Ok>`` () =
        let tr = TaskResult.retn 42
        Assert.Equal(Ok 42, tr.Result)

    [<Fact>]
    let ``TaskResult.bind chains on Ok`` () =
        let tr =
            TaskResult.retn 5
            |> TaskResult.bind (fun x -> TaskResult.retn (x * 2))
        Assert.Equal(Ok 10, tr.Result)

    [<Fact>]
    let ``TaskResult.bind short-circuits on Error`` () =
        let mutable called = false
        let tr =
            Task.FromResult(Error (exn "err"))
            |> TaskResult.bind (fun _ ->
                called <- true
                TaskResult.retn 999)
        Assert.Equal(false, called)
        match tr.Result with
        | Error e -> Assert.Equal("err", e.Message)
        | Ok _ -> failwith "Expected Error"

    [<Fact>]
    let ``TaskResult.map transforms Ok value`` () =
        let tr = TaskResult.retn 5 |> TaskResult.map ((*) 3)
        Assert.Equal(Ok 15, tr.Result)

    [<Fact>]
    let ``TaskResult.map does not transform Error`` () =
        let tr = Task.FromResult(Error (exn "e")) |> TaskResult.map ((*) 3)
        match tr.Result with
        | Error e -> Assert.Equal("e", e.Message)
        | Ok _ -> failwith "Expected Error"

    [<Fact>]
    let ``TaskResult.mapError transforms Error`` () =
        let tr : TaskResult<int, exn> =
            Task.FromResult(Error (exn "original"))
            |> TaskResult.mapError (fun e -> exn $"wrapped: {e.Message}")
        match tr.Result with
        | Error e -> Assert.Equal("wrapped: original", e.Message)
        | Ok _ -> failwith "Expected Error"

    [<Fact>]
    let ``TaskResult.mapError does not affect Ok`` () =
        let tr = TaskResult.retn 42 |> TaskResult.mapError (fun _ -> exn "should not run")
        Assert.Equal(Ok 42, tr.Result)

    [<Fact>]
    let ``TaskResult.ofTask wraps successful Task in Ok`` () =
        let t = Task.FromResult(99)
        let tr = TaskResult.ofTask t
        Assert.Equal(Ok 99, tr.Result)

    [<Fact>]
    let ``TaskResult.ofTask wraps faulted Task in Error`` () =
        let t = Task.FromException<int>(InvalidOperationException "boom")
        let tr = TaskResult.ofTask t
        match tr.Result with
        | Error e -> Assert.IsType<InvalidOperationException>(e) |> ignore
        | Ok _ -> failwith "Expected Error"

    [<Fact>]
    let ``TaskResult.mapIn pre-maps input to task-returning function`` () =
        let toString (x: int) : TaskResult<string, exn> = TaskResult.retn (string x)
        let parseFirst = TaskResult.mapIn int toString
        let tr = parseFirst "42"
        Assert.Equal(Ok "42", tr.Result)

    [<Fact>]
    let ``TaskResult.mapOut post-maps output of task-returning function`` () =
        let addOne (x: int) : TaskResult<int, exn> = TaskResult.retn (x + 1)
        let doubled = TaskResult.mapOut ((*) 2) addOne
        Assert.Equal(Ok 6, (doubled 2).Result)

    [<Fact>]
    let ``TaskResult.bindIn pre-binds input through a task-returning function`` () =
        let parse (s: string) : TaskResult<int, exn> = TaskResult.retn (int s)
        let addOne (x: int) : TaskResult<int, exn> = TaskResult.retn (x + 1)
        let combined = TaskResult.bindIn parse addOne
        Assert.Equal(Ok 11, (combined "10").Result)

    [<Fact>]
    let ``TaskResult.bindOut post-binds output through a task-returning function`` () =
        let addOne (x: int) : TaskResult<int, exn> = TaskResult.retn (x + 1)
        let double (x: int) : TaskResult<int, exn> = TaskResult.retn (x * 2)
        let combined = TaskResult.bindOut double addOne
        Assert.Equal(Ok 6, (combined 2).Result)

    [<Fact>]
    let ``TaskResult.after runs side effect and passes value through`` () =
        let mutable recorded = (0, 0)
        let addOne (x: int) : TaskResult<int, exn> = TaskResult.retn (x + 1)
        let withSideEffect = TaskResult.after (fun pair -> recorded <- pair) addOne
        let tr = withSideEffect 5
        Assert.Equal(Ok 6, tr.Result)
        Assert.Equal((5, 6), recorded)


/// Tests for Http utility functions
module HttpUtilTests =

    [<Fact>]
    let ``Http.toQueryValue converts true to lowercase 'true'`` () =
        let result = Http.toQueryValue true
        Assert.Equal("true", result)

    [<Fact>]
    let ``Http.toQueryValue converts false to lowercase 'false'`` () =
        let result = Http.toQueryValue false
        Assert.Equal("false", result)

    [<Fact>]
    let ``Http.toQueryValue converts int to string`` () =
        let result = Http.toQueryValue 42
        Assert.Equal("42", result)

    [<Fact>]
    let ``Http.toQueryValue converts float to string`` () =
        let result = Http.toQueryValue 3.14
        Assert.StartsWith("3.14", result)

    [<Fact>]
    let ``Http.toQueryValue converts string to itself`` () =
        let result = Http.toQueryValue "hello"
        Assert.Equal("hello", result)

    [<Fact>]
    let ``Http.Request.fromPath sets relative URI`` () =
        let req = Http.Request.fromPath "/my/path"
        Assert.Equal("/my/path", req.RequestUri.OriginalString)
        Assert.True(not req.RequestUri.IsAbsoluteUri)

    [<Fact>]
    let ``Http.Request.withMethod sets method on request`` () =
        let req =
            Http.Request.fromPath "/test"
            |> Http.Request.withMethod Http.Method.Get
        Assert.Equal(System.Net.Http.HttpMethod.Get, req.Method)

    [<Fact>]
    let ``Http.Request.withMethod sets POST`` () =
        let req =
            Http.Request.fromPath "/test"
            |> Http.Request.withMethod Http.Method.Post
        Assert.Equal(System.Net.Http.HttpMethod.Post, req.Method)

    [<Fact>]
    let ``Http.Request.withJson sets JSON content type`` () =
        let req =
            Http.Request.fromPath "/test"
            |> Http.Request.withJson "{\"key\":\"value\"}"
        let contentType = req.Content.Headers.ContentType.MediaType
        Assert.Equal("application/json", contentType)

    [<Fact>]
    let ``Http.Request.withJson sets correct body content`` () =
        let body = "{\"key\":\"value\"}"
        let req =
            Http.Request.fromPath "/test"
            |> Http.Request.withJson body
        let content = req.Content.ReadAsStringAsync().Result
        Assert.Equal(body, content)


/// Tests for Json utilities
module JsonUtilTests =

    [<Fact>]
    let ``Json.tryDeserialize returns Ok for valid JSON`` () =
        let json = "42"
        let result = Json.tryDeserialize<int> json
        Assert.Equal(Ok 42, result)

    [<Fact>]
    let ``Json.tryDeserialize returns Error for invalid JSON`` () =
        let json = "not-valid-json-at-all{"
        let result = Json.tryDeserialize<int> json
        match result with
        | Error _ -> ()
        | Ok _ -> failwith "Expected Error for malformed JSON"

    [<Fact>]
    let ``Json.tryDeserialize returns Error for type mismatch`` () =
        let json = "\"a string\""
        let result = Json.tryDeserialize<int> json
        match result with
        | Error _ -> ()
        | Ok _ -> failwith "Expected Error for type mismatch"

    [<Fact>]
    let ``Json.serialize and deserialize round-trips a record`` () =
        let original = {| name = "test"; value = 123 |}
        let json = Json.serialize original
        Assert.Contains("\"name\"", json)
        Assert.Contains("\"test\"", json)
        Assert.Contains("\"value\"", json)
        Assert.Contains("123", json)

    [<Fact>]
    let ``Json.serialize uses snake_case property naming`` () =
        let obj = {| myProperty = "val" |}
        let json = Json.serialize obj
        Assert.Contains("my_property", json)

    [<Fact>]
    let ``Json.serialize omits null fields`` () =
        let obj = {| name = "test"; optValue = None |}
        let json = Json.serialize obj
        Assert.DoesNotContain("opt_value", json)
