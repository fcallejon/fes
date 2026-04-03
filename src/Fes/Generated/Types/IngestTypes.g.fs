// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IngestTypes =

    [<RequireQualifiedAccess>]
    type ShapeType =
        | GeoShape
        | Shape

    [<RequireQualifiedAccess>]
    type ConvertType =
        | Integer
        | Long
        | Double
        | Float
        | Boolean
        | Ip
        | String
        | Auto

    [<RequireQualifiedAccess>]
    type FingerprintDigest =
        | MD5
        | SHA1
        | SHA256
        | SHA512
        | MurmurHash3

    [<RequireQualifiedAccess>]
    type GeoGridTileType =
        | Geotile
        | Geohex
        | Geohash

    [<RequireQualifiedAccess>]
    type GeoGridTargetFormat =
        | Geojson
        | Wkt

    type InferenceConfigRegression = {
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: Types.Integer option
    }

    type InferenceConfigClassification = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes_results_field")>]
        TopClassesResultsField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_field_type")>]
        PredictionFieldType: string option
    }

    [<RequireQualifiedAccess>]
    type InferenceConfig =
        | Regression of IngestTypes.InferenceConfigRegression
        | Classification of IngestTypes.InferenceConfigClassification

    type InputConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("input_field")>]
        InputField: string
        [<System.Text.Json.Serialization.JsonPropertyName("output_field")>]
        OutputField: string
    }

    [<RequireQualifiedAccess>]
    type JsonProcessorConflictStrategy =
        | Replace
        | Merge

    [<RequireQualifiedAccess>]
    type UserAgentProperty =
        | Name
        | Os
        | Device
        | Original
        | Version

    type AppendProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("media_type")>]
        MediaType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("copy_from")>]
        CopyFrom: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_duplicates")>]
        AllowDuplicates: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_empty_values")>]
        IgnoreEmptyValues: bool option
    }

    and ProcessorBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("if")>]
        If: Types.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_failure")>]
        IgnoreFailure: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("on_failure")>]
        OnFailure: IngestTypes.ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("tag")>]
        Tag: string option
    }

    [<RequireQualifiedAccess>]
    and ProcessorContainer =
        | Append of IngestTypes.AppendProcessor
        | Attachment of IngestTypes.AttachmentProcessor
        | Bytes of IngestTypes.BytesProcessor
        | Cef of IngestTypes.CefProcessor
        | Circle of IngestTypes.CircleProcessor
        | CommunityId of IngestTypes.CommunityIDProcessor
        | Convert of IngestTypes.ConvertProcessor
        | Csv of IngestTypes.CsvProcessor
        | Date of IngestTypes.DateProcessor
        | DateIndexName of IngestTypes.DateIndexNameProcessor
        | Dissect of IngestTypes.DissectProcessor
        | DotExpander of IngestTypes.DotExpanderProcessor
        | Drop of IngestTypes.DropProcessor
        | Enrich of IngestTypes.EnrichProcessor
        | Fail of IngestTypes.FailProcessor
        | Fingerprint of IngestTypes.FingerprintProcessor
        | Foreach of IngestTypes.ForeachProcessor
        | IpLocation of IngestTypes.IpLocationProcessor
        | GeoGrid of IngestTypes.GeoGridProcessor
        | Geoip of IngestTypes.GeoIpProcessor
        | Grok of IngestTypes.GrokProcessor
        | Gsub of IngestTypes.GsubProcessor
        | HtmlStrip of IngestTypes.HtmlStripProcessor
        | Inference of IngestTypes.InferenceProcessor
        | Join of IngestTypes.JoinProcessor
        | Json of IngestTypes.JsonProcessor
        | Kv of IngestTypes.KeyValueProcessor
        | Lowercase of IngestTypes.LowercaseProcessor
        | NetworkDirection of IngestTypes.NetworkDirectionProcessor
        | Pipeline of IngestTypes.PipelineProcessor
        | Redact of IngestTypes.RedactProcessor
        | RegisteredDomain of IngestTypes.RegisteredDomainProcessor
        | Remove of IngestTypes.RemoveProcessor
        | Rename of IngestTypes.RenameProcessor
        | Reroute of IngestTypes.RerouteProcessor
        | Script of IngestTypes.ScriptProcessor
        | Set of IngestTypes.SetProcessor
        | SetSecurityUser of IngestTypes.SetSecurityUserProcessor
        | Sort of IngestTypes.SortProcessor
        | Split of IngestTypes.SplitProcessor
        | Terminate of IngestTypes.TerminateProcessor
        | Trim of IngestTypes.TrimProcessor
        | Uppercase of IngestTypes.UppercaseProcessor
        | Urldecode of IngestTypes.UrlDecodeProcessor
        | UriParts of IngestTypes.UriPartsProcessor
        | UserAgent of IngestTypes.UserAgentProcessor
        | Unknown of name: string * System.Text.Json.JsonElement

    and AttachmentProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_chars")>]
        IndexedChars: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_chars_field")>]
        IndexedCharsField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_binary")>]
        RemoveBinary: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("resource_name")>]
        ResourceName: string option
    }

    and BytesProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and CefProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_empty_values")>]
        IgnoreEmptyValues: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timezone")>]
        Timezone: string option
    }

    and CircleProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("error_distance")>]
        ErrorDistance: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("shape_type")>]
        ShapeType: IngestTypes.ShapeType
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and CommunityIDProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("source_ip")>]
        SourceIp: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("source_port")>]
        SourcePort: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("destination_ip")>]
        DestinationIp: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("destination_port")>]
        DestinationPort: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("iana_number")>]
        IanaNumber: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("icmp_type")>]
        IcmpType: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("icmp_code")>]
        IcmpCode: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("seed")>]
        Seed: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and ConvertProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: IngestTypes.ConvertType
    }

    and CsvProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("empty_value")>]
        EmptyValue: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("quote")>]
        Quote: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_fields")>]
        TargetFields: Types.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("trim")>]
        Trim: bool option
    }

    and DateProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("formats")>]
        Formats: string list
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("timezone")>]
        Timezone: string option
        [<System.Text.Json.Serialization.JsonPropertyName("output_format")>]
        OutputFormat: string option
    }

    and DateIndexNameProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("date_formats")>]
        DateFormats: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("date_rounding")>]
        DateRounding: string
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("index_name_format")>]
        IndexNameFormat: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index_name_prefix")>]
        IndexNamePrefix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("timezone")>]
        Timezone: string option
    }

    and DissectProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("append_separator")>]
        AppendSeparator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
    }

    and DotExpanderProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("override")>]
        Override: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
    }

    and DropProcessor = {
    }

    and EnrichProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_matches")>]
        MaxMatches: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("override")>]
        Override: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("policy_name")>]
        PolicyName: string
        [<System.Text.Json.Serialization.JsonPropertyName("shape_relation")>]
        ShapeRelation: Types.GeoShapeRelation option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field
    }

    and FailProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: string
    }

    and FingerprintProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("salt")>]
        Salt: string option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: IngestTypes.FingerprintDigest option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and ForeachProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("processor")>]
        Processor: IngestTypes.ProcessorContainer
    }

    and IpLocationProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("database_file")>]
        DatabaseFile: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("first_only")>]
        FirstOnly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("download_database_on_pipeline_creation")>]
        DownloadDatabaseOnPipelineCreation: bool option
    }

    and GeoGridProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("tile_type")>]
        TileType: IngestTypes.GeoGridTileType
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("parent_field")>]
        ParentField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("children_field")>]
        ChildrenField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("non_children_field")>]
        NonChildrenField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_field")>]
        PrecisionField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_format")>]
        TargetFormat: IngestTypes.GeoGridTargetFormat option
    }

    and GeoIpProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("database_file")>]
        DatabaseFile: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("first_only")>]
        FirstOnly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("download_database_on_pipeline_creation")>]
        DownloadDatabaseOnPipelineCreation: bool option
    }

    and GrokProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern_definitions")>]
        PatternDefinitions: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("patterns")>]
        Patterns: Types.GrokPattern list
        [<System.Text.Json.Serialization.JsonPropertyName("trace_match")>]
        TraceMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("validate_only")>]
        ValidateOnly: bool option
    }

    and GsubProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("replacement")>]
        Replacement: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and HtmlStripProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and InferenceProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("field_map")>]
        FieldMap: Map<Types.Field, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: IngestTypes.InferenceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("input_output")>]
        InputOutput: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and JoinProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and JsonProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("add_to_root")>]
        AddToRoot: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("add_to_root_conflict_strategy")>]
        AddToRootConflictStrategy: IngestTypes.JsonProcessorConflictStrategy option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_duplicate_keys")>]
        AllowDuplicateKeys: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and KeyValueProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_keys")>]
        ExcludeKeys: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("field_split")>]
        FieldSplit: string
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("include_keys")>]
        IncludeKeys: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("strip_brackets")>]
        StripBrackets: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("trim_key")>]
        TrimKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("trim_value")>]
        TrimValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("value_split")>]
        ValueSplit: string
    }

    and LowercaseProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and NetworkDirectionProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("source_ip")>]
        SourceIp: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("destination_ip")>]
        DestinationIp: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("internal_networks")>]
        InternalNetworks: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("internal_networks_field")>]
        InternalNetworksField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and PipelineProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing_pipeline")>]
        IgnoreMissingPipeline: bool option
    }

    and RedactProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("patterns")>]
        Patterns: Types.GrokPattern list
        [<System.Text.Json.Serialization.JsonPropertyName("pattern_definitions")>]
        PatternDefinitions: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("prefix")>]
        Prefix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("suffix")>]
        Suffix: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("skip_if_unlicensed")>]
        SkipIfUnlicensed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("trace_redact")>]
        TraceRedact: bool option
    }

    and RegisteredDomainProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and RemoveProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("keep")>]
        Keep: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and RenameProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field
    }

    and RerouteProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("destination")>]
        Destination: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dataset")>]
        Dataset: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("namespace")>]
        Namespace: System.Text.Json.JsonElement option
    }

    and ScriptProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: Types.ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
    }

    and SetProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("copy_from")>]
        CopyFrom: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_empty_value")>]
        IgnoreEmptyValue: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("media_type")>]
        MediaType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("override")>]
        Override: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement option
    }

    and SetSecurityUserProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
    }

    and SortProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: Types.SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and SplitProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_trailing")>]
        PreserveTrailing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and TerminateProcessor = {
    }

    and TrimProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and UppercaseProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and UrlDecodeProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and UriPartsProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_original")>]
        KeepOriginal: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_if_successful")>]
        RemoveIfSuccessful: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
    }

    and UserAgentProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("regex_file")>]
        RegexFile: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: Types.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: IngestTypes.UserAgentProperty list option
        [<System.Text.Json.Serialization.JsonPropertyName("extract_device_type")>]
        ExtractDeviceType: bool option
    }

    type Maxmind = {
        [<System.Text.Json.Serialization.JsonPropertyName("account_id")>]
        AccountId: Types.Id
    }

    type Ipinfo = {
    }

    /// The configuration necessary to identify which IP geolocation provider to use to download a database, as well as any provider-specific configuration necessary for such downloading.
    [<RequireQualifiedAccess>]
    type DatabaseConfiguration =
        | Maxmind of IngestTypes.Maxmind
        | Ipinfo of IngestTypes.Ipinfo

    and DatabaseConfigurationMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
    }

    type Web = {
    }

    type Local = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type DatabaseConfigurationFull =
        | Web of IngestTypes.Web
        | Local of IngestTypes.Local
        | Maxmind of IngestTypes.Maxmind
        | Ipinfo of IngestTypes.Ipinfo

    and DatabaseConfigurationFullMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
    }

    type Document = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: System.Text.Json.JsonElement
    }

    type Redact = {
        [<System.Text.Json.Serialization.JsonPropertyName("_is_redacted")>]
        IsRedacted: bool
    }

    type Ingest = {
        [<System.Text.Json.Serialization.JsonPropertyName("_redact")>]
        Redact: IngestTypes.Redact option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: Types.Name option
    }

    /// The simulated document, with optional metadata.
    type DocumentSimulation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_ingest")>]
        Ingest: IngestTypes.Ingest
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: SpecUtils.Stringified<Types.VersionNumber> option
        [<System.Text.Json.Serialization.JsonPropertyName("_version_type")>]
        VersionType: Types.VersionType option
    }

    [<RequireQualifiedAccess>]
    type FieldAccessPattern =
        | Classic
        | Flexible

    type Pipeline = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("on_failure")>]
        OnFailure: IngestTypes.ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: IngestTypes.ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: Types.EpochTime<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("field_access_pattern")>]
        FieldAccessPattern: IngestTypes.FieldAccessPattern option
    }

    type PipelineConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: IngestTypes.ProcessorContainer list
    }

    [<RequireQualifiedAccess>]
    type PipelineSimulationStatusOptions =
        | Success
        | Error
        | ErrorIgnored
        | Skipped
        | Dropped

    type PipelineProcessorResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: IngestTypes.DocumentSimulation option
        [<System.Text.Json.Serialization.JsonPropertyName("tag")>]
        Tag: string option
        [<System.Text.Json.Serialization.JsonPropertyName("processor_type")>]
        ProcessorType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: IngestTypes.PipelineSimulationStatusOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignored_error")>]
        IgnoredError: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
    }

    type SimulateDocumentResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: IngestTypes.DocumentSimulation option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("processor_results")>]
        ProcessorResults: IngestTypes.PipelineProcessorResult list option
    }

