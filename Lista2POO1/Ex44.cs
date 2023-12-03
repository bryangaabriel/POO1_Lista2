using System;

public class Ex44
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex44");
        // Código do Ex44...
        char resposta;

        do
        {
            // Exibe as opções do programa
            ExibirOpcoes();

            // Solicita ao usuário que escolha uma opção
            Console.Write("Escolha uma opção (1, 2, 3, 4) ou 'S' para encerrar: ");
            resposta = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine(); // Pula uma linha após a escolha

            // Executa a opção escolhida
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
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        } while (resposta != 'S');
    }

    // Função para exibir as opções do programa
    static void ExibirOpcoes()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Conversão de Graus Celsius em Graus Fahrenheit");
        Console.WriteLine("2 - Conversão de Graus Fahrenheit em Graus Celsius");
        Console.WriteLine("3 - Peso ideal do homem");
        Console.WriteLine("4 - Peso ideal da mulher");
    }

    // Função para a conversão de Celsius para Fahrenheit
    static void ConversaoCelsiusParaFahrenheit()
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"A temperatura em graus Fahrenheit é: {fahrenheit:F2}°F");
    }

    // Função para a conversão de Fahrenheit para Celsius
    static void ConversaoFahrenheitParaCelsius()
    {
        Console.Write("Digite a temperatura em graus Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"A temperatura em graus Celsius é: {celsius:F2}°C");
    }

    // Função para calcular o peso ideal do homem
    static void PesoIdealHomem()
    {
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double pesoIdeal = 72.7 * altura - 58;

        Console.Write($"O peso ideal para um homem com {altura:F2} metros é: {pesoIdeal:F2} kg. ");

        // Verifica se o usuário está acima ou abaixo do peso ideal
        VerificarPesoIdeal(pesoIdeal);
    }

    // Função para calcular o peso ideal da mulher
    static void PesoIdealMulher()
    {
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        double pesoIdeal = 62.1 * altura - 44.7;

        Console.Write($"O peso ideal para uma mulher com {altura:F2} metros é: {pesoIdeal:F2} kg. ");

        // Verifica se a usuária está acima ou abaixo do peso ideal
        VerificarPesoIdeal(pesoIdeal);
    }

    // Função para verificar se o usuário está acima ou abaixo do peso ideal
    static void VerificarPesoIdeal(double pesoIdeal)
    {
        Console.Write("Digite o peso atual: ");
        double pesoAtual = double.Parse(Console.ReadLine());

        if (pesoAtual < pesoIdeal)
        {
            Console.WriteLine("Você está abaixo do peso ideal.");
        }
        else if (pesoAtual > pesoIdeal)
        {
            Console.WriteLine("Você está acima do peso ideal.");
        }
        else
        {
            Console.WriteLine("Você está no peso ideal.");
        }
    }
}
