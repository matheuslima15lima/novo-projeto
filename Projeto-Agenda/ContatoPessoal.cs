using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Agenda
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf;

        public bool ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}