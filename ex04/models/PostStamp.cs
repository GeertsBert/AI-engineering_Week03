namespace Howest.AiDriven.Ex04.Models;

public class PostStamp : Collectible
{
    string Image { get; set; }
    public override string CollectType => "post stamp";
    public PostStamp(string name, int yearoforigin, double price, string image) : base(name , yearoforigin, price)
    {
        Image = image;
    }
    public override string ToString()
    {
        return ($"PostStamp: {Name}");
    }
}