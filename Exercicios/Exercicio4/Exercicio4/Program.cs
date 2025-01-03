using System.Globalization;

int number = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
double salary = hours * value;
Console.WriteLine("NUMBER = " + number);
Console.WriteLine($"SALARY = U$ {salary.ToString("F2",CultureInfo.InvariantCulture)}");