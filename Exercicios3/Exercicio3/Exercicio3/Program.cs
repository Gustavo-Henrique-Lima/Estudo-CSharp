int qtdAlcool = 0;
int qtdGasolina = 0;
int qtdDiesel = 0;

int opcao = int.Parse(Console.ReadLine()); 

while (opcao != 4)
{
    switch (opcao) {
        case 1:
            qtdAlcool++;
            break;
        case 2: 
            qtdGasolina++;
            break;
        case 3:
            qtdDiesel++;
            break;
    }
    opcao = int.Parse(Console.ReadLine());
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {qtdAlcool}");
Console.WriteLine($"Gasolina: {qtdGasolina}");
Console.WriteLine($"Diesel: {qtdDiesel}");