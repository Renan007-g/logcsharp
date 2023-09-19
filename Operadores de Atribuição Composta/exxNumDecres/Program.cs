int contador;

System.Console.WriteLine("Digiter um numero: ");
contador = Convert.ToInt32(Console.ReadLine());

while(contador >= 0)
{
    System.Console.Write($"\n{contador}");
    contador -= 1;
}