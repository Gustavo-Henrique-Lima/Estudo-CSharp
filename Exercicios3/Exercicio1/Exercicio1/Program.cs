int password = 2002;
int guessPass = int.Parse(Console.ReadLine());
while (guessPass != password)
{
    Console.WriteLine("Senha Invalida");
    guessPass = int.Parse(Console.ReadLine());  
}
Console.WriteLine("Acesso Permitido");