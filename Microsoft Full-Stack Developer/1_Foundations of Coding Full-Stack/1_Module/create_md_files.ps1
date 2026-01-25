# PowerShell script to create simplified .md files for Module 1
Set-StrictMode -Version Latest
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $scriptDir

$files = @(
    '01_Introduction-to-the-Program.md',
    '02_Course-Introduction-Foundations-of-Coding-Full-Stack.md',
    '03_Instructor-Introduction.md',
    '04_Course-Syllabus.md',
    '05_The-Whats-What-of-the-Course.md',
    '06_Completing-the-Guided-Labs.md',
    '07_Completing-the-Guided-Labs-Reading.md',
    '08_Microsoft-Tools-for-Full-Stack-Development.md',
    '09_Introducing-the-AI-Tool-Microsoft-Copilot.md',
    '10_How-to-Be-Successful-in-This-Program.md',
    '11_Introduction-to-the-Project.md',
    '12_Introduction-to-Full-Stack-Development.md',
    '13_Full-Stack-Development.md',
    '14_Full-Stack-Development-Best-Practices.md',
    '15_Full-Stack-Development-Reading.md',
    '16_Practice-Quiz-Introduction-to-Full-Stack-Development.md',
    '17_Key-Roles-and-Responsibilities.md',
    '18_Industry-Demand-and-Career-Opportunities.md',
    '19_The-Role-of-Full-Stack-Developers-in-the-Industry.md',
    '20_Practice-Quiz-Importance-and-Role-of-Full-Stack-Developers-in-the-Industry.md',
    '21_Front-End-vs-Back-End-Development.md',
    '22_Integrating-Front-End-and-Back-End-Development.md',
    '23_Comparing-Front-End-and-Back-End-Development.md',
    '24_Practice-Quiz-Comparison-With-Front-End-and-Back-End-Development.md',
    '25_Essential-Front-End-Technologies.md',
    '26_Essential-Back-End-Technologies.md',
    '27_Key-Technologies-and-Tools-in-Full-Stack-Development.md',
    '28_Practice-Quiz-Key-Technologies-and-Tools-Used-in-Full-Stack-Development.md',
    '29_Tool-Integration-for-Back-End-Project-Planning.md',
    '30_Benefits-of-Integrated-Planning-in-Back-End-Development.md',
    '31_Integrating-Project-Planning-With-Development-Tools.md',
    '32_Practice-Quiz-Integrating-Project-Planning-With-Development-Tools.md',
    '33_Basics-of-Git-for-Back-End-Development.md',
    '34_Using-GitHub-for-Collaborative-Back-End-Development.md',
    '35_Introduction-to-Version-Control-Systems-Git-and-GitHub.md',
    '36_Graded-Quiz-Introduction-to-Full-Stack-Development.md',
    '37_Conclusion-Introduction-to-Full-Stack-Development.md'
)

foreach ($f in $files) {
    if (-not (Test-Path $f)) { New-Item -ItemType File -Path $f -Force | Out-Null }
}

Write-Host "Created simplified .md files in $scriptDir"
