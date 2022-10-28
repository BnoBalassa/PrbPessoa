using PrbPessoaWebApi.Domain.Core.Interfaces.Repository;
using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Domain.Models;
using System;
using System.Collections.Generic;
namespace PrbPessoaWebApi.Domain.Services.Services
{

    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repo;

        public BaseService(IBaseRepository<TEntity> repo)
        {
            _repo = repo;
        }
        public virtual void Adicionar(TEntity obj)
        {
            _repo.Adicionar(obj);
        }
        public virtual Pessoa BuscarPorNomeEmail(string nome, string email)
        { 
            var pessoa = _repo.BuscarPorNomeEmail(nome, email);
            return pessoa;
        }
        public virtual List<TEntity> BuscarTodos()
        {
            return _repo.BuscarTodos();
        }
        public virtual void Update(TEntity obj)
        {
            _repo.Update(obj);
        }
        public void Delete(string email)
        {
            _repo.Delete(email);
        }

        public virtual void Dispose()
        {
            _repo.Dispose();
        }

     
    }
}