using MonitoramentoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Contracts.Data
{
    public interface IRastreamentoRepository
        : IBaseRepository<Rastreamento>
    {
    }
}
