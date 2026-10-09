namespace Howest.AiDriven.Ex03.Models;

public class Boat : Vehicle
{
    public string TypeOfWater { get; set; }
    public Boat(int speed, string color, string typeofwater) : base(speed, color)
    {
        TypeOfWater = typeofwater;
    }
    public override string DescribeVehicle()
    {
        return $"This is a {Color} boat that can go {Speed} km/h on {TypeOfWater}";
    }
}