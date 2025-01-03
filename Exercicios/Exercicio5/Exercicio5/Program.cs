using System.Globalization;

string[] vet = Console.ReadLine().Split(' ');
int codigo1 = int.Parse(vet[0]);
int qtd1 = int.Parse(vet[1]);
double valor1 = double.Parse(vet[2],CultureInfo.InvariantCulture);
string[] vet2 = Console.ReadLine().Split(' ');
int codigo2 = int.Parse(vet2[0]);
int qtd2 = int.Parse(vet2[1]);
double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);
double soma = qtd1 * valor1 + qtd2 * valor2;
Console.WriteLine($"VALOR A PAGAR: R$ ${soma.ToString("F2",CultureInfo.InvariantCulture)}");
