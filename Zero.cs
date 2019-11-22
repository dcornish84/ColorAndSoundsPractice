using System;
using Inheritance;

public class Zero : Vehicle
{ // Electric motorcycle
    public double BatteryKWh { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero drives past.  BrapBrapBrap.");
    }

    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero turns right barely survives a minivan encounter.");
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero hits a wall and stops completely.");
    }
}