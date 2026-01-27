#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for: CSS for Web Development
cd "$(dirname "$0")"

MODULE_DIR="CSS_for_Web_Development"
mkdir -p "$MODULE_DIR"
cd "$MODULE_DIR"

touch 01_Introduction-to-CSS-for-Web-Development.md
touch 02_CSS-Syntax-and-Structure.md
touch 03_Applying-CSS-to-HTML-Documents.md
touch 04_The-CSS-Box-Model.md
touch 05_CSS-Reading.md
touch 06_Introduction-to-CSS-Dialogue.md
touch 07_Practice-Quiz-Introduction-to-CSS.md
touch 08_Responsive-Web-Design-Principles.md
touch 09_Media-Queries.md
touch 10_Techniques-for-Creating-Flexible-Layouts.md

touch 11_Web-Design-with-CSS-Dialogue.md
touch 12_Practice-Quiz-Web-Design-with-CSS.md
touch 13_Introduction-to-Enhancing-Web-Accessibility-with-CSS.md
touch 14_Using-CSS-to-Enhance-Accessibility.md
touch 15_Best-Practices-for-Accessible-Design.md
touch 16_Web-Accessibility-Reading.md
touch 17_Enhancing-Web-Accessibility-with-CSS-Dialogue.md
touch 18_Practice-Quiz-Enhancing-Web-Accessibility-with-CSS.md
touch 19_Flexbox-for-Responsive-Layouts.md
touch 20_CSS-Grid-for-Complex-Layouts.md

touch 21_CSS-Animations-and-Transitions.md
touch 22_CSS-Techniques-for-Web-Design-Reading.md
touch 23_Advanced-CSS-Techniques-for-Web-Design-Dialogue.md
touch 24_Practice-Quiz-Advanced-CSS-Techniques-for-Web-Design.md
touch 25_Planning-a-Responsive-Web-Design.md
touch 26_Implementing-Flexbox-for-Responsive-Layouts.md
touch 27_Creating-a-Responsive-Web-Page-with-Advanced-CSS-Techniques-Reading.md
touch 28_Creating-a-Responsive-Web-Page-with-Advanced-CSS-Techniques.md
touch 29_Guided-Lab-Creating-a-Responsive-Web-Page-with-Advanced-CSS-Techniques.md
touch 30_You-Try-It-Creating-a-Responsive-Web-Page-with-Advanced-CSS-Techniques-Answer-Key.md
touch 31_Advanced-CSS-Techniques-for-Web-Design-Dialogue.md
touch 32_Practice-Quiz-Creating-a-Responsive-Web-Page-with-Advanced-CSS-Techniques.md
touch 33_Graded-Quiz-CSS-for-Web-Development.md
touch 34_Conclusion-CSS-for-Web-Development.md

echo "Created simplified .md files in $(pwd)"
