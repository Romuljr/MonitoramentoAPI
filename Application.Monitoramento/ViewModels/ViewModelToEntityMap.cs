using AutoMapper;
using MonitoramentoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Application.ViewModels
{
    public class ViewModelToEntityMap : Profile
    {
        public ViewModelToEntityMap()
        {
            CreateMap<FuncionarioAddViewModels, Funcionario>().ForMember(dest => dest.Rastreamentos, opt => opt.MapFrom(src => src.Rastreamentos));

            CreateMap<RastreamentoFuncionarioAddViewModels, Rastreamento>();               
        }
    }
}
