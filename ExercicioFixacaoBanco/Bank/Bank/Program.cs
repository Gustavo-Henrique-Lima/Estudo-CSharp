using Bank;
using System.Globalization;

Account c;
Console.Write("Entre o número da conta: ");
string number = Console.ReadLine();
Console.Write("Entre o titular da conta: ");
string owner = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char initial = char.Parse(Console.ReadLine());
if(initial ==  's')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    c = new Account(number, owner, value);
}
else
{
    c = new Account(number, owner);
}

Console.WriteLine();
Console.WriteLine("Dados da conta: ");
Console.WriteLine(c.ToString());

Console.WriteLine();
Console.Write("Entre um valor para depósito: ");
double val_dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c.Depositar(val_dep);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(c.ToString());

Console.WriteLine();
Console.Write("Entre um valor para saque: ");
double val_sac = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();
Console.WriteLine("Dados da conta atualizados: ");
c.Sacar(val_sac);
Console.WriteLine(c.ToString());