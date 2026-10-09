namespace Howest.AiDriven.Ex07.Models;


public class SavingsAccount : Account
{
    public const decimal InterestRate = 0.015m;

    public SavingsAccount(string accountnumber) : base(accountnumber)
    {
    }
    public void AddYearlyIntrest()
    {
        balance += balance * InterestRate;
    }
}