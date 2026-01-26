#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Integrated Coding Practice, Debugging, Copilot, and Project
cd "$(dirname "$0")"

touch 01_Integrated-Coding-Practice.md
touch 02_Real-World-Problem-Solving.md
touch 03_Code-Review-and-Refinement.md
touch 04_Activity-Practical-Application-of-Coding-Concepts.md
touch 05_Activity-Practical-Application-of-Coding-Concepts-Answer-Key.md
touch 06_Introduction-to-Debugging.md
touch 07_Debugging-Techniques.md
touch 08_Debugging-Techniques-and-Practice-Reading.md
touch 09_Activity-Debugging.md
touch 10_Activity-Debugging-Answer-Key.md
touch 11_Introduction-to-Microsoft-Copilot.md
touch 12_Microsoft-Copilot-for-Debugging-and-Logic-Error.md
touch 13_Practical-Copilot-Integration.md
touch 14_Activity-Advanced-Debugging-With-Microsoft-Copilot.md
touch 15_Project-Planning-and-Design.md
touch 16_Project-Implementation.md
touch 17_Project-Submission-Peer-graded-Assignment.md
touch 18_Project-Submission-Review-Your-Peers.md
touch 19_Course-Conclusion-Foundations-of-Coding-Full-Stack.md

echo "Created simplified .md files in $(pwd)"

