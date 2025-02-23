# C# Reserved Words and Data Types

This C# program demonstrates how to list reserved words (keywords) and built-in data types in C#.  It also includes common .NET types that are frequently used as if they were built-in.

## Overview

The program uses reflection to get information about built-in data types.  However, due to the nature of reserved words (which are handled by the compiler), a hardcoded list is used for reserved words.  This list should be kept up-to-date with the official C# Language Specification.

## Features

* Lists C# reserved words (keywords) - *Note: This list is manually maintained and may not be exhaustive.*
* Lists built-in C# data types.
* Lists common .NET types often used as if they were built-in (e.g., `string`, `object`, `dynamic`).

## Getting Started

1. **Clone the repository (if applicable):**  If this code is in a repository, clone it.

2. **Save the code:** Save the provided C# code as a `.cs` file (e.g., `ReservedWords.cs`).

3. **Compile:** Open a command prompt or terminal and use the C# compiler (`csc`) to compile the code:

   ```bash
   csc ReservedWords.cs

## Note
If you really want to use an identifier that clashes with a reserved keyword, you can do so by qualifying it with the @ prefix. For instance:
int using = 123; // Illegal
int @using = 123; // Legal
The @ symbol doesn’t form part of the identifier itself. So, @myVariable is the same as myVariable.
