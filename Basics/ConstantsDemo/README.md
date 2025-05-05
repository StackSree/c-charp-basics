# ConstantsDemo

This C# project demonstrates the differences between `const` and `static readonly` fields using a simple example.

## Overview

The application outputs some application-level configuration values defined in the `AppSettings` class and explains the key differences in behavior between `const` and `static readonly`.

### Key Concepts Covered

- `const`: Compile-time constant.
- `static readonly`: Runtime constant, can hold values determined at runtime.
- Reference type behavior with `static readonly`.

## Code Breakdown

### `AppSettings` Class

```csharp
public const string Version = "1.0.0";
```

- **Type**: Compile-time constant.
- **Immutable**: Cannot be modified anywhere in the program.
- **Limitations**: Must be assigned with a constant expression.

```csharp
public static readonly DateTime BuildDate;
```

- **Type**: Runtime constant.
- **Initialized in**: Static constructor.
- **Use Case**: When the value needs to be computed at runtime (e.g., current timestamp).

```csharp
public static readonly List<string> DefaultAdminRoles;
```

- **Type**: Runtime constant of a reference type.
- **Behavior**: The reference cannot be changed, but the contents (list items) _can_ be modified.

### Behavior Demonstrated in `Main`

- Outputs the values of `Version`, `BuildDate`, and `DefaultAdminRoles`.
- Attempts to reassign `const` and `static readonly` fields (commented out, as they cause compile-time errors).
- Demonstrates that you can modify the contents of a `List<string>` even if it is marked `static readonly`.

## Example Output

```bash
Application Version (const): 1.0.0
Application Build Date (static readonly): 5/5/2025 10:00:00 AM
Default Admin Roles (static readonly): Admin, SuperAdmin
Default Admin Roles After Modification: Admin, SuperAdmin, SystemAdmin
```

## Summary

This project serves as a useful reference for understanding when to use `const` versus `static readonly` in C#, especially in configuration and system metadata scenarios.
