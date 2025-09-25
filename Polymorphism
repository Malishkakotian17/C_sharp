using System;
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
    public virtual void erase()
    {
        Console.WriteLine("Erasing shape");
    }
}
class circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing circle");
    }
    public override void erase()
    {
        Console.WriteLine("Erasing circle");
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing triangle");
        }
        public override void erase()
        {
            Console.WriteLine("Erasing triangle");
        }
        class square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("drawing square");
            }
            public override void erase()
            {
                Console.WriteLine("Erasing square");
            }
        }
        class Program
        {
            static void Main()
            {
                Shape[] shapes = { new circle(), new Triangle(), new square() };
                foreach (Shape s in shapes)
                {
                    s.Draw();
                    s.erase();
                }
            }
        }
    }
} 
