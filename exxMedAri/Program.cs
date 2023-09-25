using System.Runtime.CompilerServices;

float[] notas = new float[7];
float totalnotas = 0;
float media;

for(int i = 0; i < notas.Length; i++)
{
    System.Console.WriteLine("Digite a nota: ");
    notas[i] = Convert.ToSingle(Console.ReadLine());
}

for(int i = 0; i < notas.Length; i++)
{
    totalnotas += notas[i];
}

media = totalnotas/notas.Length;
System.Console.WriteLine($"\n A media da sala foi {media.ToString("N2")}");



