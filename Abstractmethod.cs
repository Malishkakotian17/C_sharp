using System;
abstract class Shapes
{
    public abstract double Area();
}
class Circle : Shapes
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
class Program
{
    static void Main ()
    {
        Shapes circle = new Circle(5);
        Console.WriteLine("Area of the circle: " + circle.Area());
    }
}
