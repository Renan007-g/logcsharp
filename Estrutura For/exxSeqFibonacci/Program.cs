ulong numA = 0;
ulong numB = 1;
ulong acumulador = 0;

for(int seq = 1; seq <= 30; seq++)
{
    System.Console.Write($"{acumulador}, ");
    acumulador = numA + numB;
    numB = numA;
    numA = acumulador;
}


/*int z = 0;
int u = 1;

for(int seq = 0; seq <= 30; seq++)
{
    for(int u = 1; )
}*/