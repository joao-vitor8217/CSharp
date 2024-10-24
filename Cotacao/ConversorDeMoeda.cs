using System;

namespace Cotacao;

public class ConversorDeMoeda
{
    public static double CotacaoDolar;
    public static double QtdDolar;
    
    public static double DolarReal() {
        return CotacaoDolar * QtdDolar;
    }
    public static double ValorPago() {
        double ValorTotal = DolarReal() * 0.06;
        return ValorTotal;
    }


}
