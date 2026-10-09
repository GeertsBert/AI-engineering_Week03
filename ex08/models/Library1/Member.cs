namespace Howest.AiDriven.Ex08.Models.Library1;

public class Member
{
    public const int MaxLoans = 3;

    public int MemberId { get; }
    public string Name { get; }

    public Member(int memberid, string name)
    {
        MemberId = memberid;
        Name = name;
    }

    public override string ToString()
    {
        return $"#{MemberId} {Name}";
    }
}
