namespace obtndd;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome do professor: ");
        var nprof = Console.ReadLine();
        var nomemaiuscl = nprof!.ToUpper();
        Console.WriteLine($"O nome do professor é {nomemaiuscl}.");
    }
}
