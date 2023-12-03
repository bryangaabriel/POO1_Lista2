using System;

public class Ex27
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex27");
        // C�digo do Ex27...
        // Solicita ao usu�rio a quantidade de n�meros a serem processados
        Console.Write("Digite a quantidade de n�meros a serem processados: ");
        int quantidade = int.Parse(Console.ReadLine());

        // Loop para processar cada n�mero e calcular o fatorial
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o n�mero {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula e exibe o fatorial do n�mero
            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} �: {fatorial}");
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para calcular o fatorial de um n�mero
    static long CalcularFatorial(int numero)
    {
        if (numero < 0)
        {
            Console.WriteLine("N�o � poss�vel calcular o fatorial de um n�mero negativo.");
            return -1;
        }

        if (numero == 0 || numero == 1)
        {
            return 1;
        }

        long resultado = 1;
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}
