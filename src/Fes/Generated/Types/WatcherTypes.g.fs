// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module WatcherTypes =

    [<RequireQualifiedAccess>]
    type AcknowledgementOptions =
        | AwaitsSuccessfulExecution
        | Ackable
        | Acked

    type AcknowledgeState = {
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: AcknowledgementOptions
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.DateTime
    }

    [<RequireQualifiedAccess>]
    type ActionType =
        | Email
        | Webhook
        | Index
        | Logging
        | Slack
        | Pagerduty

    type AlwaysCondition = System.Text.Json.JsonElement

    type ArrayCompareCondition = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string
    }

    [<RequireQualifiedAccess>]
    type ConditionOp =
        | NotEq
        | Eq
        | Lt
        | Gt
        | Lte
        | Gte

    type NeverCondition = System.Text.Json.JsonElement

    type ScriptCondition = {
        [<System.Text.Json.Serialization.JsonPropertyName("lang")>]
        Lang: CoreTypes.ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: CoreTypes.ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
    }

    [<RequireQualifiedAccess>]
    type ConditionContainer =
        | Always of AlwaysCondition
        | ArrayCompare of field: string * ArrayCompareCondition
        | Compare of field: string * Map<ConditionOp, CoreTypes.FieldValue>
        | Never of NeverCondition
        | Script of ScriptCondition

    type IndexAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("doc_id")>]
        DocId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh")>]
        Refresh: CoreTypes.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("op_type")>]
        OpType: CoreTypes.OpType option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_time_field")>]
        ExecutionTimeField: CoreTypes.Field option
    }

    type LoggingAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("level")>]
        Level: string option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("category")>]
        Category: string option
    }

    type EmailBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("html")>]
        Html: string option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
    }

    [<RequireQualifiedAccess>]
    type EmailPriority =
        | Lowest
        | Low
        | Normal
        | High
        | Highest

    type HttpInputBasicAuthentication = {
        [<System.Text.Json.Serialization.JsonPropertyName("password")>]
        Password: CoreTypes.Password
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: CoreTypes.Username
    }

    type HttpInputAuthentication = {
        [<System.Text.Json.Serialization.JsonPropertyName("basic")>]
        Basic: HttpInputBasicAuthentication
    }

    [<RequireQualifiedAccess>]
    type HttpInputMethod =
        | Head
        | Get
        | Post
        | Put
        | Delete

    type HttpInputProxy = {
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: CoreTypes.Uint
    }

    [<RequireQualifiedAccess>]
    type ConnectionScheme =
        | Http
        | Https

    type HttpInputRequestDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("auth")>]
        Auth: HttpInputAuthentication option
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: string option
        [<System.Text.Json.Serialization.JsonPropertyName("connection_timeout")>]
        ConnectionTimeout: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: HttpInputMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: CoreTypes.Uint option
        [<System.Text.Json.Serialization.JsonPropertyName("proxy")>]
        Proxy: HttpInputProxy option
        [<System.Text.Json.Serialization.JsonPropertyName("read_timeout")>]
        ReadTimeout: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("scheme")>]
        Scheme: ConnectionScheme option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
    }

    type HttpEmailAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("content_type")>]
        ContentType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inline")>]
        Inline: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: HttpInputRequestDefinition option
    }

    type ReportingEmailAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("inline")>]
        Inline: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("retries")>]
        Retries: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: HttpInputRequestDefinition option
    }

    [<RequireQualifiedAccess>]
    type DataAttachmentFormat =
        | Json
        | Yaml

    type DataEmailAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: DataAttachmentFormat option
    }

    [<RequireQualifiedAccess>]
    type EmailAttachmentContainer =
        | Http of HttpEmailAttachment
        | Reporting of ReportingEmailAttachment
        | Data of DataEmailAttachment

    type Email = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("bcc")>]
        Bcc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: EmailBody option
        [<System.Text.Json.Serialization.JsonPropertyName("cc")>]
        Cc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: string option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: EmailPriority option
        [<System.Text.Json.Serialization.JsonPropertyName("reply_to")>]
        ReplyTo: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("sent_date")>]
        SentDate: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("subject")>]
        Subject: string
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("attachments")>]
        Attachments: Map<string, EmailAttachmentContainer> option
    }

    type EmailAction = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type PagerDutyContextType =
        | Link
        | Image

    type PagerDutyContext = {
        [<System.Text.Json.Serialization.JsonPropertyName("href")>]
        Href: string option
        [<System.Text.Json.Serialization.JsonPropertyName("src")>]
        Src: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: PagerDutyContextType
    }

    [<RequireQualifiedAccess>]
    type PagerDutyEventType =
        | Trigger
        | Resolve
        | Acknowledge

    type PagerDutyEventProxy = {
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: CoreTypes.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: CoreTypes.Integer option
    }

    type PagerDutyEvent = {
        [<System.Text.Json.Serialization.JsonPropertyName("account")>]
        Account: string option
        [<System.Text.Json.Serialization.JsonPropertyName("attach_payload")>]
        AttachPayload: bool
        [<System.Text.Json.Serialization.JsonPropertyName("client")>]
        Client: string option
        [<System.Text.Json.Serialization.JsonPropertyName("client_url")>]
        ClientUrl: string option
        [<System.Text.Json.Serialization.JsonPropertyName("contexts")>]
        Contexts: PagerDutyContext list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("event_type")>]
        EventType: PagerDutyEventType option
        [<System.Text.Json.Serialization.JsonPropertyName("incident_key")>]
        IncidentKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("proxy")>]
        Proxy: PagerDutyEventProxy option
    }

    type PagerDutyAction = System.Text.Json.JsonElement

    type SlackAttachmentField = {
        [<System.Text.Json.Serialization.JsonPropertyName("short")>]
        Short: bool
        [<System.Text.Json.Serialization.JsonPropertyName("title")>]
        Title: string
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: string
    }

    type SlackAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("author_icon")>]
        AuthorIcon: string option
        [<System.Text.Json.Serialization.JsonPropertyName("author_link")>]
        AuthorLink: string option
        [<System.Text.Json.Serialization.JsonPropertyName("author_name")>]
        AuthorName: string
        [<System.Text.Json.Serialization.JsonPropertyName("color")>]
        Color: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fallback")>]
        Fallback: string option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: SlackAttachmentField list option
        [<System.Text.Json.Serialization.JsonPropertyName("footer")>]
        Footer: string option
        [<System.Text.Json.Serialization.JsonPropertyName("footer_icon")>]
        FooterIcon: string option
        [<System.Text.Json.Serialization.JsonPropertyName("image_url")>]
        ImageUrl: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pretext")>]
        Pretext: string option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string option
        [<System.Text.Json.Serialization.JsonPropertyName("thumb_url")>]
        ThumbUrl: string option
        [<System.Text.Json.Serialization.JsonPropertyName("title")>]
        Title: string
        [<System.Text.Json.Serialization.JsonPropertyName("title_link")>]
        TitleLink: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ts")>]
        Ts: CoreTypes.EpochTime<CoreTypes.UnitSeconds> option
    }

    type SlackDynamicAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("attachment_template")>]
        AttachmentTemplate: SlackAttachment
        [<System.Text.Json.Serialization.JsonPropertyName("list_path")>]
        ListPath: string
    }

    type SlackMessage = {
        [<System.Text.Json.Serialization.JsonPropertyName("attachments")>]
        Attachments: SlackAttachment list
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_attachments")>]
        DynamicAttachments: SlackDynamicAttachment option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: string
        [<System.Text.Json.Serialization.JsonPropertyName("icon")>]
        Icon: string option
        [<System.Text.Json.Serialization.JsonPropertyName("text")>]
        Text: string
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: string list
    }

    type SlackAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("account")>]
        Account: string option
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: SlackMessage
    }

    type WebhookAction = System.Text.Json.JsonElement

    type Action = {
        [<System.Text.Json.Serialization.JsonPropertyName("action_type")>]
        ActionType: ActionType option
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: ConditionContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("foreach")>]
        Foreach: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_iterations")>]
        MaxIterations: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period")>]
        ThrottlePeriod: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period_in_millis")>]
        ThrottlePeriodInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: CoreTypes.TransformContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexAction option
        [<System.Text.Json.Serialization.JsonPropertyName("logging")>]
        Logging: LoggingAction option
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: EmailAction option
        [<System.Text.Json.Serialization.JsonPropertyName("pagerduty")>]
        Pagerduty: PagerDutyAction option
        [<System.Text.Json.Serialization.JsonPropertyName("slack")>]
        Slack: SlackAction option
        [<System.Text.Json.Serialization.JsonPropertyName("webhook")>]
        Webhook: WebhookAction option
    }

    [<RequireQualifiedAccess>]
    type ActionExecutionMode =
        | Simulate
        | ForceSimulate
        | Execute
        | ForceExecute
        | Skip

    type ExecutionState = {
        [<System.Text.Json.Serialization.JsonPropertyName("successful")>]
        Successful: bool
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
    }

    type ThrottleState = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.DateTime
    }

    type ActionStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("ack")>]
        Ack: AcknowledgeState
        [<System.Text.Json.Serialization.JsonPropertyName("last_execution")>]
        LastExecution: ExecutionState option
        [<System.Text.Json.Serialization.JsonPropertyName("last_successful_execution")>]
        LastSuccessfulExecution: ExecutionState option
        [<System.Text.Json.Serialization.JsonPropertyName("last_throttle")>]
        LastThrottle: ThrottleState option
    }

    [<RequireQualifiedAccess>]
    type ActionStatusOptions =
        | Success
        | Failure
        | Simulated
        | Throttled

    type Actions = Map<CoreTypes.IndexName, ActionStatus>

    type ActivationState = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: bool
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.DateTime
    }

    type ActivationStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Actions
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: ActivationState
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber
    }

    [<RequireQualifiedAccess>]
    type Quantifier =
        | Some
        | All

    type ArrayCompareOpParams = {
        [<System.Text.Json.Serialization.JsonPropertyName("quantifier")>]
        Quantifier: Quantifier
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.FieldValue
    }

    [<RequireQualifiedAccess>]
    type ResponseContentType =
        | Json
        | Yaml
        | Text

    type HttpInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("extract")>]
        Extract: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: HttpInputRequestDefinition option
        [<System.Text.Json.Serialization.JsonPropertyName("response_content_type")>]
        ResponseContentType: ResponseContentType option
    }

    type SearchInputRequestBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer
    }

    type SearchTemplateRequestBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: string option
    }

    type SearchInputRequestDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: SearchInputRequestBody option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.IndexName list option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: CoreTypes.IndicesOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("search_type")>]
        SearchType: CoreTypes.SearchType option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: SearchTemplateRequestBody option
        [<System.Text.Json.Serialization.JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
    }

    type SearchInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("extract")>]
        Extract: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: SearchInputRequestDefinition
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: CoreTypes.Duration option
    }

    type ChainInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("inputs")>]
        Inputs: Map<string, InputContainer> list
    }

    and [<RequireQualifiedAccess>] InputContainer =
        | Chain of ChainInput
        | Http of HttpInput
        | Search of SearchInput
        | Simple of Map<string, System.Text.Json.JsonElement>

    [<RequireQualifiedAccess>]
    type ConditionType =
        | Always
        | Never
        | Script
        | Compare
        | ArrayCompare

    type CronExpression = string

    type HourAndMinute = {
        [<System.Text.Json.Serialization.JsonPropertyName("hour")>]
        Hour: CoreTypes.Integer list
        [<System.Text.Json.Serialization.JsonPropertyName("minute")>]
        Minute: CoreTypes.Integer list
    }

    /// A time of day, expressed either as `hh:mm`, `noon`, `midnight`, or an hour/minutes structure.
    [<RequireQualifiedAccess>]
    type ScheduleTimeOfDay =
        | String of string
        | HourAndMinute of HourAndMinute

    type DailySchedule = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: ScheduleTimeOfDay list
    }

    [<RequireQualifiedAccess>]
    type Day =
        | Sunday
        | Monday
        | Tuesday
        | Wednesday
        | Thursday
        | Friday
        | Saturday

    type EmailResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("account")>]
        Account: string option
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: Email
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
    }

    [<RequireQualifiedAccess>]
    type ExecutionPhase =
        | AwaitsExecution
        | Started
        | Input
        | Condition
        | Actions
        | WatchTransform
        | Aborted
        | Finished

    type IndexResultSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("created")>]
        Created: bool
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: CoreTypes.Result
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber
    }

    type IndexResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: IndexResultSummary
    }

    type LoggingResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("logged_text")>]
        LoggedText: string
    }

    type HttpInputRequestResult = System.Text.Json.JsonElement

    type HttpInputResponseResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: string
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: CoreTypes.HttpHeaders
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.Integer
    }

    type PagerDutyResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("event")>]
        Event: PagerDutyEvent
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: HttpInputRequestResult option
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: HttpInputResponseResult option
    }

    type SlackResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("account")>]
        Account: string option
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: SlackMessage
    }

    type WebhookResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: HttpInputRequestResult
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: HttpInputResponseResult option
    }

    type ExecutionResultAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: EmailResult option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: IndexResult option
        [<System.Text.Json.Serialization.JsonPropertyName("logging")>]
        Logging: LoggingResult option
        [<System.Text.Json.Serialization.JsonPropertyName("pagerduty")>]
        Pagerduty: PagerDutyResult option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("slack")>]
        Slack: SlackResult option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ActionStatusOptions
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ActionType
        [<System.Text.Json.Serialization.JsonPropertyName("webhook")>]
        Webhook: WebhookResult option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
    }

    type ExecutionResultCondition = {
        [<System.Text.Json.Serialization.JsonPropertyName("met")>]
        Met: bool
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ActionStatusOptions
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: ConditionType
    }

    [<RequireQualifiedAccess>]
    type InputType =
        | Http
        | Search
        | Simple

    type ExecutionResultInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("payload")>]
        Payload: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: ActionStatusOptions
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: InputType
    }

    type ExecutionResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: ExecutionResultAction list
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: ExecutionResultCondition
        [<System.Text.Json.Serialization.JsonPropertyName("execution_duration")>]
        ExecutionDuration: CoreTypes.DurationValue<CoreTypes.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("execution_time")>]
        ExecutionTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: ExecutionResultInput
    }

    [<RequireQualifiedAccess>]
    type ExecutionStatus =
        | AwaitsExecution
        | Checking
        | ExecutionNotNeeded
        | Throttled
        | Executed
        | Failed
        | DeletedWhileQueued
        | NotExecutedAlreadyQueued

    type ExecutionThreadPool = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: CoreTypes.Long
    }

    type HourlySchedule = {
        [<System.Text.Json.Serialization.JsonPropertyName("minute")>]
        Minute: CoreTypes.Integer list
    }

    [<RequireQualifiedAccess>]
    type Month =
        | January
        | February
        | March
        | April
        | May
        | June
        | July
        | August
        | September
        | October
        | November
        | December

    type WatchStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Actions
        [<System.Text.Json.Serialization.JsonPropertyName("last_checked")>]
        LastChecked: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_met_condition")>]
        LastMetCondition: CoreTypes.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: ActivationState
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("execution_state")>]
        ExecutionState: string option
    }

    type TimeOfMonth = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: string list
        [<System.Text.Json.Serialization.JsonPropertyName("on")>]
        On: CoreTypes.Integer list
    }

    type TimeOfWeek = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: string list
        [<System.Text.Json.Serialization.JsonPropertyName("on")>]
        On: Day list
    }

    type TimeOfYear = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: string list
        [<System.Text.Json.Serialization.JsonPropertyName("int")>]
        Int: Month list
        [<System.Text.Json.Serialization.JsonPropertyName("on")>]
        On: CoreTypes.Integer list
    }

    [<RequireQualifiedAccess>]
    type ScheduleContainer =
        | Timezone of string
        | Cron of CronExpression
        | Daily of DailySchedule
        | Hourly of HourlySchedule
        | Interval of CoreTypes.Duration
        | Monthly of System.Text.Json.JsonElement
        | Weekly of System.Text.Json.JsonElement
        | Yearly of System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type TriggerContainer =
        | Schedule of ScheduleContainer

    type Watch = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Map<CoreTypes.IndexName, Action>
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: ConditionContainer
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: InputContainer
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatchStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period")>]
        ThrottlePeriod: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period_in_millis")>]
        ThrottlePeriodInMillis: CoreTypes.DurationValue<CoreTypes.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: CoreTypes.TransformContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("trigger")>]
        Trigger: TriggerContainer
    }

    type QueryWatch = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatchStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("watch")>]
        Watch: Watch option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: CoreTypes.SequenceNumber option
    }

    type ScheduleTriggerEvent = {
        [<System.Text.Json.Serialization.JsonPropertyName("scheduled_time")>]
        ScheduledTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("triggered_time")>]
        TriggeredTime: CoreTypes.DateTime option
    }

    type SimulatedActions = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: string list
        [<System.Text.Json.Serialization.JsonPropertyName("all")>]
        All: SimulatedActions
        [<System.Text.Json.Serialization.JsonPropertyName("use_all")>]
        UseAll: bool
    }

    [<RequireQualifiedAccess>]
    type TriggerEventContainer =
        | Schedule of ScheduleTriggerEvent

    type TriggerEventResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("manual")>]
        Manual: TriggerEventContainer
        [<System.Text.Json.Serialization.JsonPropertyName("triggered_time")>]
        TriggeredTime: CoreTypes.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

