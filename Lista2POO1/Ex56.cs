using System;

public class Ex56
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex56");
        // C�digo do Ex56...
        int tamanhoVetor = 50;
        int[] vetor = new int[tamanhoVetor];

        // Preenche o vetor com n�meros inteiros positivos
        PreencherVetor(vetor);

        // Imprime a quantidade de n�meros pares e m�ltiplos de 5
        ImprimirQuantidades(vetor);
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

        Console.WriteLine($"\nQuantidade de n�meros pares: {countPares}");
        Console.WriteLine($"Quantidade de n�meros m�ltiplos de 5: {countMultiplosDe5}");
    }
}
