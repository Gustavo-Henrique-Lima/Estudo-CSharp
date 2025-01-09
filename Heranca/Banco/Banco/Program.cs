using Banco.entities;

BusinessAccount acount = new(8010, "Alex Brown", 100.0, 500.0);
Console.WriteLine(acount.Balance);
//acount.Balance = 500;