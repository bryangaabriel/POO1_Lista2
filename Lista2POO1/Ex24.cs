using System;

public class Ex24
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex24");
        // C�digo do Ex24...
        int numero1, numero2;
        int opcao;

        // Solicita ao usu�rio que insira dois n�meros inteiros
        Console.Write("Digite o primeiro n�mero inteiro: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo n�mero inteiro: ");
        numero2 = int.Parse(Console.ReadLine());

        do
        {
            // Exibe o menu de op��es
            ExibirMenu();

            // Solicita ao usu�rio que escolha uma op��o
            Console.Write("Escolha uma op��o: ");
            opcao = int.Parse(Console.ReadLine());

            // Executa a opera��o correspondente � op��o escolhida
            ExecutarOperacao(opcao, numero1, numero2);

        } while (opcao != 4);

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para exibir o menu de op��es
    static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma op��o:");
        Console.WriteLine("1 - Verificar se um dos n�meros � m�ltiplo do outro");
        Console.WriteLine("2 - Verificar se os dois n�meros s�o pares");
        Console.WriteLine("3 - Verificar se a m�dia dos dois n�meros � maior ou igual a 7");
        Console.WriteLine("4 - Sair");
    }

    // Fun��o para executar a opera��o correspondente � op��o escolhida
    static void ExecutarOperacao(int opcao, int num1, int num2)
    {
        switch (opcao)
        {
            case 1:
                VerificarMultiplo(num1, num2);
                break;
            case 2:
                VerificarPares(num1, num2);
                break;
            case 3:
                VerificarMedia(num1, num2);
                break;
            case 4:
                Console.WriteLine("Saindo do programa.");
                break;
            default:
                Console.WriteLine("Op��o inv�lida. Tente novamente.");
                break;
        }
    }

    // Fun��o para verificar se um dos n�meros � m�ltiplo do outro
    static void VerificarMultiplo(int a, int b)
    {
        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Um dos n�meros � m�ltiplo do outro.");
        }
        else
        {
            Console.WriteLine("Os n�meros n�o s�o m�ltiplos entre si.");
        }
    }

    // Fun��o para verificar se os dois n�meros s�o pares
    static void VerificarPares(int a, int b)
    {
        if (a % 2 == 0 && b % 2 == 0)
        {
            Console.WriteLine("Os dois n�meros s�o pares.");
        }
        else
        {
            Console.WriteLine("Pelo menos um dos n�meros n�o � par.");
        }
    }

    // Fun��o para verificar se a m�dia dos dois n�meros � maior ou igual a 7
    static void VerificarMedia(int a, int b)
    {
        double media = (a + b) / 2.0;

        if (media >= 7)
        {
            Console.WriteLine($"A m�dia dos dois n�meros � {media} e � maior ou igual a 7.");
        }
        else
        {
            Console.WriteLine($"A m�dia dos dois n�meros � {media} e � menor que 7.");
        }
    }
}
