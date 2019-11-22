using System;

public class Vehicle
{
    public string MainColor { get; set; }

    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vroom!");
    }

    public virtual void Turn()
    {
        Console.WriteLine("Tokyo drifts right.");
    }

    public virtual void Stop()
    {
        Console.WriteLine("comes to a complete stop.");
    }
}