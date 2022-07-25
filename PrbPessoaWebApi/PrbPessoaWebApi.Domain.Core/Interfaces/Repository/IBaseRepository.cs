
namespace PrbPessoaWebApi.Domain.Core.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public void Adicionar(TEntity obj);
        public TEntity BuscarPorNomeEmail(string nome, string email);
        public IEnumerable<TEntity> BuscarTodos();
        public void Update(TEntity obj);
        public void Delete(string obj);
        public void Dispose();

    }
}
