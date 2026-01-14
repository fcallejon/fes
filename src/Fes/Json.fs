namespace Fes

open System
open System.Text.Json
open System.Text.Json.Nodes
open System.Text.Json.Serialization
open System.Threading.Tasks

module JsonSettings =
    let options =
        let opts = JsonSerializerOptions()
        // Add manual type converters (not in generated models)
        opts.Converters.Add(Fes.Exceptions.ElasticsearchExceptionsConverter())
        opts.Converters.Add(Fes.Exceptions.ElasticsearchCauseByTypeConverter())
        // Enum converter for lowercase enum values (Elasticsearch expects "true" not "True")
        opts.Converters.Add(JsonStringEnumConverter(JsonNamingPolicy.CamelCase))
        // JsonFSharpConverter handles remaining F# types (options, other unions)
        opts.Converters.Add(JsonFSharpConverter(
            JsonUnionEncoding.AdjacentTag ||| JsonUnionEncoding.NamedFields ||| JsonUnionEncoding.UnwrapOption,
            unionTagName = "type",
            unionFieldsName = "value"
        ))
        opts.PropertyNamingPolicy <- JsonNamingPolicy.SnakeCaseLower
        opts.DefaultIgnoreCondition <- JsonIgnoreCondition.WhenWritingNull
        opts

module Json =
    open JsonSettings

    let inline serialize (value: 'a) : string =
        JsonSerializer.Serialize(value, options)

    let inline deserialize<'a> (json: string) : 'a =
        JsonSerializer.Deserialize<'a>(json, options)

    let inline tryDeserialize<'a> (json: string) : Result<'a, exn> =
        try
            Ok (JsonSerializer.Deserialize<'a>(json, options))
        with ex ->
            Error ex

    let inline serializeToNode (value: 'a) : JsonNode =
        JsonSerializer.SerializeToNode(value, options)

    let inline deserializeNode<'a> (node: JsonNode) : 'a =
        node.Deserialize<'a>(options)

[<RequireQualifiedAccess>]
module JsonRes =
    let inline ofString<'a> (s: string) : TaskResult<'a, exn> =
        try
            let result = Json.deserialize<'a> s
            TaskResult.retn result
        with ex ->
            Task.FromResult(Result.Error ex)
