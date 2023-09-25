bool primo;

for(int contador = 2; contador <= 1000; contador++)
{
    primo = true;

    for(int divisor = 2; divisor <= contador/2; divisor++)
    {
        if(contador % divisor == 0)
        {
            primo = false;
            break;
        }
    }
    if(primo)
    {
        System.Console.Write($"{contador}, ");
    }
    
}



/*int numax = 10;

for(int numax = 2; numax < 1000; numax++)
{
    for(int contador = 2; contador <= numax;contador++)
    {
        if(numax % contador != 0)
        {
            System.Console.WriteLine(contador);
        }
    }
}*/