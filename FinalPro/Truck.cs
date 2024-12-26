using System;
public class Truck : Vechicle
{
    public Truck(string carname, int maxspeed) : base(carname, maxspeed)
    {
    }
    public int CargoCapacity{get;set;}
    public override void Start()
    {
        Console.WriteLine("The Truck's heavy engin rumbles as it starts!");
    }
}