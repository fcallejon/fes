#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
OUTPUT="$SCRIPT_DIR/elasticsearch-schema.json"

# Pin to a specific commit for reproducibility.
# Update this SHA when upgrading to a newer schema version.
COMMIT="620149e0683f191cacc268f74620f4fa50ed1b57"
SCHEMA_URL="https://raw.githubusercontent.com/elastic/elasticsearch-specification/${COMMIT}/output/schema/schema.json"

echo "Downloading schema.json from elasticsearch-specification (commit: ${COMMIT:0:12}...)..."
curl -sL -o "$OUTPUT" "$SCHEMA_URL"
echo "$COMMIT" > "$SCRIPT_DIR/schema.commit"
echo "Saved to $OUTPUT ($(wc -c < "$OUTPUT" | tr -d ' ') bytes)"
echo "Commit SHA recorded in $SCRIPT_DIR/schema.commit"
