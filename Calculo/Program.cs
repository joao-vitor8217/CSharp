using System.Globalization;

class Progam {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        System.Console.WriteLine("Digite a base do retangulo: ");
        double baase = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite a altura do retangulo: ");
        double altura = double.Parse(Console.ReadLine());

        double area = baase * altura;
        double perimetro = 2 * (baase + altura);

        System.Console.WriteLine("AREA = " + area.ToString("F4"));
        System.Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"));

    }
}