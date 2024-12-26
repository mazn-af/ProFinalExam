using System;
public class Car : Vechicle
{
   public float FuelEfficincy {get;set;}
    public Car(string carname, int maxspeed) : base(carname, maxspeed)
    {
    }

    public override void Start()
    {
        Console.WriteLine("The car is Starting with a smooth engine Sound!");
    }
    

}