int vel;
int velmax;

System.Console.WriteLine("Digite a velocidade maxima da via: ");
velmax = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("RADAR: Qual foi a velocidade do carro: ");
vel = Convert.ToInt32(Console.ReadLine());


if(vel > velmax && vel < velmax * 1.2 )// Caso a velocidade seja maior que a velmax permitida mas seja maior em até 20%
{
    System.Console.WriteLine("\nVocê foi multado em R$130,16 ");
}
else if(vel > 1.2 * velmax && vel < 1.5 * velmax )//Caso a vel ultrapasse a vel max em ate 50%
{
    System.Console.WriteLine("\nVocê foi multado em R$195,23");
}
else if(vel > 1.5 * velmax )/**/ //Caso a vel utrapasse a velamx acima de 50%
{
    System.Console.WriteLine("\nVocê foi multado em R$880,41");
}
else
{
    System.Console.WriteLine("\nVocê passou dentro do limite de velocidade");
}


