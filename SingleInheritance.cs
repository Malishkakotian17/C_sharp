using System;

class Animal
{
    public virtual void sound()
    {
        Console.WriteLine("Animal has sound");
    }
}
class Dog : Animal
{
    public  void barks()
    {
        Console.WriteLine("Dog barks");
    }
}
class  Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.sound(); 
        dog.barks(); 
    }
}
