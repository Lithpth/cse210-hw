using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        // You can create a list out of Shape objects
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        // we add this shape to the list
        shapes.Add(s1);
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);
        
        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = s.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color=color;
    }

    // Abstract
    public abstract double GetArea();
}
public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base (color)
    {
        _side=side;
    }
    // override
    public override double GetArea()
    {
        return _side * _side;
    }

}
public class Rectangle : Shape
{
    private double _width;
    private double _length;
    public Rectangle(string color, double width,double length) : base (color)
    {
        _width = width;
        _length = length;
    }
    // override
    public override double GetArea()
    {
        return _length * _width;
    }

}