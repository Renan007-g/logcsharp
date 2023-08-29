int multiplicando = 1;
int multiplicador = 1;

while(multiplicador <=10)
{
    System.Console.WriteLine($"\nTabuada do {multiplicador}");
    while(multiplicando <= 10)
    {
        System.Console.WriteLine($"{multiplicador} x {multiplicando} = {multiplicador * multiplicando}");
        multiplicando += 1;
    }
    multiplicador += 1;
    multiplicando = 0;
}