using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TargetSolutions.src.Desafios
{
    public class Questao5
    {
        public static string InverterString(string texto)
        {
            char[] caracteres = texto.ToCharArray();
            int inicio = 0;
            int fim = caracteres.Length - 1;

            while (inicio < fim)
            {
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;

                inicio++;
                fim--;
            }

            return new string(caracteres);
        }

        public static void Executar()
        {
            Console.Write("Digite uma string para inverter: ");
            string? entrada = Console.ReadLine();

            string textoSeguro = entrada ?? string.Empty;

            string invertida = InverterString(textoSeguro);
            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}