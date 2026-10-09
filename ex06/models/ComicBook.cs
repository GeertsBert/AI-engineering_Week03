using Microsoft.VisualBasic;

namespace Howest.AiDriven.Ex06.Models;

public class ComicBook : Collectible
{
    string Publisher { get; set; }
    string Author { get; set; }
    public override string CollectType => "comic book";
    public ComicBook(string name, int yearoforigin, double price, string publisher, string author) : base(name, yearoforigin, price)
    {
        Publisher = publisher;
        Author = author;
    }
    public override string ToString()
    {
        return $"Comic: {Name} by: {Author}";
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not ComicBook other) return false;
        if (Author == other.Author && Name == other.Name) return true;
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Author, Name);
    }
}


