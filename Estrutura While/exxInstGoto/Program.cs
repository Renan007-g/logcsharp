using System.Runtime.InteropServices.Marshalling;

String nome;
String cont;

inicio:
System.Console.WriteLine("\n #######################");
System.Console.WriteLine("Qual seu nome?");
nome = Console.ReadLine();

System.Console.WriteLine($"Olá {nome}");

Console.WriteLine("Se deseja continuar digite S[Sim] Ou N[Não] se deseja encerrar.");
cont = Console.ReadLine();
if(cont == "S" || cont == "s")
{
    goto inicio;
}
