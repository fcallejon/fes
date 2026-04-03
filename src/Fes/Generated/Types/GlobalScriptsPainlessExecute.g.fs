// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalScriptsPainlessExecute =

    [<RequireQualifiedAccess>]
    type PainlessContext =
        | PainlessTest
        | Filter
        | Score
        | BooleanField
        | DateField
        | DoubleField
        | GeoPointField
        | IpField
        | KeywordField
        | LongField
        | CompositeField

    type PainlessContextSetup = {
        [<System.Text.Json.Serialization.JsonPropertyName("document")>]
        Document: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer option
    }

