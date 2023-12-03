using System;

public class Ex45
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex45");
        // Código do Ex45...
        Console.Write("Digite o tamanho da sequência de números: ");
        int tamanho = int.Parse(Console.ReadLine());

        // Declara um vetor para armazenar os números
        int[] numeros = new int[tamanho];

        // Preenche o vetor com os números informados pelo usuário
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Imprime a sequência na ordem inversa
        Console.WriteLine("\nSequência na ordem inversa:");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
