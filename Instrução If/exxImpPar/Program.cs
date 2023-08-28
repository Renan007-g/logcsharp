int num;

System.Console.Write("Digite um numero: ");
num = Convert.ToInt32(Console.ReadLine());
int res = num % 2;
bool compar = res == 0;

if( compar)
{
    System.Console.WriteLine($"O numero {num} é par");
}
else
{
    System.Console.WriteLine($"O numero {num} é impar");
}
