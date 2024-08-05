using System;
public class Pair<T, U>
{
    public T First { get; set; }
    public U Second { get; set; }
    public override string ToString()
    {
        return "{ " + First + ", " + Second + " }";
    }
}
public class App
{
    static void Main()
    {
        Pair<int, int> p1 = new Pair<int, int> { First = 5, Second = 20 };
        Console.WriteLine(p1.ToString());
        Pair<string, string> p2 = new Pair<string, string> { First = "Suzy", Second = "Bob" };
        Console.WriteLine(p2.ToString());
    }
}
