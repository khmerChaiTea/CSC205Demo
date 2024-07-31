using System;

class TestClass
{
    public class Shape
    {
        public const double PI = Math.PI;
        protected double _x, _y;
        public Shape(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public virtual double Area()
        {
            return _x * _y;
        }

        /*
         * The virtual keyword is used to modify a method, property, etc. ,
         * and allow for it to be overridden in a derived class. By default,
         * methods are non-virtual. You cannot override a non-virtual method.
         */
    }
    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0) { }

        public override double Area()
        {
            return PI * _x * _x;
        }
        // A = PI * r^2
    }
    public class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h) { }
        public override double Area()
        {
            return 2 * PI * _x * _x + 2 * PI * _x * _y;
        }
        // V = PI * r^2 * h; V = Volume
        // Total Surface Area; Atotal = Alateral + Abases = 2 * PI * r^2 + 2 * PI * r * h
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