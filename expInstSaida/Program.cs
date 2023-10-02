int nota;
string avaliacao = "";

System.Console.WriteLine("\nSelecione uma nota: ");
System.Console.WriteLine("1 - Péssimo");
System.Console.WriteLine("2 - Ruim");
System.Console.WriteLine("3 - Satisfatório");
System.Console.WriteLine("4 - Bom");
System.Console.WriteLine("5 - Execelente");

System.Console.WriteLine("\nNota: ");
nota = Convert.ToInt32(Console.ReadLine());

switch(nota /*seletor*/)
{
    case 1: 
        avaliacao = "Péssimo";
        break;
    
    case 2:
        avaliacao = "Ruim";
        return;
    
    case 3: 
        avaliacao = "Satisfatório";
        goto Sair;

    case 4:
        avaliacao = "Bom";
        break;

    case 5:
        avaliacao = "Execlente";
        break;
}

Sair:
System.Console.WriteLine($"\nO atendimento foi considerado {avaliacao}.");