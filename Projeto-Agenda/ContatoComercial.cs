using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Agenda
{
    public class ContatoComercial : Contato, IContatoComercial
    {
        public string Cnpj;

        public bool ValidarCnpj()
        {
           return true;
            
        }
    }
}