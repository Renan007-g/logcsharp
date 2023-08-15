namespace tpTipoFlu;

class Program
{
    static void Main(string[] args)
    {
        float valorFloat = 26.5f + 0.11f + 0.11f + 0.11f + 0.11f + 0.11f + 0.11f + 0.11f;
        double valorDouble = 26.5d + 0.11 + 0.11 + 0.11 + 0.11 + 0.11 + 0.11 + 0.11;
        decimal valorDecimal = 26.5m + 0.11m + 0.11m + 0.11m + 0.11m + 0.11m + 0.11m + 0.11m;

        System.Console.WriteLine($"\n A soma dos valores no tipo Float deu: {valorFloat}.\n A soma dos valores no tipo Double deu: {valorDouble}. \n A soma dos valores no tipo Decimal deu: {valorDecimal}. ");
    }
}
