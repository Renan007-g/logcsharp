namespace exxDivsao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("###Divisão###");

        System.Console.WriteLine("Digite o dividendo: ");
        decimal dividendo = Convert.ToDecimal(Console.ReadLine());

        System.Console.WriteLine("Digite o divisor: ");
        decimal divisor = Convert.ToDecimal(Console.ReadLine());

        decimal quociente = dividendo / divisor;
        System.Console.WriteLine($"O a divisão entre {dividendo} e {divisor} é igual a {quociente}");
    }
}
