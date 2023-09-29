int[,] quadBinarios = new int[5,5];


for(int i = 0; i < 5; i++ )
{
    for(int j = 0; j < 5; j++)
    {
        if(i == j)
        {
            quadBinarios[i,j] = 1;
        }
        else
        {
            quadBinarios[i,j] = 0;
        }
    }
}

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        System.Console.Write($"{quadBinarios[i, j]}\t ");//Não esquecer do espaço e do CW vazio
    }
    System.Console.WriteLine();
}
