using System.Globalization;

double media = 6;

System.Console.WriteLine("Digite a nota do aluno: ");
double nota = Convert.ToDouble(Console.ReadLine());

if(nota >= media)
{
    System.Console.WriteLine($"{nota}Aluno aprovado");
}
else if( /*nota < media ||*/ nota >= 5 )
{
    System.Console.WriteLine($"{nota} Aluno de rec");
}
else
{
    System.Console.WriteLine($"{nota} Aluno reprovado");
}
