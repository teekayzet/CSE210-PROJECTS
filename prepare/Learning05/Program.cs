using System;

class Program
{
    static void Main(string[] args)
    {
        Square S = new Square("black", 10);
        Console.WriteLine($"The color is {S.GetColor()} and the area of the shape is {S.GetArea()}");

        Rectangle R = new Rectangle("blue", 5, 13);
        Console.WriteLine($"The color is {R.GetColor()} and the area of the shape is {R.GetArea()}");

        Circle C = new Circle("green", 3);
        Console.WriteLine($"The color is {C.GetColor()} and the area of the shape is {C.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(S);
        shapes.Add(R);
        shapes.Add(C);
        foreach (Shape sha in shapes)
        {
            double area = sha.GetArea();
        }

    }
}