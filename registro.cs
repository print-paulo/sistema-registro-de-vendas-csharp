using System;
using System.IO;

public class Produto // Classe produto
{
    string NomeProduto { get; set; }
    string TipoProduto { get; set ;}
    decimal PreçoProduto { get; set; }
    int QuantidadeEstoque { get; set; }

    public void RegistrarProduto()
    {
        // A ser feito...
    }
}

public class Cliente // Classe Cliente
{
    string NomeCliente { get; set; }
    int NumeroTelefone { get; set; }
}

public class Venda // Relação de venda entre o Produto e o Cliente
{
    public Cliente Comprador { get; set; }
    public Produto ItemVendido { get; set; }

    public int Quantidade { get; set; }
    public int Data { get; set;}
}

public string CheckFile(string filePath) // Checar se o arquivo JSON de venda já existe
{
    if (File.Exists(filePath)) 
    {
        bool fileExist = true;
        return fileExist;
    }
    else
    {
        bool fileExist = false;
        return fileExist;
    }
}

class Program
{
    static void Main()
    {
        string clientesJson = "clientes.json";
        string produtosJson = "produtos.json";
        string vendasJson = "vendas.json";
        
        CheckFile(registro);
        
        int opcao = 0;
        while (opcao != 3) 
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| Escolha o que deseja alterar/adicionar    |");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("| 1 - Clientes                              |");
            Console.WriteLine("| 2 - Produtos                              |");
            Console.WriteLine("| 3 - Sair                                  |");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("O que deseja fazer? ")
            opcao = Convert.ToInt32(Console.ReadLine())

            switch (opcao)
            {
                case 1:
                {
                    int opcao = 0;
                    while (opcao != 5) 
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("| Clientes                                  |");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("| 1 - Adicionar                             |");
                        Console.WriteLine("| 2 - Remover                               |");
                        Console.WriteLine("| 3 - Modificar                             |");
                        Console.WriteLine("| 4 - Listar                                |");
                        Console.WriteLine("| 5 - Sair                                  |");
                        Console.WriteLine("---------------------------------------------");
                    }
                }
                case 2:
                {
                    int opcao = 0;
                    while (opcao != 5)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("| Produtos                                  |");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("| 1 - Adicionar                             |");
                        Console.WriteLine("| 2 - Remover                               |");
                        Console.WriteLine("| 3 - Modificar                             |");
                        Console.WriteLine("| 4 - Listar                                |");
                        Console.WriteLine("| 5 - Sair                                  |");
                        Console.WriteLine("---------------------------------------------");
                    }
                }
            }
        }
    }
}