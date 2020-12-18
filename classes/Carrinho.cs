using System;
using System.Collections.Generic;

namespace POO_ObjetoArgumento.classes
{
    public class Carrinho
    {
       
        public float ValorTotal { get; set; }

       
        List<Produto> carrinho = new List<Produto>();
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        public void MostrarProdutos(){
            if(carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }



        public void RemoverProduto(Produto produtoRemove){
            carrinho.Remove(produtoRemove);
        }
        
        public void MostrarTotal(){
            if(carrinho != null){
                foreach (var item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"O valor total é : R${ValorTotal}");
            }
            else {
                Console.WriteLine("Seu carrinho está vazio!");
            }
        }
        
        public void AlterarItem(int codigoProcurado, Produto novoProduto){
            carrinho.Find(produto => produto.Codigo == codigoProcurado).Nome = novoProduto.Nome;
            carrinho.Find(produto => produto.Codigo == codigoProcurado).Preco = novoProduto.Preco;

            
        }



    }
}