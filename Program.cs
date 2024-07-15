using System;

public class Program
{
    // Used static variable
    static int a2 = 1;
    public static void Main(String[] args)
    {
        // Generate and display 10 random 
        // integers between 0 and 100
        Random rnd = new Random();
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(rnd.Next(0, 101));

        }
    }
}

