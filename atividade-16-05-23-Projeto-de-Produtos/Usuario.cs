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
        public List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario()
        {
            // this.Nome = "Matheus";
            // this.Email = "Matheus@emaill";
            // this.Senha = "1234";
            // this.DataCadastro = DateTime.Now;
        }
        public void ConfiguraAdmin()
        {
            this.Nome = "Matheus";
            this.Email = "Matheus@emaill";
            this.Senha = "1234";
            this.DataCadastro = DateTime.Now;
        }

        public void Cadastrar()
        {


            Usuario us = new Usuario();


            Console.WriteLine($"insira seu nome");
            us.Nome = Console.ReadLine();


            Console.WriteLine($"insira seu email");
            us.Email = Console.ReadLine();

            Console.WriteLine($"insira sua senha");
            us.Senha = Console.ReadLine();

            ListaUsuario.Add(us);





        }

        public void Deletar()
        {
            // this.Nome = "";
            // this.Email = "";
            // this.Senha = "";
            // // Usuario user = new Usuario();
            // // log.Logar(user);


            Console.WriteLine($"digite a senha do usuario para remove-lo");
            Senha = (Console.ReadLine());

            Usuario us = ListaUsuario.Find(x => x.Senha == Senha);
            ListaUsuario.Remove(us);


        }

        public void Listar()
        {
            foreach (Usuario us in ListaUsuario)
            {
                Console.WriteLine($@"
             Nome: {us.Nome}
             Email: {us.Email}
             
            
             
             ");
            }
        }


    }
}