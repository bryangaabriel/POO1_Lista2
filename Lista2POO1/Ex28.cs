using System;

public class Ex28
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex28");
        // C�digo do Ex28...
        // Loop para gerar e escrever os n�meros �mpares entre 100 e 200
        for (int i = 101; i <= 199; i += 2)
        {
            Console.WriteLine(i);
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
