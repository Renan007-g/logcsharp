string opcao;

while(true)
{
    while(true)
    {
        Console.Write("Deseja continuar? [s] sim / [n] não: ");
        opcao = Console.ReadLine();

        if(opcao == "n")
        {
        break;
        }
    }
    System.Console.WriteLine("Laço exeterno");
}