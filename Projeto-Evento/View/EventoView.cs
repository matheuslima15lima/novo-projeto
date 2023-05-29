using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;

namespace Projeto_Evento.View
{
    public class EventoView
    {
        public void Listar(List<Evento> evento)
        {
                foreach (var item in evento)
                {
                    Console.WriteLine($"\nNome: {item.Nome}");

                    Console.WriteLine($"Descrição: {item.Descricao}");

                    Console.WriteLine($"Data: {item.Data}");
                    
                    
                    
                }
        }

        public CadastrarEvento ()
        {
            Evento NovoEvento = new Evento();

               Console.WriteLine($"informe o Nome");
            NovoEvento.Nome = Console.ReadLine();

            Console.WriteLine($"Faça uma descrição do evento:");
            NovoEvento.Descricao = Console.ReadLine();
            
            Console.WriteLine($"informe a Data:");
            NovoEvento.Data = DateTime.Parse(Console.ReadLine());
        }
    }
}