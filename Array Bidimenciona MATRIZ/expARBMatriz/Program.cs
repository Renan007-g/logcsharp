bool[,] CineCadeiras = new bool[5,4];//Aula 137

for(int i = 0; i < 5; i++)//Laço externo representando linhas
{
    for(int j = 0; j < 4; j++)//laço interno representando colunas
    {
        CineCadeiras[i, j] = true;
    }
    
}

//Ou ao contrario:

/*for(int j = 0; j < 4; j++)//Laço externo representando linhas
{
    for(int i = 0; i < 5; i++)//laço interno representando colunas
    {
        CineCadeiras[i, j] = true;
    }              //L  C
                   //i  o
                   //n  l
                   //h  u
                   //a  n
                   //   a
}*/

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 4; j++)
    {
        System.Console.Write($"{CineCadeiras[i, j]}\t ");
    }
    System.Console.WriteLine();
}


