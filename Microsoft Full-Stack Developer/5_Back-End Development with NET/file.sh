#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Module 5: Using Microsoft Copilot for Developing APIs
cd "$(dirname "$0")"

MODULE_DIR="5_Using_Microsoft_Copilot_for_Developing_APIs"
mkdir -p "$MODULE_DIR"
cd "$MODULE_DIR"

touch 01_Introduction-to-Microsoft-Copilot.md
touch 02_Benefits-of-Using-Copilot.md
touch 03_Overview-of-Microsoft-Copilot-Reading.md
touch 04_Generating-Code-Snippets-with-Copilot.md
touch 05_Enhancing-Existing-API-Code.md
touch 06_Activity-1-Writing-and-Enhancing-API-Code-with-Copilot.md
touch 07_Identifying-Bugs-with-Copilot.md
touch 08_Copilot-Assisted-Debugging-Techniques.md
touch 09_Advanced-Debugging-with-Copilot.md
touch 10_Activity-2-Debugging-API-Code-with-Copilot.md

touch 11_Implementing-Middleware-Components.md
touch 12_Managing-Middleware-Pipeline.md
touch 13_Comprehensive-Middleware-Management.md
touch 14_Activity-Implementing-and-Managing-Middleware-with-Copilot.md

touch 15_Project-Building-a-Simple-API-with-Copilot.md
touch 16_Project-Building-a-Simple-API-with-Copilot-Review-Your-Peers.md
touch 17_Course-Conclusion.md

echo "Created simplified .md files in $(pwd)"
