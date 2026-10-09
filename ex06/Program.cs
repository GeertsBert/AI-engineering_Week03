
ComicBook first = new ComicBook("Watchmen", 1986, 29.95, "DC Comics", "Alan Moore");
ComicBook second = new ComicBook("Watchmen", 1986, 29.95, "DC Comics", "Alan Moore");
List<Collectible> collectibles = new List<Collectible> { first, second };



HashSet<ComicBook> books = new HashSet<ComicBook>();
books.Add(first);
books.Add(second);

Console.WriteLine(books.Count);
Console.WriteLine(first == second);
Console.WriteLine(first.Equals(second));

//  the count changed because at first we were counting every individual item, but now we put every
//  item with the same author and name in a bucket and count the buckets instead