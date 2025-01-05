using Pedido.Entities;
using Pedido.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth Date (DD/MM/YYYY): ");
string date = Console.ReadLine();
DateTime birthDate = DateTime.Parse(date);
Client client = new(name, email, birthDate);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
string status = Console.ReadLine();

Order order = new(DateTime.Now, Enum.Parse<OrderStatus>(status.ToUpper()), client);

Console.Write("How many items to this order? ");
int qtd = int.Parse(Console.ReadLine());
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Enter #{i + 1} item data");
    Console.Write("Product name: ");
    string pName = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int pQtd = int.Parse(Console.ReadLine());
    Product product = new(pName, price);
    OrderItem orderItem = new(pQtd, price, product);
    order.AddItem(orderItem);
}
Console.WriteLine("");
Console.WriteLine("ORDER SUMMARY: ");
Console.WriteLine($"Order moment: {order.Moment}");
Console.WriteLine($"Order status: {order.Status}");
Console.WriteLine($"Client: {client.ToString()}");
Console.WriteLine("Order items: ");
double sum = 0.0;

foreach (OrderItem or in order.Items)
{
    Console.WriteLine(or.ToString());
    sum += or.SubTotal();
}

Console.WriteLine($"Total Price: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");