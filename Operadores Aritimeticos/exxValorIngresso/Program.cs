using System.Reflection;

namespace exxValorIngresso;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("### Valor dos ingressos: 59.90 ###");
        System.Console.WriteLine("Quantidade maxima de ingressos: 20");
        System.Console.WriteLine("Digite a quantidade de ingressos desejados: ");
        double quantIng = Convert.ToDouble(Console.ReadLine());
        double valoraPag = 59.90 * quantIng;

        if(quantIng > 20)
        {
            System.Console.WriteLine("Você execedeu a quantidade maxima de ingressos");
        }
        else if(quantIng <= 0)
        {
            System.Console.WriteLine("Digite uma quantidade valida de ingressos");
        }
        else
        {
            System.Console.WriteLine($"O valor a pagar por {quantIng} ingressos é de {valoraPag}");
        }
        
    }
}
