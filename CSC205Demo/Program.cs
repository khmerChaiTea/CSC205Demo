using System;
public class NonStaticClass
{
    public string staticStr = "A non-static variable (or data member)";
    public void NonStaticMethod()
    {
        Console.WriteLine(staticStr);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        NonStaticClass sc = new NonStaticClass(); // can be instantiated!
        Console.WriteLine(sc.staticStr);
        sc.NonStaticMethod();

        NonStaticClass sc2 = new NonStaticClass(); // can be instantiated!
        Console.WriteLine(sc.staticStr);
        sc.NonStaticMethod();
    }
}