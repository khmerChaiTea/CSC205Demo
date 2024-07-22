using System;
public class NonStaticClass
{
    // public string staticStr = "A non-static variable (or data member)";
    public string Str {  get; set; }
    public void NonStaticMethod()
    {
        Console.WriteLine(Str);
    }
}
public class Program
{
    static void Main(string[] args)
    {
        NonStaticClass sc = new NonStaticClass(); // can be instantiated!
        Console.WriteLine(sc.Str);
        sc.NonStaticMethod();
    }
}