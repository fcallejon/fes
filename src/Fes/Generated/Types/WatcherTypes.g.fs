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
        State: WatcherTypes.AcknowledgementOptions
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.DateTime
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
        Lang: Types.ScriptLanguage option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: Types.ScriptSource option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
    }

    [<RequireQualifiedAccess>]
    type ConditionContainer =
        | Always of WatcherTypes.AlwaysCondition
        | ArrayCompare of field: string * WatcherTypes.ArrayCompareCondition
        | Compare of field: string * Map<WatcherTypes.ConditionOp, Types.FieldValue>
        | Never of WatcherTypes.NeverCondition
        | Script of WatcherTypes.ScriptCondition

    type IndexAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("doc_id")>]
        DocId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh")>]
        Refresh: Types.Refresh option
        [<System.Text.Json.Serialization.JsonPropertyName("op_type")>]
        OpType: Types.OpType option
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("execution_time_field")>]
        ExecutionTimeField: Types.Field option
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
        Password: Types.Password
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: Types.Username
    }

    type HttpInputAuthentication = {
        [<System.Text.Json.Serialization.JsonPropertyName("basic")>]
        Basic: WatcherTypes.HttpInputBasicAuthentication
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
        Host: Types.Host
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: Types.Uint
    }

    [<RequireQualifiedAccess>]
    type ConnectionScheme =
        | Http
        | Https

    type HttpInputRequestDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("auth")>]
        Auth: WatcherTypes.HttpInputAuthentication option
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: string option
        [<System.Text.Json.Serialization.JsonPropertyName("connection_timeout")>]
        ConnectionTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("headers")>]
        Headers: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("method")>]
        Method: WatcherTypes.HttpInputMethod option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: Types.Uint option
        [<System.Text.Json.Serialization.JsonPropertyName("proxy")>]
        Proxy: WatcherTypes.HttpInputProxy option
        [<System.Text.Json.Serialization.JsonPropertyName("read_timeout")>]
        ReadTimeout: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("scheme")>]
        Scheme: WatcherTypes.ConnectionScheme option
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string option
    }

    type HttpEmailAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("content_type")>]
        ContentType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("inline")>]
        Inline: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.HttpInputRequestDefinition option
    }

    type ReportingEmailAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("url")>]
        Url: string
        [<System.Text.Json.Serialization.JsonPropertyName("inline")>]
        Inline: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("retries")>]
        Retries: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("interval")>]
        Interval: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.HttpInputRequestDefinition option
    }

    [<RequireQualifiedAccess>]
    type DataAttachmentFormat =
        | Json
        | Yaml

    type DataEmailAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("format")>]
        Format: WatcherTypes.DataAttachmentFormat option
    }

    [<RequireQualifiedAccess>]
    type EmailAttachmentContainer =
        | Http of WatcherTypes.HttpEmailAttachment
        | Reporting of WatcherTypes.ReportingEmailAttachment
        | Data of WatcherTypes.DataEmailAttachment

    type Email = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("bcc")>]
        Bcc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: WatcherTypes.EmailBody option
        [<System.Text.Json.Serialization.JsonPropertyName("cc")>]
        Cc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("from")>]
        From: string option
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: WatcherTypes.EmailPriority option
        [<System.Text.Json.Serialization.JsonPropertyName("reply_to")>]
        ReplyTo: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("sent_date")>]
        SentDate: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("subject")>]
        Subject: string
        [<System.Text.Json.Serialization.JsonPropertyName("to")>]
        To: System.Text.Json.JsonElement
        [<System.Text.Json.Serialization.JsonPropertyName("attachments")>]
        Attachments: Map<string, WatcherTypes.EmailAttachmentContainer> option
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
        Type: WatcherTypes.PagerDutyContextType
    }

    [<RequireQualifiedAccess>]
    type PagerDutyEventType =
        | Trigger
        | Resolve
        | Acknowledge

    type PagerDutyEventProxy = {
        [<System.Text.Json.Serialization.JsonPropertyName("host")>]
        Host: Types.Host option
        [<System.Text.Json.Serialization.JsonPropertyName("port")>]
        Port: Types.Integer option
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
        Contexts: WatcherTypes.PagerDutyContext list option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("event_type")>]
        EventType: WatcherTypes.PagerDutyEventType option
        [<System.Text.Json.Serialization.JsonPropertyName("incident_key")>]
        IncidentKey: string
        [<System.Text.Json.Serialization.JsonPropertyName("proxy")>]
        Proxy: WatcherTypes.PagerDutyEventProxy option
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
        Fields: WatcherTypes.SlackAttachmentField list option
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
        Ts: Types.EpochTime<Types.UnitSeconds> option
    }

    type SlackDynamicAttachment = {
        [<System.Text.Json.Serialization.JsonPropertyName("attachment_template")>]
        AttachmentTemplate: WatcherTypes.SlackAttachment
        [<System.Text.Json.Serialization.JsonPropertyName("list_path")>]
        ListPath: string
    }

    type SlackMessage = {
        [<System.Text.Json.Serialization.JsonPropertyName("attachments")>]
        Attachments: WatcherTypes.SlackAttachment list
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_attachments")>]
        DynamicAttachments: WatcherTypes.SlackDynamicAttachment option
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
        Message: WatcherTypes.SlackMessage
    }

    type WebhookAction = System.Text.Json.JsonElement

    type Action = {
        [<System.Text.Json.Serialization.JsonPropertyName("action_type")>]
        ActionType: WatcherTypes.ActionType option
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: WatcherTypes.ConditionContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("foreach")>]
        Foreach: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_iterations")>]
        MaxIterations: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period")>]
        ThrottlePeriod: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period_in_millis")>]
        ThrottlePeriodInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: Types.TransformContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: WatcherTypes.IndexAction option
        [<System.Text.Json.Serialization.JsonPropertyName("logging")>]
        Logging: WatcherTypes.LoggingAction option
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: WatcherTypes.EmailAction option
        [<System.Text.Json.Serialization.JsonPropertyName("pagerduty")>]
        Pagerduty: WatcherTypes.PagerDutyAction option
        [<System.Text.Json.Serialization.JsonPropertyName("slack")>]
        Slack: WatcherTypes.SlackAction option
        [<System.Text.Json.Serialization.JsonPropertyName("webhook")>]
        Webhook: WatcherTypes.WebhookAction option
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
        Timestamp: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
    }

    type ThrottleState = {
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.DateTime
    }

    type ActionStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("ack")>]
        Ack: WatcherTypes.AcknowledgeState
        [<System.Text.Json.Serialization.JsonPropertyName("last_execution")>]
        LastExecution: WatcherTypes.ExecutionState option
        [<System.Text.Json.Serialization.JsonPropertyName("last_successful_execution")>]
        LastSuccessfulExecution: WatcherTypes.ExecutionState option
        [<System.Text.Json.Serialization.JsonPropertyName("last_throttle")>]
        LastThrottle: WatcherTypes.ThrottleState option
    }

    [<RequireQualifiedAccess>]
    type ActionStatusOptions =
        | Success
        | Failure
        | Simulated
        | Throttled

    type Actions = Map<Types.IndexName, WatcherTypes.ActionStatus>

    type ActivationState = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: bool
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.DateTime
    }

    type ActivationStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: WatcherTypes.Actions
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: WatcherTypes.ActivationState
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
    }

    [<RequireQualifiedAccess>]
    type Quantifier =
        | Some
        | All

    type ArrayCompareOpParams = {
        [<System.Text.Json.Serialization.JsonPropertyName("quantifier")>]
        Quantifier: WatcherTypes.Quantifier
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.FieldValue
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
        Request: WatcherTypes.HttpInputRequestDefinition option
        [<System.Text.Json.Serialization.JsonPropertyName("response_content_type")>]
        ResponseContentType: WatcherTypes.ResponseContentType option
    }

    type SearchInputRequestBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
    }

    type SearchTemplateRequestBody = {
        [<System.Text.Json.Serialization.JsonPropertyName("explain")>]
        Explain: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("profile")>]
        Profile: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: string option
    }

    type SearchInputRequestDefinition = {
        [<System.Text.Json.Serialization.JsonPropertyName("body")>]
        Body: WatcherTypes.SearchInputRequestBody option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.IndexName list option
        [<System.Text.Json.Serialization.JsonPropertyName("indices_options")>]
        IndicesOptions: Types.IndicesOptions option
        [<System.Text.Json.Serialization.JsonPropertyName("search_type")>]
        SearchType: Types.SearchType option
        [<System.Text.Json.Serialization.JsonPropertyName("template")>]
        Template: WatcherTypes.SearchTemplateRequestBody option
        [<System.Text.Json.Serialization.JsonPropertyName("rest_total_hits_as_int")>]
        RestTotalHitsAsInt: bool option
    }

    type SearchInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("extract")>]
        Extract: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.SearchInputRequestDefinition
        [<System.Text.Json.Serialization.JsonPropertyName("timeout")>]
        Timeout: Types.Duration option
    }

    type ChainInput = {
        [<System.Text.Json.Serialization.JsonPropertyName("inputs")>]
        Inputs: Map<string, WatcherTypes.InputContainer> list
    }

    and [<RequireQualifiedAccess>] InputContainer =
        | Chain of WatcherTypes.ChainInput
        | Http of WatcherTypes.HttpInput
        | Search of WatcherTypes.SearchInput
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
        Hour: Types.Integer list
        [<System.Text.Json.Serialization.JsonPropertyName("minute")>]
        Minute: Types.Integer list
    }

    /// A time of day, expressed either as `hh:mm`, `noon`, `midnight`, or an hour/minutes structure.
    [<RequireQualifiedAccess>]
    type ScheduleTimeOfDay =
        | String of string
        | HourAndMinute of WatcherTypes.HourAndMinute

    type DailySchedule = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: WatcherTypes.ScheduleTimeOfDay list
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
        Message: WatcherTypes.Email
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
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: Types.Result
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
    }

    type IndexResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: WatcherTypes.IndexResultSummary
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
        Headers: Types.HttpHeaders
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: Types.Integer
    }

    type PagerDutyResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("event")>]
        Event: WatcherTypes.PagerDutyEvent
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.HttpInputRequestResult option
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: WatcherTypes.HttpInputResponseResult option
    }

    type SlackResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("account")>]
        Account: string option
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: WatcherTypes.SlackMessage
    }

    type WebhookResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: WatcherTypes.HttpInputRequestResult
        [<System.Text.Json.Serialization.JsonPropertyName("response")>]
        Response: WatcherTypes.HttpInputResponseResult option
    }

    type ExecutionResultAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("email")>]
        Email: WatcherTypes.EmailResult option
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: WatcherTypes.IndexResult option
        [<System.Text.Json.Serialization.JsonPropertyName("logging")>]
        Logging: WatcherTypes.LoggingResult option
        [<System.Text.Json.Serialization.JsonPropertyName("pagerduty")>]
        Pagerduty: WatcherTypes.PagerDutyResult option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("slack")>]
        Slack: WatcherTypes.SlackResult option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatcherTypes.ActionStatusOptions
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: WatcherTypes.ActionType
        [<System.Text.Json.Serialization.JsonPropertyName("webhook")>]
        Webhook: WatcherTypes.WebhookResult option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
    }

    type ExecutionResultCondition = {
        [<System.Text.Json.Serialization.JsonPropertyName("met")>]
        Met: bool
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatcherTypes.ActionStatusOptions
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: WatcherTypes.ConditionType
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
        Status: WatcherTypes.ActionStatusOptions
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: WatcherTypes.InputType
    }

    type ExecutionResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: WatcherTypes.ExecutionResultAction list
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: WatcherTypes.ExecutionResultCondition
        [<System.Text.Json.Serialization.JsonPropertyName("execution_duration")>]
        ExecutionDuration: Types.DurationValue<Types.UnitMillis>
        [<System.Text.Json.Serialization.JsonPropertyName("execution_time")>]
        ExecutionTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: WatcherTypes.ExecutionResultInput
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
        MaxSize: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("queue_size")>]
        QueueSize: Types.Long
    }

    type HourlySchedule = {
        [<System.Text.Json.Serialization.JsonPropertyName("minute")>]
        Minute: Types.Integer list
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
        Actions: WatcherTypes.Actions
        [<System.Text.Json.Serialization.JsonPropertyName("last_checked")>]
        LastChecked: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("last_met_condition")>]
        LastMetCondition: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: WatcherTypes.ActivationState
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("execution_state")>]
        ExecutionState: string option
    }

    type TimeOfMonth = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: string list
        [<System.Text.Json.Serialization.JsonPropertyName("on")>]
        On: Types.Integer list
    }

    type TimeOfWeek = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: string list
        [<System.Text.Json.Serialization.JsonPropertyName("on")>]
        On: WatcherTypes.Day list
    }

    type TimeOfYear = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: string list
        [<System.Text.Json.Serialization.JsonPropertyName("int")>]
        Int: WatcherTypes.Month list
        [<System.Text.Json.Serialization.JsonPropertyName("on")>]
        On: Types.Integer list
    }

    [<RequireQualifiedAccess>]
    type ScheduleContainer =
        | Timezone of string
        | Cron of WatcherTypes.CronExpression
        | Daily of WatcherTypes.DailySchedule
        | Hourly of WatcherTypes.HourlySchedule
        | Interval of Types.Duration
        | Monthly of System.Text.Json.JsonElement
        | Weekly of System.Text.Json.JsonElement
        | Yearly of System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type TriggerContainer =
        | Schedule of WatcherTypes.ScheduleContainer

    type Watch = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Map<Types.IndexName, WatcherTypes.Action>
        [<System.Text.Json.Serialization.JsonPropertyName("condition")>]
        Condition: WatcherTypes.ConditionContainer
        [<System.Text.Json.Serialization.JsonPropertyName("input")>]
        Input: WatcherTypes.InputContainer
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: Types.Metadata option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatcherTypes.WatchStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period")>]
        ThrottlePeriod: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttle_period_in_millis")>]
        ThrottlePeriodInMillis: Types.DurationValue<Types.UnitMillis> option
        [<System.Text.Json.Serialization.JsonPropertyName("transform")>]
        Transform: Types.TransformContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("trigger")>]
        Trigger: WatcherTypes.TriggerContainer
    }

    type QueryWatch = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: WatcherTypes.WatchStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("watch")>]
        Watch: WatcherTypes.Watch option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: Types.SequenceNumber option
    }

    type ScheduleTriggerEvent = {
        [<System.Text.Json.Serialization.JsonPropertyName("scheduled_time")>]
        ScheduledTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("triggered_time")>]
        TriggeredTime: Types.DateTime option
    }

    type SimulatedActions = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: string list
        [<System.Text.Json.Serialization.JsonPropertyName("all")>]
        All: WatcherTypes.SimulatedActions
        [<System.Text.Json.Serialization.JsonPropertyName("use_all")>]
        UseAll: bool
    }

    [<RequireQualifiedAccess>]
    type TriggerEventContainer =
        | Schedule of WatcherTypes.ScheduleTriggerEvent

    type TriggerEventResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("manual")>]
        Manual: WatcherTypes.TriggerEventContainer
        [<System.Text.Json.Serialization.JsonPropertyName("triggered_time")>]
        TriggeredTime: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
    }

