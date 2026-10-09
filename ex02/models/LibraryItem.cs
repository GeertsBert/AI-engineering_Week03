namespace Howest.AiDriven.Ex02.Models
{
    public class LibraryItem
    {
        public int ID {get; set;}
        public string Title {get; set;}
        public int YearPublished {get; set;}
        public LibraryItem(int id, string title, int yearpublished)
        {
            ID = id;
            Title = title;
            YearPublished = yearpublished;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine($"{ID}: {Title} published:{YearPublished}");
        }
    }
}
