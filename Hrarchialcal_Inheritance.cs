namespace Hrarchialcal_Inheritance;
using System;

class SolarSystem
{
    public void ShowInfo()
    {
        Console.WriteLine("This is the Solar System.");
    }
}

class Planet : SolarSystem
{
    public void PlanetInfo()
    {
        Console.WriteLine("Planets revolve around the Sun.");
    }
}

class Star : SolarSystem
{
    public void StarInfo()
    {
        Console.WriteLine("The Sun is the star of the Solar System.");
    }
}

class Satellite : SolarSystem
{
    public void SatelliteInfo()
    {
        Console.WriteLine("Satellites revolve around planets.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Planet earth = new Planet();
        Star sun = new Star();
        Satellite moon = new Satellite();

        earth.ShowInfo();
        earth.PlanetInfo();

        sun.ShowInfo();
        sun.StarInfo();

        moon.ShowInfo();
        moon.SatelliteInfo();
    }
}

