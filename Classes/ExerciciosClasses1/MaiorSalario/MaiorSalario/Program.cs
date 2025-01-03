using MaiorSalario;
using System.Globalization;

Funcionario x, y;
x = new Funcionario();
y = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário: ");
Console.WriteLine("Nome: ");
x.Nome = Console.ReadLine();
Console.WriteLine("Salário: ");
x.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário: ");
Console.WriteLine("Nome: ");
y.Nome = Console.ReadLine();
Console.WriteLine("Salário: ");
y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Salário médio = {((x.Salario+y.Salario)/2.0).ToString("F2",CultureInfo.InvariantCulture)}");