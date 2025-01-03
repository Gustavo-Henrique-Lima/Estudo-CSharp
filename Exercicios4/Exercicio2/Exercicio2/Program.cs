int qtd = int.Parse(Console.ReadLine());
int qtdIn = 0;
int qtdOut = 0;
for(int i = 0; i<qtd; i++)
{
    int num = int.Parse(Console.ReadLine());
    if(num<10 || num > 20)
    {
        qtdOut++;
    }
    else
    {
        qtdIn++;
    }
}
Console.WriteLine($"{qtdIn} in");
Console.WriteLine($"{qtdOut} out");