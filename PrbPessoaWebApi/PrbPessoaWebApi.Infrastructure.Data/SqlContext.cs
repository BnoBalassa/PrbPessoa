using Microsoft.EntityFrameworkCore;
using PrbPessoaWebApi.Domain.Models;
using System;
using System.Linq;

namespace PrbPessoaWebApi.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> opt) : base(opt)
        {
            
        }

        public DbSet<Pessoa> pessoa { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("UpdatedDate").IsModified = false;
                }


            }

            return base.SaveChanges();
        }
    }
}
