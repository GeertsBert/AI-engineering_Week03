namespace Howest.AiDriven.Ex08.Models.Library2;

public class Dvd : Item
{
    public string Director { get; }
    public int DurationInMinutes { get; }
    public override string ItemType => "DVD";

    public Dvd(int id, string title, int year, string director, int durationinminutes) : base(id, title, year)
    {
        Director = director;
        DurationInMinutes = durationinminutes;
    }
}
