using System;
using System.Collections;   // Removed Generic
class Example
{
    public static void Main()
    {
        Queue numbers = new Queue();    // Removed <String>
        numbers.Enqueue("one");
        numbers.Enqueue(2);
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        // A queue can be enumerated without disturbing its contents.
        // When compiled it throw error so change string to var
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
        Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("\nItems in the queue now:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1
