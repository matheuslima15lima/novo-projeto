using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_gamer.Models
{
    public class Jogador
    {
        [Key]
       public int IdJogador { get; set; }
       public string Nome { get; set; }
       public string Email { get; set; }
       public string Senha { get; set; }

       [ForeignKey("Equipe")]
       public int IdEquipe { get; set; }
       public Equipe Equipe {get;set;}
       
    }
}