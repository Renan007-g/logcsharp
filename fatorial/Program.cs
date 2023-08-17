/*namespace fatorial;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um numero inteiro positivo: ");
        int num = Int32.Parse(Console.ReadLine());
        /*Console.ReadLine();
        int num = Convert.ToInt32(Console.ReadLine());*/

        /*if (num < 0)
        {
            System.Console.WriteLine("O numero deve ser positivo");
        }
        else
        {
            int fatorial =CalcularFatorial(num);
            Console.WriteLine($"O fatorial do numero {num} é igual a: {fatorial}");
        }
    }
    static int CalcularFatorial(int n)
    {
        if(n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * CalcularFatorial(n-1);
        }
    }
}*///Meu codigo
namespace CalculadoraFatorial//Codigo GPT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro não negativo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("O número deve ser não negativo.");
            }
            else
            {
                int fatorial = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
            }
        }

        static int CalcularFatorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalcularFatorial(n - 1);
            }
        }
    }
}
