module Fes.Generator.Emitters.FSharpWriter

open System
open System.Text

type Writer() =
    let sb = StringBuilder()
    let mutable indentLevel = 0
    let indentStr () = String(' ', indentLevel * 4)

    member _.Indent() = indentLevel <- indentLevel + 1
    member _.Dedent() = indentLevel <- max 0 (indentLevel - 1)
    member _.IndentLevel = indentLevel

    member _.Line (text: string) =
        if String.IsNullOrEmpty text then
            sb.AppendLine() |> ignore
        else
            sb.Append(indentStr()).AppendLine(text) |> ignore

    member this.Lines (lines: string list) =
        for line in lines do
            this.Line line

    member _.Append (text: string) =
        sb.Append(text) |> ignore

    member this.BlankLine() = this.Line ""

    member this.Header() =
        this.Line "// Auto-generated from Elasticsearch schema.json — do not edit manually"
        this.BlankLine()

    member this.Namespace (ns: string) =
        this.Line $"namespace {ns}"
        this.BlankLine()

    member this.Open (moduleName: string) =
        this.Line $"open {moduleName}"

    member this.Module (name: string) =
        this.Line $"module {name} ="
        this.BlankLine()
        this.Indent()

    member this.AutoOpenModule (name: string) =
        this.Line "[<AutoOpen>]"
        this.Line $"module {name} ="
        this.BlankLine()
        this.Indent()

    member this.RequireQualifiedAccessModule (name: string) =
        this.Line "[<RequireQualifiedAccess>]"
        this.Line $"module {name} ="
        this.BlankLine()
        this.Indent()

    member this.Attribute (attr: string) =
        this.Line $"[<{attr}>]"

    member this.DocComment (text: string option) =
        match text with
        | Some desc when not (String.IsNullOrWhiteSpace desc) ->
            let escaped = desc.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;")
            // Take only the first line, truncated
            let firstLine =
                let idx = escaped.IndexOfAny([| '\n'; '\r' |])
                if idx >= 0 then escaped.Substring(0, idx)
                else escaped
            let truncated =
                if firstLine.Length > 200 then firstLine.Substring(0, 200) + "..."
                else firstLine
            this.Line $"/// {truncated}"
        | _ -> ()

    member this.TypeKeyword (isFirst: bool) =
        if isFirst then "type" else "and"

    override _.ToString() = sb.ToString()
