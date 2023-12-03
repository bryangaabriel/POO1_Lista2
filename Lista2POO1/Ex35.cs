using System;

public class Ex35
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex35");
        // Código do Ex35...
        // Loop para contar de 1 até 100
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);

            // Verifica se o número atual é um múltiplo de 10
            if (i % 10 == 0)
            {
                Console.WriteLine("Múltiplo de 10");
            }
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
