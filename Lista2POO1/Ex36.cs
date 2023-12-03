using System;

public class Ex36
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex36");
        // C�digo do Ex36...
        int quantidadeValores = 10;
        int[] valores = new int[quantidadeValores];

        // Loop para ler 10 valores inteiros e positivos
        for (int i = 0; i < quantidadeValores; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());

            // Verifica se o valor � positivo
            while (valores[i] <= 0)
            {
                Console.WriteLine("Por favor, digite um valor inteiro e positivo.");
                Console.Write($"Digite o valor {i + 1} novamente: ");
                valores[i] = int.Parse(Console.ReadLine());
            }
        }

        // Encontra o maior valor
        int maior = EncontrarMaiorValor(valores);

        // Encontra o menor valor
        int menor = EncontrarMenorValor(valores);

        // Calcula a m�dia dos n�meros lidos
        double media = CalcularMedia(valores);

        // Exibe os resultados
        Console.WriteLine($"O maior valor �: {maior}");
        Console.WriteLine($"O menor valor �: {menor}");
        Console.WriteLine($"A m�dia dos valores �: {media}");

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para encontrar o maior valor em um array de inteiros
    static int EncontrarMaiorValor(int[] array)
    {
        int maior = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maior)
            {
                maior = array[i];
            }
        }

        return maior;
    }

    // Fun��o para encontrar o menor valor em um array de inteiros
    static int EncontrarMenorValor(int[] array)
    {
        int menor = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < menor)
            {
                menor = array[i];
            }
        }

        return menor;
    }

    // Fun��o para calcular a m�dia de um array de inteiros
    static double CalcularMedia(int[] array)
    {
        double soma = 0;

        foreach (int valor in array)
        {
            soma += valor;
        }

        return soma / array.Length;
    }
}
