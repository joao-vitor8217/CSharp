class Progam {
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Digite 3 numeros: ");
        string [] vet = Console.ReadLine().Split(' ');

        
        int num1 = int.Parse(vet[0]);
        int num2 = int.Parse(vet[1]);
        int num3 = int.Parse(vet[2]);

        if(num1 < num2 || num1 < num3) {
            System.Console.WriteLine("Menor = " + num1);
        }
        else if (num2 < num1 || num2 < num3){
            System.Console.WriteLine("Menor = " + num2);
        }
        else if (num3 < num1 || num3 < num2) {
            System.Console.WriteLine("Menor = " + num3);
        }
       
    }
}