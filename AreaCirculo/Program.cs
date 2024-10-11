using System.Globalization;

class Progam {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        double n = 3.14159;
        double raio = double.Parse(Console.ReadLine());

        double calculo = n * Math.Pow(raio, 2);

        Console.WriteLine("X=" + calculo);




        
    }
}