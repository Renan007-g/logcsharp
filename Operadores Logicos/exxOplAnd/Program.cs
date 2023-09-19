int num;
int contador = 0;

while(contador < 3)
{
    System.Console.Write("\nDigite um numero: ");
    num = Convert.ToInt32(Console.ReadLine());

    if(num > 30 && num < 50)
    {
        System.Console.WriteLine(num);
    }
    contador += 1;
}