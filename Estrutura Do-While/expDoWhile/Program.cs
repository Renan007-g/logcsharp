decimal valoritem;
decimal valortotal = 0;
string continuar;

do{
    System.Console.Write("Insira o valor do item: ");
    valoritem = Convert.ToDecimal(Console.ReadLine());
    valortotal += valoritem;

    System.Console.WriteLine("\nDeseja inserir mais itens? Digite s[sim] n[não]");
    continuar = Console.ReadLine();
    continuar = continuar.ToLower();
}while(continuar == "s");

System.Console.WriteLine($"\n Valor total: R${valortotal.ToString("N2")}");

