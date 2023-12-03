using System;

public class Ex42
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex42");
        // C�digo do Ex42...
        Console.WriteLine("Digite uma sequ�ncia de n�meros. Digite 0 (ZERO) para encerrar.");

        // Inicializa as vari�veis de m�nimo e m�ximo
        int numero;
        int minimo = int.MaxValue; // Inicializado com o maior valor poss�vel para garantir que qualquer n�mero seja menor
        int maximo = int.MinValue; // Inicializado com o menor valor poss�vel para garantir que qualquer n�mero seja maior

        do
        {
            // Solicita ao usu�rio que insira um n�mero
            Console.Write("Digite um n�mero: ");
            numero = int.Parse(Console.ReadLine());

            // Verifica se o n�mero � diferente de zero antes de processar
            if (numero != 0)
            {
                // Atualiza o m�nimo e o m�ximo
                minimo = Math.Min(minimo, numero);
                maximo = Math.Max(maximo, numero);
            }

        } while (numero != 0);

        // Exibe o resultado
        Console.WriteLine($"O menor n�mero �: {minimo}");
        Console.WriteLine($"O maior n�mero �: {maximo}");
    }
}
