using Imposto.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int qtd = int.Parse(Console.ReadLine());
List<Person> persons = new List<Person>();


for (int i = 0; i < qtd; i++)
{
    Person p;
    Console.WriteLine($"Taxer payer #{i + 1} data");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        p = new NaturalPerson(name, anualIncome, healthExpenditures);
        persons.Add(p);
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberEmployees = int.Parse(Console.ReadLine());
        p = new LegalPerson(name, anualIncome, numberEmployees);
        persons.Add(p);
    }
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
double sum = 0.0;
foreach(Person p in persons)
{
    sum += p.CalculateTaxes();
    Console.WriteLine($"{p.Name} $ {p.CalculateTaxes().ToString("F2",CultureInfo.InvariantCulture)}");
}
Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");