namespace Howest.AiDriven.Ex04.Models;

public class ComicBook : Collectible
{
    string Publisher { get; set; }
    string Author { get; set; }
    public override string CollectType => "comic book";
    public ComicBook(string name, int yearoforigin, double price, string publisher, string author) : base(name , yearoforigin, price)
    {
        Publisher = publisher;
        Author = author;
    }
    public override string ToString()
    {
        return $"Comic: {Name} by: {Author}";
    }
}