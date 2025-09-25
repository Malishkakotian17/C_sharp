// Complex addition

using System;

class ComplexNumber
{
  
    double real;
    double imag;


    public ComplexNumber(double r, double i)
    {
        real = r;
        imag = i;
    }

 
    public void Show()
    {
        Console.WriteLine(real + " + " + imag + "i");
    }

    // Overloaded Add method (instance method)
    public ComplexNumber Add(ComplexNumber c)
    {
        double r = real + c.real;
        double i = imag + c.imag;
        return new ComplexNumber(r, i);
    }

    // Overloaded Add method (static method)
    public static ComplexNumber Add(ComplexNumber a, ComplexNumber b)
    {
        double r = a.real + b.real;
        double i = a.imag + b.imag;
        return new ComplexNumber(r, i);
    }
}

class Program
{
    static void Main()
    {   Console.WriteLine("Enter real and imaginary parts of first complex number:");
        double r1 = Convert.ToDouble(Console.ReadLine());
        double i1 = Convert.ToDouble(Console.ReadLine());
        ComplexNumber c1 = new ComplexNumber(r1,i1);


        Console.WriteLine("Enter real and imaginary parts of second complex number:");
        double r2= Convert.ToDouble(Console.ReadLine());
        double i2 = Convert.ToDouble(Console.ReadLine());
        ComplexNumber c2 = new ComplexNumber(r2, i2);

        Console.Write("First number: ");
        c1.Show();

        Console.Write("Second number: ");
        c2.Show();

      
        ComplexNumber sum1 = c1.Add(c2);
        Console.Write("Sum using instance method: ");
        sum1.Show();

     
        ComplexNumber sum2 = ComplexNumber.Add(c1, c2);
        Console.Write("Sum using static method: ");
        sum2.Show();
    }
}
