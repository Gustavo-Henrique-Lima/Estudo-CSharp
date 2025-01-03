using Retangulo;
using System.Globalization;

Reta r = new Reta();
Console.WriteLine("Entre a largura e a altura do retângulo: ");
double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = altura;
r.Largura = largura;

Console.WriteLine($"AREA = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"PERÍMETRO = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"DIAGONAL = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
