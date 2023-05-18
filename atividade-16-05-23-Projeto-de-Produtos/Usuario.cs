using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Usuario
    {
        // Login log = new Login();
        public int codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Usuario>? ListaUsuario;

        public Usuario()
        {
            Cadastrar();
        }

        public void Cadastrar()
        {
            this.Nome = "Matheus";
            this.Email = "Matheus@emaill";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;

        }

        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            // Usuario user = new Usuario();
            // log.Logar(user);
            

        
           

        }


    }
}