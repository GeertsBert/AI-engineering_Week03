namespace Howest.AiDriven.Ex04.Models;

public abstract class Collectible
{
    public string Name { get; set; }
    public int YearOfOrigin { get; set; }
    public double Price { get; set; }
    public double StartBidPrice { get { return Price * 0.8; } }
    public abstract string CollectType { get; }

    public Collectible(string name, int yearoforigin, double price)
    {
        Name = name;
        YearOfOrigin = yearoforigin;
        Price = price;
    }
}