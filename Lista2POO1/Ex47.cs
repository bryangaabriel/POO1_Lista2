using System;

public class Ex47
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex47");
        // Código do Ex47...
        // Tamanho do vetor
        int tamanho = 10;

        // Vetor de números inteiros positivos maiores que zero
        int[] vetor = new int[tamanho];

        // Preenche o vetor com números informados pelo usuário
        PreencherVetor(vetor);

        // Lê o número X
        Console.Write("Digite um número X: ");
        int numeroX = int.Parse(Console.ReadLine());

        // Conta quantos números no vetor são maiores que X, menores que X e iguais a X
        int maioresQueX = ContarMaioresQueX(vetor, numeroX);
        int menoresQueX = ContarMenoresQueX(vetor, numeroX);
        int iguaisAX = ContarIguaisAX(vetor, numeroX);

        // Exibe os resultados
        Console.WriteLine($"Números maiores que {numeroX}: {maioresQueX}");
        Console.WriteLine($"Números menores que {numeroX}: {menoresQueX}");
        Console.WriteLine($"Números iguais a {numeroX}: {iguaisAX}");
    }

    // Função para preencher um vetor com números informados pelo usuário
    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite 10 números inteiros positivos maiores que zero:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());

            // Verifica se o número é positivo e maior que zero
            while (vetor[i] <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
                Console.Write($"Número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para contar quantos números no vetor são maiores que X
    static int ContarMaioresQueX(int[] vetor, int x)
    {
        int contador = 0;

        foreach (int numero in vetor)
        {
            if (numero > x)
            {
                contador++;
            }
        }

        return contador;
    }

    // Função para contar quantos números no vetor são menores que X
    static int ContarMenoresQueX(int[] vetor, int x)
    {
        int contador = 0;

        foreach (int numero in vetor)
        {
            if (numero < x)
            {
                contador++;
            }
        }

        return contador;
    }

    // Função para contar quantos números no vetor são iguais a X
    static int ContarIguaisAX(int[] vetor, int x)
    {
        int contador = 0;

        foreach (int numero in vetor)
        {
            if (numero == x)
            {
                contador++;
            }
        }

        return contador;
    }
}
