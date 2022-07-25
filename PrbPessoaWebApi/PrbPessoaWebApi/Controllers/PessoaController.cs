using Microsoft.AspNetCore.Mvc;
using PrbPessoaWebApi.App.Interfaces;
using PrbPessoaWebApi.App.ViewModel.ViewModels;

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
            try
            {
                return Ok(_apPessoaService.BuscarTodos());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}