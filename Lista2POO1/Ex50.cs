using System;

public class Ex50
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex50");
        // C�digo do Ex50...
        // Gera um n�mero aleat�rio de 0 a 100
        Random random = new Random();
        int numeroSorteado = random.Next(101);

        // Vari�vel para armazenar a tentativa do usu�rio
        int tentativa;

        // Contador de tentativas
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o n�mero sorteado de 0 a 100.");

        do
        {
            Console.Write("Digite sua tentativa: ");
            tentativa = int.Parse(Console.ReadLine());

            // Incrementa o contador de tentativas
            tentativas++;

            // Verifica se a tentativa est� correta e informa se � maior ou menor
            if (tentativa < numeroSorteado)
            {
                Console.WriteLine("O n�mero sorteado � maior. Tente novamente.");
            }
            else if (tentativa > numeroSorteado)
            {
                Console.WriteLine("O n�mero sorteado � menor. Tente novamente.");
            }
            else
            {
                Console.WriteLine($"Parab�ns! Voc� acertou o n�mero {numeroSorteado} em {tentativas} tentativas.");
            }

        } while (tentativa != numeroSorteado);
    }
}
