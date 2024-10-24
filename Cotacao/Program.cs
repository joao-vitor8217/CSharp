using System.Globalization;
using Cotacao;

class Program {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        System.Console.WriteLine("Qual a cotacao do dolar atual? ");
        ConversorDeMoeda.CotacaoDolar = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Quantos dolores voce vai comprar? ");
        ConversorDeMoeda.QtdDolar = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Valor total a ser pago em reais: " + ConversorDeMoeda.DolarReal());
        
    }
}