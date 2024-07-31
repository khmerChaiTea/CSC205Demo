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
        //Shape[] shapes = { new Square(5), new Rectangle(3, 4) };
        Object[] shapes = { new Square(5), new Rectangle(3, 4) };
        //Shape sq = new Square(12);
        //Console.WriteLine($"Area of the square = {shapes[0].GetArea()}");
        Console.WriteLine($"Area of the square = {((Shape)shapes[0]).GetArea()}");
        /*
         * shapes[0]: This accesses the first element in the array, which is an instance of Square.
         * (Shape)shapes[0]: This casts the object at shapes[0] to the Shape type.
         * Since Square is a subclass of Shape, this cast is valid.
         * ((Shape)shapes[0]).GetArea(): This calls the GetArea method on the cast object.
         * If GetArea is a virtual or abstract method defined in the Shape class
         * and overridden in the Square class, the correct method implementation
         * will be invoked for the Square instance.
        */

        //Shape rect = new Rectangle(5, 7);
        //Console.WriteLine($"Area of the rectangle = {shapes[1].GetArea()}");
    }
}
