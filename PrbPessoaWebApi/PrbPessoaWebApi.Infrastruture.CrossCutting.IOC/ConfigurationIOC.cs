using Autofac;
using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Domain.Services.Services;
using PrbPessoaWebApi.Repository.Repository;
using PrbPessoaWebApi.Domain.Core.Interfaces.Repository;
using PrbPessoaWebApi.App.Services;
using PrbPessoaWebApi.App.Interfaces;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace PrbPessoaWebApi.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {

        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<AppPessoaService>().As<IAppPessoaService>();
            #endregion

            #region IOC Services
            builder.RegisterType<PessoaService>().As<IPessoaService>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<PessoaRepository>().As<IPessoaService>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<PessoaMapper>().As<IPessoaMapper>();

            #endregion

            #endregion

        }
    }
}