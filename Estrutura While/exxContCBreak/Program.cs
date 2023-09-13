System.Console.WriteLine("Digite o numero de incio: ");
int ini = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Digite o numero de fim: ");
int fim = Convert.ToInt32(Console.ReadLine());

while(true)
{
    if(ini > fim)
    {
        break;
    }
    System.Console.WriteLine(ini);
    ini += 1;
}