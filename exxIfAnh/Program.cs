System.Console.WriteLine("Digite um número: ");
float num = Convert.ToSingle(Console.ReadLine());

if( num % 2 == 0)
{
    if( num >= 0)
    {
        System.Console.WriteLine($"O numero {num} é par positivo");
    }
    else
    {
        System.Console.WriteLine($"O num {num} é par negativo");
    }
}
else
{
    if( num >= 0 )
    {
        System.Console.WriteLine($"O numero {num} é impar positivo");
    } 
    else{
        System.Console.WriteLine($"O numero {num} é impar negativo");
    }
}
