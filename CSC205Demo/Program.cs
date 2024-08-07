using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        var salmons = new List<string>();
        salmons.Add("chinook");
        salmons.Add("coho");
        salmons.Add("pink");
        salmons.Add("sockeye");
        salmons.RemoveAt(3);
        // Iterate through the list.
        foreach (var salmon in salmons)
        {
            Console.Write(salmon + " ");
        }
    }
}
