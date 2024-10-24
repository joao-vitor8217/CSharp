
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Quantos numeros voce quer colocar? ");
        int quantidade = int.Parse(System.Console.ReadLine());
        int numeros = 0;
        int dentro = 0;
        int fora = 0;

        for (int i = 0; i < quantidade; i++)
        {
            if (numeros >= 10 && numeros <= 20)
            {
                dentro++;

            }
            else
            {
                fora++;
            }
            numeros = int.Parse(System.Console.ReadLine());

        }

        System.Console.WriteLine("in: " + dentro);
        System.Console.WriteLine("out: " + fora);


    }
}