using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// List<Personagem> list = new List<Personagem>();

// list.Add(p1);
namespace Poo_Tarde
{
    public class personagem
    {
        // atributos
        // nome,idade,armadura,IA
        public string nome;
        public int idade;
        public string armadura;

        public string ia;

        // metodos 
        // atacar,defender,restaurar armadura

        public void atacar()
        {
            Console.WriteLine($"o personagem atacou !!!");
            
        }
        public void defender()
        {
            Console.WriteLine($"o personagem defendeu !!!");
            
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"armadura restaurada !!!");
            
        }

    }
}