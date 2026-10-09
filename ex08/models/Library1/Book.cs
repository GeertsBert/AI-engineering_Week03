namespace Howest.AiDriven.Ex08.Models.Library1;

public class Book
{
    public string Isbn { get; }
    public string Title { get; }
    public string Author { get; }
    public int YearPublished { get; }

    public Book(string isbn, string title, string author, int yearpublished)
    {
        Isbn = isbn;
        Title = title;
        Author = author;
        YearPublished = yearpublished;
    }

    public override string ToString()
    {
        return $"{Title} by {Author} ({YearPublished})";
    }
}
