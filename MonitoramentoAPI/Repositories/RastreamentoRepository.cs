using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Domain.Entities;
using MonitoramentoAPI.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Infra.Repositories
{
    public class RastreamentoRepository : BaseRepository<Rastreamento>, IRastreamentoRepository
    {
        private readonly SqlServerContext context;

        public RastreamentoRepository(SqlServerContext context) : base(context) 
        {
            this.context = context;
        }
    }
}
