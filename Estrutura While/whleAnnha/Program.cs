int contin = 0;
int contex = 1;

while( contex < 4)
{
    System.Console.WriteLine($"\n #### Laço externo: {contex} ####");

    while( contin < 5)
    {
        System.Console.WriteLine($"Laço Interno: {contin}");

        contin += 1;
    }

    contex += 1;
    contin = 0;
}