namespace PrbPessoaWebApi.Domain.Core.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity BuscarPorNomeEmail(string nome, string email);
        List<TEntity> BuscarTodos();
        void Update(TEntity obj);
        void Delete(string email);
        void Dispose();
    }
}