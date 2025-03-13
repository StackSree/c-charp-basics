namespace BooleanDemo;

internal class Program
{
    static void Main(string[] args)
    {
        // Boolean variable declarations
        bool isTrue = true;
        bool isFalse = false;
        bool result;

        // Logical Negation (!)
        Console.WriteLine($"!true: {!isTrue}"); // Output: !true: false
        Console.WriteLine($"!false: {!isFalse}"); // Output: !false: true

        // Logical AND (&)
        Console.WriteLine($"true & true: {isTrue & isTrue}"); // Output: true & true: true
        Console.WriteLine($"true & false: {isTrue & isFalse}"); // Output: true & false: false
        Console.WriteLine($"false & false: {isFalse & isFalse}"); // Output: false & false: false

        // Logical OR (|)
        Console.WriteLine($"true | true: {isTrue | isTrue}"); // Output: true | true: true
        Console.WriteLine($"true | false: {isTrue | isFalse}"); // Output: true | false: true
        Console.WriteLine($"false | false: {isFalse | isFalse}"); // Output: false | false: false

        // Logical Exclusive OR (^)
        Console.WriteLine($"true ^ true: {isTrue ^ isTrue}"); // Output: true ^ true: false
        Console.WriteLine($"true ^ false: {isTrue ^ isFalse}"); // Output: true ^ false: true
        Console.WriteLine($"false ^ false: {isFalse ^ isFalse}"); // Output: false ^ false: false

        // Conditional Logical AND (&&)
        result = isTrue && isTrue;
        Console.WriteLine($"true && true: {result}"); // Output: true && true: true

        result = isTrue && isFalse;
        Console.WriteLine($"true && false: {result}"); // Output: true && false: false

        // Example of short-circuiting:
        int x = 5;
        result = (x > 10) && (x++ < 6); // x++ is not executed because (x > 10) is false.
        Console.WriteLine($"x after short-circuit &&: {x}"); // Output: x after short-circuit &&: 5

        // Conditional Logical OR (||)
        result = isTrue || isFalse;
        Console.WriteLine($"true || false: {result}"); // Output: true || false: true

        result = isFalse || isTrue;
        Console.WriteLine($"false || true: {result}"); // Output: false || true: true

        // Example of short-circuiting:
        x = 5;
        result = (x < 10) || (x++ > 6); // x++ is not executed because (x < 10) is true.
        Console.WriteLine($"x after short-circuit ||: {x}"); // Output: x after short-circuit ||: 5

        // Equality (==) and Inequality (!=)
        Console.WriteLine($"true == true: {isTrue == isTrue}"); // Output: true == true: true
        Console.WriteLine($"true != false: {isTrue != isFalse}"); // Output: true != false: true

        // Nullable Boolean
        bool? nullableBool = null;
        Console.WriteLine($"Nullable boolean is null: {nullableBool == null}"); //Output: Nullable boolean is null: True

        nullableBool = true;
        Console.WriteLine($"Nullable boolean is true: {nullableBool == true}"); //Output: Nullable boolean is true: True

        nullableBool = false;
        Console.WriteLine($"Nullable boolean is false: {nullableBool == false}"); //Output: Nullable boolean is false: True

    }
}
