using System;
using System.IO;
using SistemaVendas.Services;

class Program
{
    static void Main()
    {
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