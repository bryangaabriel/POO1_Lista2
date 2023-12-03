using System;

public class Ex21
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex21");
        // C�digo do Ex21...
        int numero;

        do
        {
            // Solicita ao usu�rio que insira um n�mero inteiro
            Console.Write("Digite um n�mero inteiro (ou zero para encerrar): ");
            numero = int.Parse(Console.ReadLine());

            // Verifica se o n�mero � positivo, negativo ou zero
            if (numero > 0)
            {
                Console.WriteLine("O n�mero � positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O n�mero � negativo.");
            }
            else
            {
                Console.WriteLine("O n�mero � zero. Encerrando o programa...");
            }

        } while (numero != 0);

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
