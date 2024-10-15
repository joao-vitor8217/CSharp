using System.Globalization;

class Program {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        System.Console.WriteLine("Digite sua primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite sua segunda nota");
        double nota2 = double.Parse(Console.ReadLine());

        double notaFinal = nota1 + nota2;

        if (notaFinal >= 60.00) {
            System.Console.WriteLine("Nota final: " + notaFinal.ToString("F2"));
            System.Console.WriteLine("APROVADO!!");
        }
        else {
           System.Console.WriteLine("Nota final: " + notaFinal.ToString("F2"));
           System.Console.WriteLine("REPROVADO!!");
          }
        
    }
}