using MonitoramentoAPI.Domain.Entities;
using MonitoramentoAPI.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Application.ViewModels
{
    public class FuncionarioAddViewModels
    {
        [Required(ErrorMessage = "Informe o nome do funcionário.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o cargo do funcionário.")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Informe o email do funcionário.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do funcionário.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe a permissão do funcionário.")]
        public Permissao PermissaoRastreamento { get; set; }

        [Required(ErrorMessage = "Informe o departamento do funcionário.")]
        public string Departamento { get; set; }


        // Relação de um para muitos com Rastreamento
        public ICollection<Rastreamento> Rastreamentos { get; set; }

        // continua...
    }
}
