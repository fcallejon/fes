module Fes.Tests.TransportTests

open Xunit
open FsUnit.Xunit
open Fes
open Elastic.Transport

[<Fact>]
let ``ES.connect creates a transport`` () =
    let transport = ES.connect "http://localhost:9200"
    transport |> should not' (be null)

[<Fact>]
let ``ES.connectWithApiKey creates a transport with auth`` () =
    let transport = ES.connectWithApiKey "http://localhost:9200" "test-api-key"
    transport |> should not' (be null)

[<Fact>]
let ``esTransport CE creates a transport`` () =
    let transport = esTransport {
        uri "http://localhost:9200"
        requestTimeout 30.
        maxRetries 3
        compression true
    }
    transport |> should not' (be null)

[<Fact>]
let ``esTransport CE with API key auth`` () =
    let transport = esTransport {
        uri "http://localhost:9200"
        apiKey "my-test-key"
    }
    transport |> should not' (be null)

[<Fact>]
let ``esTransport CE with basic auth`` () =
    let transport = esTransport {
        uri "http://localhost:9200"
        basicAuth "user" "pass"
    }
    transport |> should not' (be null)
