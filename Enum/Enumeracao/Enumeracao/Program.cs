using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

Order order = new Order {
     Id = 1080,
     Moment = DateTime.Now,
     Status = OrderStatus.PendingPayment
 };

Console.WriteLine(order);

Order order1 = new(1060, DateTime.Now, OrderStatus.Shipped);

Console.WriteLine(order1);

string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
Console.WriteLine(os);