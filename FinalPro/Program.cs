public class Program : Vechicle
{
    public Program(string carname, int maxspeed) : base(carname, maxspeed)
    {
    }
    public static void Main(string[]args){
        Vechicle[] a=new Vechicle[3];
        a[0]=new Car("car",100);
        a[1]=new Motorcycle("motor",100);
        a[2]=new Truck("truck",70);
        foreach (var vehicle in a)
        {
            vehicle.Start();
        }
        a[0].Accelerate(10);
        a[1].Accelerate(20);
        a[2].Accelerate(15);
        foreach (var vehicle in a)
        {
            vehicle.GetSpeed();
        }
        Console.WriteLine(Vechicle.TotalVechicles);
    }
}
