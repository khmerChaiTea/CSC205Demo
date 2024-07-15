using System;

public class Program
{
    public static void Main(String[] args)
    {
        //int[] a = new int[4];
        //int[] a = new int[4] { 1, 2, 3, 4 };
        int[] a = { 1, 2, 3, 4 };

        foreach (int i in a)
        {
            Console.WriteLine(i);
        }
    }

}

