using Microsoft.AspNetCore.Mvc;
using PrbPessoaWebApi.App.Interfaces;
using PrbPessoaWebApi.App.ViewModel.ViewModels;
using PrbPessoaWebApi.Domain.Models;

namespace PrbPessoaWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        private readonly IAppPessoaService _apPessoaService;

        public PessoaController(IAppPessoaService apPessoaService)
        {
            _apPessoaService = apPessoaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PessoaViewModel>> Buscar()
        {
            var pessoas = _apPessoaService.BuscarTodos();
            if (pessoas != null)
                return Ok(pessoas);

            return BadRequest("Nenhum cliente cadastrado");
        }

        [HttpPost]
        public ActionResult Cadastrar([FromBody] PessoaViewModel pessoa)
        {
            try
            {
                _apPessoaService.Adicionar(pessoa);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public void AtualizarCadastro([FromBody] AtualizarPessoaViewModel atualizarPessoa)
        {
            try
            {
                _apPessoaService.Update(atualizarPessoa);

            }catch(Exception e)
            {
                throw new Exception("Nenhum cliente encontrado");
            }
        }
    }
}