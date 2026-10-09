SavingsAccount account = new SavingsAccount("BE11 2222 3333 4444");
account.Deposit(500);
account.AddYearlyIntrest();
Console.WriteLine(account.Balance);
Console.WriteLine(SavingsAccount.InterestRate);


List<Account> accounts = new List<Account>
{
    new Account("BE22 2222 3333 4444"),
    new SavingsAccount("BE11 2222 3333 4444")
};

foreach (var acc in accounts)
{
    acc.Deposit(6000);
    if (acc is SavingsAccount savings) savings.AddYearlyIntrest();
    Console.WriteLine(acc.Balance);
}
//"Cannot create an instance of the abstract type or interface 'Account'"