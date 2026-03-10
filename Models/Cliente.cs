namespace SistemaVendas.Models
{
    public class Cliente // Classe Cliente
    {
        string NomeCliente { get; set; }
        int NumeroTelefone { get; set; }

        public Cliente(string nomeCliente, int numeroCliente)
        {
            NomeCliente = nomeCliente;
            NumeroTelefone = numeroCliente
        }
    }
}