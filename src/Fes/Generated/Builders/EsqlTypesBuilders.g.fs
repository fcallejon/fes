// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module EsqlTypesBuilders =

    type AsyncEsqlResultBuilder() =
        member _.Yield(_: unit) : Types.AsyncEsqlResult =
            {
                Id = None
                IsRunning = Unchecked.defaultof<_>
                Took = None
                IsPartial = None
                AllColumns = None
                Columns = Unchecked.defaultof<_>
                Values = Unchecked.defaultof<_>
                Clusters = None
                Profile = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.AsyncEsqlResult, value: string) =
            { state with Id = Some value }

        [<CustomOperation("isRunning")>]
        member _.IsRunning(state: Types.AsyncEsqlResult, value: bool) =
            { state with IsRunning = value }

        [<CustomOperation("took")>]
        member _.Took(state: Types.AsyncEsqlResult, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: Types.AsyncEsqlResult, value: bool) =
            { state with IsPartial = Some value }

        [<CustomOperation("allColumns")>]
        member _.AllColumns(state: Types.AsyncEsqlResult, value: Types.EsqlColumnInfo list) =
            { state with AllColumns = Some value }

        [<CustomOperation("columns")>]
        member _.Columns(state: Types.AsyncEsqlResult, value: Types.EsqlColumnInfo list) =
            { state with Columns = value }

        [<CustomOperation("values")>]
        member _.Values(state: Types.AsyncEsqlResult, value: Types.FieldValue list list) =
            { state with Values = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: Types.AsyncEsqlResult, value: Types.EsqlClusterInfo) =
            { state with Clusters = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: Types.AsyncEsqlResult, value: System.Text.Json.JsonElement) =
            { state with Profile = Some value }

    let asyncEsqlResult = AsyncEsqlResultBuilder()

    type EsqlClusterDetailsBuilder() =
        member _.Yield(_: unit) : Types.EsqlClusterDetails =
            {
                Status = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                Took = None
                Shards = None
                Failures = None
            }

        [<CustomOperation("status")>]
        member _.Status(state: Types.EsqlClusterDetails, value: Types.EsqlClusterStatus) =
            { state with Status = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.EsqlClusterDetails, value: string) =
            { state with Indices = value }

        [<CustomOperation("took")>]
        member _.Took(state: Types.EsqlClusterDetails, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.EsqlClusterDetails, value: Types.EsqlShardInfo) =
            { state with Shards = Some value }

        [<CustomOperation("failures")>]
        member _.Failures(state: Types.EsqlClusterDetails, value: Types.EsqlShardFailure list) =
            { state with Failures = Some value }

    let esqlClusterDetails = EsqlClusterDetailsBuilder()

    type EsqlResultBuilder() =
        member _.Yield(_: unit) : Types.EsqlResult =
            {
                Took = None
                IsPartial = None
                AllColumns = None
                Columns = Unchecked.defaultof<_>
                Values = Unchecked.defaultof<_>
                Clusters = None
                Profile = None
            }

        [<CustomOperation("took")>]
        member _.Took(state: Types.EsqlResult, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: Types.EsqlResult, value: bool) =
            { state with IsPartial = Some value }

        [<CustomOperation("allColumns")>]
        member _.AllColumns(state: Types.EsqlResult, value: Types.EsqlColumnInfo list) =
            { state with AllColumns = Some value }

        [<CustomOperation("columns")>]
        member _.Columns(state: Types.EsqlResult, value: Types.EsqlColumnInfo list) =
            { state with Columns = value }

        [<CustomOperation("values")>]
        member _.Values(state: Types.EsqlResult, value: Types.FieldValue list list) =
            { state with Values = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: Types.EsqlResult, value: Types.EsqlClusterInfo) =
            { state with Clusters = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: Types.EsqlResult, value: System.Text.Json.JsonElement) =
            { state with Profile = Some value }

    let esqlResult = EsqlResultBuilder()

    type EsqlShardInfoBuilder() =
        member _.Yield(_: unit) : Types.EsqlShardInfo =
            {
                Total = Unchecked.defaultof<_>
                Successful = None
                Skipped = None
                Failed = None
            }

        [<CustomOperation("total")>]
        member _.Total(state: Types.EsqlShardInfo, value: Types.Integer) =
            { state with Total = value }

        [<CustomOperation("successful")>]
        member _.Successful(state: Types.EsqlShardInfo, value: Types.Integer) =
            { state with Successful = Some value }

        [<CustomOperation("skipped")>]
        member _.Skipped(state: Types.EsqlShardInfo, value: Types.Integer) =
            { state with Skipped = Some value }

        [<CustomOperation("failed")>]
        member _.Failed(state: Types.EsqlShardInfo, value: Types.Integer) =
            { state with Failed = Some value }

    let esqlShardInfo = EsqlShardInfoBuilder()

    module TableValues =

        let integer (value: Types.TableValuesIntegerValue list) =
            Types.TableValuesContainer.Integer value

        let keyword (value: Types.TableValuesKeywordValue list) =
            Types.TableValuesContainer.Keyword value

        let long (value: Types.TableValuesLongValue list) =
            Types.TableValuesContainer.Long value

        let double (value: Types.TableValuesLongDouble list) =
            Types.TableValuesContainer.Double value

