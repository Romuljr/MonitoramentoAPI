using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Entities
{
    public class Rastreamento
    {
        public int Id { get; set; }

        public DateTime DataAnalise { get; set; }

        public bool CurvasOk { get; set; }

        // Associação com Funcionário
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }

}
