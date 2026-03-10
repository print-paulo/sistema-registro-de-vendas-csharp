namespace SistemaVendas.Models
{
    public class Produto // Modelo produto
    {
        public string NomeProduto { get; set; }
        public string TipoProduto { get; set ;}
        public decimal PrecoProduto { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto(string nomeProduto, string tipoProduto, decimal precoProduto, int quantidadeEstoque)
        {
            NomeProduto = nomeProduto;
            TipoProduto = tipoProduto;
            PrecoProduto = precoProduto;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}