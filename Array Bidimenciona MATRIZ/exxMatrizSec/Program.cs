int[,] matriz = new int[5,5];

/*for(int i = 0; i < matriz.GetLength(0) ; i++)
{
    for(int j = 0; j < matriz.GetLength(1); j++ )
    {
        matriz[i,j] = 0;
    }
}*/ 

/*for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if(i + j == 4 )
        {
            matriz[i,j] = 1;
        }
        System.Console.Write($"{matriz[i,j]}\t ");
    }
    System.Console.WriteLine();
}
/*matriz.GetLength(0)*/

//OU: 

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if(j == matriz.GetLength(1) - 1 - i )
        {
            matriz[i,j] = 1;
        }
        else
        {
            matriz[i,j] = 0;
        }
        System.Console.Write($"{matriz[i,j]}\t ");
    }
    System.Console.WriteLine();
}