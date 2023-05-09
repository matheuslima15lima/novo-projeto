using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_09_05_23
{
    public class ConversorMoedas
    {
        public static float Moeda;


        public static float DolarParaReal(float dolar)
        {
            Moeda = dolar;

            float Real = (Moeda * 4.99f );

            return Real;

           
            
            
        }

        public static float RealParaDolar(float Real)
        {
            Moeda = Real;

            float Dolar = (Moeda * 0.20f);

            return Dolar;
        }
    }
}

