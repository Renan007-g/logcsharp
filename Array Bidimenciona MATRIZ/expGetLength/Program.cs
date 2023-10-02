int[] vetor = new int[5];
int[,] matriz = new int[5,4];

//System.Console.WriteLine(vetor.Length);
System.Console.WriteLine($"O numero de linha é {matriz.GetLength(0)}");
System.Console.WriteLine($"O numero de Colunas é {matriz.GetLength(1)}");

for(int i = 0; i < matriz.GetLength(0); i++)
{
    for(int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i,j] = 1;
        System.Console.Write($"{matriz[i,j]}\t ");
    }
    System.Console.WriteLine();
}
