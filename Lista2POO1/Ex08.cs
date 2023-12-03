using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Ex08
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira o raio da lata de óleo
            Console.Write("Digite o raio da lata de óleo: ");
            double raio = double.Parse(Console.ReadLine());

            // Solicita ao usuário que insira a altura da lata de óleo
            Console.Write("Digite a altura da lata de óleo: ");
            double altura = double.Parse(Console.ReadLine());

            // Calcula o volume da lata de óleo
            double volume = CalcularVolumeLataDeOleo(raio, altura);

            // Exibe o resultado
            Console.WriteLine($"O volume da lata de óleo é: {volume:F2} unidades cúbicas");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }
        // Função para calcular o volume da lata de óleo
        static double CalcularVolumeLataDeOleo(double raio, double altura)
        {
            return 3.14159 * raio * raio * altura;
        }
    }

