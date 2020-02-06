using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Infra.Linq.Repositorio
{
    public class RepositorioDeCategoria
    {
        LojaLinqDataContext _ctx = new LojaLinqDataContext();

        public void AdicionarCategoria(string nome)
        {
            _ctx.Categorias.InsertOnSubmit(new Categoria() { Nome = nome });
            _ctx.SubmitChanges();
        }

        public void ExcluirCategoria(int id)
        {
            LojaLinqDataContext _ctx = new LojaLinqDataContext();

            try
            {
                var categoria = _ctx.Categorias.First(c => c.Id == id);
                if (categoria != null)
                {
                    _ctx.Categorias.DeleteOnSubmit(categoria);
                    _ctx.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Categoria.");
            }
        }

        public List<Produto> ListarProduto()
        {
            LojaLinqDataContext _ctx = new LojaLinqDataContext();

            return _ctx.Produtos.ToList();
        }
    }
}
