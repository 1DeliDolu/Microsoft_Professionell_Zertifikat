#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Module 2: Applying Programming Foundations
cd "$(dirname "$0")"

touch 01_Introduction-Applying-Programming-Foundations.md
touch 02_Fundamental-Programming-Concepts.md
touch 03_Methods-and-Pseudocode.md
touch 04_Reviewing-Essential-Programming-Concepts-Reading.md
touch 05_Practice-Quiz-Reviewing-Essential-Programming-Concepts.md
touch 06_Logical-Thinking-Skills.md
touch 07_Application-of-Logical-Thinking.md
touch 08_Logical-Thinking-in-Programming-Reading.md
touch 09_Logical-Thinking-in-Programming-Dialogue.md
touch 10_Practice-Quiz-Logical-Thinking-in-Programming.md

touch 11_Debugging-Fundamentals.md
touch 12_Practical-Debugging.md
touch 13_Debugging-Reading.md
touch 14_Activity-Debugging-Code.md
touch 15_Activity-Debugging-Code-Answer-Key.md
touch 16_Practice-Quiz-Introduction-to-Debugging.md

touch 17_Basic-C-Sharp-Syntax.md
touch 18_Practical-Programming.md
touch 19_Basic-C-Sharp-Syntax-Reading.md
touch 20_Writing-Simple-Programs-in-C-Sharp.md
touch 21_Guided-Lab-Writing-Simple-Programs-in-C-Sharp.md
touch 22_You-Try-It-Writing-Simple-Programs-in-C-Sharp.md
touch 23_You-Try-It-Writing-Simple-Programs-in-C-Sharp-Answer-Key.md
touch 24_Practice-Quiz-Writing-Simple-Programs-in-C-Sharp.md

touch 25_Create-a-Small-Project-and-Debug-a-Program.md
touch 26_Guided-Lab-Create-a-Small-Project-and-Debug-a-Program.md
touch 27_You-Try-It-Create-a-Small-Project-and-Debug-a-Program.md
touch 28_You-Try-It-Create-a-Small-Project-and-Debug-a-Program-Answer-Key.md

touch 29_Graded-Quiz-Applying-Programming-Foundations.md
touch 30_Conclusion-Applying-Programming-Foundations.md

echo "Created simplified .md files in $(pwd)"
