using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex12
{
    public static void Executar()
    {
        // Solicita ao usuário que insira um número inteiro
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Calcula e exibe o módulo do número
        int modulo = CalcularModulo(numero);
        Console.WriteLine($"O módulo do número é: {modulo}");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
    /// Função para calcular o módulo de um número
    static int CalcularModulo(int x)
    {
        return x >= 0 ? x : x * (-1);
    }
}

