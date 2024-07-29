using System;

abstract class Shape
{
    public abstract int GetArea();
}

class Square : Shape
{
    private int _side;

    public Square(int n) => _side = n;

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _side * _side;
}
// Output: Area of the square = 144z

class Rectangle : Shape
{
    private int _length;
    private int _width;

    public Rectangle(int l, int w) => (_length, _width) = (l, w);
    //public Rectangle(int l, int w)
    //{
    //    _length = l;
    //    _width = w;
    //}

    // GetArea method is required to avoid a compile-time error.
    public override int GetArea() => _length * _width;
}

class App
{
    static void Main()
    {
        var sq = new Square(12);
        Console.WriteLine($"Area of the square = {sq.GetArea()}");

        var rect = new Rectangle(5, 7);
        Console.WriteLine($"Area of the rectangle = {rect.GetArea()}");
    }
}
