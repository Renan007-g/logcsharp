int maioridade = 18;
string nome2;
int idade2;

System.Console.Write("\nDigite seu nome: ");
string nome1 = Console.ReadLine();

System.Console.Write("\nDigite sua idade: ");
int idade1 = Convert.ToInt32(Console.ReadLine());



if( idade1 < maioridade)
{
    System.Console.Write("\nDigite o nome do seu responsavel: ");
    nome2 = Console.ReadLine();

    System.Console.Write("\nDigite a idade do seu responsavel: ");
    idade2 = Convert.ToInt32(Console.ReadLine());
    if(idade2 < maioridade)
    {
        System.Console.WriteLine("O responsavel precisa ser maior de idade");
        System.Console.WriteLine("Entrada proibida");
    }
    else
    {
        System.Console.WriteLine($"Bem vindo ao parque {nome1} e {nome2}");
    }
}
else
{
    System.Console.WriteLine($"Bem vindo ao parque {nome1}");
}

