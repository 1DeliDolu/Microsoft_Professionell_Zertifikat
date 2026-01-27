#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for the Microsoft Copilot (Coding & Debugging) module
cd "$(dirname "$0")"

touch 01_Capabilities-of-Microsoft-Copilot.md
touch 02_Benefits-of-Using-Microsoft-Copilot.md
touch 03_Overview-of-Microsoft-Copilot-Reading.md

touch 04_Generating-Code-With-Copilot.md
touch 05_Generating-Code-With-Copilot-Reading.md
touch 06_Guided-Lab-Practical-Coding-with-Copilot.md
touch 07_You-Try-It-Practical-Coding-With-Copilot.md

touch 08_Debugging-C-Sharp-Code-With-Microsoft-Copilot.md
touch 09_Debugging-C-Sharp-Code-With-Microsoft-Copilot-Reading.md
touch 10_Guided-Lab-Practical-Debugging-with-Copilot.md
touch 11_Debugging-C-Sharp-Code-With-Microsoft-Copilot-Dialogue.md
touch 12_You-Try-It-Practical-Debugging-With-Copilot.md

touch 13_Code-Optimization-With-Copilot.md
touch 14_Code-Optimization-With-Copilot-Reading.md
touch 15_Guided-Lab-Practical-Coding-Improvement.md
touch 16_You-Try-It-Practical-Coding-Improvement.md

touch 17_Coding-Challenge-Scenarios.md
touch 18_Guided-Lab-Practical-Coding-Exercises.md
touch 19_You-Try-It-Practical-Coding-Exercises.md

touch 20_C-Sharp-Coding-With-Microsoft-Copilot-Peer-graded-Assignment.md
touch 21_C-Sharp-Coding-With-Microsoft-Copilot-Review-Your-Peers.md
touch 22_Course-Conclusion.md

echo "Created simplified .md files in $(pwd)"
