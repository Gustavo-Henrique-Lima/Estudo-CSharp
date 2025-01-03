using System.Globalization;

namespace Produto
{
    class Prod
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
        }

        public override string ToString()
        {
            return $"{Nome}, $ {Preco.ToString("F2",CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {(Quantidade*Preco).ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
