namespace tpint;

class Program
{
    static void Main(string[] args)
    {
        string hotelNome;
        ushort hotelHmetros;
        byte hotelQuantAndar;
        int andarHosp;
        int numeroHosp;

        System.Console.WriteLine("\n****** Cadastro de Hotel *****");

        Console.Write("Digite o Nome do hotel desejado: ");
        hotelNome = Console.ReadLine();

        Console.Write("Digite a altura do hotel em metros: ");
        string hotelHmetrosObtidos = Console.ReadLine();
        hotelHmetros = Convert.ToUInt16(hotelHmetrosObtidos);

        Console.Write("Digite a quantidade de andares do Hotel: ");
        hotelQuantAndar = Convert.ToByte(Console.ReadLine());
        //string hotelQuantAndarObitidos = Console.ReadLine();
        //hotelQuantAndar = Convert.ToByte(hotelQuantAndarObitidos);

        /*Console.Write("Digite O andar desejado para hospedagem: ");
        andarHosp = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nDigite o numero do quarto desejado: ");
        numeroHosp = Convert.ToInt32(Console.ReadLine());*/

        System.Console.WriteLine("\nSeu cadastro foi efetuado com sucesso!");
        System.Console.WriteLine($"Hotel: {hotelNome}. Altura do hotel em metros {hotelHmetros}. Quantidade de quartos {hotelQuantAndar}.");
        // Andar e numero do quarto hospedado{andarHosp + numeroHosp}
    }
}
