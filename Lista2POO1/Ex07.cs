using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex07
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira a temperatura em graus Fahrenheit
            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            double temperaturaFahrenheit = double.Parse(Console.ReadLine());

            // Calcula a temperatura em graus Celsius
            double temperaturaCelsius = ConverterFahrenheitParaCelsius(temperaturaFahrenheit);

            // Exibe o resultado
            Console.WriteLine($"A temperatura em graus Celsius é: {temperaturaCelsius:F2} °C");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }
        // Função para converter temperatura de Fahrenheit para Celsius
        static double ConverterFahrenheitParaCelsius(double temperaturaFahrenheit)
        {
            return (temperaturaFahrenheit - 32) * 5 / 9;
        }
    }
