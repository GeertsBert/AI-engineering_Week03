namespace Howest.AiDriven.Ex08.Models.Library2;

public abstract class Item
{
    public int Id { get; }
    public string Title { get; }
    public int Year { get; }
    public Section? Section { get; internal set; }
    public Member? BorrowedBy { get; internal set; }

    public bool IsAvailable => BorrowedBy == null;
    public abstract string ItemType { get; }

    protected Item(int id, string title, int year)
    {
        Id = id;
        Title = title;
        Year = year;
    }

    public override string ToString()
    {
        string status = IsAvailable ? "available" : $"borrowed by {BorrowedBy!.Name}";
        return $"[{ItemType}] {Title} ({Year}) - {status}";
    }
}
