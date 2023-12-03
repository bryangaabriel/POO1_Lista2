using System;

public class Ex32
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex32");
        // Código do Ex32...
        // Solicita ao usuário que insira um número entre 1 e 9
        Console.Write("Digite um número entre 1 e 9: ");
        int numeroInicial = int.Parse(Console.ReadLine());

        // Verifica se o número está dentro do intervalo permitido
        if (numeroInicial >= 1 && numeroInicial <= 9)
        {
            // Chama a função para calcular e exibir a soma dos quadrados dos 20 primeiros números ímpares
            CalcularESomarQuadradosImpares(numeroInicial);
        }
        else
        {
            Console.WriteLine("Número inválido. O número deve ser entre 1 e 9.");
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para calcular e exibir a soma dos quadrados dos 20 primeiros números ímpares
    static void CalcularESomarQuadradosImpares(int numeroInicial)
    {
        int somaQuadrados = 0;
        int contadorImpares = 0;

        Console.WriteLine($"Os 20 primeiros números ímpares a partir de {numeroInicial} são:");

        // Loop para encontrar e somar os quadrados dos 20 primeiros números ímpares
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
        Console.WriteLine($"\nA soma dos quadrados dos 20 primeiros números ímpares é: {somaQuadrados}");
    }
}
