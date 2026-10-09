namespace Howest.AiDriven.Ex02.Models
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public Book(int id, string title, int yearpublished, string author) : base(id, title, yearpublished)
        {
            Author = author;
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"{ID}: {Title} published:{YearPublished} by: {Author}");
        }
    }
}