using Microsoft.EntityFrameworkCore;
using PrbPessoaWebApi.Domain.Core.Interfaces.Repository;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastructure.Data;

namespace PrbPessoaWebApi.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext _Context;

        public BaseRepository(SqlContext sqlContext)
        {
            this._Context = sqlContext;
        }
            
        public virtual void Adicionar(TEntity obj)
        {
            try
            {
                _Context.Set<TEntity>().Add(obj);
                _Context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public virtual Pessoa BuscarPorNomeEmail(string nome, string email)
        {
            try
            {
                return _Context.pessoa.FirstOrDefault(e => e.Email == email && e.Nome == nome);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<TEntity> BuscarTodos()
        {
            return _Context.Set<TEntity>().ToList();
        }

        public void Delete(string obj)
        {
             _Context.Remove(obj);
            _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }

        public void Update(TEntity obj)
        {
            _Context.Entry(obj).State = EntityState.Modified;
            _Context.SaveChanges();
        }
    }
}