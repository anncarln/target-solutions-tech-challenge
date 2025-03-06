using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetSolutions.src.Desafios
{
    public class Questao1
    {
        public static int CalcularSoma()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            return SOMA;
        }

        public static void Executar()
        {
            Console.WriteLine("Executando Questão 1...");
            int resultado = CalcularSoma();
            Console.WriteLine($"O valor final de SOMA é: {resultado}");
        }
    }
}