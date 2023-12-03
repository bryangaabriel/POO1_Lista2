using System;

public class Ex31
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex31");
        // C�digo do Ex31...
        int numero;
        int somaPares = 0;
        int somaImpares = 0;

        // Loop para ler n�meros positivos at� que um n�mero negativo seja inserido
        do
        {
            Console.Write("Digite um n�mero (ou um n�mero negativo para encerrar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                // Verifica se o n�mero � par ou �mpar e atualiza as somas
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"{numero} � par.");
                    somaPares += numero;
                }
                else
                {
                    Console.WriteLine($"{numero} � �mpar.");
                    somaImpares += numero;
                }
            }

        } while (numero >= 0);

        // Exibe as somas total de n�meros pares e �mpares
        Console.WriteLine($"Soma dos n�meros pares: {somaPares}");
        Console.WriteLine($"Soma dos n�meros �mpares: {somaImpares}");

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
