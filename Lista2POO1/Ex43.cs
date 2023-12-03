using System;

public class Ex43
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex43");
        // C�digo do Ex43...
        // Calcula o total de gr�os usando a f�rmula da progress�o geom�trica
        ulong totalDeGraos = CalcularTotalDeGraos();

        // Exibe o resultado
        Console.WriteLine($"O monge esperava receber um total de {totalDeGraos:N0} gr�os de trigo.");
    }

    // Fun��o para calcular o total de gr�os usando a f�rmula da progress�o geom�trica
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
