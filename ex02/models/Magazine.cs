namespace Howest.AiDriven.Ex02.Models
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public Magazine(int id, string title, int yearpublished, int issuenumber) : base(id, title, yearpublished)
        {
            IssueNumber = issuenumber;
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"{ID}: {Title} published:{YearPublished} issue: {IssueNumber}");
        }
    }
}