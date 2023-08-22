namespace exxSinInv;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Digite um numero positivo ou negativo: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        valor *= -1;
        Console.WriteLine($"O valor adicionado com sinal trocado é {valor}");

        /*if(valor > 0)
        {
            valor *= -1;
        }
        else
        {
            valor *= -1;
        }
        System.Console.WriteLine($"O valor adicionado com sinal trocado é {valor}");*/
    }
}
