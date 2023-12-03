using System;

public class Ex49
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex49");
        // C�digo do Ex49...
        // Tamanho m�ximo dos vetores
        int tamanhoMaximo = 50;

        // Tamanho dos vetores
        Console.Write("Digite o tamanho dos vetores (m�ximo 50): ");
        int tamanho = int.Parse(Console.ReadLine());

        // Verifica se o tamanho informado n�o ultrapassa o m�ximo
        tamanho = Math.Min(tamanho, tamanhoMaximo);

        // Vetores de inteiros
        int[] v1 = new int[tamanho];
        int[] v2 = new int[tamanho];

        // Preenche os vetores com valores informados pelo usu�rio
        PreencherVetor("V1", v1);
        PreencherVetor("V2", v2);

        // Determina e imprime a quantidade de valores id�nticos nas mesmas posi��es
        int quantidadeIdenticos = ContarValoresIdenticos(v1, v2);
        Console.WriteLine($"Quantidade de valores id�nticos nas mesmas posi��es: {quantidadeIdenticos}");
    }

    // Fun��o para preencher um vetor com valores informados pelo usu�rio
    static void PreencherVetor(string nomeVetor, int[] vetor)
    {
        Console.WriteLine($"Digite os elementos do vetor {nomeVetor}:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    // Fun��o para contar a quantidade de valores id�nticos nas mesmas posi��es em dois vetores
    static int ContarValoresIdenticos(int[] vetor1, int[] vetor2)
    {
        int quantidadeIdenticos = 0;

        // Verifica se os vetores t�m o mesmo tamanho
        if (vetor1.Length != vetor2.Length)
        {
            Console.WriteLine("Os vetores devem ter o mesmo tamanho para contar valores id�nticos.");
            return 0;
        }

        // Conta a quantidade de valores id�nticos nas mesmas posi��es
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
