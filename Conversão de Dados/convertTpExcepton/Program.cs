namespace convertTpExcepton;

class Program
{
    static void Main(string[] args)
    {
        double x = 97;
        char y;

        try
        {
            y = Convert.ToChar(x);
            System.Console.WriteLine($"O valor {x} do tipo {x.GetType()} foi convertido para o valor {y} do tipo {y.GetType()}");
        }
        catch(FormatException e)
        {
            System.Console.WriteLine($"{e.Message}: {x}");
        }
        catch(OverflowException e)
        {
            System.Console.WriteLine($"{e.Message}: {x}");
            //Value was either too large or too small for an Int32.: 58182810050414
        }
        catch(InvalidCastException e)
        {
            System.Console.WriteLine($"{e.Message}: {x}");
        }
    }
}
