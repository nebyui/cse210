using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("blue", 8.5, 7.2);
        Circle circle = new Circle("green", 3.14);

        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach (Shape shape in shapeList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"{color} - {area}");
        }



    }
}