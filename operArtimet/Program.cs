namespace operArtimet;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um numero: ");
        int valorA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite outro numero: ");
        int valorB = Convert.ToInt32(Console.ReadLine()) ;

        int res = valorA + valorB;
        System.Console.WriteLine($"A soma entre {valorA} e {valorB} é igual a {res}");
    }
}
