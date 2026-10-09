namespace Howest.AiDriven.Ex08.Models.Library2;

public class Member
{
    public const int MaxItems = 5;

    private readonly List<Item> borrowedItems = new List<Item>();

    public int MemberId { get; }
    public string Name { get; }
    public IReadOnlyList<Item> BorrowedItems => borrowedItems;

    public Member(int memberid, string name)
    {
        MemberId = memberid;
        Name = name;
    }

    public void Borrow(Item item)
    {
        if (!item.IsAvailable)
            throw new InvalidOperationException($"{item.Title} is already borrowed by {item.BorrowedBy!.Name}");
        if (borrowedItems.Count >= MaxItems)
            throw new InvalidOperationException($"{Name} already has {MaxItems} items");

        borrowedItems.Add(item);
        item.BorrowedBy = this;
    }

    public void Return(Item item)
    {
        if (!borrowedItems.Remove(item))
            throw new InvalidOperationException($"{Name} did not borrow {item.Title}");

        item.BorrowedBy = null;
    }

    public override string ToString()
    {
        return $"#{MemberId} {Name}";
    }
}
