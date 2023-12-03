using System;

public class Ex31
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex31");
        // Código do Ex31...
        int numero;
        int somaPares = 0;
        int somaImpares = 0;

        // Loop para ler números positivos até que um número negativo seja inserido
        do
        {
            Console.Write("Digite um número (ou um número negativo para encerrar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                // Verifica se o número é par ou ímpar e atualiza as somas
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} é par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine($"{numero} é ímpar.");
                    somaImpares += numero;
                }
            }

        } while (numero >= 0);

        // Exibe as somas total de números pares e ímpares
        Console.WriteLine($"Soma dos números pares: {somaPares}");
        Console.WriteLine($"Soma dos números ímpares: {somaImpares}");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
