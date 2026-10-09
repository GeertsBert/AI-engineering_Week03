namespace Howest.AiDriven.Ex02.Models
{
    public class DvD : LibraryItem
    {
        public int Duration { get; set; }
        public DvD(int id, string title, int yearpublished, int duration) : base(id, title, yearpublished)
        {
            Duration = duration;
        }
        public override void PrintDetails()
        {
            Console.WriteLine($"{ID}: {Title} published:{YearPublished} duration: {Duration} minutes");
        }
    }
}