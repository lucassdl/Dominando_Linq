using Loja.Dominio.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            //var produto = new Produto();
            //var produtos = produto.ListarFrutas().Where(p => p.Valor > 4);

            //foreach (var item in produtos)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //new Produto().ListarFrutas().Where(p => p.Valor > 4).ToList().ForEach(p =>
            //    {
            //        Console.WriteLine(p.Nome);
            //        Console.WriteLine(p.Valor);
            //    });

            //var produtos = new Produto().ListarFrutas();

            //if (produtos.Any(p => p.Valor > 10))
            //{
            //    produtos.Where(p => p.Valor > 10)
            //        .Select(p => new { p.Nome, p.Valor })
            //        .ToList()
            //        .ForEach(p => Console.WriteLine(JsonConvert.SerializeObject(p)));
            //}

            //var produtosFrutas = new Produto().ListarFrutas();
            //var produtosEletronicos = new Produto().ListarEletronicos();

            //var produtos = new List<Produto>();
            //produtos.AddRange(produtosFrutas);
            //produtos.AddRange(produtosEletronicos);

            //produtos.ToList()
            //    .ForEach(p =>
            //{
            //    Console.WriteLine(JsonConvert.SerializeObject(p));
            //    Console.WriteLine();
            //});

            //Console.WriteLine("------- Consulta utilizando LINQ ----------");

            //var resultado = (from p in produtos
            //                 group p by p.Categoria into grupo
            //                 select new RelatorioProdutoPorCategoria
            //                 {
            //                     NomeDaCategoria = grupo.Key,
            //                     ValorMinimo = grupo.Min(x => x.Valor),
            //                     ValorMaximo = grupo.Max(x => x.Valor),
            //                     ValorTotal = grupo.Sum(x => x.Valor)
            //                 }).OrderBy(x => x.NomeDaCategoria).ToList();

            //resultado.ToList()
            //    .ForEach(p => Console.WriteLine(JsonConvert.SerializeObject(p)));

            //Console.WriteLine();
            //Console.WriteLine("------- Consulta utilizando LAMBDA ----------");

            //produtos.GroupBy(p => p.Categoria)
            //    .Select(x => new RelatorioProdutoPorCategoria
            //    {
            //        NomeDaCategoria = x.Key,
            //        ValorMaximo = x.Max(p => p.Valor),
            //        ValorMinimo = x.Min(p => p.Valor),
            //        ValorTotal = x.Sum(p => p.Valor)
            //    })
            //    .OrderBy(p => p.NomeDaCategoria)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(JsonConvert.SerializeObject(p)));

            //Valor do produto mais caro
            //var valorDoProdutoMaisCaro = produtos1.Max(p => p.Valor);

            ///Valor do produto mais caro
            //var valorMinimo = produtos1.Min(p => p.Valor);

            //Média do valor
            //var mediaValorDoEstoque = produtos1.Average(p => p.Valor);

            //Soma dos valores
            //var soma = produtos1.Sum(p => p.Valor);

            //Console.WriteLine(soma);

            //int[] numerosPares = { 2, 4, 6, 8, 10 };
            //int[] numerosImpares = { 1, 3, 5, 7, 9 };
            //int[] numerosMisturados = { 1, 2, 3, 4 };

            //var resultado = numerosMisturados.Intersect(numerosPares);
            //var resultado = numerosMisturados.Except(numerosImpares);
            //resultado.ToList().ForEach(p => Console.WriteLine(p));

            //var produtos2 = new List<Produto>();
            //produtos2.Add(new Produto() { Nome = "Galaxy", Valor = 2500 });
            //produtos2.Add(new Produto() { Nome = "iPhone X", Valor = 7900 });

            //produtos1.AddRange(produtos2);

            //produtos1.Where(p => p.Quantidade == 0)
            //    .Select(p => p.Nome)
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p));


            //var produtos = new List<Produto>();

            //var produto2 = produtos.FirstOrDefault();
            //var produto1 = produtos.First();

            //var produto2 = produtos.LastOrDefault();
            //var produto1 = produtos.Last();

            //var nomes = produtos
            //.Where(p => p.Nome.StartsWith("A") || p.Nome.EndsWith("o"))
            ////.Where(p => p.DataDeVencimento.Year.Equals(2019))
            //.Select(p => new { Name = p.Nome, Value = p.Valor, DiaDeVencimento = p.DataDeVencimento.Day })
            //.ToList();

            //nomes.ForEach(p =>
            //{
            //    //Console.WriteLine(JsonConvert.SerializeObject(p));
            //    Console.WriteLine(JsonConvert.SerializeObject(nomes));
            //    Console.WriteLine("");
            //});

            //var sequencia = Enumerable.Range(10, 5);
            //var repetir = Enumerable.Repeat("Lucas Lima", 12);

            //repetir.ToList().ForEach(p => Console.WriteLine(p));

            //Salvando Categorias com Entity Framework
            //new Infra.EF.Repositorio.RepositorioDeCategoria().AdicionarCategoria("Frutas");
            //new Infra.EF.Repositorio.RepositorioDeCategoria().AdicionarCategoria("Eletronicos");
            //new Infra.EF.Repositorio.RepositorioDeCategoria().ExcluirCategoria(6);

            //Salvando Categorias com LINQ
            //new Infra.Linq.Repositorio.RepositorioDeCategoria().AdicionarCategoria("Vestuários");
            //new Infra.Linq.Repositorio.RepositorioDeCategoria().AdicionarCategoria("Alimentos");
            //new Infra.Linq.Repositorio.RepositorioDeCategoria().ExcluirCategoria(5);

            Console.WriteLine("--------------- Entity Framework ---------------");
            var produtosEF = new Infra.EF.Repositorio.RepositorioDeCategoria().ListarProduto();
            produtosEF.ToList().ForEach(p => Console.WriteLine(p.NomeCategoria));

            Console.WriteLine("--------------- Linq To SQL ---------------");
            var produtosLinq = new Infra.EF.Repositorio.RepositorioDeCategoria().ListarProduto();
            produtosLinq.ToList().ForEach(p => Console.WriteLine(p.NomeCategoria));



            //try
            //{
            //    new Infra.EF.Repositorio.RepositorioDeCategoria().AlterarCategoria(6, "Alimentos");
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}


            Console.ReadKey();
        }
    }

    public class RelatorioProdutoPorCategoria
    {
        public string NomeDaCategoria { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public decimal ValorTotal { get; set; }
    }
}

