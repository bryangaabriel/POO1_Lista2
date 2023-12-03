using System;

public class Ex27
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex27");
        // Código do Ex27...
        // Solicita ao usuário a quantidade de números a serem processados
        Console.Write("Digite a quantidade de números a serem processados: ");
        int quantidade = int.Parse(Console.ReadLine());

        // Loop para processar cada número e calcular o fatorial
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            int numero = int.Parse(Console.ReadLine());

            // Calcula e exibe o fatorial do número
            long fatorial = CalcularFatorial(numero);
            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para calcular o fatorial de um número
    static long CalcularFatorial(int numero)
    {
        if (numero < 0)
        {
            Console.WriteLine("Não é possível calcular o fatorial de um número negativo.");
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
