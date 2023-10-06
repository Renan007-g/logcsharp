float alturaParede;
float larguraParede;
string continuar;

float alturaAbertura;
float larguraAbertura;

float tamanhototalParede = 0;
float tamanhototalAbertura = 0;
float rendimentoPL;
int nDeMaos;
float litroPmq;
float consumoTT;

do{
System.Console.WriteLine("Digite a altura da parede em metros: ");
alturaParede = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("Digite a largura da parede em metros");
larguraParede = Convert.ToSingle(Console.ReadLine());

tamanhototalParede += alturaParede * larguraParede;

Console.Clear();

while(true){
    System.Console.WriteLine("Deseja calcular outra parede? [s]Sim [n]Não");
    continuar = Console.ReadLine().ToLower();

    if(continuar == "s" || continuar == "n")
    {
        break;
    }
    else
    {
        System.Console.WriteLine("Digite um valor valido");
    }
}

}while(continuar == "s");

Console.Clear();

while(true)
{
    System.Console.WriteLine("A parede possui aberturas? [s]Sim [n]Não");
    continuar = Console.ReadLine().ToLower();

    if(continuar == "s" || continuar == "n")
    {
        break;
    }
    else
    {
        System.Console.WriteLine("Insira um valor valido");
    }
}

while(continuar == "s")
{
    System.Console.WriteLine("Insira a altura da abertura em metros: ");
    alturaAbertura = Convert.ToSingle(Console.ReadLine());

    System.Console.WriteLine("Insira a largura da abertura em metros: ");
    larguraAbertura = Convert.ToSingle(Console.ReadLine());

    tamanhototalAbertura += alturaAbertura * larguraAbertura;

    Console.Clear();

    while(true)
    {
        System.Console.WriteLine("Possui mais alguma abertura? [s]Sim [n]Não");
        continuar = Console.ReadLine();

        if(continuar == "s" || continuar == "n"){
            break;
        }
        else{
            System.Console.WriteLine("Insira uma opção valida");
        }
        Console.Clear();
    }
}

System.Console.WriteLine("Insira o redimento por m² por litro (m²/L)");
rendimentoPL = Convert.ToSingle(Console.ReadLine());
Console.Clear();

System.Console.WriteLine("Insira o numero de demãos nessesarias: ");
nDeMaos = Convert.ToInt32(Console.ReadLine());

tamanhototalParede -= tamanhototalAbertura;

litroPmq = 1 / rendimentoPL;

consumoTT = litroPmq * tamanhototalParede;
consumoTT *= nDeMaos;

if(consumoTT > 1){
System.Console.WriteLine($"O consumo total de tinta sera {Math.Round(consumoTT, 1)} litros.\n");
}
else{
    System.Console.WriteLine($"O consumo total de tinta sera {Math.Round(consumoTT * 1000, 1)} mililitros.\n");
}

