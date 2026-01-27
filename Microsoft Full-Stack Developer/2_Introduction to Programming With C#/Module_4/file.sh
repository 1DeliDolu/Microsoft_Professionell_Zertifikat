#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for the Mastering Object-Oriented Programming in C# module
cd "$(dirname "$0")"

touch 01_Fundamental-Concepts-of-Objects-and-Classes.md
touch 02_Theoretical-Understanding-of-OOP-Principles.md
touch 03_Objects-and-Classes-Reading.md
touch 04_Practice-Quiz-Objects-and-Classes.md

touch 05_Inheritance.md
touch 06_Polymorphism.md
touch 07_Inheritance-and-Polymorphism-Reading.md
touch 08_Practice-Quiz-Inheritance-and-Polymorphism.md
touch 09_Coding-Inheritance-in-C-Sharp.md
touch 10_Coding-Polymorphism-in-C-Sharp.md
touch 11_Guided-Lab-Inheritance-and-Polymorphism-in-C-Sharp.md
touch 12_You-Try-It-Inheritance-and-Polymorphism-in-C-Sharp.md
touch 13_You-Try-It-Inheritance-and-Polymorphism-in-C-Sharp-Answer-Key.md
touch 14_Practice-Quiz-Practical-Implementation-of-Inheritance-and-Polymorphism.md

touch 15_Design-Patterns.md
touch 16_Identifying-Design-Patterns.md
touch 17_Recognizing-Design-Patterns-Reading.md
touch 18_Activity-Recognizing-Design-Patterns.md
touch 19_Activity-Recognizing-Design-Patterns-Answer-Key.md
touch 20_Recognizing-Design-Patterns-Dialogue.md
touch 21_Practice-Quiz-Recognizing-Design-Patterns.md

touch 22_Creating-Classes-and-Objects.md
touch 23_Implementation-of-Classes-and-Objects-Reading.md
touch 24_Implementing-Classes-and-Objects.md
touch 25_Guided-Lab-Implementing-Classes-and-Objects.md
touch 26_You-Try-It-Implementing-Classes-and-Objects.md
touch 27_You-Try-It-Implementing-Classes-and-Objects-Answer-Key.md
touch 28_Practice-Quiz-Implementation-of-Classes-and-Objects.md

touch 29_Graded-Quiz-Mastering-Object-Oriented-Programming-in-C-Sharp.md
touch 30_Conclusion-Mastering-Object-Oriented-Programming-in-C-Sharp.md

echo "Created simplified .md files in $(pwd)"
