using Banco.Entities;
using System.Collections.Generic;
using System.Globalization;

List<Account> accounts = new List<Account>();

accounts.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
accounts.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
accounts.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
accounts.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

double sum = 0.0;

foreach (Account acc in accounts)
{
    sum += acc.Balance;
}
Console.WriteLine($"Total balance: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

foreach (Account acc in accounts)
{
    acc.WithDraw(10);
}

foreach (Account acc in accounts)
{
    Console.WriteLine("Update balance for account " + acc.Number + ": " + acc.Balance);
}