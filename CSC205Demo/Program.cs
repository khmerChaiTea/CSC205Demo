using System;

public class Counter
{
    public int instances = 0;
    public Counter()
    { instances++; }
}
public class App
{
    static void Main(String[] args)
    {
        Counter c0 = new Counter();
        Console.WriteLine($"{c0.instances} instance(s) of the Counter class!");
        Counter c1 = new Counter();
        Console.WriteLine($"{c1.instances} instance(s) of the Counter class!");
        Counter c2 = new Counter();
        Console.WriteLine($"{c2.instances} instance(s) of the Counter class!");
        Counter c3 = new Counter();
        Console.WriteLine($"{c3.instances} instance(s) of the Counter class!");
        Counter c4 = new Counter();
        Console.WriteLine($"{c4.instances} instance(s) of the Counter class!");
        Console.WriteLine($"{c0.instances} instance(s) of the Counter class!");
    }
}

