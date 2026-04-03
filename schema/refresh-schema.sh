#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
SCHEMA_URL="https://raw.githubusercontent.com/elastic/elasticsearch-specification/main/output/schema/schema.json"
OUTPUT="$SCRIPT_DIR/elasticsearch-schema.json"

echo "Downloading schema.json from elasticsearch-specification..."
curl -sL -o "$OUTPUT" "$SCHEMA_URL"
echo "Saved to $OUTPUT ($(wc -c < "$OUTPUT" | tr -d ' ') bytes)"
