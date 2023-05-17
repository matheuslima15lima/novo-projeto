using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Marca
    {
        public int codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }




        public void Cadastrar()
        {
            
            this.DataCadastro=DateTime.Now;

        }

        public void Remover()
        {

        }

        public void Listar()
        {

        }


    }
}