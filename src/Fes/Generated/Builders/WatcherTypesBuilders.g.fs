// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module WatcherTypesBuilders =

    type WatcherTypesActionBuilder() =
        member _.Yield(_: unit) : Types.WatcherTypesAction =
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
        member _.ActionType(state: Types.WatcherTypesAction, value: Types.ActionType) =
            { state with ActionType = Some value }

        [<CustomOperation("condition")>]
        member _.Condition(state: Types.WatcherTypesAction, value: Types.ConditionContainer) =
            { state with Condition = Some value }

        [<CustomOperation("foreach")>]
        member _.Foreach(state: Types.WatcherTypesAction, value: string) =
            { state with Foreach = Some value }

        [<CustomOperation("maxIterations")>]
        member _.MaxIterations(state: Types.WatcherTypesAction, value: Types.Integer) =
            { state with MaxIterations = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.WatcherTypesAction, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("throttlePeriod")>]
        member _.ThrottlePeriod(state: Types.WatcherTypesAction, value: Types.Duration) =
            { state with ThrottlePeriod = Some value }

        [<CustomOperation("throttlePeriodInMillis")>]
        member _.ThrottlePeriodInMillis(state: Types.WatcherTypesAction, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottlePeriodInMillis = Some value }

        [<CustomOperation("transform")>]
        member _.Transform(state: Types.WatcherTypesAction, value: Types.TransformContainer) =
            { state with Transform = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.WatcherTypesAction, value: Types.IndexAction) =
            { state with Index = Some value }

        [<CustomOperation("logging")>]
        member _.Logging(state: Types.WatcherTypesAction, value: Types.LoggingAction) =
            { state with Logging = Some value }

        [<CustomOperation("email")>]
        member _.Email(state: Types.WatcherTypesAction, value: Types.EmailAction) =
            { state with Email = Some value }

        [<CustomOperation("pagerduty")>]
        member _.Pagerduty(state: Types.WatcherTypesAction, value: Types.PagerDutyAction) =
            { state with Pagerduty = Some value }

        [<CustomOperation("slack")>]
        member _.Slack(state: Types.WatcherTypesAction, value: Types.SlackAction) =
            { state with Slack = Some value }

        [<CustomOperation("webhook")>]
        member _.Webhook(state: Types.WatcherTypesAction, value: Types.WebhookAction) =
            { state with Webhook = Some value }

    let watcherTypesAction = WatcherTypesActionBuilder()

    type ActionStatusBuilder() =
        member _.Yield(_: unit) : Types.ActionStatus =
            {
                Ack = Unchecked.defaultof<_>
                LastExecution = None
                LastSuccessfulExecution = None
                LastThrottle = None
            }

        [<CustomOperation("ack")>]
        member _.Ack(state: Types.ActionStatus, value: Types.AcknowledgeState) =
            { state with Ack = value }

        [<CustomOperation("lastExecution")>]
        member _.LastExecution(state: Types.ActionStatus, value: Types.ExecutionState) =
            { state with LastExecution = Some value }

        [<CustomOperation("lastSuccessfulExecution")>]
        member _.LastSuccessfulExecution(state: Types.ActionStatus, value: Types.ExecutionState) =
            { state with LastSuccessfulExecution = Some value }

        [<CustomOperation("lastThrottle")>]
        member _.LastThrottle(state: Types.ActionStatus, value: Types.ThrottleState) =
            { state with LastThrottle = Some value }

    let actionStatus = ActionStatusBuilder()

    module Condition =

        let always (value: Types.AlwaysCondition) =
            Types.ConditionContainer.Always value

        let arrayCompare (field: string) (value: Types.ArrayCompareCondition) =
            Types.ConditionContainer.ArrayCompare (field, value)

        let compare (field: string) (value: Map<Types.ConditionOp, Types.FieldValue>) =
            Types.ConditionContainer.Compare (field, value)

        let never (value: Types.NeverCondition) =
            Types.ConditionContainer.Never value

        let script (value: Types.ScriptCondition) =
            Types.ConditionContainer.Script value

    type EmailBuilder() =
        member _.Yield(_: unit) : Types.Email =
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
        member _.Id(state: Types.Email, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("bcc")>]
        member _.Bcc(state: Types.Email, value: string list) =
            { state with Bcc = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: Types.Email, value: Types.EmailBody) =
            { state with Body = Some value }

        [<CustomOperation("cc")>]
        member _.Cc(state: Types.Email, value: string list) =
            { state with Cc = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.Email, value: string) =
            { state with From = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.Email, value: Types.EmailPriority) =
            { state with Priority = Some value }

        [<CustomOperation("replyTo")>]
        member _.ReplyTo(state: Types.Email, value: string list) =
            { state with ReplyTo = Some value }

        [<CustomOperation("sentDate")>]
        member _.SentDate(state: Types.Email, value: Types.DateTime) =
            { state with SentDate = Some value }

        [<CustomOperation("subject")>]
        member _.Subject(state: Types.Email, value: string) =
            { state with Subject = value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.Email, value: string list) =
            { state with To = value }

        [<CustomOperation("attachments")>]
        member _.Attachments(state: Types.Email, value: Map<string, Types.EmailAttachmentContainer>) =
            { state with Attachments = Some value }

    let email = EmailBuilder()

    type EmailActionBuilder() =
        member _.Yield(_: unit) : Types.EmailAction =
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
        member _.Id(state: Types.EmailAction, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("bcc")>]
        member _.Bcc(state: Types.EmailAction, value: string list) =
            { state with Bcc = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: Types.EmailAction, value: Types.EmailBody) =
            { state with Body = Some value }

        [<CustomOperation("cc")>]
        member _.Cc(state: Types.EmailAction, value: string list) =
            { state with Cc = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.EmailAction, value: string) =
            { state with From = Some value }

        [<CustomOperation("priority")>]
        member _.Priority(state: Types.EmailAction, value: Types.EmailPriority) =
            { state with Priority = Some value }

        [<CustomOperation("replyTo")>]
        member _.ReplyTo(state: Types.EmailAction, value: string list) =
            { state with ReplyTo = Some value }

        [<CustomOperation("sentDate")>]
        member _.SentDate(state: Types.EmailAction, value: Types.DateTime) =
            { state with SentDate = Some value }

        [<CustomOperation("subject")>]
        member _.Subject(state: Types.EmailAction, value: string) =
            { state with Subject = value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.EmailAction, value: string list) =
            { state with To = value }

        [<CustomOperation("attachments")>]
        member _.Attachments(state: Types.EmailAction, value: Map<string, Types.EmailAttachmentContainer>) =
            { state with Attachments = Some value }

    let emailAction = EmailActionBuilder()

    module EmailAttachment =

        let http (value: Types.HttpEmailAttachment) =
            Types.EmailAttachmentContainer.Http value

        let reporting (value: Types.ReportingEmailAttachment) =
            Types.EmailAttachmentContainer.Reporting value

        let data (value: Types.DataEmailAttachment) =
            Types.EmailAttachmentContainer.Data value

    type EmailBodyBuilder() =
        member _.Yield(_: unit) : Types.EmailBody =
            {
                Html = None
                Text = None
            }

        [<CustomOperation("html")>]
        member _.Html(state: Types.EmailBody, value: string) =
            { state with Html = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: Types.EmailBody, value: string) =
            { state with Text = Some value }

    let emailBody = EmailBodyBuilder()

    type EmailResultBuilder() =
        member _.Yield(_: unit) : Types.EmailResult =
            {
                Account = None
                Message = Unchecked.defaultof<_>
                Reason = None
            }

        [<CustomOperation("account")>]
        member _.Account(state: Types.EmailResult, value: string) =
            { state with Account = Some value }

        [<CustomOperation("message")>]
        member _.Message(state: Types.EmailResult, value: Types.Email) =
            { state with Message = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.EmailResult, value: string) =
            { state with Reason = Some value }

    let emailResult = EmailResultBuilder()

    type ExecutionResultActionBuilder() =
        member _.Yield(_: unit) : Types.ExecutionResultAction =
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
        member _.Email(state: Types.ExecutionResultAction, value: Types.EmailResult) =
            { state with Email = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ExecutionResultAction, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ExecutionResultAction, value: Types.IndexResult) =
            { state with Index = Some value }

        [<CustomOperation("logging")>]
        member _.Logging(state: Types.ExecutionResultAction, value: Types.LoggingResult) =
            { state with Logging = Some value }

        [<CustomOperation("pagerduty")>]
        member _.Pagerduty(state: Types.ExecutionResultAction, value: Types.PagerDutyResult) =
            { state with Pagerduty = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.ExecutionResultAction, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("slack")>]
        member _.Slack(state: Types.ExecutionResultAction, value: Types.SlackResult) =
            { state with Slack = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.ExecutionResultAction, value: Types.ActionStatusOptions) =
            { state with Status = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ExecutionResultAction, value: Types.ActionType) =
            { state with Type = value }

        [<CustomOperation("webhook")>]
        member _.Webhook(state: Types.ExecutionResultAction, value: Types.WebhookResult) =
            { state with Webhook = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.ExecutionResultAction, value: Types.ErrorCause) =
            { state with Error = Some value }

    let executionResultAction = ExecutionResultActionBuilder()

    type HttpEmailAttachmentBuilder() =
        member _.Yield(_: unit) : Types.HttpEmailAttachment =
            {
                ContentType = None
                Inline = None
                Request = None
            }

        [<CustomOperation("contentType")>]
        member _.ContentType(state: Types.HttpEmailAttachment, value: string) =
            { state with ContentType = Some value }

        [<CustomOperation("inline'")>]
        member _.Inline(state: Types.HttpEmailAttachment, value: bool) =
            { state with Inline = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.HttpEmailAttachment, value: Types.HttpInputRequestDefinition) =
            { state with Request = Some value }

    let httpEmailAttachment = HttpEmailAttachmentBuilder()

    type HttpInputBuilder() =
        member _.Yield(_: unit) : Types.HttpInput =
            {
                Extract = None
                Request = None
                ResponseContentType = None
            }

        [<CustomOperation("extract")>]
        member _.Extract(state: Types.HttpInput, value: string list) =
            { state with Extract = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.HttpInput, value: Types.HttpInputRequestDefinition) =
            { state with Request = Some value }

        [<CustomOperation("responseContentType")>]
        member _.ResponseContentType(state: Types.HttpInput, value: Types.ResponseContentType) =
            { state with ResponseContentType = Some value }

    let httpInput = HttpInputBuilder()

    type HttpInputRequestDefinitionBuilder() =
        member _.Yield(_: unit) : Types.HttpInputRequestDefinition =
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
        member _.Auth(state: Types.HttpInputRequestDefinition, value: Types.HttpInputAuthentication) =
            { state with Auth = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: Types.HttpInputRequestDefinition, value: string) =
            { state with Body = Some value }

        [<CustomOperation("connectionTimeout")>]
        member _.ConnectionTimeout(state: Types.HttpInputRequestDefinition, value: Types.Duration) =
            { state with ConnectionTimeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.HttpInputRequestDefinition, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.HttpInputRequestDefinition, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: Types.HttpInputRequestDefinition, value: Types.HttpInputMethod) =
            { state with Method = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.HttpInputRequestDefinition, value: Map<string, string>) =
            { state with Params = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.HttpInputRequestDefinition, value: string) =
            { state with Path = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.HttpInputRequestDefinition, value: Types.Uint) =
            { state with Port = Some value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: Types.HttpInputRequestDefinition, value: Types.HttpInputProxy) =
            { state with Proxy = Some value }

        [<CustomOperation("readTimeout")>]
        member _.ReadTimeout(state: Types.HttpInputRequestDefinition, value: Types.Duration) =
            { state with ReadTimeout = Some value }

        [<CustomOperation("scheme")>]
        member _.Scheme(state: Types.HttpInputRequestDefinition, value: Types.ConnectionScheme) =
            { state with Scheme = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.HttpInputRequestDefinition, value: string) =
            { state with Url = Some value }

    let httpInputRequestDefinition = HttpInputRequestDefinitionBuilder()

    type HttpInputRequestResultBuilder() =
        member _.Yield(_: unit) : Types.HttpInputRequestResult =
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
        member _.Auth(state: Types.HttpInputRequestResult, value: Types.HttpInputAuthentication) =
            { state with Auth = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: Types.HttpInputRequestResult, value: string) =
            { state with Body = Some value }

        [<CustomOperation("connectionTimeout")>]
        member _.ConnectionTimeout(state: Types.HttpInputRequestResult, value: Types.Duration) =
            { state with ConnectionTimeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.HttpInputRequestResult, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.HttpInputRequestResult, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: Types.HttpInputRequestResult, value: Types.HttpInputMethod) =
            { state with Method = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.HttpInputRequestResult, value: Map<string, string>) =
            { state with Params = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.HttpInputRequestResult, value: string) =
            { state with Path = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.HttpInputRequestResult, value: Types.Uint) =
            { state with Port = Some value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: Types.HttpInputRequestResult, value: Types.HttpInputProxy) =
            { state with Proxy = Some value }

        [<CustomOperation("readTimeout")>]
        member _.ReadTimeout(state: Types.HttpInputRequestResult, value: Types.Duration) =
            { state with ReadTimeout = Some value }

        [<CustomOperation("scheme")>]
        member _.Scheme(state: Types.HttpInputRequestResult, value: Types.ConnectionScheme) =
            { state with Scheme = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.HttpInputRequestResult, value: string) =
            { state with Url = Some value }

    let httpInputRequestResult = HttpInputRequestResultBuilder()

    type IndexActionBuilder() =
        member _.Yield(_: unit) : Types.IndexAction =
            {
                Index = Unchecked.defaultof<_>
                DocId = None
                Refresh = None
                OpType = None
                Timeout = None
                ExecutionTimeField = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.IndexAction, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("docId")>]
        member _.DocId(state: Types.IndexAction, value: Types.Id) =
            { state with DocId = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: Types.IndexAction, value: Types.Refresh) =
            { state with Refresh = Some value }

        [<CustomOperation("opType")>]
        member _.OpType(state: Types.IndexAction, value: Types.OpType) =
            { state with OpType = Some value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: Types.IndexAction, value: Types.Duration) =
            { state with Timeout = Some value }

        [<CustomOperation("executionTimeField")>]
        member _.ExecutionTimeField(state: Types.IndexAction, value: Types.Field) =
            { state with ExecutionTimeField = Some value }

    let indexAction = IndexActionBuilder()

    module Input =

        let chain (value: Types.ChainInput) =
            Types.InputContainer.Chain value

        let http (value: Types.HttpInput) =
            Types.InputContainer.Http value

        let search (value: Types.SearchInput) =
            Types.InputContainer.Search value

        let simple (value: Map<string, System.Text.Json.JsonElement>) =
            Types.InputContainer.Simple value

    type LoggingActionBuilder() =
        member _.Yield(_: unit) : Types.LoggingAction =
            {
                Level = None
                Text = Unchecked.defaultof<_>
                Category = None
            }

        [<CustomOperation("level")>]
        member _.Level(state: Types.LoggingAction, value: string) =
            { state with Level = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: Types.LoggingAction, value: string) =
            { state with Text = value }

        [<CustomOperation("category")>]
        member _.Category(state: Types.LoggingAction, value: string) =
            { state with Category = Some value }

    let loggingAction = LoggingActionBuilder()

    type PagerDutyActionBuilder() =
        member _.Yield(_: unit) : Types.PagerDutyAction =
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
        member _.Account(state: Types.PagerDutyAction, value: string) =
            { state with Account = Some value }

        [<CustomOperation("attachPayload")>]
        member _.AttachPayload(state: Types.PagerDutyAction, value: bool) =
            { state with AttachPayload = value }

        [<CustomOperation("client")>]
        member _.Client(state: Types.PagerDutyAction, value: string) =
            { state with Client = Some value }

        [<CustomOperation("clientUrl")>]
        member _.ClientUrl(state: Types.PagerDutyAction, value: string) =
            { state with ClientUrl = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: Types.PagerDutyAction, value: Types.PagerDutyContext list) =
            { state with Contexts = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.PagerDutyAction, value: string) =
            { state with Description = value }

        [<CustomOperation("eventType")>]
        member _.EventType(state: Types.PagerDutyAction, value: Types.PagerDutyEventType) =
            { state with EventType = Some value }

        [<CustomOperation("incidentKey")>]
        member _.IncidentKey(state: Types.PagerDutyAction, value: string) =
            { state with IncidentKey = value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: Types.PagerDutyAction, value: Types.PagerDutyEventProxy) =
            { state with Proxy = Some value }

    let pagerDutyAction = PagerDutyActionBuilder()

    type PagerDutyContextBuilder() =
        member _.Yield(_: unit) : Types.PagerDutyContext =
            {
                Href = None
                Src = None
                Type = Unchecked.defaultof<_>
            }

        [<CustomOperation("href")>]
        member _.Href(state: Types.PagerDutyContext, value: string) =
            { state with Href = Some value }

        [<CustomOperation("src")>]
        member _.Src(state: Types.PagerDutyContext, value: string) =
            { state with Src = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PagerDutyContext, value: Types.PagerDutyContextType) =
            { state with Type = value }

    let pagerDutyContext = PagerDutyContextBuilder()

    type PagerDutyEventBuilder() =
        member _.Yield(_: unit) : Types.PagerDutyEvent =
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
        member _.Account(state: Types.PagerDutyEvent, value: string) =
            { state with Account = Some value }

        [<CustomOperation("attachPayload")>]
        member _.AttachPayload(state: Types.PagerDutyEvent, value: bool) =
            { state with AttachPayload = value }

        [<CustomOperation("client")>]
        member _.Client(state: Types.PagerDutyEvent, value: string) =
            { state with Client = Some value }

        [<CustomOperation("clientUrl")>]
        member _.ClientUrl(state: Types.PagerDutyEvent, value: string) =
            { state with ClientUrl = Some value }

        [<CustomOperation("contexts")>]
        member _.Contexts(state: Types.PagerDutyEvent, value: Types.PagerDutyContext list) =
            { state with Contexts = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.PagerDutyEvent, value: string) =
            { state with Description = value }

        [<CustomOperation("eventType")>]
        member _.EventType(state: Types.PagerDutyEvent, value: Types.PagerDutyEventType) =
            { state with EventType = Some value }

        [<CustomOperation("incidentKey")>]
        member _.IncidentKey(state: Types.PagerDutyEvent, value: string) =
            { state with IncidentKey = value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: Types.PagerDutyEvent, value: Types.PagerDutyEventProxy) =
            { state with Proxy = Some value }

    let pagerDutyEvent = PagerDutyEventBuilder()

    type PagerDutyEventProxyBuilder() =
        member _.Yield(_: unit) : Types.PagerDutyEventProxy =
            {
                Host = None
                Port = None
            }

        [<CustomOperation("host")>]
        member _.Host(state: Types.PagerDutyEventProxy, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.PagerDutyEventProxy, value: Types.Integer) =
            { state with Port = Some value }

    let pagerDutyEventProxy = PagerDutyEventProxyBuilder()

    type PagerDutyResultBuilder() =
        member _.Yield(_: unit) : Types.PagerDutyResult =
            {
                Event = Unchecked.defaultof<_>
                Reason = None
                Request = None
                Response = None
            }

        [<CustomOperation("event")>]
        member _.Event(state: Types.PagerDutyResult, value: Types.PagerDutyEvent) =
            { state with Event = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.PagerDutyResult, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.PagerDutyResult, value: Types.HttpInputRequestResult) =
            { state with Request = Some value }

        [<CustomOperation("response")>]
        member _.Response(state: Types.PagerDutyResult, value: Types.HttpInputResponseResult) =
            { state with Response = Some value }

    let pagerDutyResult = PagerDutyResultBuilder()

    type QueryWatchBuilder() =
        member _.Yield(_: unit) : Types.QueryWatch =
            {
                Id = Unchecked.defaultof<_>
                Status = None
                Watch = None
                PrimaryTerm = None
                SeqNo = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.QueryWatch, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.QueryWatch, value: Types.WatchStatus) =
            { state with Status = Some value }

        [<CustomOperation("watch")>]
        member _.Watch(state: Types.QueryWatch, value: Types.Watch) =
            { state with Watch = Some value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: Types.QueryWatch, value: Types.Integer) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: Types.QueryWatch, value: Types.SequenceNumber) =
            { state with SeqNo = Some value }

    let queryWatch = QueryWatchBuilder()

    type ReportingEmailAttachmentBuilder() =
        member _.Yield(_: unit) : Types.ReportingEmailAttachment =
            {
                Url = Unchecked.defaultof<_>
                Inline = None
                Retries = None
                Interval = None
                Request = None
            }

        [<CustomOperation("url")>]
        member _.Url(state: Types.ReportingEmailAttachment, value: string) =
            { state with Url = value }

        [<CustomOperation("inline'")>]
        member _.Inline(state: Types.ReportingEmailAttachment, value: bool) =
            { state with Inline = Some value }

        [<CustomOperation("retries")>]
        member _.Retries(state: Types.ReportingEmailAttachment, value: Types.Integer) =
            { state with Retries = Some value }

        [<CustomOperation("interval")>]
        member _.Interval(state: Types.ReportingEmailAttachment, value: Types.Duration) =
            { state with Interval = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.ReportingEmailAttachment, value: Types.HttpInputRequestDefinition) =
            { state with Request = Some value }

    let reportingEmailAttachment = ReportingEmailAttachmentBuilder()

    module Schedule =

        let timezone (value: string) =
            Types.ScheduleContainer.Timezone value

        let cron (value: Types.CronExpression) =
            Types.ScheduleContainer.Cron value

        let daily (value: Types.DailySchedule) =
            Types.ScheduleContainer.Daily value

        let hourly (value: Types.HourlySchedule) =
            Types.ScheduleContainer.Hourly value

        let interval (value: Types.Duration) =
            Types.ScheduleContainer.Interval value

        let monthly (value: Types.TimeOfMonth list) =
            Types.ScheduleContainer.Monthly value

        let weekly (value: Types.TimeOfWeek list) =
            Types.ScheduleContainer.Weekly value

        let yearly (value: Types.TimeOfYear list) =
            Types.ScheduleContainer.Yearly value

    type ScriptConditionBuilder() =
        member _.Yield(_: unit) : Types.ScriptCondition =
            {
                Lang = None
                Params = None
                Source = None
                Id = None
            }

        [<CustomOperation("lang")>]
        member _.Lang(state: Types.ScriptCondition, value: Types.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.ScriptCondition, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.ScriptCondition, value: Types.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ScriptCondition, value: string) =
            { state with Id = Some value }

    let scriptCondition = ScriptConditionBuilder()

    type SearchInputBuilder() =
        member _.Yield(_: unit) : Types.SearchInput =
            {
                Extract = None
                Request = Unchecked.defaultof<_>
                Timeout = None
            }

        [<CustomOperation("extract")>]
        member _.Extract(state: Types.SearchInput, value: string list) =
            { state with Extract = Some value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.SearchInput, value: Types.SearchInputRequestDefinition) =
            { state with Request = value }

        [<CustomOperation("timeout")>]
        member _.Timeout(state: Types.SearchInput, value: Types.Duration) =
            { state with Timeout = Some value }

    let searchInput = SearchInputBuilder()

    type SearchInputRequestDefinitionBuilder() =
        member _.Yield(_: unit) : Types.SearchInputRequestDefinition =
            {
                Body = None
                Indices = None
                IndicesOptions = None
                SearchType = None
                Template = None
                RestTotalHitsAsInt = None
            }

        [<CustomOperation("body")>]
        member _.Body(state: Types.SearchInputRequestDefinition, value: Types.SearchInputRequestBody) =
            { state with Body = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.SearchInputRequestDefinition, value: Types.IndexName list) =
            { state with Indices = Some value }

        [<CustomOperation("indicesOptions")>]
        member _.IndicesOptions(state: Types.SearchInputRequestDefinition, value: Types.IndicesOptions) =
            { state with IndicesOptions = Some value }

        [<CustomOperation("searchType")>]
        member _.SearchType(state: Types.SearchInputRequestDefinition, value: Types.SearchType) =
            { state with SearchType = Some value }

        [<CustomOperation("template")>]
        member _.Template(state: Types.SearchInputRequestDefinition, value: Types.SearchTemplateRequestBody) =
            { state with Template = Some value }

        [<CustomOperation("restTotalHitsAsInt")>]
        member _.RestTotalHitsAsInt(state: Types.SearchInputRequestDefinition, value: bool) =
            { state with RestTotalHitsAsInt = Some value }

    let searchInputRequestDefinition = SearchInputRequestDefinitionBuilder()

    type SearchTemplateRequestBodyBuilder() =
        member _.Yield(_: unit) : Types.SearchTemplateRequestBody =
            {
                Explain = None
                Id = None
                Params = None
                Profile = None
                Source = None
            }

        [<CustomOperation("explain")>]
        member _.Explain(state: Types.SearchTemplateRequestBody, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.SearchTemplateRequestBody, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.SearchTemplateRequestBody, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: Types.SearchTemplateRequestBody, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.SearchTemplateRequestBody, value: string) =
            { state with Source = Some value }

    let searchTemplateRequestBody = SearchTemplateRequestBodyBuilder()

    type SlackAttachmentBuilder() =
        member _.Yield(_: unit) : Types.SlackAttachment =
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
        member _.AuthorIcon(state: Types.SlackAttachment, value: string) =
            { state with AuthorIcon = Some value }

        [<CustomOperation("authorLink")>]
        member _.AuthorLink(state: Types.SlackAttachment, value: string) =
            { state with AuthorLink = Some value }

        [<CustomOperation("authorName")>]
        member _.AuthorName(state: Types.SlackAttachment, value: string) =
            { state with AuthorName = value }

        [<CustomOperation("color")>]
        member _.Color(state: Types.SlackAttachment, value: string) =
            { state with Color = Some value }

        [<CustomOperation("fallback")>]
        member _.Fallback(state: Types.SlackAttachment, value: string) =
            { state with Fallback = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.SlackAttachment, value: Types.SlackAttachmentField list) =
            { state with Fields = Some value }

        [<CustomOperation("footer")>]
        member _.Footer(state: Types.SlackAttachment, value: string) =
            { state with Footer = Some value }

        [<CustomOperation("footerIcon")>]
        member _.FooterIcon(state: Types.SlackAttachment, value: string) =
            { state with FooterIcon = Some value }

        [<CustomOperation("imageUrl")>]
        member _.ImageUrl(state: Types.SlackAttachment, value: string) =
            { state with ImageUrl = Some value }

        [<CustomOperation("pretext")>]
        member _.Pretext(state: Types.SlackAttachment, value: string) =
            { state with Pretext = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: Types.SlackAttachment, value: string) =
            { state with Text = Some value }

        [<CustomOperation("thumbUrl")>]
        member _.ThumbUrl(state: Types.SlackAttachment, value: string) =
            { state with ThumbUrl = Some value }

        [<CustomOperation("title")>]
        member _.Title(state: Types.SlackAttachment, value: string) =
            { state with Title = value }

        [<CustomOperation("titleLink")>]
        member _.TitleLink(state: Types.SlackAttachment, value: string) =
            { state with TitleLink = Some value }

        [<CustomOperation("ts")>]
        member _.Ts(state: Types.SlackAttachment, value: Types.EpochTime<Types.UnitSeconds>) =
            { state with Ts = Some value }

    let slackAttachment = SlackAttachmentBuilder()

    type SlackMessageBuilder() =
        member _.Yield(_: unit) : Types.SlackMessage =
            {
                Attachments = Unchecked.defaultof<_>
                DynamicAttachments = None
                From = Unchecked.defaultof<_>
                Icon = None
                Text = Unchecked.defaultof<_>
                To = Unchecked.defaultof<_>
            }

        [<CustomOperation("attachments")>]
        member _.Attachments(state: Types.SlackMessage, value: Types.SlackAttachment list) =
            { state with Attachments = value }

        [<CustomOperation("dynamicAttachments")>]
        member _.DynamicAttachments(state: Types.SlackMessage, value: Types.SlackDynamicAttachment) =
            { state with DynamicAttachments = Some value }

        [<CustomOperation("from")>]
        member _.From(state: Types.SlackMessage, value: string) =
            { state with From = value }

        [<CustomOperation("icon")>]
        member _.Icon(state: Types.SlackMessage, value: string) =
            { state with Icon = Some value }

        [<CustomOperation("text")>]
        member _.Text(state: Types.SlackMessage, value: string) =
            { state with Text = value }

        [<CustomOperation("to'")>]
        member _.To(state: Types.SlackMessage, value: string list) =
            { state with To = value }

    let slackMessage = SlackMessageBuilder()

    module Trigger =

        let schedule (value: Types.ScheduleContainer) =
            Types.TriggerContainer.Schedule value

    module TriggerEvent =

        let schedule (value: Types.ScheduleTriggerEvent) =
            Types.TriggerEventContainer.Schedule value

    type WatchBuilder() =
        member _.Yield(_: unit) : Types.Watch =
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
        member _.Actions(state: Types.Watch, value: Map<Types.IndexName, Types.WatcherTypesAction>) =
            { state with Actions = value }

        [<CustomOperation("condition")>]
        member _.Condition(state: Types.Watch, value: Types.ConditionContainer) =
            { state with Condition = value }

        [<CustomOperation("input")>]
        member _.Input(state: Types.Watch, value: Types.InputContainer) =
            { state with Input = value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.Watch, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.Watch, value: Types.WatchStatus) =
            { state with Status = Some value }

        [<CustomOperation("throttlePeriod")>]
        member _.ThrottlePeriod(state: Types.Watch, value: Types.Duration) =
            { state with ThrottlePeriod = Some value }

        [<CustomOperation("throttlePeriodInMillis")>]
        member _.ThrottlePeriodInMillis(state: Types.Watch, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottlePeriodInMillis = Some value }

        [<CustomOperation("transform")>]
        member _.Transform(state: Types.Watch, value: Types.TransformContainer) =
            { state with Transform = Some value }

        [<CustomOperation("trigger")>]
        member _.Trigger(state: Types.Watch, value: Types.TriggerContainer) =
            { state with Trigger = value }

    let watch = WatchBuilder()

    type WatchStatusBuilder() =
        member _.Yield(_: unit) : Types.WatchStatus =
            {
                Actions = Unchecked.defaultof<_>
                LastChecked = None
                LastMetCondition = None
                State = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                ExecutionState = None
            }

        [<CustomOperation("actions")>]
        member _.Actions(state: Types.WatchStatus, value: Types.WatcherTypesActions) =
            { state with Actions = value }

        [<CustomOperation("lastChecked")>]
        member _.LastChecked(state: Types.WatchStatus, value: Types.DateTime) =
            { state with LastChecked = Some value }

        [<CustomOperation("lastMetCondition")>]
        member _.LastMetCondition(state: Types.WatchStatus, value: Types.DateTime) =
            { state with LastMetCondition = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.WatchStatus, value: Types.ActivationState) =
            { state with State = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.WatchStatus, value: Types.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("executionState")>]
        member _.ExecutionState(state: Types.WatchStatus, value: string) =
            { state with ExecutionState = Some value }

    let watchStatus = WatchStatusBuilder()

    type WebhookActionBuilder() =
        member _.Yield(_: unit) : Types.WebhookAction =
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
        member _.Auth(state: Types.WebhookAction, value: Types.HttpInputAuthentication) =
            { state with Auth = Some value }

        [<CustomOperation("body")>]
        member _.Body(state: Types.WebhookAction, value: string) =
            { state with Body = Some value }

        [<CustomOperation("connectionTimeout")>]
        member _.ConnectionTimeout(state: Types.WebhookAction, value: Types.Duration) =
            { state with ConnectionTimeout = Some value }

        [<CustomOperation("headers")>]
        member _.Headers(state: Types.WebhookAction, value: Map<string, string>) =
            { state with Headers = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.WebhookAction, value: Types.Host) =
            { state with Host = Some value }

        [<CustomOperation("method")>]
        member _.Method(state: Types.WebhookAction, value: Types.HttpInputMethod) =
            { state with Method = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.WebhookAction, value: Map<string, string>) =
            { state with Params = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.WebhookAction, value: string) =
            { state with Path = Some value }

        [<CustomOperation("port")>]
        member _.Port(state: Types.WebhookAction, value: Types.Uint) =
            { state with Port = Some value }

        [<CustomOperation("proxy")>]
        member _.Proxy(state: Types.WebhookAction, value: Types.HttpInputProxy) =
            { state with Proxy = Some value }

        [<CustomOperation("readTimeout")>]
        member _.ReadTimeout(state: Types.WebhookAction, value: Types.Duration) =
            { state with ReadTimeout = Some value }

        [<CustomOperation("scheme")>]
        member _.Scheme(state: Types.WebhookAction, value: Types.ConnectionScheme) =
            { state with Scheme = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.WebhookAction, value: string) =
            { state with Url = Some value }

    let webhookAction = WebhookActionBuilder()

