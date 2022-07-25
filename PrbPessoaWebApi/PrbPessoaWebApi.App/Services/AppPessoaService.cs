using PrbPessoaWebApi.App.Interfaces;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace PrbPessoaWebApi.App.Services
{
    public class AppPessoaService : IAppPessoaService
    {
        private readonly IPessoaService _serviceCliente;
        private readonly IPessoaMapper _mapper;

        public AppPessoaService(IPessoaService serviceCliente, IPessoaMapper mapper)
        {
            _serviceCliente = serviceCliente;
            _mapper = mapper;
        }

        public void Adicionar(PessoaViewModel obj)
        {
            var pessoa = _mapper.PessoaToViewModel(obj);
            _serviceCliente.Adicionar(pessoa);
        }

        public PessoaViewModel BuscarPorNomeEmail(string nome, string email)
        {
            var pessoa = _serviceCliente.BuscarPorNomeEmail(nome, email);

            return _mapper.PessoaViewToPessoa(pessoa);
        }

        public IEnumerable<PessoaViewModel> BuscarTodos()
        {
            var pessoa = _serviceCliente.BuscarTodos();
            if(string.IsNullOrEmpty(pessoa.ToString()))
            {
                return _mapper.ListViewModelToPessoa(pessoa);
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

        public void Update(PessoaViewModel obj)
        {
            var pessoa = _mapper.PessoaToViewModel(obj);
            _serviceCliente.Update(pessoa);
        }
    }
}