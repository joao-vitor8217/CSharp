namespace Retangulo;

public class RetanguloCal
{
    public double Largura;
    public double Altura;

    public double Area() {
        return Largura * Altura;
    }

    public double Perimetro(){
        return 2 * (Largura + Altura);
    }

    public override string ToString()
    {
        return "AREA: " + Area().ToString("F2") + "\n" + "Perimetro: " + Perimetro().ToString("F2");
    }
}
