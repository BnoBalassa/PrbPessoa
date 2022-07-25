using PrbPessoaWebApi.App.ViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrbPessoaWebApi.App.Interfaces
{
    public interface IAppPessoaService
    {
        void Adicionar(PessoaViewModel obj);
        PessoaViewModel BuscarPorNomeEmail(string nome, string email);
        IEnumerable<PessoaViewModel> BuscarTodos();
        void Update(PessoaViewModel obj);
        void delete(string email);
        void Dispose();
    }
}
