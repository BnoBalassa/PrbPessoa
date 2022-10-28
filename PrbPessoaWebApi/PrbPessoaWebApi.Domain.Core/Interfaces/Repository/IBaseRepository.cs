
using PrbPessoaWebApi.Domain.Models;

namespace PrbPessoaWebApi.Domain.Core.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        public void Adicionar(TEntity obj);
        public Pessoa BuscarPorNomeEmail(string nome, string email);
        public List<TEntity> BuscarTodos();
        public void Update(TEntity obj);
        public void Delete(string obj);
        public void Dispose();

    }
}
