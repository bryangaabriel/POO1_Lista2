using System;

public class Ex19
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex19");
        // Código do Ex19...
        // Solicita ao usuário que insira os lados do triângulo
        Console.Write("Digite o lado A do triângulo: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o lado B do triângulo: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o lado C do triângulo: ");
        double c = double.Parse(Console.ReadLine());

        // Verifica se os lados formam um triângulo
        if (FormaTriangulo(a, b, c))
        {
            // Verifica o tipo de triângulo
            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os lados fornecidos não formam um triângulo.");
        }

        // Aguarda o usuário pressionar Enter antes de fechar a aplicação
        Console.ReadLine();
    }

    // Função para verificar se os lados formam um triângulo
    static bool FormaTriangulo(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

}
