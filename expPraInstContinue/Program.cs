int cont = -1;

while(cont <= 100)
{
    cont += 1;

    if(cont % 2 == 0)
    {
        continue;
    }
    System.Console.WriteLine(cont);
}