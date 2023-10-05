using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

string mes = "";

System.Console.Write("Digite o nome de um mes: ");
mes = Console.ReadLine();

switch(mes)
{
    case "fevereiro":
        System.Console.WriteLine($"O mes de {mes} possui 28 ou 29 dias.");
        break;

    case "abril":
    case "junho":
    case "setembro":
    case "novembro":
        System.Console.WriteLine($"O mes de {mes} possui 30 dias.");
        break;

    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        System.Console.WriteLine($"O mes de {mes} possui 31 dias.");
        break;

    default:
        System.Console.WriteLine("O valor digitado não corresponde a nenhum mes");
        break;

}