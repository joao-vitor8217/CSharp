using System.Globalization;
using FuncionarioProgama;

class Program {
    public static void Main(string[] args)
    {

        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Funcionario f1 = new Funcionario();

        System.Console.WriteLine("Nome: ");
        f1.Nome = Console.ReadLine();

        System.Console.WriteLine("Salario Bruto: ");
        f1.SalarioBruto = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Imposto: ");
        f1.Imposto = double.Parse(Console.ReadLine());

        System.Console.WriteLine(f1);

        System.Console.WriteLine("Digite a porcentagem para aumentar o saraio: ");
        f1.AumentarSalario(double.Parse(Console.ReadLine()));
    

        System.Console.WriteLine("Dados atualizado: " + f1);
        
 }
}