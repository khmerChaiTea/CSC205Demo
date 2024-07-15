using System;

public class Program
{
    public static void Main(String[] args)
    {
        // Initialized array
        int[] a = { 1, 2, 3, 4 };
        // Output the array a
        Console.WriteLine("before:");
        foreach (int i in a) Console.WriteLine(i);
        // Modify array a
        ModifyArray(a);
        // Output a new array calling method ModifyArray()
        Console.WriteLine("after");
        foreach (int i in a) Console.WriteLine(i);
    }


    // Passby reference
    public static void ModifyArray(int[] b)
    {
        for (int i = 0; i < b.Length; i++)
        {
            // Value of the array increased by one
            b[i]++;
        }
    }
}

