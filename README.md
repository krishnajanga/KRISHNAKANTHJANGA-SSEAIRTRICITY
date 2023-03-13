This framework was built on Selenium C# using Nunit and Specflow feature files.
All required packages were downloaded and kept under Dependenices->packages
Only one feature file created and kept under Features folder.
Page Object model followed and maintained all objects under Pages folder.
Step Definition file created against the steps mentioned in the feature file and kept under Steps folder.
Browser invoking and reporting related code maintained under Utilities folder.
checkout the code from github from the following branch 'https://github.com/krishnajanga/KRISHNAKANTHJANGA-SSEAIRTRICITY'.
Tests can be executed on two browsers 'Edge' and 'Chrome' which can be configurable inside feature file along with the URL.
Edge driver path should be updated inside BrowserBase.cs file.
while building the project make sure that target framework should be .NET 6.0 or above under
project(SSEAutomationHomeAppliances)-> Prperties.
Currently added appliances with daily,weekly,monthly and yearly consumption are shown in the console as mentionedd in Acceptance criteria.
Once build is succesful,tests need to be run from Test Explorer.
At the end of test execution report can be seen under Reports folder and status can be seen on console window.
