using System;

public class Ex48
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex48");
        // Código do Ex48...
        // Tamanho do vetor
        int tamanho = 20;

        // Vetores para armazenar os nomes e idades das candidatas
        string[] nomes = new string[tamanho];
        int[] idades = new int[tamanho];

        // Preenche os vetores com as informações das candidatas
        PreencherCandidatas(nomes, idades);

        // Imprime os nomes das candidatas aptas à campanha milionária
        ImprimirCandidatasAptas(nomes, idades);
    }

    // Função para preencher os vetores com informações das candidatas
    static void PreencherCandidatas(string[] nomes, int[] idades)
    {
        Console.WriteLine("Digite as informações das candidatas:");

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"Nome da candidata {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Idade da candidata {i + 1}: ");
            idades[i] = int.Parse(Console.ReadLine());

            // Verifica se a idade está entre 18 e 20 anos
            while (idades[i] < 18 || idades[i] > 20)
            {
                Console.WriteLine("A candidata deve ter entre 18 e 20 anos para participar da campanha.");
                Console.Write($"Idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para imprimir os nomes das candidatas aptas à campanha milionária
    static void ImprimirCandidatasAptas(string[] nomes, int[] idades)
    {
        Console.WriteLine("\nCandidatas aptas à campanha milionária:");

        for (int i = 0; i < nomes.Length; i++)
        {
            if (idades[i] >= 18 && idades[i] <= 20)
            {
                Console.WriteLine($"{nomes[i]} (Idade: {idades[i]} anos)");
            }
        }
    }
}
