using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ex16
{
    public static void Executar()
    {
        // Solicita ao usuário que insira dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Verifica e exibe o maior e o menor número
        VerificarMaiorEMenor(numero1, numero2);

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para verificar o maior e o menor número
    static void VerificarMaiorEMenor(double a, double b)
    {
        if (a > b)
        {
            Console.WriteLine($"Maior número: {a}");
            Console.WriteLine($"Menor número: {b}");
        }
        else if (a < b)
        {
            Console.WriteLine($"Maior número: {b}");
            Console.WriteLine($"Menor número: {a}");
        }
        else
        {
            Console.WriteLine($"Os dois números são iguais: {a}");
        }
    }
}

