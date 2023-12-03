using System;

public class Ex24
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex24");
        // Código do Ex24...
        int numero1, numero2;
        int opcao;

        // Solicita ao usuário que insira dois números inteiros
        Console.Write("Digite o primeiro número inteiro: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        numero2 = int.Parse(Console.ReadLine());

        do
        {
            // Exibe o menu de opções
            ExibirMenu();

            // Solicita ao usuário que escolha uma opção
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            // Executa a operação correspondente à opção escolhida
            ExecutarOperacao(opcao, numero1, numero2);

        } while (opcao != 4);

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para exibir o menu de opções
    static void ExibirMenu()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Verificar se um dos números é múltiplo do outro");
        Console.WriteLine("2 - Verificar se os dois números são pares");
        Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
        Console.WriteLine("4 - Sair");
    }

    // Função para executar a operação correspondente à opção escolhida
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
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }

    // Função para verificar se um dos números é múltiplo do outro
    static void VerificarMultiplo(int a, int b)
    {
        if (a % b == 0 || b % a == 0)
        {
            Console.WriteLine("Um dos números é múltiplo do outro.");
        }
        else
        {
            Console.WriteLine("Os números não são múltiplos entre si.");
        }
    }

    // Função para verificar se os dois números são pares
    static void VerificarPares(int a, int b)
    {
        if (a % 2 == 0 && b % 2 == 0)
        {
            Console.WriteLine("Os dois números são pares.");
        }
        else
        {
            Console.WriteLine("Pelo menos um dos números não é par.");
        }
    }

    // Função para verificar se a média dos dois números é maior ou igual a 7
    static void VerificarMedia(int a, int b)
    {
        double media = (a + b) / 2.0;

        if (media >= 7)
        {
            Console.WriteLine($"A média dos dois números é {media} e é maior ou igual a 7.");
        }
        else
        {
            Console.WriteLine($"A média dos dois números é {media} e é menor que 7.");
        }
    }
}
