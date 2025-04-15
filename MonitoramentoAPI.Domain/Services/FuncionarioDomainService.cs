using MonitoramentoAPI.Domain.Contracts.Data;
using MonitoramentoAPI.Domain.Contracts.Services;
using MonitoramentoAPI.Domain.Entities;
using MonitoramentoAPI.Domain.Exceptions.Funcionario;
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

        public override void Add(Funcionario funcionario)
        {
            if (unitOfWork.funcionarioRepository.Find(f => f.Email.Equals(funcionario.Email)) != null) throw new EmailDeveSerUnicoException(funcionario.Email);
            

            try
            {
                unitOfWork.BeginTransaction();

                unitOfWork.funcionarioRepository.Insert(funcionario);

                foreach ( var rastreamento in funcionario.Rastreamentos)
                {
                    rastreamento.FuncionarioId = funcionario.Id;
                    unitOfWork.rastreamentoRepository.Insert(rastreamento);
                }

                unitOfWork.Commit();
            }
            catch (Exception e)
            {
                unitOfWork.Rollback();
                throw new Exception(e.Message);
            }
        }
    }
}
