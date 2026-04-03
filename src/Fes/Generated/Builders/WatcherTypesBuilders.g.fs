// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module WatcherTypesBuilders =

    type ActionBuilder() =
        member _.Yield(_: unit) : Action =
            {
                ActionType = None
                Condition = None
                Foreach = None
                MaxIterations = None
                Name = None
                ThrottlePeriod = None
                ThrottlePeriodInMillis = None
                Transform = None
                Index = None
                Logging = None
                Email = None
                Pagerduty = None
                Slack = None
                Webhook = None
            }

        [<CustomOperation("actionType")>]
        member _.ActionType(state: Action, value: WatcherTypes.ActionType) =
            { state with ActionType = Some value }

        [<CustomOperation("condition")>]
        member _.Condition(state: Action, value: WatcherTypes.ConditionContainer) =
            { state with Condition = Some value }

        [<CustomOperation("foreach")>]
        member _.Foreach(state: Action, value: string) =
            { state with Foreach = Some value }

        [<CustomOperation("maxIterations")>]
        member _.MaxIterations(state: Action, value: Types.Integer) =
            { state with MaxIterations = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Action, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("throttlePeriod")>]
        member _.ThrottlePeriod(state: Action, value: Types.Duration) =
            { state with ThrottlePeriod = Some value }

        [<CustomOperation("throttlePeriodInMillis")>]
        member _.ThrottlePeriodInMillis(state: Action, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottlePeriodInMillis = Some value }

        [<CustomOperation("transform")>]
        member _.Transform(state: Action, value: Types.TransformContainer) =
            { state with Transform = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Action, value: WatcherTypes.IndexAction) =
            { state with Index = Some value }

        [<CustomOperation("logging")>]
        member _.Logging(state: Action, value: WatcherTypes.LoggingAction) =
            { state with Logging = Some value }

        [<CustomOperation("email")>]
        member _.Email(state: Action, value: WatcherTypes.EmailAction) =
            { state with Email = Some value }

        [<CustomOperation("pagerduty")>]
        member _.Pagerduty(state: Action, value: WatcherTypes.PagerDutyAction) =
            { state with Pagerduty = Some value }

        [<CustomOperation("slack")>]
        member _.Slack(state: Action, value: WatcherTypes.SlackAction) =
            { state with Slack = Some value }

        [<CustomOperation("webhook")>]
        member _.Webhook(state: Action, value: WatcherTypes.WebhookAction) =
            { state with Webhook = Some value }

    let action = ActionBuilder()

    type ActionStatusBuilder() =
        member _.Yield(_: unit) : ActionStatus =
            {
                Ack = Unchecked.defaultof<_>
                LastExecution = None
                LastSuccessfulExecution = None
                LastThrottle = None
            }

        [<CustomOperation("ack")>]
        member _.Ack(state: ActionStatus, value: WatcherTypes.AcknowledgeState) =
            { state with Ack = value }

        [<CustomOperation("lastExecution")>]
        member _.LastExecution(state: ActionStatus, value: WatcherTypes.ExecutionState) =
            { state with LastExecution = Some value }

        [<CustomOperation("lastSuccessfulExecution")>]
        member _.LastSuccessfulExecution(state: ActionStatus, value: WatcherTypes.ExecutionState) =
            { state with LastSuccessfulExecution = Some value }

        [<CustomOperation("lastThrottle")>]
        member _.LastThrottle(state: ActionStatus, value: WatcherTypes.ThrottleState) =
            { state with LastThrottle = Some value }

    let actionStatus = ActionStatusBuilder()

    module Condition =

        let always (value: WatcherTypes.AlwaysCondition) =
            ConditionContainer.Always value

        let arrayCompare (field: string) (value: WatcherTypes.ArrayCompareCondition) =
            ConditionContainer.ArrayCompare (field, value)

        let compare (field: string) (value: Map<WatcherTypes.ConditionOp, Types.FieldValue>) =
            ConditionContainer.Compare (field, value)

        let never (value: WatcherTypes.NeverCondition) =
            ConditionContainer.Never value

        let script (value: WatcherTypes.ScriptCondition) =
            ConditionContainer.Script value

    type EmailBuilder() =
        member _.Yield(_: unit) : Email =
            {
                Id = None
                Bcc = None
                Body = None
                Cc = None
                From = None
                Priority = None
                ReplyTo = None
                SentDate = None
                Subject = Unchecked.defaultof<_>
                To = Unchecked.defaultof<_>
                Attachments = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Email, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("bcc")>]
        member _.Bcc(state: Email, value: System.Text.Json.JsonElement) =
            { state with Bcc = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: Email, value: WatcherTypes.EmailBody) =
            { state with Body = Some value }

        [<CustomOperation("cc")>]
        member _.Cc(state: Email, value: System.Text.Json.JsonElement) =
            { state with Cc = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Email, value: string) =
            { state with From = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Email, value: WatcherTypes.EmailPriority) =
            { state with Priority = Some value }

        [<CustomOperation("replyTo")>]
        member _.ReplyTo(state: Email, value: System.Text.Json.JsonElement) =
            { state with ReplyTo = Some value }

        [<CustomOperation("sentDate")>]
        member _.SentDate(state: Email, value: Types.DateTime) =
            { state with SentDate = Some value }

        [<CustomOperation("subject")>]
        member _.Subject(state: Email, value: string) =
            { state with Subject = value }

        [<CustomOperation("to'")>]
        member _.To(state: Email, value: System.Text.Json.JsonElement) =
            { state with To = value }

        [<CustomOperation("attachments")>]
        member _.Attachments(state: Email, value: Map<string, WatcherTypes.EmailAttachmentContainer>) =
            { state with Attachments = Some value }

    let email = EmailBuilder()

    module EmailAttachment =

        let http (value: WatcherTypes.HttpEmailAttachment) =
            EmailAttachmentContainer.Http value

        let reporting (value: WatcherTypes.ReportingEmailAttachment) =
            EmailAttachmentContainer.Reporting value

        let data (value: WatcherTypes.DataEmailAttachment) =
            EmailAttachmentContainer.Data value

    type EmailBodyBuilder() =
        member _.Yield(_: unit) : EmailBody =
            {
                Html = None
                Text = None
            }

        [<CustomOperation("html")>]
        member _.Html(state: EmailBody, value: string) =
            { state with Html = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: EmailBody, value: string) =
            { state with Text = Some value }

    let emailBody = EmailBodyBuilder()

    type EmailResultBuilder() =
        member _.Yield(_: unit) : EmailResult =
            {
                Account = None
                Message = Unchecked.defaultof<_>
                Reason = None
            }

        [<CustomOperation("account")>]
        member _.Account(state: EmailResult, value: string) =
            { state with Account = Some value }

        [<CustomOperation("message")>]
        member _.Message(state: EmailResult, value: WatcherTypes.Email) =
            { state with Message = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: EmailResult, value: string) =
            { state with Reason = Some value }

    let emailResult = EmailResultBuilder()

    type ExecutionResultActionBuilder() =
        member _.Yield(_: unit) : ExecutionResultAction =
            {
                Email = None
                Id = Unchecked.defaultof<_>
                Index = None
                Logging = None
                Pagerduty = None
                Reason = None
                Slack = None
                Status = Unchecked.defaultof<_>
                Type = Unchecked.defaultof<_>
                Webhook = None
                Error = None
            }

        [<CustomOperation("email")>]
        member _.Email(state: ExecutionResultAction, value: WatcherTypes.EmailResult) =
            { state with Email = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: ExecutionResultAction, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: ExecutionResultAction, value: WatcherTypes.IndexResult) =
            { state with Index = Some value }

        [<CustomOperation("logging")>]
        member _.Logging(state: ExecutionResultAction, value: WatcherTypes.LoggingResult) =
            { state with Logging = Some value }

        [<CustomOperation("pagerduty")>]
        member _.Pagerduty(state: ExecutionResultAction, value: WatcherTypes.PagerDutyResult) =
            { state with Pagerduty = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: ExecutionResultAction, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("slack")>]
        member _.Slack(state: ExecutionResultAction, value: WatcherTypes.SlackResult) =
            { state with Slack = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: ExecutionResultAction, value: WatcherTypes.ActionStatusOptions) =
            { state with Status = value }

        [<CustomOperation("type'")>]
        member _.Type(state: ExecutionResultAction, value: WatcherTypes.ActionType) =
            { state with Type = value }

        [<CustomOperation("webhook")>]
        member _.Webhook(state: ExecutionResultAction, value: WatcherTypes.WebhookResult) =
            { state with Webhook = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: ExecutionResultAction, value: Types.ErrorCause) =
            { state with Error = Some value }

    let executionResultAction = ExecutionResultActionBuilder()

    type HttpEmailAttachmentBuilder() =
        member _.Yield(_: unit) : HttpEmailAttachment =
            {
                ContentType = None
                Inline = None
                Request = None
            }

        [<CustomOperation("contentType")>]
        member _.ContentType(state: HttpEmailAttachment, value: string) =
            { state with ContentType = Some value }

        [<CustomOperation("inline'")>]
        member _.Inline(state: HttpEmailAttachment, value: bool) =
            { state with Inline = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: HttpEmailAttachment, value: WatcherTypes.HttpInputRequestDefinition) =
            { state with Request = Some value }

    let httpEmailAttachment = HttpEmailAttachmentBuilder()

    type HttpInputBuilder() =
        member _.Yield(_: unit) : HttpInput =
            {
                Extract = None
                Request = None
                ResponseContentType = None
            }

        [<CustomOperation("extract")>]
        member _.Extract(state: HttpInput, value: string list) =
            { state with Extract = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: HttpInput, value: WatcherTypes.HttpInputRequestDefinition) =
            { state with Request = Some value }

        [<CustomOperation("responseContentType")>]
        member _.ResponseContentType(state: HttpInput, value: WatcherTypes.ResponseContentType) =
            { state with ResponseContentType = Some value }

    let httpInput = HttpInputBuilder()

    type HttpInputRequestDefinitionBuilder() =
        member _.Yield(_: unit) : HttpInputRequestDefinition =
            {
                Auth = None
                Body = None
                ConnectionTimeout = None
                Headers = None
                Host = None
                Method = None
                Params = None
                Path = None
                Port = None
                Proxy = None
                ReadTimeout = None
                Scheme = None
                Url = None
            }

        [<CustomOperation("auth")>]
        member _.Auth(state: HttpInputRequestDefinition, value: WatcherTypes.HttpInputAuthentication) =
            { state with Auth = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: HttpInputRequestDefinition, value: string) =
            { state with Body = Some value }

        [<CustomOperation("connectionTimeout")>]
        member _.ConnectionTimeout(state: HttpInputRequestDefinition, value: Types.Duration) =
            { state with ConnectionTimeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: HttpInputRequestDefinition, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: HttpInputRequestDefinition, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: HttpInputRequestDefinition, value: WatcherTypes.HttpInputMethod) =
            { state with Method = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: HttpInputRequestDefinition, value: Map<string, string>) =
            { state with Params = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: HttpInputRequestDefinition, value: string) =
            { state with Path = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: HttpInputRequestDefinition, value: Types.Uint) =
            { state with Port = Some value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: HttpInputRequestDefinition, value: WatcherTypes.HttpInputProxy) =
            { state with Proxy = Some value }

        [<CustomOperation("readTimeout")>]
        member _.ReadTimeout(state: HttpInputRequestDefinition, value: Types.Duration) =
            { state with ReadTimeout = Some value }

        [<CustomOperation("scheme")>]
        member _.Scheme(state: HttpInputRequestDefinition, value: WatcherTypes.ConnectionScheme) =
            { state with Scheme = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: HttpInputRequestDefinition, value: string) =
            { state with Url = Some value }

    let httpInputRequestDefinition = HttpInputRequestDefinitionBuilder()

    type IndexActionBuilder() =
        member _.Yield(_: unit) : IndexAction =
            {
                Index = Unchecked.defaultof<_>
                DocId = None
                Refresh = None
                OpType = None
                Timeout = None
                ExecutionTimeField = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: IndexAction, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("docId")>]
        member _.DocId(state: IndexAction, value: Types.Id) =
            { state with DocId = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: IndexAction, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("opType")>]
        member _.OpType(state: IndexAction, value: Types.OpType) =
            { state with OpType = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: IndexAction, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("executionTimeField")>]
        member _.ExecutionTimeField(state: IndexAction, value: Types.Field) =
            { state with ExecutionTimeField = Some value }

    let indexAction = IndexActionBuilder()

    module Input =

        let chain (value: WatcherTypes.ChainInput) =
            InputContainer.Chain value

        let http (value: WatcherTypes.HttpInput) =
            InputContainer.Http value

        let search (value: WatcherTypes.SearchInput) =
            InputContainer.Search value

        let simple (value: Map<string, System.Text.Json.JsonElement>) =
            InputContainer.Simple value

    type LoggingActionBuilder() =
        member _.Yield(_: unit) : LoggingAction =
            {
                Level = None
                Text = Unchecked.defaultof<_>
                Category = None
            }

        [<CustomOperation("level")>]
        member _.Level(state: LoggingAction, value: string) =
            { state with Level = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: LoggingAction, value: string) =
            { state with Text = value }

        [<CustomOperation("category")>]
        member _.Category(state: LoggingAction, value: string) =
            { state with Category = Some value }

    let loggingAction = LoggingActionBuilder()

    type PagerDutyContextBuilder() =
        member _.Yield(_: unit) : PagerDutyContext =
            {
                Href = None
                Src = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("href")>]
        member _.Href(state: PagerDutyContext, value: string) =
            { state with Href = Some value }

        [<CustomOperation("src")>]
        member _.Src(state: PagerDutyContext, value: string) =
            { state with Src = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: PagerDutyContext, value: WatcherTypes.PagerDutyContextType) =
            { state with Type = value }

    let pagerDutyContext = PagerDutyContextBuilder()

    type PagerDutyEventBuilder() =
        member _.Yield(_: unit) : PagerDutyEvent =
            {
                Account = None
                AttachPayload = Unchecked.defaultof<_>
                Client = None
                ClientUrl = None
                Contexts = None
                Description = Unchecked.defaultof<_>
                EventType = None
                IncidentKey = Unchecked.defaultof<_>
                Proxy = None
            }

        [<CustomOperation("account")>]
        member _.Account(state: PagerDutyEvent, value: string) =
            { state with Account = Some value }

        [<CustomOperation("attachPayload")>]
        member _.AttachPayload(state: PagerDutyEvent, value: bool) =
            { state with AttachPayload = value }

        [<CustomOperation("client")>]
        member _.Client(state: PagerDutyEvent, value: string) =
            { state with Client = Some value }

        [<CustomOperation("clientUrl")>]
        member _.ClientUrl(state: PagerDutyEvent, value: string) =
            { state with ClientUrl = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: PagerDutyEvent, value: WatcherTypes.PagerDutyContext list) =
            { state with Contexts = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: PagerDutyEvent, value: string) =
            { state with Description = value }

        [<CustomOperation("eventType")>]
        member _.EventType(state: PagerDutyEvent, value: WatcherTypes.PagerDutyEventType) =
            { state with EventType = Some value }

        [<CustomOperation("incidentKey")>]
        member _.IncidentKey(state: PagerDutyEvent, value: string) =
            { state with IncidentKey = value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: PagerDutyEvent, value: WatcherTypes.PagerDutyEventProxy) =
            { state with Proxy = Some value }

    let pagerDutyEvent = PagerDutyEventBuilder()

    type PagerDutyEventProxyBuilder() =
        member _.Yield(_: unit) : PagerDutyEventProxy =
            {
                Host = None
                Port = None
            }

        [<CustomOperation("host")>]
        member _.Host(state: PagerDutyEventProxy, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: PagerDutyEventProxy, value: Types.Integer) =
            { state with Port = Some value }

    let pagerDutyEventProxy = PagerDutyEventProxyBuilder()

    type PagerDutyResultBuilder() =
        member _.Yield(_: unit) : PagerDutyResult =
            {
                Event = Unchecked.defaultof<_>
                Reason = None
                Request = None
                Response = None
            }

        [<CustomOperation("event")>]
        member _.Event(state: PagerDutyResult, value: WatcherTypes.PagerDutyEvent) =
            { state with Event = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: PagerDutyResult, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: PagerDutyResult, value: WatcherTypes.HttpInputRequestResult) =
            { state with Request = Some value }

        [<CustomOperation("response")>]
        member _.Response(state: PagerDutyResult, value: WatcherTypes.HttpInputResponseResult) =
            { state with Response = Some value }

    let pagerDutyResult = PagerDutyResultBuilder()

    type QueryWatchBuilder() =
        member _.Yield(_: unit) : QueryWatch =
            {
                Id = Unchecked.defaultof<_>
                Status = None
                Watch = None
                PrimaryTerm = None
                SeqNo = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: QueryWatch, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("status")>]
        member _.Status(state: QueryWatch, value: WatcherTypes.WatchStatus) =
            { state with Status = Some value }

        [<CustomOperation("watch")>]
        member _.Watch(state: QueryWatch, value: WatcherTypes.Watch) =
            { state with Watch = Some value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: QueryWatch, value: Types.Integer) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: QueryWatch, value: Types.SequenceNumber) =
            { state with SeqNo = Some value }

    let queryWatch = QueryWatchBuilder()

    type ReportingEmailAttachmentBuilder() =
        member _.Yield(_: unit) : ReportingEmailAttachment =
            {
                Url = Unchecked.defaultof<_>
                Inline = None
                Retries = None
                Interval = None
                Request = None
            }

        [<CustomOperation("url")>]
        member _.Url(state: ReportingEmailAttachment, value: string) =
            { state with Url = value }

        [<CustomOperation("inline'")>]
        member _.Inline(state: ReportingEmailAttachment, value: bool) =
            { state with Inline = Some value }

        [<CustomOperation("retries")>]
        member _.Retries(state: ReportingEmailAttachment, value: Types.Integer) =
            { state with Retries = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: ReportingEmailAttachment, value: Types.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: ReportingEmailAttachment, value: WatcherTypes.HttpInputRequestDefinition) =
            { state with Request = Some value }

    let reportingEmailAttachment = ReportingEmailAttachmentBuilder()

    module Schedule =

        let timezone (value: string) =
            ScheduleContainer.Timezone value

        let cron (value: WatcherTypes.CronExpression) =
            ScheduleContainer.Cron value

        let daily (value: WatcherTypes.DailySchedule) =
            ScheduleContainer.Daily value

        let hourly (value: WatcherTypes.HourlySchedule) =
            ScheduleContainer.Hourly value

        let interval (value: Types.Duration) =
            ScheduleContainer.Interval value

        let monthly (value: System.Text.Json.JsonElement) =
            ScheduleContainer.Monthly value

        let weekly (value: System.Text.Json.JsonElement) =
            ScheduleContainer.Weekly value

        let yearly (value: System.Text.Json.JsonElement) =
            ScheduleContainer.Yearly value

    type ScriptConditionBuilder() =
        member _.Yield(_: unit) : ScriptCondition =
            {
                Lang = None
                Params = None
                Source = None
                Id = None
            }

        [<CustomOperation("lang")>]
        member _.Lang(state: ScriptCondition, value: Types.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: ScriptCondition, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ScriptCondition, value: Types.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: ScriptCondition, value: string) =
            { state with Id = Some value }

    let scriptCondition = ScriptConditionBuilder()

    type SearchInputBuilder() =
        member _.Yield(_: unit) : SearchInput =
            {
                Extract = None
                Request = Unchecked.defaultof<_>
                Timeout = None
            }

        [<CustomOperation("extract")>]
        member _.Extract(state: SearchInput, value: string list) =
            { state with Extract = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: SearchInput, value: WatcherTypes.SearchInputRequestDefinition) =
            { state with Request = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: SearchInput, value: Types.Duration) =
            { state with Timeout = Some value }

    let searchInput = SearchInputBuilder()

    type SearchInputRequestDefinitionBuilder() =
        member _.Yield(_: unit) : SearchInputRequestDefinition =
            {
                Body = None
                Indices = None
                IndicesOptions = None
                SearchType = None
                Template = None
                RestTotalHitsAsInt = None
            }

        [<CustomOperation("body")>]
        member _.Body(state: SearchInputRequestDefinition, value: WatcherTypes.SearchInputRequestBody) =
            { state with Body = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SearchInputRequestDefinition, value: Types.IndexName list) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: SearchInputRequestDefinition, value: Types.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: SearchInputRequestDefinition, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: SearchInputRequestDefinition, value: WatcherTypes.SearchTemplateRequestBody) =
            { state with Template = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: SearchInputRequestDefinition, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

    let searchInputRequestDefinition = SearchInputRequestDefinitionBuilder()

    type SearchTemplateRequestBodyBuilder() =
        member _.Yield(_: unit) : SearchTemplateRequestBody =
            {
                Explain = None
                Id = None
                Params = None
                Profile = None
                Source = None
            }

        [<CustomOperation("explain")>]
        member _.Explain(state: SearchTemplateRequestBody, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: SearchTemplateRequestBody, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: SearchTemplateRequestBody, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: SearchTemplateRequestBody, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: SearchTemplateRequestBody, value: string) =
            { state with Source = Some value }

    let searchTemplateRequestBody = SearchTemplateRequestBodyBuilder()

    type SlackAttachmentBuilder() =
        member _.Yield(_: unit) : SlackAttachment =
            {
                AuthorIcon = None
                AuthorLink = None
                AuthorName = Unchecked.defaultof<_>
                Color = None
                Fallback = None
                Fields = None
                Footer = None
                FooterIcon = None
                ImageUrl = None
                Pretext = None
                Text = None
                ThumbUrl = None
                Title = Unchecked.defaultof<_>
                TitleLink = None
                Ts = None
            }

        [<CustomOperation("authorIcon")>]
        member _.AuthorIcon(state: SlackAttachment, value: string) =
            { state with AuthorIcon = Some value }

        [<CustomOperation("authorLink")>]
        member _.AuthorLink(state: SlackAttachment, value: string) =
            { state with AuthorLink = Some value }

        [<CustomOperation("authorName")>]
        member _.AuthorName(state: SlackAttachment, value: string) =
            { state with AuthorName = value }

        [<CustomOperation("color")>]
        member _.Color(state: SlackAttachment, value: string) =
            { state with Color = Some value }

        [<CustomOperation("fallback")>]
        member _.Fallback(state: SlackAttachment, value: string) =
            { state with Fallback = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: SlackAttachment, value: WatcherTypes.SlackAttachmentField list) =
            { state with Fields = Some value }

        [<CustomOperation("footer")>]
        member _.Footer(state: SlackAttachment, value: string) =
            { state with Footer = Some value }

        [<CustomOperation("footerIcon")>]
        member _.FooterIcon(state: SlackAttachment, value: string) =
            { state with FooterIcon = Some value }

        [<CustomOperation("imageUrl")>]
        member _.ImageUrl(state: SlackAttachment, value: string) =
            { state with ImageUrl = Some value }

        [<CustomOperation("pretext")>]
        member _.Pretext(state: SlackAttachment, value: string) =
            { state with Pretext = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: SlackAttachment, value: string) =
            { state with Text = Some value }

        [<CustomOperation("thumbUrl")>]
        member _.ThumbUrl(state: SlackAttachment, value: string) =
            { state with ThumbUrl = Some value }

        [<CustomOperation("title")>]
        member _.Title(state: SlackAttachment, value: string) =
            { state with Title = value }

        [<CustomOperation("titleLink")>]
        member _.TitleLink(state: SlackAttachment, value: string) =
            { state with TitleLink = Some value }

        [<CustomOperation("ts")>]
        member _.Ts(state: SlackAttachment, value: Types.EpochTime<Types.UnitSeconds>) =
            { state with Ts = Some value }

    let slackAttachment = SlackAttachmentBuilder()

    type SlackMessageBuilder() =
        member _.Yield(_: unit) : SlackMessage =
            {
                Attachments = Unchecked.defaultof<_>
                DynamicAttachments = None
                From = Unchecked.defaultof<_>
                Icon = None
                Text = Unchecked.defaultof<_>
                To = Unchecked.defaultof<_>
            }

        [<CustomOperation("attachments")>]
        member _.Attachments(state: SlackMessage, value: WatcherTypes.SlackAttachment list) =
            { state with Attachments = value }

        [<CustomOperation("dynamicAttachments")>]
        member _.DynamicAttachments(state: SlackMessage, value: WatcherTypes.SlackDynamicAttachment) =
            { state with DynamicAttachments = Some value }

        [<CustomOperation("from")>]
        member _.From(state: SlackMessage, value: string) =
            { state with From = value }

        [<CustomOperation("icon")>]
        member _.Icon(state: SlackMessage, value: string) =
            { state with Icon = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: SlackMessage, value: string) =
            { state with Text = value }

        [<CustomOperation("to'")>]
        member _.To(state: SlackMessage, value: string list) =
            { state with To = value }

    let slackMessage = SlackMessageBuilder()

    module Trigger =

        let schedule (value: WatcherTypes.ScheduleContainer) =
            TriggerContainer.Schedule value

    module TriggerEvent =

        let schedule (value: WatcherTypes.ScheduleTriggerEvent) =
            TriggerEventContainer.Schedule value

    type WatchBuilder() =
        member _.Yield(_: unit) : Watch =
            {
                Actions = Unchecked.defaultof<_>
                Condition = Unchecked.defaultof<_>
                Input = Unchecked.defaultof<_>
                Metadata = None
                Status = None
                ThrottlePeriod = None
                ThrottlePeriodInMillis = None
                Transform = None
                Trigger = Unchecked.defaultof<_>
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Watch, value: Map<Types.IndexName, WatcherTypes.Action>) =
            { state with Actions = value }

        [<CustomOperation("condition")>]
        member _.Condition(state: Watch, value: WatcherTypes.ConditionContainer) =
            { state with Condition = value }

        [<CustomOperation("input")>]
        member _.Input(state: Watch, value: WatcherTypes.InputContainer) =
            { state with Input = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Watch, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Watch, value: WatcherTypes.WatchStatus) =
            { state with Status = Some value }

        [<CustomOperation("throttlePeriod")>]
        member _.ThrottlePeriod(state: Watch, value: Types.Duration) =
            { state with ThrottlePeriod = Some value }

        [<CustomOperation("throttlePeriodInMillis")>]
        member _.ThrottlePeriodInMillis(state: Watch, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottlePeriodInMillis = Some value }

        [<CustomOperation("transform")>]
        member _.Transform(state: Watch, value: Types.TransformContainer) =
            { state with Transform = Some value }

        [<CustomOperation("trigger")>]
        member _.Trigger(state: Watch, value: WatcherTypes.TriggerContainer) =
            { state with Trigger = value }

    let watch = WatchBuilder()

    type WatchStatusBuilder() =
        member _.Yield(_: unit) : WatchStatus =
            {
                Actions = Unchecked.defaultof<_>
                LastChecked = None
                LastMetCondition = None
                State = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                ExecutionState = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: WatchStatus, value: WatcherTypes.Actions) =
            { state with Actions = value }

        [<CustomOperation("lastChecked")>]
        member _.LastChecked(state: WatchStatus, value: Types.DateTime) =
            { state with LastChecked = Some value }

        [<CustomOperation("lastMetCondition")>]
        member _.LastMetCondition(state: WatchStatus, value: Types.DateTime) =
            { state with LastMetCondition = Some value }

        [<CustomOperation("state")>]
        member _.State(state: WatchStatus, value: WatcherTypes.ActivationState) =
            { state with State = value }

        [<CustomOperation("version")>]
        member _.Version(state: WatchStatus, value: Types.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("executionState")>]
        member _.ExecutionState(state: WatchStatus, value: string) =
            { state with ExecutionState = Some value }

    let watchStatus = WatchStatusBuilder()

