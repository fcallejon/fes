// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlGetCalendars =

    type Calendar = {
        [<System.Text.Json.Serialization.JsonPropertyName("calendar_id")>]
        CalendarId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("job_ids")>]
        JobIds: Types.Id list
    }

