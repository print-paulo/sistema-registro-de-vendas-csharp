using System;
using System.IO;
using System.Text.Json;
using SistemaVendas.Models;

namespace SistemaVendas.Services
{
    public class ClienteService
    {
        public string path = "Data/clientes.json";

        public void RegistrarCliente()
        {
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite número do cliente: ");
            if (!long.TryParse(Console.ReadLine(), out long numero))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Cliente novoCliente = new Cliente // Cria a instancia do modelo
            {
                NomeCliente = nome,
                NumeroTelefone = numero
            };

            List<Cliente> listaAtual = CarregarClientes(); // Carrega a lista de clientes do arquivo json
            listaAtual.Add(novoCliente) // Adiciona o novo cliente
            SalvarClientes(listaAtual) // Salva a lista
        }
        
        private List<Cliente> CarregarClientes()
        {
            if (!File.Exists(path) return new List<Cliente>()) 
            string json = File.ReadAllText(path); 
            // Se o arquivo estiver vazio, retorna uma lista nova
            return JsonSerializer.Deserialize<List<Cliente>>(json) ?? List<Cliente>();
        }

        private List<Cliente> SalvarClientes()
        {
            string json = JsonSerializer.Serialize(clientes, new JsonSerializerOptions {WriteIntended = true})
            File.WriteAllText(path, json)
        }
    }
}