using System;

public class Ex56
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex56");
        // Código do Ex56...
        int tamanhoVetor = 50;
        int[] vetor = new int[tamanhoVetor];

        // Preenche o vetor com números inteiros positivos
        PreencherVetor(vetor);

        // Imprime a quantidade de números pares e múltiplos de 5
        ImprimirQuantidades(vetor);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine($"Digite {vetor.Length} números inteiros positivos:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] < 0)
            {
                Console.WriteLine("Digite apenas números inteiros positivos.");
                i--; // Decrementa i para repetir a leitura do mesmo índice
            }
        }
    }

    static void ImprimirQuantidades(int[] vetor)
    {
        int countPares = 0;
        int countMultiplosDe5 = 0;

        foreach (int numero in vetor)
        {
            if (numero % 2 == 0)
            {
                countPares++;
            }

            if (numero % 5 == 0)
            {
                countMultiplosDe5++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {countPares}");
        Console.WriteLine($"Quantidade de números múltiplos de 5: {countMultiplosDe5}");
    }
}
