using System;

public class Ex19
{
    public static void Executar()
    {
        Console.WriteLine("Executando o Ex19");
        // C�digo do Ex19...
        // Solicita ao usu�rio que insira os lados do tri�ngulo
        Console.Write("Digite o lado A do tri�ngulo: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o lado B do tri�ngulo: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o lado C do tri�ngulo: ");
        double c = double.Parse(Console.ReadLine());

        // Verifica se os lados formam um tri�ngulo
        if (FormaTriangulo(a, b, c))
        {
            // Verifica o tipo de tri�ngulo
            if (a == b && b == c)
            {
                Console.WriteLine("Tri�ngulo Equil�tero");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Tri�ngulo Is�sceles");
            }
            else
            {
                Console.WriteLine("Tri�ngulo Escaleno");
            }
        }
        else
        {
            Console.WriteLine("Os lados fornecidos n�o formam um tri�ngulo.");
        }

        // Aguarda o usu�rio pressionar Enter antes de fechar a aplica��o
        Console.ReadLine();
    }

    // Fun��o para verificar se os lados formam um tri�ngulo
    static bool FormaTriangulo(double a, double b, double c)
    {
        return (a + b > c) && (a + c > b) && (b + c > a);
    }

}
