#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for the Asynchronous Programming module
cd "$(dirname "$0")"

touch 01_Introduction-Asynchronous-Programming.md
touch 02_Fundamentals-of-Asynchronous-Programming.md
touch 03_Benefits-and-Challenges-of-Asynchronous-Programming.md
touch 04_Introduction-to-Asynchronous-Programming-Reading.md
touch 05_Practice-Quiz-Introduction-to-Asynchronous-Programming.md
touch 06_Syntax-and-Usage-of-Async-and-Await.md
touch 07_Syntax-and-Usage-of-Async-and-Await-Reading.md
touch 08_Practical-Implementation.md
touch 09_Using-Async-and-Await-in-C-Sharp.md
touch 10_Guided-Lab-Using-Async-and-Await-in-C-Sharp.md
touch 11_You-Try-It-Using-Async-and-Await-in-C-Sharp.md
touch 12_You-Try-It-Using-Async-and-Await-in-C-Sharp-Answer-Key.md
touch 13_Practice-Quiz-Using-Async-and-Await-in-C-Sharp.md

touch 14_Designing-Asynchronous-Solutions.md
touch 15_Using-Practical-Asynchronous-Programming-Solutions.md
touch 16_Creating-Practical-Asynchronous-Solutions-Reading.md
touch 17_Activity-Creating-Practical-Asynchronous-Solutions.md
touch 18_Activity-Creating-Practical-Asynchronous-Solutions-Answer-Key.md
touch 19_Creating-Practical-Asynchronous-Solutions-Dialogue.md
touch 20_Practice-Quiz-Creating-Practical-Asynchronous-Solutions.md

touch 21_Role-in-Modern-Applications.md
touch 22_Industry-Examples.md
touch 23_Significance-of-Asynchronous-Programming-Reading.md
touch 24_Practice-Quiz-Significance-of-Asynchronous-Programming.md

touch 25_Debugging-Asynchronous-Code.md
touch 26_Debugging-and-Creating-Asynchronous-Programs-Reading.md
touch 27_Debugging-and-Creating-Asynchronous-Programs.md
touch 28_Guided-Lab-Debugging-and-Creating-Asynchronous-Programs.md
touch 29_You-Try-It-Debugging-and-Creating-Asynchronous-Programs.md
touch 30_You-Try-It-Debugging-and-Creating-Asynchronous-Programs-Answer-Key.md
touch 31_Practice-Quiz-Debugging-and-Creating-Asynchronous-Programs.md

touch 32_Graded-Quiz-Asynchronous-Programming-in-C-Sharp.md
touch 33_Conclusion-Asynchronous-Programming.md

echo "Created simplified .md files in $(pwd)"
