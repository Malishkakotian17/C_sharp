using System;
using System;

interface IColor
{
    void ShowColor();
}

interface IFragrance
{
    void ShowFragrance();
}

class Flower : IColor, IFragrance
{
    public void ShowColor()
    {
        Console.WriteLine("The flower is Red in color.");
    }

    public void ShowFragrance()
    {
        Console.WriteLine("The flower has a Sweet fragrance.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Flower rose = new Flower();
        rose.ShowColor();
        rose.ShowFragrance();
    }
}
