class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite dois numeros: ");
        string[] vet = Console.ReadLine().Split(' ');

        int num1 = int.Parse(vet[0]);
        int num2 = int.Parse(vet[1]);

        while (num1 != num2)
        {
            if (num1 > num2)
            {
                System.Console.WriteLine("Decrescente");
            }
            else if (num1 < num2)
            {
                System.Console.WriteLine("Crescente");

            }
            string[] vet2 = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet2[0]);
            num2 = int.Parse(vet2[1]);

        }
        System.Console.WriteLine("PROGAMA ENCERRADO!!");
    }
}