namespace Howest.AiDriven.Ex08.Models.Library2;

public class Book : Item
{
    public string Author { get; }
    public int Pages { get; }
    public override string ItemType => "Book";

    public Book(int id, string title, int year, string author, int pages) : base(id, title, year)
    {
        Author = author;
        Pages = pages;
    }
}
