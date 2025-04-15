using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoramentoAPI.Domain.Exceptions.Funcionario
{
    public class EmailDeveSerUnicoException : Exception
    {
        private string email;

        public EmailDeveSerUnicoException(string email)
        {
            this.email = email;
        }

        public override string Message 
            => $"O email '{email}' informado já encontra-se cadastrado. ";
    }
}
