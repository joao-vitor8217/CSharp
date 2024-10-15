using System.Globalization;

class Progam {
    public static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        System.Console.WriteLine("Digite o nome e idade da primeira pessoa: ");
        string [] vetor1 = Console.ReadLine().Split(' ');

        System.Console.WriteLine("Digite o nome e a idade da segunda pessoa: ");
        string [] vetor2 = Console.ReadLine().Split(' ');

        double idadeMedia = (double.Parse(vetor1[1]) + double.Parse(vetor2[1])) / 2;

        System.Console.WriteLine("A idade media de " + vetor1[0] + " e " + vetor2[0] + " e de " + idadeMedia + " anos");
    }
}