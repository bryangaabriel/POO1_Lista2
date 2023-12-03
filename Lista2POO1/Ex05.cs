using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex05
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira o tempo gasto na viagem em horas
            Console.Write("Digite o tempo gasto na viagem (em horas): ");
            double tempoGasto = double.Parse(Console.ReadLine());

            // Solicita ao usuário que insira a velocidade média em Km/h
            Console.Write("Digite a velocidade média (em Km/h): ");
            double velocidadeMedia = double.Parse(Console.ReadLine());

            // Calcula a distância percorrida
            double distanciaPercorrida = CalcularDistancia(tempoGasto, velocidadeMedia);

            // Calcula a quantidade de litros de combustível utilizada na viagem
            double litrosUsados = CalcularLitrosUsados(distanciaPercorrida);

            // Exibe os resultados
            Console.WriteLine($"Velocidade Média: {velocidadeMedia} Km/h");
            Console.WriteLine($"Tempo Gasto: {tempoGasto} horas");
            Console.WriteLine($"Distância Percorrida: {distanciaPercorrida} Km");
            Console.WriteLine($"Quantidade de Litros Utilizada: {litrosUsados:F2} litros");

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }

        // Função para calcular a distância percorrida
        static double CalcularDistancia(double tempo, double velocidade)
        {
            return tempo * velocidade;
        }

        // Função para calcular a quantidade de litros de combustível utilizada
        static double CalcularLitrosUsados(double distancia)
        {
            // Considerando que o carro faz 12 Km por litro
            return distancia / 12.0;
        }
    }