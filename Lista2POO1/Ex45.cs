using System;

public class Ex45
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex45");
        // C�digo do Ex45...
        Console.Write("Digite o tamanho da sequ�ncia de n�meros: ");
        int tamanho = int.Parse(Console.ReadLine());

        // Declara um vetor para armazenar os n�meros
        int[] numeros = new int[tamanho];

        // Preenche o vetor com os n�meros informados pelo usu�rio
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o n�mero {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Imprime a sequ�ncia na ordem inversa
        Console.WriteLine("\nSequ�ncia na ordem inversa:");
        for (int i = tamanho - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
