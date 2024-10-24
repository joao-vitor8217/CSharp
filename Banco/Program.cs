using System.Globalization;
using System.Reflection.PortableExecutable;

class Program
{
    public static void Main(string[] args)
    {

        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        System.Console.WriteLine("Entre o numero da conta: ");
        int numero = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("Entre o titular da conta: ");
        string titular = Console.ReadLine();

        Cliente a = new Cliente(numero, titular);

        System.Console.WriteLine(a);

        System.Console.WriteLine("Havera um deposito inicial?");
        char deposito = char.Parse(Console.ReadLine());

        if (deposito == 's')
        {
            System.Console.WriteLine("Entre o valor de deposito");
            double Deposito = double.Parse(Console.ReadLine());
            a.Depositar(Deposito);
        }

        System.Console.WriteLine("Dados da conta: ");
        System.Console.WriteLine(a);

        System.Console.WriteLine("Entre o valor de deposito");
        double valorDeposito = double.Parse(Console.ReadLine());
        a.Depositar(valorDeposito);

        System.Console.WriteLine("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine());

            a.Sacar(saque);
            System.Console.WriteLine("Dados atualizados: ");
            System.Console.WriteLine(a);

    }
}