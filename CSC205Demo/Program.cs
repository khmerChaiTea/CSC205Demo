using System;

class TestClass
{
    public abstract class Shape
    {
        public const double PI = Math.PI;

        public abstract double Area();  // class must be abstract
    }
    public class Circle : Shape
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public override double Area()
        {
            return PI * r * r;
        }
        // A = PI * r^2
    }
    public class Cylinder : Shape
    {
        private double r, h;
        public Cylinder(double r, double h)
        {
            this.r = r;
            this.h = h;
        }
        public override double Area()
        {
            return 2 * PI * r * r + 2 * PI * r * h;
        }
        // V = PI * r^2 * h; V = Volume
        // Total Surface Area; A(total) = A(lateral) + A(bases) = 2 * PI * r^2 + 2 * PI * r * h
    }
    static void Main()
    {
        double r = 3.0, h = 5.0;
        Shape c = new Circle(r);
        Shape l = new Cylinder(r, h);
        // Display results.
        Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
        Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
    }
}