# C# Type Conversion Demo

This C# console application demonstrates implicit and explicit type conversions, as well as the use of the `Convert` class, `Parse` method, and `TryParse` method.

## Overview

Type conversion is the process of changing a value from one data type to another. In C#, this can be done implicitly (automatically) or explicitly (manually). This project provides examples of both.

## Features

* **Implicit Conversion:** Shows examples of automatic type conversion from smaller to larger data types (e.g., `int` to `long`, `float` to `double`).
* **Explicit Conversion:** Demonstrates manual type conversion using the cast operator `(type)`, highlighting potential data loss (truncation) and overflow.
* **`Convert` Class:** Shows how to use the `Convert` class for explicit conversions, particularly with strings.
* **`Parse` Method:** Demonstrates the use of the `Parse` method for string to number conversion, and the potential for exceptions.
* **`TryParse` Method:** Shows how to use the `TryParse` method for safe string to number conversions, preventing exceptions.

## Getting Started

1.  **Prerequisites:**
    * .NET SDK installed on your system.
2.  **Clone the Repository:**
    ```bash
    git clone <repository_url>
    cd <repository_directory>
    ```
3.  **Build and Run:**
    ```bash
    dotnet run
    ```
4.  **View Output:**
    The console will display the results of the various type conversion examples.

## Code Examples

### Implicit Conversion

```csharp
int intValue = 100;
long longValue = intValue; // Implicit conversion from int to long
float floatValue = 12.5f;
double doubleValue = floatValue; // Implicit conversion from float to double

### Explicit conversion
double doubleValue2 = 123.789;
int intValue2 = (int)doubleValue2; // Explicit conversion from double to int (truncation)

### Convert Class
string stringValue = "42";
int convertedIntValue = Convert.ToInt32(stringValue); // Explicit conversion string to int using Convert

### Parse Method
string stringFloat = "3.14159";
float parsedFloat = float.Parse(stringFloat);

### TryParse Method
string stringTryInt = "abc";
int tryIntResult;
bool success = int.TryParse(stringTryInt, out tryIntResult);

if (success)
{
    // Conversion successful
}
else
{
    // Conversion failed
}


### Considerations
* **Be aware of potential data loss or overflow when performing explicit conversions.
* **Use TryParse for safer string to number conversions to avoid exceptions.
* **The Convert class provides a robust way to handle conversions, including null values.
* **Understand the limitations and ranges of each datatype.