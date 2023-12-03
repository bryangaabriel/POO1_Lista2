using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex13
{
    public static void Executar()
    {
        // Solicita ao usuário que insira três números inteiros
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número inteiro: ");
        int numero3 = int.Parse(Console.ReadLine());

        // Ordena os números em ordem decrescente e os imprime
        ImprimirEmOrdemDecrescente(numero1, numero2, numero3);

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
    /// Função para imprimir três números em ordem decrescente
    static void ImprimirEmOrdemDecrescente(int a, int b, int c)
    {
        // Usando a função Sort para ordenar os números
        int[] numeros = { a, b, c };
        Array.Sort(numeros);
        Array.Reverse(numeros);

        // Imprime os números em ordem decrescente
        Console.WriteLine($"Números em ordem decrescente: {numeros[0]}, {numeros[1]}, {numeros[2]}");
    }
}

