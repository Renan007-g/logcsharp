namespace ConvertCarctertoClass;

class Program
{
    static void Main(string[] args)
    {
        string x = "B";
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
        }
        catch(InvalidCastException e)
        {
            System.Console.WriteLine($"{e.Message}: {x}");
        }
    }
}
