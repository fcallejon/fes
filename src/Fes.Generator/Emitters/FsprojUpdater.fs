module Fes.Generator.Emitters.FsprojUpdater

open System.IO
open System.Text
open System.Text.RegularExpressions

/// Update the Fes.fsproj generated ItemGroup only, preserving everything else.
/// Looks for the marker comments <!-- GENERATED:BEGIN --> and <!-- GENERATED:END -->
/// and replaces only the content between them. If markers don't exist, appends
/// a new ItemGroup before the closing </Project> tag.
let updateFsproj (fsprojPath: string) (generatedDir: string) =
    let fsprojDir = Path.GetDirectoryName(fsprojPath)

    let generatedFiles =
        if Directory.Exists generatedDir then
            Directory.GetFiles(generatedDir, "*.g.fs", SearchOption.AllDirectories)
            |> Array.map (fun f -> Path.GetRelativePath(fsprojDir, f).Replace('\\', '/'))
            |> Array.sort
            |> Array.toList
        else
            []

    if generatedFiles.IsEmpty then
        printfn "  No generated files found, skipping fsproj update"
    else

    // Order generated files: Types → Converters → Builders → Operations (ES.g.fs last)
    let typeFiles = generatedFiles |> List.filter (fun f -> f.Contains("/Types/"))
    let converterFiles = generatedFiles |> List.filter (fun f -> f.EndsWith("Converters.g.fs"))
    let builderFiles = generatedFiles |> List.filter (fun f -> f.Contains("/Builders/"))
    let esModule = generatedFiles |> List.filter (fun f -> f.EndsWith("/ES.g.fs"))
    let otherOpFiles =
        generatedFiles
        |> List.filter (fun f ->
            f.Contains("/Operations/") && not (f.EndsWith("/ES.g.fs")))
    let orderedFiles = typeFiles @ converterFiles @ builderFiles @ otherOpFiles @ esModule

    // Build the generated ItemGroup content (includes core files that depend on generated types)
    let sb = StringBuilder()
    sb.AppendLine("    <!-- GENERATED:BEGIN — do not edit between these markers -->") |> ignore
    sb.AppendLine("    <ItemGroup>") |> ignore
    sb.AppendLine("        <!-- Generated types -->") |> ignore
    for f in typeFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("        <!-- Generated converters -->") |> ignore
    for f in converterFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("    </ItemGroup>") |> ignore
    sb.AppendLine("    <ItemGroup>") |> ignore
    sb.AppendLine("        <!-- Core library files (after types/converters, before builders) -->") |> ignore
    sb.AppendLine("        <Compile Include=\"Json.fs\"/>") |> ignore
    sb.AppendLine("        <Compile Include=\"Http.fs\"/>") |> ignore
    sb.AppendLine("        <Compile Include=\"Transport.fs\"/>") |> ignore
    sb.AppendLine("    </ItemGroup>") |> ignore
    sb.AppendLine("    <ItemGroup>") |> ignore
    sb.AppendLine("        <!-- Generated builders -->") |> ignore
    for f in builderFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("        <!-- Generated operations -->") |> ignore
    for f in otherOpFiles do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    for f in esModule do
        sb.AppendLine($"        <Compile Include=\"{f}\"/>") |> ignore
    sb.AppendLine("    </ItemGroup>") |> ignore
    sb.Append("    <!-- GENERATED:END -->") |> ignore

    let generatedBlock = sb.ToString()

    let content = File.ReadAllText(fsprojPath)

    // Try to find existing markers
    let markerPattern = Regex(@"    <!-- GENERATED:BEGIN[^>]*-->.*?<!-- GENERATED:END -->", RegexOptions.Singleline)
    let updated =
        if markerPattern.IsMatch(content) then
            // Replace the region between markers
            markerPattern.Replace(content, generatedBlock)
        else
            // No markers — insert before </Project>
            content.Replace("</Project>", generatedBlock + "\n</Project>")

    File.WriteAllText(fsprojPath, updated)
    printfn $"  Updated {fsprojPath} with {orderedFiles.Length} generated files"
