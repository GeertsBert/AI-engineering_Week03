List<Collectible> collectibles = new List<Collectible>
{
    new Wine("Chianti Classico", 2019, 18.50, 5.00, "Italy", WineType.Red),
    new Wine("Sancerre", 2021, 24.90, 6.50, "France", WineType.White),
    new Wine("Cava Brut", 2022, 12.75, 4.00, "Spain", WineType.Sparkling),
    new PostStamp("Penny Black", 1840, 2500.00, "penny_black.png"),
    new PostStamp("Inverted Jenny", 1918, 1500000.00, "inverted_jenny.png"),
    new PostStamp("Belgian Lion", 1951, 3.20, "belgian_lion.png"),
    new ComicBook("Tintin in Tibet", 1960, 14.99, "Casterman", "Hergé"),
    new ComicBook("Asterix the Gaul", 1961, 9.99, "Dargaud", "René Goscinny"),
    new ComicBook("Watchmen", 1986, 29.95, "DC Comics", "Alan Moore")
};

collectibles.Sort();
foreach (var item in collectibles)
{
    Console.WriteLine(item.ToString());
}