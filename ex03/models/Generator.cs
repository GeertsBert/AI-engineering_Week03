namespace Howest.AiDriven.Ex03.Models;

public class Generator : IRefuelable
{
    public int PowerInWatts { get; set; }
    public Generator(int powerinwatts)
    {
        PowerInWatts = powerinwatts;
    }
    public void Refuel()
    {
        Console.WriteLine("Refueling the generator....");
    }
    public void DescribeGenerator()
    {
        Console.WriteLine($"This is a generator with a power output of {PowerInWatts} watts");
    }
}