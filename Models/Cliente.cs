namespace SistemaVendas.Models
{
    public class Cliente // Classe Cliente
    {
        public string NomeCliente { get; set; }
        public long NumeroTelefone { get; set; }

        public Cliente(string nomeCliente, long numeroCliente)
        {
            NomeCliente = nomeCliente;
            NumeroTelefone = numeroCliente;
        }
    }
}