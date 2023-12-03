using System;

public class Ex32
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex32");
        // C�digo do Ex32...
        // Solicita ao usu�rio que insira um n�mero entre 1 e 9
        Console.Write("Digite um n�mero entre 1 e 9: ");
        int numeroInicial = int.Parse(Console.ReadLine());

        // Verifica se o n�mero est� dentro do intervalo permitido
        if (numeroInicial >= 1 && numeroInicial <= 9)
        {
            // Chama a fun��o para calcular e exibir a soma dos quadrados dos 20 primeiros n�meros �mpares
            CalcularESomarQuadradosImpares(numeroInicial);
        }
        else
        {
            Console.WriteLine("N�mero inv�lido. O n�mero deve ser entre 1 e 9.");
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para calcular e exibir a soma dos quadrados dos 20 primeiros n�meros �mpares
    static void CalcularESomarQuadradosImpares(int numeroInicial)
    {
        int somaQuadrados = 0;
        int contadorImpares = 0;

        Console.WriteLine($"Os 20 primeiros n�meros �mpares a partir de {numeroInicial} s�o:");

        // Loop para encontrar e somar os quadrados dos 20 primeiros n�meros �mpares
        for (int i = numeroInicial; contadorImpares < 20; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write($"{i} ");
                somaQuadrados += i * i;
                contadorImpares++;
            }
        }

        // Exibe a soma dos quadrados
        Console.WriteLine($"\nA soma dos quadrados dos 20 primeiros n�meros �mpares �: {somaQuadrados}");
    }
}
