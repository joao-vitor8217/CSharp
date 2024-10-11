
using System.Globalization;

class Progam {
    public static void Main(string[] args) {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3]);

        Console.WriteLine("Seu nome e: " + nome);
        Console.WriteLine("Seu sexo e: " + sexo);
        Console.WriteLine("Sua idade e: " + idade);
        Console.WriteLine("Sua altura e: " + altura);


}
 }
