using AutoMapper;
using PrbPessoaWebApi.App.Interfaces;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Domain.Models;
using System.Reflection.Metadata.Ecma335;

namespace PrbPessoaWebApi.App.Services
{
    public class AppPessoaService : IAppPessoaService
    {
        private readonly IPessoaService _serviceCliente;
        private readonly IMapper _mapper;

        public AppPessoaService(IPessoaService serviceCliente, IMapper mapper)
        {
            _serviceCliente = serviceCliente;
            _mapper = mapper;
        }

        public void Adicionar(PessoaViewModel obj)
        {
            var pessoa = _mapper.Map<Pessoa>(obj);
            _serviceCliente.Adicionar(pessoa);
        }

        public PessoaViewModel BuscarPorNomeEmail(string nome, string email)
        {
            var pessoa = _serviceCliente.BuscarPorNomeEmail(nome, email);

            PessoaViewModel model = _mapper.Map<PessoaViewModel>(pessoa);
            return model;
        }

        public IEnumerable<PessoaViewModel> BuscarTodos()
        {
            var pessoa = _serviceCliente.BuscarTodos();
            if (!string.IsNullOrEmpty(pessoa.ToString()))
            {
                var model = _mapper.Map<IEnumerable<PessoaViewModel>>(pessoa);
                return model;
            }
            return null;
        }

        public void delete(string email)
        {
            _serviceCliente.Delete(email);
        }

        public void Dispose()
        {
            _serviceCliente.Dispose();
        }

        public void Update(AtualizarPessoaViewModel obj)
        {
            var pessoa = _serviceCliente.BuscarPorNomeEmail(obj.Nome, obj.Email);
            if(pessoa != null)
            {
                pessoa.Celular = obj.Celular;
                _serviceCliente.Update(pessoa);
            }
          
        }
    }
}