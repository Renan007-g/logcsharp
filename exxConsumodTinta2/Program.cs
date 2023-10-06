float altParede;
float largParede;
double ttParede = 0;
string continuar;

float altAbert;
float largAbert;
double ttAbert = 0;

double totalParedes = 0;
double consuT;

float rendimento;
int nDeMaos;
float litroPmetroQuad;


do{
System.Console.WriteLine("##### Rendimento da tinta por metro quadrado = 0.037 #####");
System.Console.WriteLine("##### Rendimento em litro por lata = 0.036 #####\n");

System.Console.WriteLine("Informe a altura em M da parede:");
altParede = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("\nDigite a largura em M da parede: ");
largParede = Convert.ToSingle(Console.ReadLine());

ttParede += altParede * largParede;
//totalParedes += ttParede;

while(true){
    System.Console.WriteLine("Deseja pintar mais alguma parede? digite [s]Sim [n]Não");
    continuar = Console.ReadLine().ToLower();

    if(continuar == "s" || continuar == "n"){
        break;
    }
    else{
        System.Console.WriteLine("Digite uma opção valida.");
    }

}

Console.Clear();

}while(continuar == "s");

while(true){

    System.Console.WriteLine("A parede possui aberturas? (janelas, portas e etc?) se digite: [s]Sim [n]Não ");
    continuar = Console.ReadLine().ToLower();

    if(continuar == "s" || continuar == "n"){
        break;
    }
    else{
        System.Console.WriteLine("Digite um opção valida");
    }
}

while(continuar == "s"){
    System.Console.WriteLine("Qual a altura em M da abertura: ");
    altAbert = Convert.ToSingle(Console.ReadLine());

    System.Console.WriteLine("Qual a largura em M da abertura: ");
    largAbert = Convert.ToSingle(Console.ReadLine());

    ttAbert += altAbert * largAbert;
    Console.Clear();

    while(true){
        System.Console.WriteLine("Deseja inserir mais aberturas? [s]Sim [n]Não");
        continuar = Console.ReadLine();

        if(continuar == "s" || continuar == "n"){
            break;
        }
        else{
            System.Console.WriteLine("Digite um opção valida.");
        }

        Console.Clear();
    }
}

System.Console.WriteLine("Digite o rendimento por metro quadrado por litro: ");
rendimento = Convert.ToSingle(Console.ReadLine());
Console.Clear();

System.Console.WriteLine("Digite o numero demãos: ");
nDeMaos = Convert.ToInt32(Console.ReadLine());



totalParedes -= ttAbert;

litroPmetroQuad = 1 / rendimento;

consuT = litroPmetroQuad * totalParedes;
consuT *= nDeMaos;

//System.Console.WriteLine($"\nO consumo de tinta por demão será: {consuT.ToString("N2")}litros");
System.Console.WriteLine($"\nO consumo total de tinta será de {consuT.ToString("N2")} litros");

/*float altParede;
float largParede;
double ttParede;
string continuar;

float altAbert;
float largAbert;
double ttAbert = 0;
string simnao;

double totalParedes = 0;
double consuT;


do{
System.Console.WriteLine("##### Rendimento da tinta por metro quadrado = 0.037 #####");
System.Console.WriteLine("##### Rendimento em litro por lata = 0.036 #####\n");

System.Console.WriteLine("Informe a altura em M da parede:");
altParede = Convert.ToSingle(Console.ReadLine());

System.Console.WriteLine("\nDigite a largura em M da parede: ");
largParede = Convert.ToSingle(Console.ReadLine());

ttParede = altParede * largParede;
totalParedes += ttParede;


System.Console.WriteLine("Deseja pintar mais alguma parede? digite [s]Sim [n]Não");
continuar = Console.ReadLine();
continuar = continuar.ToLower();

}while(continuar == "s");

System.Console.WriteLine("A parede possui aberturas? (janelas, portas e etc?) se digite: [s]Sim [n]Não ");
simnao = Console.ReadLine();
simnao = simnao.ToLower();

if(simnao == "s"){
    System.Console.WriteLine("Qual a altura em M da abertura: ");
    altAbert = Convert.ToSingle(Console.ReadLine());

    System.Console.WriteLine("Qual a largura em M da abertura: ");
    largAbert = Convert.ToSingle(Console.ReadLine());

    ttAbert = altAbert * largAbert;
}

totalParedes -= ttAbert;
consuT = 0.037 * totalParedes;

System.Console.WriteLine($"\nO consumo de tinta por demão será: {consuT.ToString("N2")}litros");
consuT *= 3;
System.Console.WriteLine($"\nCom o total de 3 demãos sará de {consuT.ToString("N2")} litros");



*/