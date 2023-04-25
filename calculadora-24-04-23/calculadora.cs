//Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.

namespace calculadora_24_04_23
{
    public class Calculadora
    {

        // propriedades
        public float numero1;
        public float numero2;

        // metodos
        public float Somar()
        {
            return this.numero1 + this.numero2;
        }

        public float Subtrair()
        {
            return this.numero1 - this.numero2;
        }

        public float Multiplicar()
        {
            return this.numero1 * this.numero2;
        }

        public float Dividir()
        {
            return this.numero1 / this.numero2;
        }

    }


}


