using System;

public class Ex37
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex37");
        // C�digo do Ex37...
        char opcao;

        do
        {
            // Exibe o menu principal
            Console.WriteLine("Calculadora B�sica");
            Console.WriteLine("1 - Adi��o");
            Console.WriteLine("2 - Subtra��o");
            Console.WriteLine("3 - Multiplica��o");
            Console.WriteLine("4 - Divis�o");
            Console.Write("Escolha uma op��o (1-4): ");

            // L� a op��o escolhida pelo usu�rio
            opcao = char.Parse(Console.ReadLine());

            // Executa a opera��o correspondente
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
                    Console.WriteLine("Op��o inv�lida. Tente novamente.");
                    break;
            }

            // Pergunta ao usu�rio se deseja voltar ao menu principal
            Console.Write("Deseja voltar ao menu principal? (S/n): ");
            opcao = char.Parse(Console.ReadLine());

        } while (opcao == 'S' || opcao == 's');
    }

    // Fun��o para realizar a opera��o selecionada
    static void RealizarOperacao(Func<double, double, double> operacao)
    {
        // Solicita ao usu�rio que digite dois n�meros
        Console.Write("Digite o primeiro n�mero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo n�mero: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Calcula e exibe o resultado da opera��o
        double resultado = operacao(numero1, numero2);
        Console.WriteLine($"Resultado: {resultado}");
    }

    // Fun��es para as opera��es matem�ticas
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
            Console.WriteLine("N�o � poss�vel dividir por zero.");
            return double.NaN; // Retorna Not-a-Number (NaN) em caso de divis�o por zero
        }
    }
}
