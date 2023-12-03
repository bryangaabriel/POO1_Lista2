using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex06
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira a temperatura em graus Celsius
            Console.Write("Digite a temperatura em graus Celsius: ");
            double temperaturaCelsius = double.Parse(Console.ReadLine());

            // Calcula a temperatura em graus Fahrenheit
            double temperaturaFahrenheit = ConverterCelsiusParaFahrenheit(temperaturaCelsius);

            // Exibe o resultado
            Console.WriteLine($"A temperatura em graus Fahrenheit é: {temperaturaFahrenheit:F2} °F");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }
        // Função para converter temperatura de Celsius para Fahrenheit
        static double ConverterCelsiusParaFahrenheit(double temperaturaCelsius)
        {
            return (9 * temperaturaCelsius + 160) / 5;
        }
    }

