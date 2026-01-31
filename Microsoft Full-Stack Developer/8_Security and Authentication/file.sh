#!/usr/bin/env bash
set -euo pipefail
# Script to create simplified .md files for Module 1: Securing APIs with ASP.NET Identity
cd "$(dirname "$0")"

MODULE_DIR="1_Securing_APIs_with_ASPNET_Identity"
mkdir -p "$MODULE_DIR"
cd "$MODULE_DIR"

touch 01_Course-Introduction-Introduction-to-Security-and-Authentication.md
touch 02_Instructor-Introduction.md
touch 03_Course-Syllabus.md
touch 04_The-Whats-What-of-the-Course.md
touch 05_Completing-the-Guided-Labs.md
touch 06_Completing-the-Guided-Labs-Reading.md
touch 07_Microsoft-Tools-for-Back-End-Development.md
touch 08_Introducing-the-AI-Tool-Microsoft-Copilot.md
touch 09_How-to-Be-Successful-in-This-Program.md
touch 10_Introduction-to-the-Project.md

touch 11_Introduction-Securing-APIs-with-ASPNET-Identity.md
touch 12_Overview-of-ASPNET-Identity.md
touch 13_Architecture-of-ASPNET-Identity.md
touch 14_Introduction-to-ASPNET-Identity-Reading.md
touch 15_Practice-Quiz-Introduction-to-ASPNET-Identity.md

touch 16_User-Registration-Process.md
touch 17_Activity-User-Registration.md
touch 18_Activity-User-Registration-Answer-Key.md
touch 19_User-Authentication-Process.md
touch 20_Implementing-User-Registration-and-Authentication.md
touch 21_Guided-Lab-Implementing-User-Registration-and-Authentication.md
touch 22_You-Try-It-Implementing-User-Registration-and-Authentication.md
touch 23_You-Try-It-Implementing-User-Registration-and-Authentication-Answer-Key.md
touch 24_User-Registration-and-Authentication-in-ASPNET-Identity-Reading.md
touch 25_Practice-Quiz-User-Registration-and-Authentication-in-ASPNET-Identity.md

touch 26_Introduction-to-User-Roles-in-ASPNET-Identity.md
touch 27_Managing-Roles-in-ASPNET-Identity-Reading.md
touch 28_Claims-Based-Authorization-in-ASPNET-Identity.md
touch 29_Managing-User-Roles-and-Claims-in-ASPNET-Identity-Reading.md
touch 30_Demonstrating-Roles-and-Claims-in-an-ASPNET-Application.md
touch 31_Managing-Roles-and-Claims-in-an-ASPNET-Application.md
touch 32_Guided-Lab-Managing-Roles-and-Claims-in-an-ASPNET-Application.md
touch 33_You-Try-It-Managing-Roles-and-Claims-in-an-ASPNET-Application.md
touch 34_You-Try-It-Managing-Roles-and-Claims-in-an-ASPNET-Application-Answer-Key.md
touch 35_Managing-Roles-and-Claims-in-ASPNET-Identity-Reading.md
touch 36_Practice-Quiz-Managing-User-Roles-and-Claims-in-ASPNET-Identity.md

touch 37_Overview-of-Token-Based-Authentication.md
touch 38_Demonstrating-Token-Based-Authentication-in-ASPNET.md
touch 39_Implementing-Token-Based-Authentication-in-an-ASPNET-Application.md
touch 40_Guided-Lab-Implementing-Token-Based-Authentication-in-an-ASPNET-Application.md
touch 41_You-Try-It-Implementing-Token-Based-Authentication-in-an-ASPNET-Application.md
touch 42_You-Try-It-Implementing-Token-Based-Authentication-in-an-ASPNET-Application-Answer-Key.md
touch 43_Implementing-Token-Based-Authentication-in-ASPNET-Identity-Reading.md
touch 44_Practice-Quiz-Token-Based-Authentication-in-ASPNET-Identity.md

touch 45_Overview-of-External-Authentication-Providers.md
touch 46_Demonstrating-Integration-of-External-Providers.md
touch 47_Integrating-External-Authentication-Providers.md
touch 48_Guided-Lab-Integrating-External-Authentication-Providers.md
touch 49_You-Try-It-Integrating-External-Authentication-Providers.md
touch 50_You-Try-It-Integrating-External-Authentication-Providers-Answer-Key.md
touch 51_Using-OAuth-2-0-and-OpenID-Connect-for-External-Authentication-Reading.md
touch 52_Practice-Quiz-Integrating-External-Authentication-Providers-with-ASPNET-Identity.md

touch 53_Graded-Quiz-Securing-APIs-with-ASPNET-Identity.md
touch 54_Conclusion-Securing-APIs-with-ASPNET-Identity.md

echo "Created simplified .md files in $(pwd)"
