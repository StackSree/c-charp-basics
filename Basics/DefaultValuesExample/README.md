# Default Values in C#

## Overview
This C# program demonstrates the **default values** assigned to different types in C#. The `default` keyword is used to initialize variables with their default values based on their type.

## Concepts Covered
- **Reference types** (default to `null`)
- **Nullable value types**
- **Numeric types** (default to `0` or `0.0` for floating points)
- **Enum types** (default to the first defined constant, which is `0`)
- **Character type** (default to `\0`)
- **Boolean type** (default to `false`)
- **Using `default` without specifying a type**
- **Default values for custom value types (structs)**

## Execution Steps

1. **Compile the program** using:
   ```sh
   csc DefaultValuesExample.cs
   ```
2. **Run the executable**:
   ```sh
   DefaultValuesExample.exe
   ```

## Expected Output
```
Default values for predefined types:
string: null
int?:
int: 0
double: 0
decimal: 0
MyEnum: Value1
char: '\0'
bool: False
decimal inferred: 0

Default value for custom value type (struct):
MyStruct.intField: 0
MyStruct.stringField: null
MyStruct.boolField: False
```

## Key Takeaways
- The `default` keyword provides the default value of a type.
- **Reference types** default to `null`.
- **Value types** default to zero-equivalent values.
- **Structs** have default values for their fields.

Understanding default values helps avoid **uninitialized variables** and ensures **safe memory allocation** in C#.

