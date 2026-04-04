# FEs

FEs is an F# client for Elasticsearch, built on top of [`Elastic.Transport`](https://github.com/elastic/elastic-transport-net).

It generates a full typed DSL from the official Elasticsearch schema — every API endpoint, type, and CE (computation expression) builder is derived directly from `schema/elasticsearch-schema.json`.

---

## Quick start

```fsharp
open Fes
open Fes.Generated
open Fes.Generated.Operations

// Connect
let t = ES.connect "http://localhost:9200"

// Create an index
let req = indicesCreateRequest { index "products" }
let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
```

---

## Index mappings — `Mapping` module

Use `Mapping.mapping` to build a `TypeMapping` without manually wrapping every field in the `Property` DU:

```fsharp
let req = indicesCreateRequest {
    index "products"
    mappings (Mapping.mapping [
        Mapping.text    "title"      { Types.TextProperty.empty    with Analyzer = Some "my_search" }
        Mapping.keyword "category"   Types.KeywordProperty.empty
        Mapping.float'  "price"      Types.FloatNumberProperty.empty
        Mapping.boolean "in_stock"   Types.BooleanProperty.empty
        Mapping.integer "quantity"   Types.IntegerNumberProperty.empty
        Mapping.date    "created_at" Types.DateProperty.empty
    ])
}
```

### Multi-fields (`withFields`)

Attach sub-fields to any property with `Mapping.withFields`:

```fsharp
Mapping.mapping [
    Mapping.text "title" Types.TextProperty.empty
    |> Mapping.withFields [
        Mapping.keyword "keyword" Types.KeywordProperty.empty
    ]
]
// → "title": { "type": "text", "fields": { "keyword": { "type": "keyword" } } }
```

Available field helpers: `text`, `keyword`, `boolean`, `float'`, `double'`, `integer`, `long`, `short`, `byte'`, `halfFloat`, `scaledFloat`, `unsignedLong`, `date`, `dateNanos`, `nested`, `object'`, `geoPoint`, `geoShape`, `ip`, `completion`, `binary`, `tokenCount`, `denseVector`, `alias`, `constantKeyword`, `flattened`, `searchAsYouType`, `wildcard`, `integerRange`, `floatRange`, `longRange`, `doubleRange`, `dateRange`, `ipRange`.

---

## Index analysis — `Analysis` module

Use `Analysis.analysis` to build `IndexSettingsAnalysis` from a mixed list of named components, then wire it into index settings:

```fsharp
let myAnalysis = Analysis.analysis [
    // Built-in analyzer with config
    Analysis.withStandard "default" Types.StandardAnalyzer.empty

    // Custom analyzer referencing named filter/tokenizer
    Analysis.withCustom "my_search" (customAnalyzer {
        tokenizer "standard"
        filter    [ "lowercase"; "my_edge" ]
    })

    // Edge-NGram token filter
    Analysis.withEdgeNGramFilter "my_edge" (edgeNGramTokenFilter {
        minGram 1
        maxGram 20
    })

    // HTML-strip char filter
    Analysis.withHtmlStripCharFilter "html_strip" Types.HtmlStripCharFilter.empty
]

let req = indicesCreateRequest {
    index "products"
    settings (indexSettings {
        analysis myAnalysis
    })
    mappings (Mapping.mapping [
        Mapping.text "title" { Types.TextProperty.empty with Analyzer = Some "my_search" }
    ])
}
```

### Supported `Analysis.with*` helpers

