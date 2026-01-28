#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Module 4: Using Microsoft Copilot for Generating SQL Queries and Database Operations
cd "$(dirname "$0")"

MODULE_DIR="4_Using_Microsoft_Copilot_for_Generating_SQL_Queries_and_Database_Operations"
mkdir -p "$MODULE_DIR"
cd "$MODULE_DIR"

touch 01_Introduction-Writing-SQL-Queries-with-Microsoft-Copilot.md
touch 02_Introduction-to-Microsoft-Copilot-for-SQL-Query-Writing.md
touch 03_Writing-SQL-Queries-with-Microsoft-Copilot-Reading.md
touch 04_Activity-Writing-Basic-SQL-Queries-with-Microsoft-Copilot.md
touch 05_Advanced-SQL-Query-Capabilities-of-Microsoft-Copilot.md
touch 06_Activity-Creating-Complex-SQL-Queries-with-Microsoft-Copilot.md

touch 07_Introduction-to-SQL-Query-Debugging-and-Optimization-with-Microsoft-Copilot.md
touch 08_Activity-3-Debugging-and-Optimizing-SQL-Queries-with-Microsoft-Copilot.md

touch 09_Capstone-Project-Overview-and-Requirements.md
touch 10_Capstone-Project-Overview-and-Requirements-Review-Your-Peers.md
touch 11_Course-Conclusion-Database-Integration-and-Management.md

echo "Created simplified .md files in $(pwd)"
