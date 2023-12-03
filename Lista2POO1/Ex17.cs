using System;

public class Ex17
{
    public static void Executar()
    {
        // Solicita ao usuário que insira um número inteiro
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número está na faixa entre 0 e 9
        if (numero >= 0 && numero <= 9)
        {
            Console.WriteLine("Valor válido");
        }
        else
        {
            Console.WriteLine("Valor inválido");
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
