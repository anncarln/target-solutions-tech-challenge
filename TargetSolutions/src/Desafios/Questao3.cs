using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TargetSolutions.src.Desafios
{
    public class Questao3
    {
        private class FaturamentoDiario
        {
            public int dia { get; set; }
            public double valor { get; set; }
        }

        public static void AnalisarFaturamento()
        {
            string caminhoArquivo = "data/dados.json";

            if (!File.Exists(caminhoArquivo))
            {
                Console.WriteLine("Arquivo de faturamento não encontrado!");
                return;
            }

            string json = File.ReadAllText(caminhoArquivo);
            List<FaturamentoDiario> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

            var diasUteis = faturamento.Where(d => d.valor > 0).ToList();

            if (diasUteis.Count == 0)
            {
                Console.WriteLine("Não há dados de faturamento para análise.");
                return;
            }

            double menorFaturamento = diasUteis.Min(d => d.valor);
            double maiorFaturamento = diasUteis.Max(d => d.valor);

            double mediaMensal = diasUteis.Average(d => d.valor);

            int diasAcimaDaMedia = diasUteis.Count(d => d.valor > mediaMensal);

            Console.WriteLine("Análise do Faturamento Diário:");
            Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2}");
            Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2}");
            Console.WriteLine($"Média mensal (dias úteis): R$ {mediaMensal:F2}");
            Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
    }
}