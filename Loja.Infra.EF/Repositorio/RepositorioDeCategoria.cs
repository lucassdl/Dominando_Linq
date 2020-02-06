using System;
using System.Collections.Generic;
using System.Linq;

namespace Loja.Infra.EF.Repositorio
{
    public class RepositorioDeCategoria : IDisposable
    {
        private LojaEFEntities _ctx = null;

        public void AdicionarCategoria(string nome)
        {
            _ctx = new LojaEFEntities();

            try
            {
                _ctx.Categoria.Add(new Categoria() { Nome = nome });
                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao adicionar Categoria.");
            }
        }

        public void AlterarCategoria(int id, string nome = "")
        {
            _ctx = new LojaEFEntities();

            try
            {
                //var categoria = _ctx.Categoria.First(c => c.Id == id);
                var categoria = _ctx.Categoria.Find(id);
                categoria.Nome = nome;

                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Erro ao atualizar Categoria.");
            }
        }

        public void ExcluirCategoria(int id)
        {
            _ctx = new LojaEFEntities();

            try
            {
                var categoria = _ctx.Categoria.Find(id);
                _ctx.Categoria.Remove(categoria);

                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir Categoria.");
            }
        }

        public List<Produto> ListarProduto()
        {
            _ctx = new LojaEFEntities();

            return _ctx.Produto.ToList();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        
    }
}
