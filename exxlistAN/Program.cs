string[] nomes = new string[4];
float[] notas = new float[4];

for(int i = 0; i < notas.Length; i++)
{
    System.Console.WriteLine("\nDigite o nome do aluno: ");
    nomes[i] = Console.ReadLine();

    System.Console.WriteLine($"Digite a nota do {nomes[i]}");
    notas[i] = Convert.ToSingle(Console.ReadLine());
}

System.Console.WriteLine("Notas de casa aluno");
for(int i = 0; i < notas.Length; i++)
{
    System.Console.WriteLine($"A nota do aluno {nomes[i]} foi {notas[i]}");
}