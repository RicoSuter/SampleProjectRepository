SampleProjectRepository
=======================

A repository with a sample project structure used to demonstrate build processes and how to do dependency management using NuGet. 

Run `BuildAll.bat` to build all projects and generate new NuGet packages. 
The `BuildAll.bat` must be run in the "Developer Command Prompt for Visual Studio" so that the MSBuild application is known. 

In Visual Studio, add the "Packages" directory as a NuGet feed to install the generated packages. 
