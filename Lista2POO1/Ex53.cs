using System;

public class Ex53
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex53");
        // Código do Ex53...
        Console.Write("Digite a quantidade de voltas: ");
        int quantidadeVoltas = int.Parse(Console.ReadLine());

        if (quantidadeVoltas <= 0)
        {
            Console.WriteLine("A quantidade de voltas deve ser maior que zero.");
            return;
        }

        double[] tempos = new double[quantidadeVoltas];

        // Preenche o array com os tempos das voltas
        for (int i = 0; i < quantidadeVoltas; i++)
        {
            Console.Write($"Digite o tempo da volta {i + 1} (em segundos): ");
            tempos[i] = double.Parse(Console.ReadLine());

            if (tempos[i] < 0)
            {
                Console.WriteLine("O tempo da volta não pode ser negativo.");
                return;
            }
        }

        // Calcula o melhor tempo e a volta em que ocorreu
        double melhorTempo = double.MaxValue;
        int voltaMelhorTempo = -1;

        for (int i = 0; i < quantidadeVoltas; i++)
        {
            if (tempos[i] < melhorTempo)
            {
                melhorTempo = tempos[i];
                voltaMelhorTempo = i + 1;
            }
        }

        // Calcula o tempo médio das voltas
        double tempoMedio = 0;

        for (int i = 0; i < quantidadeVoltas; i++)
        {
            tempoMedio += tempos[i];
        }

        tempoMedio /= quantidadeVoltas;

        // Exibe os resultados
        Console.WriteLine($"\nMelhor tempo: {melhorTempo} segundos");
        Console.WriteLine($"Volta em que o melhor tempo ocorreu: {voltaMelhorTempo}");
        Console.WriteLine($"Tempo médio das voltas: {tempoMedio} segundos");
    }
}
