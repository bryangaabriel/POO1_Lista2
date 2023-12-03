using System;

class Menu
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("Escolha um exercício (1 a 64) para executar ou 0 para sair:");
            Console.WriteLine("\nMenu de Códigos:");
            Console.WriteLine("1 - Calcular estoque médio de uma peça");
            Console.WriteLine("2 - Conversão de dólar para real");
            Console.WriteLine("3 - Pagamento de comissão de vendedores de peças");
            Console.WriteLine("4 - Adição e multiplicação de quatro valores inteiros");
            Console.WriteLine("5 - Cálculo de quantidade de litros de combustível em uma viagem");
            Console.WriteLine("6 - Conversão de temperatura de Celsius para Fahrenheit");
            Console.WriteLine("7 - Conversão de temperatura de Fahrenheit para Celsius");
            Console.WriteLine("8 - Cálculo do volume de uma lata de óleo");
            Console.WriteLine("9 - Cálculo da idade em dias");
            Console.WriteLine("10 - Relacionamentos de ordem entre dois números inteiros");
            Console.WriteLine("11 - Troca de valores entre duas variáveis");
            Console.WriteLine("12 - Cálculo do módulo de um número inteiro");
            Console.WriteLine("13 - Impressão de três números inteiros em ordem decrescente");
            Console.WriteLine("14 - Diferença entre o maior e o menor de dois números");
            Console.WriteLine("15 - Verificação da aprovação do aluno com possibilidade de recuperação");
            Console.WriteLine("16 - Identificação do maior e menor número entre dois valores");
            Console.WriteLine("17 - Verificação se um número está na faixa de 0 a 9");
            Console.WriteLine("18 - Impressão do valor por extenso de um código");
            Console.WriteLine("19 - Classificação de um triângulo (equilátero, isósceles, escaleno)");
            Console.WriteLine("20 - Operações com três variáveis (maior, menor, média)");
            Console.WriteLine("21 - Verificação se um número é positivo ou negativo");
            Console.WriteLine("22 - Armazenamento de número positivo em variáveis distintas");
            Console.WriteLine("23 - Menu de operações matemáticas");
            Console.WriteLine("24 - Menu de verificações com dois números");
            Console.WriteLine("25 - Cálculo do peso ideal (homem ou mulher)");
            Console.WriteLine("26 - Impressão dos números de 1 a 100 em ordem decrescente");
            Console.WriteLine("27 - Cálculo do fatorial de uma sequência de números");
            Console.WriteLine("28 - Impressão de números ímpares entre 100 e 200");
            Console.WriteLine("29 - Impressão dos números de 1 a 2000");
            Console.WriteLine("30 - Impressão de uma tabuada");
            Console.WriteLine("31 - Leitura de números e verificação de paridade");
            Console.WriteLine("32 - Cálculo da soma dos quadrados dos números ímpares");
            Console.WriteLine("33 - Cálculo da média da nota dos alunos");
            Console.WriteLine("34 - Impressão do maior e do menor número de um conjunto");
            Console.WriteLine("35 - Impressão de mensagem a cada múltiplo de 10");
            Console.WriteLine("36 - Leitura de 10 valores e cálculos diversos");
            Console.WriteLine("37 - Conversão de base numérica com menu");
            Console.WriteLine("38 - Cálculo do salário com horas extras");
            Console.WriteLine("39 - Verificação de paridade e sinal de um número");
            Console.WriteLine("40 - Notificação de empresas por índice de poluição");
            Console.WriteLine("41 - Classificação de nadadores por idade");
            Console.WriteLine("42 - Determinação do maior e menor entre N números");
            Console.WriteLine("43 - Cálculo do número de grãos em um tabuleiro de xadrez");
            Console.WriteLine("44 - Menu de conversões e cálculos diversos");
            Console.WriteLine("45 - Impressão de frase sem espaços em branco");
            Console.WriteLine("46 - Produto escalar de dois vetores");
            Console.WriteLine("47 - Comparação de elementos em duas posições de vetores");
            Console.WriteLine("48 - Seleção de candidatas por faixa etária");
            Console.WriteLine("49 - Contagem de elementos idênticos em posições correspondentes de vetores");
            Console.WriteLine("50 - Jogo de adivinhação de número");
            Console.WriteLine("51 - Cálculo da média e contagem de notas acima de 7.0");
            Console.WriteLine("52 - Contagem de ocorrências dos números 1, 3 e 4 em um vetor");
            Console.WriteLine("53 - Cálculo do melhor tempo em uma corrida de automóveis");
            Console.WriteLine("54 - Impressão dos elementos comuns a dois vetores");
            Console.WriteLine("55 - Impressão de vogais em uma frase");
            Console.WriteLine("56 - Contagem de números pares e múltiplos de 5 em um vetor");
            Console.WriteLine("57 - Impressão de vogais em uma frase");
            Console.WriteLine("58 - Cálculo da média e impressão do maior em um vetor");
            Console.WriteLine("59 - Contagem de caracteres entre dois caracteres alfabéticos");
            Console.WriteLine("60 - Verificação do quadrante através de método");
            Console.WriteLine("61 - Cálculo do salário com reajuste através de método");
            Console.WriteLine("62 - Cálculo da hipotenusa e área de um triângulo através de método");
            Console.WriteLine("63 - Verificação se um número é par ou ímpar através de método");
            Console.WriteLine("64 - Menu com operações em um vetor");
            Console.WriteLine("0 - Para sair do programa");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo do programa. Até mais!");
                        break;
                    case 1:
                        Ex01.Executar();
                        break;
                    case 2:
                        Ex02.Executar();
                        break;
                    case 3:
                        Ex03.Executar();
                        break;
                    case 4:
                        Ex04.Executar();
                        break;
                    case 5:
                        Ex05.Executar();
                        break;
                    case 6:
                        Ex06.Executar();
                        break;
                    case 7:
                        Ex07.Executar();
                        break;
                    case 8:
                        Ex08.Executar();
                        break;
                    case 9:
                        Ex09.Executar();
                        break;
                    case 10:
                        Ex10.Executar();
                        break;
                    case 11:
                        Ex11.Executar();
                        break;
                    case 12:
                        Ex12.Executar();
                        break;
                    case 13:
                        Ex13.Executar();
                        break;
                    case 14:
                        Ex14.Executar();
                        break;
                    case 15:
                        Ex15.Executar();
                        break;
                    case 16:
                        Ex16.Executar();
                        break;
                    case 17:
                        Ex17.Executar();
                        break;
                    case 18:
                        Ex18.Executar();
                        break;
                    case 19:
                        Ex19.Executar();
                        break;
                    case 20:
                        Ex20.Executar();
                        break;
                    case 21:
                        Ex21.Executar();
                        break;
                    case 22:
                        Ex22.Executar();
                        break;
                    case 23:
                        Ex23.Executar();
                        break;
                    case 24:
                        Ex24.Executar();
                        break;
                    case 25:
                        Ex25.Executar();
                        break;
                    case 26:
                        Ex26.Executar();
                        break;
                    case 27:
                        Ex27.Executar();
                        break;
                    case 28:
                        Ex28.Executar();
                        break;
                    case 29:
                        Ex29.Executar();
                        break;
                    case 30:
                        Ex30.Executar();
                        break;
                    case 31:
                        Ex31.Executar();
                        break;
                    case 32:
                        Ex32.Executar();
                        break;
                    case 33:
                        Ex33.Executar();
                        break;
                    case 34:
                        Ex34.Executar();
                        break;
                    case 35:
                        Ex35.Executar();
                        break;
                    case 36:
                        Ex36.Executar();
                        break;
                    case 37:
                        Ex37.Executar();
                        break;
                    case 38:
                        Ex38.Executar();
                        break;
                    case 39:
                        Ex39.Executar();
                        break;
                    case 40:
                        Ex40.Executar();
                        break;
                    case 41:
                        Ex41.Executar();
                        break;
                    case 42:
                        Ex42.Executar();
                        break;
                    case 43:
                        Ex43.Executar();
                        break;
                    case 44:
                        Ex44.Executar();
                        break;
                    case 45:
                        Ex45.Executar();
                        break;
                    case 46:
                        Ex46.Executar();
                        break;
                    case 47:
                        Ex47.Executar();
                        break;
                    case 48:
                        Ex48.Executar();
                        break;
                    case 49:
                        Ex49.Executar();
                        break;
                    case 50:
                        Ex50.Executar();
                        break;
                    case 51:
                        Ex51.Executar();
                        break;
                    case 52:
                        Ex52.Executar();
                        break;
                    case 53:
                        Ex53.Executar();
                        break;
                    case 54:
                        Ex54.Executar();
                        break;
                    case 55:
                        Ex55.Executar();
                        break;
                    case 56:
                        Ex56.Executar();
                        break;
                    case 57:
                        Ex57.Executar();
                        break;
                    case 58:
                        Ex58.Executar();
                        break;
                    case 59:
                        Ex59.Executar();
                        break;
                    case 60:
                        Ex60.Executar();
                        break;
                    case 61:
                        Ex61.Executar();
                        break;
                    case 62:
                        Ex62.Executar();
                        break;
                    case 63:
                        Ex63.Executar();
                        break;
                    case 64:
                        Ex64.Executar();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine();
        } while (opcao != 0);
    }
}
