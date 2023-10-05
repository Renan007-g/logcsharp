string tipo;
decimal numA;
decimal numB;


System.Console.WriteLine("\n1) Adição");
System.Console.WriteLine("2) Subtração");
System.Console.WriteLine("3) Divisão");
System.Console.WriteLine("4) Multiplicação");
System.Console.WriteLine("Digite qual tipo da operação:");
tipo = Console.ReadLine();

tipo = tipo.ToLower();

switch(tipo)
{
    case "1":
        System.Console.WriteLine("Digite a parcela: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite a outra parcela: ");
        numB = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"A soma entre {numA} + {numB} =  {(numA + numB).ToString("N2")}");
        break;

    case "2":
        System.Console.WriteLine("Digite o minuendo: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o subtraendo: ");
        numB = Convert.ToInt32(Console.ReadLine());
        

        System.Console.WriteLine($"A subtração entre {numA} - {numB} = {(numA - numB).ToString("N2")}");
        break;

    case "3":
        System.Console.WriteLine("Digite o dividendo: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o divisor: ");
        numB = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"A divisão entre {numA} / {numB} = {(numA / numB).ToString("N2")}");
        break;

    case "4":
        System.Console.WriteLine("Digite o multiplicando: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o multiplicador: ");
        numB = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"A multiplicação entre {numA} X {numB} = {(numA * numB).ToString("N2")}");
        break;

    default:
        System.Console.WriteLine("O tipo de operação está incorreto");
        break;
}
