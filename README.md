# HtmlAgilityTest

## Reproduce JetBrains issue DCVR-9763
Project uses HtmlAgilityPack to reproduce the error thrown when using dotCover.
It looks like the **--DisableNGen** argument will workaround the issue.

## Prerequisites
- JetBrains.dotCover.CommandLineTools installed
- NUnit.ConsoleRunner installed

## Steps to reproduce
1. dotnet build
2. dotcover.exe cover --targetexecutable="nunit3-console.exe" --reporttype=detailedxml --output=.\dotcover.out -- .\HtmlAgilityTest.Tests\bin\Debug\HtmlAgilityTest.Tests.dll

## Steps to workaround
1. dotnet build
2. dotcover.exe cover --targetexecutable="nunit3-console.exe" --disablengen --reporttype=detailedxml --output=.\dotcover.out -- .\HtmlAgilityTest.Tests\bin\Debug\HtmlAgilityTest.Tests.dll
