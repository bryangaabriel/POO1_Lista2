using System;

public class Ex22
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex22");
        // Código do Ex22...
        int numero;
        int a = 0; // Variável para armazenar números positivos
        int b = 0; // Variável para armazenar números negativos

        // Solicita ao usuário que insira um número
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        // Verifica se o número é positivo ou negativo
        if (numero > 0)
        {
            a = numero;
        }
        else if (numero < 0)
        {
            b = numero;
        }

        // Mostra o resultado
        Console.WriteLine($"Número positivo (A): {a}");
        Console.WriteLine($"Número negativo (B): {b}");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
