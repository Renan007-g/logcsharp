int num;
int contador = 0;

while(contador < 3)
{
    System.Console.Write("\n Digite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());
    contador += 1;

    if(num < 30 || num > 50)
    {
        System.Console.WriteLine(num);
    }
    /*else if(num > 50)
    {
        System.Console.WriteLine(num);
    }*///metodo sem operador relacional
}
