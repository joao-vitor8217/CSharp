class Soma {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um numero: ");
        int num1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite mais um numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;

        System.Console.WriteLine("SOMA = " + soma);
    }
}