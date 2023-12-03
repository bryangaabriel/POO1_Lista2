using System;

public class Ex58
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex58");
        // C�digo do Ex58...
        Console.Write("Digite a quantidade de n�meros a serem armazenados: ");
        int quantidadeNumeros = int.Parse(Console.ReadLine());

        if (quantidadeNumeros <= 0)
        {
            Console.WriteLine("A quantidade de n�meros deve ser maior que zero.");
            return;
        }

        int[] numeros = new int[quantidadeNumeros];

        // Preenche o vetor com n�meros inteiros positivos
        PreencherVetor(numeros);

        // Calcula a m�dia e imprime o maior n�mero
        CalcularMediaEImprimirMaior(numeros);
    }

    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine($"Digite {vetor.Length} n�meros inteiros positivos:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"N�mero {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] < 0)
            {
                Console.WriteLine("Digite apenas n�meros inteiros positivos.");
                i--; // Decrementa i para repetir a leitura do mesmo �ndice
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

        Console.WriteLine($"\nM�dia dos n�meros: {media:F2}");
        Console.WriteLine($"Maior n�mero: {maior}");
    }
}
