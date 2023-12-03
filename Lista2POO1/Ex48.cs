using System;

public class Ex48
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex48");
        // C�digo do Ex48...
        // Tamanho do vetor
        int tamanho = 20;

        // Vetores para armazenar os nomes e idades das candidatas
        string[] nomes = new string[tamanho];
        int[] idades = new int[tamanho];

        // Preenche os vetores com as informa��es das candidatas
        PreencherCandidatas(nomes, idades);

        // Imprime os nomes das candidatas aptas � campanha milion�ria
        ImprimirCandidatasAptas(nomes, idades);
    }

    // Fun��o para preencher os vetores com informa��es das candidatas
    static void PreencherCandidatas(string[] nomes, int[] idades)
    {
        Console.WriteLine("Digite as informa��es das candidatas:");

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"Nome da candidata {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Idade da candidata {i + 1}: ");
            idades[i] = int.Parse(Console.ReadLine());

            // Verifica se a idade est� entre 18 e 20 anos
            while (idades[i] < 18 || idades[i] > 20)
            {
                Console.WriteLine("A candidata deve ter entre 18 e 20 anos para participar da campanha.");
                Console.Write($"Idade da candidata {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Fun��o para imprimir os nomes das candidatas aptas � campanha milion�ria
    static void ImprimirCandidatasAptas(string[] nomes, int[] idades)
    {
        Console.WriteLine("\nCandidatas aptas � campanha milion�ria:");

        for (int i = 0; i < nomes.Length; i++)
        {
            if (idades[i] >= 18 && idades[i] <= 20)
            {
                Console.WriteLine($"{nomes[i]} (Idade: {idades[i]} anos)");
            }
        }
    }
}
