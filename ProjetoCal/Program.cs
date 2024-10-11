using System.Globalization;

class Progam {
    public static void Main(string[] args) {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        double comprimento;
        double altura;
        double area;
        double valorArea;
        double preco;

        System.Console.WriteLine("Digite o comprimento: ");
        comprimento = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a altura: ");
        altura = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite o valor da area: ");
        valorArea = double.Parse(Console.ReadLine());

        area = comprimento * altura;
        preco = valorArea * area;

        Console.WriteLine("Area = " + area.ToString("F2"));
        Console.WriteLine("Preco = " + preco.ToString("F2"));
    }
}
