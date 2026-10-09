namespace Howest.AiDriven.Ex08.Models.Library2;

public class Comic : Item
{
    public string Author { get; }
    public string Publisher { get; }
    public int IssueNumber { get; }
    public override string ItemType => "Comic";

    public Comic(int id, string title, int year, string author, string publisher, int issuenumber) : base(id, title, year)
    {
        Author = author;
        Publisher = publisher;
        IssueNumber = issuenumber;
    }
}
