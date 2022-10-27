using AutoMapper;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;


namespace PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Mapping
{
    public class ModelToView : Profile
    {
        public ModelToView()
        {
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<PessoaViewModel, Pessoa>();
        }
    }
}