| Category | Helpers |
|---|---|
| Custom | `withCustom` |
| General | `withStandard`, `withSimple`, `withStop`, `withWhitespace`, `withKeyword`, `withPattern`, `withFingerprint`, `withSnowball` |
| Plugin | `withIcu`, `withKuromoji`, `withNori` |
| Language | `withArabic`, `withArmenian`, `withBasque`, `withBengali`, `withBrazilian`, `withBulgarian`, `withCatalan`, `withChinese`, `withCjk`, `withCzech`, `withDanish`, `withDutch`, `withEnglish`, `withEstonian`, `withFinnish`, `withFrench`, `withGalician`, `withGerman`, `withGreek`, `withHindi`, `withHungarian`, `withIndonesian`, `withIrish`, `withItalian`, `withLatvian`, `withLithuanian`, `withNorwegian`, `withPersian`, `withPortuguese`, `withRomanian`, `withRussian`, `withSerbian`, `withSorani`, `withSpanish`, `withSwedish`, `withThai`, `withTurkish` |
| Token filters | `withEdgeNGramFilter`, `withNGramFilter`, `withStopFilter`, `withSynonymFilter`, `withSynonymGraphFilter`, `withStemmerFilter`, `withPatternReplaceFilter`, `withShingleFilter`, `withLengthFilter`, `withLimitTokenCountFilter`, `withTruncateFilter`, `withHunspellFilter`, `withIcuCollationFilter`, `withKuromojiReadingFormFilter`, `withFilter` (generic) |
| Char filters | `withHtmlStripCharFilter`, `withMappingCharFilter`, `withPatternReplaceCharFilter`, `withIcuNormalizationCharFilter`, `withCharFilter` (generic) |
| Tokenizers | `withEdgeNGramTokenizer`, `withNGramTokenizer`, `withPatternTokenizer`, `withStandardTokenizer`, `withWhitespaceTokenizer`, `withNoriTokenizer`, `withKuromojiTokenizer`, `withTokenizer` (generic) |
| Normalizers | `withCustomNormalizer`, `withLowercaseNormalizer`, `withNormalizer` (generic) |

---

## Indexing documents

```fsharp
let doc = {| title = "Laptop"; price = 999.99; inStock = true |}

let req = indexRequest {
    index "products"
    id    "prod-1"
    document doc
    refresh Types.Refresh.WaitFor
}

let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
```

---

## Search

```fsharp
// Simple match query
let req = searchRequest {
    index (Types.Indices.IndexName "products")
    query (Query.match' "title" (matchQuery { query (jsonEl "\"Laptop\"") }))
}

// Bool query
let req = searchRequest {
    index (Types.Indices.IndexName "products")
    query (Types.QueryContainer.Bool {
        Types.BoolQuery.empty with
            Must   = Some [ Query.match' "title" (matchQuery { query (jsonEl "\"Laptop\"") }) ]
            Filter = Some [ Query.term "category" "electronics" ]
    })
}

let result : TaskResult<System.Text.Json.JsonElement, exn> = ES.sendAsync t req
```

---

## CE builders

Every generated type with ≥ 2 optional fields gets a computation expression builder.  
The builder instance name is the camelCase type name (e.g. `indicesCreateRequest { ... }`, `customAnalyzer { ... }`, `edgeNGramTokenFilter { ... }`).

---

## Code generation

All types, converters, CE builders, and operation wrappers under `src/Fes/Generated/` are produced from `schema/elasticsearch-schema.json` by the generator in `src/Fes.Generator/`.

Re-generate after schema or generator changes:

```bash
dotnet run --project src/Fes.Generator
# Also regenerate test stubs:
dotnet run --project src/Fes.Generator -- --test-output tests/Fes.Tests
```

Key generator features:
- **Inheritance flattening** — inherited properties (`fields`, `copy_to`, `boost`, `_name`, …) are included in derived types.
- **`T | T[]` union resolution** — schema unions like `string | string[]` become `string list` instead of `JsonElement`.

---

## Building and testing

```bash
dotnet build
dotnet test                                      # all tests (integration requires ES on localhost:9200)
dotnet test --filter "Category!=Integration"     # unit + generated tests only
```

---

## Road map

- [x] Generated typed DSL from Elasticsearch schema
- [x] CE builders for all record types
- [x] `Mapping` convenience module
- [x] `Analysis` module (`with[Analyzer]`, `with[Filter]`, …)
- [x] Multi-fields (`Mapping.withFields`)
- [x] Generator: inheritance flattening
- [x] Generator: typed union resolution (`T | T[]` → `T list`)
- [ ] NuGet package
- [ ] Retry / resilience support
- [ ] Streaming / async-seq responses

---

## Contributing

Weekend project — contributions welcome! Good places to start:

- Adding or fixing integration tests
- Improving the generator (more union patterns, better `empty` defaults)
- Resilience / retry support
- NuGet packaging
