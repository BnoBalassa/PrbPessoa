﻿using Autofac;


namespace PrbPessoaWebApi.Infrastruture.CrossCutting.IOC
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Carrega IOC

            ConfigurationIOC.Load(builder);

            #endregion
        }
    }
}
