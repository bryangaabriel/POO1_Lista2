using System;

public class Ex39
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex39");
        // Código do Ex39...
        char resposta;

        do
        {
            // Solicita ao usuário que insira um número inteiro
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o número é par ou ímpar e se é positivo ou negativo
            VerificarParImparPositivoNegativo(numero);

            // Pergunta ao usuário se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Função para verificar se um número é par ou ímpar e se é positivo ou negativo
    static void VerificarParImparPositivoNegativo(int numero)
    {
        // Verifica se o número é par ou ímpar
        string parImpar = (numero % 2 == 0) ? "par" : "ímpar";

        // Verifica se o número é positivo, negativo ou zero
        string positivoNegativo = (numero > 0) ? "positivo" : (numero < 0) ? "negativo" : "zero";

        // Exibe a mensagem com as informações sobre o número
        Console.WriteLine($"O número {numero} é {parImpar} e {positivoNegativo}.");
    }
}
