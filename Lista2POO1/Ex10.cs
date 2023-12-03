using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex10
{
    public static void Executar()
    {
        // Solicita ao usuário que insira dois números inteiros
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        // Verifica os relacionamentos de ordem
        VerificarRelacionamentos(numero1, numero2);

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
    // Função para verificar os relacionamentos de ordem
    static void VerificarRelacionamentos(int num1, int num2)
    {
        if (num1 == num2)
        {
            Console.WriteLine("Os números são iguais.");
        }
        else
        {
            Console.WriteLine("Os números são diferentes.");

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} é maior que {num2}.");
                Console.WriteLine($"{num2} é menor que {num1}.");
            }
            else
            {
                Console.WriteLine($"{num1} é menor que {num2}.");
                Console.WriteLine($"{num2} é maior que {num1}.");
            }
        }

        if (num1 >= num2)
        {
            Console.WriteLine($"{num1} é maior ou igual a {num2}.");
        }
        else
        {
            Console.WriteLine($"{num1} é menor ou igual a {num2}.");
        }
    }
}

