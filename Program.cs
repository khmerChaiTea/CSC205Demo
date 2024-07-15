using System;

public class Program
{
    // Used static variable
    static int a2 = 1;
    public static void Main(String[] args)
    {
        // Generate and display 10 random 
        // floating numbers between 0 and 1.0 
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            double x = random.NextDouble();
            Console.WriteLine(x);
        }

    }
}

