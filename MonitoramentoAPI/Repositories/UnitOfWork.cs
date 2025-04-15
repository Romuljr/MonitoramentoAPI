using Microsoft.EntityFrameworkCore.Storage;
using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //atributos 
        private readonly SqlServerContext context;
        private IDbContextTransaction transaction;

        public UnitOfWork(SqlServerContext context)
        {
            this.context = context;
        }

        public IFuncionarioRepository funcionarioRepository => new FuncionarioRepository(context);

        public IRastreamentoRepository rastreamentoRepository => new RastreamentoRepository(context);

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }
    }
}
