using System;

public class Ex22
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex22");
        // C�digo do Ex22...
        int numero;
        int a = 0; // Vari�vel para armazenar n�meros positivos
        int b = 0; // Vari�vel para armazenar n�meros negativos

        // Solicita ao usu�rio que insira um n�mero
        Console.Write("Digite um n�mero: ");
        numero = int.Parse(Console.ReadLine());

        // Verifica se o n�mero � positivo ou negativo
        if (numero > 0)
        {
            a = numero;
        }
        else if (numero < 0)
        {
            b = numero;
        }

        // Mostra o resultado
        Console.WriteLine($"N�mero positivo (A): {a}");
        Console.WriteLine($"N�mero negativo (B): {b}");

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
