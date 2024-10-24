using System.Reflection.Emit;

class Cliente {
    public int Numero { get; private set; }
    public string Titular { get;  set; }
    public double Saldo { get; private set; }

    public Cliente(int numero, string titular) {
        Numero = numero;
        Titular = titular;
        
    }

    public void Depositar(double deposito) {
        Saldo += deposito;
    }

    public void Sacar(double sacar) {
        if (Saldo > sacar) {
        Saldo -= sacar + 5;
        }
        else {
            System.Console.WriteLine("Voce nao tem esse valor para saque");
        }
    }

    public override string ToString()
    {
        return "Conta: " + Numero + ", Titutar: " + Titular + ", Saldo: " + Saldo.ToString("F2");
    }

}