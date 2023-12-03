using System;

public class Ex50
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex50");
        // Código do Ex50...
        // Gera um número aleatório de 0 a 100
        Random random = new Random();
        int numeroSorteado = random.Next(101);

        // Variável para armazenar a tentativa do usuário
        int tentativa;

        // Contador de tentativas
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número sorteado de 0 a 100.");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = int.Parse(Console.ReadLine());

            // Incrementa o contador de tentativas
            tentativas++;

            // Verifica se a tentativa está correta e informa se é maior ou menor
            if (tentativa < numeroSorteado)
            {
                Console.WriteLine("O número sorteado é maior. Tente novamente.");
            }
            else if (tentativa > numeroSorteado)
            {
                Console.WriteLine("O número sorteado é menor. Tente novamente.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativas.");
            }

        } while (tentativa != numeroSorteado);
    }
}
