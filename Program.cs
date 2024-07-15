using System;

public class Program
{
    // Used static variable
    static int a2 = 1;
    public static void Main(String[] args)
    {
        int a2 = 1;
        Console.WriteLine(a2);  // Output 1 takes a2 = 1 and out put 1
        // no parameter or arguement to pass
        ModifyNumber();         // Call the method and output 2
        Console.WriteLine(a2);  // Output 1 since no parameter or arguement to pass through
    }

    static void ModifyNumber()
    {
        // Take the global
        a2++;
        Console.WriteLine(a2);  // Increment global by 1
    }
}

