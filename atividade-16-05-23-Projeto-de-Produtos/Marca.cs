using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividade_16_05_23_Projeto_de_Produtos
{
    public class Marca
    {
        public int CodigoMarca { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro = DateTime.Now;

         public List<Marca> ListaMarca = new List<Marca>();




        public void Cadastrar()
        {
            Marca m = new Marca();
            
            Console.WriteLine($"informe o nome da marca");
              m.NomeMarca = Console.ReadLine();

            Console.WriteLine($"informe o codigo da marca");
            m.CodigoMarca = int.Parse(Console.ReadLine());

            Console.WriteLine($"*********************");
            
           
            
    	    ListaMarca.Add(m);
            
             

        }

        public void Remover()
        {
            // pedir o codigo da marca que vai ser removida
            Console.WriteLine($"digite o codigo da marca a ser removido");
            CodigoMarca = int.Parse(Console.ReadLine());

            // achar a marca dentro da lista procurando ela pelo codigo
            Marca m = ListaMarca.Find(x => x.CodigoMarca == CodigoMarca);

            // chamar a lista e remover a marca
            ListaMarca.Remove(m);

        }

        public void Listar()
        {
            foreach (Marca m in ListaMarca)
            {
                Console.WriteLine($@"
                
                Nome: {m.NomeMarca}
                codigo: {m.CodigoMarca}
                
                ");
                Console.WriteLine($"data: {DataCadastro}");
                
            }

        }


    }
}