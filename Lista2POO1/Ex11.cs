using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex11
{
    public static void Executar()
    {
        // Solicita ao usuário que insira dois números inteiros
        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        // Troca os valores entre as variáveis A e B
        TrocarValores(ref a, ref b);

        // Exibe os valores trocados
        Console.WriteLine($"Valores trocados: A = {a}, B = {b}");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
    // Função para trocar os valores entre duas variáveis
    static void TrocarValores(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}



