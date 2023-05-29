using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_gamer.Models;

namespace Projeto_gamer.Infra
{
    public class Context : DbContext
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
           {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-2B634JF; initial catalog = gamerTarde; Integrated Security = true; TrustServerCertificate = true");
           }
        }

        public DbSet<Jogador> Jogador {get;set;}
        public DbSet<Equipe> Equipe {get;set;}
    }
}