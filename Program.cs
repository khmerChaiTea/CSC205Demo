using System;

public class Program
{
    // Used static variable
    static int a2 = 1;
    public static void Main(String[] args)
    {
        int a2 = 1;
        Console.WriteLine(a2);  // Output 1
        // no parameter or arguement to pass
        ModifyNumber();
        Console.WriteLine(a2);  // Output 1
    }

    static void ModifyNumber()
    {
        // Take the global
        a2++;
        Console.WriteLine(a2);  // Output 2
    }
}

