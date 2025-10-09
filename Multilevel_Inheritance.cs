using System;

class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animals make sounds");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}

class Puppy : Dog
{
    public void Play()
    {
        Console.WriteLine("Puppy plays");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Puppy p = new Puppy();
        p.Speak();
        p.Bark();
        p.Play();
    }
}
