using NSubstitute;
using PrbPessoaTest.RepositoryTest;
using PrbPessoaWebApi.App.Services;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace PrbPessoaTest.Services
{
    
    public class AppPessoaServiceTest
    {
        private IPessoaService _service;
        private IPessoaMapper _mapper;
        private AppPessoaService _appService;
        public AppPessoaServiceTest()
        {
            _service = Substitute.For<IPessoaService>();
            _mapper = Substitute.For<IPessoaMapper>();
            _appService = new AppPessoaService(_service, _mapper);
            
        }      

        [Fact]
        public void Deve_BuscaPessoaPeloNomeEmail_RetornaPessoa()
        {
            //Arrange
            (string nome, string email) = ("teste","teste");
            var pessoa = PessoaRepositoryMock.RetornaPessoa();
            _service.BuscarPorNomeEmail(nome, email).Returns(pessoa);

            //Act
            var res = _appService.BuscarPorNomeEmail(nome, email);

            //Assert
            Assert.Equal(nome, res.Nome);
        }

        [Fact]
        public void Deve_BuscaPessoaPeloNomeEmail_RetornaErro()
        {
            //Arrange
            (string nome, string email) = ("tet", "este");
            var pessoa = PessoaRepositoryMock.RetornaPessoa();
            _service.BuscarPorNomeEmail(nome, email).Returns(pessoa);

            //Act
            var res = _appService.BuscarPorNomeEmail(nome, email);

            //Assert
            Assert.NotEqual(nome, res.Nome);
        }
    }
}