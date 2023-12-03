using System;

public class Ex18
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex18");
        // C�digo do Ex18...
        // Solicita ao usu�rio que insira um n�mero inteiro
        Console.Write("Digite um c�digo (1, 2 ou 3): ");
        int codigo = int.Parse(Console.ReadLine());

        // Verifica se o c�digo � 1, 2 ou 3 usando switch
        switch (codigo)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Tr�s");
                break;
            default:
                Console.WriteLine("C�digo inv�lido");
                break;
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
