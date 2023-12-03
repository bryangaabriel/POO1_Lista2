using System;

public class Ex46
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex46");
        // Código do Ex46...
        Console.Write("Digite o tamanho dos vetores: ");
        int tamanho = int.Parse(Console.ReadLine());

        // Declara os vetores x e y
        int[] x = new int[tamanho];
        int[] y = new int[tamanho];

        // Preenche os vetores x e y com valores informados pelo usuário
        PreencherVetor("x", x);
        PreencherVetor("y", y);

        // Calcula o produto escalar dos vetores
        int produtoEscalar = CalcularProdutoEscalar(x, y);

        // Exibe o resultado
        Console.WriteLine($"O produto escalar dos vetores é: {produtoEscalar}");
    }

    // Função para preencher um vetor com valores informados pelo usuário
    static void PreencherVetor(string nomeVetor, int[] vetor)
    {
        Console.WriteLine($"Digite os elementos do vetor {nomeVetor}:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    // Função para calcular o produto escalar de dois vetores
    static int CalcularProdutoEscalar(int[] vetorX, int[] vetorY)
    {
        int produtoEscalar = 0;

        // Verifica se os vetores têm o mesmo tamanho
        if (vetorX.Length != vetorY.Length)
        {
            Console.WriteLine("Os vetores devem ter o mesmo tamanho para calcular o produto escalar.");
            return 0;
        }

        // Calcula o produto escalar
        for (int i = 0; i < vetorX.Length; i++)
        {
            produtoEscalar += vetorX[i] * vetorY[i];
        }

        return produtoEscalar;
    }
}
