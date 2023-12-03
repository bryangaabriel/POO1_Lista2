using System;

public class Ex52
{
    public static void Executar()
    {
        const int tamanhoMaximo = 100;

        // Vetor para armazenar os n�meros
        int[] vetor = new int[tamanhoMaximo];

        // Vari�veis para contar as ocorr�ncias de 1, 3 e 4
        int ocorrencias1 = 0;
        int ocorrencias3 = 0;
        int ocorrencias4 = 0;

        // Preenche o vetor com n�meros at� que seja digitado -1
        int posicao = 0;
        int numero;

        Console.WriteLine("Digite os n�meros (digite -1 para sair):");

        do
        {
            Console.Write($"N�mero {posicao + 1}: ");
            numero = int.Parse(Console.ReadLine());

            if (numero == -1)
            {
                break;
            }

            vetor[posicao] = numero;
            posicao++;
        } while (posicao < tamanhoMaximo);

        // Conta as ocorr�ncias de 1, 3 e 4 no vetor
        for (int i = 0; i < posicao; i++)
        {
            if (vetor[i] == 1)
            {
                ocorrencias1++;
            }
            else if (vetor[i] == 3)
            {
                ocorrencias3++;
            }
            else if (vetor[i] == 4)
            {
                ocorrencias4++;
            }
        }

        // Imprime o resultado
        Console.WriteLine($"\nOcorr�ncias de 1: {ocorrencias1}");
        Console.WriteLine($"Ocorr�ncias de 3: {ocorrencias3}");
        Console.WriteLine($"Ocorr�ncias de 4: {ocorrencias4}");
    }
}
