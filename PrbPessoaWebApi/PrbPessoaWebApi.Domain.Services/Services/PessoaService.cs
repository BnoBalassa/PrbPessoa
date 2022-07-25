using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Domain.Core.Interfaces.Repository;
using PrbPessoaWebApi.Domain.Models;

namespace PrbPessoaWebApi.Domain.Services.Services
{
    public class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        public readonly IPessoaRepository _repo;

        public PessoaService(IPessoaRepository repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
