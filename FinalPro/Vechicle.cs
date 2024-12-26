using System;
public class Vechicle{
    public string name{get;set;}
    int speed {get; set;}
    public static int TotalVechicles{get;set;}
   public Vechicle(string carname , int maxspeed){
        name =carname;
        speed = maxspeed;
        TotalVechicles++;
    }
    public virtual void Start(){
        Console.WriteLine("Vehicle Is Starting!");
    }
    public virtual void Accelerate(int incrment){
        speed = incrment;
        Console.WriteLine(GetSpeed());
    }
    public int  GetSpeed(){
        return speed;
    }
}