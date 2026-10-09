using L2 = Howest.AiDriven.Ex08.Models.Library2;

Console.WriteLine("=== Library 1: books, members and loans ===");
Library library = new Library();

Book hobbit = new Book("978-0261102217", "The Hobbit", "J.R.R. Tolkien", 1937);
Book dune = new Book("978-0441172719", "Dune", "Frank Herbert", 1965);
Book nineteen84 = new Book("978-0451524935", "1984", "George Orwell", 1949);
library.AddBook(hobbit);
library.AddBook(dune);
library.AddBook(nineteen84);

Member anna = new Member(1, "Anna");
Member bram = new Member(2, "Bram");
library.AddMember(anna);
library.AddMember(bram);

DateTime start = new DateTime(2026, 10, 1);
library.Lend(hobbit, anna, start);
library.Lend(dune, bram, start);

try
{
    library.Lend(hobbit, bram, start);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Could not lend: {ex.Message}");
}

library.Return(dune, start.AddDays(7));

Console.WriteLine("\nAvailable books:");
foreach (var book in library.GetAvailableBooks())
    Console.WriteLine($"  {book}");

Console.WriteLine($"\nOverdue on {start.AddDays(20):dd/MM/yyyy}:");
foreach (var loan in library.GetOverdueLoans(start.AddDays(20)))
    Console.WriteLine($"  {loan}");

Console.WriteLine("\n=== Library 2: items, members and sections ===");

L2.Section fantasy = new L2.Section("Fantasy");
L2.Section sciFi = new L2.Section("Science Fiction");

L2.Book lotr = new L2.Book(1, "The Lord of the Rings", 1954, "J.R.R. Tolkien", 1178);
L2.Dvd lotrDvd = new L2.Dvd(2, "The Fellowship of the Ring", 2001, "Peter Jackson", 178);
L2.Comic sandman = new L2.Comic(3, "The Sandman", 1989, "Neil Gaiman", "DC Comics", 1);
L2.Book foundation = new L2.Book(4, "Foundation", 1951, "Isaac Asimov", 255);
L2.Dvd interstellar = new L2.Dvd(5, "Interstellar", 2014, "Christopher Nolan", 169);

fantasy.Add(lotr);
fantasy.Add(lotrDvd);
fantasy.Add(sandman);
sciFi.Add(foundation);
sciFi.Add(interstellar);

L2.Member lotte = new L2.Member(1, "Lotte");
L2.Member jonas = new L2.Member(2, "Jonas");

lotte.Borrow(lotrDvd);
jonas.Borrow(foundation);

try
{
    jonas.Borrow(lotrDvd);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"Could not borrow: {ex.Message}");
}

foreach (var section in new List<L2.Section> { fantasy, sciFi })
{
    Console.WriteLine($"\n{section}");
    foreach (var item in section.Items)
        Console.WriteLine($"  {item}");
}

Console.WriteLine($"\n{lotte.Name} has borrowed:");
foreach (var item in lotte.BorrowedItems)
    Console.WriteLine($"  {item.Title} from {item.Section?.Name}");
