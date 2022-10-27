using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Mapping;
using System.Diagnostics.CodeAnalysis;

namespace PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter
{
    [ExcludeFromCodeCoverage]
    public class ServiceExtension
    {
        public static void AddMapping(IServiceCollection service)
        {   
            service.AddSingleton(provedor => new MapperConfiguration(c =>
              
              c.AddProfile<ModelToView>()
              
            ).CreateMapper());

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Pessoa,PessoaViewModel>());
        }

        
    }
}
