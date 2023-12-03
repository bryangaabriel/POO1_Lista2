using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex01
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira a quantidade mínima
            Console.Write("Digite a quantidade mínima de peças: ");
            int quantidadeMinima = int.Parse(Console.ReadLine());

            // Solicita ao usuário que insira a quantidade máxima
            Console.Write("Digite a quantidade máxima de peças: ");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            // Calcula o estoque médio
            double estoqueMedio = CalcularEstoqueMedio(quantidadeMinima, quantidadeMaxima);

            // Exibe o resultado
            Console.WriteLine($"O estoque médio é: {estoqueMedio}");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }

        // Função para calcular o estoque médio
        static double CalcularEstoqueMedio(int quantidadeMinima, int quantidadeMaxima)
        {
            return (quantidadeMinima + quantidadeMaxima) / 2.0;
        }

    }

