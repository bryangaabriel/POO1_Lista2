using System;

public class Ex64
{

    static int[] vetor; // Vetor global para ser utilizado em todos os métodos
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex64");
        // Código do Ex64...
        int opcao;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares");
            Console.WriteLine("7 - Sair");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CarregarVetor();
                        break;
                    case 2:
                        ListarVetor();
                        break;
                    case 3:
                        ExibirNumerosPares();
                        break;
                    case 4:
                        ExibirNumerosImpares();
                        break;
                    case 5:
                        ContarParesNasPosicoesImpares();
                        break;
                    case 6:
                        ContarImparesNasPosicoesPares();
                        break;
                    case 7:
                        Console.WriteLine("Saindo do programa. Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        } while (opcao != 7);
    }

    static void CarregarVetor()
    {
        Console.WriteLine("Digite o tamanho do vetor:");
        int tamanho = int.Parse(Console.ReadLine());

        vetor = new int[tamanho];

        Console.WriteLine("Digite os elementos do vetor:");

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso!");
    }

    static void ListarVetor()
    {
        Console.WriteLine("Vetor:");

        foreach (var numero in vetor)
        {
            Console.Write(numero + " ");
        }

        Console.WriteLine();
    }

    static void ExibirNumerosPares()
    {
        Console.WriteLine("Números pares do vetor:");

        foreach (var numero in vetor)
        {
            if (numero % 2 == 0)
            {
                Console.Write(numero + " ");
            }
        }

        Console.WriteLine();
    }

    static void ExibirNumerosImpares()
    {
        Console.WriteLine("Números ímpares do vetor:");

        foreach (var numero in vetor)
        {
            if (numero % 2 != 0)
            {
                Console.Write(numero + " ");
            }
        }

        Console.WriteLine();
    }

    static void ContarParesNasPosicoesImpares()
    {
        int contador = 0;

        for (int i = 1; i < vetor.Length; i += 2)
        {
            if (vetor[i] % 2 == 0)
            {
                contador++;
            }
        }

        Console.WriteLine($"Quantidade de números pares nas posições ímpares: {contador}");
    }

    static void ContarImparesNasPosicoesPares()
    {
        int contador = 0;

        for (int i = 0; i < vetor.Length; i += 2)
        {
            if (vetor[i] % 2 != 0)
            {
                contador++;
            }
        }

        Console.WriteLine($"Quantidade de números ímpares nas posições pares: {contador}");
    }
}
