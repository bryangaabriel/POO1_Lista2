using System;

public class Ex42
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex42");
        // Código do Ex42...
        Console.WriteLine("Digite uma sequência de números. Digite 0 (ZERO) para encerrar.");

        // Inicializa as variáveis de mínimo e máximo
        int numero;
        int minimo = int.MaxValue; // Inicializado com o maior valor possível para garantir que qualquer número seja menor
        int maximo = int.MinValue; // Inicializado com o menor valor possível para garantir que qualquer número seja maior

        do
        {
            // Solicita ao usuário que insira um número
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            // Verifica se o número é diferente de zero antes de processar
            if (numero != 0)
            {
                // Atualiza o mínimo e o máximo
                minimo = Math.Min(minimo, numero);
                maximo = Math.Max(maximo, numero);
            }

        } while (numero != 0);

        // Exibe o resultado
        Console.WriteLine($"O menor número é: {minimo}");
        Console.WriteLine($"O maior número é: {maximo}");
    }
}
