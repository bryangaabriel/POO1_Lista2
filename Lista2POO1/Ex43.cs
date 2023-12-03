using System;

public class Ex43
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex43");
        // Código do Ex43...
        // Calcula o total de grãos usando a fórmula da progressão geométrica
        ulong totalDeGraos = CalcularTotalDeGraos();

        // Exibe o resultado
        Console.WriteLine($"O monge esperava receber um total de {totalDeGraos:N0} grãos de trigo.");
    }

    // Função para calcular o total de grãos usando a fórmula da progressão geométrica
    static ulong CalcularTotalDeGraos()
    {
        ulong total = 0;

        for (int i = 0; i < 64; i++)
        {
            total += (ulong)Math.Pow(2, i);
        }

        return total;
    }
}
