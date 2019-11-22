using System;
using Inheritance;

public class Cessna : Vehicle
{ // Propellor light aircraft
    public double FuelCapacity { get; set; }

    //override
    public virtual void RefuelTank() { }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna drives past.  ZoomzzzzzaaaaazzaaaZooom.");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna barrel roles right in attack formation.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna touches down gently on the runway.");
    }
}