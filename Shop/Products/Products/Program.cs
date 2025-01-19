using Products.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int qtd = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();

for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Product #{i + 1} data");
    Console.Write("Common, used, or imported (c/u/i)? ");
    char type = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (type == 'c')
    {
        Product commomProduct = new(name, price);
        products.Add(commomProduct);
    }
    else if(type == 'i')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ImportedProduct importProduct = new(name, price, customFee);
        products.Add(importProduct);
    }
    else
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        string date = Console.ReadLine();
        UsedProduct usedProduct = new(name, price, DateTime.Parse(date));
        products.Add(usedProduct);
    }
}
Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach(Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
