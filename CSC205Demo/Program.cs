﻿using System;
using System.Collections.Generic;
class Example
{
    public static void Main()
    {
        var numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        // A queue can be enumerated without disturbing its contents.
        Console.WriteLine("Contents of queue:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        var numbersStack = new Stack<string>();

        //int count = numbers.Count;
        //for (int i = 0; i < count; i++)
        while (numbers.Count > 0)
        {
            //string number = numbers.Dequeue();
            //numbersStack.Push(number);
            Console.WriteLine("numberStack.Count: " + numbersStack.Count);
            numbersStack.Push((numbers.Dequeue()));
        }

        Console.WriteLine("Contents of stack:");
        foreach (var number in numbersStack)
        {
            Console.WriteLine(number);
        }

        // Move items back from stack to queue
        while (numbersStack.Count > 0)
        {
            string number = numbersStack.Pop();
            numbers.Enqueue(number);
        }

        Console.WriteLine("Contents of queue again:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

