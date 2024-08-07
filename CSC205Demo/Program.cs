using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        var salmons = new List<string>();
        salmons.Add("chinook");
        salmons.Add("pink");
        salmons.Add("sockeye");
        salmons.Add("coho");

        salmons.Sort();
        // Iterate through the list.
        foreach (var salmon in salmons)
        {
            Console.Write(salmon + " ");
        }
    }
}
