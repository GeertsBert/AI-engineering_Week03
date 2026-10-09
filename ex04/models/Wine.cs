namespace Howest.AiDriven.Ex04.Models;

public class Wine : Collectible
{
    public double PricePerGlass { get; set; }
    public string Country { get; set; }
    public WineType Type { get; set; }
    public override string CollectType =>  $"{Type} wine";
    public Wine(string name, int yearoforigin, double price, double priceperglass, string country, WineType type) : base(name, yearoforigin, price)
    {
        PricePerGlass = priceperglass;
        Country = country;
        Type = type;
    }
    public override string ToString()
    {
        return $"Wine: {Name} from: {Country}";
    }
}
public enum WineType
{
    Red,
    White,
    Rose,
    Sparkling
}