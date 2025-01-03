string[] dimensao = Console.ReadLine().Split(" ");

int linhas = int.Parse(dimensao[0]);
int colunas = int.Parse(dimensao[1]);

int[,] mat = new int[linhas, colunas];

for (int i = 0; i < linhas; i++)
{
    string[] valores = Console.ReadLine().Split(" ");
    for (int j = 0; j < colunas; j++)
    {
        mat[i, j] = int.Parse(valores[j]);
    }
}

int number = int.Parse(Console.ReadLine());


for (int i = 0; i < linhas; i++)
{
    for (int j = 0; j < colunas; j++)
    {
        int linha = 0;
        int coluna = 0;
        if (mat[i, j] == number)
        {
            linha += i;
            coluna += j;
            Console.WriteLine("Position " + linha + "," + coluna + ":");
            if (coluna != 0)
            {
                Console.WriteLine("Left: " + mat[linha, coluna - 1]);
            }
            if (linha != 0)
            {
                Console.WriteLine("Up: " + mat[linha - 1, coluna]);
            }
            if (coluna + 1 != colunas)
            {
                Console.WriteLine("Right: " + mat[linha, coluna + 1]);
            }
            if(linha + 1 != linhas)
            {
                Console.WriteLine("Down: " + mat[linha + 1, coluna]);
            }
        }
    }
}
