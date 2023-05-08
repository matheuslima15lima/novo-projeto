// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

namespace exercicio_01
{
    public class Elevador
    {
        public int terreo { get; set; } = 0;
        public int TotalAndares { get; set; } = 3;
        public int Capacidade { get; set; } = 6;
        public int PessoasPresentes { get; set; }

        public int AndarAtual { get; set; } = 0;

        // metodos
        public void Inicicializar(int Capacidade)
        {

        }

        public void Inicicializar(int Capacidade, int TotalAndares)
        {
            Console.WriteLine($@"
            capacidade = {Capacidade} 
            total de andares {TotalAndares}
            
            
            
            ");

            Console.WriteLine($@"
            qual andar voce quer?
            [1]
            [2]
            [3]
            
            ");






        }

        public void Subir()
        {

            Console.WriteLine($"deseja subir?");
            Sobe Console.ReadLine();
            
            if (AndarAtual < 10)
            {
                AndarAtual += 1;
            }
            else
            {
                Console.WriteLine($"Você já está no último andar!!!");
            }

        }

        public void Descer()
        {
            if (AndarAtual != 0)
        {
            AndarAtual -=1;
        }
        else{
            Console.WriteLine($"Não há como descer mais do que isso");
            
        }

        }

        public void Entrar()
        {
            Console.WriteLine($"Quantas pessoas estao no elevador?");
            this.PessoasPresentes = int.Parse(Console.ReadLine());

            if (this.PessoasPresentes >= this.Capacidade)
            {
                Console.WriteLine($"nao pode entrar , ja ta cheio");
            }

            else
            {
                Console.WriteLine($"pode entrar");
            }



        }

        public void Sair()
        {

            if (PessoasPresentes != 0)
            {
                PessoasPresentes -= 1;
            }
            else
            {
                Console.WriteLine($"Não tem ninguém no elevador");

            }


        }
    }
}
