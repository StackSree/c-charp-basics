# Null Operators Demo in C#

This project demonstrates how to use C# null-related operators effectively:

- `??` - Null-Coalescing Operator
- `??=` - Null-Coalescing Assignment Operator
- `?.` - Null-Conditional (Elvis) Operator

## 📌 Description

These operators make it easier to handle `null` values in C# and help avoid `NullReferenceException` errors.

### Null-Coalescing Operator (`??`)

```csharp
string s1 = null;
string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"

### Null-Coalescing Assignment Operator (??=)
string name = null;
name ??= "Default Name"; // Assigns only if name is null

### Null-Conditional Operator (?.)
StringBuilder sb = null;
string s = sb?.ToString(); // s becomes null, no exception thrown

## Supports chaining:
int? length = sb?.ToString().Length;

## Supports indexers:
string word = words?[1];

## Supports void methods:
someObject?.SomeVoidMethod(); // Becomes a no-op if someObject is null

## Combining Operators
string s = sb?.ToString() ?? "nothing"; // Avoids exception and uses default
```
