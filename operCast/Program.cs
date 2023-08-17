namespace operCast;

class Program
{
    static void Main(string[] args)
    {
        long x = 987;
        int y = (int) x;

        System.Console.WriteLine($"O valor {x} do tipo {x.GetType()} foi convertido para {y} do tipo {y.GetType()}");
    }
}
