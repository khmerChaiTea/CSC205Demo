using System;
public class Cat
{
    // Auto-implemented properties.
    public int Age { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Cat cat = new Cat { Age = 10, Name = "Fluffy" };
        Cat sameSameCat = new Cat();

        Console.WriteLine($"cat name: {cat.Name}, cat age: {cat.Age}");
        Console.WriteLine($"cat name: {sameSameCat.Name}, cat age: {sameSameCat.Age}");
    }
}
