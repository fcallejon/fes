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
