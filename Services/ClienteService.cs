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

            Cliente novoCliente = new Cliente
            {
                NomeCliente = nome;
                NumeroTelefone = numero;
            }

            // A CONTINUAR...
        }
    }
}