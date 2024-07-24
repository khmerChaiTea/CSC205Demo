using System;
namespace CSC205
{
    internal class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x; this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }

    public sealed class App
    {
        static void Main()
        {
            var p1 = new Point(1, 2);
            var p2 = p1;
            var p3 = new Point(1, 2);
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine($"p1's value is: {p1.ToString()}");
        }
    }
}