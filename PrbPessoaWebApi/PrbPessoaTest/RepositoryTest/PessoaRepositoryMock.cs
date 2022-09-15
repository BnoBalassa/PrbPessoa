using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrbPessoaTest.RepositoryTest
{
    public class PessoaRepositoryMock
    {
        public static Pessoa RetornaPessoa()
        {
            var pessoa = new Pessoa { Nome = "teste", Email = "teste" };
            return pessoa;
        }
    }
}
