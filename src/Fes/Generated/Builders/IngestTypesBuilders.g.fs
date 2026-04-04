// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IngestTypesBuilders =

    type AppendProcessorBuilder() =
        member _.Yield(_: unit) : Types.AppendProcessor =
            {
                Field = Unchecked.defaultof<_>
                Value = None
                MediaType = None
                CopyFrom = None
                AllowDuplicates = None
                IgnoreEmptyValues = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.AppendProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.AppendProcessor, value: System.Text.Json.JsonElement) =
            { state with Value = Some value }

        [<CustomOperation("mediaType")>]
        member _.MediaType(state: Types.AppendProcessor, value: string) =
            { state with MediaType = Some value }

        [<CustomOperation("copyFrom")>]
        member _.CopyFrom(state: Types.AppendProcessor, value: Types.Field) =
            { state with CopyFrom = Some value }

        [<CustomOperation("allowDuplicates")>]
        member _.AllowDuplicates(state: Types.AppendProcessor, value: bool) =
            { state with AllowDuplicates = Some value }

        [<CustomOperation("ignoreEmptyValues")>]
        member _.IgnoreEmptyValues(state: Types.AppendProcessor, value: bool) =
            { state with IgnoreEmptyValues = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.AppendProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.AppendProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.AppendProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.AppendProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.AppendProcessor, value: string) =
            { state with Tag = Some value }

    let appendProcessor = AppendProcessorBuilder()

    type AttachmentProcessorBuilder() =
        member _.Yield(_: unit) : Types.AttachmentProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                IndexedChars = None
                IndexedCharsField = None
                Properties = None
                TargetField = None
                RemoveBinary = None
                ResourceName = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.AttachmentProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.AttachmentProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("indexedChars")>]
        member _.IndexedChars(state: Types.AttachmentProcessor, value: Types.Long) =
            { state with IndexedChars = Some value }

        [<CustomOperation("indexedCharsField")>]
        member _.IndexedCharsField(state: Types.AttachmentProcessor, value: Types.Field) =
            { state with IndexedCharsField = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.AttachmentProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.AttachmentProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("removeBinary")>]
        member _.RemoveBinary(state: Types.AttachmentProcessor, value: bool) =
            { state with RemoveBinary = Some value }

        [<CustomOperation("resourceName")>]
        member _.ResourceName(state: Types.AttachmentProcessor, value: string) =
            { state with ResourceName = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.AttachmentProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.AttachmentProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.AttachmentProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.AttachmentProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.AttachmentProcessor, value: string) =
            { state with Tag = Some value }

    let attachmentProcessor = AttachmentProcessorBuilder()

    type BytesProcessorBuilder() =
        member _.Yield(_: unit) : Types.BytesProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.BytesProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.BytesProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.BytesProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.BytesProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.BytesProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.BytesProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.BytesProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.BytesProcessor, value: string) =
            { state with Tag = Some value }

    let bytesProcessor = BytesProcessorBuilder()

    type CefProcessorBuilder() =
        member _.Yield(_: unit) : Types.CefProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                IgnoreEmptyValues = None
                Timezone = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.CefProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.CefProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.CefProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("ignoreEmptyValues")>]
        member _.IgnoreEmptyValues(state: Types.CefProcessor, value: bool) =
            { state with IgnoreEmptyValues = Some value }

        [<CustomOperation("timezone")>]
        member _.Timezone(state: Types.CefProcessor, value: string) =
            { state with Timezone = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.CefProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.CefProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.CefProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.CefProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.CefProcessor, value: string) =
            { state with Tag = Some value }

    let cefProcessor = CefProcessorBuilder()

    type CircleProcessorBuilder() =
        member _.Yield(_: unit) : Types.CircleProcessor =
            {
                ErrorDistance = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                ShapeType = Unchecked.defaultof<_>
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("errorDistance")>]
        member _.ErrorDistance(state: Types.CircleProcessor, value: Types.Double) =
            { state with ErrorDistance = value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.CircleProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.CircleProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("shapeType")>]
        member _.ShapeType(state: Types.CircleProcessor, value: Types.ShapeType) =
            { state with ShapeType = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.CircleProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.CircleProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.CircleProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.CircleProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.CircleProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.CircleProcessor, value: string) =
            { state with Tag = Some value }

    let circleProcessor = CircleProcessorBuilder()

    type CommunityIDProcessorBuilder() =
        member _.Yield(_: unit) : Types.CommunityIDProcessor =
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
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("sourceIp")>]
        member _.SourceIp(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with SourceIp = Some value }

        [<CustomOperation("sourcePort")>]
        member _.SourcePort(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with SourcePort = Some value }

        [<CustomOperation("destinationIp")>]
        member _.DestinationIp(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with DestinationIp = Some value }

        [<CustomOperation("destinationPort")>]
        member _.DestinationPort(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with DestinationPort = Some value }

        [<CustomOperation("ianaNumber")>]
        member _.IanaNumber(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with IanaNumber = Some value }

        [<CustomOperation("icmpType")>]
        member _.IcmpType(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with IcmpType = Some value }

        [<CustomOperation("icmpCode")>]
        member _.IcmpCode(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with IcmpCode = Some value }

        [<CustomOperation("transport")>]
        member _.Transport(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with Transport = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.CommunityIDProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("seed")>]
        member _.Seed(state: Types.CommunityIDProcessor, value: Types.Integer) =
            { state with Seed = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.CommunityIDProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.CommunityIDProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.CommunityIDProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.CommunityIDProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.CommunityIDProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.CommunityIDProcessor, value: string) =
            { state with Tag = Some value }

    let communityIDProcessor = CommunityIDProcessorBuilder()

    type ConvertProcessorBuilder() =
        member _.Yield(_: unit) : Types.ConvertProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Type = Unchecked.defaultof<_>
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.ConvertProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.ConvertProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.ConvertProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ConvertProcessor, value: Types.ConvertType) =
            { state with Type = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.ConvertProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.ConvertProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.ConvertProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.ConvertProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.ConvertProcessor, value: string) =
            { state with Tag = Some value }

    let convertProcessor = ConvertProcessorBuilder()

    type CsvProcessorBuilder() =
        member _.Yield(_: unit) : Types.CsvProcessor =
            {
                EmptyValue = None
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Quote = None
                Separator = None
                TargetFields = Unchecked.defaultof<_>
                Trim = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("emptyValue")>]
        member _.EmptyValue(state: Types.CsvProcessor, value: System.Text.Json.JsonElement) =
            { state with EmptyValue = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.CsvProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.CsvProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("quote")>]
        member _.Quote(state: Types.CsvProcessor, value: string) =
            { state with Quote = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.CsvProcessor, value: string) =
            { state with Separator = Some value }

        [<CustomOperation("targetFields")>]
        member _.TargetFields(state: Types.CsvProcessor, value: Types.Fields) =
            { state with TargetFields = value }

        [<CustomOperation("trim")>]
        member _.Trim(state: Types.CsvProcessor, value: bool) =
            { state with Trim = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.CsvProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.CsvProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.CsvProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.CsvProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.CsvProcessor, value: string) =
            { state with Tag = Some value }

    let csvProcessor = CsvProcessorBuilder()

    module DatabaseConfiguration =

        let maxmind (value: Types.Maxmind) =
            Types.DatabaseConfiguration.Maxmind value

        let ipinfo (value: Types.Ipinfo) =
            Types.DatabaseConfiguration.Ipinfo value

    module DatabaseConfigurationFull =

        let web (value: Types.Web) =
            Types.DatabaseConfigurationFull.Web value

        let local (value: Types.Local) =
            Types.DatabaseConfigurationFull.Local value

        let maxmind (value: Types.Maxmind) =
            Types.DatabaseConfigurationFull.Maxmind value

        let ipinfo (value: Types.Ipinfo) =
            Types.DatabaseConfigurationFull.Ipinfo value

    type DateIndexNameProcessorBuilder() =
        member _.Yield(_: unit) : Types.DateIndexNameProcessor =
            {
                DateFormats = None
                DateRounding = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                IndexNameFormat = None
                IndexNamePrefix = None
                Locale = None
                Timezone = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("dateFormats")>]
        member _.DateFormats(state: Types.DateIndexNameProcessor, value: string list) =
            { state with DateFormats = Some value }

        [<CustomOperation("dateRounding")>]
        member _.DateRounding(state: Types.DateIndexNameProcessor, value: string) =
            { state with DateRounding = value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DateIndexNameProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("indexNameFormat")>]
        member _.IndexNameFormat(state: Types.DateIndexNameProcessor, value: string) =
            { state with IndexNameFormat = Some value }

        [<CustomOperation("indexNamePrefix")>]
        member _.IndexNamePrefix(state: Types.DateIndexNameProcessor, value: string) =
            { state with IndexNamePrefix = Some value }

        [<CustomOperation("locale")>]
        member _.Locale(state: Types.DateIndexNameProcessor, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("timezone")>]
        member _.Timezone(state: Types.DateIndexNameProcessor, value: string) =
            { state with Timezone = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DateIndexNameProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.DateIndexNameProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.DateIndexNameProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.DateIndexNameProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.DateIndexNameProcessor, value: string) =
            { state with Tag = Some value }

    let dateIndexNameProcessor = DateIndexNameProcessorBuilder()

    type DateProcessorBuilder() =
        member _.Yield(_: unit) : Types.DateProcessor =
            {
                Field = Unchecked.defaultof<_>
                Formats = Unchecked.defaultof<_>
                Locale = None
                TargetField = None
                Timezone = None
                OutputFormat = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DateProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("formats")>]
        member _.Formats(state: Types.DateProcessor, value: string list) =
            { state with Formats = value }

        [<CustomOperation("locale")>]
        member _.Locale(state: Types.DateProcessor, value: string) =
            { state with Locale = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.DateProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("timezone")>]
        member _.Timezone(state: Types.DateProcessor, value: string) =
            { state with Timezone = Some value }

        [<CustomOperation("outputFormat")>]
        member _.OutputFormat(state: Types.DateProcessor, value: string) =
            { state with OutputFormat = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DateProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.DateProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.DateProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.DateProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.DateProcessor, value: string) =
            { state with Tag = Some value }

    let dateProcessor = DateProcessorBuilder()

    type DissectProcessorBuilder() =
        member _.Yield(_: unit) : Types.DissectProcessor =
            {
                AppendSeparator = None
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Pattern = Unchecked.defaultof<_>
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("appendSeparator")>]
        member _.AppendSeparator(state: Types.DissectProcessor, value: string) =
            { state with AppendSeparator = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DissectProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.DissectProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.DissectProcessor, value: string) =
            { state with Pattern = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DissectProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.DissectProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.DissectProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.DissectProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.DissectProcessor, value: string) =
            { state with Tag = Some value }

    let dissectProcessor = DissectProcessorBuilder()

    type DocumentBuilder() =
        member _.Yield(_: unit) : Types.Document =
            {
                Id = None
                Index = None
                Source = Unchecked.defaultof<_>
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.Document, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.Document, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.Document, value: System.Text.Json.JsonElement) =
            { state with Source = value }

    let document = DocumentBuilder()

    type DocumentSimulationBuilder() =
        member _.Yield(_: unit) : Types.DocumentSimulation =
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
        member _.Id(state: Types.DocumentSimulation, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.DocumentSimulation, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("ingest")>]
        member _.Ingest(state: Types.DocumentSimulation, value: Types.IngestTypesIngest) =
            { state with Ingest = value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.DocumentSimulation, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.DocumentSimulation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Source = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.DocumentSimulation, value: Types.Stringified<Types.VersionNumber>) =
            { state with Version = Some value }

        [<CustomOperation("versionType")>]
        member _.VersionType(state: Types.DocumentSimulation, value: Types.VersionType) =
            { state with VersionType = Some value }

    let documentSimulation = DocumentSimulationBuilder()

    type DotExpanderProcessorBuilder() =
        member _.Yield(_: unit) : Types.DotExpanderProcessor =
            {
                Field = Unchecked.defaultof<_>
                Override = None
                Path = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DotExpanderProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("override'")>]
        member _.Override(state: Types.DotExpanderProcessor, value: bool) =
            { state with Override = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.DotExpanderProcessor, value: string) =
            { state with Path = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DotExpanderProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.DotExpanderProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.DotExpanderProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.DotExpanderProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.DotExpanderProcessor, value: string) =
            { state with Tag = Some value }

    let dotExpanderProcessor = DotExpanderProcessorBuilder()

    type DropProcessorBuilder() =
        member _.Yield(_: unit) : Types.DropProcessor =
            {
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: Types.DropProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.DropProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.DropProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.DropProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.DropProcessor, value: string) =
            { state with Tag = Some value }

    let dropProcessor = DropProcessorBuilder()

    type EnrichProcessorBuilder() =
        member _.Yield(_: unit) : Types.EnrichProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                MaxMatches = None
                Override = None
                PolicyName = Unchecked.defaultof<_>
                ShapeRelation = None
                TargetField = Unchecked.defaultof<_>
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.EnrichProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.EnrichProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("maxMatches")>]
        member _.MaxMatches(state: Types.EnrichProcessor, value: Types.Integer) =
            { state with MaxMatches = Some value }

        [<CustomOperation("override'")>]
        member _.Override(state: Types.EnrichProcessor, value: bool) =
            { state with Override = Some value }

        [<CustomOperation("policyName")>]
        member _.PolicyName(state: Types.EnrichProcessor, value: string) =
            { state with PolicyName = value }

        [<CustomOperation("shapeRelation")>]
        member _.ShapeRelation(state: Types.EnrichProcessor, value: Types.GeoShapeRelation) =
            { state with ShapeRelation = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.EnrichProcessor, value: Types.Field) =
            { state with TargetField = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.EnrichProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.EnrichProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.EnrichProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.EnrichProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.EnrichProcessor, value: string) =
            { state with Tag = Some value }

    let enrichProcessor = EnrichProcessorBuilder()

    type FailProcessorBuilder() =
        member _.Yield(_: unit) : Types.FailProcessor =
            {
                Message = Unchecked.defaultof<_>
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("message")>]
        member _.Message(state: Types.FailProcessor, value: string) =
            { state with Message = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.FailProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.FailProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.FailProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.FailProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.FailProcessor, value: string) =
            { state with Tag = Some value }

    let failProcessor = FailProcessorBuilder()

    type FingerprintProcessorBuilder() =
        member _.Yield(_: unit) : Types.FingerprintProcessor =
            {
                Fields = Unchecked.defaultof<_>
                TargetField = None
                Salt = None
                Method = None
                IgnoreMissing = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FingerprintProcessor, value: Types.Fields) =
            { state with Fields = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.FingerprintProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("salt")>]
        member _.Salt(state: Types.FingerprintProcessor, value: string) =
            { state with Salt = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: Types.FingerprintProcessor, value: Types.FingerprintDigest) =
            { state with Method = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.FingerprintProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.FingerprintProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.FingerprintProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.FingerprintProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.FingerprintProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.FingerprintProcessor, value: string) =
            { state with Tag = Some value }

    let fingerprintProcessor = FingerprintProcessorBuilder()

    type ForeachProcessorBuilder() =
        member _.Yield(_: unit) : Types.ForeachProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Processor = Unchecked.defaultof<_>
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.ForeachProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.ForeachProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("processor")>]
        member _.Processor(state: Types.ForeachProcessor, value: Types.ProcessorContainer) =
            { state with Processor = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.ForeachProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.ForeachProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.ForeachProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.ForeachProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.ForeachProcessor, value: string) =
            { state with Tag = Some value }

    let foreachProcessor = ForeachProcessorBuilder()

    type GeoGridProcessorBuilder() =
        member _.Yield(_: unit) : Types.GeoGridProcessor =
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
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GeoGridProcessor, value: string) =
            { state with Field = value }

        [<CustomOperation("tileType")>]
        member _.TileType(state: Types.GeoGridProcessor, value: Types.GeoGridTileType) =
            { state with TileType = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.GeoGridProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("parentField")>]
        member _.ParentField(state: Types.GeoGridProcessor, value: Types.Field) =
            { state with ParentField = Some value }

        [<CustomOperation("childrenField")>]
        member _.ChildrenField(state: Types.GeoGridProcessor, value: Types.Field) =
            { state with ChildrenField = Some value }

        [<CustomOperation("nonChildrenField")>]
        member _.NonChildrenField(state: Types.GeoGridProcessor, value: Types.Field) =
            { state with NonChildrenField = Some value }

        [<CustomOperation("precisionField")>]
        member _.PrecisionField(state: Types.GeoGridProcessor, value: Types.Field) =
            { state with PrecisionField = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.GeoGridProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetFormat")>]
        member _.TargetFormat(state: Types.GeoGridProcessor, value: Types.GeoGridTargetFormat) =
            { state with TargetFormat = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.GeoGridProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.GeoGridProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.GeoGridProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.GeoGridProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.GeoGridProcessor, value: string) =
            { state with Tag = Some value }

    let geoGridProcessor = GeoGridProcessorBuilder()

    type GeoIpProcessorBuilder() =
        member _.Yield(_: unit) : Types.GeoIpProcessor =
            {
                DatabaseFile = None
                Field = Unchecked.defaultof<_>
                FirstOnly = None
                IgnoreMissing = None
                Properties = None
                TargetField = None
                DownloadDatabaseOnPipelineCreation = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("databaseFile")>]
        member _.DatabaseFile(state: Types.GeoIpProcessor, value: string) =
            { state with DatabaseFile = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GeoIpProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("firstOnly")>]
        member _.FirstOnly(state: Types.GeoIpProcessor, value: bool) =
            { state with FirstOnly = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.GeoIpProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.GeoIpProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.GeoIpProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("downloadDatabaseOnPipelineCreation")>]
        member _.DownloadDatabaseOnPipelineCreation(state: Types.GeoIpProcessor, value: bool) =
            { state with DownloadDatabaseOnPipelineCreation = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.GeoIpProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.GeoIpProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.GeoIpProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.GeoIpProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.GeoIpProcessor, value: string) =
            { state with Tag = Some value }

    let geoIpProcessor = GeoIpProcessorBuilder()

    type GrokProcessorBuilder() =
        member _.Yield(_: unit) : Types.GrokProcessor =
            {
                EcsCompatibility = None
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                PatternDefinitions = None
                Patterns = Unchecked.defaultof<_>
                TraceMatch = None
                ValidateOnly = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("ecsCompatibility")>]
        member _.EcsCompatibility(state: Types.GrokProcessor, value: string) =
            { state with EcsCompatibility = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GrokProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.GrokProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("patternDefinitions")>]
        member _.PatternDefinitions(state: Types.GrokProcessor, value: Map<string, string>) =
            { state with PatternDefinitions = Some value }

        [<CustomOperation("patterns")>]
        member _.Patterns(state: Types.GrokProcessor, value: Types.GrokPattern list) =
            { state with Patterns = value }

        [<CustomOperation("traceMatch")>]
        member _.TraceMatch(state: Types.GrokProcessor, value: bool) =
            { state with TraceMatch = Some value }

        [<CustomOperation("validateOnly")>]
        member _.ValidateOnly(state: Types.GrokProcessor, value: bool) =
            { state with ValidateOnly = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.GrokProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.GrokProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.GrokProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.GrokProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.GrokProcessor, value: string) =
            { state with Tag = Some value }

    let grokProcessor = GrokProcessorBuilder()

    type GsubProcessorBuilder() =
        member _.Yield(_: unit) : Types.GsubProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                Pattern = Unchecked.defaultof<_>
                Replacement = Unchecked.defaultof<_>
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.GsubProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.GsubProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("pattern")>]
        member _.Pattern(state: Types.GsubProcessor, value: string) =
            { state with Pattern = value }

        [<CustomOperation("replacement")>]
        member _.Replacement(state: Types.GsubProcessor, value: string) =
            { state with Replacement = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.GsubProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.GsubProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.GsubProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.GsubProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.GsubProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.GsubProcessor, value: string) =
            { state with Tag = Some value }

    let gsubProcessor = GsubProcessorBuilder()

    type HtmlStripProcessorBuilder() =
        member _.Yield(_: unit) : Types.HtmlStripProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.HtmlStripProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.HtmlStripProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.HtmlStripProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.HtmlStripProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.HtmlStripProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.HtmlStripProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.HtmlStripProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.HtmlStripProcessor, value: string) =
            { state with Tag = Some value }

    let htmlStripProcessor = HtmlStripProcessorBuilder()

    module InferenceConfig =

        let regression (value: Types.InferenceConfigRegression) =
            Types.InferenceConfig.Regression value

        let classification (value: Types.InferenceConfigClassification) =
            Types.InferenceConfig.Classification value

    type InferenceConfigClassificationBuilder() =
        member _.Yield(_: unit) : Types.InferenceConfigClassification =
            {
                NumTopClasses = None
                NumTopFeatureImportanceValues = None
                ResultsField = None
                TopClassesResultsField = None
                PredictionFieldType = None
            }

        [<CustomOperation("numTopClasses")>]
        member _.NumTopClasses(state: Types.InferenceConfigClassification, value: Types.Integer) =
            { state with NumTopClasses = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: Types.InferenceConfigClassification, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.InferenceConfigClassification, value: Types.Field) =
            { state with ResultsField = Some value }

        [<CustomOperation("topClassesResultsField")>]
        member _.TopClassesResultsField(state: Types.InferenceConfigClassification, value: Types.Field) =
            { state with TopClassesResultsField = Some value }

        [<CustomOperation("predictionFieldType")>]
        member _.PredictionFieldType(state: Types.InferenceConfigClassification, value: string) =
            { state with PredictionFieldType = Some value }

    let inferenceConfigClassification = InferenceConfigClassificationBuilder()

    type InferenceConfigRegressionBuilder() =
        member _.Yield(_: unit) : Types.InferenceConfigRegression =
            {
                ResultsField = None
                NumTopFeatureImportanceValues = None
            }

        [<CustomOperation("resultsField")>]
        member _.ResultsField(state: Types.InferenceConfigRegression, value: Types.Field) =
            { state with ResultsField = Some value }

        [<CustomOperation("numTopFeatureImportanceValues")>]
        member _.NumTopFeatureImportanceValues(state: Types.InferenceConfigRegression, value: Types.Integer) =
            { state with NumTopFeatureImportanceValues = Some value }

    let inferenceConfigRegression = InferenceConfigRegressionBuilder()

    type InferenceProcessorBuilder() =
        member _.Yield(_: unit) : Types.InferenceProcessor =
            {
                ModelId = Unchecked.defaultof<_>
                TargetField = None
                FieldMap = None
                InferenceConfig = None
                InputOutput = None
                IgnoreMissing = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("modelId")>]
        member _.ModelId(state: Types.InferenceProcessor, value: Types.Id) =
            { state with ModelId = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.InferenceProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("fieldMap")>]
        member _.FieldMap(state: Types.InferenceProcessor, value: Map<Types.Field, System.Text.Json.JsonElement>) =
            { state with FieldMap = Some value }

        [<CustomOperation("inferenceConfig")>]
        member _.InferenceConfig(state: Types.InferenceProcessor, value: Types.InferenceConfig) =
            { state with InferenceConfig = Some value }

        [<CustomOperation("inputOutput")>]
        member _.InputOutput(state: Types.InferenceProcessor, value: Types.InputConfig list) =
            { state with InputOutput = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.InferenceProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.InferenceProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.InferenceProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.InferenceProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.InferenceProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.InferenceProcessor, value: string) =
            { state with Tag = Some value }

    let inferenceProcessor = InferenceProcessorBuilder()

    type IngestTypesIngestBuilder() =
        member _.Yield(_: unit) : Types.IngestTypesIngest =
            {
                Redact = None
                Timestamp = Unchecked.defaultof<_>
                Pipeline = None
            }

        [<CustomOperation("redact")>]
        member _.Redact(state: Types.IngestTypesIngest, value: Types.Redact) =
            { state with Redact = Some value }

        [<CustomOperation("timestamp")>]
        member _.Timestamp(state: Types.IngestTypesIngest, value: Types.DateTime) =
            { state with Timestamp = value }

        [<CustomOperation("pipeline")>]
        member _.Pipeline(state: Types.IngestTypesIngest, value: Types.Name) =
            { state with Pipeline = Some value }

    let ingestTypesIngest = IngestTypesIngestBuilder()

    type IpLocationProcessorBuilder() =
        member _.Yield(_: unit) : Types.IpLocationProcessor =
            {
                DatabaseFile = None
                Field = Unchecked.defaultof<_>
                FirstOnly = None
                IgnoreMissing = None
                Properties = None
                TargetField = None
                DownloadDatabaseOnPipelineCreation = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("databaseFile")>]
        member _.DatabaseFile(state: Types.IpLocationProcessor, value: string) =
            { state with DatabaseFile = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.IpLocationProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("firstOnly")>]
        member _.FirstOnly(state: Types.IpLocationProcessor, value: bool) =
            { state with FirstOnly = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.IpLocationProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.IpLocationProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.IpLocationProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("downloadDatabaseOnPipelineCreation")>]
        member _.DownloadDatabaseOnPipelineCreation(state: Types.IpLocationProcessor, value: bool) =
            { state with DownloadDatabaseOnPipelineCreation = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.IpLocationProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.IpLocationProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.IpLocationProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.IpLocationProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.IpLocationProcessor, value: string) =
            { state with Tag = Some value }

    let ipLocationProcessor = IpLocationProcessorBuilder()

    type JoinProcessorBuilder() =
        member _.Yield(_: unit) : Types.JoinProcessor =
            {
                Field = Unchecked.defaultof<_>
                Separator = Unchecked.defaultof<_>
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.JoinProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.JoinProcessor, value: string) =
            { state with Separator = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.JoinProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.JoinProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.JoinProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.JoinProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.JoinProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.JoinProcessor, value: string) =
            { state with Tag = Some value }

    let joinProcessor = JoinProcessorBuilder()

    type JsonProcessorBuilder() =
        member _.Yield(_: unit) : Types.JsonProcessor =
            {
                AddToRoot = None
                AddToRootConflictStrategy = None
                AllowDuplicateKeys = None
                Field = Unchecked.defaultof<_>
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("addToRoot")>]
        member _.AddToRoot(state: Types.JsonProcessor, value: bool) =
            { state with AddToRoot = Some value }

        [<CustomOperation("addToRootConflictStrategy")>]
        member _.AddToRootConflictStrategy(state: Types.JsonProcessor, value: Types.JsonProcessorConflictStrategy) =
            { state with AddToRootConflictStrategy = Some value }

        [<CustomOperation("allowDuplicateKeys")>]
        member _.AllowDuplicateKeys(state: Types.JsonProcessor, value: bool) =
            { state with AllowDuplicateKeys = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.JsonProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.JsonProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.JsonProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.JsonProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.JsonProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.JsonProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.JsonProcessor, value: string) =
            { state with Tag = Some value }

    let jsonProcessor = JsonProcessorBuilder()

    type KeyValueProcessorBuilder() =
        member _.Yield(_: unit) : Types.KeyValueProcessor =
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
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("excludeKeys")>]
        member _.ExcludeKeys(state: Types.KeyValueProcessor, value: string list) =
            { state with ExcludeKeys = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.KeyValueProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("fieldSplit")>]
        member _.FieldSplit(state: Types.KeyValueProcessor, value: string) =
            { state with FieldSplit = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.KeyValueProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("includeKeys")>]
        member _.IncludeKeys(state: Types.KeyValueProcessor, value: string list) =
            { state with IncludeKeys = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: Types.KeyValueProcessor, value: string) =
            { state with Prefix = Some value }

        [<CustomOperation("stripBrackets")>]
        member _.StripBrackets(state: Types.KeyValueProcessor, value: bool) =
            { state with StripBrackets = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.KeyValueProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("trimKey")>]
        member _.TrimKey(state: Types.KeyValueProcessor, value: string) =
            { state with TrimKey = Some value }

        [<CustomOperation("trimValue")>]
        member _.TrimValue(state: Types.KeyValueProcessor, value: string) =
            { state with TrimValue = Some value }

        [<CustomOperation("valueSplit")>]
        member _.ValueSplit(state: Types.KeyValueProcessor, value: string) =
            { state with ValueSplit = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.KeyValueProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.KeyValueProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.KeyValueProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.KeyValueProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.KeyValueProcessor, value: string) =
            { state with Tag = Some value }

    let keyValueProcessor = KeyValueProcessorBuilder()

    type LowercaseProcessorBuilder() =
        member _.Yield(_: unit) : Types.LowercaseProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.LowercaseProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.LowercaseProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.LowercaseProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.LowercaseProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.LowercaseProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.LowercaseProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.LowercaseProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.LowercaseProcessor, value: string) =
            { state with Tag = Some value }

    let lowercaseProcessor = LowercaseProcessorBuilder()

    type NetworkDirectionProcessorBuilder() =
        member _.Yield(_: unit) : Types.NetworkDirectionProcessor =
            {
                SourceIp = None
                DestinationIp = None
                TargetField = None
                InternalNetworks = None
                InternalNetworksField = None
                IgnoreMissing = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("sourceIp")>]
        member _.SourceIp(state: Types.NetworkDirectionProcessor, value: Types.Field) =
            { state with SourceIp = Some value }

        [<CustomOperation("destinationIp")>]
        member _.DestinationIp(state: Types.NetworkDirectionProcessor, value: Types.Field) =
            { state with DestinationIp = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.NetworkDirectionProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("internalNetworks")>]
        member _.InternalNetworks(state: Types.NetworkDirectionProcessor, value: string list) =
            { state with InternalNetworks = Some value }

        [<CustomOperation("internalNetworksField")>]
        member _.InternalNetworksField(state: Types.NetworkDirectionProcessor, value: Types.Field) =
            { state with InternalNetworksField = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.NetworkDirectionProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.NetworkDirectionProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.NetworkDirectionProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.NetworkDirectionProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.NetworkDirectionProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.NetworkDirectionProcessor, value: string) =
            { state with Tag = Some value }

    let networkDirectionProcessor = NetworkDirectionProcessorBuilder()

    type IngestTypesPipelineBuilder() =
        member _.Yield(_: unit) : Types.IngestTypesPipeline =
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
        member _.Description(state: Types.IngestTypesPipeline, value: string) =
            { state with Description = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.IngestTypesPipeline, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("processors")>]
        member _.Processors(state: Types.IngestTypesPipeline, value: Types.ProcessorContainer list) =
            { state with Processors = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.IngestTypesPipeline, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("deprecated")>]
        member _.Deprecated(state: Types.IngestTypesPipeline, value: bool) =
            { state with Deprecated = Some value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.IngestTypesPipeline, value: Types.Metadata) =
            { state with Meta = Some value }

        [<CustomOperation("createdDate")>]
        member _.CreatedDate(state: Types.IngestTypesPipeline, value: Types.DateTime) =
            { state with CreatedDate = Some value }

        [<CustomOperation("createdDateMillis")>]
        member _.CreatedDateMillis(state: Types.IngestTypesPipeline, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CreatedDateMillis = Some value }

        [<CustomOperation("modifiedDate")>]
        member _.ModifiedDate(state: Types.IngestTypesPipeline, value: Types.DateTime) =
            { state with ModifiedDate = Some value }

        [<CustomOperation("modifiedDateMillis")>]
        member _.ModifiedDateMillis(state: Types.IngestTypesPipeline, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ModifiedDateMillis = Some value }

        [<CustomOperation("fieldAccessPattern")>]
        member _.FieldAccessPattern(state: Types.IngestTypesPipeline, value: Types.FieldAccessPattern) =
            { state with FieldAccessPattern = Some value }

    let ingestTypesPipeline = IngestTypesPipelineBuilder()

    type PipelineConfigBuilder() =
        member _.Yield(_: unit) : Types.PipelineConfig =
            {
                Description = None
                Version = None
                Processors = Unchecked.defaultof<_>
            }

        [<CustomOperation("description")>]
        member _.Description(state: Types.PipelineConfig, value: string) =
            { state with Description = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.PipelineConfig, value: Types.VersionNumber) =
            { state with Version = Some value }

        [<CustomOperation("processors")>]
        member _.Processors(state: Types.PipelineConfig, value: Types.ProcessorContainer list) =
            { state with Processors = value }

    let pipelineConfig = PipelineConfigBuilder()

    type PipelineProcessorBuilder() =
        member _.Yield(_: unit) : Types.PipelineProcessor =
            {
                Name = Unchecked.defaultof<_>
                IgnoreMissingPipeline = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.PipelineProcessor, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("ignoreMissingPipeline")>]
        member _.IgnoreMissingPipeline(state: Types.PipelineProcessor, value: bool) =
            { state with IgnoreMissingPipeline = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.PipelineProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.PipelineProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.PipelineProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.PipelineProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.PipelineProcessor, value: string) =
            { state with Tag = Some value }

    let pipelineProcessor = PipelineProcessorBuilder()

    type PipelineProcessorResultBuilder() =
        member _.Yield(_: unit) : Types.PipelineProcessorResult =
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
        member _.Doc(state: Types.PipelineProcessorResult, value: Types.DocumentSimulation) =
            { state with Doc = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.PipelineProcessorResult, value: string) =
            { state with Tag = Some value }

        [<CustomOperation("processorType")>]
        member _.ProcessorType(state: Types.PipelineProcessorResult, value: string) =
            { state with ProcessorType = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.PipelineProcessorResult, value: Types.PipelineSimulationStatusOptions) =
            { state with Status = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.PipelineProcessorResult, value: string) =
            { state with Description = Some value }

        [<CustomOperation("ignoredError")>]
        member _.IgnoredError(state: Types.PipelineProcessorResult, value: Types.ErrorCause) =
            { state with IgnoredError = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.PipelineProcessorResult, value: Types.ErrorCause) =
            { state with Error = Some value }

    let pipelineProcessorResult = PipelineProcessorResultBuilder()

    type ProcessorBaseBuilder() =
        member _.Yield(_: unit) : Types.ProcessorBase =
            {
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: Types.ProcessorBase, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.ProcessorBase, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.ProcessorBase, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.ProcessorBase, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.ProcessorBase, value: string) =
            { state with Tag = Some value }

    let processorBase = ProcessorBaseBuilder()

    module Processor =

        let append (value: Types.AppendProcessor) =
            Types.ProcessorContainer.Append value

        let attachment (value: Types.AttachmentProcessor) =
            Types.ProcessorContainer.Attachment value

        let bytes (value: Types.BytesProcessor) =
            Types.ProcessorContainer.Bytes value

        let cef (value: Types.CefProcessor) =
            Types.ProcessorContainer.Cef value

        let circle (value: Types.CircleProcessor) =
            Types.ProcessorContainer.Circle value

        let communityId (value: Types.CommunityIDProcessor) =
            Types.ProcessorContainer.CommunityId value

        let convert (value: Types.ConvertProcessor) =
            Types.ProcessorContainer.Convert value

        let csv (value: Types.CsvProcessor) =
            Types.ProcessorContainer.Csv value

        let date (value: Types.DateProcessor) =
            Types.ProcessorContainer.Date value

        let dateIndexName (value: Types.DateIndexNameProcessor) =
            Types.ProcessorContainer.DateIndexName value

        let dissect (value: Types.DissectProcessor) =
            Types.ProcessorContainer.Dissect value

        let dotExpander (value: Types.DotExpanderProcessor) =
            Types.ProcessorContainer.DotExpander value

        let drop (value: Types.DropProcessor) =
            Types.ProcessorContainer.Drop value

        let enrich (value: Types.EnrichProcessor) =
            Types.ProcessorContainer.Enrich value

        let fail (value: Types.FailProcessor) =
            Types.ProcessorContainer.Fail value

        let fingerprint (value: Types.FingerprintProcessor) =
            Types.ProcessorContainer.Fingerprint value

        let foreach (value: Types.ForeachProcessor) =
            Types.ProcessorContainer.Foreach value

        let ipLocation (value: Types.IpLocationProcessor) =
            Types.ProcessorContainer.IpLocation value

        let geoGrid (value: Types.GeoGridProcessor) =
            Types.ProcessorContainer.GeoGrid value

        let geoip (value: Types.GeoIpProcessor) =
            Types.ProcessorContainer.Geoip value

        let grok (value: Types.GrokProcessor) =
            Types.ProcessorContainer.Grok value

        let gsub (value: Types.GsubProcessor) =
            Types.ProcessorContainer.Gsub value

        let htmlStrip (value: Types.HtmlStripProcessor) =
            Types.ProcessorContainer.HtmlStrip value

        let inference (value: Types.InferenceProcessor) =
            Types.ProcessorContainer.Inference value

        let join (value: Types.JoinProcessor) =
            Types.ProcessorContainer.Join value

        let json (value: Types.JsonProcessor) =
            Types.ProcessorContainer.Json value

        let kv (value: Types.KeyValueProcessor) =
            Types.ProcessorContainer.Kv value

        let lowercase (value: Types.LowercaseProcessor) =
            Types.ProcessorContainer.Lowercase value

        let networkDirection (value: Types.NetworkDirectionProcessor) =
            Types.ProcessorContainer.NetworkDirection value

        let pipeline (value: Types.PipelineProcessor) =
            Types.ProcessorContainer.Pipeline value

        let redact (value: Types.RedactProcessor) =
            Types.ProcessorContainer.Redact value

        let registeredDomain (value: Types.RegisteredDomainProcessor) =
            Types.ProcessorContainer.RegisteredDomain value

        let remove (value: Types.RemoveProcessor) =
            Types.ProcessorContainer.Remove value

        let rename (value: Types.RenameProcessor) =
            Types.ProcessorContainer.Rename value

        let reroute (value: Types.RerouteProcessor) =
            Types.ProcessorContainer.Reroute value

        let script (value: Types.ScriptProcessor) =
            Types.ProcessorContainer.Script value

        let set (value: Types.SetProcessor) =
            Types.ProcessorContainer.Set value

        let setSecurityUser (value: Types.SetSecurityUserProcessor) =
            Types.ProcessorContainer.SetSecurityUser value

        let sort (value: Types.SortProcessor) =
            Types.ProcessorContainer.Sort value

        let split (value: Types.SplitProcessor) =
            Types.ProcessorContainer.Split value

        let terminate (value: Types.TerminateProcessor) =
            Types.ProcessorContainer.Terminate value

        let trim (value: Types.TrimProcessor) =
            Types.ProcessorContainer.Trim value

        let uppercase (value: Types.UppercaseProcessor) =
            Types.ProcessorContainer.Uppercase value

        let urldecode (value: Types.UrlDecodeProcessor) =
            Types.ProcessorContainer.Urldecode value

        let uriParts (value: Types.UriPartsProcessor) =
            Types.ProcessorContainer.UriParts value

        let userAgent (value: Types.UserAgentProcessor) =
            Types.ProcessorContainer.UserAgent value

    type RedactProcessorBuilder() =
        member _.Yield(_: unit) : Types.RedactProcessor =
            {
                Field = Unchecked.defaultof<_>
                Patterns = Unchecked.defaultof<_>
                PatternDefinitions = None
                Prefix = None
                Suffix = None
                IgnoreMissing = None
                SkipIfUnlicensed = None
                TraceRedact = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RedactProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("patterns")>]
        member _.Patterns(state: Types.RedactProcessor, value: Types.GrokPattern list) =
            { state with Patterns = value }

        [<CustomOperation("patternDefinitions")>]
        member _.PatternDefinitions(state: Types.RedactProcessor, value: Map<string, string>) =
            { state with PatternDefinitions = Some value }

        [<CustomOperation("prefix")>]
        member _.Prefix(state: Types.RedactProcessor, value: string) =
            { state with Prefix = Some value }

        [<CustomOperation("suffix")>]
        member _.Suffix(state: Types.RedactProcessor, value: string) =
            { state with Suffix = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.RedactProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("skipIfUnlicensed")>]
        member _.SkipIfUnlicensed(state: Types.RedactProcessor, value: bool) =
            { state with SkipIfUnlicensed = Some value }

        [<CustomOperation("traceRedact")>]
        member _.TraceRedact(state: Types.RedactProcessor, value: bool) =
            { state with TraceRedact = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RedactProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.RedactProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.RedactProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.RedactProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.RedactProcessor, value: string) =
            { state with Tag = Some value }

    let redactProcessor = RedactProcessorBuilder()

    type RegisteredDomainProcessorBuilder() =
        member _.Yield(_: unit) : Types.RegisteredDomainProcessor =
            {
                Field = Unchecked.defaultof<_>
                TargetField = None
                IgnoreMissing = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RegisteredDomainProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.RegisteredDomainProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.RegisteredDomainProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RegisteredDomainProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.RegisteredDomainProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.RegisteredDomainProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.RegisteredDomainProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.RegisteredDomainProcessor, value: string) =
            { state with Tag = Some value }

    let registeredDomainProcessor = RegisteredDomainProcessorBuilder()

    type RemoveProcessorBuilder() =
        member _.Yield(_: unit) : Types.RemoveProcessor =
            {
                Field = Unchecked.defaultof<_>
                Keep = None
                IgnoreMissing = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RemoveProcessor, value: Types.Fields) =
            { state with Field = value }

        [<CustomOperation("keep")>]
        member _.Keep(state: Types.RemoveProcessor, value: Types.Fields) =
            { state with Keep = Some value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.RemoveProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RemoveProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.RemoveProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.RemoveProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.RemoveProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.RemoveProcessor, value: string) =
            { state with Tag = Some value }

    let removeProcessor = RemoveProcessorBuilder()

    type RenameProcessorBuilder() =
        member _.Yield(_: unit) : Types.RenameProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = Unchecked.defaultof<_>
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.RenameProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.RenameProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.RenameProcessor, value: Types.Field) =
            { state with TargetField = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RenameProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.RenameProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.RenameProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.RenameProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.RenameProcessor, value: string) =
            { state with Tag = Some value }

    let renameProcessor = RenameProcessorBuilder()

    type RerouteProcessorBuilder() =
        member _.Yield(_: unit) : Types.RerouteProcessor =
            {
                Destination = None
                Dataset = None
                Namespace = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("destination")>]
        member _.Destination(state: Types.RerouteProcessor, value: string) =
            { state with Destination = Some value }

        [<CustomOperation("dataset")>]
        member _.Dataset(state: Types.RerouteProcessor, value: string list) =
            { state with Dataset = Some value }

        [<CustomOperation("namespace'")>]
        member _.Namespace(state: Types.RerouteProcessor, value: string list) =
            { state with Namespace = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.RerouteProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.RerouteProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.RerouteProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.RerouteProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.RerouteProcessor, value: string) =
            { state with Tag = Some value }

    let rerouteProcessor = RerouteProcessorBuilder()

    type ScriptProcessorBuilder() =
        member _.Yield(_: unit) : Types.ScriptProcessor =
            {
                Id = None
                Lang = None
                Params = None
                Source = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ScriptProcessor, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: Types.ScriptProcessor, value: Types.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.ScriptProcessor, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.ScriptProcessor, value: Types.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.ScriptProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.ScriptProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.ScriptProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.ScriptProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.ScriptProcessor, value: string) =
            { state with Tag = Some value }

    let scriptProcessor = ScriptProcessorBuilder()

    type SetProcessorBuilder() =
        member _.Yield(_: unit) : Types.SetProcessor =
            {
                CopyFrom = None
                Field = Unchecked.defaultof<_>
                IgnoreEmptyValue = None
                MediaType = None
                Override = None
                Value = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("copyFrom")>]
        member _.CopyFrom(state: Types.SetProcessor, value: Types.Field) =
            { state with CopyFrom = Some value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SetProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreEmptyValue")>]
        member _.IgnoreEmptyValue(state: Types.SetProcessor, value: bool) =
            { state with IgnoreEmptyValue = Some value }

        [<CustomOperation("mediaType")>]
        member _.MediaType(state: Types.SetProcessor, value: string) =
            { state with MediaType = Some value }

        [<CustomOperation("override'")>]
        member _.Override(state: Types.SetProcessor, value: bool) =
            { state with Override = Some value }

        [<CustomOperation("value")>]
        member _.Value(state: Types.SetProcessor, value: System.Text.Json.JsonElement) =
            { state with Value = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.SetProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.SetProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.SetProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.SetProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.SetProcessor, value: string) =
            { state with Tag = Some value }

    let setProcessor = SetProcessorBuilder()

    type SetSecurityUserProcessorBuilder() =
        member _.Yield(_: unit) : Types.SetSecurityUserProcessor =
            {
                Field = Unchecked.defaultof<_>
                Properties = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SetSecurityUserProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.SetSecurityUserProcessor, value: string list) =
            { state with Properties = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.SetSecurityUserProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.SetSecurityUserProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.SetSecurityUserProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.SetSecurityUserProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.SetSecurityUserProcessor, value: string) =
            { state with Tag = Some value }

    let setSecurityUserProcessor = SetSecurityUserProcessorBuilder()

    type SimulateDocumentResultBuilder() =
        member _.Yield(_: unit) : Types.SimulateDocumentResult =
            {
                Doc = None
                Error = None
                ProcessorResults = None
            }

        [<CustomOperation("doc")>]
        member _.Doc(state: Types.SimulateDocumentResult, value: Types.DocumentSimulation) =
            { state with Doc = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.SimulateDocumentResult, value: Types.ErrorCause) =
            { state with Error = Some value }

        [<CustomOperation("processorResults")>]
        member _.ProcessorResults(state: Types.SimulateDocumentResult, value: Types.PipelineProcessorResult list) =
            { state with ProcessorResults = Some value }

    let simulateDocumentResult = SimulateDocumentResultBuilder()

    type SortProcessorBuilder() =
        member _.Yield(_: unit) : Types.SortProcessor =
            {
                Field = Unchecked.defaultof<_>
                Order = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SortProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.SortProcessor, value: Types.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.SortProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.SortProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.SortProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.SortProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.SortProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.SortProcessor, value: string) =
            { state with Tag = Some value }

    let sortProcessor = SortProcessorBuilder()

    type SplitProcessorBuilder() =
        member _.Yield(_: unit) : Types.SplitProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                PreserveTrailing = None
                Separator = Unchecked.defaultof<_>
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.SplitProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.SplitProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("preserveTrailing")>]
        member _.PreserveTrailing(state: Types.SplitProcessor, value: bool) =
            { state with PreserveTrailing = Some value }

        [<CustomOperation("separator")>]
        member _.Separator(state: Types.SplitProcessor, value: string) =
            { state with Separator = value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.SplitProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.SplitProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.SplitProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.SplitProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.SplitProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.SplitProcessor, value: string) =
            { state with Tag = Some value }

    let splitProcessor = SplitProcessorBuilder()

    type TerminateProcessorBuilder() =
        member _.Yield(_: unit) : Types.TerminateProcessor =
            {
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TerminateProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.TerminateProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.TerminateProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.TerminateProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.TerminateProcessor, value: string) =
            { state with Tag = Some value }

    let terminateProcessor = TerminateProcessorBuilder()

    type TrimProcessorBuilder() =
        member _.Yield(_: unit) : Types.TrimProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.TrimProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.TrimProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.TrimProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TrimProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.TrimProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.TrimProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.TrimProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.TrimProcessor, value: string) =
            { state with Tag = Some value }

    let trimProcessor = TrimProcessorBuilder()

    type UppercaseProcessorBuilder() =
        member _.Yield(_: unit) : Types.UppercaseProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.UppercaseProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.UppercaseProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.UppercaseProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.UppercaseProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.UppercaseProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.UppercaseProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.UppercaseProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.UppercaseProcessor, value: string) =
            { state with Tag = Some value }

    let uppercaseProcessor = UppercaseProcessorBuilder()

    type UriPartsProcessorBuilder() =
        member _.Yield(_: unit) : Types.UriPartsProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                KeepOriginal = None
                RemoveIfSuccessful = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.UriPartsProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.UriPartsProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("keepOriginal")>]
        member _.KeepOriginal(state: Types.UriPartsProcessor, value: bool) =
            { state with KeepOriginal = Some value }

        [<CustomOperation("removeIfSuccessful")>]
        member _.RemoveIfSuccessful(state: Types.UriPartsProcessor, value: bool) =
            { state with RemoveIfSuccessful = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.UriPartsProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.UriPartsProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.UriPartsProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.UriPartsProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.UriPartsProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.UriPartsProcessor, value: string) =
            { state with Tag = Some value }

    let uriPartsProcessor = UriPartsProcessorBuilder()

    type UrlDecodeProcessorBuilder() =
        member _.Yield(_: unit) : Types.UrlDecodeProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                TargetField = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.UrlDecodeProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.UrlDecodeProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.UrlDecodeProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.UrlDecodeProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.UrlDecodeProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.UrlDecodeProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.UrlDecodeProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.UrlDecodeProcessor, value: string) =
            { state with Tag = Some value }

    let urlDecodeProcessor = UrlDecodeProcessorBuilder()

    type UserAgentProcessorBuilder() =
        member _.Yield(_: unit) : Types.UserAgentProcessor =
            {
                Field = Unchecked.defaultof<_>
                IgnoreMissing = None
                RegexFile = None
                TargetField = None
                Properties = None
                ExtractDeviceType = None
                Description = None
                If = None
                IgnoreFailure = None
                OnFailure = None
                Tag = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.UserAgentProcessor, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("ignoreMissing")>]
        member _.IgnoreMissing(state: Types.UserAgentProcessor, value: bool) =
            { state with IgnoreMissing = Some value }

        [<CustomOperation("regexFile")>]
        member _.RegexFile(state: Types.UserAgentProcessor, value: string) =
            { state with RegexFile = Some value }

        [<CustomOperation("targetField")>]
        member _.TargetField(state: Types.UserAgentProcessor, value: Types.Field) =
            { state with TargetField = Some value }

        [<CustomOperation("properties")>]
        member _.Properties(state: Types.UserAgentProcessor, value: Types.UserAgentProperty list) =
            { state with Properties = Some value }

        [<CustomOperation("extractDeviceType")>]
        member _.ExtractDeviceType(state: Types.UserAgentProcessor, value: bool) =
            { state with ExtractDeviceType = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.UserAgentProcessor, value: string) =
            { state with Description = Some value }

        [<CustomOperation("if'")>]
        member _.If(state: Types.UserAgentProcessor, value: Types.Script) =
            { state with If = Some value }

        [<CustomOperation("ignoreFailure")>]
        member _.IgnoreFailure(state: Types.UserAgentProcessor, value: bool) =
            { state with IgnoreFailure = Some value }

        [<CustomOperation("onFailure")>]
        member _.OnFailure(state: Types.UserAgentProcessor, value: Types.ProcessorContainer list) =
            { state with OnFailure = Some value }

        [<CustomOperation("tag")>]
        member _.Tag(state: Types.UserAgentProcessor, value: string) =
            { state with Tag = Some value }

    let userAgentProcessor = UserAgentProcessorBuilder()

