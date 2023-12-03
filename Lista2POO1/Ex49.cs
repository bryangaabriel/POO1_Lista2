using System;

public class Ex49
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex49");
        // Código do Ex49...
        // Tamanho máximo dos vetores
        int tamanhoMaximo = 50;

        // Tamanho dos vetores
        Console.Write("Digite o tamanho dos vetores (máximo 50): ");
        int tamanho = int.Parse(Console.ReadLine());

        // Verifica se o tamanho informado não ultrapassa o máximo
        tamanho = Math.Min(tamanho, tamanhoMaximo);

        // Vetores de inteiros
        int[] v1 = new int[tamanho];
        int[] v2 = new int[tamanho];

        // Preenche os vetores com valores informados pelo usuário
        PreencherVetor("V1", v1);
        PreencherVetor("V2", v2);

        // Determina e imprime a quantidade de valores idênticos nas mesmas posições
        int quantidadeIdenticos = ContarValoresIdenticos(v1, v2);
        Console.WriteLine($"Quantidade de valores idênticos nas mesmas posições: {quantidadeIdenticos}");
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

    // Função para contar a quantidade de valores idênticos nas mesmas posições em dois vetores
    static int ContarValoresIdenticos(int[] vetor1, int[] vetor2)
    {
        int quantidadeIdenticos = 0;

        // Verifica se os vetores têm o mesmo tamanho
        if (vetor1.Length != vetor2.Length)
        {
            Console.WriteLine("Os vetores devem ter o mesmo tamanho para contar valores idênticos.");
            return 0;
        }

        // Conta a quantidade de valores idênticos nas mesmas posições
        for (int i = 0; i < vetor1.Length; i++)
        {
            if (vetor1[i] == vetor2[i])
            {
                quantidadeIdenticos++;
            }
        }

        return quantidadeIdenticos;
    }
}
