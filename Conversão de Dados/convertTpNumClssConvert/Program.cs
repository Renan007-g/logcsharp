namespace convertTpNumClssConvert;

class Program
{
    static void Main(string[] args)
    {
        double x = 97.50;
        int y = Convert.ToInt32(x);
        System.Console.WriteLine($"O valor {x} do tipo {x.GetType()} foi convertido para o valor {y} do tipo {y.GetType()}");
    }
}
