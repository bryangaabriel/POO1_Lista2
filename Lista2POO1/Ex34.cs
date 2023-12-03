using System;

public class Ex34
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex34");
        // Código do Ex34...
        int numero;
        int menor = int.MaxValue; // Inicializado com o maior valor possível para garantir que o primeiro número seja menor
        int maior = int.MinValue; // Inicializado com o menor valor possível para garantir que o primeiro número seja maior

        // Loop para ler números positivos até que um número negativo seja inserido
        do
        {
            Console.Write("Digite um número (ou um número negativo para encerrar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                // Atualiza o menor e o maior número
                menor = Math.Min(menor, numero);
                maior = Math.Max(maior, numero);
            }

        } while (numero >= 0);

        // Verifica se pelo menos um número positivo foi inserido antes de exibir o resultado
        if (menor != int.MaxValue && maior != int.MinValue)
        {
            // Exibe o menor e o maior número
            Console.WriteLine($"O menor número é: {menor}");
            Console.WriteLine($"O maior número é: {maior}");
        }
        else
        {
            Console.WriteLine("Nenhum número positivo foi inserido.");
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
}
