using System;

public class Ex28
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex28");
        // Código do Ex28...
        // Loop para gerar e escrever os números ímpares entre 100 e 200
        for (int i = 101; i <= 199; i += 2)
        {
            Console.WriteLine(i);
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
