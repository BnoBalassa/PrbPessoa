using AutoMapper;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Globalization;

namespace PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Mapping
{
    public class ModelToView : Profile
    {
        public ModelToView()
        {
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<AtualizarPessoaViewModel, Pessoa>();
            CreateMap<Pessoa, AtualizarPessoaViewModel>()
                .ForMember(e => e.Celular, a => a.MapFrom(j => j.Celular));
        }
    }
}
