namespace metodoTryParse;

class Program
{
    static void Main(string[] args)
    {
        string valor = "35,65";
        decimal resultado = 5;
        bool sucesso = true;

        sucesso = decimal.TryParse(valor, out resultado);

        /*if(sucesso )
        {
            System.Console.WriteLine("Valor {0} convertido para {1} com sucesso!", valor, resultado);
        }
        else
        {
            System.Console.WriteLine("Tentaiva de conversão do valor {0}falhou.", valor, resultado);
        }*/
    }
}
