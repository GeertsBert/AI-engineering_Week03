namespace Howest.AiDriven.Ex07.Models;

public class Account
{
    protected decimal balance;
    public decimal Balance { get { return balance; } }
    public string AccountNumber { get; }
    public readonly DateTime OpenedAt = DateTime.Now;

    public Account(string accountnumber)
    {
        AccountNumber = accountnumber;
    }
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }

    }
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"New balance: {balance}");
    }
}