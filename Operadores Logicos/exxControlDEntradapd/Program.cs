int idade;

System.Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if(idade <= 6 || idade >= 80)//Caso idade seja menor ou igual a 6 anos ou maior ou igual a 80 anos
{
    System.Console.WriteLine("fita vermelha");
}
else if(idade > 6 && idade < 13 || idade > 69 && idade < 80)//Caso idade dor maior que 6 anos e menor que 13 anos ou maior que 69 e menor que 80 anos
{
    System.Console.WriteLine("fita amarela");
}
else/*if (idade >= 13 && idade < 70 )*/
//Caso idade seja maior ou igual a 13 anos e menor que 70 anos
{
    System.Console.WriteLine("Fita verde");
}