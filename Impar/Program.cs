class Program {
    public static void Main(string[] args)
    {

        int acumulador = 0;
        System.Console.WriteLine("Digite o primeiro numero: ");
        int num1 = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Digite o segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        for (int i =+ num1; i < num2; i++)
        {
            if (i > num1 && i % 2 == 1) {
                acumulador += i;

            }
            
        }
        System.Console.WriteLine(acumulador);
    }
}
