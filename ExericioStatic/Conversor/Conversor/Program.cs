using Conversor;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? ");
double dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double total = ConversorDeMoeda.Converter(dolar, qtd);
Console.WriteLine($"Valor a ser pago em reais = {total.ToString("F2", CultureInfo.InvariantCulture)}");