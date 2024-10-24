using System.Globalization;
using System.Reflection;
using Retangulo;

class Program {
    public static void Main(string[] args)
    {

         CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        RetanguloCal r = new RetanguloCal();


         Console.WriteLine("Digite a altura e largura do retangulo: ");
         r.Altura = double.Parse(Console.ReadLine());
         r.Largura = double.Parse(Console.ReadLine());

         System.Console.WriteLine(r);

        
    }
}