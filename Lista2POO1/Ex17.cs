using System;

public class Ex17
{
    public static void Executar()
    {
        // Solicita ao usu�rio que insira um n�mero inteiro
        Console.Write("Digite um n�mero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o n�mero est� na faixa entre 0 e 9
        if (numero >= 0 && numero <= 9)
        {
            Console.WriteLine("Valor v�lido");
        }
        else
        {
            Console.WriteLine("Valor inv�lido");
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
