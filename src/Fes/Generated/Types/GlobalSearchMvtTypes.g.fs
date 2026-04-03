// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalSearchMvtTypes =

    type Coordinate = Types.Integer

    [<RequireQualifiedAccess>]
    type GridAggregationType =
        | Geotile
        | Geohex

    [<RequireQualifiedAccess>]
    type GridType =
        | Grid
        | Point
        | Centroid

    type ZoomLevel = Types.Integer

