using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ex04
    {
        public static void Executar()
        {
            // Solicita ao usuário que insira quatro valores inteiros
            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            // Realiza as operações de adição e multiplicação dois a dois
            RealizarOperacoes(a, b, c, d);

            // Aguarda o usuário pressionar Enter antes de fechar a aplicação
            Console.ReadLine();
        }
        // Função para realizar as operações de adição e multiplicação dois a dois
        static void RealizarOperacoes(int a, int b, int c, int d)
        {
            // Adições
            Console.WriteLine($"Adição: A + B = {a + b}");
            Console.WriteLine($"Adição: A + C = {a + c}");
            Console.WriteLine($"Adição: A + D = {a + d}");
            Console.WriteLine($"Adição: B + C = {b + c}");
            Console.WriteLine($"Adição: B + D = {b + d}");
            Console.WriteLine($"Adição: C + D = {c + d}");

            // Multiplicações
            Console.WriteLine($"Multiplicação: A * B = {a * b}");
            Console.WriteLine($"Multiplicação: A * C = {a * c}");
            Console.WriteLine($"Multiplicação: A * D = {a * d}");
            Console.WriteLine($"Multiplicação: B * C = {b * c}");
            Console.WriteLine($"Multiplicação: B * D = {b * d}");
            Console.WriteLine($"Multiplicação: C * D = {c * d}");
        }

    }