

namespace Estoque;

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque() {
        double precoTotal = Preco * Quantidade;
        return precoTotal;
    }
    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;

    }

    public void RemoverProdutos(int quantidade0) {
        Quantidade -= quantidade0;
        
    }

    public override string ToString()
    {
        return Nome + ", $" + Preco + ", " + Quantidade + ", Preço total: " + ValorTotalEmEstoque();
    }



}
