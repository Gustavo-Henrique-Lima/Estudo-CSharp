using Bank.Entities;
using Bank.Entities.Exceptions;
using System.Globalization;

try
{
    Console.WriteLine("Enter account data");
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write("Holder: ");
    string holder = Console.ReadLine();
    Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Withdraw limit: ");
    double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Account acc = new(number, holder, initialBalance, withDrawLimit);
    Console.WriteLine();
    Console.Write("Enter amount for withdraw: ");
    double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    acc.WithDraw(withDraw);
    Console.WriteLine($"New balance: {acc.Balance}");
}
catch (DomainException e)
{
    Console.WriteLine($"Withdraw error: {e.Message}");
}