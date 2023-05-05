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
        public int terreo { get; set; }
        public int TotalAndares  { get; set;} = 3;
        public int Capacidade { get; set;} = 6;
        public int PessoasPresentes { get; set; }

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
            
        }

        public void Subir()
        {
            Console.WriteLine($@"
            qual andar voce quer subir?
            [1]
            [2]
            [3]
            
            ");
            
        }

        public void Descer()
        {

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
    }
}
