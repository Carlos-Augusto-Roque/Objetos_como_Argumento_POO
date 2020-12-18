using System;
using Objetos_como_Argumento_POO.classes;

namespace Objetos_como_Argumento_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int opcao;

            Produto p = new Produto();
            Produto produtos = new Produto();
            Carrinho cooper = new Carrinho();

            do
            {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("");
            System.Console.WriteLine("---WELCOME TO E-COMMERCE XXX---");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("");
            System.Console.WriteLine("-----MENU PRINCIPAL-----");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("ACESSO PARA:");
            System.Console.WriteLine("");
            System.Console.WriteLine("[1] - ADMINISTRADOR");
            System.Console.WriteLine("[2] - CLIENTE");
            System.Console.WriteLine("[0] - SAIR DO MENU PRINCIPAL");
            opcao = int.Parse(Console.ReadLine());
            Console.ResetColor();

            
            switch (opcao)
            {
                case 1:
                    System.Console.Write("DIGITE A SENHA DO ADMINISTRADOR: ");
                    string senhaAdministrador = Console.ReadLine();

                    if(senhaAdministrador == "admin"){
                        
                        int opcaoAdm;
                        do
                        {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"----MENU DO ADMINISTRADOR----");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"[1] - CADASTRAR PRODUTOS");
                        System.Console.WriteLine($"[2] - DESCADASTRAR PRODUTO");
                        System.Console.WriteLine($"[3] - ATUALIZAR CADASTRO");
                        System.Console.WriteLine($"[4] - LISTAR PRODUTOS DISPONÍVEIS");
                        System.Console.WriteLine($"[0] - SAIR DO MENU DO ADMINISTRADOR");
                        opcaoAdm = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                       

                        switch (opcaoAdm)
                        {
                            case 1:
                                //cadastrar produtos
                                Produto newProduto = new Produto();
                                System.Console.Write("NOME DO PRODUTO: ");
                                newProduto.Nome = Console.ReadLine();
                                System.Console.Write("CÓDIGO DO PRODUTO: ");
                                newProduto.Codigo = int.Parse(Console.ReadLine());
                                System.Console.Write("PREÇO DO PRODUTO: ");
                                newProduto.Preco = float.Parse(Console.ReadLine());

                                p.CadastrarProduto(newProduto);

                            break;

                            case 2:
                                //descadastrar produtos
                                
                                System.Console.WriteLine($"DIGITE O CÓDIGO DO PRODUTO");
                                p.Codigo = int.Parse(Console.ReadLine());
                                p.DescadastrarProduto(p);
                                System.Console.WriteLine($"O PRODUTO DE CÓDIGO {p.Codigo} FOI DESCADASTRADO!");
                            break;

                            case 3:
                                //atualizar cadastro do produto
                                Produto alterarProduto = new Produto();
                                System.Console.WriteLine("Qual o código a ser alterado?");
                                alterarProduto.Codigo = int.Parse(Console.ReadLine());

                                System.Console.WriteLine("Qual a nova descricção do produto?");
                                alterarProduto.Nome = Console.ReadLine();

                                System.Console.WriteLine("Qual o novp preço?");
                                alterarProduto.Preco = float.Parse(Console.ReadLine());

                                p.AtualizarCadastro(alterarProduto.Codigo, alterarProduto);
                            break;

                            case 4:
                                p.ListaProdCadastrados();
                            break;

                            case 0:
                                //sair
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine("OPÇÃO INVÁLIDA!");
                                Console.ResetColor();
                            break;
                        }
                        
                        } while (opcaoAdm !=0);

                    }else{
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine($"SENHA INVÁLIDA - TENTE NOVAMENTE !");
                        Console.ResetColor();
                    }


                break;

                case 2:
                    System.Console.WriteLine($"DIGITE A SENHA DO CLIENTE");
                    string senhaCliente = Console.ReadLine();

                    if(senhaCliente == "cliente"){
                        int opcaoCliente;
                        do
                        {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"----MENU DO CLIENTE----");
                        System.Console.WriteLine("");
                        System.Console.WriteLine($"[1] - ADICIONAR PRODUTO AO CARRINHO");
                        System.Console.WriteLine($"[2] - REMOVER PRODUTO DO CARRINHO");
                        System.Console.WriteLine($"[3] - LISTAR PRODUTOS DO CARRINHO");
                        System.Console.WriteLine($"[0] - SAIR DO MENU DO CLIENTE");
                        opcaoCliente = int.Parse(Console.ReadLine());
                        Console.ResetColor();

                        switch (opcaoCliente)
                        {
                            case 1:
                                //adicionar produto no carrinho
                            break;

                            case 2:
                                //remover produto do carrinho
                            break;

                            case 3:
                                //listar produtos do carrinho
                            break;

                            case 0:
                                //sair
                            break;

                            default:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                System.Console.WriteLine("OPÇÃO INVÁLIDA!");
                                Console.ResetColor();
                            break;
                        }
                        
                        } while (opcaoCliente !=0);

                    }

                break;
                
                case 0:
                    System.Console.WriteLine($"SAINDO DO MENU PRINCIPAL...");
                break;

                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine($"OPÇÃO INVÁLIDA");
                    Console.ResetColor();
                break;
            }
            
                
            } while (opcao !=0);
        }
    }
}
