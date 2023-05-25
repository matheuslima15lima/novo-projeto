using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Evento
    {
        public string Nome;
        public string Descricao;
        public DateTime Data;


        private const string PATH = "Database/Produto.csv";
        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        // metodo para ler os dados do arquivo csv
        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();
            string Linhas = File.ReadAllLines(PATH);

            foreach (var item in Linhas)
            {
                string[] Atributos = item.Split(";");
                Evento eve = new Evento();

                eve.Nome = Atributos[0];
                eve.Descricao = Atributos[1];
                eve.Data = Atributos[2];

                eventos.Add(eve);
            }

            return eventos;
        }


        public string PrepararLinhasCSV(Evento eve)
        {
            return $"{eve.Codigo};{eve.Nome};{eve.Preco}";
        }


        public void inserir(Evento eve)
        {
            string[] linhas = { PrepararLinhasCSV(eve) };

            File.AppendAllLines(Path, linhas);
        }




    }
}