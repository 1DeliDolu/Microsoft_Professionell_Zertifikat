#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Module 1: Connecting Front-End and Back-End Components
cd "$(dirname "$0")"

MODULE_DIR="Connecting_Front-End_and_Back-End_Components"
mkdir -p "$MODULE_DIR"
cd "$MODULE_DIR"

touch 01_Course-Introduction-Full-Stack-Integration.md
touch 02_Course-Syllabus-Full-Stack-Integration.md
touch 03_Instructor-Introduction.md
touch 04_The-Whats-What-of-the-Course.md
touch 05_Completing-the-Guided-Labs.md
touch 06_Completing-the-Guided-Labs-Reading.md
touch 07_Microsoft-Tools-for-Full-Stack-Development.md
touch 08_Introducing-the-AI-Tool-Microsoft-Copilot.md
touch 09_How-to-Be-Successful-in-This-Program.md
touch 10_Introduction-to-the-Project.md

touch 11_Introduction-to-Connecting-Front-End-and-Back-End-Components.md
touch 12_Components-of-Full-Stack-Development.md
touch 13_Full-Stack-Architectural-Patterns.md
touch 14_Components-and-Architecture-in-Full-Stack-Development-Reading.md
touch 15_Practice-Quiz-Full-Stack-Development-Architecture.md

touch 16_Overview-of-Required-Tools-and-Frameworks.md
touch 17_Configuring-Development-Tools-in-VS-Code.md
touch 18_Setting-Up-a-Full-Stack-Development-Environment.md
touch 19_Guided-Lab-Setting-Up-a-Full-Stack-Development-Environment.md
touch 20_You-Try-It-Setting-Up-a-Full-Stack-Development-Environment.md
touch 21_You-Try-It-Setting-Up-a-Full-Stack-Development-Environment-Answer-Key.md
touch 22_Configuring-a-Full-Stack-Development-Environment-with-VS-Code-Reading.md
touch 23_Practice-Quiz-Setting-Up-the-Full-Stack-Development-Environment.md

touch 24_Introduction-to-RESTful-API-Design.md
touch 25_RESTful-API-Concepts-in-NET-Minimal-APIs.md
touch 26_Using-System-Text-Json-for-JSON-Serialization.md
touch 27_RESTful-API-Implementation-in-VS-Code.md
touch 28_Building-a-RESTful-API.md
touch 29_Guided-Lab-Building-a-RESTful-API.md
touch 30_You-Try-It-Building-a-RESTful-API.md
touch 31_You-Try-It-Building-a-RESTful-API-Answer-Key.md
touch 32_RESTful-APIs-Concepts-and-Implementation-Reading.md
touch 33_Practice-Quiz-Building-RESTful-APIs-for-Front-End-Integration.md

touch 34_Creating-APIs-for-Front-End-Applications.md
touch 35_Integrating-APIs-in-Blazor-Applications.md
touch 36_Consuming-APIs-in-a-Blazor-Application.md
touch 37_API-Consumption-in-a-Blazor-Based-Front-End-Application.md
touch 38_Guided-Lab-Implementing-API-Consumption-in-React.md
touch 39_You-Try-It-Implementing-API-Consumption-in-React.md
touch 40_You-Try-It-Implementing-API-Consumption-in-React-Answer-Key.md
touch 41_API-Consumption-in-Front-End-Applications-Reading.md
touch 42_Practice-Quiz-Creating-and-Consuming-APIs-in-Front-End-Applications.md

touch 43_Common-Use-Cases-for-Front-End-and-Back-End-Integration.md
touch 44_Project-Based-Examples-of-Full-Stack-Integration.md
touch 45_Activity-Analyzing-Full-Stack-Integration-in-Industry.md
touch 46_Activity-Analyzing-Full-Stack-Integration-in-Industry-Answer-Key.md
touch 47_Real-World-Full-Stack-Integration-Scenarios-Reading.md
touch 48_Practice-Quiz-Real-World-Scenarios-of-Full-Stack-Integration.md

touch 49_Graded-Quiz-Connecting-Front-End-and-Back-End-Components.md
touch 50_Conclusion-Connecting-Front-End-and-Back-End-Components.md

echo "Created simplified .md files in $(pwd)"
