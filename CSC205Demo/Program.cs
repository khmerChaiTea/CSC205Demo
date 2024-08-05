using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        var numbers = new Stack();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");

        // A stack can be enumerated without disturbing its contents.
        Console.WriteLine("Contents of the stack:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\nPopping '{0}'", numbers.Pop());
        Console.WriteLine("Peek at next item: {0}",
            numbers.Peek()); // Peek does not remove the item
        Console.WriteLine("Contents of the stack now:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
} //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-8.0
