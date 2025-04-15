using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Domain.Contracts.Services;
using MonitoramentoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Services
{
    public class RastreamentoDomainService : BaseDomainService<Rastreamento>, IRastreamentoDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public RastreamentoDomainService(IUnitOfWork unitOfWork) : base(unitOfWork.rastreamentoRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
