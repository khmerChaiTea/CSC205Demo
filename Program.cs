using System;
public class Book
{
    public string title;
    public string isbn;
    public double price;
    public Book()
    {
        title = "";
        isbn = "";
        price = 0.0;
    }
    public Book(string t, string i, double p)
    {
        title = t;
        isbn = i;
        price = p;
    }
    public void Display()
    { Console.WriteLine($"Title: {title}, ISBN: {isbn}, Price: {price}"); }
}

public class Program
{
    public static void Main(string[] args)
    {
        Book[] books = new Book[5];
        books[0] = new Book("book 1", "121", 10.99);
        books[1] = new Book("book 2", "122", 12.99);
        books[2] = new Book("book 3", "123", 18.88);
        books[3] = new Book("book 4", "124", 5.99);
        books[4] = new Book("book 5", "125", 20.0);

        books[4].Display();
    }
}


