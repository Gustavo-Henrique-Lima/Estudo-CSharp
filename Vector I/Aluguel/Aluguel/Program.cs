using Aluguel;

Console.Write("How many room will be rented? ");
int qtd = int.Parse(Console.ReadLine());
Console.WriteLine();

Rent[] rooms = new Rent[10];
for (int i = 0; i < qtd; i++)
{
    Console.WriteLine($"Rent #{i + 1}: ");
    Console.Write("Name: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());
    rooms[room] = new Rent { Nome = nome, Email = email, Room = room };
    Console.WriteLine();
}

Console.WriteLine("Busy rooms:");
foreach (Rent r in rooms)
{
    if (r != null)
    {
        Console.WriteLine(r.Room + ": " + r.Nome + ", " + r.Email);
    }
}
