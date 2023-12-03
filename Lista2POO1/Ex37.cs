using System;

public class Ex37
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex37");
        // Código do Ex37...
        char opcao;

        do
        {
            // Exibe o menu principal
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.Write("Escolha uma opção (1-4): ");

            // Lê a opção escolhida pelo usuário
            opcao = char.Parse(Console.ReadLine());

            // Executa a operação correspondente
            switch (opcao)
            {
                case '1':
                    RealizarOperacao(Adicao);
                    break;
                case '2':
                    RealizarOperacao(Subtracao);
                    break;
                case '3':
                    RealizarOperacao(Multiplicacao);
                    break;
                case '4':
                    RealizarOperacao(Divisao);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            // Pergunta ao usuário se deseja voltar ao menu principal
            Console.Write("Deseja voltar ao menu principal? (S/n): ");
            opcao = char.Parse(Console.ReadLine());

        } while (opcao == 'S' || opcao == 's');
    }

    // Função para realizar a operação selecionada
    static void RealizarOperacao(Func<double, double, double> operacao)
    {
        // Solicita ao usuário que digite dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Calcula e exibe o resultado da operação
        double resultado = operacao(numero1, numero2);
        Console.WriteLine($"Resultado: {resultado}");
    }

    // Funções para as operações matemáticas
    static double Adicao(double a, double b) => a + b;
    static double Subtracao(double a, double b) => a - b;
    static double Multiplicacao(double a, double b) => a * b;
    static double Divisao(double a, double b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
            return double.NaN; // Retorna Not-a-Number (NaN) em caso de divisão por zero
        }
    }
}
