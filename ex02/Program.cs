Book book = new Book(1,"le book",2026,"Me");
Magazine magazine = new Magazine(2,"le magazine",2026,2);
DvD dvd = new DvD(3,"le dvd",2026,45);

List<LibraryItem> libraryItems = new List<LibraryItem> {book, magazine, dvd};

foreach (var item in libraryItems)
{
    item.PrintDetails();
}