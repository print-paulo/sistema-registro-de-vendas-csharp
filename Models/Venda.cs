namespace SistemaVendas.Models
{
    public class Venda // Relação de venda entre o Produto e o Cliente
    {
        public Cliente Comprador { get; set; }
        public Produto ItemVendido { get; set; }

        public int Quantidade { get; set; }
        public int DataCompra { get; set;}

        public decimal precoVenda => ItemVendido.PrecoProduto * Quantidade;
    }
}