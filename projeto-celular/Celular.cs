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
    public class Celular
    {
        // atributos/objetos
        public string Cor;
        public string Modelo;
        public float Tamanho = 0.20f;
        public bool Ligado;
        

        //metodos
        public void LigarCelular()
        {
            Ligado = true;
            Console.WriteLine($"ligando...");
        }

        public void Desligar()
        {
            Ligado = false;
            Console.WriteLine($"desligando");
        }

        public void FazerLigacao()
        {
            Console.WriteLine($"fazendo ligacao...");
        }

        public void EnviarMensagem()
        {
                Console.WriteLine($"enviando mensagem...");
        }
    }
}