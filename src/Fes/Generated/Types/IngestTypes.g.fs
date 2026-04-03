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
        ResultsField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: CoreTypes.Integer option
    }

    type InferenceConfigClassification = {
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_classes")>]
        NumTopClasses: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("num_top_feature_importance_values")>]
        NumTopFeatureImportanceValues: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("results_field")>]
        ResultsField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("top_classes_results_field")>]
        TopClassesResultsField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("prediction_field_type")>]
        PredictionFieldType: string option
    }

    [<RequireQualifiedAccess>]
    type InferenceConfig =
        | Regression of InferenceConfigRegression
        | Classification of InferenceConfigClassification

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
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("media_type")>]
        MediaType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("copy_from")>]
        CopyFrom: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_duplicates")>]
        AllowDuplicates: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_empty_values")>]
        IgnoreEmptyValues: bool option
    }

    and ProcessorBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("if")>]
        If: CoreTypes.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_failure")>]
        IgnoreFailure: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("on_failure")>]
        OnFailure: ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("tag")>]
        Tag: string option
    }

    and [<RequireQualifiedAccess>] ProcessorContainer =
        | Append of AppendProcessor
        | Attachment of AttachmentProcessor
        | Bytes of BytesProcessor
        | Cef of CefProcessor
        | Circle of CircleProcessor
        | CommunityId of CommunityIDProcessor
        | Convert of ConvertProcessor
        | Csv of CsvProcessor
        | Date of DateProcessor
        | DateIndexName of DateIndexNameProcessor
        | Dissect of DissectProcessor
        | DotExpander of DotExpanderProcessor
        | Drop of DropProcessor
        | Enrich of EnrichProcessor
        | Fail of FailProcessor
        | Fingerprint of FingerprintProcessor
        | Foreach of ForeachProcessor
        | IpLocation of IpLocationProcessor
        | GeoGrid of GeoGridProcessor
        | Geoip of GeoIpProcessor
        | Grok of GrokProcessor
        | Gsub of GsubProcessor
        | HtmlStrip of HtmlStripProcessor
        | Inference of InferenceProcessor
        | Join of JoinProcessor
        | Json of JsonProcessor
        | Kv of KeyValueProcessor
        | Lowercase of LowercaseProcessor
        | NetworkDirection of NetworkDirectionProcessor
        | Pipeline of PipelineProcessor
        | Redact of RedactProcessor
        | RegisteredDomain of RegisteredDomainProcessor
        | Remove of RemoveProcessor
        | Rename of RenameProcessor
        | Reroute of RerouteProcessor
        | Script of ScriptProcessor
        | Set of SetProcessor
        | SetSecurityUser of SetSecurityUserProcessor
        | Sort of SortProcessor
        | Split of SplitProcessor
        | Terminate of TerminateProcessor
        | Trim of TrimProcessor
        | Uppercase of UppercaseProcessor
        | Urldecode of UrlDecodeProcessor
        | UriParts of UriPartsProcessor
        | UserAgent of UserAgentProcessor
        | Unknown of name: string * System.Text.Json.JsonElement

    and AttachmentProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_chars")>]
        IndexedChars: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_chars_field")>]
        IndexedCharsField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_binary")>]
        RemoveBinary: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("resource_name")>]
        ResourceName: string option
    }

    and BytesProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and CefProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_empty_values")>]
        IgnoreEmptyValues: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("timezone")>]
        Timezone: string option
    }

    and CircleProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("error_distance")>]
        ErrorDistance: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("shape_type")>]
        ShapeType: ShapeType
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and CommunityIDProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("source_ip")>]
        SourceIp: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("source_port")>]
        SourcePort: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("destination_ip")>]
        DestinationIp: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("destination_port")>]
        DestinationPort: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("iana_number")>]
        IanaNumber: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("icmp_type")>]
        IcmpType: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("icmp_code")>]
        IcmpCode: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("transport")>]
        Transport: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("seed")>]
        Seed: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and ConvertProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ConvertType
    }

    and CsvProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("empty_value")>]
        EmptyValue: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("quote")>]
        Quote: string option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_fields")>]
        TargetFields: CoreTypes.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("trim")>]
        Trim: bool option
    }

    and DateProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("formats")>]
        Formats: string list
        [<System.Text.Json.Serialization.JsonPropertyName("locale")>]
        Locale: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
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
        Field: CoreTypes.Field
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
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
    }

    and DotExpanderProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("override")>]
        Override: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
    }

    and DropProcessor = System.Text.Json.JsonElement

    and EnrichProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("max_matches")>]
        MaxMatches: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("override")>]
        Override: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("policy_name")>]
        PolicyName: string
        [<System.Text.Json.Serialization.JsonPropertyName("shape_relation")>]
        ShapeRelation: CoreTypes.GeoShapeRelation option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field
    }

    and FailProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: string
    }

    and FingerprintProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: CoreTypes.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("salt")>]
        Salt: string option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: FingerprintDigest option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and ForeachProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("processor")>]
        Processor: ProcessorContainer
    }

    and IpLocationProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("database_file")>]
        DatabaseFile: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("first_only")>]
        FirstOnly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("download_database_on_pipeline_creation")>]
        DownloadDatabaseOnPipelineCreation: bool option
    }

    and GeoGridProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("tile_type")>]
        TileType: GeoGridTileType
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("parent_field")>]
        ParentField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("children_field")>]
        ChildrenField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("non_children_field")>]
        NonChildrenField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("precision_field")>]
        PrecisionField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_format")>]
        TargetFormat: GeoGridTargetFormat option
    }

    and GeoIpProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("database_file")>]
        DatabaseFile: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("first_only")>]
        FirstOnly: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("download_database_on_pipeline_creation")>]
        DownloadDatabaseOnPipelineCreation: bool option
    }

    and GrokProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("ecs_compatibility")>]
        EcsCompatibility: string option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern_definitions")>]
        PatternDefinitions: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("patterns")>]
        Patterns: CoreTypes.GrokPattern list
        [<System.Text.Json.Serialization.JsonPropertyName("trace_match")>]
        TraceMatch: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("validate_only")>]
        ValidateOnly: bool option
    }

    and GsubProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: string
        [<System.Text.Json.Serialization.JsonPropertyName("replacement")>]
        Replacement: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and HtmlStripProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and InferenceProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("model_id")>]
        ModelId: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("field_map")>]
        FieldMap: Map<CoreTypes.Field, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("inference_config")>]
        InferenceConfig: InferenceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("input_output")>]
        InputOutput: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and JoinProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and JsonProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("add_to_root")>]
        AddToRoot: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("add_to_root_conflict_strategy")>]
        AddToRootConflictStrategy: JsonProcessorConflictStrategy option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_duplicate_keys")>]
        AllowDuplicateKeys: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and KeyValueProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("exclude_keys")>]
        ExcludeKeys: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
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
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("trim_key")>]
        TrimKey: string option
        [<System.Text.Json.Serialization.JsonPropertyName("trim_value")>]
        TrimValue: string option
        [<System.Text.Json.Serialization.JsonPropertyName("value_split")>]
        ValueSplit: string
    }

    and LowercaseProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and NetworkDirectionProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("source_ip")>]
        SourceIp: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("destination_ip")>]
        DestinationIp: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("internal_networks")>]
        InternalNetworks: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("internal_networks_field")>]
        InternalNetworksField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and PipelineProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing_pipeline")>]
        IgnoreMissingPipeline: bool option
    }

    and RedactProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("patterns")>]
        Patterns: CoreTypes.GrokPattern list
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
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and RemoveProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Fields
        [<System.Text.Json.Serialization.JsonPropertyName("keep")>]
        Keep: CoreTypes.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
    }

    and RenameProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field
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
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: CoreTypes.ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: CoreTypes.ScriptSource option
    }

    and SetProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("copy_from")>]
        CopyFrom: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
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
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: string list option
    }

    and SortProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("order")>]
        Order: CoreTypes.SortOrder option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and SplitProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("preserve_trailing")>]
        PreserveTrailing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("separator")>]
        Separator: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and TerminateProcessor = System.Text.Json.JsonElement

    and TrimProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and UppercaseProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and UrlDecodeProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and UriPartsProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("keep_original")>]
        KeepOriginal: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("remove_if_successful")>]
        RemoveIfSuccessful: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
    }

    and UserAgentProcessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_missing")>]
        IgnoreMissing: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("regex_file")>]
        RegexFile: string option
        [<System.Text.Json.Serialization.JsonPropertyName("target_field")>]
        TargetField: CoreTypes.Field option
        [<System.Text.Json.Serialization.JsonPropertyName("properties")>]
        Properties: UserAgentProperty list option
        [<System.Text.Json.Serialization.JsonPropertyName("extract_device_type")>]
        ExtractDeviceType: bool option
    }

    type Maxmind = {
        [<System.Text.Json.Serialization.JsonPropertyName("account_id")>]
        AccountId: CoreTypes.Id
    }

    type Ipinfo = System.Text.Json.JsonElement

    /// The configuration necessary to identify which IP geolocation provider to use to download a database, as well as any provider-specific configuration necessary for such downloading.
    [<RequireQualifiedAccess>]
    type DatabaseConfiguration =
        | Maxmind of Maxmind
        | Ipinfo of Ipinfo

    and DatabaseConfigurationMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    type Web = System.Text.Json.JsonElement

    type Local = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

    [<RequireQualifiedAccess>]
    type DatabaseConfigurationFull =
        | Web of Web
        | Local of Local
        | Maxmind of Maxmind
        | Ipinfo of Ipinfo

    and DatabaseConfigurationFullMeta = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    type Document = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: System.Text.Json.JsonElement
    }

    type Redact = {
        [<System.Text.Json.Serialization.JsonPropertyName("_is_redacted")>]
        IsRedacted: bool
    }

    type Ingest = {
        [<System.Text.Json.Serialization.JsonPropertyName("_redact")>]
        Redact: Redact option
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: CoreTypes.Name option
    }

    /// The simulated document, with optional metadata.
    type DocumentSimulation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_ingest")>]
        Ingest: Ingest
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: CoreTypes.Stringified<CoreTypes.VersionNumber> option
        [<System.Text.Json.Serialization.JsonPropertyName("_version_type")>]
        VersionType: CoreTypes.VersionType option
    }

    [<RequireQualifiedAccess>]
    type FieldAccessPattern =
        | Classic
        | Flexible

    type Pipeline = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("on_failure")>]
        OnFailure: ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: ProcessorContainer list option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("deprecated")>]
        Deprecated: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date")>]
        CreatedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("created_date_millis")>]
        CreatedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date")>]
        ModifiedDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("modified_date_millis")>]
        ModifiedDateMillis: CoreTypes.EpochTime<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("field_access_pattern")>]
        FieldAccessPattern: FieldAccessPattern option
    }

    type PipelineConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("processors")>]
        Processors: ProcessorContainer list
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
        Doc: DocumentSimulation option
        [<System.Text.Json.Serialization.JsonPropertyName("tag")>]
        Tag: string option
        [<System.Text.Json.Serialization.JsonPropertyName("processor_type")>]
        ProcessorType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: PipelineSimulationStatusOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ignored_error")>]
        IgnoredError: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
    }

    type SimulateDocumentResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: DocumentSimulation option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("processor_results")>]
        ProcessorResults: PipelineProcessorResult list option
    }

