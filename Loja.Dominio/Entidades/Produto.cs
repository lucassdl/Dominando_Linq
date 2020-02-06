using System.Collections.Generic;

namespace Loja.Dominio.Entidades
{
    public class Produto
    {
        public Produto()
        {
            Produtos = new List<Produto>();
        }

        public List<Produto> ListarFrutas()
        {
            Produtos.Add(new Produto() { Nome = "Banana", Valor = 2, Categoria="Frutas" });
            Produtos.Add(new Produto() { Nome = "Morango", Valor = 25, Categoria = "Frutas" });
            Produtos.Add(new Produto() { Nome = "Pêra", Valor = 12, Categoria = "Frutas" });
            Produtos.Add(new Produto() { Nome = "Abacaxi", Valor = 4, Categoria = "Frutas" });
            Produtos.Add(new Produto() { Nome = "Melão", Valor = 5, Categoria = "Frutas" });

            return Produtos;
        }

        public List<Produto> ListarEletronicos()
        {
            Produtos.Add(new Produto() { Nome = "iPhone", Valor = 8000, Categoria = "Eletrônicos" });
            Produtos.Add(new Produto() { Nome = "Galaxy S7 Edge", Valor = 2000, Categoria = "Eletrônicos" });
            Produtos.Add(new Produto() { Nome = "Pen Drive", Valor = 35, Categoria = "Eletrônicos" });

            return Produtos;
        }

        public List<Produto> Produtos { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Categoria { get; set; }


        public override string ToString()
        {
            return $"Nome: {Nome}, Valor: {Valor}";
        }
    }
}
