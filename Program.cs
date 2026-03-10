using System;
using System.IO;

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

            Console.WriteLine("O que deseja fazer? ");
            opcao = Convert.ToInt32(Console.ReadLine());

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

                        Console.WriteLine("O que deseja fazer? ");
                        opcao = Convert.ToInt32(Console.Readline());

                        switch (opcao)
                        {
                            case 1:
                            {
                                Console.WriteLine("Digite o nome do produto: ");
                                string nomeCliente = Console.ReadLine();

                                Console.WriteLine("Digite o tipo do produto: ");
                                int numeroCliente = int.Parse(Console.ReadLine());
                            }
                            case 2:
                            {
                                // A fazer...
                            }
                            case 3:
                            {
                                // A fazer...
                            }
                            case 4:
                            {
                                // A fazer...
                            }
                            case 5:
                            {
                                break;
                            }
                        }
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

                        Console.WriteLine("O que deseja fazer? ");
                        opcao = Convert.ToInt32(Console.Readline());

                        switch (opcao)
                        {
                            case 1:
                            {
                                // A fazer...
                            }
                            case 2:
                            {
                                // A fazer...
                            }
                            case 3:
                            {
                                // A fazer...
                            }
                            case 4:
                            {
                                // A fazer...
                            }
                            case 5:
                            {
                                break;
                            }
                        }
                    }
                }
            }  
        }
    }
}