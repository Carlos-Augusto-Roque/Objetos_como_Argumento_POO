using System;
using System.Collections.Generic;

namespace Objetos_como_Argumento_POO.classes
{
    public class Carrinho : Produto
    {
        public float ValorTotal { get; set; }

        //lista de produtos no carrinho
        List<Produto> carrinho = new List<Produto>();

        //adicionar produto no carrinho
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        //remover produto do carrinho
        public void RemoverProduto(Produto produto){
            carrinho.Remove(produto);
        }
        
        //mostrar os produtos do carrinho
        public void MostrarProdutos(){
            if(carrinho != null){
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    System.Console.WriteLine($" R$ {p.Preco.ToString("n2")} - {p.Nome}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }

        //mostrar o total do carrinho
        public void MostrarTotal(){
            Console.ForegroundColor = ConsoleColor.Blue;

            if(carrinho != null){
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                System.Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")}");
            }else{
                System.Console.WriteLine($"Carrinho Vazio!");
            }
            Console.ResetColor();
        }

        
    }
}