using Conta.Entities;

Account acc1 = new(1001, "Alex", 500.00);
Account acc2 = new SavingsAccount(1002, "Ana", 500.00, 0.01);
Account acc3 = new BusinessAccount(1003, "Bob", 500.00, 200.0);

acc1.WithDraw(10.0);
acc2.WithDraw(10.0);
acc3.WithDraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);
Console.WriteLine(acc3.Balance);