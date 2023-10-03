string tipo;
int numA;
int numB;


System.Console.WriteLine("Digite qual tipo da operação(soma, subtração, divisão e multiplicação.)");
tipo = Console.ReadLine();

tipo = tipo.ToLower();

switch(tipo)
{
    case "soma":
        System.Console.WriteLine("Digite a parcela: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite a outra parcela: ");
        numB = Convert.ToInt32(Console.ReadLine());
        break;

    case "subtração":
        System.Console.WriteLine("Digite o minuendo: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o subtraendo: ");
        numB = Convert.ToInt32(Console.ReadLine());
        break;

    case "divisão":
        System.Console.WriteLine("Digite o dividendo: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o divisor: ");
        numB = Convert.ToInt32(Console.ReadLine());
        break;

    case "multiplição":
        System.Console.WriteLine("Digite o multiplicando: ");
        numA = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Digite o multiplicador: ");
        numB = Convert.ToInt32(Console.ReadLine());
        break;

    default:
        System.Console.WriteLine("O tipo de operação está incorreto");
        break;
}


switch(tipo)
{
    case "soma":
        System.Console.WriteLine($"A subtração entre {numA} + {numB} = {numA - numB}");
        break;

    case "subtração":
        System.Console.WriteLine($"A subtração entre {numA} - {numB} = {numA - numB}");
        break;

    case "divisão":
        System.Console.WriteLine($"A divisão entre {numA} / {numB} = {numA / numB}");
        break;

    case "multiplição":
        System.Console.WriteLine($"A multiplicação entre {numA} * {numB} = {numA * numB}");
        break;

    default:
        System.Console.WriteLine("O tipo de operação está incorreto");
        break;
}