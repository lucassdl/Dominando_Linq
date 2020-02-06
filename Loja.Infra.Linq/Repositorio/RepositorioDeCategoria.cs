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
    }
}
