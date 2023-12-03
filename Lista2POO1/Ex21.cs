using System;

public class Ex21
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex21");
        // Código do Ex21...
        int numero;

        do
        {
            // Solicita ao usuário que insira um número inteiro
            Console.Write("Digite um número inteiro (ou zero para encerrar): ");
            numero = int.Parse(Console.ReadLine());

            // Verifica se o número é positivo, negativo ou zero
            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }
            else
            {
                Console.WriteLine("O número é zero. Encerrando o programa...");
            }

        } while (numero != 0);

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
