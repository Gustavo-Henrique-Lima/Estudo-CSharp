using Pessoa;
using System.Globalization;

Funcionario funcionario = new();
Console.Write("NOME: ");
string nome = Console.ReadLine();
Console.Write("Salário bruto: ");
double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto: ");
double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
funcionario.Nome = nome;
funcionario.SalarioBruto = salario;
funcionario.Imposto = imposto;

Console.WriteLine("Funcionário: "+funcionario.ToString());

Console.Write("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
funcionario.AumentarSalario(porcentagem);

Console.WriteLine("Dados atualizados: " + funcionario.ToString());