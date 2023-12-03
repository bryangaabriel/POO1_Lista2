using System;

public class Ex18
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex18");
        // Código do Ex18...
        // Solicita ao usuário que insira um número inteiro
        Console.Write("Digite um código (1, 2 ou 3): ");
        int codigo = int.Parse(Console.ReadLine());

        // Verifica se o código é 1, 2 ou 3 usando switch
        switch (codigo)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default:
                Console.WriteLine("Código inválido");
                break;
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
