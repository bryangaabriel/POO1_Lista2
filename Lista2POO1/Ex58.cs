using System;

public class Ex58
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex58");
        // Código do Ex58...
        Console.Write("Digite a quantidade de números a serem armazenados: ");
        int quantidadeNumeros = int.Parse(Console.ReadLine());

        if (quantidadeNumeros <= 0)
        {
            Console.WriteLine("A quantidade de números deve ser maior que zero.");
            return;
        }

        int[] numeros = new int[quantidadeNumeros];

        // Preenche o vetor com números inteiros positivos
        PreencherVetor(numeros);

        // Calcula a média e imprime o maior número
        CalcularMediaEImprimirMaior(numeros);
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

    static void CalcularMediaEImprimirMaior(int[] vetor)
    {
        int soma = 0;
        int maior = int.MinValue;

        foreach (int numero in vetor)
        {
            soma += numero;

            if (numero > maior)
            {
                maior = numero;
            }
        }

        double media = (double)soma / vetor.Length;

        Console.WriteLine($"\nMédia dos números: {media:F2}");
        Console.WriteLine($"Maior número: {maior}");
    }
}
