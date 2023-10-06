string canditado;
bool continua;

do{

System.Console.WriteLine("1) Bolso");
System.Console.WriteLine("2) Lula");
System.Console.WriteLine("3) Nikolas");
System.Console.WriteLine("4) Nulo");
System.Console.WriteLine("5) Branco");

System.Console.WriteLine("Digite uma das opções para prefeito: ");
canditado = Console.ReadLine();

Inicio: 
switch(canditado)
{
    case "1":
        System.Console.WriteLine("\nVocê, votou no candidato Bolso. Obrigado\n");
        continua = false;
        break;

    case "2":
        System.Console.WriteLine("\nVocê, votou no candidato Lula. Obrigado\n");
        continua = false;
        break;   
    
    case "3":
        System.Console.WriteLine("\nVocê, votou no candidato Nikolas. Obrigado\n");
        continua = false;
        break;

    case "4":
        System.Console.WriteLine("\nVocê, votou Nulo. Obrigado\n");
        continua = false;
        break;

    case "5":
        System.Console.WriteLine("\nVocê, votou em Branco. Obrigado\n");
        continua = false;
        break;

    default:
        System.Console.WriteLine("Digite um valor valido!");
        continua = true;
        break;
}
}while(continua);
/*do
{
    goto Inicio;
}while(canditado == "0");
*/


