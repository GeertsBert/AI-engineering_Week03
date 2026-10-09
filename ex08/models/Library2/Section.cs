namespace Howest.AiDriven.Ex08.Models.Library2;

public class Section
{
    private readonly List<Item> items = new List<Item>();

    public string Name { get; }
    public IReadOnlyList<Item> Items => items;

    public Section(string name)
    {
        Name = name;
    }

    public void Add(Item item)
    {
        item.Section?.Remove(item);
        items.Add(item);
        item.Section = this;
    }

    public void Remove(Item item)
    {
        if (items.Remove(item))
            item.Section = null;
    }

    public override string ToString()
    {
        return $"{Name} ({items.Count} items)";
    }
}
