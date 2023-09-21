int num;
bool primo = true;

System.Console.WriteLine("Digite um numero: ");
num = Convert.ToInt32(Console.ReadLine());

if(num <= 1)
{
    primo = false;
}

for(int contador = 2; contador <= num/2; contador++)
{
    if(num % contador == 0)
    {
        primo = false;
        break;
    }
}
if(primo)
{
    System.Console.WriteLine($"O numero {num} é primo");
}
else
{
    System.Console.WriteLine($"O numero {num} não é primo");
}

/*if(num > 1 && num % 2 != 0 && num % 3 != 0)
{
    System.Console.WriteLine("O numero é primo");
}
else
{
    System.Console.WriteLine("O numero não é primo");
}*/