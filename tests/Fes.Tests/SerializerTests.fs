module Fes.Tests.SerializerTests

open Xunit
open FsUnit.Xunit
open Fes
open System.IO

// ============================================================================
// FesSerializer integration with Elastic.Transport
// ============================================================================

[<Fact>]
let ``FesSerializer can serialise a record to stream`` () =
    let serialiser = FesSerializer()
    use stream = new MemoryStream()
    let data = {| name = "test"; value = 42 |}
    serialiser.Serialize(data, stream)
    stream.Length |> should be (greaterThan 0L)

[<Fact>]
let ``FesSerializer can deserialise from stream`` () =
    let serialiser = FesSerializer()
    let json = """{"name":"test","value":42}"""
    use stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(json))
    let result = serialiser.Deserialize<{| name: string; value: int |}>(stream)
    result.name |> should equal "test"
    result.value |> should equal 42
