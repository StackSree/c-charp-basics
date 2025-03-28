namespace RefLocalsDemo;

internal class Program
{
    static void Main(string[] args)
    {
        DataContainer container = new DataContainer();
        container.PrintData(); // Output: Data: [10, 20, 30, 40, 50]

        Console.WriteLine("\nWorking with a ref local:");
        // ref local: numRef becomes a reference to the element at index 2
        ref int numRef = ref container.GetElementRef(2);
        Console.WriteLine($"Value of numRef: {numRef}"); // Output: Value of numRef: 30
        Console.WriteLine($"Value in container[2]: {container.GetElementValue(2)}"); // Output: Value in container[2]: 30

        Console.WriteLine("\nModifying through the ref local:");
        numRef *= 2; // Directly modifies the underlying array element
        Console.WriteLine($"Value of numRef after modification: {numRef}"); // Output: Value of numRef after modification: 60
        Console.WriteLine($"Value in container[2] after modification: {container.GetElementValue(2)}"); // Output: Value in container[2] after modification: 60
        container.PrintData(); // Output: Data: [10, 20, 60, 40, 50]

        Console.WriteLine("\nAnother ref local referencing a different element:");
        ref int firstElementRef = ref container.GetElementRef(0);
        firstElementRef += 5;
        Console.WriteLine($"Value of firstElementRef: {firstElementRef}"); // Output: Value of firstElementRef: 15
        Console.WriteLine($"Value in container[0]: {container.GetElementValue(0)}"); // Output: Value in container[0]: 15
        container.PrintData(); // Output: Data: [15, 20, 60, 40, 50]

        Console.WriteLine("\nDemonstrating the difference without 'ref':");
        int regularLocal = container.GetElementValue(1); // Gets a copy of the value
        Console.WriteLine($"Value of regularLocal: {regularLocal}"); // Output: Value of regularLocal: 20
        regularLocal *= 3; // Modifies the local copy
        Console.WriteLine($"Value of regularLocal after modification: {regularLocal}"); // Output: Value of regularLocal after modification: 60
        Console.WriteLine($"Value in container[1]: {container.GetElementValue(1)}"); // Output: Value in container[1]: 20 (original value unchanged)
        container.PrintData(); // Output: Data: [15, 20, 60, 40, 50] (still unchanged)

        // You can even re-assign a ref local to refer to a different location
        Console.WriteLine("\nRe-assigning the ref local:");
        numRef = ref container.GetElementRef(4); // Now numRef refers to the element at index 4
        numRef -= 10;
        Console.WriteLine($"Value of numRef (now referencing index 4): {numRef}"); // Output: Value of numRef (now referencing index 4): 40
        Console.WriteLine($"Value in container[4]: {container.GetElementValue(4)}"); // Output: Value in container[4]: 40
        container.PrintData(); // Output: Data: [15, 20, 60, 40, 40]

        // Note: You cannot make a ref local refer to a property's getter result.
        // The following would result in a compile-time error:
        // public int MyProperty { get => _data[0]; set => _data[0] = value; }
        // ref int propertyRef = ref container.MyProperty; // Error: Property or indexer '...' cannot be passed as an out or ref parameter
    }

    public class DataContainer
    {
        private int[] _data = { 10, 20, 30, 40, 50 };

        // Ref return: Returns a reference to an element in the internal array
        public ref int GetElementRef(int index)
        {
            if (index >= 0 && index < _data.Length)
            {
                return ref _data[index]; // Return a reference
            }
            throw new IndexOutOfRangeException();
        }

        public int GetElementValue(int index)
        {
            if (index >= 0 && index < _data.Length)
            {
                return _data[index]; // Return a copy of the value
            }
            throw new IndexOutOfRangeException();
        }

        public void PrintData()
        {
            Console.WriteLine($"Data: [{string.Join(", ", _data)}]");
        }
    }
}
