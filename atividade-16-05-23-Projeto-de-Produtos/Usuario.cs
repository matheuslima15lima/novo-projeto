using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Usuario
    {
        private int codigo;
        private string? Nome;
        private string? Email;
        private string? Senha;
        private DateTime DataCadastro;
        public List<Usuario>? ListaUsuario;

        public string Cadastrar(Usuario _cadastro)
        {
            return ListaUsuario.Add();

        }

        public string Deletar(Usuario _cadastro)
        {
            return ListaUsuario.Remove();

        }


    }
}