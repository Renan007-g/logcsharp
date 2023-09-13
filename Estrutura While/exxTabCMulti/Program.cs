namespace exxTabCMulti;

class Program
{
    static void Main(string[] args)
    {
        int num;
        int mult;
        int tab;

        System.Console.WriteLine("Digite um multiplicando para a tabuada");
        num = Convert.ToInt32(Console.ReadLine());
        mult = 0;
        
        
        while(mult <= 10)
        {
            tab = num * mult;
            System.Console.WriteLine($"{num} x {mult} = {tab}");
            mult += 1;
        }
    }
}
