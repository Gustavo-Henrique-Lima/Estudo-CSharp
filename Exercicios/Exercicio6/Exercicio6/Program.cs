using System.Globalization;

string[] vet = Console.ReadLine().Split(" ");
double num1 = double.Parse(vet[0],CultureInfo.InvariantCulture);
double num2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
double num3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

double trianguloRetangulo = num1 * num3 / 2;
double circulo = Math.Pow(num3, 2) * 3.14159;
double trapezio = (num1 + num2) * num3 / 2;
double quadrado = Math.Pow(num2, 2);
double retangulo = num1 * num2;

Console.WriteLine($"TRIANGULO: {trianguloRetangulo.ToString("F3",CultureInfo.InvariantCulture)}");
Console.WriteLine($"CIRCULO: {circulo.ToString("F3",CultureInfo.InvariantCulture)}");
Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3",CultureInfo.InvariantCulture)}");
Console.WriteLine($"QUADRADO: {quadrado.ToString("F3",CultureInfo.InvariantCulture)}");
Console.WriteLine($"RETANGULO: {retangulo.ToString("F3",CultureInfo.InvariantCulture)}");