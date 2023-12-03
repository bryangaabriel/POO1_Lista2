using System;

public class Ex34
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex34");
        // C�digo do Ex34...
        int numero;
        int menor = int.MaxValue; // Inicializado com o maior valor poss�vel para garantir que o primeiro n�mero seja menor
        int maior = int.MinValue; // Inicializado com o menor valor poss�vel para garantir que o primeiro n�mero seja maior

        // Loop para ler n�meros positivos at� que um n�mero negativo seja inserido
        do
        {
            Console.Write("Digite um n�mero (ou um n�mero negativo para encerrar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                // Atualiza o menor e o maior n�mero
                menor = Math.Min(menor, numero);
                maior = Math.Max(maior, numero);
            }

        } while (numero >= 0);

        // Verifica se pelo menos um n�mero positivo foi inserido antes de exibir o resultado
        if (menor != int.MaxValue && maior != int.MinValue)
        {
            // Exibe o menor e o maior n�mero
            Console.WriteLine($"O menor n�mero �: {menor}");
            Console.WriteLine($"O maior n�mero �: {maior}");
        }
        else
        {
            Console.WriteLine("Nenhum n�mero positivo foi inserido.");
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }
}
