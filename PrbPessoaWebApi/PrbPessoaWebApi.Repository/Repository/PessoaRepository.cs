using PrbPessoaWebApi.Domain.Core.Services;
using PrbPessoaWebApi.Domain.Models;
using PrbPessoaWebApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrbPessoaWebApi.Repository.Repository
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaService
    {
        public PessoaRepository(SqlContext sqlContext) : base(sqlContext)
        {
        }
    }
}
