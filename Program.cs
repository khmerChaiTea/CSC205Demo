﻿using System;
public class Book
{
    public string title;
    public string isbn;
    public double price;
}

public class Program
{
    public static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "C# 9 and .NET 5";
        book1.isbn = "180056810X";
        book1.price = 42.74;
        Console.WriteLine(book1.title);

        Book book2 = new Book();
        book2.title = "C# in Depth";
        book2.isbn = "1617294535";
        book2.price = 38.99;
        Console.WriteLine(book2.title);
    }
}