using System;

public class Ex47
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex47");
        // C�digo do Ex47...
        // Tamanho do vetor
        int tamanho = 10;

        // Vetor de n�meros inteiros positivos maiores que zero
        int[] vetor = new int[tamanho];

        // Preenche o vetor com n�meros informados pelo usu�rio
        PreencherVetor(vetor);

        // L� o n�mero X
        Console.Write("Digite um n�mero X: ");
        int numeroX = int.Parse(Console.ReadLine());

        // Conta quantos n�meros no vetor s�o maiores que X, menores que X e iguais a X
        int maioresQueX = ContarMaioresQueX(vetor, numeroX);
        int menoresQueX = ContarMenoresQueX(vetor, numeroX);
        int iguaisAX = ContarIguaisAX(vetor, numeroX);

        // Exibe os resultados
        Console.WriteLine($"N�meros maiores que {numeroX}: {maioresQueX}");
        Console.WriteLine($"N�meros menores que {numeroX}: {menoresQueX}");
        Console.WriteLine($"N�meros iguais a {numeroX}: {iguaisAX}");
    }

    // Fun��o para preencher um vetor com n�meros informados pelo usu�rio
    static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite 10 n�meros inteiros positivos maiores que zero:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"N�mero {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());

            // Verifica se o n�mero � positivo e maior que zero
            while (vetor[i] <= 0)
            {
                Console.WriteLine("Por favor, digite um n�mero inteiro positivo maior que zero.");
                Console.Write($"N�mero {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Fun��o para contar quantos n�meros no vetor s�o maiores que X
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

    // Fun��o para contar quantos n�meros no vetor s�o menores que X
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

    // Fun��o para contar quantos n�meros no vetor s�o iguais a X
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
