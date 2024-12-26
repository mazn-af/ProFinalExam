using System;

public class Motorcycle : Vechicle
{
    public Motorcycle(string carname, int maxspeed) : base(carname, maxspeed)
    {
    }
    public override void Start()
    {
        Console.WriteLine("The motorcycle roars to life!");
    }
    public override void Accelerate(int incrment)
    {
        incrment=incrment*2;
        base.Accelerate(incrment);
    }
}