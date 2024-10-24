class Program {
    public static void Main(string[] args)
    {
        Pessoa p1, p2;

        p1 = new Pessoa();
        p2 = new Pessoa();

        System.Console.WriteLine("Digite o nome da primeira pessoa: ");
        p1.nome = Console.ReadLine();

        System.Console.WriteLine("Digite o nome da segunda pessoa: ");
        p2.nome = Console.ReadLine();

        System.Console.WriteLine("Digite a idade da primeira pessoa: ");
        p1.idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a idade da segunda pessoa: ");
        p2.idade = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Nome: " + p1.nome);
        System.Console.WriteLine("Idade: " + p1.idade);
        System.Console.WriteLine(" ");
        System.Console.WriteLine("Nome: " + p2.nome);
        System.Console.WriteLine("Idade: " + p2.idade);

        if (p1.idade > p2.idade)
        {
            System.Console.WriteLine("O mais velho: " + p1.nome);
        }else if (p2.idade > p1.idade)
        {
            System.Console.WriteLine("O mais velho: " + p2.nome);
        }
        
    }
}