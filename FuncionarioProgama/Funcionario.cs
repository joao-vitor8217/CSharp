using System;

namespace FuncionarioProgama;

public class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido() {
        double salarioatualizado = SalarioBruto - Imposto;
        return salarioatualizado;
    }

    public void AumentarSalario(double porcentagem) {
        SalarioBruto += SalarioBruto * porcentagem / 100;
    }

    public override string ToString()
    {
        return Nome + " " + "R$" + SalarioLiquido().ToString("F2");
    }

}
