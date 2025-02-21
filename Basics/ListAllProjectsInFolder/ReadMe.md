# C# Project Lister and Builder

This C# console application lists all `.csproj` files (C# projects) within a specified folder and optionally builds them using the `dotnet build` command.

## Overview

The program takes a folder path as input.  It searches recursively through the folder and its subfolders for `.csproj` files.  It then lists these files and proceeds to build each project.

## Features

* **Recursive Search:** Finds all `.csproj` files within a given directory and its subdirectories.
* **Project Listing:** Displays the names of the discovered C# project files.
* **Project Building (Optional):**  Builds each project using the `dotnet build` command.  The build output is displayed in the console.

## Getting Started

1. **Save the Code:** Save the provided C# code as a `.cs` file (e.g., `ProjectLister.cs`).

2. **Compile:** Open your terminal or command prompt and compile the code using the C# compiler (`csc`):

   ```bash
   csc ProjectLister.cs