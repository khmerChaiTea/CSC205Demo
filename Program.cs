﻿using System;

public class Program
{
    // Used static variable
    static int a2 = 1;
    public static void Main(String[] args)
    {
        Random random = new Random();
        int n1 = random.Next();
        int n2 = random.Next(101);
        int dice = random.Next(1, 7);
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        Console.WriteLine(dice);
    }
}

