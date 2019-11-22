using System;
using Inheritance;

public class Ram : Vehicle
{ // Gas powered truck
    public double FuelCapacity { get; set; }

    public void RefuelTank() { }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives past.  Woooooooooo");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram turns right and flips over.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram stops on Broadway for a jaywalking Chad or Kyle.");
    }
}