namespace Howest.AiDriven.Ex03.Models;

public abstract class Vehicle
{
    public int Speed {get; set;}
    public string Color {get; set;}
    public Vehicle(int speed, string color)
    {
        Speed = speed;
        Color = color;
    }
    public abstract string DescribeVehicle();
}