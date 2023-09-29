int[] numeroUsers = new int[5];
int numMaior;

for(int i = 0; i < numeroUsers.Length; i++)
{
    System.Console.WriteLine("Digite um numero: ");
    numeroUsers[i] = Convert.ToInt32(Console.ReadLine());
}

numMaior = numeroUsers[0];

for(int i = 1; i < numeroUsers.Length; i++)
{
    if(numeroUsers[i] > numMaior)
    {
        numMaior = numeroUsers[i];
    }
}
System.Console.WriteLine($"\nO maior numeor adicionado foi: {numMaior}");
