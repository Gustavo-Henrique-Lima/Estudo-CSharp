using Salario.entities;
using System.Globalization;
using Salario.entities.enums;

Console.Write("Enter department's name: ");
string departmentName = Console.ReadLine();
Department department = new(departmentName);
Console.WriteLine("Enter Worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
string level = Console.ReadLine();
WorkerLevel wokerLevel = Enum.Parse<WorkerLevel>(level.ToUpper());
Console.Write("Base Salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("How many contract to this worker? ");
Worker worker = new(name, wokerLevel, salary, department);
int qtd = int.Parse(Console.ReadLine());
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Enter #{i + 1} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    string date = Console.ReadLine();
    Console.Write("Value per hour: ");
    double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new(DateTime.Parse(date), value, hours);
    worker.AddContract(contract);
}

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string[] data = Console.ReadLine().Split("/");
Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Department: {worker.Department.Name}");
double total = worker.Income(int.Parse(data[1]), int.Parse(data[0]));
Console.WriteLine($"Income for {data[0]}/{data[1]}: {total.ToString("F2", CultureInfo.InvariantCulture)}");