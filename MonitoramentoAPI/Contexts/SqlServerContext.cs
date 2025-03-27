using Microsoft.EntityFrameworkCore;
using MonitoramentoAPI.Domain.Entities;
using MonitoramentoAPI.Infra.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Infra.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options)
            : base(options)
        {

        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Rastreamento> Rastreamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            modelBuilder.ApplyConfiguration(new RastreamentoMap());

            //Verificar posteriormente.
            modelBuilder.Entity<Funcionario>(f =>
            {
                f.HasIndex(f => f.Email).IsUnique();
            });
        }
    }
}

