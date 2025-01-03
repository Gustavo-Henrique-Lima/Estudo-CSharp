using Produto;
using System.Globalization;

Prod produto = new();

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
produto.Nome = Console.ReadLine();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + produto);

Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
int qtd = int.Parse(Console.ReadLine());

produto.AdicionarProdutos(qtd);

Console.WriteLine("Dados atualizados: " + produto);

Console.Write("Digite o número de produtos a serem removidos ao estoque: ");
qtd = int.Parse(Console.ReadLine());

produto.RemoverProdutos(qtd);

Console.WriteLine("Dados atualizados: " + produto);
