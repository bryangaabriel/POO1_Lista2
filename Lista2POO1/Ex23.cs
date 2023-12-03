using System;

public class Ex23
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex23");
        // Código do Ex23...
        int opcao;

        do
        {
            // Exibe o menu de opções
            ExibirMenu();

            // Solicita ao usuário que escolha uma opção
            Console.Write("Escolha uma opção (ou 0 para sair): ");
            opcao = int.Parse(Console.ReadLine());

            // Executa a operação correspondente à opção escolhida
            ExecutarOperacao(opcao);

        } while (opcao != 0);

        Console.WriteLine("Programa encerrado.");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para exibir o menu de opções
    static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("0 - Sair");
    }

    // Função para executar a operação correspondente à opção escolhida
    static void ExecutarOperacao(int opcao)
    {
        switch (opcao)
        {
            case 1:
                RealizarAdicao();
                break;
            case 2:
                RealizarSubtracao();
                break;
            case 3:
                RealizarMultiplicacao();
                break;
            case 4:
                RealizarDivisao();
                break;
            case 0:
                break; // Nada a ser feito para sair
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    // Função para realizar a operação de adição
    static void RealizarAdicao()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine($"Resultado da adição: {resultado}");
    }

    // Função para realizar a operação de subtração
    static void RealizarSubtracao()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine($"Resultado da subtração: {resultado}");
    }

    // Função para realizar a operação de multiplicação
    static void RealizarMultiplicacao()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine($"Resultado da multiplicação: {resultado}");
    }

    // Função para realizar a operação de divisão
    static void RealizarDivisao()
    {
        Console.Write("Digite o numerador: ");
        double numerador = double.Parse(Console.ReadLine());

        Console.Write("Digite o denominador: ");
        double denominador = double.Parse(Console.ReadLine());

        if (denominador != 0)
        {
            double resultado = numerador / denominador;
            Console.WriteLine($"Resultado da divisão: {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: divisão por zero.");
        }
    }
}
