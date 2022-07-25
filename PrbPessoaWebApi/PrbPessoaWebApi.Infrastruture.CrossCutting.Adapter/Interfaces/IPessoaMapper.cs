using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;

namespace PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces
{

    public interface IPessoaMapper
    {
        #region

        Pessoa PessoaToViewModel(PessoaViewModel pessoaViewModel);

        IEnumerable<PessoaViewModel> ListViewModelToPessoa(IEnumerable<Pessoa> pessoa);

        PessoaViewModel PessoaViewToPessoa(Pessoa pessoa);

        #endregion
    }

}