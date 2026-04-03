// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module LogstashTypes =

    type PipelineMetadata = {
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: string
    }

    type PipelineSettings = {
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline.workers")>]
        PipelineWorkers: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline.batch.size")>]
        PipelineBatchSize: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline.batch.delay")>]
        PipelineBatchDelay: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("queue.type")>]
        QueueType: string
        [<System.Text.Json.Serialization.JsonPropertyName("queue.max_bytes")>]
        QueueMaxBytes: string
        [<System.Text.Json.Serialization.JsonPropertyName("queue.checkpoint.writes")>]
        QueueCheckpointWrites: Types.Integer
    }

    type Pipeline = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("last_modified")>]
        LastModified: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline_metadata")>]
        PipelineMetadata: LogstashTypes.PipelineMetadata
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline_settings")>]
        PipelineSettings: LogstashTypes.PipelineSettings
        [<System.Text.Json.Serialization.JsonPropertyName("username")>]
        Username: string
    }

