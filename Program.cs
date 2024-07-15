using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int x = 8;
            // int y = 5;
            int x = 8, y = 5;
            Console.WriteLine((x >= y) && (x < 10));

            double pi = 3.14159;
            int p = (int)pi;
            double q = Math.Round(pi * 20.0);
            Console.WriteLine(p);
            Console.WriteLine(q);

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
