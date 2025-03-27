using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Contracts.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        IFuncionarioRepository funcionarioRepository { get; }
        IRastreamentoRepository rastreamentoRepository { get; }

    }
}
