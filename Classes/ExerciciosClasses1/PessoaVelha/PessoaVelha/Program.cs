using PessoaVelha;

Pessoa x, y;
x = new Pessoa();
y=new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.WriteLine("Nome: ");
x.name = Console.ReadLine();
Console.WriteLine("Idade: ");
x.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa: ");
Console.WriteLine("Nome: ");
y.name = Console.ReadLine();
Console.WriteLine("Idade: ");
y.idade = int.Parse(Console.ReadLine());

Console.WriteLine(x.idade > y.idade ? $"Pessoa mais velha {x.name}" : $"Pessoa mais velha ${y.name}");