#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Module 1: HTML for Web Development
cd "$(dirname "$0")"

MODULE_DIR="HTML_for_Web_Development"
mkdir -p "$MODULE_DIR"
cd "$MODULE_DIR"

touch 01_Course-Introduction-Introduction-to-Web-Development.md
touch 02_Instructor-Introduction.md
touch 03_Introduction-to-Web-Development-Course-Syllabus.md
touch 04_The-Whats-What-of-the-Course.md
touch 05_Completing-the-Guided-Labs.md
touch 06_Completing-the-Guided-Labs-Reading.md
touch 07_Microsoft-Tools-for-Front-End-Development.md
touch 08_Introducing-the-AI-Tool-Microsoft-Copilot.md
touch 09_How-to-Be-Successful-in-This-Program.md

touch 10_Introduction-to-the-Project.md
touch 11_Introduction-to-HTML.md
touch 12_HTML-Elements-and-Tags.md
touch 13_HTML-Attributes.md
touch 14_HTML-Document-Structure-and-Hierarchy.md
touch 15_HTML-Structure-and-Elements-Reading.md
touch 16_Introduction-to-HTML-Dialogue.md
touch 17_Practice-Quiz-Introduction-to-HTML.md
touch 18_HTML-as-the-Foundation-of-Web-Content.md
touch 19_Interaction-Between-HTML-and-CSS.md
touch 20_Interaction-Between-HTML-and-JavaScript.md

touch 21_HTML-in-Web-Development-Reading.md
touch 22_Practice-Quiz-The-Role-of-HTML-in-Web-Development.md
touch 23_Understanding-Semantic-HTML.md
touch 24_Semantic-HTML-and-Accessibility.md
touch 25_Implementing-Semantic-HTML-in-Web-Development.md
touch 26_Semantic-HTML-Reading.md
touch 27_The-Importance-of-Semantic-HTML-Dialogue.md
touch 28_Practice-Quiz-The-Importance-of-Semantic-HTML.md
touch 29_Structuring-an-HTML-Document.md
touch 30_Working-with-Forms-Tables-and-Lists.md

touch 31_Integrating-Media-Elements.md
touch 32_Building-an-HTML-Document-Reading.md
touch 33_Building-an-HTML-Document.md
touch 34_Guided-Lab-Building-an-HTML-Document.md
touch 35_You-Try-It-Building-an-HTML-Document-Lab.md
touch 36_You-Try-It-Building-an-HTML-Document-Answer-Key.md
touch 37_Practice-Quiz-Building-Your-First-HTML-Document.md
touch 38_Structuring-the-Web-Page.md
touch 39_Incorporating-Text-Lists-and-Links.md
touch 40_HTML-Page-Walk-Through.md

touch 41_Constructing-a-Complete-Web-Page-with-HTML-Reading.md
touch 42_Create-a-Web-Page-with-HTML.md
touch 43_Guided-Lab-Create-a-Web-Page-with-HTML.md
touch 44_You-Try-It-Create-a-Web-Page-with-HTML-Lab.md
touch 45_You-Try-It-Create-a-Web-Page-with-HTML-Answer-Key.md
touch 46_Practice-Quiz-Constructing-a-Complete-Web-Page-with-HTML.md
touch 47_Graded-Quiz-HTML-for-Web-Development.md
touch 48_Conclusion-HTML-for-Web-Development.md

echo "Created simplified .md files in $(pwd)"
