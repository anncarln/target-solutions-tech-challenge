using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetSolutions.src.Desafios
{
    public class Questao4
    {
        public static void CalcularPercentualFaturamento()
        {
            Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double faturamentoTotal = faturamentoPorEstado.Values.Sum();

            Console.WriteLine("Percentual de Faturamento por Estado:");
            foreach (var estado in faturamentoPorEstado)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"🔹 {estado.Key}: {percentual:F2}%");
            }

            Console.WriteLine($"\nFaturamento Total: R$ {faturamentoTotal:F2}");
        }
    }
}