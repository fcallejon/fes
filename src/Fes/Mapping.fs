namespace Fes

open Fes.Generated

/// Convenience functions for building index mappings without verbose Property DU wrapping.
///
/// Example:
///   let req = indicesCreateRequest {
///       index "products"
///       mappings (Mapping.mapping [
///           Mapping.text "title" { Types.TextProperty.empty with Analyzer = Some "standard" }
///           Mapping.keyword "category" Types.KeywordProperty.empty
///           Mapping.float' "price" Types.FloatNumberProperty.empty
///           Mapping.boolean "in_stock" Types.BooleanProperty.empty
///       ])
///   }
[<RequireQualifiedAccess>]
module Mapping =

    // ── Build a TypeMapping from field definitions ──────────────────────

    /// Build a Properties map from field definitions
    let properties (fields: (string * Types.Property) list) : Map<string, Types.Property> option =
        fields |> Map.ofList |> Some

    /// Build a TypeMapping with the given property definitions
    let mapping (fields: (string * Types.Property) list) : Types.TypeMapping =
        { Types.TypeMapping.empty with Properties = properties fields }

    // ── Core field types ────────────────────────────────────────────────

    /// Text field (full-text search)
    let text (name: string) (prop: Types.TextProperty) : string * Types.Property =
        name, Types.Property.TextProperty prop

    /// Keyword field (exact match / aggregations)
    let keyword (name: string) (prop: Types.KeywordProperty) : string * Types.Property =
        name, Types.Property.KeywordProperty prop

    /// Boolean field
    let boolean (name: string) (prop: Types.BooleanProperty) : string * Types.Property =
        name, Types.Property.BooleanProperty prop

    // ── Numeric types ───────────────────────────────────────────────────

    /// Float field
    let float' (name: string) (prop: Types.FloatNumberProperty) : string * Types.Property =
        name, Types.Property.FloatNumberProperty prop

    /// Double field
    let double' (name: string) (prop: Types.DoubleNumberProperty) : string * Types.Property =
        name, Types.Property.DoubleNumberProperty prop

    /// Integer field
    let integer (name: string) (prop: Types.IntegerNumberProperty) : string * Types.Property =
        name, Types.Property.IntegerNumberProperty prop

    /// Long field
    let long (name: string) (prop: Types.LongNumberProperty) : string * Types.Property =
        name, Types.Property.LongNumberProperty prop

    /// Short field
    let short (name: string) (prop: Types.ShortNumberProperty) : string * Types.Property =
        name, Types.Property.ShortNumberProperty prop

    /// Byte field
    let byte' (name: string) (prop: Types.ByteNumberProperty) : string * Types.Property =
        name, Types.Property.ByteNumberProperty prop

    /// Half-float field
    let halfFloat (name: string) (prop: Types.HalfFloatNumberProperty) : string * Types.Property =
        name, Types.Property.HalfFloatNumberProperty prop

    /// Scaled float field
    let scaledFloat (name: string) (prop: Types.ScaledFloatNumberProperty) : string * Types.Property =
        name, Types.Property.ScaledFloatNumberProperty prop

    /// Unsigned long field
    let unsignedLong (name: string) (prop: Types.UnsignedLongNumberProperty) : string * Types.Property =
        name, Types.Property.UnsignedLongNumberProperty prop

    // ── Date types ──────────────────────────────────────────────────────

    /// Date field
    let date (name: string) (prop: Types.DateProperty) : string * Types.Property =
        name, Types.Property.DateProperty prop

    /// Date nanos field
    let dateNanos (name: string) (prop: Types.DateNanosProperty) : string * Types.Property =
        name, Types.Property.DateNanosProperty prop

    // ── Structured types ────────────────────────────────────────────────

    /// Nested field (array of objects with independent querying)
    let nested (name: string) (prop: Types.NestedProperty) : string * Types.Property =
        name, Types.Property.NestedProperty prop

    /// Object field
    let object' (name: string) (prop: Types.ObjectProperty) : string * Types.Property =
        name, Types.Property.ObjectProperty prop

    // ── Geo types ───────────────────────────────────────────────────────

    /// Geo-point field
    let geoPoint (name: string) (prop: Types.GeoPointProperty) : string * Types.Property =
        name, Types.Property.GeoPointProperty prop

    /// Geo-shape field
    let geoShape (name: string) (prop: Types.GeoShapeProperty) : string * Types.Property =
        name, Types.Property.GeoShapeProperty prop

    // ── Specialised types ───────────────────────────────────────────────

    /// IP address field
    let ip (name: string) (prop: Types.IpProperty) : string * Types.Property =
        name, Types.Property.IpProperty prop

    /// Completion field (for suggest / autocomplete)
    let completion (name: string) (prop: Types.CompletionProperty) : string * Types.Property =
        name, Types.Property.CompletionProperty prop

    /// Binary field
    let binary (name: string) (prop: Types.BinaryProperty) : string * Types.Property =
        name, Types.Property.BinaryProperty prop

    /// Token count field
    let tokenCount (name: string) (prop: Types.TokenCountProperty) : string * Types.Property =
        name, Types.Property.TokenCountProperty prop

    /// Dense vector field
    let denseVector (name: string) (prop: Types.DenseVectorProperty) : string * Types.Property =
        name, Types.Property.DenseVectorProperty prop

    /// Field alias
    let alias (name: string) (prop: Types.FieldAliasProperty) : string * Types.Property =
        name, Types.Property.FieldAliasProperty prop

    /// Constant keyword field
    let constantKeyword (name: string) (prop: Types.ConstantKeywordProperty) : string * Types.Property =
        name, Types.Property.ConstantKeywordProperty prop

    /// Flattened field
    let flattened (name: string) (prop: Types.FlattenedProperty) : string * Types.Property =
        name, Types.Property.FlattenedProperty prop

    /// Search-as-you-type field
    let searchAsYouType (name: string) (prop: Types.SearchAsYouTypeProperty) : string * Types.Property =
        name, Types.Property.SearchAsYouTypeProperty prop

    /// Wildcard field
    let wildcard (name: string) (prop: Types.WildcardProperty) : string * Types.Property =
        name, Types.Property.WildcardProperty prop

    // ── Range types ─────────────────────────────────────────────────────

    /// Integer range field
    let integerRange (name: string) (prop: Types.IntegerRangeProperty) : string * Types.Property =
        name, Types.Property.IntegerRangeProperty prop

    /// Float range field
    let floatRange (name: string) (prop: Types.FloatRangeProperty) : string * Types.Property =
        name, Types.Property.FloatRangeProperty prop

    /// Long range field
    let longRange (name: string) (prop: Types.LongRangeProperty) : string * Types.Property =
        name, Types.Property.LongRangeProperty prop

    /// Double range field
    let doubleRange (name: string) (prop: Types.DoubleRangeProperty) : string * Types.Property =
        name, Types.Property.DoubleRangeProperty prop

    /// Date range field
    let dateRange (name: string) (prop: Types.DateRangeProperty) : string * Types.Property =
        name, Types.Property.DateRangeProperty prop

    /// IP range field
    let ipRange (name: string) (prop: Types.IpRangeProperty) : string * Types.Property =
        name, Types.Property.IpRangeProperty prop

    // ── Multi-fields ─────────────────────────────────────────────────────────

    /// Attach sub-fields (multi-fields) to any property that supports them.
    ///
    /// Example — text field with an unanalysed .keyword sub-field:
    ///   Mapping.text "title" Types.TextProperty.empty
    ///   |> Mapping.withFields [ Mapping.keyword "keyword" Types.KeywordProperty.empty ]
    let withFields
            (subFields: (string * Types.Property) list)
            ((name, prop): string * Types.Property) : string * Types.Property =
        let fields = Some (subFields |> Map.ofList)
        let updated =
            match prop with
            | Types.Property.TextProperty p ->
                Types.Property.TextProperty { p with Fields = fields }
            | Types.Property.KeywordProperty p ->
                Types.Property.KeywordProperty { p with Fields = fields }
            | Types.Property.BooleanProperty p ->
                Types.Property.BooleanProperty { p with Fields = fields }
            | Types.Property.DateProperty p ->
                Types.Property.DateProperty { p with Fields = fields }
            | Types.Property.DateNanosProperty p ->
                Types.Property.DateNanosProperty { p with Fields = fields }
            | Types.Property.ObjectProperty p ->
                Types.Property.ObjectProperty { p with Fields = fields }
            | Types.Property.NestedProperty p ->
                Types.Property.NestedProperty { p with Fields = fields }
            | Types.Property.ByteNumberProperty p ->
                Types.Property.ByteNumberProperty { p with Fields = fields }
            | Types.Property.ShortNumberProperty p ->
                Types.Property.ShortNumberProperty { p with Fields = fields }
            | Types.Property.IntegerNumberProperty p ->
                Types.Property.IntegerNumberProperty { p with Fields = fields }
            | Types.Property.LongNumberProperty p ->
                Types.Property.LongNumberProperty { p with Fields = fields }
            | Types.Property.FloatNumberProperty p ->
                Types.Property.FloatNumberProperty { p with Fields = fields }
            | Types.Property.DoubleNumberProperty p ->
                Types.Property.DoubleNumberProperty { p with Fields = fields }
            | Types.Property.HalfFloatNumberProperty p ->
                Types.Property.HalfFloatNumberProperty { p with Fields = fields }
            | Types.Property.ScaledFloatNumberProperty p ->
                Types.Property.ScaledFloatNumberProperty { p with Fields = fields }
            | Types.Property.UnsignedLongNumberProperty p ->
                Types.Property.UnsignedLongNumberProperty { p with Fields = fields }
            | Types.Property.IpProperty p ->
                Types.Property.IpProperty { p with Fields = fields }
            | Types.Property.CompletionProperty p ->
                Types.Property.CompletionProperty { p with Fields = fields }
            | Types.Property.TokenCountProperty p ->
                Types.Property.TokenCountProperty { p with Fields = fields }
            | Types.Property.GeoPointProperty p ->
                Types.Property.GeoPointProperty { p with Fields = fields }
            | Types.Property.GeoShapeProperty p ->
                Types.Property.GeoShapeProperty { p with Fields = fields }
            | Types.Property.SearchAsYouTypeProperty p ->
                Types.Property.SearchAsYouTypeProperty { p with Fields = fields }
            | Types.Property.WildcardProperty p ->
                Types.Property.WildcardProperty { p with Fields = fields }
            | Types.Property.BinaryProperty p ->
                Types.Property.BinaryProperty { p with Fields = fields }
            | Types.Property.JoinProperty p ->
                Types.Property.JoinProperty { p with Fields = fields }
            | Types.Property.MatchOnlyTextProperty p ->
                Types.Property.MatchOnlyTextProperty { p with Fields = fields }
            | Types.Property.PercolatorProperty p ->
                Types.Property.PercolatorProperty { p with Fields = fields }
            | Types.Property.RankFeatureProperty p ->
                Types.Property.RankFeatureProperty { p with Fields = fields }
            | Types.Property.RankFeaturesProperty p ->
                Types.Property.RankFeaturesProperty { p with Fields = fields }
            | Types.Property.VersionProperty p ->
                Types.Property.VersionProperty { p with Fields = fields }
            | Types.Property.AggregateMetricDoubleProperty p ->
                Types.Property.AggregateMetricDoubleProperty { p with Fields = fields }
            | Types.Property.DenseVectorProperty p ->
                Types.Property.DenseVectorProperty { p with Fields = fields }
            | Types.Property.FlattenedProperty p ->
                Types.Property.FlattenedProperty { p with Fields = fields }
            | Types.Property.PassthroughObjectProperty p ->
                Types.Property.PassthroughObjectProperty { p with Fields = fields }
            | Types.Property.RankVectorProperty p ->
                Types.Property.RankVectorProperty { p with Fields = fields }
            | Types.Property.SemanticTextProperty p ->
                Types.Property.SemanticTextProperty { p with Fields = fields }
            | Types.Property.SparseVectorProperty p ->
                Types.Property.SparseVectorProperty { p with Fields = fields }
            | Types.Property.ConstantKeywordProperty p ->
                Types.Property.ConstantKeywordProperty { p with Fields = fields }
            | Types.Property.CountedKeywordProperty p ->
                Types.Property.CountedKeywordProperty { p with Fields = fields }
            | Types.Property.FieldAliasProperty p ->
                Types.Property.FieldAliasProperty { p with Fields = fields }
            | Types.Property.HistogramProperty p ->
                Types.Property.HistogramProperty { p with Fields = fields }
            | Types.Property.ExponentialHistogramProperty p ->
                Types.Property.ExponentialHistogramProperty { p with Fields = fields }
            | Types.Property.Murmur3HashProperty p ->
                Types.Property.Murmur3HashProperty { p with Fields = fields }
            | Types.Property.PointProperty p ->
                Types.Property.PointProperty { p with Fields = fields }
            | Types.Property.ShapeProperty p ->
                Types.Property.ShapeProperty { p with Fields = fields }
            | Types.Property.IcuCollationProperty p ->
                Types.Property.IcuCollationProperty { p with Fields = fields }
            | Types.Property.DateRangeProperty p ->
                Types.Property.DateRangeProperty { p with Fields = fields }
            | Types.Property.DoubleRangeProperty p ->
                Types.Property.DoubleRangeProperty { p with Fields = fields }
            | Types.Property.FloatRangeProperty p ->
                Types.Property.FloatRangeProperty { p with Fields = fields }
            | Types.Property.IntegerRangeProperty p ->
                Types.Property.IntegerRangeProperty { p with Fields = fields }
            | Types.Property.IpRangeProperty p ->
                Types.Property.IpRangeProperty { p with Fields = fields }
            | Types.Property.LongRangeProperty p ->
                Types.Property.LongRangeProperty { p with Fields = fields }
            | Types.Property.DynamicProperty _
            | Types.Property.Unknown _ -> prop
        name, updated
