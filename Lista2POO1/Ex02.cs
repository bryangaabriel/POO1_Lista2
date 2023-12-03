using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex02
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira a cotação do dólar
            Console.Write("Digite a cotação do dólar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            // Solicita ao usuário que insira o valor em dólares
            Console.Write("Digite o valor em dólares: ");
            double valorDolar = double.Parse(Console.ReadLine());

            // Calcula o valor em reais
            double valorReal = ConverterDolarParaReal(valorDolar, cotacaoDolar);

            // Exibe o resultado
            Console.WriteLine($"O valor em reais é: {valorReal:C}");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }
        // Função para converter dólares para reais
        static double ConverterDolarParaReal(double valorDolar, double cotacaoDolar)
        {
            return valorDolar * cotacaoDolar;
        }
    }