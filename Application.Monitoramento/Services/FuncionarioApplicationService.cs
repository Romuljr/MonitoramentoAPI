using AutoMapper;
using MonitoramentoAPI.Application.Contracts;
using MonitoramentoAPI.Application.ViewModels;
using MonitoramentoAPI.Domain.Contracts.Services;
using MonitoramentoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Application.Services
{
    public class FuncionarioApplicationService : IFuncionarioApplicationService
    {
        private readonly IFuncionarioDomainService funcionarioDomainService;
        private IMapper mapper;

        public FuncionarioApplicationService(IFuncionarioDomainService funcionarioDomainService, IMapper mapper)
        {
            this.funcionarioDomainService = funcionarioDomainService;
            this.mapper = mapper;
        }

        public void Add(FuncionarioAddViewModels model)
        {
            var funcionario = mapper.Map<Funcionario>(model);
            funcionarioDomainService.Add(funcionario);
        }

        public void Dispose()
        {
            funcionarioDomainService.Dispose();
        }
    }
}
