string[] vet = Console.ReadLine().Split(" ");
int num1 = int.Parse(vet[0]);
int num2 = int.Parse(vet[1]);
if(num1 % num2 == 0 || num2 % num1 ==0)
{
    Console.WriteLine("Sao Multiplos");
} else
{
    Console.WriteLine("Nao sao Multiplos");
}