# Bitwise Replace in C#

This project demonstrates a utility method in C# that replaces a specific range of bits within an integer. The purpose is to perform bit-level manipulation in a clear and verifiable way using bitwise operations.

## Features

- Replace a specified range of bits in an integer
- Bit masking and shifting logic
- Includes binary and decimal debug output
- Validation of replaced bits to ensure correctness

## Function: `ModifyBits`

```csharp
public static int ModifyBits(int num, int start, int end, int newValue)
```

### Parameters:

- `num`: Original integer value
- `start`: Start bit index (0-based, from right to left)
- `end`: End bit index (inclusive)
- `newValue`: New value to insert into the bit range

### Returns:

- Modified integer after replacing the specified bits

## How It Works

1. **Create a mask** to isolate the bit range using left shift (`<<`).
2. **Clear the original bits** in the range using bitwise AND with the complement of the mask.
3. **Insert the new bits** using bitwise OR.
4. **Print debugging output** showing binary values before and after the operation.
5. **Validate** that the replacement was successful.

## Example Usage

```csharp
int original = 0b10101010; // 170 in decimal
int startIdx = 2;
int endIdx = 5;
int newVal = 0b011; // 3 in decimal

int modified = ModifyBits(original, startIdx, endIdx, newVal);
Console.WriteLine(Convert.ToString(modified, 2));
```

**Expected Output:**

```
Original binary: 10101010
Extracted original bits: 1010
Modified binary: 10001110
Modified decimal: 142
Replaced bits: 11
Final modified binary: 10001110
```

## Requirements

- .NET 6.0+ or any compatible C# compiler

## License

MIT License
