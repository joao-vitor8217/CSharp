class Progam {
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome completo: ");
        string NomeCompleto = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa? ");
        int quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o preco de um produto: ");
        double preco = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Entre seu ultimo nome, idade e altura");

        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        int indade = int.Parse(vet [1]);
        double altura = double.Parse(vet [2]);

        System.Console.WriteLine(NomeCompleto);
        System.Console.WriteLine(quartos);
        System.Console.WriteLine(preco);
        System.Console.WriteLine(nome);
        System.Console.WriteLine(indade);
        System.Console.WriteLine(altura);


    }
}