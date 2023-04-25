// Capacidade: 
// Utilizar o paradigma da programação orientada a objetos 
// Tipo: Formativa


// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

namespace Projeto_Celular
{
    public class celular
    {
        // atributos/objetos
        public string Cor = azul;
        public string Modelo = moto-g7-play;
        public float Tamanho = 0.20f;
        public bool Ligado;

        //metodos
        public string LigarCelular()
        {
            return Console.WriteLine($"ligando...");
            
        }

        public string Desligar()
        {
            Console.WriteLine($"desligando...");
            
        }

        public string FazerLigacao()
        {
            Console.WriteLine($"ligando...");
            
        }

        public string EnviarMensagem()
        {
            Console.WriteLine($"enviando...");
            
        }
        
      
        

    }
}

