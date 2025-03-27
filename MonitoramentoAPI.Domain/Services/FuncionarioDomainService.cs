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
    public class FuncionarioDomainService : BaseDomainService<Funcionario>, IFuncionarioDomainService
    {
        private readonly IUnitOfWork unitOfWork;

        public FuncionarioDomainService(IUnitOfWork unitOfWork) : base(unitOfWork.funcionarioRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
