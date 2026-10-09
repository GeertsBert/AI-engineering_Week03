namespace Howest.AiDriven.Ex08.Models.Library1;

public class Loan
{
    public const int LoanPeriodInDays = 14;

    public Book Book { get; }
    public Member Member { get; }
    public DateTime LoanDate { get; }
    public DateTime DueDate { get; }
    public DateTime? ReturnDate { get; private set; }

    public bool IsReturned => ReturnDate != null;

    public Loan(Book book, Member member, DateTime loandate)
    {
        Book = book;
        Member = member;
        LoanDate = loandate;
        DueDate = loandate.AddDays(LoanPeriodInDays);
    }

    public void MarkReturned(DateTime returndate)
    {
        ReturnDate = returndate;
    }

    public bool IsOverdue(DateTime today)
    {
        return !IsReturned && today > DueDate;
    }

    public override string ToString()
    {
        string status = IsReturned ? $"returned {ReturnDate:dd/MM/yyyy}" : $"due {DueDate:dd/MM/yyyy}";
        return $"{Book.Title} -> {Member.Name} ({status})";
    }
}
