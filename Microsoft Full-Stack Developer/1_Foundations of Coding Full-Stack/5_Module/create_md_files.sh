#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for the Functions, Methods, and Scope module (Module 5)
cd "$(dirname "$0")"

touch 34_Comprehensive-Program-Development.md
touch 35_Developing-Programs-With-Functions-and-Methods-Reading.md
touch 36_Developing-Programs-With-Functions-and-Methods.md
touch 37_Guided-Lab-Developing-Programs-With-Functions-and-Methods.md
touch 38_Practice-Quiz-Developing-Programs-With-Functions-and-Methods.md
touch 39_Graded-Quiz-Functions-Methods-and-Scope.md
touch 40_Conclusion-Functions-Methods-and-Scope.md

echo "Created simplified .md files in $(pwd)"
