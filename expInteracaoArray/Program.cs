String[] alunoNomes = new string[5];

System.Console.WriteLine("Digite o nome dos alunos: ");

for(int indice = 0; indice < 5; indice++)
{
    alunoNomes[indice] = Console.ReadLine();
}

System.Console.WriteLine("\n Lista de Alunos:");

for(int indice = 0; indice < 5; indice++)
{
    System.Console.WriteLine($"Aluno:{alunoNomes[indice]}");
}