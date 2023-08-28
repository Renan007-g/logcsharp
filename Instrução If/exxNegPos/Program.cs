namespace exxNegPos;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite um numero positivo ou negativo: ");
        float num = Convert.ToSingle(Console.ReadLine());

        if( num >= 0)
        {
            System.Console.WriteLine($"O numero {num} é positivo");
        }
        else
        {
            System.Console.WriteLine($"O numero {num} é negativo");
        }
    }
}
