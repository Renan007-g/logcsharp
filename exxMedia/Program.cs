using System.Reflection;

namespace exxMedia;

class Program
{
    static void Main(string[] args)
    {
        float m1;
        float m2;
        float m3;

        System.Console.WriteLine("Digite a nota 1: ");
        m1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite a nota 2: ");
        m2 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite a nota 3: ");
        m3 = Convert.ToSingle(Console.ReadLine());

        float mediaTotal = (m1 + m2 + m3) / 3;
        System.Console.WriteLine($"A média total entre os valores {m1}, {m2} e {m3} é de {mediaTotal}");

    }
}
