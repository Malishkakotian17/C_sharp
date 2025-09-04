using System;

interface Ipayment
{
    void MakePayment(double amount);
}

class CreditCardPayment : Ipayment
{
    public void MakePayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
        Console.WriteLine("Payment successful!");
    }
}   

class PayPalPayment : Ipayment
{
       public void MakePayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
        Console.WriteLine("Payment successful!");
    }
}
class UPIPayment : Ipayment
{
    public void MakePayment(double amount)
    {
         Console.WriteLine($"Processing UPI payment of {amount:C}");
         Console.WriteLine("Payment successful!");
    }
}

class Program
{
    static void Main()
    {   
            Console.WriteLine("Welcome!");
            Console.WriteLine("Choose a payment method:");
            Console.WriteLine(" 1. Credit Card \n 2. Paypal Payment \n 3. UPI Payment ");
            Console.WriteLine("Enter your choice");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    CreditCardPayment c = new CreditCardPayment();
                    Console.WriteLine("Enter the amount to be paid:");
                    double amount1 = Convert.ToDouble(Console.ReadLine());
                    c.MakePayment(amount1);
                    break;

                case 2:
                    PayPalPayment p = new PayPalPayment();
                    Console.WriteLine("Enter the amount to paid:");
                    double amount2 = Convert.ToDouble(Console.ReadLine());
                    p.MakePayment(amount2);
                    break;

                case 3:
                    UPIPayment u = new UPIPayment();
                    Console.WriteLine("Enter the amount to be paid:");
                    double amount3 = Convert.ToDouble(Console.ReadLine());
                    u.MakePayment(amount3);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
       }
}
