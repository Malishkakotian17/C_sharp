using System;
abstract class shape
{
    public abstract double area();
}
class circle : shape
{
    double r;
    public circle(double r)
    {
        this.r = r;
    }
    public override double area()
    {
        return Math.PI * r * r;
    }
}
class triangle : shape
{
    double b, h;
    public triangle(double b, double h)
    {
        this.b = b;
        this.h = h;
    }
    public override double area()
    {
        return 0.5 * b * h;
    }
}
class progrm
{
    static void Main(string[] args)
    {
        shape s;
        s = new circle(5.0);
        Console.WriteLine("Area of circle: " + s.area());
        s = new triangle(4.0, 5.0);
        Console.WriteLine("Area of triangle: " + s.area());
    }
}
