int valMax;
int contEx = 0;
int contin = 1; 

System.Console.Write("Digite um numero: ");
valMax = Convert.ToInt32(Console.ReadLine());

while(contEx <= valMax)
{
    System.Console.WriteLine();
    while( contin <= valMax - contEx)
    {
        Console.Write(contin + " ");
        contin += 1;
    }
    contEx += 1;
    contin = 1;
}

/*int numuser;
int valin = 1;
int valout = 0;

System.Console.Write("Digite um numero: ");
numuser = Convert.ToInt32(Console.ReadLine());

while(numuser >  valout)
{
    System.Console.WriteLine();
    while(numuser - valout >= valin)
    {
        System.Console.Write(valin + " ");
        valin += 1;
    }
    valout += 1;
    valin = 1;
}*/