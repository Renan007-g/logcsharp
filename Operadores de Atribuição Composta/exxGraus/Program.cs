float tempC = 0;
float tempF;

while(tempC <= 100)
{ 
    tempF = tempC * 1.8f + 32;
    System.Console.Write($"\n{tempC} Graus celcius \t {tempF.ToString("N1")} Graus fahrenheit");
    tempC += 1;
}

//A variavel fahrenheit podia ser substituida no cw com: {tempc *1.8 + 32}.
//E para adicionar a formatação adicionar {(tempc *1.8 + 32).ToString("N1")}