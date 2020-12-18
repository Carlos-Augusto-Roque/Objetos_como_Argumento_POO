using System;
using System.Collections.Generic;

namespace Objetos_como_Argumento_POO.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        
        public Produto(){

        }

        public Produto(int _codigo,string _nome,float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco; 
        }

        //lista de produtos cadastrados
        List<Produto> produtos = new List<Produto>();

        //metodo para cadastrar produto
        public void CadastrarProduto(Produto produto){
            produtos.Add(produto);
        }

        //metodo para descadastrar produto    
        public void DescadastrarProduto(Produto produto){
            produtos.Remove(produto);
        }

        //metodo para mostrar os produtos cadastrados
        public void ListaProdCadastrados(){
            if(produtos != null){
                foreach (Produto p in produtos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($" R$ {p.Preco.ToString("n2")} - {p.Nome}");
                    Console.ResetColor();
                }
               
            }
        }

        public void AtualizarCadastro(int _codigo,Produto _novoProduto){
            produtos.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            produtos.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }

}