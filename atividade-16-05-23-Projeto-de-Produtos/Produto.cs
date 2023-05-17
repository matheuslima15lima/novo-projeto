using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string NomeProduto {get; set;}
        public float Preco;
        public DateTime DataCadastro {get; set;}
        public Marca marca = new Marca(); 
        public Usuario CadastradoPor {get; set;}

        public List<Produto> ListaProduto = new List<Produto>();
        
        public void Cadastrar()
        {
            Console.WriteLine($"informe o codigo");
            int Codigo = int.Parse(Console.ReadLine());
            
            
           Console.WriteLine($"informe o nome");
           string NomeProduto = Console.ReadLine();
           
           Console.WriteLine($"informe o preço");
           float Preco = float.Parse(Console.ReadLine());
           
           Console.WriteLine($"informe a marca");
           string marca = Console.ReadLine();
           
           Console.WriteLine($"cadastro feito{CadastradoPor}");
           
           
            
        }

        public void Listar()
        {
           foreach (Produto p  in ListaProduto)
           {
            
             Console.WriteLine($@"
             Codigo: {p.Codigo}
            Nome: {p.NomeProduto}
            preco: {p.Preco}
            marca: {p.marca}
             
             ");
             
           }
        }

        public void Deletar()
        {

        }

    }
}