

class Program {
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Digite um numero: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 10; i++)
        {
            System.Console.WriteLine(i + " x " + n + " = " + i * n);
            
        }
        
    }
}