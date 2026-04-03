// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGet =

    [<RequireQualifiedAccess>]
    type Feature =
        | Aliases
        | Mappings
        | Settings

    [<RequireQualifiedAccess>]
    type Features =
        | Feature of Feature
        | Array of Feature list

