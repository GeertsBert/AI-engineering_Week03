namespace Howest.AiDriven.Ex08.Models.Library1;

public class Library
{
    private readonly List<Book> books = new List<Book>();
    private readonly List<Member> members = new List<Member>();
    private readonly List<Loan> loans = new List<Loan>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void AddMember(Member member)
    {
        members.Add(member);
    }

    public bool IsAvailable(Book book)
    {
        return !loans.Any(l => l.Book == book && !l.IsReturned);
    }

    public Loan Lend(Book book, Member member, DateTime date)
    {
        if (!books.Contains(book))
            throw new InvalidOperationException($"{book.Title} is not part of this library");
        if (!members.Contains(member))
            throw new InvalidOperationException($"{member.Name} is not a member");
        if (!IsAvailable(book))
            throw new InvalidOperationException($"{book.Title} is already on loan");
        if (GetActiveLoans(member).Count >= Member.MaxLoans)
            throw new InvalidOperationException($"{member.Name} already has {Member.MaxLoans} books on loan");

        Loan loan = new Loan(book, member, date);
        loans.Add(loan);
        return loan;
    }

    public void Return(Book book, DateTime date)
    {
        Loan? loan = loans.FirstOrDefault(l => l.Book == book && !l.IsReturned);
        if (loan == null)
            throw new InvalidOperationException($"{book.Title} is not on loan");

        loan.MarkReturned(date);
    }

    public List<Book> GetAvailableBooks()
    {
        return books.Where(IsAvailable).ToList();
    }

    public List<Loan> GetActiveLoans(Member member)
    {
        return loans.Where(l => l.Member == member && !l.IsReturned).ToList();
    }

    public List<Loan> GetOverdueLoans(DateTime today)
    {
        return loans.Where(l => l.IsOverdue(today)).ToList();
    }
}
