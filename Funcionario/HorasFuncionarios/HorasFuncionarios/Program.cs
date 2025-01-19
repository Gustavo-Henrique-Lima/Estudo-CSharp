using HorasFuncionarios.Entities;
using System.Globalization;

Console.Write("Enter the number of employees: ");
int qtd = int.Parse(Console.ReadLine());
List<Employee> employees = new List<Employee>();
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Empolyee #{i + 1} data");
    Console.Write("Outsourced (y/n)? ");
    char outSorced = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(outSorced == 'n')
    {
        Employee em = new(name, hours, value);
        employees.Add(em);
    }
    else
    {
        Console.Write("Additional charge: ");
        double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        OutsourcedEmployee e = new(name, hours, value, additional);
        employees.Add(e);
    }
}
Console.WriteLine();
Console.WriteLine("Payments: ");
foreach (Employee employee in employees)
{
    double salary = employee.Payment();
    Console.WriteLine($"{employee.Name} - $ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
}
