namespace ConvertTpBool;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        bool y = Convert.ToBoolean(x);
        System.Console.WriteLine($"O valor {x} do tipo {x.GetType()} foi Convertido para o valor {y} do tipo {y.GetType}. ");
    }
}
