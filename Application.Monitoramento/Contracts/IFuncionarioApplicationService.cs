using MonitoramentoAPI.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Application.Contracts
{
    public interface IFuncionarioApplicationService : IDisposable
    {
        void Add(FuncionarioAddViewModels model);
    }
}
