using SalaDeAula;
using System.Globalization;

Aluno aluno = new();

Console.Write("Nome do aluno: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
double n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota1 = n1;
aluno.Nota2 = n2;
aluno.Nota3 = n3;
Console.WriteLine(aluno.CalcularMedia());