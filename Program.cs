using System;
using POO_ObjetoArgumento.classes;

namespace POO_ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Produto p1 = new Produto(1, "Read Dead Redemption", 499f);
            Produto p2 = new Produto(2, "GTA 5", 56.9f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.5f);
            Produto p4 = new Produto(4, "Celeste", 22.9f);

    
            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);

            cart.MostrarProdutos();

          Produto p5 = new Produto(5, "GTA San Andreas", 120f);
          cart.AlterarItem(1, p5);

          cart.MostrarProdutos();

        }
    }
}