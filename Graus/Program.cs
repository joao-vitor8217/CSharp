class Program {
    public static void Main(string[] args)
    {
        double graus;
        double f;
        string confirmacao;

        do{
        System.Console.WriteLine("Digite quantos graus deseja fazer a converção: ");
        graus = double.Parse(Console.ReadLine());
        f = (graus / 5) + 32;
        System.Console.WriteLine("Equivalente em Fahrenheit: " + f);
        System.Console.WriteLine("Deseja fazer denovo? (s/n)");
        confirmacao = Console.ReadLine();
        
            
        } while (confirmacao == "s");
        
    }
}