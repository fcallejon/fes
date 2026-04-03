// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IngestTypesBuilders =

    type AppendProcessorBuilder() =
        member _.Yield(_: unit) : AppendProcessor =
            {
                Field = Unchecked.defaultof<_>
                Value = None
                MediaType = None
                CopyFrom = None
                AllowDuplicates = None
                IgnoreEmptyValues = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: AppendProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("value")>]
        member _.Value(state: AppendProcessor, value: System.Text.Json.JsonElement) =
            { state with Value = Some value }

        [<CustomOperation("mediaType")>]
        member _.MediaType(state: AppendProcessor, value: string) =
            { state with MediaType = Some value }

        [<CustomOperation("copyFrom")>]
        member _.CopyFrom(state: AppendProcessor, value: Types.Field) =
            { state with CopyFrom = Some value }

        [<CustomOperation("allowDuplicates")>]
        member _.AllowDuplicates(state: AppendProcessor, value: bool) =
            { state with AllowDuplicates = Some value }

        [<CustomOperation("ignoreEmptyValues")>]
        member _.IgnoreEmptyValues(state: AppendProcessor, value: bool) =
            { state with IgnoreEmptyValues = Some value }

    let appendProcessor = AppendProcessorBuilder()

    type AttachmentProcessorBuilder() =
        member _.Yield(_: unit) : AttachmentProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                IndexedChars = None
                IndexedCharsField = None
                Properties = None
                TargetField = None
                RemoveBinary = None
                ResourceName = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: AttachmentProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: AttachmentProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("indexedChars")>]
        member _.IndexedChars(state: AttachmentProcessor, value: Types.Long) =
            { state with IndexedChars = Some value }

        [<CustomOperation("indexedCharsField")>]
        member _.IndexedCharsField(state: AttachmentProcessor, value: Types.Field) =
            { state with IndexedCharsField = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: AttachmentProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: AttachmentProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("removeBinary")>]
        member _.RemoveBinary(state: AttachmentProcessor, value: bool) =
            { state with RemoveBinary = Some value }

        [<CustomOperation("resourceName")>]
        member _.ResourceName(state: AttachmentProcessor, value: string) =
            { state with ResourceName = Some value }

    let attachmentProcessor = AttachmentProcessorBuilder()

    type BytesProcessorBuilder() =
        member _.Yield(_: unit) : BytesProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: BytesProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: BytesProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: BytesProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let bytesProcessor = BytesProcessorBuilder()

    type CefProcessorBuilder() =
        member _.Yield(_: unit) : CefProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                IgnoreEmptyValues = None
                Timezone = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: CefProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: CefProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: CefProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("ignoreEmptyValues")>]
        member _.IgnoreEmptyValues(state: CefProcessor, value: bool) =
            { state with IgnoreEmptyValues = Some value }

        [<CustomOperation("timezone")>]
        member _.Timezone(state: CefProcessor, value: string) =
            { state with Timezone = Some value }

    let cefProcessor = CefProcessorBuilder()

    type CircleProcessorBuilder() =
        member _.Yield(_: unit) : CircleProcessor =
            {
                ErrorDistance = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                ShapeType = Unchecked.defaultof<_>
                TargetField = None
            }

        [<CustomOperation("errorDistance")>]
        member _.ErrorDistance(state: CircleProcessor, value: Types.Double) =
            { state with ErrorDistance = value }

        [<CustomOperation("field")>]
        member _.Field(state: CircleProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: CircleProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("shapeType")>]
        member _.ShapeType(state: CircleProcessor, value: IngestTypes.ShapeType) =
            { state with ShapeType = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: CircleProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let circleProcessor = CircleProcessorBuilder()

    type CommunityIDProcessorBuilder() =
        member _.Yield(_: unit) : CommunityIDProcessor =
            {
                SourceIp = None
                SourcePort = None
                DestinationIp = None
                DestinationPort = None
                IanaNumber = None
                IcmpType = None
                IcmpCode = None
                Transport = None
                TargetField = None
                Seed = None
                IgnoreMissing = None
            }

        [<CustomOperation("sourceIp")>]
        member _.SourceIp(state: CommunityIDProcessor, value: Types.Field) =
            { state with SourceIp = Some value }

        [<CustomOperation("sourcePort")>]
        member _.SourcePort(state: CommunityIDProcessor, value: Types.Field) =
            { state with SourcePort = Some value }

        [<CustomOperation("destinationIp")>]
        member _.DestinationIp(state: CommunityIDProcessor, value: Types.Field) =
            { state with DestinationIp = Some value }

        [<CustomOperation("destinationPort")>]
        member _.DestinationPort(state: CommunityIDProcessor, value: Types.Field) =
            { state with DestinationPort = Some value }

        [<CustomOperation("ianaNumber")>]
        member _.IanaNumber(state: CommunityIDProcessor, value: Types.Field) =
            { state with IanaNumber = Some value }

        [<CustomOperation("icmpType")>]
        member _.IcmpType(state: CommunityIDProcessor, value: Types.Field) =
            { state with IcmpType = Some value }

        [<CustomOperation("icmpCode")>]
        member _.IcmpCode(state: CommunityIDProcessor, value: Types.Field) =
            { state with IcmpCode = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: CommunityIDProcessor, value: Types.Field) =
            { state with Transport = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: CommunityIDProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("seed")>]
        member _.Seed(state: CommunityIDProcessor, value: Types.Integer) =
            { state with Seed = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: CommunityIDProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

    let communityIDProcessor = CommunityIDProcessorBuilder()

    type ConvertProcessorBuilder() =
        member _.Yield(_: unit) : ConvertProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("field")>]
        member _.Field(state: ConvertProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: ConvertProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: ConvertProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: ConvertProcessor, value: IngestTypes.ConvertType) =
            { state with Type = value }

    let convertProcessor = ConvertProcessorBuilder()

    type CsvProcessorBuilder() =
        member _.Yield(_: unit) : CsvProcessor =
            {
                EmptyValue = None
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Quote = None
                Separator = None
                TargetFields = Unchecked.defaultof<_>
                Trim = None
            }

        [<CustomOperation("emptyValue")>]
        member _.EmptyValue(state: CsvProcessor, value: System.Text.Json.JsonElement) =
            { state with EmptyValue = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: CsvProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: CsvProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("quote")>]
        member _.Quote(state: CsvProcessor, value: string) =
            { state with Quote = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: CsvProcessor, value: string) =
            { state with Separator = Some value }

        [<CustomOperation("targetFields")>]
        member _.TargetFields(state: CsvProcessor, value: Types.Fields) =
            { state with TargetFields = value }

        [<CustomOperation("trim")>]
        member _.Trim(state: CsvProcessor, value: bool) =
            { state with Trim = Some value }

    let csvProcessor = CsvProcessorBuilder()

    module DatabaseConfiguration =

        let maxmind (value: IngestTypes.Maxmind) =
            DatabaseConfiguration.Maxmind value

        let ipinfo (value: IngestTypes.Ipinfo) =
            DatabaseConfiguration.Ipinfo value

    module DatabaseConfigurationFull =

        let web (value: IngestTypes.Web) =
            DatabaseConfigurationFull.Web value

        let local (value: IngestTypes.Local) =
            DatabaseConfigurationFull.Local value

        let maxmind (value: IngestTypes.Maxmind) =
            DatabaseConfigurationFull.Maxmind value

        let ipinfo (value: IngestTypes.Ipinfo) =
            DatabaseConfigurationFull.Ipinfo value

    type DateIndexNameProcessorBuilder() =
        member _.Yield(_: unit) : DateIndexNameProcessor =
            {
                DateFormats = None
                DateRounding = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                IndexNameFormat = None
                IndexNamePrefix = None
                Locale = None
                Timezone = None
            }

        [<CustomOperation("dateFormats")>]
        member _.DateFormats(state: DateIndexNameProcessor, value: string list) =
            { state with DateFormats = Some value }

        [<CustomOperation("dateRounding")>]
        member _.DateRounding(state: DateIndexNameProcessor, value: string) =
            { state with DateRounding = value }

        [<CustomOperation("field")>]
        member _.Field(state: DateIndexNameProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("indexNameFormat")>]
        member _.IndexNameFormat(state: DateIndexNameProcessor, value: string) =
            { state with IndexNameFormat = Some value }

        [<CustomOperation("indexNamePrefix")>]
        member _.IndexNamePrefix(state: DateIndexNameProcessor, value: string) =
            { state with IndexNamePrefix = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: DateIndexNameProcessor, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("timezone")>]
        member _.Timezone(state: DateIndexNameProcessor, value: string) =
            { state with Timezone = Some value }

    let dateIndexNameProcessor = DateIndexNameProcessorBuilder()

    type DateProcessorBuilder() =
        member _.Yield(_: unit) : DateProcessor =
            {
                Field = Unchecked.defaultof<_>
                Formats = Unchecked.defaultof<_>
                Locale = None
                TargetField = None
                Timezone = None
                OutputFormat = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: DateProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("formats")>]
        member _.Formats(state: DateProcessor, value: string list) =
            { state with Formats = value }

        [<CustomOperation("locale")>]
        member _.Locale(state: DateProcessor, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: DateProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("timezone")>]
        member _.Timezone(state: DateProcessor, value: string) =
            { state with Timezone = Some value }

        [<CustomOperation("outputFormat")>]
        member _.OutputFormat(state: DateProcessor, value: string) =
            { state with OutputFormat = Some value }

    let dateProcessor = DateProcessorBuilder()

    type DissectProcessorBuilder() =
        member _.Yield(_: unit) : DissectProcessor =
            {
                AppendSeparator = None
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Pattern = Unchecked.defaultof<_>
            }

        [<CustomOperation("appendSeparator")>]
        member _.AppendSeparator(state: DissectProcessor, value: string) =
            { state with AppendSeparator = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: DissectProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: DissectProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: DissectProcessor, value: string) =
            { state with Pattern = value }

    let dissectProcessor = DissectProcessorBuilder()

    type DocumentBuilder() =
        member _.Yield(_: unit) : Document =
            {
                Id = None
                Index = None
                Source = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: Document, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Document, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Document, value: System.Text.Json.JsonElement) =
            { state with Source = value }

    let document = DocumentBuilder()

    type DocumentSimulationBuilder() =
        member _.Yield(_: unit) : DocumentSimulation =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Ingest = Unchecked.defaultof<_>
                Routing = None
                Source = Unchecked.defaultof<_>
                Version = None
                VersionType = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: DocumentSimulation, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: DocumentSimulation, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: DocumentSimulation, value: IngestTypes.Ingest) =
            { state with Ingest = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: DocumentSimulation, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: DocumentSimulation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Source = value }

        [<CustomOperation("version")>]
        member _.Version(state: DocumentSimulation, value: SpecUtils.Stringified<Types.VersionNumber>) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: DocumentSimulation, value: Types.VersionType) =
            { state with VersionType = Some value }

    let documentSimulation = DocumentSimulationBuilder()

    type DotExpanderProcessorBuilder() =
        member _.Yield(_: unit) : DotExpanderProcessor =
            {
                Field = Unchecked.defaultof<_>
                Override = None
                Path = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: DotExpanderProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("override'")>]
        member _.Override(state: DotExpanderProcessor, value: bool) =
            { state with Override = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: DotExpanderProcessor, value: string) =
            { state with Path = Some value }

    let dotExpanderProcessor = DotExpanderProcessorBuilder()

    type EnrichProcessorBuilder() =
        member _.Yield(_: unit) : EnrichProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                MaxMatches = None
                Override = None
                PolicyName = Unchecked.defaultof<_>
                ShapeRelation = None
                TargetField = Unchecked.defaultof<_>
            }

        [<CustomOperation("field")>]
        member _.Field(state: EnrichProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: EnrichProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("maxMatches")>]
        member _.MaxMatches(state: EnrichProcessor, value: Types.Integer) =
            { state with MaxMatches = Some value }

        [<CustomOperation("override'")>]
        member _.Override(state: EnrichProcessor, value: bool) =
            { state with Override = Some value }

        [<CustomOperation("policyName")>]
        member _.PolicyName(state: EnrichProcessor, value: string) =
            { state with PolicyName = value }

        [<CustomOperation("shapeRelation")>]
        member _.ShapeRelation(state: EnrichProcessor, value: Types.GeoShapeRelation) =
            { state with ShapeRelation = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: EnrichProcessor, value: Types.Field) =
            { state with TargetField = value }

    let enrichProcessor = EnrichProcessorBuilder()

    type FingerprintProcessorBuilder() =
        member _.Yield(_: unit) : FingerprintProcessor =
            {
                Fields = Unchecked.defaultof<_>
                TargetField = None
                Salt = None
                Method = None
                IgnoreMissing = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: FingerprintProcessor, value: Types.Fields) =
            { state with Fields = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: FingerprintProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("salt")>]
        member _.Salt(state: FingerprintProcessor, value: string) =
            { state with Salt = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: FingerprintProcessor, value: IngestTypes.FingerprintDigest) =
            { state with Method = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: FingerprintProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

    let fingerprintProcessor = FingerprintProcessorBuilder()

    type GeoGridProcessorBuilder() =
        member _.Yield(_: unit) : GeoGridProcessor =
            {
                Field = Unchecked.defaultof<_>
                TileType = Unchecked.defaultof<_>
                TargetField = None
                ParentField = None
                ChildrenField = None
                NonChildrenField = None
                PrecisionField = None
                IgnoreMissing = None
                TargetFormat = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: GeoGridProcessor, value: string) =
            { state with Field = value }

        [<CustomOperation("tileType")>]
        member _.TileType(state: GeoGridProcessor, value: IngestTypes.GeoGridTileType) =
            { state with TileType = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: GeoGridProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("parentField")>]
        member _.ParentField(state: GeoGridProcessor, value: Types.Field) =
            { state with ParentField = Some value }

        [<CustomOperation("childrenField")>]
        member _.ChildrenField(state: GeoGridProcessor, value: Types.Field) =
            { state with ChildrenField = Some value }

        [<CustomOperation("nonChildrenField")>]
        member _.NonChildrenField(state: GeoGridProcessor, value: Types.Field) =
            { state with NonChildrenField = Some value }

        [<CustomOperation("precisionField")>]
        member _.PrecisionField(state: GeoGridProcessor, value: Types.Field) =
            { state with PrecisionField = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: GeoGridProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetFormat")>]
        member _.TargetFormat(state: GeoGridProcessor, value: IngestTypes.GeoGridTargetFormat) =
            { state with TargetFormat = Some value }

    let geoGridProcessor = GeoGridProcessorBuilder()

    type GeoIpProcessorBuilder() =
        member _.Yield(_: unit) : GeoIpProcessor =
            {
                DatabaseFile = None
                Field = Unchecked.defaultof<_>
                FirstOnly = None
                IgnoreMissing = None
                Properties = None
                TargetField = None
                DownloadDatabaseOnPipelineCreation = None
            }

        [<CustomOperation("databaseFile")>]
        member _.DatabaseFile(state: GeoIpProcessor, value: string) =
            { state with DatabaseFile = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: GeoIpProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("firstOnly")>]
        member _.FirstOnly(state: GeoIpProcessor, value: bool) =
            { state with FirstOnly = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: GeoIpProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: GeoIpProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: GeoIpProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("downloadDatabaseOnPipelineCreation")>]
        member _.DownloadDatabaseOnPipelineCreation(state: GeoIpProcessor, value: bool) =
            { state with DownloadDatabaseOnPipelineCreation = Some value }

    let geoIpProcessor = GeoIpProcessorBuilder()

    type GrokProcessorBuilder() =
        member _.Yield(_: unit) : GrokProcessor =
            {
                EcsCompatibility = None
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                PatternDefinitions = None
                Patterns = Unchecked.defaultof<_>
                TraceMatch = None
                ValidateOnly = None
            }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: GrokProcessor, value: string) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: GrokProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: GrokProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("patternDefinitions")>]
        member _.PatternDefinitions(state: GrokProcessor, value: Map<string, string>) =
            { state with PatternDefinitions = Some value }

        [<CustomOperation("patterns")>]
        member _.Patterns(state: GrokProcessor, value: Types.GrokPattern list) =
            { state with Patterns = value }

        [<CustomOperation("traceMatch")>]
        member _.TraceMatch(state: GrokProcessor, value: bool) =
            { state with TraceMatch = Some value }

        [<CustomOperation("validateOnly")>]
        member _.ValidateOnly(state: GrokProcessor, value: bool) =
            { state with ValidateOnly = Some value }

    let grokProcessor = GrokProcessorBuilder()

    type GsubProcessorBuilder() =
        member _.Yield(_: unit) : GsubProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Pattern = Unchecked.defaultof<_>
                Replacement = Unchecked.defaultof<_>
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: GsubProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: GsubProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: GsubProcessor, value: string) =
            { state with Pattern = value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: GsubProcessor, value: string) =
            { state with Replacement = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: GsubProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let gsubProcessor = GsubProcessorBuilder()

    type HtmlStripProcessorBuilder() =
        member _.Yield(_: unit) : HtmlStripProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: HtmlStripProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: HtmlStripProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: HtmlStripProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let htmlStripProcessor = HtmlStripProcessorBuilder()

    module InferenceConfig =

        let regression (value: IngestTypes.InferenceConfigRegression) =
            InferenceConfig.Regression value

        let classification (value: IngestTypes.InferenceConfigClassification) =
            InferenceConfig.Classification value

    type InferenceConfigClassificationBuilder() =
        member _.Yield(_: unit) : InferenceConfigClassification =
            {
                NumTopClasses = None
                NumTopFeatureImportanceValues = None
                ResultsField = None
                TopClassesResultsField = None
                PredictionFieldType = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: InferenceConfigClassification, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: InferenceConfigClassification, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: InferenceConfigClassification, value: Types.Field) =
            { state with ResultsField = Some value }

        [<CustomOperation("topClassesResultsField")>]
        member _.TopClassesResultsField(state: InferenceConfigClassification, value: Types.Field) =
            { state with TopClassesResultsField = Some value }

        [<CustomOperation("predictionFieldType")>]
        member _.PredictionFieldType(state: InferenceConfigClassification, value: string) =
            { state with PredictionFieldType = Some value }

    let inferenceConfigClassification = InferenceConfigClassificationBuilder()

    type InferenceConfigRegressionBuilder() =
        member _.Yield(_: unit) : InferenceConfigRegression =
            {
                ResultsField = None
                NumTopFeatureImportanceValues = None
            }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: InferenceConfigRegression, value: Types.Field) =
            { state with ResultsField = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: InferenceConfigRegression, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

    let inferenceConfigRegression = InferenceConfigRegressionBuilder()

    type InferenceProcessorBuilder() =
        member _.Yield(_: unit) : InferenceProcessor =
            {
                ModelId = Unchecked.defaultof<_>
                TargetField = None
                FieldMap = None
                InferenceConfig = None
                InputOutput = None
                IgnoreMissing = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: InferenceProcessor, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: InferenceProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("fieldMap")>]
        member _.FieldMap(state: InferenceProcessor, value: Map<Types.Field, System.Text.Json.JsonElement>) =
            { state with FieldMap = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: InferenceProcessor, value: IngestTypes.InferenceConfig) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("inputOutput")>]
        member _.InputOutput(state: InferenceProcessor, value: System.Text.Json.JsonElement) =
            { state with InputOutput = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: InferenceProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

    let inferenceProcessor = InferenceProcessorBuilder()

    type IngestBuilder() =
        member _.Yield(_: unit) : Ingest =
            {
                Redact = None
                Timestamp = Unchecked.defaultof<_>
                Pipeline = None
            }

        [<CustomOperation("redact")>]
        member _.Redact(state: Ingest, value: IngestTypes.Redact) =
            { state with Redact = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Ingest, value: Types.DateTime) =
            { state with Timestamp = value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Ingest, value: Types.Name) =
            { state with Pipeline = Some value }

    let ingest = IngestBuilder()

    type IpLocationProcessorBuilder() =
        member _.Yield(_: unit) : IpLocationProcessor =
            {
                DatabaseFile = None
                Field = Unchecked.defaultof<_>
                FirstOnly = None
                IgnoreMissing = None
                Properties = None
                TargetField = None
                DownloadDatabaseOnPipelineCreation = None
            }

        [<CustomOperation("databaseFile")>]
        member _.DatabaseFile(state: IpLocationProcessor, value: string) =
            { state with DatabaseFile = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: IpLocationProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("firstOnly")>]
        member _.FirstOnly(state: IpLocationProcessor, value: bool) =
            { state with FirstOnly = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: IpLocationProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: IpLocationProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: IpLocationProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("downloadDatabaseOnPipelineCreation")>]
        member _.DownloadDatabaseOnPipelineCreation(state: IpLocationProcessor, value: bool) =
            { state with DownloadDatabaseOnPipelineCreation = Some value }

    let ipLocationProcessor = IpLocationProcessorBuilder()

    type JsonProcessorBuilder() =
        member _.Yield(_: unit) : JsonProcessor =
            {
                AddToRoot = None
                AddToRootConflictStrategy = None
                AllowDuplicateKeys = None
                Field = Unchecked.defaultof<_>
                TargetField = None
            }

        [<CustomOperation("addToRoot")>]
        member _.AddToRoot(state: JsonProcessor, value: bool) =
            { state with AddToRoot = Some value }

        [<CustomOperation("addToRootConflictStrategy")>]
        member _.AddToRootConflictStrategy(state: JsonProcessor, value: IngestTypes.JsonProcessorConflictStrategy) =
            { state with AddToRootConflictStrategy = Some value }

        [<CustomOperation("allowDuplicateKeys")>]
        member _.AllowDuplicateKeys(state: JsonProcessor, value: bool) =
            { state with AllowDuplicateKeys = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: JsonProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: JsonProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let jsonProcessor = JsonProcessorBuilder()

    type KeyValueProcessorBuilder() =
        member _.Yield(_: unit) : KeyValueProcessor =
            {
                ExcludeKeys = None
                Field = Unchecked.defaultof<_>
                FieldSplit = Unchecked.defaultof<_>
                IgnoreMissing = None
                IncludeKeys = None
                Prefix = None
                StripBrackets = None
                TargetField = None
                TrimKey = None
                TrimValue = None
                ValueSplit = Unchecked.defaultof<_>
            }

        [<CustomOperation("excludeKeys")>]
        member _.ExcludeKeys(state: KeyValueProcessor, value: string list) =
            { state with ExcludeKeys = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: KeyValueProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("fieldSplit")>]
        member _.FieldSplit(state: KeyValueProcessor, value: string) =
            { state with FieldSplit = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: KeyValueProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("includeKeys")>]
        member _.IncludeKeys(state: KeyValueProcessor, value: string list) =
            { state with IncludeKeys = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: KeyValueProcessor, value: string) =
            { state with Prefix = Some value }

        [<CustomOperation("stripBrackets")>]
        member _.StripBrackets(state: KeyValueProcessor, value: bool) =
            { state with StripBrackets = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: KeyValueProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("trimKey")>]
        member _.TrimKey(state: KeyValueProcessor, value: string) =
            { state with TrimKey = Some value }

        [<CustomOperation("trimValue")>]
        member _.TrimValue(state: KeyValueProcessor, value: string) =
            { state with TrimValue = Some value }

        [<CustomOperation("valueSplit")>]
        member _.ValueSplit(state: KeyValueProcessor, value: string) =
            { state with ValueSplit = value }

    let keyValueProcessor = KeyValueProcessorBuilder()

    type LowercaseProcessorBuilder() =
        member _.Yield(_: unit) : LowercaseProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: LowercaseProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: LowercaseProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: LowercaseProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let lowercaseProcessor = LowercaseProcessorBuilder()

    type NetworkDirectionProcessorBuilder() =
        member _.Yield(_: unit) : NetworkDirectionProcessor =
            {
                SourceIp = None
                DestinationIp = None
                TargetField = None
                InternalNetworks = None
                InternalNetworksField = None
                IgnoreMissing = None
            }

        [<CustomOperation("sourceIp")>]
        member _.SourceIp(state: NetworkDirectionProcessor, value: Types.Field) =
            { state with SourceIp = Some value }

        [<CustomOperation("destinationIp")>]
        member _.DestinationIp(state: NetworkDirectionProcessor, value: Types.Field) =
            { state with DestinationIp = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: NetworkDirectionProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("internalNetworks")>]
        member _.InternalNetworks(state: NetworkDirectionProcessor, value: string list) =
            { state with InternalNetworks = Some value }

        [<CustomOperation("internalNetworksField")>]
        member _.InternalNetworksField(state: NetworkDirectionProcessor, value: Types.Field) =
            { state with InternalNetworksField = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: NetworkDirectionProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

    let networkDirectionProcessor = NetworkDirectionProcessorBuilder()

    type PipelineBuilder() =
        member _.Yield(_: unit) : Pipeline =
            {
                Description = None
                OnFailure = None
                Processors = None
                Version = None
                Deprecated = None
                Meta = None
                CreatedDate = None
                CreatedDateMillis = None
                ModifiedDate = None
                ModifiedDateMillis = None
                FieldAccessPattern = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: Pipeline, value: string) =
            { state with Description = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Pipeline, value: IngestTypes.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("processors")>]
        member _.Processors(state: Pipeline, value: IngestTypes.ProcessorContainer list) =
            { state with Processors = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Pipeline, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: Pipeline, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Pipeline, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: Pipeline, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: Pipeline, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Pipeline, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Pipeline, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

        [<CustomOperation("fieldAccessPattern")>]
        member _.FieldAccessPattern(state: Pipeline, value: IngestTypes.FieldAccessPattern) =
            { state with FieldAccessPattern = Some value }

    let pipeline = PipelineBuilder()

    type PipelineConfigBuilder() =
        member _.Yield(_: unit) : PipelineConfig =
            {
                Description = None
                Version = None
                Processors = Unchecked.defaultof<_>
            }

        [<CustomOperation("description")>]
        member _.Description(state: PipelineConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: PipelineConfig, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("processors")>]
        member _.Processors(state: PipelineConfig, value: IngestTypes.ProcessorContainer list) =
            { state with Processors = value }

    let pipelineConfig = PipelineConfigBuilder()

    type PipelineProcessorResultBuilder() =
        member _.Yield(_: unit) : PipelineProcessorResult =
            {
                Doc = None
                Tag = None
                ProcessorType = None
                Status = None
                Description = None
                IgnoredError = None
                Error = None
            }

        [<CustomOperation("doc")>]
        member _.Doc(state: PipelineProcessorResult, value: IngestTypes.DocumentSimulation) =
            { state with Doc = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: PipelineProcessorResult, value: string) =
            { state with Tag = Some value }

        [<CustomOperation("processorType")>]
        member _.ProcessorType(state: PipelineProcessorResult, value: string) =
            { state with ProcessorType = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: PipelineProcessorResult, value: IngestTypes.PipelineSimulationStatusOptions) =
            { state with Status = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: PipelineProcessorResult, value: string) =
            { state with Description = Some value }

        [<CustomOperation("ignoredError")>]
        member _.IgnoredError(state: PipelineProcessorResult, value: Types.ErrorCause) =
            { state with IgnoredError = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: PipelineProcessorResult, value: Types.ErrorCause) =
            { state with Error = Some value }

    let pipelineProcessorResult = PipelineProcessorResultBuilder()

    type ProcessorBaseBuilder() =
        member _.Yield(_: unit) : ProcessorBase =
            {
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: ProcessorBase, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: ProcessorBase, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: ProcessorBase, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: ProcessorBase, value: IngestTypes.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: ProcessorBase, value: string) =
            { state with Tag = Some value }

    let processorBase = ProcessorBaseBuilder()

    module Processor =

        let append (value: IngestTypes.AppendProcessor) =
            ProcessorContainer.Append value

        let attachment (value: IngestTypes.AttachmentProcessor) =
            ProcessorContainer.Attachment value

        let bytes (value: IngestTypes.BytesProcessor) =
            ProcessorContainer.Bytes value

        let cef (value: IngestTypes.CefProcessor) =
            ProcessorContainer.Cef value

        let circle (value: IngestTypes.CircleProcessor) =
            ProcessorContainer.Circle value

        let communityId (value: IngestTypes.CommunityIDProcessor) =
            ProcessorContainer.CommunityId value

        let convert (value: IngestTypes.ConvertProcessor) =
            ProcessorContainer.Convert value

        let csv (value: IngestTypes.CsvProcessor) =
            ProcessorContainer.Csv value

        let date (value: IngestTypes.DateProcessor) =
            ProcessorContainer.Date value

        let dateIndexName (value: IngestTypes.DateIndexNameProcessor) =
            ProcessorContainer.DateIndexName value

        let dissect (value: IngestTypes.DissectProcessor) =
            ProcessorContainer.Dissect value

        let dotExpander (value: IngestTypes.DotExpanderProcessor) =
            ProcessorContainer.DotExpander value

        let drop (value: IngestTypes.DropProcessor) =
            ProcessorContainer.Drop value

        let enrich (value: IngestTypes.EnrichProcessor) =
            ProcessorContainer.Enrich value

        let fail (value: IngestTypes.FailProcessor) =
            ProcessorContainer.Fail value

        let fingerprint (value: IngestTypes.FingerprintProcessor) =
            ProcessorContainer.Fingerprint value

        let foreach (value: IngestTypes.ForeachProcessor) =
            ProcessorContainer.Foreach value

        let ipLocation (value: IngestTypes.IpLocationProcessor) =
            ProcessorContainer.IpLocation value

        let geoGrid (value: IngestTypes.GeoGridProcessor) =
            ProcessorContainer.GeoGrid value

        let geoip (value: IngestTypes.GeoIpProcessor) =
            ProcessorContainer.Geoip value

        let grok (value: IngestTypes.GrokProcessor) =
            ProcessorContainer.Grok value

        let gsub (value: IngestTypes.GsubProcessor) =
            ProcessorContainer.Gsub value

        let htmlStrip (value: IngestTypes.HtmlStripProcessor) =
            ProcessorContainer.HtmlStrip value

        let inference (value: IngestTypes.InferenceProcessor) =
            ProcessorContainer.Inference value

        let join (value: IngestTypes.JoinProcessor) =
            ProcessorContainer.Join value

        let json (value: IngestTypes.JsonProcessor) =
            ProcessorContainer.Json value

        let kv (value: IngestTypes.KeyValueProcessor) =
            ProcessorContainer.Kv value

        let lowercase (value: IngestTypes.LowercaseProcessor) =
            ProcessorContainer.Lowercase value

        let networkDirection (value: IngestTypes.NetworkDirectionProcessor) =
            ProcessorContainer.NetworkDirection value

        let pipeline (value: IngestTypes.PipelineProcessor) =
            ProcessorContainer.Pipeline value

        let redact (value: IngestTypes.RedactProcessor) =
            ProcessorContainer.Redact value

        let registeredDomain (value: IngestTypes.RegisteredDomainProcessor) =
            ProcessorContainer.RegisteredDomain value

        let remove (value: IngestTypes.RemoveProcessor) =
            ProcessorContainer.Remove value

        let rename (value: IngestTypes.RenameProcessor) =
            ProcessorContainer.Rename value

        let reroute (value: IngestTypes.RerouteProcessor) =
            ProcessorContainer.Reroute value

        let script (value: IngestTypes.ScriptProcessor) =
            ProcessorContainer.Script value

        let set (value: IngestTypes.SetProcessor) =
            ProcessorContainer.Set value

        let setSecurityUser (value: IngestTypes.SetSecurityUserProcessor) =
            ProcessorContainer.SetSecurityUser value

        let sort (value: IngestTypes.SortProcessor) =
            ProcessorContainer.Sort value

        let split (value: IngestTypes.SplitProcessor) =
            ProcessorContainer.Split value

        let terminate (value: IngestTypes.TerminateProcessor) =
            ProcessorContainer.Terminate value

        let trim (value: IngestTypes.TrimProcessor) =
            ProcessorContainer.Trim value

        let uppercase (value: IngestTypes.UppercaseProcessor) =
            ProcessorContainer.Uppercase value

        let urldecode (value: IngestTypes.UrlDecodeProcessor) =
            ProcessorContainer.Urldecode value

        let uriParts (value: IngestTypes.UriPartsProcessor) =
            ProcessorContainer.UriParts value

        let userAgent (value: IngestTypes.UserAgentProcessor) =
            ProcessorContainer.UserAgent value

    type RedactProcessorBuilder() =
        member _.Yield(_: unit) : RedactProcessor =
            {
                Field = Unchecked.defaultof<_>
                Patterns = Unchecked.defaultof<_>
                PatternDefinitions = None
                Prefix = None
                Suffix = None
                IgnoreMissing = None
                SkipIfUnlicensed = None
                TraceRedact = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: RedactProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("patterns")>]
        member _.Patterns(state: RedactProcessor, value: Types.GrokPattern list) =
            { state with Patterns = value }

        [<CustomOperation("patternDefinitions")>]
        member _.PatternDefinitions(state: RedactProcessor, value: Map<string, string>) =
            { state with PatternDefinitions = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: RedactProcessor, value: string) =
            { state with Prefix = Some value }

        [<CustomOperation("suffix")>]
        member _.Suffix(state: RedactProcessor, value: string) =
            { state with Suffix = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: RedactProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("skipIfUnlicensed")>]
        member _.SkipIfUnlicensed(state: RedactProcessor, value: bool) =
            { state with SkipIfUnlicensed = Some value }

        [<CustomOperation("traceRedact")>]
        member _.TraceRedact(state: RedactProcessor, value: bool) =
            { state with TraceRedact = Some value }

    let redactProcessor = RedactProcessorBuilder()

    type RegisteredDomainProcessorBuilder() =
        member _.Yield(_: unit) : RegisteredDomainProcessor =
            {
                Field = Unchecked.defaultof<_>
                TargetField = None
                IgnoreMissing = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: RegisteredDomainProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: RegisteredDomainProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: RegisteredDomainProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

    let registeredDomainProcessor = RegisteredDomainProcessorBuilder()

    type RemoveProcessorBuilder() =
        member _.Yield(_: unit) : RemoveProcessor =
            {
                Field = Unchecked.defaultof<_>
                Keep = None
                IgnoreMissing = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: RemoveProcessor, value: Types.Fields) =
            { state with Field = value }

        [<CustomOperation("keep")>]
        member _.Keep(state: RemoveProcessor, value: Types.Fields) =
            { state with Keep = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: RemoveProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

    let removeProcessor = RemoveProcessorBuilder()

    type RerouteProcessorBuilder() =
        member _.Yield(_: unit) : RerouteProcessor =
            {
                Destination = None
                Dataset = None
                Namespace = None
            }

        [<CustomOperation("destination")>]
        member _.Destination(state: RerouteProcessor, value: string) =
            { state with Destination = Some value }

        [<CustomOperation("dataset")>]
        member _.Dataset(state: RerouteProcessor, value: System.Text.Json.JsonElement) =
            { state with Dataset = Some value }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: RerouteProcessor, value: System.Text.Json.JsonElement) =
            { state with Namespace = Some value }

    let rerouteProcessor = RerouteProcessorBuilder()

    type ScriptProcessorBuilder() =
        member _.Yield(_: unit) : ScriptProcessor =
            {
                Id = None
                Lang = None
                Params = None
                Source = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: ScriptProcessor, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: ScriptProcessor, value: Types.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: ScriptProcessor, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ScriptProcessor, value: Types.ScriptSource) =
            { state with Source = Some value }

    let scriptProcessor = ScriptProcessorBuilder()

    type SetProcessorBuilder() =
        member _.Yield(_: unit) : SetProcessor =
            {
                CopyFrom = None
                Field = Unchecked.defaultof<_>
                IgnoreEmptyValue = None
                MediaType = None
                Override = None
                Value = None
            }

        [<CustomOperation("copyFrom")>]
        member _.CopyFrom(state: SetProcessor, value: Types.Field) =
            { state with CopyFrom = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: SetProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreEmptyValue")>]
        member _.IgnoreEmptyValue(state: SetProcessor, value: bool) =
            { state with IgnoreEmptyValue = Some value }

        [<CustomOperation("mediaType")>]
        member _.MediaType(state: SetProcessor, value: string) =
            { state with MediaType = Some value }

        [<CustomOperation("override'")>]
        member _.Override(state: SetProcessor, value: bool) =
            { state with Override = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: SetProcessor, value: System.Text.Json.JsonElement) =
            { state with Value = Some value }

    let setProcessor = SetProcessorBuilder()

    type SimulateDocumentResultBuilder() =
        member _.Yield(_: unit) : SimulateDocumentResult =
            {
                Doc = None
                Error = None
                ProcessorResults = None
            }

        [<CustomOperation("doc")>]
        member _.Doc(state: SimulateDocumentResult, value: IngestTypes.DocumentSimulation) =
            { state with Doc = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: SimulateDocumentResult, value: Types.ErrorCause) =
            { state with Error = Some value }

        [<CustomOperation("processorResults")>]
        member _.ProcessorResults(state: SimulateDocumentResult, value: IngestTypes.PipelineProcessorResult list) =
            { state with ProcessorResults = Some value }

    let simulateDocumentResult = SimulateDocumentResultBuilder()

    type SortProcessorBuilder() =
        member _.Yield(_: unit) : SortProcessor =
            {
                Field = Unchecked.defaultof<_>
                Order = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: SortProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("order")>]
        member _.Order(state: SortProcessor, value: Types.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: SortProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let sortProcessor = SortProcessorBuilder()

    type SplitProcessorBuilder() =
        member _.Yield(_: unit) : SplitProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                PreserveTrailing = None
                Separator = Unchecked.defaultof<_>
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: SplitProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: SplitProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("preserveTrailing")>]
        member _.PreserveTrailing(state: SplitProcessor, value: bool) =
            { state with PreserveTrailing = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: SplitProcessor, value: string) =
            { state with Separator = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: SplitProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let splitProcessor = SplitProcessorBuilder()

    type TrimProcessorBuilder() =
        member _.Yield(_: unit) : TrimProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: TrimProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: TrimProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: TrimProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let trimProcessor = TrimProcessorBuilder()

    type UppercaseProcessorBuilder() =
        member _.Yield(_: unit) : UppercaseProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: UppercaseProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: UppercaseProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: UppercaseProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let uppercaseProcessor = UppercaseProcessorBuilder()

    type UriPartsProcessorBuilder() =
        member _.Yield(_: unit) : UriPartsProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                KeepOriginal = None
                RemoveIfSuccessful = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: UriPartsProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: UriPartsProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("keepOriginal")>]
        member _.KeepOriginal(state: UriPartsProcessor, value: bool) =
            { state with KeepOriginal = Some value }

        [<CustomOperation("removeIfSuccessful")>]
        member _.RemoveIfSuccessful(state: UriPartsProcessor, value: bool) =
            { state with RemoveIfSuccessful = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: UriPartsProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let uriPartsProcessor = UriPartsProcessorBuilder()

    type UrlDecodeProcessorBuilder() =
        member _.Yield(_: unit) : UrlDecodeProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: UrlDecodeProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: UrlDecodeProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: UrlDecodeProcessor, value: Types.Field) =
            { state with TargetField = Some value }

    let urlDecodeProcessor = UrlDecodeProcessorBuilder()

    type UserAgentProcessorBuilder() =
        member _.Yield(_: unit) : UserAgentProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                RegexFile = None
                TargetField = None
                Properties = None
                ExtractDeviceType = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: UserAgentProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: UserAgentProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("regexFile")>]
        member _.RegexFile(state: UserAgentProcessor, value: string) =
            { state with RegexFile = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: UserAgentProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: UserAgentProcessor, value: IngestTypes.UserAgentProperty list) =
            { state with Properties = Some value }

        [<CustomOperation("extractDeviceType")>]
        member _.ExtractDeviceType(state: UserAgentProcessor, value: bool) =
            { state with ExtractDeviceType = Some value }

    let userAgentProcessor = UserAgentProcessorBuilder()

