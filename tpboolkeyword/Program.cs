namespace tpboolkeyword;

class Program
{
    static void Main(string[] args)
    {
        string senha = "Renan2007";
        string senhaConfirmação = "Renan2007";

        //bool resultado = senha == senhaConfirmação;

        if(senha == senhaConfirmação)
        {
            System.Console.WriteLine("A senha está correta!");
        }
        else{
            System.Console.WriteLine("A senha está incorreta!");
        }
    }
}
