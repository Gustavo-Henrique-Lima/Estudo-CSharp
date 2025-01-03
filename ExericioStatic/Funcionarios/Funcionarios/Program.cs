using Funcionarios;
using System.Collections.Generic;
using System.Globalization;

List<Employee> employees = new List<Employee>();
Console.Write("How many employees will be registered? ");
int qtd = int.Parse(Console.ReadLine());
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Employee #{i+1}: ");
    Console.Write("Id: ");
    int ind = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Employee e = new(ind, name, salario);
    employees.Add(e);
    Console.WriteLine("");
}
Console.WriteLine("");
Console.Write("Enter the employee id that will have salary increase: ");
int id = int.Parse(Console.ReadLine());

Employee employee = employees.Find(x => x.Id == id);
if(employee != null)
{
    Console.Write("Enter the percentage: ");
    double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    int posicao = employees.FindIndex(x => x.Id == id);

    employee.AumentarSalario(p);
    employees.RemoveAt(posicao);
    employees.Insert(posicao, employee);
}
else
{
    Console.WriteLine("This id does not exist!");
}

    
Console.WriteLine("");
Console.WriteLine("Update list of employees: ");
foreach (Employee obj in employees)
{
    Console.WriteLine(obj.ToString());
}