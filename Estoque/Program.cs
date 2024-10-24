using System.Globalization;
using Estoque;

class Program {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Produto nome;
        Produto preco;
        Produto quantidade;

        Produto P = new Produto();

        System.Console.WriteLine("Entre com os dados do produto: ");
        System.Console.Write("Nome: ");
        P.Nome = Console.ReadLine();
        
        System.Console.Write("Preço: ");
        P.Preco = double.Parse(System.Console.ReadLine());

        System.Console.Write("Quantidade: ");
        P.Quantidade= int.Parse(Console.ReadLine());

        System.Console.WriteLine("Dados do produto: " + P);

        System.Console.Write("Digite a quantidade que deseja adicionar: ");
        int qtd = int.Parse(System.Console.ReadLine());

        P.AdicionarProdutos(qtd);

        System.Console.WriteLine("Dados atualizados: " + P);

        System.Console.Write("Digite a quantidade que deseja retirar: ");
        int rqtd = int.Parse(System.Console.ReadLine());

        P.RemoverProdutos(rqtd);

        System.Console.WriteLine("Dados atualizados: " + P);
        
    
    }
}