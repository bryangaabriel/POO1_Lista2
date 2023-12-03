using System;

public class Ex36
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex36");
        // Código do Ex36...
        int quantidadeValores = 10;
        int[] valores = new int[quantidadeValores];

        // Loop para ler 10 valores inteiros e positivos
        for (int i = 0; i < quantidadeValores; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            valores[i] = int.Parse(Console.ReadLine());

            // Verifica se o valor é positivo
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

        // Calcula a média dos números lidos
        double media = CalcularMedia(valores);

        // Exibe os resultados
        Console.WriteLine($"O maior valor é: {maior}");
        Console.WriteLine($"O menor valor é: {menor}");
        Console.WriteLine($"A média dos valores é: {media}");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para encontrar o maior valor em um array de inteiros
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

    // Função para encontrar o menor valor em um array de inteiros
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

    // Função para calcular a média de um array de inteiros
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
