using System;
using Inheritance;

public class Tesla : Vehicle
{ // Electric car
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives past.  Weeeeehoehoeoh");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Tesla silently banks right completely unnoticed.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla runs out of battery and grinds to a halt.");
    }
}