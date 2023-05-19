using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Requisitos
// A classe Login deve ter um método que vai ser responsável por gerar os menus e todas as funcionalidades gerais do programa
// Para isso vamos seguir a linha de raciocínio abaixo:
// [ ] Criar estrutura do projeto
// [ ] Criar Classes
// [ ] Marca
// [ ] Usuário
// [ ] Produto
// [ ] Login
// [ ] Implementar a lógica nos métodos
// [ ] Na classe program.cs chamar apenas o construtor Login que vai gerar o menu e todas as outras opções.
// Dica: crie os métodos e atributos primeiro, e só depois comece a implementar as ações nos métodos, isso vai gerar uma 
// visão mais sistêmica de seu projeto.

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Login
    {

        Usuario user = new Usuario();
        Produto produto = new Produto();

        Marca marca = new Marca();
        public bool Logado { get; set; }



        public Login()
        {
            user.ConfiguraAdmin();

            Logar(user);
            if (Logado = true)
            {
                GerarMenu();
            }

            else
            {
                Logado = false;
                user.Cadastrar();
            }
        }


        public void Logar(Usuario usuario)
        {
            // user.Cadastrar();
            // user.Nome = "Matheus";
            // user.Email = "Matheus@emaill";
            // user.Senha = "1234";
            // user.DataCadastro = DateTime.Now;
           
            Console.WriteLine($"insira seu email");
            string email = Console.ReadLine();

            Console.WriteLine($"insira sua senha");
            string senha = Console.ReadLine();


            if (senha == user.Senha && email == user.Email)
            {
                this.Logado = true;

            }
             else
            {
                this.Logado = false;
                
                
                             //   this.Logado = false;
                    Console.WriteLine($"erro!!! escreva novamente");

                    Console.WriteLine($"Email:");
                     email = Console.ReadLine();


                    Console.WriteLine($"Senha:");
                     senha = Console.ReadLine();

                    
                 
            }




            // else
            // {
            //      this.Logado = false;
            // //         do
            // //         {
            // //             this.Logado = false;
            // //         Console.WriteLine($"erro!!! escreva novamente");

            // //         Console.WriteLine($"Email:");
            // //          email = Console.ReadLine();


            // //         Console.WriteLine($"Senha:");
            // //          senha = Console.ReadLine();

            // //         } while (false);
                  


                


            // }





        }

        // public void Deslogar()
        // {
        //     user.Cadastrar(); 

        //     this.Logado = false;
        // }

        public void GerarMenu()
        {
            string opcao;
            do
            {
                Console.WriteLine($@"
            
            escolha as opcoes

            [1] - Cadastrar Produto
            [2] - Listar Produtos
            [3] - Remover Produto
            ----------------------

            [4] - Cadastrar Marca
            [5] - Listar Marcas
            [6] - Remover Marca
            ---------------------

            [7]- cadastra usuario
            [8] - listar usuario
            [9] - deletar usuario

            [0] - Sair
            
            
            ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        produto.Cadastrar();
                        break;

                    case "2":
                        produto.Listar();
                        break;

                    case "3":
                        produto.Deletar();
                        break;

                    case "4":
                        marca.Cadastrar();
                        break;

                    case "5":
                        marca.Listar();
                        break;

                    case "6":
                        marca.Remover();
                        break;

                    case "7":
                        user.Cadastrar();
                        break;


                      case "8":  
                      user.Listar();
                      break;

                      case "9":
                      user.Deletar();
                      break;

                    case "0":
                        Console.WriteLine($"obrigado!!!");

                        break;

                    default:
                        Console.WriteLine($"opcao invalida");
                        break;
                }
            } while (opcao != "0");





        }
    }
}