using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        // public Marca marca = new Marca();
        public Usuario CadastradoPor { get; set; }

        public List<Produto> ListaProduto = new List<Produto>();
         
         

        // Produto p = new Produto();

        public void Cadastrar()
        {
            // instanciar classe
            Produto p = new Produto();


            // chamar junto com o novo nome da classe

            Console.WriteLine($"informe o codigo");
             p.Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine($"informe o nome");
            p.NomeProduto = Console.ReadLine();

            Console.WriteLine($"informe o preço");
             p.Preco = float.Parse(Console.ReadLine());

            // Console.WriteLine($"informe a marca");
            // marca = Console.ReadLine();

            Console.WriteLine($"cadastro feito {CadastradoPor}");

            // Adicionar na lista
            ListaProduto.Add(p);





        }

        public void Listar()
        {
            foreach (Produto p in ListaProduto)
            {

                Console.WriteLine($@"
             Codigo: {p.Codigo}
             Nome: {p.NomeProduto}
             preco: {p.Preco :C}
            
             
             ");
                // Console.ReadLine();


            }
        }

        public void Deletar()
        {
            Console.WriteLine($"digite o produto a ser removido");
            Codigo = int.Parse(Console.ReadLine());
            
             Produto p = ListaProduto.Find(x => x.Codigo == Codigo);
            ListaProduto.Remove(p);

        }

    }
}