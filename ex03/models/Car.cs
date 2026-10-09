using System.Drawing;

namespace Howest.AiDriven.Ex03.Models;

public class Car : Vehicle, IRefuelable
{
    public int NumberOfWheels {get; set;}
    public Car(int speed, string color, int numberofwheels) : base(speed,color)
    {
        NumberOfWheels = numberofwheels;
    }
    public void Refuel()
    {
        Console.WriteLine("Refueling the car....");
    }
    public override string DescribeVehicle()
    {
        return $"This is a {Color} car that can go {Speed} km/h on {NumberOfWheels} wheels";
    }
}