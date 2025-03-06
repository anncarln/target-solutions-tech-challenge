using System;
using TargetSolutions.src.Desafios;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Desafio Técnico - Target Solutions ===");
            Console.WriteLine("Escolha uma questão para executar:");
            Console.WriteLine("1 - Questão 1");
            Console.WriteLine("2 - Questão 2");
            Console.WriteLine("3 - Questão 3");
            Console.WriteLine("4 - Questão 4");
            Console.WriteLine("5 - Questão 5");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ExecutarQuestao1();
                    break;
                case "2":
                    ExecutarQuestao2();
                    break;
                case "3":
                    ExecutarQuestao3();
                    break;
                case "4":
                    ExecutarQuestao4();
                    break;
                case "5":
                    ExecutarQuestao5();
                    break;
                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void ExecutarQuestao1()
    {
        Questao1.Executar();
    }

    static void ExecutarQuestao2()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            bool pertence = Questao2.PertenceFibonacci(numero);
            Console.WriteLine(pertence
                ? $"O número {numero} pertence à sequência de Fibonacci."
                : $"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        }
    }

    static void ExecutarQuestao3()
    {
        Console.WriteLine("Executando Questão 3...");
        Questao3.AnalisarFaturamento();
    }

    static void ExecutarQuestao4()
    {
        Console.WriteLine("Executando Questão 4...");
        Questao4.CalcularPercentualFaturamento();
    }

    static void ExecutarQuestao5()
    {
        Console.WriteLine("Executando Questão 5...");
        Questao5.Executar();
    }
}
