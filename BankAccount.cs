using System;

class BankAcc
{
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("deposited:" + amount);
    }

    public void withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("withdrawn:" + amount);
        }
        else
            Console.WriteLine("not enough balance");
    }
}
class SavingAcc : BankAcc
{
    public double InterestRate;
    public void CalculateInterest()
    {
        Console.WriteLine("Interest added: " + (Balance * InterestRate / 100));
    }
}
