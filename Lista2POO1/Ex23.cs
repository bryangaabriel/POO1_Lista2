using System;

public class Ex23
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex23");
        // C�digo do Ex23...
        int opcao;

        do
        {
            // Exibe o menu de op��es
            ExibirMenu();

            // Solicita ao usu�rio que escolha uma op��o
            Console.Write("Escolha uma op��o (ou 0 para sair): ");
            opcao = int.Parse(Console.ReadLine());

            // Executa a opera��o correspondente � op��o escolhida
            ExecutarOperacao(opcao);

        } while (opcao != 0);

        Console.WriteLine("Programa encerrado.");

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para exibir o menu de op��es
    static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma op��o:");
        Console.WriteLine("1 - Adi��o");
        Console.WriteLine("2 - Subtra��o");
        Console.WriteLine("3 - Multiplica��o");
        Console.WriteLine("4 - Divis�o");
        Console.WriteLine("0 - Sair");
    }

    // Fun��o para executar a opera��o correspondente � op��o escolhida
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
                Console.WriteLine("Op��o inv�lida. Tente novamente.");
                break;
        }
    }

    // Fun��o para realizar a opera��o de adi��o
    static void RealizarAdicao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo n�mero: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 + num2;
        Console.WriteLine($"Resultado da adi��o: {resultado}");
    }

    // Fun��o para realizar a opera��o de subtra��o
    static void RealizarSubtracao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo n�mero: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 - num2;
        Console.WriteLine($"Resultado da subtra��o: {resultado}");
    }

    // Fun��o para realizar a opera��o de multiplica��o
    static void RealizarMultiplicacao()
    {
        Console.Write("Digite o primeiro n�mero: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo n�mero: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 * num2;
        Console.WriteLine($"Resultado da multiplica��o: {resultado}");
    }

    // Fun��o para realizar a opera��o de divis�o
    static void RealizarDivisao()
    {
        Console.Write("Digite o numerador: ");
        double numerador = double.Parse(Console.ReadLine());

        Console.Write("Digite o denominador: ");
        double denominador = double.Parse(Console.ReadLine());

        if (denominador != 0)
        {
            double resultado = numerador / denominador;
            Console.WriteLine($"Resultado da divis�o: {resultado}");
        }
        else
        {
            Console.WriteLine("Erro: divis�o por zero.");
        }
    }
}
