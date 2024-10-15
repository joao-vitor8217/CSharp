using System.Globalization;

class Program {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        double idade = double.Parse(Console.ReadLine());
        double acumulador = 0;
        double vezes = 0;
        double media;

        if(idade < 0) {
            System.Console.WriteLine("Impossivel Calcular");
        }

        while (idade > 0) {
            vezes ++;
            acumulador += idade;
            idade = double.Parse(Console.ReadLine());

        }
        media = acumulador / vezes;
        
        System.Console.WriteLine(media.ToString("F2"));
    }
}