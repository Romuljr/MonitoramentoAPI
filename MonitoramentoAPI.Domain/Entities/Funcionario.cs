using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitoramentoAPI.Domain.Enums;

namespace MonitoramentoAPI.Domain.Entities
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Permissao PermissaoRastreamento { get; set; }
        public string Departamento { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataAtualizacao { get; set; } = DateTime.UtcNow;

        // Relação de um para muitos com Rastreamento
        public ICollection<Rastreamento> Rastreamentos { get; set; } = new List<Rastreamento>();
    }

}
