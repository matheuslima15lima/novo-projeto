using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Agenda
{
    public interface IContatoPessoal
    {
        public bool ValidarCpf(string _cpf);
    }
}