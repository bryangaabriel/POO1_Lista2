using System;

public class Ex39
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex39");
        // C�digo do Ex39...
        char resposta;

        do
        {
            // Solicita ao usu�rio que insira um n�mero inteiro
            Console.Write("Digite um n�mero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            // Verifica se o n�mero � par ou �mpar e se � positivo ou negativo
            VerificarParImparPositivoNegativo(numero);

            // Pergunta ao usu�rio se deseja encerrar o programa
            Console.Write("Deseja encerrar o programa? (S/n): ");
            resposta = char.Parse(Console.ReadLine());

        } while (resposta != 'S' && resposta != 's');
    }

    // Fun��o para verificar se um n�mero � par ou �mpar e se � positivo ou negativo
    static void VerificarParImparPositivoNegativo(int numero)
    {
        // Verifica se o n�mero � par ou �mpar
        string parImpar = (numero % 2 == 0) ? "par" : "�mpar";

        // Verifica se o n�mero � positivo, negativo ou zero
        string positivoNegativo = (numero > 0) ? "positivo" : (numero < 0) ? "negativo" : "zero";

        // Exibe a mensagem com as informa��es sobre o n�mero
        Console.WriteLine($"O n�mero {numero} � {parImpar} e {positivoNegativo}.");
    }
}
