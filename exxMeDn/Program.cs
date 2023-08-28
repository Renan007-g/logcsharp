System.Console.WriteLine("Digite um numero: ");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite outro numero: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if( num1 > num2 )
{
    System.Console.WriteLine($"O numero {num1} é maior que o numero {num2}");
}
else if ( num1 == num2)
{
    Console.WriteLine($"Os numeros {num2} e {num1} são iguais");
}
else
{
    Console.WriteLine($"O numero {num2} é maior que o numero {num1}");
}