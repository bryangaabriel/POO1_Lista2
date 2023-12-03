using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex14
{
    public static void Executar()
    {
        // Solicita ao usuário que insira dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Calcula e exibe a diferença do maior para o menor
        double diferenca = CalcularDiferenca(numero1, numero2);
        Console.WriteLine($"A diferença do maior para o menor é: {diferenca}");

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }
    // Função para calcular a diferença do maior para o menor
    static double CalcularDiferenca(double a, double b)
    {
        // Encontra o maior e o menor número
        double maior = Math.Max(a, b);
        double menor = Math.Min(a, b);

        // Calcula a diferença
        double diferenca = maior - menor;
        return diferenca;
    }
}

