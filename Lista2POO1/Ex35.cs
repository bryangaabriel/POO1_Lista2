using System;

public class Ex35
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex35");
        // C�digo do Ex35...
        // Loop para contar de 1 at� 100
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);

            // Verifica se o n�mero atual � um m�ltiplo de 10
            if (i % 10 == 0)
            {
                Console.WriteLine("M�ltiplo de 10");
            }
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
