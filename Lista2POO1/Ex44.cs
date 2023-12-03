using System;

public class Ex44
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex44");
        // C�digo do Ex44...
        char resposta;

        do
        {
            // Exibe as op��es do programa
            ExibirOpcoes();

            // Solicita ao usu�rio que escolha uma op��o
            Console.Write("Escolha uma op��o (1, 2, 3, 4) ou 'S' para encerrar: ");
            resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Pula uma linha ap�s a escolha

            // Executa a op��o escolhida
            switch (resposta)
            {
                case '1':
                    ConversaoCelsiusParaFahrenheit();
                    break;
                case '2':
                    ConversaoFahrenheitParaCelsius();
                    break;
                case '3':
                    PesoIdealHomem();
                    break;
                case '4':
                    PesoIdealMulher();
                    break;
                case 'S':
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Op��o inv�lida. Tente novamente.");
                    break;
            }

        } while (resposta != 'S');
    }

    // Fun��o para exibir as op��es do programa
    static void ExibirOpcoes()
    {
        Console.WriteLine("Escolha uma op��o:");
        Console.WriteLine("1 - Convers�o de Graus Celsius em Graus Fahrenheit");
        Console.WriteLine("2 - Convers�o de Graus Fahrenheit em Graus Celsius");
        Console.WriteLine("3 - Peso ideal do homem");
        Console.WriteLine("4 - Peso ideal da mulher");
    }

    // Fun��o para a convers�o de Celsius para Fahrenheit
    static void ConversaoCelsiusParaFahrenheit()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"A temperatura em graus Fahrenheit �: {fahrenheit:F2}�F");
    }

    // Fun��o para a convers�o de Fahrenheit para Celsius
    static void ConversaoFahrenheitParaCelsius()
    {
        Console.Write("Digite a temperatura em graus Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"A temperatura em graus Celsius �: {celsius:F2}�C");
    }

    // Fun��o para calcular o peso ideal do homem
    static void PesoIdealHomem()
    {
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double pesoIdeal = 72.7 * altura - 58;

        Console.Write($"O peso ideal para um homem com {altura:F2} metros �: {pesoIdeal:F2} kg. ");

        // Verifica se o usu�rio est� acima ou abaixo do peso ideal
        VerificarPesoIdeal(pesoIdeal);
    }

    // Fun��o para calcular o peso ideal da mulher
    static void PesoIdealMulher()
    {
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double pesoIdeal = 62.1 * altura - 44.7;

        Console.Write($"O peso ideal para uma mulher com {altura:F2} metros �: {pesoIdeal:F2} kg. ");

        // Verifica se a usu�ria est� acima ou abaixo do peso ideal
        VerificarPesoIdeal(pesoIdeal);
    }

    // Fun��o para verificar se o usu�rio est� acima ou abaixo do peso ideal
    static void VerificarPesoIdeal(double pesoIdeal)
    {
        Console.Write("Digite o peso atual: ");
        double pesoAtual = double.Parse(Console.ReadLine());

        if (pesoAtual < pesoIdeal)
        {
            Console.WriteLine("Voc� est� abaixo do peso ideal.");
        }
        else if (pesoAtual > pesoIdeal)
        {
            Console.WriteLine("Voc� est� acima do peso ideal.");
        }
        else
        {
            Console.WriteLine("Voc� est� no peso ideal.");
        }
    }
}
